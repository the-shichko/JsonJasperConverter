using JsonJasperConverter.Attributes;
using JsonJasperConverter.JasperModels.BaseJasper;

namespace JsonJasperConverter.JasperModels.JasperProperties
{
    [JProperty("reportElement")]
    public class JasperReportElement : BaseUuidComponent
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }

    [JProperty("reportElement")]
    public class JasperModeReportElement : JasperReportElement
    {
        public JasperModeReportElement()
        {
            X = 0;
            Y = 0;
            Properties = new[] { new JasperProperty { Name = "com.jaspersoft.studio.layout" } };
        }

        [JProperty("forecolor")] public string ForeColor { get; set; } = "#000000";
        [JProperty("backcolor")] public string BackColor { get; set; } = "#FFFFFF";
        [JProperty("positionType")] public string PositionType { get; set; } = "FixRelativeToBottom";

        private string _mode = "Opaque";

        public string Mode
        {
            get => BackColor.ToLower() == "transparent" ? "Transparent" : _mode;
            set => _mode = value;
        }
    }
}