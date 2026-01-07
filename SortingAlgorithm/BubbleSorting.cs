/* Bubble Sort - Sort Student Marks
Problem Statement:
A school maintains student marks in an array. Implement Bubble Sort in C# to sort the student marks in ascending order.
Hint:
● Traverse through the array multiple times.
● Compare adjacent elements and swap them if needed.
● Repeat the process until no swaps are required.*/


using System;

class BubbleSorting
{
	public void BubbleSort()
	{
		int []arr = { 92, 76, 89, 54, 71, 97 };
		for(int i=0;i<arr.Length-1; i++)
		{
			for(int j = 0; j < arr.Length - i - 1; j++)
			{
				if (arr[j] > arr[j + 1])
				{
					int temp = arr[j];
					arr[j] = arr[j + 1];
					arr[j + 1] = temp;
				}
			}
		}
		Console.WriteLine(string.Join(",", arr));
	}
}