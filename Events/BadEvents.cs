using System;

namespace ConsoleGameAdventure
{
    public class BadEvents
    {
        private Random Rand = new Random();
        private int Index;

        StatsHolder statsHolder;
        DayManager dayManager;
        NeutralEvents neutralEvents;

        public BadEvents(StatsHolder holder, DayManager manager, NeutralEvents events)
        {
            statsHolder = holder;
            dayManager = manager;
            neutralEvents = events;
        }
        
        //This method calls th diffrent events based on stability and just random
        public void Events()
        {
            // Index = Rand.Next(0, 12) + 1;
            Index = 1;

            switch (Index)
            {
                case 1 when statsHolder.Stability <= 100:
                    Strikes();
                    break;
                case 2 when statsHolder.Stability <= 85:
                    Protests();
                    break;
                case 3 when statsHolder.Stability <= 80:
                    RightUprisings();
                    break;
                case 4 when statsHolder.Stability <= 70:
                    Riots();
                    break;
                case 5 when statsHolder.Stability <= 50:
                    DesertionMilitary();
                    break;
                case 6 when statsHolder.Stability <= 50: 
                    InstabilityPolice(); 
                    break;
                case 7 when statsHolder.InternationalRelation <= 30:
                    WarDeclaration(); 
                    break;
                case 8 when statsHolder.Stability <= 30:
                    Rebellion();
                    break;
                case 9 when statsHolder.Stability <= 50:
                    Boycott();
                    break;
                case 10 when statsHolder.Stability <= 0:
                    CivilWar();
                    break;
                case 11 when statsHolder.InternationalRelation <= 50:
                    Terrorism();
                    break;
                case 12 when statsHolder.Stability <= 10:
                    Corruption();
                    break;
                default:
                {
                    if (statsHolder.Stability < 90)
                    { 
                        Events();
                    }
                    else 
                    { 
                        neutralEvents.Events();
                    }
                    break;
                }
             }
        }

        //After this comment is all the events stored for easy access
        
        public void Strikes()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Your population grows impatient. They decide to strike.");
            Console.ForegroundColor = ConsoleColor.White;

            statsHolder.UnhappyPopulation += Rand.Next(0, 100) + 1;

            Console.WriteLine("");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1) Let the strikes procede");
            Console.WriteLine("2) Lower the workload for the workers");
            Console.WriteLine("3) Punish the strikers");
            Console.WriteLine("4) Use military force");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    statsHolder.Stability -= Rand.Next(0, 4) + 1;
                    break;
                case "2":
                    statsHolder.Stability += Rand.Next(0, 4) + 1;
                    statsHolder.GoodDescisions += 1;
                    break;
                case "3":
                    statsHolder.Stability -= Rand.Next(0, 10) + 1;
                    statsHolder.UnhappyPopulation += Rand.Next(0, 5) + 1;
                    break;
                case "4":
                    statsHolder.Stability -= Rand.Next(0, 10) + 1;
                    statsHolder.UnhappyPopulation += Rand.Next(0, 5) + 1;
                    break;
            }
            dayManager.CreateGame();
        }

        public void Protests()
        {
            Console.WriteLine("Protests");
        }

        public void RightUprisings()
        {
            Console.WriteLine("Rightuprising");
        }

        public void Riots()
        {
            Console.WriteLine("Riots");
        }

        public void DesertionMilitary()
        {
            Console.WriteLine("Desertion");
        }

        public void InstabilityPolice()
        {
            Console.WriteLine("instability");
        }

        public void WarDeclaration()
        {
            Console.WriteLine("War");
        }

        public void Rebellion()
        {
            Console.WriteLine("Rebellion");
        }

        public void Boycott()
        {
            Console.WriteLine("Boycott");
        }

        public void CivilWar()
        {
            Console.WriteLine("Civilwar");
        }

        public void Terrorism()
        {
            Console.WriteLine("Terrorism");
        }

        public void Corruption()
        {
            Console.WriteLine("Corruption");
        }
    }
}