using System.Linq;

namespace WeekChallengeBot
{
    public partial class Program
    {
        public static void Main(string[] args)
        {
            var centerOfGalaxy = new Vector(15, 15, 15);

            // draft
            var draftOptions = IO.ReadInput<DraftOptions>();
            var autoDraftChoice = new DraftChoice();
            IO.SendOutput(autoDraftChoice);

            // battle
            while (true)
            {
                var state = IO.ReadInput<BattleState>();
                var output = new BattleOutput { Message = $"I have {state.My.Count} ships and move to center of galaxy" };

                foreach (var ship in state.My)
                {
                    output.UserCommands.Add(new UserCommand
                    {
                        Command = "MOVE",
                        Parameters = new MoveCommandParameters(ship.Id, centerOfGalaxy)
                    });

                    var gun = ship.Equipment.OfType<GunBlock>().FirstOrDefault();
                    if (gun != null)
                    {
                        output.UserCommands.Add(new UserCommand
                        {
                            Command = "ATTACK",
                            Parameters = new AttackCommandParameters(ship.Id, gun.Name, centerOfGalaxy)
                        });
                    }
                }

                IO.SendOutput(output);
            }
        }
    }
}
