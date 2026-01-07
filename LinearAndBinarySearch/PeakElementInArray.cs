/*Binary Search Problem 2: Find the Peak Element in an Array
Problem: A peak element is an element that is greater than its neighbors. Write a program
that performs Binary Search to find a peak element in an array.*/


using System;

class PeakElementInArray
{
	public static int FindRotationPoint(int[] arr1)
	{
		int left = 0;
		int right = arr1.Length - 1;
		while (left < right)
		{
			int mid = left + (right - left) / 2;
			if (arr1[mid] > arr1[right])
				left = mid + 1;
			else
				right = mid;
		}
		return left;
	}
}