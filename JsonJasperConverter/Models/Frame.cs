using System.Collections.Generic;
using System.Linq;
using JsonJasperConverter.Attributes;
using JsonJasperConverter.Extensions;
using JsonJasperConverter.JasperModels;
using JsonJasperConverter.JasperModels.BaseJasper;
using JsonJasperConverter.JasperModels.JasperBasicElements;
using JsonJasperConverter.JasperModels.JasperProperties;

namespace JsonJasperConverter.Models
{
    public class Frame : IJasperConvertable
    {
        [JPropertyIgnore] public string EditorData { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public string Color { get; set; } = "#FFFFFF";
        public int LeftMargin { get; set; } = 0;
        public int RightMargin { get; set; } = 0;
        public int TopMargin { get; set; } = 0;
        public int BottomMargin { get; set; } = 0;

        public IEnumerable<IJasperConvertable> Components { get; set; }
        public IEnumerable<string> Fields { get; set; }

        /// <summary>
        /// Return JasperBand object
        /// </summary>
        /// <returns><see cref="JasperDetail"/></returns>
        public IJComponent ConvertToJasper()
        {
            return new JasperDetail
            {
                Band = new JasperBand
                {
                    Height = (Height - BottomMargin).ToPixelSize(),
                    Frame = new JasperFrame
                    {
                        Components = Components.Select(x => x.ConvertToJasper()),
                        ReportElement = new JasperModeReportElement
                        {
                            Height = (Height - BottomMargin).ToPixelSize(),
                            Width = (Width - LeftMargin - RightMargin).ToPixelSize(),
                            BackColor = Color,
                            Properties = new List<JasperProperty>().AddMillimeterProperties(),
                        }
                    }
                }
            };
        }
    }
}