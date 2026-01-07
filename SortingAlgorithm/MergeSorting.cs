/* Merge Sort(Divide and Conquer)
Merge Sort recursively divides an array into halves, sorts them, and merges them back together.
Performance Analysis:
● Best, Average, and Worst Case: O(n log n)
● Space Complexity: O(n)
● Stability: Stable*/


using System;

class MergeSorting
{
	public static void Sort(int[] arr, int left, int right)
	{
		if (left < right)
		{
			int mid = left + (right - left) / 2;

			Sort(arr, left, mid);
			Sort(arr, mid + 1, right);
			Merge(arr, left, mid, right);
		}
	}
	private static void Merge(int[] arr, int left, int mid, int right)
	{
		int n1 = mid - left + 1;
		int n2 = right - mid;

		int[] leftArr = new int[n1];
		int[] rightArr = new int[n2];

		for (int i = 0; i < n1; i++)
			leftArr[i] = arr[left + i];

		for (int j = 0; j < n2; j++)
			rightArr[j] = arr[mid + 1 + j];

		int iIdx = 0, jIdx = 0, k = left;

		while (iIdx < n1 && jIdx < n2)
		{
			if (leftArr[iIdx] <= rightArr[jIdx])
				arr[k++] = leftArr[iIdx++];
			else
				arr[k++] = rightArr[jIdx++]; 
		}
		while (iIdx < n1)
			arr[k++] = leftArr[iIdx++];

		while (jIdx < n2)
			arr[k++] = rightArr[jIdx++];
	}
}
