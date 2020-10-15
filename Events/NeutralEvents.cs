using System;

namespace ConsoleGameAdventure
{
    public class NeutralEvents
    {
        
        private Random Rand = new Random();
        private int Index;
        public void Events()
        {
            Index = Rand.Next(0, 9) + 1;

            if (Index == 1)
            {
                HeroLeader();
            }
            else if (Index == 2)
            {
                WorkersDay();
            }
            else if (Index == 3)
            {
                MilitaryEnthusiasm();
            }
            else if (Index == 4)
            {
                GreatHarvest();
            }
            else if (Index == 5)
            {
                WorkersSafety();
            }
            else if (Index == 6)
            {
                WorkerSalary();
            }
            else if (Index == 7)
            {
                BuildLocation();
            }
            else if (Index == 8)
            {
                PoliceStrenght();
            }
            else if (Index == 9)
            {
                InternationalCouncil();
            }
        }

        public void HeroLeader()
        {
            Console.WriteLine("HeroLeader");
        }

        public void WorkersDay()
        {
            Console.WriteLine("WorkersDay");
        }

        public void MilitaryEnthusiasm()
        {
            Console.WriteLine("MilitaryEnthusiasm");
        }

        public void GreatHarvest()
        {
            Console.WriteLine("GreatHarvest");
        }
        
        //Now comes descisions that you make

        public void WorkersSafety()
        {
            Console.WriteLine("WorkersSafety");
        }

        public void WorkerSalary()
        {
            Console.WriteLine("WorkersSalary");
        }

        public void BuildLocation()
        {
            Console.WriteLine("BuildLocation");
        }

        public void PoliceStrenght()
        {
            Console.WriteLine("PoliceStrenght"); 
        }

        public void InternationalCouncil()
        {
            Console.WriteLine("InternationalCouncil");
        }
    }
}