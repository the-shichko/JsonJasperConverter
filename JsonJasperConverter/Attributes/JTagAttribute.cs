using System;

namespace JsonJasperConverter.Attributes
{
    public class JTagAttribute : Attribute
    {
        public bool CanClosed;
        public JTagAttribute(bool canClosed = true)
        {
            CanClosed = canClosed;
        }
    }
}