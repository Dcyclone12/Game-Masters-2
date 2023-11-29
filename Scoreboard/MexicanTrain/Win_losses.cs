using System;
using System.Collections.Generic;

public class MexicanTrainGame
{
    // Define a class to represent a player and their score
    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }
    }

    // Method to determine the winner after multiple rounds
    public static Player DetermineWinner(List<Player> players)
    {
        // Assuming the game is played over a fixed number of rounds, for example, 5 rounds
        int numberOfRounds = 5;

        for (int round = 1; round <= numberOfRounds; round++)
        {
            Console.WriteLine($"Round {round}");

            
            Random random = new Random();
            foreach (Player player in players)
            {
                int roundScore = random.Next(0, 50); 
                player.Score += roundScore;
                Console.WriteLine($"{player.Name} scored {roundScore} in Round {round}. Total Score: {player.Score}");
            }

            Console.WriteLine();
        }

        // Determine the winner based on the lowest total score
        Player winner = players[0]; 

        foreach (Player player in players)
        {
            if (player.Score < winner.Score)
            {
                winner = player;
            }
        }

        Console.WriteLine($"The winner is {winner.Name} with a total score of {winner.Score}");
        return winner;
    }

    // Example usage
    public static void Main()
    {
        // Create players
        List<Player> players = new List<Player>
        {
            new Player { Name = "Player1", Score = 0 },
            new Player { Name = "Player2", Score = 0 },
            new Player { Name = "Player3", Score = 0 }
        };

        // Determine the winner after multiple rounds
        Player overallWinner = DetermineWinner(players);

        Console.ReadLine(); 
    }
}
