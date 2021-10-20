using JsonJasperConverter.Attributes;
using JsonJasperConverter.JasperModels.BaseJasper;

namespace JsonJasperConverter.JasperModels.JasperBasicElements
{
    [JProperty("detail")]
    [JTag]
    public class JasperDetail : IJComponent
    {
        [JTag] public JasperBand Band { get; set; }
    }
}