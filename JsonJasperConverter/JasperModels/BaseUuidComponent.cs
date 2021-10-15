using System;

namespace JsonJasperConverter.JasperModels
{
    public abstract class BaseUuidComponent : BaseComponentWithProperty
    {
        protected BaseUuidComponent()
        {
            Uuid = Guid.NewGuid();
        }

        public Guid Uuid { get; }
    }
}