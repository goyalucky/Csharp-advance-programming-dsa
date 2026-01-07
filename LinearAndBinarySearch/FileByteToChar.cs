/*Problem 1: Convert Byte Stream to Character Stream Using StreamReader
Problem: Write a program that uses StreamReader to read binary data from a file and print
it as characters.*/


using System;
using System.IO;

public class FileByteToChar
{
	public static void ConvertAndPrint(string p)
	{
		using (FileStream fs = new FileStream(p, FileMode.Open, FileAccess.Read))
		using (StreamReader sr = new StreamReader(fs))
		{
			string content = sr.ReadToEnd();
			Console.WriteLine("File content as characters:");
			Console.WriteLine(content);
		}
	}
}
