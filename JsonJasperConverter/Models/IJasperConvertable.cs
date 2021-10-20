using JsonJasperConverter.JasperModels;
using JsonJasperConverter.JasperModels.BaseJasper;

namespace JsonJasperConverter.Models
{
    public interface IJasperConvertable
    {
        public IJComponent ConvertToJasper();
    }
}