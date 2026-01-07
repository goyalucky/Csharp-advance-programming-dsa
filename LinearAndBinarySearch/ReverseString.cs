/* StringBuilder Problem 1: Reverse a String Using StringBuilder
Problem: Write a program that uses StringBuilder to reverse a given string. For example, if
the input is "hello", the output should be "olleh".*/


using System;
using System.Text;

class ReverseString
{
	public void StringReverse()
	{
		string s = "hello";
		StringBuilder sb = new StringBuilder();
		for (int i = s.Length - 1; i >= 0; i--)
		{
			sb.Append(s[i]);
		}
		Console.WriteLine(sb.ToString());
	}
}
