/* Challenge Problem(for both Linear and Binary Search)
Problem:
You are given a list of integers. Write a program that uses Linear Search to find the first missing positive integer in the list and Binary 
Search to find the index of a given target number.
Approach:
1.Linear Search for the first missing positive integer:
	o Iterate through the list and mark each number in the list as visited (you can use negative marking or a separate array).
	o Traverse the array again to find the first positive integer that is not marked.
2. Binary Search for the target index:
	o After sorting the array, perform binary search to find the index of the given target number.
	o Return the index if found, otherwise return -1.*/



using System;

class ChallengingProblem
{
	// Linear Search for First Missing Positive
	public static int FirstMissingPositive(int[] arr)
	{
		int n = arr.Length;
		bool[] visited = new bool[n + 1];
		// mark positive numbers
		foreach (int num in arr)
			if (num > 0 && num <= n)
				visited[num] = true;

		// find first missing
		for (int i = 1; i <= n; i++)
			if (!visited[i])
				return i;
		return n + 1;
	}
	// Binary Search for target index
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
