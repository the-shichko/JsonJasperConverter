using System;

namespace JsonJasperConverter.JasperModels.BaseJasper
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