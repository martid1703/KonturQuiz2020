using System;
using Newtonsoft.Json;

namespace WeekChallengeBot
{
    public class IO
    {
        public static T ReadInput<T>()
        {
            var line = Console.ReadLine();
            return JsonConvert.DeserializeObject<T>(line);
        }

        public static void SendOutput(object output)
        {
            var outputStr = JsonConvert.SerializeObject(output);
            Console.WriteLine(outputStr);
        }
    }
}
