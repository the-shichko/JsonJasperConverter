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
    public class TextField : BasicComponent
    {
        public string Value { get; set; }

        public override string ComponentName { get; set; } = nameof(TextField);
        public ComponentBorder Border { get; set; }
        public string Color { get; set; }
        public TextProperties TextProperties { get; set; }

        public override IJComponent ConvertToJasper()
        {
            return new JasperTextField
            {
                ReportElement = new JasperModeReportElement
                {
                    X = X,
                    Height = Height,
                    Width = Width,
                    Y = Y,
                    ForeColor = Color,
                    Properties = new List<JasperProperty>().AddMillimeterProperties()
                },
                Box = (JasperBox)Border?.ConvertToJasper(),
                TextElement = (JasperTextElement)TextProperties?.ConvertToJasper(),
                TextFieldExpression = Value
            };
        }
    }
}