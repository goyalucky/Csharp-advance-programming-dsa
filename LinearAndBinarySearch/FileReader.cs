/* Problem 1: Read a File Line by Line Using StreamReader
Problem: Write a program that uses StreamReader to read a text file line by line and print
each line to the console.*/


using System;
using System.IO;

public class FileReader
{
	public static void ReadFile(string path)
	{
		using(StreamReader sr = new StreamReader(path))
		{
			string line;
			while((line = sr.ReadLine()) != null)
			{
				Console.WriteLine(line);
			}
		}
	}
}