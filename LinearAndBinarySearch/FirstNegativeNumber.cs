/*Linear Search Problem 1: Search for the First Negative Number
Problem: You are given an integer array. Write a program that performs Linear Search to find the first negative number in the array.*/


using System;

public class FirstNegativeNumber
{
	public void FirstNegative()
	{
		int []arr = { 7, -9, -4, 6 };
		for(int i = 0; i < arr.Length; i++)
		{
			if (arr[i] < 0)
			{
				Console.WriteLine(arr[i]);
				break;
			}
		}
	}
} 