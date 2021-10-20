using JsonJasperConverter.Attributes;
using JsonJasperConverter.JasperModels.BaseJasper;

namespace JsonJasperConverter.JasperModels.JasperProperties
{
    [JTag]
    [JProperty("textElement")]
    public class JasperTextElement : IJComponent
    {
        public string TextAlignment { get; set; } = "Left";
        public string VerticalAlignment { get; set; } = "Middle";

        [JTag(false)]
        public JasperFont Font { get; set; }
    }
}