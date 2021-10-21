using JsonJasperConverter.Attributes;
using JsonJasperConverter.JasperModels.BaseJasper;

namespace JsonJasperConverter.JasperModels.JasperBasicElements
{
    [JProperty("image")]
    public class JasperImage : BaseJElement
    {
        [JTag] [JPosition(1)] public JasperBox Box { get; set; }

        private string _image;

        [JTag]
        [JPosition(2)]
        public string ImageExpression
        {
            get => $"<![CDATA[\"{_image.Replace("\\", "/")}\"]]>";
            set => _image = value;
        }
    }
}