using System;

namespace JsonJasperConverter.Extensions
{
    public static class DoubleExtensions
    {
        public static int ToPixelSize(this double sender)
        {
            var result = (int)Math.Round(sender / 0.352775, MidpointRounding.AwayFromZero);
            return result != 0 ? result : 1;
        }
    }
}