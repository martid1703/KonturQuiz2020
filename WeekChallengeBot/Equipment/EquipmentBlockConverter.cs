using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WeekChallengeBot
{
        public class EquipmentBlockConverter : JsonConverter<EquipmentBlock>
        {
            public override void WriteJson(JsonWriter writer, EquipmentBlock value, JsonSerializer serializer)
            {
                throw new NotImplementedException();
            }

            public override EquipmentBlock ReadJson(
                JsonReader reader,
                Type objectType,
                EquipmentBlock existingValue,
                bool hasExistingValue,
                JsonSerializer serializer)
            {
                var obj = JObject.Load(reader);
                var type = obj[nameof(EquipmentBlock.Type)].ToObject<EquipmentType>();

                EquipmentBlock equipmentBlock;
                switch (type)
                {
                    case EquipmentType.Energy:
                        equipmentBlock = new EnergyBlock();
                        break;
                    case EquipmentType.Gun:
                        equipmentBlock = new GunBlock();
                        break;
                    case EquipmentType.Engine:
                        equipmentBlock = new EngineBlock();
                        break;
                    case EquipmentType.Health:
                        equipmentBlock = new HealthBlock();
                        break;
                    default:
                        throw new NotSupportedException($"Unknown equipment {obj}");
                }
            
                serializer.Populate(obj.CreateReader(), equipmentBlock);
                return equipmentBlock;
            }
        }
}