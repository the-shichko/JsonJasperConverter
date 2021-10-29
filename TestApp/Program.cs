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
            var frame = "{\"editorInfo\":\"{\\\"elementsToAdd\\\":[{\\\"key\\\":\\\"textField_0\\\",\\\"category\\\":\\\"textFields\\\",\\\"name\\\":\\\"textField\\\"},{\\\"key\\\":\\\"rectangle_0\\\",\\\"category\\\":\\\"rectangles\\\",\\\"name\\\":\\\"rectangle\\\"},{\\\"key\\\":\\\"dataMatrix\\\",\\\"category\\\":\\\"marking\\\",\\\"name\\\":\\\"dataMatrix\\\"}],\\\"newDbElements\\\":[{\\\"name\\\":\\\"textField\\\",\\\"elementCategory\\\":\\\"textFields\\\",\\\"initialSize\\\":{\\\"width\\\":10,\\\"height\\\":10},\\\"lockAspectRatio\\\":false,\\\"content\\\":{\\\"text\\\":\\\"Текстовое поле\\\"},\\\"type\\\":\\\"decorativeItem\\\",\\\"properties\\\":{\\\"fontSize\\\":\\\"default\\\",\\\"borderColor\\\":\\\"default\\\",\\\"bordered\\\":false,\\\"fontColor\\\":\\\"default\\\",\\\"autoHeight\\\":true,\\\"fontBold\\\":false,\\\"fontItalic\\\":false,\\\"textAlign\\\":\\\"middleCenter\\\"},\\\"allowIntersections\\\":true,\\\"extraIndex\\\":0,\\\"key\\\":\\\"textField_0\\\"},{\\\"name\\\":\\\"rectangle\\\",\\\"elementCategory\\\":\\\"rectangles\\\",\\\"initialSize\\\":{\\\"width\\\":10,\\\"height\\\":10},\\\"lockAspectRatio\\\":false,\\\"type\\\":\\\"decorativeItem\\\",\\\"properties\\\":{\\\"color\\\":\\\"default\\\",\\\"lineWidth\\\":0.3,\\\"lineType\\\":\\\"solid\\\"},\\\"allowIntersections\\\":true,\\\"extraIndex\\\":0,\\\"key\\\":\\\"rectangle_0\\\"}],\\\"addedElements\\\":[{\\\"extraIndex\\\":0,\\\"content\\\":{\\\"text\\\":\\\"Tessstsdfdsfsdfsdf\\\"},\\\"allowIntersections\\\":true,\\\"properties\\\":{\\\"fontSize\\\":\\\"default\\\",\\\"borderColor\\\":\\\"default\\\",\\\"bordered\\\":false,\\\"fontColor\\\":\\\"default\\\",\\\"autoHeight\\\":true,\\\"fontBold\\\":false,\\\"fontItalic\\\":false,\\\"textAlign\\\":\\\"middleCenter\\\"},\\\"lockAspectRatio\\\":false,\\\"name\\\":\\\"textField\\\",\\\"key\\\":\\\"textField_0\\\",\\\"x\\\":0,\\\"y\\\":0,\\\"width\\\":218,\\\"height\\\":88,\\\"currentScale\\\":10.920298,\\\"layerIndex\\\":0,\\\"elementCategory\\\":\\\"textFields\\\",\\\"type\\\":\\\"decorativeItem\\\"},{\\\"extraIndex\\\":0,\\\"allowIntersections\\\":true,\\\"properties\\\":{\\\"color\\\":\\\"default\\\",\\\"lineWidth\\\":0.3,\\\"lineType\\\":\\\"solid\\\"},\\\"lockAspectRatio\\\":false,\\\"name\\\":\\\"rectangle\\\",\\\"key\\\":\\\"rectangle_0\\\",\\\"x\\\":276.094602,\\\"y\\\":244,\\\"width\\\":259,\\\"height\\\":302,\\\"currentScale\\\":10.920298,\\\"layerIndex\\\":1,\\\"elementCategory\\\":\\\"rectangles\\\",\\\"type\\\":\\\"decorativeItem\\\"},{\\\"allowIntersections\\\":false,\\\"properties\\\":{\\\"borderColor\\\":\\\"default\\\",\\\"bordered\\\":false,\\\"color\\\":\\\"#000\\\"},\\\"lockAspectRatio\\\":true,\\\"name\\\":\\\"dataMatrix\\\",\\\"key\\\":\\\"dataMatrix\\\",\\\"x\\\":0,\\\"y\\\":496,\\\"width\\\":109.20298000000001,\\\"height\\\":50.01490000000001,\\\"currentScale\\\":10.920298,\\\"layerIndex\\\":2,\\\"elementCategory\\\":\\\"marking\\\",\\\"type\\\":\\\"dataMatrix\\\"}],\\\"labelParameters\\\":{\\\"type\\\":\\\"label\\\",\\\"padding\\\":\\\"0 0 0 0\\\",\\\"backgroundColor\\\":\\\"rgba(255,255,255,1)\\\",\\\"defaultFontColor\\\":\\\"#000\\\",\\\"defaultElementBorderColor\\\":\\\"#000\\\",\\\"defaultFontSize\\\":8,\\\"key\\\":\\\"label\\\",\\\"labelSize\\\":[50,50]},\\\"editorSettings\\\":{\\\"gridVisible\\\":false,\\\"elementBoundariesVisible\\\":true,\\\"scale\\\":2.9,\\\"gridColor\\\":\\\"gray\\\",\\\"selectionColor\\\":\\\"rgb(10, 68, 99)\\\",\\\"wrongElementColor\\\":\\\"rgba(255, 0, 0, 0.247)\\\",\\\"backgroundElementColor\\\":\\\"rgba(90, 90, 90, 0.24)\\\",\\\"preListExpanded\\\":false},\\\"labelInfo\\\":{\\\"labelName\\\":\\\"TEST SH2\\\",\\\"comment\\\":\\\"\\\",\\\"size\\\":\\\"50x50\\\",\\\"byDefault\\\":false,\\\"mainCategory\\\":0,\\\"creationDate\\\":\\\"\\\"}}\",\"height\":50,\"width\":50,\"color\":\"#ffffff\",\"components\":[{\"componentName\":\"staticText\",\"x\":0,\"y\":0,\"height\":8.1,\"width\":20,\"border\":{\"color\":\"transparent\",\"width\":0.3,\"padding\":1},\"textProperties\":{\"alignment\":{\"horizontal\":\"Center\",\"vertical\":\"Middle\"},\"font\":{\"isBold\":false,\"isItalic\":false,\"isUnderline\":false,\"isStrikeThrough\":false,\"size\":8,\"name\":\"Bell MT\"}},\"color\":\"#000\",\"value\":\"Tessstsdfdsfsdfsdf\"},{\"componentName\":\"rectangle\",\"x\":25.3,\"y\":22.3,\"height\":27.7,\"width\":23.7,\"color\":\"transparent\",\"radius\":0,\"border\":{\"color\":\"#000\",\"width\":0.3,\"style\":\"Solid\"}},{\"x\":0,\"y\":45.4,\"height\":4.6,\"width\":10,\"border\":{\"color\":\"transparent\",\"width\":0.3,\"padding\":1},\"componentName\":\"textField\",\"textProperties\":{\"alignment\":{\"horizontal\":\"Center\",\"vertical\":\"Middle\"},\"font\":{\"isBold\":false,\"isItalic\":false,\"isUnderline\":false,\"isStrikeThrough\":false,\"size\":10,\"name\":\"Bell MT\"}},\"color\":\"#000\"}]}".ToJasperConvertableFrame();

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