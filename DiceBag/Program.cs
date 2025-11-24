using System;
using System.Diagnostics;

namespace DiceBag;
class Program {
    private Random _dice = new Random();

    static void Main(string[] args) {
        var program = new Program();
        program.CreateScores();
        program.DiceRoll(20);
        program.Roll(3);
    }

    void CreateScores() {
        var scores = new List<int>();

        for (var i = 0; i < 6; i++) {
            var rolls = new List<int>();
            
            // roll 4d6
            for (int j = 0; j < 4; j++) {
                rolls.Add(DiceRoll(6));
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

    int DiceRoll(int sides) {
        // Create a die of variable size
        return _dice.Next(1, sides);
    }

    void Roll(int numberOfDice) {

        // Create list
        var roll = new List<int>();
        
        for (int k = 0; k < numberOfDice; k++) {
            // Roll custom die
            roll.Add(DiceRoll(20));
        }

        // Print sum of dice
        Console.WriteLine($"You rolled a {roll.Sum()}");
    }
    
}