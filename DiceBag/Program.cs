using System;
using System.Diagnostics;

namespace AbilityScoreGenerator {
    class Program {
        static void Main(string[] args) {
            Random random = new Random();
            List<int> d6 = new List<int>();

            for (int x = 0; x <= 6;  x++) {


            //roll 4d6
            for (int i = 0; i <= 4; i++) {
                d6.Add(random.Next(1, 7));
            }
            //remove minimum
            d6.Remove(d6.Min());
            //sum remaining 3 values
            int sum = d6.Sum();

            //print result
            Console.WriteLine($"Sum:{sum}");
        }
    }
}