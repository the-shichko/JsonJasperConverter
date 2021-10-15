using JsonJasperConverter.Attributes;

namespace JsonJasperConverter.JasperModels
{
    [JProperty("textField")]
    public class JasperTextField : BaseJElement
    {
        private string _textField;

        [JTag]
        public string TextFieldExpression
        {
            get => $"<![CDATA[{_textField}]]>";
            set => _textField = value;
        }
    }
}