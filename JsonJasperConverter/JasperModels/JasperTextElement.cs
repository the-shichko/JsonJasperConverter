using JsonJasperConverter.Attributes;

namespace JsonJasperConverter.JasperModels
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