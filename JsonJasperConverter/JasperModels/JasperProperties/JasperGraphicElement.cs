using JsonJasperConverter.Attributes;
using JsonJasperConverter.JasperModels.BaseJasper;

namespace JsonJasperConverter.JasperModels.JasperProperties
{
    [JProperty("graphicElement")]
    public class JasperGraphicElement : IJComponent
    {
        [JTag(false)]public JasperPositionPen Pen { get; set; } 
    }
}