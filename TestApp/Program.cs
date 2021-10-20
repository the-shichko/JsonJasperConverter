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
                Color = "#732726",
                Components = new List<IJasperConvertable>
                {
                    new TextField
                    {
                        Height = 100, Value = "Test", Width = 100, X = 10, Y = 10,
                        Border = new TextBorder
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
                    }
                },
                Fields = new[] { "name" }
            };

            // serialization
            //var json = JsonConvert.SerializeObject(frontFrame);
            var json = JsonConvert.SerializeObject(frontFrame);

            //back to frame from "front"
            var frame = json//"{\"editorInfo\":\"{\\\"elementsToAdd\\\":[{\\\"key\\\":\\\"originCountry\\\",\\\"category\\\":\\\"common\\\",\\\"name\\\":\\\"originCountry\\\"}],\\\"newDbElements\\\":[],\\\"addedElements\\\":[{\\\"allowIntersections\\\":false,\\\"properties\\\":{\\\"fontSize\\\":\\\"default\\\",\\\"borderColor\\\":\\\"default\\\",\\\"bordered\\\":false,\\\"fontColor\\\":\\\"default\\\",\\\"autoHeight\\\":true,\\\"fontBold\\\":false,\\\"fontItalic\\\":false,\\\"textAlign\\\":\\\"topMiddle\\\"},\\\"lockAspectRatio\\\":false,\\\"name\\\":\\\"originCountry\\\",\\\"key\\\":\\\"originCountry\\\",\\\"x\\\":106,\\\"y\\\":65,\\\"width\\\":155,\\\"height\\\":60.4,\\\"currentScale\\\":7.55,\\\"layerIndex\\\":0,\\\"elementCategory\\\":\\\"common\\\",\\\"type\\\":\\\"common\\\"}],\\\"labelParameters\\\":{\\\"type\\\":\\\"label\\\",\\\"padding\\\":\\\"0 0 0 0\\\",\\\"backgroundColor\\\":\\\"rgba(255,255,255,1)\\\",\\\"defaultFontColor\\\":\\\"#000\\\",\\\"defaultElementBorderColor\\\":\\\"#000\\\",\\\"defaultFontSize\\\":8,\\\"key\\\":\\\"label\\\",\\\"labelSize\\\":[47,25]},\\\"editorSettings\\\":{\\\"gridVisible\\\":false,\\\"elementBoundariesVisible\\\":false,\\\"scale\\\":2,\\\"gridColor\\\":\\\"gray\\\",\\\"selectionColor\\\":\\\"rgb(10, 68, 99)\\\",\\\"wrongElementColor\\\":\\\"rgba(255, 0, 0, 0.247)\\\",\\\"backgroundElementColor\\\":\\\"rgba(90, 90, 90, 0.24)\\\",\\\"preListExpanded\\\":false},\\\"labelInfo\\\":{\\\"labelName\\\":\\\"test666222sad\\\",\\\"mainCategory\\\":0,\\\"size\\\":\\\"47x25\\\",\\\"byDefault\\\":true,\\\"comment\\\":\\\"1121123\\\",\\\"creationDate\\\":\\\"\\\"}}\",\"height\":25,\"width\":47,\"color\":\"#ffffff\",\"components\":[{\"x\":14.1,\"y\":8.7,\"height\":8,\"width\":20.5,\"border\":{\"color\":\"transparent\",\"width\":0.3,\"padding\":1},\"componentName\":\"originCountry\",\"textProperties\":{\"alignment\":{\"horizontal\":\"Top\",\"vertical\":\"Middle\"},\"font\":{\"isBold\":false,\"isItalic\":false,\"isUnderline\":false,\"IsStrikeThrough\":false,\"size\":8}},\"color\":\"#000\"}]}"
                .ToJasperConvertableFrame();

            //convert to jrxml
            var jrxml = frame.ConvertFrameToJasper();

            Console.WriteLine(jrxml);
            Console.ReadKey();
        }
    }
}