using JsonJasperConverter.Attributes;

namespace JsonJasperConverter.JasperModels
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