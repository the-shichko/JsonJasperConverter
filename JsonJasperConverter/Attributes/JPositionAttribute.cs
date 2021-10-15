using System;

namespace JsonJasperConverter.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class JPositionAttribute : Attribute
    {
        public int Position { get; }
        public JPositionAttribute(int position)
        {
            Position = position;
        }
    }
}