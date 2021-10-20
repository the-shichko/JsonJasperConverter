﻿using System;
using JsonJasperConverter.JasperModels;
using JsonJasperConverter.JasperModels.BaseJasper;
using JsonJasperConverter.JasperModels.JasperBasicElements;
using JsonJasperConverter.JasperModels.JasperProperties;

namespace JsonJasperConverter.Models
{
    [Serializable]
    public class Image : BasicComponent
    {
        public string ValueUrl { get; set; }
        public byte[] ValueBase64 { get; set; }

        public override string ComponentName { get; set; } = nameof(Image);

        public override IJComponent ConvertToJasper()
        {
            return new JasperImage
            {
                ReportElement = new JasperReportElement
                {
                    X = X,
                    Height = Height,
                    Width = Width,
                    Y = Y
                },
                ImageExpression = ValueUrl
            };
        }
    }
}