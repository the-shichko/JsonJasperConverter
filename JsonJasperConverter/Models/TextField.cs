using System;
using System.Collections.Generic;
using JsonJasperConverter.Extensions;
using JsonJasperConverter.JasperModels;

namespace JsonJasperConverter.Models
{
    [Serializable]
    public class TextField : BasicComponent
    {
        public string Value { get; set; }

        public override string ComponentName { get; set; } = nameof(TextField);
        public Border Border { get; set; }
        public TextProperties TextProperties { get; set; }

        public override IJComponent ConvertToJasper()
        {
            return new JasperTextField
            {
                ReportElement = new JasperReportElement
                {
                    X = X,
                    Height = Height,
                    Width = Width,
                    Y = Y,
                    Properties = new List<JasperProperty>().AddPixelProperties()
                },
                Box = (JasperBox)Border?.ConvertToJasper(),
                TextElement = (JasperTextElement)TextProperties?.ConvertToJasper(),
                TextFieldExpression = Value
            };
        }
    }
}