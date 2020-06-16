namespace WeekChallengeBot
{
        public class AttackCommandParameters : CommandParameters
        {
            public int Id { get; }
            public string Name { get; }
            public Vector Target { get; }

            public AttackCommandParameters(int id, string gunName, Vector target)
            {
                Id = id;
                Name = gunName;
                Target = target;
            }
        }
}