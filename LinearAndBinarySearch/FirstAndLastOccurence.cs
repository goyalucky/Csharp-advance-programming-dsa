/* Binary Search Problem 4: Find the First and Last Occurrence of an Element in a Sorted Array
Problem: Given a sorted array and a target element, write a program that uses Binary Search to find the first and last occurrence of the 
target element in the array.*/


using System;

class FirstAndLastOccurence
{
	public static int FindFirstAndLast(int[] arr, int target, bool isFirst)
	{
		int left = 0, right = arr.Length - 1, ans = -1;
		while (left <= right)
		{
			int mid = (left + right) / 2;
			if (arr[mid] == target)
			{
				ans = mid;
				if (isFirst)
					right = mid - 1; 
				else
					left = mid + 1; 
			}
			else if (arr[mid] < target)
				left = mid + 1;
			else
				right = mid - 1;
		}
		return ans;
	}
}