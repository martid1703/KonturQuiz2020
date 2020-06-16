namespace WeekChallengeBot
{
        public class GunBlock : EquipmentBlock
        {
            public override EquipmentType Type => EquipmentType.Gun;
            public int Damage;
            public int EnergyPrice;
            public int Radius;
            public EffectType EffectType;
        }
}