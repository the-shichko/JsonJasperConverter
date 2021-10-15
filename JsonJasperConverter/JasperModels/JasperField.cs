using JsonJasperConverter.Attributes;

namespace JsonJasperConverter.JasperModels
{
    [JProperty("field")]
    public class JasperField : IJComponent
    {
        public string Name { get; set; }
        public string Class { get; set; } = "java.lang.String";
    }
}