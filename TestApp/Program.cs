using System;
using System.Collections.Generic;
using System.IO;
using JsonJasperConverter.Extensions;
using JsonJasperConverter.Models;
using Newtonsoft.Json;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // front
            var frontFrame = new Frame
            {
                Height = 300,
                Width = 300,
                Color = "#732726",
                Components = new List<IJasperConvertable>
                {
                    new TextField
                    {
                        Height = 100, Value = "Test", Width = 100, X = 10, Y = 10,
                        Border = new ComponentBorder
                        {
                            Width = 5,
                            Padding = 10
                        },
                        Color = "#732726",
                        ComponentName = "textField",
                        TextProperties = new TextProperties
                        {
                            Alignment = new Alignment
                            {
                                Horizontal = "Right",
                                Vertical = "Middle"
                            },
                            Font = new Font
                            {
                                Name = "Bell MT",
                                Size = 16,
                                IsBold = true
                            }
                        }
                    },
                    new Line
                    {
                        Width = 3,
                        X = 7,
                        Y = 200,
                        X2 = 300,
                        Y2 = 300,
                        Color = "#17FF9A",
                    },
                    new Rectangle
                    {
                        X = 30,
                        Y = 40,
                        Color = "#FFFFFF",
                        Width = 100,
                        Height = 100,
                        Radius = 1,
                        Border = new DefaultBorder
                        {
                            Color = "#17FF9A",
                            Width = 2
                        }
                    },
                    new StaticText
                    {
                        X = 60,
                        Y = 70,
                        Height = 100,
                        Value = "100",
                        Width = 100
                    },
                    new Image
                    {
                        X = 200,
                        Y = 200,
                        Height = 100,
                        Width = 100,
                        ValueUrl = "https://10.81.80.6:5152/images/logoImages/logo-eac.png",
                        Border = new ComponentBorder
                        {
                            Color = "#000000",
                            Padding = 10,
                            Style = "Double",
                            Width = 2
                        }
                    }
                },
                Fields = new[] { "name" }
            };

            // serialization
            var json = JsonConvert.SerializeObject(frontFrame);

            //back to frame from "front"
            var frame =
                json.ToJasperConvertableFrame();

            foreach (var element in frame.Components)
            {
                if (!(element is Image image) || image.ValueBase64 == null) continue;

                var path = Path.Combine(Directory.GetCurrentDirectory(),
                    $"logo-{Guid.NewGuid()}");
                File.WriteAllBytes(path, Convert.FromBase64String(image.ValueBase64));
                image.ValueUrl = path;
            }

            //convert to jrxml
            var jrxml = frame.ConvertFrameToJasper();

            Console.WriteLine(jrxml);
            Console.ReadKey();
        }
    }
}