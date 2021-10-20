using JsonJasperConverter.Attributes;
using JsonJasperConverter.JasperModels.BaseJasper;
using JsonJasperConverter.JasperModels.JasperProperties;

namespace JsonJasperConverter.JasperModels.JasperBasicElements
{
    [JProperty("staticText")]
    public class JasperStaticText : BaseJElement
    {
        [JTag] [JPosition(1)] public JasperBox Box { get; set; }
        [JTag] [JPosition(2)] public JasperTextElement TextElement { get; set; }
        [JTag] [JPosition(3)] public string Text { get; set; }
    }
}