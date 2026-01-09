/* 1.Search a Target in a Large Dataset
Objective - Compare the performance of Linear Search (O(N)) and Binary Search (O(log N)) on different dataset sizes.
Approach-
● Linear Search: Scan each element until the target is found.
● Binary Search: Sort the data first (O(N log N)), then perform O(log N) search.
Dataset Size (N) Linear Search (O(N)) Binary Search (O(log N))
1,000 1ms 0.01ms
10,000 10ms 0.02ms
1,000,000 1s 0.1ms
Expected Result - Binary Search performs much better for large datasets, provided data is sorted.*/



using System;
using System.Diagnostics;

class SearchComparison
{
	public static int LinearSearch(int[] arr, int target)
	{
		for (int i = 0; i < arr.Length; i++)
		{
			if (arr[i] == target)
				return i;
		}
		return -1;
	}

	public static int BinarySearch(int[] arr, int target)
	{
		int left = 0, right = arr.Length - 1;
		while (left <= right)
		{
			int mid = (left + right) / 2;

			if (arr[mid] == target)
				return mid;
			else if (arr[mid] < target)
				left = mid + 1;
			else
				right = mid - 1;
		}
		return -1;
	}
}
