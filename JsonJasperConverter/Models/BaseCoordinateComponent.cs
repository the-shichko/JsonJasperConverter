using System;
using JsonJasperConverter.JasperModels;

namespace JsonJasperConverter.Models
{
    [Serializable]
    public abstract class BasicComponent : IJasperConvertable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public abstract string ComponentName { get; set; }
        public abstract IJComponent ConvertToJasper();
    }
}