using System;
using System.Diagnostics;

namespace DiceBag {
    class Program {
        static void Main(string[] args) {
            Random dice = new Random();
            var scores = new List<int>();

            for (var x = 0; x < 6; x++) {
                var rolls = new List<int>();
                
                // roll 4d6
                for (int i = 0; i < 4; i++) {
                    rolls.Add(dice.Next(1, 7));
                }

                // remove minimum
                rolls.Remove(rolls.Min());
                
                // sum remaining 3 values
                scores.Add(rolls.Sum());
            }

            foreach (var score in scores) {
                Console.WriteLine($"Your score is {score}");
            }
        }
    }
}