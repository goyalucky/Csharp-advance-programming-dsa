/*Game Score System
When score changes:
Update UI
Check for bonus
Save score*/


using System;

public class ScoreChangedEventArgs : EventArgs
{
	public int Score { get; }

	public ScoreChangedEventArgs(int score)
	{
		Score = score;
	}
}

public class Maintanability

public class Game
{
	int score;
	public event EventHandler<ScoreChangedEventArgs> ScoreChanged;

	public void AddScore(int points)
	{
		score += points;
		ScoreChanged?.Invoke(this, new ScoreChangedEventArgs(score));
	}
}

public class UI
{
	public static void Update(object s, ScoreChangedEventArgs e)
	{
		Console.WriteLine("UI updated. Score: " + e.Score);
	}
}

public class Bonus
{
	public static void Check(object s, ScoreChangedEventArgs e)
	{
		if (e.Score >= 100)
			Console.WriteLine("Bonus unlocked!");
	}
}

public class ScoreStorage
{
	public static void Save(object s, ScoreChangedEventArgs e)
	{
		Console.WriteLine("Score saved: " + e.Score);
	}
}
