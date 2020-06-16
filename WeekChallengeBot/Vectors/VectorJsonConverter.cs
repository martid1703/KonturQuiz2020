using System;
using Newtonsoft.Json;

namespace WeekChallengeBot
{
        public class VectorJsonConverter : JsonConverter<Vector>
        {
            public override void WriteJson(JsonWriter writer, Vector value, JsonSerializer serializer)
            {
                if (value == null)
                {
                    writer.WriteNull();
                    return;
                }

                var stringVector = $"{value.X}/{value.Y}/{value.Z}";
                writer.WriteValue(stringVector);
            }

            public override Vector ReadJson(JsonReader reader, Type objectType, Vector existingValue, bool hasExistingValue,
                JsonSerializer serializer)
            {
                if (reader.Value == null)
                {
                    return null;
                }
            
                if (reader.ValueType != typeof(string))
                {
                    throw new Exception(reader.Value.ToString());
                }

                var value = (string) reader.Value;
                var components = value.Split(new [] {'/'}, 3);
                if (components.Length != 3)
                {
                    throw new Exception(reader.Value.ToString());
                }

                var x = ParseComponent(components[0]);
                var y = ParseComponent(components[1]);
                var z = ParseComponent(components[2]);
            
                return new Vector(x, y, z);
            }

            private static int ParseComponent(string componentValue)
            {
                if (!int.TryParse(componentValue, out var value))
                {
                    throw new Exception(componentValue);
                }

                return value;
            }
        }
}