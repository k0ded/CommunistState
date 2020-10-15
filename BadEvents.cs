﻿using System;

namespace ConsoleGameAdventure
{
    public class BadEvents
    {
        private Random Rand = new Random();
        private int Index;

        StatsHolder statsHolder = Program.statsHolder;
        NeutralEvents neutralEvents = new NeutralEvents();
        DayManager dayManager = new DayManager();
        
        //This method calls th diffrent events based on stability and just random
        public void Events()
        {
         // Index = Rand.Next(0, 12) + 1;
         Index = 1;

          if (Index == 1 && statsHolder.Stability <= 100)
            {
                Strikes();
            }
            else if (Index == 2 && statsHolder.Stability <= 85)
            {
                Protests();
            }
            else if (Index == 3 && statsHolder.Stability <= 80)
            {
                RightUprisings();
            }
            else if (Index == 4 && statsHolder.Stability <= 70)
            {
                Riots();
            }
            else if (Index == 5 && statsHolder.Stability <= 50)
            {
                DesertionMilitary();
            }
            else if (Index == 6 && statsHolder.Stability <= 50)
            {
                InstabilityPolice();
            }
            else if (Index == 7 && statsHolder.InternationalRelation <= 30)
            {
                WarDeclaration();
            }
            else if (Index == 8 && statsHolder.Stability <= 30)
            {
                Rebellion();
            }
            else if (Index == 9 && statsHolder.Stability <= 50)
            {
                Boycott();
            }
            else if (Index == 10 && statsHolder.Stability <= 0)
            {
                CivilWar();
            }
            else if (Index == 11 && statsHolder.InternationalRelation <= 50)
            {
                Terrorism();
            }
            else if (Index == 12 && statsHolder.Stability <= 10)
            {
                Corruption();
            }
            else if (statsHolder.Stability < 90)
            {
                Events();
            }
           else 
           {
               neutralEvents.Events();
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
                case ("1"):
                    statsHolder.Stability -= Rand.Next(0, 4) + 1;
                    break;
                case ("2"):
                    statsHolder.Stability += Rand.Next(0, 4) + 1;
                    statsHolder.GoodDescisions += 1;
                    break;
                case ("3"):
                    statsHolder.Stability -= Rand.Next(0, 10) + 1;
                    statsHolder.UnhappyPopulation += Rand.Next(0, 5) + 1;
                    break;
                case ("4"):
                    statsHolder.Stability -= Rand.Next(0, 10) + 1;
                    statsHolder.UnhappyPopulation += Rand.Next(0, 5) + 1;
                    break;
                default:
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