using JsonJasperConverter.Attributes;

namespace JsonJasperConverter.JasperModels
{
    public class BaseJElement : IJComponent
    {
        [JTag(false)] [JPosition(0)] public JasperReportElement ReportElement { get; set; }
    }
}