using System.Collections.Generic;
using JsonJasperConverter.Attributes;
using JsonJasperConverter.JasperModels.BaseJasper;
using JsonJasperConverter.JasperModels.JasperProperties;

namespace JsonJasperConverter.JasperModels.JasperBasicElements
{
    [JProperty("frame")]
    public class JasperFrame : IJComponent
    {
        [JPosition(0)] [JTag] public JasperModeReportElement ReportElement { get; set; }
        [JPosition(1)] [JTag(false)] public IEnumerable<IJComponent> Components { get; set; }
    }
}