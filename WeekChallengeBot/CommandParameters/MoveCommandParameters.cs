namespace WeekChallengeBot
{
        public class MoveCommandParameters : CommandParameters
        {
            public int Id { get; }
            public Vector Target { get; }

            public MoveCommandParameters(int shipId, Vector target)
            {
                Id = shipId;
                Target = target;
            }
        }
}