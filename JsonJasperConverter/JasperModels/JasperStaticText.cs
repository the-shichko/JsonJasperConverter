using JsonJasperConverter.Attributes;

namespace JsonJasperConverter.JasperModels
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