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
            var localX = X.ToPixelSize();
            var localX2 = X2.ToPixelSize();
            var localY = Y.ToPixelSize();
            var localY2 = Y2.ToPixelSize();
            
            return new JasperLine
            {
                Direction = Y2 - Y < 0 ? "BottomUp" : "TopDown",
                ReportElement = new JasperModeReportElement
                {
                    X = localX,
                    Y = localY - (localY2 - localY < 0 ? Math.Abs(localY2 - localY) : 0),
                    Height = localY2 - localY == 0 ? 1 : Math.Abs(localY2 - localY),
                    Width = localX2 - localX == 0 ? 1 : localX2 - localX,
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