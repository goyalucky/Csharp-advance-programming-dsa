/* Problem 1: Concatenate Strings Efficiently Using StringBuilder
Problem: You are given an array of strings. Write a program that uses StringBuilder to
concatenate all the strings in the array efficiently.*/


using System;
using System.Text;

public class StringConcantenate
{
	public static string ConcantenateStrings(string[] arr)
	{
		StringBuilder sb = new StringBuilder();
		foreach(string s in arr)
		{
			sb.Append(s);
		}
		return sb.ToString();
	}
}