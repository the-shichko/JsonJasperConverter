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
    public class StaticText : TextField
    {
        public override string ComponentName { get; set; } = nameof(StaticText);
        public override IJComponent ConvertToJasper()
        {
            return new JasperStaticText
            {
                ReportElement = new JasperModeReportElement
                {
                    X = X.ToPixelSize(),
                    Height = Height.ToPixelSize(),
                    Width = Width.ToPixelSize(),
                    Y = Y.ToPixelSize(),
                    ForeColor = Color,
                    Properties = new List<JasperProperty>().AddMillimeterProperties()
                },
                Box = (JasperBox)Border?.ConvertToJasper(),
                TextElement = (JasperTextElement)TextProperties?.ConvertToJasper(),
                Text = Value
            };
        }
    }
}