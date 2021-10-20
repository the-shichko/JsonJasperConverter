using JsonJasperConverter.Attributes;
using JsonJasperConverter.JasperModels.BaseJasper;

namespace JsonJasperConverter.JasperModels.JasperProperties
{
    [JProperty("field")]
    public class JasperField : IJComponent
    {
        public string Name { get; set; }
        public string Class { get; set; } = "java.lang.String";
    }
}