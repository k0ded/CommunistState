﻿using System;

namespace ConsoleGameAdventure
{
    public class DayManager
    {
        StatsHolder statsHolder = Program.statsHolder;
        BadEvents badEvents = new BadEvents();
        NeutralEvents neutralEvents = new NeutralEvents();

        private Random Rand = new Random();

        public void StartGame()
        {
            StoryBoard storyBoard = new StoryBoard();
            storyBoard.Tutorial();
        }
        public void CreateGame()
        {
            Console.Clear();
            NextDay();
        }
            
        public void StatBar()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(" -- Rubels: " + statsHolder.Rubels + "k" + " || Stability: " + statsHolder.Stability + "%" + " || Population: " + statsHolder.Population + "k" + " || Food: " + statsHolder.Food + " Tons" + " || Buisnesses: " + statsHolder.Businesses + " || Revolting population: " + statsHolder.UnhappyPopulation + " || International relation: " + statsHolder.InternationalRelation + "%" + " || Date: " + statsHolder.Date + " -- ");
        }
        
        public void NextDay()
        {
            
            StatBar();
           int index = Rand.Next(0, 2) + 1;

           switch (index)
           {
               case (1):
                   neutralEvents.Events();
                   break;
               case (2):
                   badEvents.Events();
                   break;
               default:
                   break;
           }
        }
    }
}