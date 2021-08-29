

using System;

namespace Preparatioin_for_the_exam
{
    class Program
    {
        static void Main(string[] args)
        {
            //Входни данни
            string nameOfTournament = string.Empty;
            int countOfMatches = 0;
            int wonPoints = 0;
            int enemyPoints = 0;
            int totalMatches = 0;
            double wonMatches = 0;
            double lostMatches = 0;
            int gamesPlayed1 = 0;
            double gamesPlayed = 0;
            //Логика
            nameOfTournament = Console.ReadLine();
            while (nameOfTournament != "End of tournaments")
            {
                countOfMatches = int.Parse(Console.ReadLine());
                for (int broi = 0; broi < countOfMatches; broi++)
                {
                    wonPoints = int.Parse(Console.ReadLine());
                    enemyPoints = int.Parse(Console.ReadLine());
                    gamesPlayed1++;
                    gamesPlayed = gamesPlayed1;
                    if (wonPoints > enemyPoints)
                    {
                        Console.WriteLine($"Game {gamesPlayed} of tournament {nameOfTournament}: win with {wonPoints - enemyPoints} points.");
                        wonMatches++;
                        wonMatches = wonMatches;
                    }
                    else
                    {
                        Console.WriteLine($"Game {gamesPlayed} of tournament {nameOfTournament}: lost with {enemyPoints - wonPoints} points.");
                        lostMatches++;
                        lostMatches = lostMatches;
                    }
                }
                totalMatches += countOfMatches;
                nameOfTournament = Console.ReadLine();
            }
            double totalMatchesWhichAreWinned = wonMatches;
            double totalMatchesWhichAreLoosed = lostMatches;
            double ttoottaallMatches = totalMatches;
            if (nameOfTournament == "End of tournaments")
            {
                Console.WriteLine($"{(totalMatchesWhichAreWinned/ttoottaallMatches)*100:f2}% matches win");
                Console.WriteLine($"{(totalMatchesWhichAreLoosed/ttoottaallMatches)*100:f2}% matches lost");

            }
        }
    }
}
