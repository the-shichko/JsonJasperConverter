using System.Collections.Generic;
using JsonJasperConverter.Attributes;

namespace JsonJasperConverter.JasperModels
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
    public class JasperFrameReportElement : JasperReportElement
    {
        public JasperFrameReportElement()
        {
            X = 0;
            Y = 0;
            Properties = new[] { new JasperProperty { Name = "com.jaspersoft.studio.layout" } };
        }
        [JProperty("backcolor")] public string BackColor { get; set; }
        [JProperty("positionType")] public string PositionType { get; set; } = "FixRelativeToBottom";
    }
}