using JsonJasperConverter.Attributes;
using JsonJasperConverter.JasperModels.BaseJasper;

namespace JsonJasperConverter.JasperModels.JasperBasicElements
{
    [JProperty("band")]
    public class JasperBand : BaseComponentWithProperty
    {
        public int Height { get; set; }
        [JPosition(1)] [JTag] public JasperFrame Frame { get; set; }
    }
}