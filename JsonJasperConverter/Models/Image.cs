using System;
using JsonJasperConverter.Extensions;
using JsonJasperConverter.JasperModels.BaseJasper;
using JsonJasperConverter.JasperModels.JasperBasicElements;
using JsonJasperConverter.JasperModels.JasperProperties;

namespace JsonJasperConverter.Models
{
    [Serializable]
    public class Image : BasicComponent
    {
        public string ValueUrl { get; set; }
        public string ValueBase64 { get; set; }

        public override string ComponentName { get; set; } = nameof(Image);
        public ComponentBorder Border { get; set; }

        public override IJComponent ConvertToJasper()
        {
            return new JasperImage
            {
                ReportElement = new JasperReportElement
                {
                    X = X.ToPixelSize(),
                    Height = Height.ToPixelSize(),
                    Width = Width.ToPixelSize(),
                    Y = Y.ToPixelSize()
                },
                ImageExpression = ValueUrl,
                Box = (JasperBox)Border?.ConvertToJasper()
            };
        }
    }
}