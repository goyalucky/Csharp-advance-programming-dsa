/* Problem 2: Count the Occurrence of a Word in a File Using StreamReader
Problem: Write a program that reads a file and counts how many times a specific word
appears in the file.*/


using System;
using System.IO;

public class FileWordCounter()
{
	public static int CountWord(string path, string wordCount)
	{
		int count = 0;
		foreach (string s in File.ReadAllLines(path)){
			string[] words = s.Split(' ');
			foreach(string word in words)
			{
				if (word.Equals(wordCount, StringComparison.OrdinalIgnoreCase))
					count++;
			}
		}
		return count;
	}
}