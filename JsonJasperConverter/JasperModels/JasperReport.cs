using System.Collections.Generic;
using JsonJasperConverter.Attributes;

namespace JsonJasperConverter.JasperModels
{
    [JProperty("jasperReport")]
    [JTag]
    public class JasperReport : BaseUuidComponent
    {
        public string Xmlns { get; set; } = "http://jasperreports.sourceforge.net/jasperreports";
        [JProperty("xmlns:xsi")] public string Xsi { get; set; } = "http://www.w3.org/2001/XMLSchema-instance";

        [JProperty("xsi:schemaLocation")]
        public string SchemaLocation { get; set; } =
            "http://jasperreports.sourceforge.net/jasperreports http://jasperreports.sourceforge.net/xsd/jasperreport.xsd";

        public int PageWidth { get; set; }
        public int PageHeight { get; set; }
        [JPosition(3)][JTag] public IEnumerable<JasperDetail> Details { get; set; }

        public int LeftMargin { get; set; } = 0;
        public int RightMargin { get; set; } = 0;
        public int TopMargin { get; set; } = 0;
        public int BottomMargin { get; set; } = 0;
        public int ColumnWidth { get; set; } = 50;
        public string Name { get; set; } = "autoCreated";

        [JPosition(1)][JTag(false)] public string QueryString { get; set; } = "<![CDATA[]]>";
        [JPosition(2)][JTag(false)] public IEnumerable<JasperField> Fields { get; set; }

        public static JasperReport CreateBase()
        {
            return new JasperReport
            {
                Properties = new[]
                {
                    new JasperProperty
                        { Name = "com.jaspersoft.studio.data.defaultdataadapter", Value = "One Empty Record" }
                }
            };
        }
    }
}