using JsonJasperConverter.Attributes;

namespace JsonJasperConverter.JasperModels
{
    [JProperty("band")]
    public class JasperBand : BaseComponentWithProperty
    {
        public int Height { get; set; }
        [JPosition(1)] [JTag] public JasperFrame Frame { get; set; }
    }
}