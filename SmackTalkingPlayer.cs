using System;

namespace ShootingDice
{

    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer : Player
    {
        // this = one taunt from the player 
        public string Taunt { get; } = "Freeze!";

        public override int Roll()
        {
            Console.WriteLine($"{Name} shouts {Taunt}");
            // Return a random number between 1 and DiceSize
            return new Random().Next(DiceSize) + 1;
        }

    }

}