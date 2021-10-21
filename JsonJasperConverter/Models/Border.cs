using JsonJasperConverter.JasperModels.BaseJasper;
using JsonJasperConverter.JasperModels.JasperBasicElements;
using JsonJasperConverter.JasperModels.JasperProperties;

namespace JsonJasperConverter.Models
{
    public class ComponentBorder : DefaultBorder, IJasperConvertable
    {
        public int Padding { get; set; }
        public IJComponent ConvertToJasper()
        {
            var jasper = new JasperPositionPen
            {
                LineColor = Color ?? "#000000",
                LineWidth = Width,
                LineStyle = Style ?? "Solid"
            };
            return new JasperBox
            {
                Padding = Padding,
                BottomPen = jasper.CreateBottom(),
                LeftPen = jasper.CreateLeft(),
                RightPen = jasper.CreateRight(),
                TopPen = jasper.CreateTop()
            };
        }
    }
}