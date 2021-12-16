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
                "{\"editorInfo\":\"{\\\"elementsToAdd\\\":[{\\\"key\\\":\\\"verticalLine_0\\\",\\\"category\\\":\\\"lines\\\",\\\"name\\\":\\\"verticalLine\\\"},{\\\"key\\\":\\\"horizontalLine_0\\\",\\\"category\\\":\\\"lines\\\",\\\"name\\\":\\\"horizontalLine\\\"},{\\\"key\\\":\\\"dataMatrix\\\",\\\"category\\\":\\\"marking\\\",\\\"name\\\":\\\"dataMatrix\\\"}],\\\"newDbElements\\\":[{\\\"name\\\":\\\"verticalLine\\\",\\\"elementCategory\\\":\\\"lines\\\",\\\"initialSize\\\":{\\\"width\\\":3,\\\"height\\\":10},\\\"lockAspectRatio\\\":false,\\\"type\\\":\\\"decorativeItem\\\",\\\"properties\\\":{\\\"color\\\":\\\"default\\\",\\\"lineWidth\\\":0.3,\\\"lineType\\\":\\\"solid\\\"},\\\"allowIntersections\\\":true,\\\"extraIndex\\\":0,\\\"key\\\":\\\"verticalLine_0\\\"},{\\\"name\\\":\\\"horizontalLine\\\",\\\"elementCategory\\\":\\\"lines\\\",\\\"initialSize\\\":{\\\"width\\\":10,\\\"height\\\":3},\\\"lockAspectRatio\\\":false,\\\"type\\\":\\\"decorativeItem\\\",\\\"properties\\\":{\\\"color\\\":\\\"default\\\",\\\"lineWidth\\\":0.3,\\\"lineType\\\":\\\"solid\\\"},\\\"allowIntersections\\\":true,\\\"extraIndex\\\":0,\\\"key\\\":\\\"horizontalLine_0\\\"}],\\\"addedElements\\\":[{\\\"extraIndex\\\":0,\\\"allowIntersections\\\":true,\\\"properties\\\":{\\\"color\\\":\\\"default\\\",\\\"lineWidth\\\":0.3,\\\"lineType\\\":\\\"solid\\\"},\\\"lockAspectRatio\\\":false,\\\"name\\\":\\\"verticalLine\\\",\\\"key\\\":\\\"verticalLine_0\\\",\\\"x\\\":23,\\\"y\\\":24,\\\"width\\\":23,\\\"height\\\":308,\\\"currentScale\\\":7.53124,\\\"layerIndex\\\":0,\\\"elementCategory\\\":\\\"lines\\\",\\\"type\\\":\\\"decorativeItem\\\"},{\\\"extraIndex\\\":0,\\\"allowIntersections\\\":true,\\\"properties\\\":{\\\"color\\\":\\\"default\\\",\\\"lineWidth\\\":0.3,\\\"lineType\\\":\\\"solid\\\"},\\\"lockAspectRatio\\\":false,\\\"name\\\":\\\"horizontalLine\\\",\\\"key\\\":\\\"horizontalLine_0\\\",\\\"x\\\":73,\\\"y\\\":22,\\\"width\\\":264,\\\"height\\\":22,\\\"currentScale\\\":7.53124,\\\"layerIndex\\\":1,\\\"elementCategory\\\":\\\"lines\\\",\\\"type\\\":\\\"decorativeItem\\\"},{\\\"allowIntersections\\\":false,\\\"properties\\\":{\\\"borderColor\\\":\\\"default\\\",\\\"bordered\\\":false,\\\"color\\\":\\\"#000\\\"},\\\"lockAspectRatio\\\":true,\\\"name\\\":\\\"dataMatrix\\\",\\\"key\\\":\\\"dataMatrix\\\",\\\"x\\\":101,\\\"y\\\":107,\\\"width\\\":179,\\\"height\\\":179,\\\"currentScale\\\":7.53124,\\\"layerIndex\\\":2,\\\"elementCategory\\\":\\\"marking\\\",\\\"type\\\":\\\"dataMatrix\\\"}],\\\"labelParameters\\\":{\\\"type\\\":\\\"label\\\",\\\"padding\\\":\\\"0 0 0 0\\\",\\\"backgroundColor\\\":\\\"rgba(255,255,255,1)\\\",\\\"defaultFontColor\\\":\\\"#000\\\",\\\"defaultElementBorderColor\\\":\\\"#000\\\",\\\"defaultFontSize\\\":8,\\\"key\\\":\\\"label\\\",\\\"labelSize\\\":[50,50]},\\\"editorSettings\\\":{\\\"gridVisible\\\":false,\\\"elementBoundariesVisible\\\":true,\\\"scale\\\":2,\\\"gridColor\\\":\\\"gray\\\",\\\"selectionColor\\\":\\\"rgb(10, 68, 99)\\\",\\\"wrongElementColor\\\":\\\"rgba(255, 0, 0, 0.247)\\\",\\\"backgroundElementColor\\\":\\\"rgba(90, 90, 90, 0.24)\\\",\\\"preListExpanded\\\":false},\\\"labelInfo\\\":{\\\"labelName\\\":\\\"Линии\\\",\\\"comment\\\":\\\"\\\",\\\"size\\\":\\\"50x50\\\",\\\"byDefault\\\":false,\\\"mainCategory\\\":0,\\\"creationDate\\\":\\\"\\\",\\\"id\\\":\\\"914c12c1-9ca7-4cf0-b67d-123467506f9d\\\"},\\\"disableByDefault\\\":false}\",\"height\":50,\"width\":50,\"color\":\"#ffffff\",\"components\":[{\"componentName\":\"line\",\"width\":0.3,\"style\":\"Solid\",\"x\":4.65,\"y\":3.5,\"x2\":4.65,\"y2\":43.800000000000004,\"color\":\"#000\"},{\"componentName\":\"line\",\"width\":0.3,\"style\":\"Solid\",\"x\":10,\"y\":4.35,\"x2\":44.5,\"y2\":4.35,\"color\":\"#000\"},{\"componentName\":\"image\",\"x\":13.4,\"y\":14.2,\"height\":23.8,\"width\":23.8,\"valueUrl\":\"{DataMatrix}\",\"border\":{\"color\":\"transparent\",\"width\":0,\"padding\":1},\"color\":\"#000\"}]}"
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