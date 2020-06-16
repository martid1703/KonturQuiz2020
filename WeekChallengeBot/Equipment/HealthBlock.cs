namespace WeekChallengeBot
{
        public class HealthBlock : EquipmentBlock
        {
            public override EquipmentType Type => EquipmentType.Health;
            public int MaxHealth;
            public int StartHealth;
        }
}