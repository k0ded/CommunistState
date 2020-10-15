﻿using System;
using System.Threading;

namespace ConsoleGameAdventure
{
    public class StoryBoard
    {
        DayManager dayManager = new DayManager();
        public void Tutorial()
        {
            string s = @"You are a communist leader of a communist state. Your descisions affect your popularity.
            The more bad descisions you make the more the people hate you BUT you will gain more from it.
            Makeing nice descisions will affect your relation with other communist states and will affect you
            negatively but make the people happier. The people of your state is on their way to your office
            to kill you. Your goal is to stop them before they reach you and kill you. Making nice descisions
            might spare your life but you will forever be remembered as the weak leader.";

            Console.WriteLine(s);
            
            Console.WriteLine("");
            Console.WriteLine("You can win the game in these ways:");
            Console.WriteLine("1. Eliminate the resistance in a month");
            Console.WriteLine("2. Get spared by the resistance when they get to your office");
            Console.WriteLine("");
            Console.WriteLine("These are the ways you can lose:");
            Console.WriteLine("1. The resistance kills you");
            Console.WriteLine("2. Get eliminated by other countries which is a result of bad relations with countries");
            
            Console.WriteLine("");
            Console.WriteLine("Do you want a more advanced tutorial? Type number to procede");
            Console.WriteLine("1) Yes");
            Console.WriteLine("2) No"); 

            String input = Console.ReadLine();

            if (input == "1")
            {
                MoreTutorial();
            }
            else if (input == "2")
            {
                dayManager.CreateGame();
            }
            else
            {
                Console.Clear();
                Tutorial();
                Console.ReadKey();
            }
            
        }

        public void MoreTutorial()
        {
            Console.Clear();

            Console.WriteLine("Each day for 30 days you will get a event. The event can be good or bad or even a descision for you to make.");
            Console.WriteLine("You decide what you want to do while controlling your country. Make the best descisions to not lose.");
            Console.WriteLine("Each day that passes the human mob will get closer to you and on the 30th day they will get into your");
            Console.WriteLine("office. You need to keep your stability, food, rubels, happy population, international relation high and good");

            Console.WriteLine("");
            Console.WriteLine("Press any key to procede");
            Console.ReadKey();
            dayManager.CreateGame();
        }
    }
}