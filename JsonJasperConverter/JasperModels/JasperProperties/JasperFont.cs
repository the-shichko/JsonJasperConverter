using JsonJasperConverter.Attributes;
using JsonJasperConverter.JasperModels.BaseJasper;

namespace JsonJasperConverter.JasperModels.JasperProperties
{
    [JProperty("font")]
    public class JasperFont : IJComponent
    {
        public string FontName { get; set; }
        public int Size { get; set; }
        public bool IsBold { get; set; }
        public bool IsItalic { get; set; }
        public bool IsUnderline { get; set; }
        public bool IsStrikeThrough { get; set; }
    }
}