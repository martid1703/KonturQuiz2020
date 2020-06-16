namespace WeekChallengeBot
{
        public class EnergyBlock : EquipmentBlock
        {
            public override EquipmentType Type => EquipmentType.Energy;
            public int IncrementPerTurn;
            public int MaxEnergy;
            public int StartEnergy;
        }
}