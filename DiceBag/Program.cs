using System;
using System.Diagnostics;

namespace DiceBag;
class Program {
    static void Main(string[] args) {
        Random dice = new Random();
        var scores = new List<int>();

        for (var i = 0; i < 6; i++) {
            var rolls = new List<int>();
            
            // roll 4d6
            for (int j = 0; j < 4; j++) {
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