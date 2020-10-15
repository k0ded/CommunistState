using System;

namespace ConsoleGameAdventure
{
    internal class Program
    {

        public static StatsHolder StatsHolderInstance;
        public static StoryBoard StoryBoardInstance;

        public static void Main(string[] args)
        {
            
            string title = @"
  _____                           _     __        __       __            _            __     __             
 / ___/__  __ _  __ _  __ _____  (_)__ / /_  ___ / /____ _/ /____   ___ (_)_ _  __ __/ /__ _/ /____  ____   
/ /__/ _ \/  ' \/  ' \/ // / _ \/ (_-</ __/ (_-</ __/ _ `/ __/ -_) (_-</ /  ' \/ // / / _ `/ __/ _ \/ __/   
\___/\___/_/_/_/_/_/_/\_,_/_//_/_/___/\__/ /___/\__/\_,_/\__/\__/ /___/_/_/_/_/\_,_/_/\_,_/\__/\___/_/      
                                            ______  ____ ___                                                
     ____________________________________  <  / _ \/ __// _ \  ____________________________________         
    /___/___/___/___/___/___/___/___/___/  / /\_, /__ \/ // / /___/___/___/___/___/___/___/___/___/         
                                          /_//___/____/\___/                                                
                                                                                                            
";
            Console.WriteLine(title);

            StatsHolderInstance = new StatsHolder();
            StatsHolderInstance.Stats();
            
            StoryBoardInstance = new StoryBoard();
            StoryBoardInstance.Tutorial();
        }

        public void StoryCaller()
        {

        }
    }
}