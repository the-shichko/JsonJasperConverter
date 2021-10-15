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
                    new StaticText { Height = 100, Value = "Славик", Width = 100, X = 10, Y = 10 },
                    new StaticText { Height = 50, Value = "Курганов", Width = 100, X = 10, Y = 100 },
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