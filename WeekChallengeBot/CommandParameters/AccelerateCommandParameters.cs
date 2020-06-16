namespace WeekChallengeBot
{
        public class AccelerateCommandParameters : CommandParameters
        {
            public int Id { get; }
            public Vector Vector { get; }

            public AccelerateCommandParameters(int id, Vector vector)
            {
                Id = id;
                Vector = vector;
            }
        }
}