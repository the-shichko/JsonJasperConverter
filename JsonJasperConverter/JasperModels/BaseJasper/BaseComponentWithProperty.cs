using System.Collections.Generic;
using JsonJasperConverter.Attributes;

namespace JsonJasperConverter.JasperModels.BaseJasper
{
    public abstract class BaseComponentWithProperty : IJComponent
    {
        [JPosition(0)] [JTag(false)] public IEnumerable<JasperProperty> Properties { get; set; }
    }
}