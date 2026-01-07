/cd*Binary Search Problem 3: Search for a Target Value in a 2D Sorted Matrix
Problem: You are given a 2D matrix where each row is sorted in ascending order. Write a
program that performs Binary Search to find a target value in the matrix.*/


using System;

class Search2DMatrix
{
	public static bool Search(int[][] matrix, int target)
	{
		foreach (int[] row in matrix)
		{
			if (target >= row[0] && target <= row[row.Length - 1])
			{
				return BinarySearch(row, target);
			}
		}
		return false;
	}

	private static bool BinarySearch(int[] arr, int target)
	{
		int left = 0;
		int right = arr.Length - 1;
		while (left <= right)
		{
			int mid = left + (right - left) / 2;
			if (arr[mid] == target)
				return true;
			else if (arr[mid] < target)
				left = mid + 1;
			else
				right = mid - 1;
		}
		return false;
	}
}