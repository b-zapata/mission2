using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mission2
{
    internal class RollDice
    {
        private int[] combinationCount = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private int numOfRolls = 0;
        public RollDice(int numOfRolls)
        {
            this.numOfRolls = numOfRolls;
        }

        public int[] roll()
        {
            // Do a for loop for as many rolls as the user indicated
            for (int i = 0; i < numOfRolls; i++)
            {
                // Do a random number indicating the number that each dice got
                Random random = new Random();
                int numberDice1 = random.Next(1, 7);
                int numberDice2 = random.Next(1, 7);
                int combination = numberDice1 + numberDice2;
                int combinationIndex = (combination - 2);
                combinationCount[combinationIndex]++;
            }

            return combinationCount;   
        }
    }
}
