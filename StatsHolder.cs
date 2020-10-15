using System;

namespace ConsoleGameAdventure
{
    public class StatsHolder
    {
        // Stability in percent (%)
        public int Stability;
        
        //Unhappy pop is in numbers 
        public int UnhappyPopulation;
        
        //Population is in numbers (thousands, K)
        public int Population; 
        
        //Rubels is in numbers (thousands, K)
        public int Rubels;
        
        //Food is in tons
        public int Food;
        
        //Date is numbers like day/month/year
        public string Date;
        
        //Businesses is in numbers
        public int Businesses;

        //InterRelation is in percent (%)
        public int InternationalRelation;

        //Stores how many good descisions youve made
        public int GoodDescisions;
        
        private Random Rand = new Random();
        
        //Randomly assigns values to the variables
        public void Stats()
        {
            Stability = 100;

            Population = Rand.Next(10, 1000);

            Rubels = Rand.Next(1, 100) + 1;

            Food = Rand.Next(5, 10) + 1;

            Businesses = Rand.Next(10, 100) + 1;

            InternationalRelation = 100;

            UnhappyPopulation = Rand.Next(1, 100) + 1;

            Date = Rand.Next(0, 12) + 1 + "/" + (Rand.Next(0, 30) + 1) + "/" + "1950";
        }
    }
}