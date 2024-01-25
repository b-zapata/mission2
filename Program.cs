using mission2;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.WriteLine("");
        Console.WriteLine("How many dice rolls would you like to simulate?");
        int numOfRolls = int.Parse(Console.ReadLine());
        Console.WriteLine("");

        RollDice rd = new RollDice(numOfRolls);
        int[] combinationsCount = rd.roll();
        double[] combinationPcts = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0];

        // This code is just to make sure that the correct number of rolls are being rolled
        /*
        int rollsCount = 0;

        Console.WriteLine("===== test run ======");

        for(int i = 0; i < numOfRolls; i++)
        {
            rollsCount++;
        }

        Console.WriteLine("Rolls count: " + rollsCount);
        Console.WriteLine("====== test run over ======");
        */

        int totalPct = 0;

        for (int i = 0; i < combinationPcts.Length; i++)
        {
            //Console.WriteLine("===============");
            //Console.WriteLine("Combination: " + (i + 2));
            //Console.WriteLine("Combination count: " + combinationsCount[i]);    
            double pct = ((double)combinationsCount[i] / numOfRolls) * 100;
            //Console.WriteLine("non-rounded pct: " + pct);
            int roundedPct = (int)Math.Round(pct);
            //Console.WriteLine("rounded pct: " + roundedPct);
            combinationPcts[i] = roundedPct;
            totalPct += roundedPct;
        }

        //Console.WriteLine("Total Pct: " + totalPct);
        //Console.WriteLine("CombinationsCount: " + combinationsCount);
        //Console.WriteLine("Combinations Pct: " + combinationPcts);

        //We have the array of combinations and percentages, we now need to calculate the number of stars that will go in each line to create the histogram.
        Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine("Total number of rolls = " + numOfRolls + ".");
        Console.WriteLine("");

        //Console.WriteLine("CombinationPcts Length: " + combinationPcts.Length);

        for (int i = 0; i < combinationPcts.Length; i++)
        {
            string stars = "";
            //Console.WriteLine("Combination: " + (i + 2));
            //Console.WriteLine("Pct for Combination " + (i + 2) + ": " + combinationPcts[i]);
            for (int j = 0; j < combinationPcts[i]; j++)
            {
                stars = stars + "*";

            }
            Console.WriteLine((i + 2) + ": " + stars);
        }

        Console.WriteLine("");
        Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");

    }
}