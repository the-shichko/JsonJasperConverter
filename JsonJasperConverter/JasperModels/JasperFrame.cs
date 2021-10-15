using System.Collections.Generic;
using JsonJasperConverter.Attributes;

namespace JsonJasperConverter.JasperModels
{
    [JProperty("frame")]
    public class JasperFrame : IJComponent
    {
        [JPosition(0)] [JTag] public JasperFrameReportElement ReportElement { get; set; }
        [JPosition(1)] [JTag(false)] public IEnumerable<IJComponent> Components { get; set; }
    }
}