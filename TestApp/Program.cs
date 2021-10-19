using System;
using System.Collections.Generic;
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
                Components = new List<IJasperConvertable>
                {
                    new TextField
                    {
                        Height = 100, Value = "Test", Width = 100, X = 10, Y = 10,
                        Border = new Border
                        {
                            Width = 5,
                            Padding = 10
                        },
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
                },
                Fields = new[] { "name" }
            };

            // serialization
            var json = JsonConvert.SerializeObject(frontFrame);

            //back to frame from "front"
            var frame = json.ToJasperConvertableFrame();

            //convert to jrxml
            var jrxml = frame.ConvertFrameToJasper();

            Console.WriteLine(jrxml);
            Console.ReadKey();
        }
    }
}