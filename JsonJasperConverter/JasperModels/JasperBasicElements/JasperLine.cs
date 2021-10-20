using JsonJasperConverter.Attributes;
using JsonJasperConverter.JasperModels.BaseJasper;
using JsonJasperConverter.JasperModels.JasperProperties;

namespace JsonJasperConverter.JasperModels.JasperBasicElements
{
    [JProperty("line")]
    public class JasperLine : BaseModeJElement
    {
        public string Direction { get; set; } = "TopDown";
        [JTag] [JPosition(1)]public JasperGraphicElement GraphicElement { get; set; }
    }
}