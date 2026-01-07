/* Scenario 2: Music Playlist Queue
Use Case: A music player plays songs one after another and can dynamically add/remove songs.
Why LinkedList? Dynamic addition/removal from both ends.
OOP Concepts:
● Encapsulation: Playlist data is secured.
● Abstraction: Methods like playNext(), addSong() simplify usage.
● Polymorphism: If we extend MediaPlayer, it could play videos, podcasts, etc.*/


using System;
using System.Collections.Generic;

// Abstraction + Polymorphism
abstract class MediaPlayer
{
	public abstract void Add(string media);
	public abstract void PlayNext();
	public abstract void Remove(string media);
}

// Encapsulation + Playlist Logic
class MusicPlayer : MediaPlayer
{
	private LinkedList<string> playlist = new LinkedList<string>();

	public override void Add(string song)
	{
		playlist.AddLast(song);
		Console.WriteLine("Added: " + song);
	}

	public override void PlayNext()
	{
		if (playlist.Count == 0)
		{
			Console.WriteLine("Playlist is empty.");
			return;
		}

		string currentSong = playlist.First.Value;
		Console.WriteLine("Playing: " + currentSong);
		playlist.RemoveFirst();
	}

	public override void Remove(string song)
	{
		if (playlist.Remove(song))
			Console.WriteLine("Removed: " + song);
		else
			Console.WriteLine("Song not found.");
	}
}
