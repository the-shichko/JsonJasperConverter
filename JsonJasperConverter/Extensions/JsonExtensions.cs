using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using JsonJasperConverter.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JsonJasperConverter.Extensions
{
    public static class JsonExtensions
    {
        public static Frame ToJasperConvertableFrame([NotNull] this string json)
        {
            var frame = new Frame();
            var frameJObject = (JObject)JsonConvert.DeserializeObject(json);

            if (frameJObject == null) throw new Exception("JObject is null");

            foreach (var propertyInfo in frame.GetType().GetProperties().Where(x => x.PropertyType.IsValueType))
            {
                propertyInfo.SetValue(frame,
                    Convert.ChangeType(
                        frameJObject.GetValue(propertyInfo.Name, StringComparison.CurrentCultureIgnoreCase),
                        propertyInfo.PropertyType));
            }

            frame.Components =
                ToJasperConvertable(JsonConvert.SerializeObject(frameJObject.GetValue("Components",
                    StringComparison.CurrentCultureIgnoreCase)));
            frame.Fields = frameJObject.GetValue("Fields", StringComparison.CurrentCultureIgnoreCase)
                ?.ToObject<List<string>>();
            return frame;
        }

        /// <summary>
        /// Json must contain IJasperConvertable objects
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static IEnumerable<IJasperConvertable> ToJasperConvertable(this string json)
        {
            var list = new List<IJasperConvertable>();
            var jObjects = JsonConvert.DeserializeObject(json);

            if (!(jObjects is JArray array)) throw new Exception("json is not jArray");

            list.AddRange(from item in array
                let type = JObject.Parse(JsonConvert.SerializeObject(item))
                    .GetValue("ComponentName", StringComparison.CurrentCultureIgnoreCase)
                let typeClass = Type.GetType($"JsonJasperConverter.Models.{type.ToString().FirstCharToUpperCase()}") ??
                                throw new Exception(
                                    "Cannot found class. Class must be in namespace JsonJasperConverter.Models.YourClass")
                select item.ToObject(typeClass) as IJasperConvertable);

            return list;
        }
    }
}