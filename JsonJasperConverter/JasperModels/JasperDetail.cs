using JsonJasperConverter.Attributes;

namespace JsonJasperConverter.JasperModels
{
    [JProperty("detail")]
    [JTag]
    public class JasperDetail : IJComponent
    {
        [JTag] public JasperBand Band { get; set; }
    }
}