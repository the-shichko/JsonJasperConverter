using System;

namespace JsonJasperConverter.Models
{
    [Serializable]
    public class DefaultBorder
    {
        public double Width { get; set; } = 0.0;
        public string Color { get; set; }
        public string Style { get; set; } = "Solid";
    }
}