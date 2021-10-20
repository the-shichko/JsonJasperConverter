using System;
using System.Collections.Generic;
using JsonJasperConverter.Extensions;
using JsonJasperConverter.JasperModels;

namespace JsonJasperConverter.Models
{
    [Serializable]
    public class StaticText : BasicComponent
    {
        public override string ComponentName { get; set; } = nameof(StaticText);
        public string Value { get; set; }

        public override IJComponent ConvertToJasper()
        {
            return new JasperStaticText
            {
                ReportElement = new JasperReportElement
                {
                    X = X,
                    Height = Height,
                    Width = Width,
                    Y = Y,
                    Properties = new List<JasperProperty>().AddMillimeterProperties()
                },
                Text = Value
            };
        }
    }
}