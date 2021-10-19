using JsonJasperConverter.Attributes;

namespace JsonJasperConverter.JasperModels
{
    [JProperty("textField")]
    public class JasperTextField : BaseJElement
    {
        [JTag] [JPosition(1)] public JasperBox Box { get; set; }
        [JTag] [JPosition(2)] public JasperTextElement TextElement { get; set; }

        private string _textField;

        [JTag]
        [JPosition(3)]
        public string TextFieldExpression
        {
            get => "<![CDATA[($F{" + _textField +"} == null) ? \"--\" :  $F{" + _textField + "}]]>";
            set => _textField = value;
        }
    }
}