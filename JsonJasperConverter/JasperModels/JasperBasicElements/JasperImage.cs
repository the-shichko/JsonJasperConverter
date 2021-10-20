using JsonJasperConverter.Attributes;
using JsonJasperConverter.JasperModels.BaseJasper;

namespace JsonJasperConverter.JasperModels.JasperBasicElements
{
    [JProperty("image")]
    public class JasperImage : BaseJElement
    {
        private string _image;

        [JTag]
        [JPosition(1)]
        public string ImageExpression
        {
            get => $"<![CDATA[{_image}]]>";
            set => _image = value;
        }
    }
}