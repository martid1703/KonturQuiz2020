using Newtonsoft.Json;

namespace WeekChallengeBot
{
        [JsonConverter(typeof(EquipmentBlockConverter))]
        public abstract class EquipmentBlock
        {
            public string Name;
            public abstract EquipmentType Type { get; }
        }
}