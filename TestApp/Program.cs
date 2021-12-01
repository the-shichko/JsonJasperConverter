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
                "{\"editorInfo\":\"{\\\"elementsToAdd\\\":[{\\\"key\\\":\\\"dataMatrix\\\",\\\"category\\\":\\\"marking\\\",\\\"name\\\":\\\"dataMatrix\\\"}],\\\"newDbElements\\\":[],\\\"addedElements\\\":[{\\\"allowIntersections\\\":false,\\\"properties\\\":{\\\"borderColor\\\":\\\"default\\\",\\\"bordered\\\":false,\\\"color\\\":\\\"#000\\\"},\\\"lockAspectRatio\\\":true,\\\"name\\\":\\\"dataMatrix\\\",\\\"key\\\":\\\"dataMatrix\\\",\\\"x\\\":54,\\\"y\\\":0,\\\"width\\\":348,\\\"height\\\":348,\\\"currentScale\\\":7.53124,\\\"layerIndex\\\":0,\\\"elementCategory\\\":\\\"marking\\\",\\\"type\\\":\\\"dataMatrix\\\"}],\\\"labelParameters\\\":{\\\"type\\\":\\\"label\\\",\\\"padding\\\":\\\"0 0 0 0\\\",\\\"backgroundColor\\\":\\\"rgba(255,255,255,1)\\\",\\\"defaultFontColor\\\":\\\"#000\\\",\\\"defaultElementBorderColor\\\":\\\"#000\\\",\\\"defaultFontSize\\\":8,\\\"key\\\":\\\"label\\\",\\\"labelSize\\\":[58,60]},\\\"editorSettings\\\":{\\\"gridVisible\\\":false,\\\"elementBoundariesVisible\\\":true,\\\"scale\\\":2,\\\"gridColor\\\":\\\"gray\\\",\\\"selectionColor\\\":\\\"rgb(10, 68, 99)\\\",\\\"wrongElementColor\\\":\\\"rgba(255, 0, 0, 0.247)\\\",\\\"backgroundElementColor\\\":\\\"rgba(90, 90, 90, 0.24)\\\",\\\"preListExpanded\\\":false},\\\"labelInfo\\\":{\\\"labelName\\\":\\\"6661\\\",\\\"comment\\\":\\\"\\\",\\\"size\\\":\\\"58x60\\\",\\\"byDefault\\\":false,\\\"mainCategory\\\":1,\\\"creationDate\\\":\\\"\\\",\\\"id\\\":\\\"a3f07cc6-4352-4bec-beb2-cee5176ecc9d\\\"}}\",\"height\":60,\"width\":58,\"color\":\"#ffffff\",\"components\":[{\"componentName\":\"image\",\"x\":7.2,\"y\":0,\"height\":46.2,\"width\":46.2,\"valueUrl\":\"{DataMatrix}\",\"border\":{\"color\":\"transparent\",\"width\":0.3,\"padding\":1},\"color\":\"#000\"}]}"
                    .ToJasperConvertableFrame();
            // foreach (var element in frame.Components)
            // {
            //     if (!(element is Image image) || image.ValueBase64 == null) continue;
            //
            //     var path = Path.Combine(Directory.GetCurrentDirectory(),
            //         $"logo-{Guid.NewGuid()}");
            //     File.WriteAllBytes(path, Convert.FromBase64String(image.ValueBase64));
            //     image.ValueUrl = path;
            // }

            //convert to jrxml
            var jrxml = frame.ConvertFrameToJasper();

            Console.WriteLine(jrxml);
            Console.ReadKey();
        }
    }
}