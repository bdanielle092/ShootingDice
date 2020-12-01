using System;
using System.Collections.Generic;
namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player

    {
        // this is a list of taunts 
        List<String> SmackTalk = new List<String>
        {
            "Vibe",
            "Ok whatever you say",
            "Well you won because your fast"
        };

        public override void Play(Player other)
        {
            // This is looking at the list then picking at Random which taunt to use. 
            int SmackTalkSaying = new Random().Next(0, SmackTalk.Count);
            // Call roll for "this" object and for the "other" object
            int myRoll = Roll();
            int otherRoll = other.Roll();

            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");
            if (myRoll > otherRoll)
            {
                Console.WriteLine($"{Name} Wins!");
            }
            else if (myRoll < otherRoll)
            {
                Console.WriteLine($"{other.Name} Wins!");
            }
            else
            {
                // if the rolls are equal it's a tie
                Console.WriteLine("It's a tie");
            }
        }
    }
}