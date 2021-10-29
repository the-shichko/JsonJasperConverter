using System;

namespace JsonJasperConverter.Models
{
    [Serializable]
    public class DefaultBorder
    {
        public double Width { get; set; }
        public string Color { get; set; }
        public string Style { get; set; } = "Solid";
    }
}