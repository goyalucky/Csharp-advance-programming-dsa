/* Insertion Sort - Sort Employee IDs
Problem Statement:
A company stores employee IDs in an unsorted array. Implement Insertion Sort in C# to sort the employee IDs in ascending order.
Hint:
● Divide the array into sorted and unsorted parts.
● Pick an element from the unsorted part and insert it into its correct position in the sorted part.
● Repeat for all elements.*/


using System;

class InsertionSorting
{
	public void InsertionSort()
	{
		int[] arr = { 12, 11, 13, 5, 6 };
		for (int i = 1; i < arr.Length; i++)
		{
			int key = arr[i];
			int j = i - 1;
			while (j >= 0 && arr[j] > key)
			{
				arr[j + 1] = arr[j];
				j--;
			}
			arr[j + 1] = key;
		}
		Console.WriteLine(string.Join(", ", arr));
	}
}
