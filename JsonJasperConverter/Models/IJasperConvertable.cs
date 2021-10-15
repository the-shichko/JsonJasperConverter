using JsonJasperConverter.JasperModels;

namespace JsonJasperConverter.Models
{
    public interface IJasperConvertable
    {
        public IJComponent ConvertToJasper();
    }
}