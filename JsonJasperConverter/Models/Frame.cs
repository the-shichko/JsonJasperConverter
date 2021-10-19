using System.Collections.Generic;
using System.Linq;
using JsonJasperConverter.JasperModels;

namespace JsonJasperConverter.Models
{
    public class Frame : IJasperConvertable
    {
        public string EditorData { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

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
                    Height = Height,
                    Frame = new JasperFrame
                    {
                        Components = Components.Select(x => x.ConvertToJasper()),
                        ReportElement = new JasperFrameReportElement
                        {
                            Height = Height,
                            Width = Width
                        }
                    }
                }
            };
        }
    }
}