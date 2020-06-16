using Newtonsoft.Json;

namespace WeekChallengeBot
{
        [JsonConverter(typeof(VectorJsonConverter))]
        public class Vector
        {
            public Vector(int x, int y, int z)
            {
                X = x;
                Y = y;
                Z = z;
            }

            public int X { get; }
            public int Y { get; }
            public int Z { get; }
        }
}