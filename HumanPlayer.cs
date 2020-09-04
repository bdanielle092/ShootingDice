using System;
namespace ShootingDice
{
    // TODO: Complete this class

    // A player that prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override int Roll()
        {
            Console.WriteLine("Please enter a number");
            // use Int32.Parse to turn any string into an int. The readline read the number that is entered.
            int Number = Int32.Parse(Console.ReadLine());

            // Return a random number between 1 and DiceSize
            return Number;
        }
    }
}