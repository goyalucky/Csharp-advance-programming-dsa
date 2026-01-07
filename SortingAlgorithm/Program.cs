using System;

class Program
{
	static void Main(string[] args)
	{
		int[] arr2 = { 4, 2, 2, 8, 3, 3, 1 };
		CountingSort.CountSort(arr2);
		Console.WriteLine("Counting Sorted Array");
		foreach (int x in arr2)
			Console.Write(x + " ");
		Console.WriteLine();


		int[] a = { 12, 11, 13, 5, 6, 7 };
		int n = a.Length;
		for (int i = n / 2 - 1; i >= 0; i--)
			HeapSorting.Heapify(a, n, i);
		for (int i = n - 1; i > 0; i--)
		{
			(a[0], a[i]) = (a[i], a[0]);
			HeapSorting.Heapify(a, i, 0);
		}
		Console.WriteLine("Heap Sorted Array");
		foreach (int x in a)
			Console.Write(x + " ");
		Console.WriteLine();


		SelectionSort ss = new SelectionSort();
		ss.SelectionSorting();
		Console.WriteLine();

		int[] arr1 = { 5, 3, 8, 4, 2 };
		QuickSorting.Sort(arr1, 0, arr1.Length - 1);
		Console.WriteLine("Quick Sorted Array");
		Console.WriteLine(string.Join(", ", arr1));

		int[] arr = { 450, 320, 250, 375, 410, 200, 636 };
		MergeSorting.Sort(arr, 0, arr.Length - 1); 
		Console.WriteLine("Merge Sorted array:");
		foreach (int x in arr)
		Console.Write(x + " "); 
		Console.WriteLine();

		Console.WriteLine("Insertion Sorted array");
		InsertionSorting ins = new InsertionSorting();
		ins.InsertionSort();

		Console.WriteLine("Bubble Sorted array");
		BubbleSorting bs = new BubbleSorting();
		bs.BubbleSort();
	}
}
