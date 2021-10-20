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
        public int X2 { get; set; }
        public int Y2 { get; set; }
        public string Color { get; set; } = "#FFFFFF";
        public override string ComponentName { get; set; }
        public override IJComponent ConvertToJasper()
        {
            return new JasperLine
            {
                Direction = Y2 - Y < 0 ? "BottomUp" : "TopDown",
                ReportElement = new JasperModeReportElement
                {
                    X = X,
                    Y = Y - (Y2 - Y < 0 ? Math.Abs(Y2 - Y) : 0),
                    Height = Y2 - Y == 0 ? 1 : Math.Abs(Y2 - Y),
                    Width = X2 - X == 0 ? 1 : X2 - X,
                    Properties = new List<JasperProperty>().AddMillimeterProperties()
                },
                GraphicElement = new JasperGraphicElement
                {
                    Pen = new JasperPositionPen
                    {
                        LineWidth = Width,
                        LineStyle = "Solid",
                        LineColor = Color
                    }
                }
            };
        }
    }
}