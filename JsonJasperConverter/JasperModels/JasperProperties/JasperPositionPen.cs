using JsonJasperConverter.Attributes;
using JsonJasperConverter.JasperModels.BaseJasper;

namespace JsonJasperConverter.JasperModels.JasperProperties
{
    [JProperty("pen")]
    public class JasperPositionPen : IJComponent
    {
        public double LineWidth { get; set; }
        public string LineStyle { get; set; } = "Solid";
        public string LineColor { get; set; } = "#000000";
        
        public JasperTopPen CreateTop()
        {
            return new JasperTopPen
            {
                LineColor = LineColor,
                LineStyle = LineStyle,
                LineWidth = LineWidth
            };
        }
        public JasperLeftPen CreateLeft()
        {
            return new JasperLeftPen
            {
                LineColor = LineColor,
                LineStyle = LineStyle,
                LineWidth = LineWidth
            };
        }
        
        public JasperBottomPen CreateBottom()
        {
            return new JasperBottomPen
            {
                LineColor = LineColor,
                LineStyle = LineStyle,
                LineWidth = LineWidth
            };
        }
        public JasperRightPen CreateRight()
        {
            return new JasperRightPen
            {
                LineColor = LineColor,
                LineStyle = LineStyle,
                LineWidth = LineWidth
            };
        }
        
        
    }

    [JProperty("topPen")]
    public class JasperTopPen : JasperPositionPen
    {
    }
    
    [JProperty("leftPen")]
    public class JasperLeftPen : JasperPositionPen
    {
    }
    
    [JProperty("bottomPen")]
    public class JasperBottomPen : JasperPositionPen
    {
    }
    
    [JProperty("rightPen")]
    public class JasperRightPen : JasperPositionPen
    {
    }
}