using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using JsonJasperConverter.Attributes;
using JsonJasperConverter.JasperModels;
using JsonJasperConverter.JasperModels.BaseJasper;
using JsonJasperConverter.JasperModels.JasperBasicElements;
using JsonJasperConverter.JasperModels.JasperProperties;
using JsonJasperConverter.Models;

namespace JsonJasperConverter.Extensions
{
    public static class JasperExtension
    {
        public static string ConvertFrameToJasper(this Frame frame)
        {
            var report = JasperReport.CreateBase();
            report.PageWidth = frame.Width.ToPixelSize();
            report.ColumnWidth = frame.Width.ToPixelSize();
            report.PageHeight = frame.Height.ToPixelSize();
            report.BottomMargin = frame.BottomMargin;
            report.TopMargin = frame.TopMargin;
            report.LeftMargin = frame.LeftMargin;
            report.RightMargin = frame.RightMargin;
            report.Fields = frame.Fields?.Select(x => new JasperField { Name = x });
            report.Details = new List<JasperDetail> { (JasperDetail)frame.ConvertToJasper() };

            return $"<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n{report.ConvertComponentToJrxml()}";
        }

        public static string ConvertComponentToJrxml([NotNull] this IJComponent jComponent)
        {
            var properties = jComponent.GetType()
                .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .OrderBy(x => ((JPositionAttribute)x.GetCustomAttribute(typeof(JPositionAttribute)))?.Position).ToList();

            var mainClassName = GetJasperName(jComponent);

            string GetJasperName(object jComp)
            {
                var attribute = jComp is PropertyInfo prop
                    ? prop.GetCustomAttribute(typeof(JPropertyAttribute)) as JPropertyAttribute
                    : jComp.GetType().GetCustomAttribute(typeof(JPropertyAttribute)) as JPropertyAttribute;
                return attribute?.NameProperty ?? (jComp is PropertyInfo prop2
                    ? prop2.Name.FirstCharToLowerCase()
                    : jComp.GetType().Name.FirstCharToLowerCase());
            }

            var props = string.Empty;
            foreach (var x in properties)
            {
                if (x.GetCustomAttribute(typeof(JTagAttribute)) != null) continue;
                
                var value = x.GetValue(jComponent, null);
                var valueStr = value?.ToString();

                if (value is bool b)
                    valueStr = b.ToString().FirstCharToLowerCase();
                props += $"{GetJasperName(x)}=\"{valueStr}\" ";
            }

            var tags = string.Empty;
            foreach (var tagProp in properties.Where(x => x.GetCustomAttribute(typeof(JTagAttribute)) != null))
            {
                var tag = tagProp.GetValue(jComponent, null);
                switch (tag)
                {
                    case IEnumerable<IJComponent> list:
                        tags = list.Aggregate(tags,
                            (current, itemList) => current + itemList.ConvertComponentToJrxml());
                        break;
                    case IJComponent item:
                        tags += item.ConvertComponentToJrxml();
                        break;
                    case string strItem:
                        var tagStart = GetJasperName(tagProp);
                        tags += $"<{tagStart}>{strItem}</{tagStart}>";
                        break;
                }
            }

            var attribute = jComponent.GetType().GetCustomAttribute(typeof(JTagAttribute)) as JTagAttribute;
            var can = attribute?.CanClosed ?? true;
            return $"<{mainClassName} {props}{(can ? $">{tags}</{mainClassName}>" : "/>")}";
        }

        public static IEnumerable<JasperProperty> AddMillimeterProperties(this List<JasperProperty> sender)
        {
            sender.AddRange(
                new[]
                {
                    new JasperProperty
                    {
                        Name = "com.jaspersoft.studio.unit.width",
                        Value = "mm"
                    },
                    new JasperProperty
                    {
                        Name = "com.jaspersoft.studio.unit.height",
                        Value = "mm"
                    },
                    new JasperProperty
                    {
                        Name = "com.jaspersoft.studio.unit.y",
                        Value = "mm"
                    },
                    new JasperProperty
                    {
                        Name = "com.jaspersoft.studio.unit.x",
                        Value = "mm"
                    }
                });
            return sender;
        }
    }
}