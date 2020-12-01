using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player whose role will always be in the upper half of their possible rolls
    public class UpperHalfPlayer : Player
    {

        public override int Roll()
        {

            // Return a random number between 1 and DiceSize
            // the player cannot roll lower than a 4. Its the minimum number 
            return new Random().Next(4, DiceSize) + 1;
        }
    }
}