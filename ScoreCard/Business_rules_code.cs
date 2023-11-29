using System;
using System.Collections.Generic;
using System.Linq;

// Represents a domino with pips on each side
public class Domino
{
	public int PipsOnSide1 { get; }
	public int PipsOnSide2 { get; }

	public Domino(int pipsOnSide1, int pipsOnSide2)
	{
		PipsOnSide1 = pipsOnSide1;
		PipsOnSide2 = pipsOnSide2;
	}

	public int GetDominoScore()
	{
		return PipsOnSide1 + PipsOnSide2;
	}
}

// Represents a player in the game
public class Player
{
	public string Name { get; }
	public List<Domino> Dominos { get; } = new List<Domino>();
	public int RoundScore { get; private set; } = 0;
	public int TotalScore { get; private set; } = 0;
	public int ZeroPointRounds { get; private set; } = 0;

	public Player(string name)
	{
		Name = name;
	}

	// Draw a domino from the boneyard and add it to the player's hand
	public void DrawDominoFromBoneyard(List<Domino> boneyard)
	{
		if (boneyard.Count > 0)
		{
			int randomIndex = new Random().Next(0, boneyard.Count);
			Dominos.Add(boneyard[randomIndex]);
			boneyard.RemoveAt(randomIndex);
		}
	}

	// Play the round by placing the player's dominos into the round's collection
	public void PlayRound(List<Domino> roundDominos)
	{
		foreach (var domino in Dominos)
		{
			roundDominos.Add(domino);
		}
		Dominos.Clear();
	}

	// Calculate the score for the current round based on the dominos in the player's hand
	public void CalculateRoundScore()
	{
		RoundScore = Dominos.Sum(domino => domino.GetDominoScore());
	}

	// Update the player's total score and count zero-point rounds
	public void UpdateTotalScore()
	{
		TotalScore += RoundScore;
		if (RoundScore == 0)
		{
			ZeroPointRounds++;
		}
	}
}

// Represents the Mexican Train game
public class MexicanTrainGame
{
	private List<Player> players = new List<Player>();
	private List<Domino> boneyard = new List<Domino>();

	// Add a player to the game
	public void AddPlayer(string playerName)
	{
		players.Add(new Player(playerName));
	}

	// Initialize the game by creating the boneyard and shuffling it
	public void InitializeGame()
	{
		// Initialize the boneyard with dominos
		for (int i = 0; i <= 12; i++)
		{
			for (int j = i; j <= 12; j++)
			{
				boneyard.Add(new Domino(i, j));
			}
		}

		// Shuffle the boneyard
		boneyard = boneyard.OrderBy(domino => Guid.NewGuid()).ToList();
	}

	// Simulate playing a round in the game
	public void PlayRound()
	{
		List<Domino> roundDominos = new List<Domino>();

		// Draw domino for each player from the boneyard
		foreach (var player in players)
		{
			player.DrawDominoFromBoneyard(boneyard);
		}

		// Simulate player interactions and playing the round
		foreach (var player in players)
		{
			player.PlayRound(roundDominos);
		}

		// Calculate and update scores at the end of the round
		foreach (var player in players)
		{
			player.CalculateRoundScore();
			player.UpdateTotalScore();
		}
	}

	// Determine the winner based on the game rules
	public Player DetermineWinner()
	{
		// Determine the winner based on game rules
		// This could involve comparing TotalScores, zero-point rounds, and lowest non-zero point rounds

		// For simplicity, let's assume the player with the lowest TotalScore wins
		return players.OrderBy(player => player.TotalScore).First();
	}

	// Display scores after each round
	public void DisplayScores()
	{
		foreach (var player in players)
		{
			Console.WriteLine($"{player.Name}'s Total Score: {player.TotalScore}");
		}
	}

	// Display the remaining dominos in the boneyard
	public void DisplayBoneyard()
	{
		Console.Write("Boneyard: ");
		foreach (var domino in boneyard)
		{
			Console.Write($"({domino.PipsOnSide1},{domino.PipsOnSide2}) ");
		}
		Console.WriteLine();
	}
}

class Program
{
	static void Main()
	{
		// Create an instance of the Mexican Train game
		MexicanTrainGame game = new MexicanTrainGame();

		// Add players to the game
		game.AddPlayer("Player1");
		game.AddPlayer("Player2");
		// Add more players as needed

		// Initialize the game
		game.InitializeGame();

		// Play 13 rounds
		for (int round = 1; round <= 13; round++)
		{
			Console.WriteLine($"Round {round}");
			game.PlayRound();
			game.DisplayScores();
			game.DisplayBoneyard();
			Console.WriteLine();
		}

		// Determine and display the winner
		Pla
