using System;
using JsonJasperConverter.JasperModels;
using JsonJasperConverter.JasperModels.BaseJasper;
using JsonJasperConverter.JasperModels.JasperProperties;

namespace JsonJasperConverter.Models
{
    [Serializable]
    public class TextProperties : IJasperConvertable
    {
        public Alignment Alignment { get; set; }
        public Font Font { get; set; }
        public IJComponent ConvertToJasper()
        {
            return new JasperTextElement
            {
                Font = new JasperFont
                {
                    Size = Font.Size == 0 ? 15 : Font.Size,
                    FontName = Font.Name ?? "Arial Narrow",
                    IsBold = Font.IsBold,
                    IsItalic = Font.IsItalic,
                    IsUnderline = Font.IsUnderline,
                    IsStrikeThrough = Font.IsStrikeThrough
                },
                TextAlignment = Alignment.Horizontal,
                VerticalAlignment = Alignment.Vertical
            };
        }
    }
}