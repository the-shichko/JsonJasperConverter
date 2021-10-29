using System;
using System.Collections.Generic;
using JsonJasperConverter.Extensions;
using JsonJasperConverter.JasperModels;
using JsonJasperConverter.JasperModels.BaseJasper;
using JsonJasperConverter.JasperModels.JasperBasicElements;
using JsonJasperConverter.JasperModels.JasperProperties;

namespace JsonJasperConverter.Models
{
    [Serializable]
    public class Rectangle : BasicComponent
    {
        public override string ComponentName { get; set; } = nameof(Rectangle);
        public DefaultBorder Border { get; set; }
        public int Radius { get; set; }
        public string Color { get; set; }

        public override IJComponent ConvertToJasper()
        {
            return new JasperRectangle
            {
                Radius = Radius,
                ReportElement = new JasperModeReportElement
                {
                    X = X.ToPixelSize(),
                    Y = Y.ToPixelSize(),
                    BackColor = Color,
                    Height = Height.ToPixelSize(),
                    Width = Width.ToPixelSize(),
                    Properties = new List<JasperProperty>().AddMillimeterProperties()
                },
                GraphicElement = new JasperGraphicElement
                {
                    Pen = new JasperPositionPen
                    {
                        LineColor = Border.Color,
                        LineStyle = Border.Style,
                        LineWidth = Border.Width
                    }
                }
            };
        }
    }
}