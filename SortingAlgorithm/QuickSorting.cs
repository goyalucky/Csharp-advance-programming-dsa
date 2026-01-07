/* Quick Sort - Sort Product Prices
Problem Statement:
An e-commerce company wants to display product prices in ascending order. Implement Quick Sort in C# to sort the product prices.
Hint:
● Pick a pivot element (first, last, or random).
● Partition the array such that elements smaller than the pivot are on the left and larger ones are on the right.
● Recursively apply Quick Sort on left and right partitions.*/


using System;

class QuickSorting
{
	public static void Sort(int[] arr1, int low, int high)
	{
		if (low < high)
		{
			int pi = Partition(arr1, low, high);
			Sort(arr1, low, pi - 1);
			Sort(arr1, pi + 1, high);
		}
	}

	private static int Partition(int[] arr1, int low, int high)
	{
		int pivot = arr1[high], i = low - 1;
		for (int j = low; j < high; j++)
		{
			if (arr1[j] < pivot)
			{
				i++;
				(arr1[i], arr1[j]) = (arr1[j], arr1[i]);
			}
		}
		(arr1[i + 1], arr1[high]) = (arr1[high], arr1[i + 1]);
		return i + 1;
	}
}