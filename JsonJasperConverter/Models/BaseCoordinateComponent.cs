using System;
using JsonJasperConverter.JasperModels.BaseJasper;

namespace JsonJasperConverter.Models
{
    [Serializable]
    public abstract class BasicComponent : IJasperConvertable
    {
        public double X { get; set; }
        public double Y { get; set; }
        // protected double WidthD;
        // protected double HeightD;

        public double Width { get; set; }
        // {
        //     get => (int)Math.Ceiling(WidthD);
        //     set => WidthD = value;
        // }

        public double Height { get; set; }
        // {
        //     get => (int)Math.Ceiling(HeightD);
        //     set => HeightD = value;
        // }

        public abstract string ComponentName { get; set; }
        public abstract IJComponent ConvertToJasper();
    }
}