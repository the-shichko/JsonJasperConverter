using JsonJasperConverter.Attributes;
using JsonJasperConverter.JasperModels.BaseJasper;

namespace JsonJasperConverter.JasperModels.JasperBasicElements
{
    [JProperty("staticText")]
    public class JasperStaticText : BaseJElement
    {
        private string _text;

        [JTag]
        [JPosition(1)]
        public string Text
        {
            get => $"<![CDATA[{_text}]]>";
            set => _text = value;
        }
    }
}