using System.Collections.Generic;
using JsonJasperConverter.Attributes;

namespace JsonJasperConverter.JasperModels
{
    public abstract class BaseComponentWithProperty : IJComponent
    {
        [JPosition(0)] [JTag(false)] public IEnumerable<JasperProperty> Properties { get; set; }
    }
}