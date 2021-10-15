using JsonJasperConverter.Attributes;

namespace JsonJasperConverter.JasperModels
{
    [JProperty("property")]
    [JTag(false)]
    public class JasperProperty : IJComponent
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}