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
    public class Line : BasicComponent
    {
        public double X2 { get; set; }
        public double Y2 { get; set; }
        public string Color { get; set; } = "#FFFFFF";
        public string Style { get; set; } = "Solid";
        public override string ComponentName { get; set; } = nameof(Line);
        public override IJComponent ConvertToJasper()
        {
            return new JasperLine
            {
                Direction = Y2 - Y < 0 ? "BottomUp" : "TopDown",
                ReportElement = new JasperModeReportElement
                {
                    X = X.ToPixelSize(),
                    Y = (Y - (Y2 - Y < 0 ? Math.Abs(Y2 - Y) : 0)).ToPixelSize(),
                    Height = (Y2 - Y == 0 ? 1 : Math.Abs(Y2 - Y)).ToPixelSize(),
                    Width = (X2 - X == 0 ? 1 : X2 - X).ToPixelSize(),
                    Properties = new List<JasperProperty>().AddMillimeterProperties()
                },
                GraphicElement = new JasperGraphicElement
                {
                    Pen = new JasperPositionPen
                    {
                        LineWidth = Width,
                        LineStyle = Style,
                        LineColor = Color
                    }
                }
            };
        }
    }
}