using System;

namespace JsonJasperConverter.Attributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Class)]
    public class JPropertyAttribute : Attribute
    {
        public string NameProperty { get; }
        public JPropertyAttribute(string name)
        {
            NameProperty = name;
        }
    }
}