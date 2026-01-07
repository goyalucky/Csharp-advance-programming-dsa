/* StringBuilder Problem 2: Remove Duplicates from a String Using StringBuilder
Problem: Write a program that uses StringBuilder to remove all duplicate characters from a
given string while maintaining the original order. */


using System;
using System.Text;


class RemoveDuplicates
{
	public void ShowRemoveDuplicate()
	{
		string s = "luucky";
		StringBuilder sb = new StringBuilder();
		for (int i = 0; i < s.Length; i++)
		{
			if (sb.ToString().IndexOf(s[i])==-1)
			{
				sb.Append(s[i]);
			}
		}
		Console.WriteLine(sb.ToString());
	}
}