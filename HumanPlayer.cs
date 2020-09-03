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
            int Number = Int32.Parse(Console.ReadLine());

            // Return a random number between 1 and DiceSize
            return Number;
        }
    }
}