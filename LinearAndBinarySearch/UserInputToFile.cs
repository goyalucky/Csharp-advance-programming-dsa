/* Problem 2: Read User Input and Write to File Using StreamReader
Problem: Write a program that reads user input from the console and writes it to a file.*/


using System;
using System.IO;

public class UserInputToFile
{
	public static void WriteToFile(string pa)
	{
		Console.WriteLine("Enter text to write to the file (type 'exit' to finish):");
		using (StreamWriter sw = new StreamWriter(pa))
		{
			string st;
			while (true)
			{
				st = Console.ReadLine();
				if (st.Equals("exit", StringComparison.OrdinalIgnoreCase))
					break;
				sw.WriteLine(st);
			}
		}
		Console.WriteLine($"Data successfully written to {pa}");
	}
}
