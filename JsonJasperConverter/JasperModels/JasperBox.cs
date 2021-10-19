using JsonJasperConverter.Attributes;

namespace JsonJasperConverter.JasperModels
{
    [JProperty("box")]
    public class JasperBox : IJComponent
    {
        public int Padding { get; set; }
        [JTag(false)] [JPosition(0)] public JasperTopPen TopPen { get; set; }
        [JTag(false)] [JPosition(1)] public JasperLeftPen LeftPen { get; set; }
        [JTag(false)] [JPosition(2)] public JasperBottomPen BottomPen { get; set; }
        [JTag(false)] [JPosition(3)] public JasperRightPen RightPen { get; set; }
    }
}