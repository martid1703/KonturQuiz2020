using System.Collections.Generic;

namespace WeekChallengeBot
{
        public class Ship
        {
            public int Id;
            public Vector Velocity;
            public Vector Position;
            public int Energy;
            public int? Health;
            public List<EquipmentBlock> Equipment;
        }
}