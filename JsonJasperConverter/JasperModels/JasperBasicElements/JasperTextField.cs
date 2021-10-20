using JsonJasperConverter.Attributes;
using JsonJasperConverter.JasperModels.BaseJasper;
using JsonJasperConverter.JasperModels.JasperProperties;

namespace JsonJasperConverter.JasperModels.JasperBasicElements
{
    [JProperty("textField")]
    public class JasperTextField : BaseModeJElement
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