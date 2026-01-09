/*2.Sorting Large Data Efficiently
Objective - Compare sorting algorithms Bubble Sort (O(N2)), Merge Sort (O(N log N)), and Quick Sort (O(N log N)).
Approach
● Bubble Sort: Repeated swapping(inefficient for large data).
● Merge Sort: Divide & Conquer approach(stable).
● Quick Sort: Partition - based approach(fast but unstable).
Dataset Size(N) Bubble Sort(O(N2)) Merge Sort(O(N log N)) Quick Sort(O(N log N))
1,000 50ms 5ms 3ms
10,000 5s 50ms 30ms
Dataset Size (N) Bubble Sort (O(N2)) Merge Sort (O(N log N)) Quick Sort (O(N log N)) 1,000,000 Unfeasible (>1hr) 3s 2s
Expected Result - Bubble Sort is impractical for large datasets. Merge Sort & Quick Sort perform well.*/




using System;
using System.Diagnostics;

class SortingComparison
{
	// BUbble Sort
	public void BubbleSort()
	{
		int[] arr = { 92, 76, 89, 54, 71, 97 };
		for (int i = 0; i < arr.Length - 1; i++)
		{
			for (int j = 0; j < arr.Length - i - 1; j++)
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

	//Merge Sort
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

	//Quick Sort
	public static void Sorting(int[] arr1, int low, int high)
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
