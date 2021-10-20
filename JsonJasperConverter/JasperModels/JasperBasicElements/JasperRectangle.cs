using JsonJasperConverter.Attributes;
using JsonJasperConverter.JasperModels.BaseJasper;
using JsonJasperConverter.JasperModels.JasperProperties;

namespace JsonJasperConverter.JasperModels.JasperBasicElements
{
    [JProperty("rectangle")]
    public class JasperRectangle : BaseModeJElement
    {
        public int Radius { get; set; }
        [JTag] [JPosition(1)] public JasperGraphicElement GraphicElement { get; set; }
    }
}