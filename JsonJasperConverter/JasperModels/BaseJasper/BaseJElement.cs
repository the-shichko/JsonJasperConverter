using JsonJasperConverter.Attributes;
using JsonJasperConverter.JasperModels.JasperProperties;

namespace JsonJasperConverter.JasperModels.BaseJasper
{
    public class BaseJElement : IJComponent
    {
        [JTag(false)] [JPosition(0)] public JasperReportElement ReportElement { get; set; }
    }
    
    /// <summary>
    /// Use class when tag 'reportElement' with 'mode' exist in your object
    /// </summary>
    public class BaseModeJElement : IJComponent
    {
        [JTag(false)] [JPosition(0)] public JasperModeReportElement ReportElement { get; set; }
    }
}