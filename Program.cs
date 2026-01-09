using System;
using System.Diagnostics;

class Program
{
	static void Main()
	{
		Stopwatch stp = new Stopwatch();
		stp.Start();
		FibonacciComparison.fibonacciRecursive(40);
		stp.Stop();
		Console.WriteLine("Time for Fibonacci using Recursive: " + stp.ElapsedMilliseconds + " ms");
		stp.Restart();
		FibonacciComparison.fibonacciIterative(40);
		Console.WriteLine("Time for Fibonacci using Iterative: " + stp.ElapsedMilliseconds + " ms");
		stp.Stop();

		
/*		
		//Large File Reading Efficiency
		FileReadComparison.Compare();
*/


/*
		//String Concatenation Performance
		StringComparison.Compare();
*/


/*

		//Sorting Large Data Efficiently
		SortingComparison sc = new SortingComparison();
		Stopwatch sp = new Stopwatch();
		// Bubble Sort
		Console.WriteLine("Bubble Sort:");
		sp.Start();
		sc.BubbleSort();
		sp.Stop();
		Console.WriteLine("Time: " + sp.ElapsedMilliseconds + " ms\n");

		// Merge Sort
		int[] arr1 = { 92, 76, 89, 54, 71, 97 };
		Console.WriteLine("Merge Sort:");
		sp.Restart();
		SortingComparison.Sort(arr1, 0, arr1.Length - 1);
		sp.Stop();
		Console.WriteLine(string.Join(",", arr1));
		Console.WriteLine("Time: " + sp.ElapsedMilliseconds + " ms\n");
		
		// Quick Sort
		int[] arr2 = { 92, 76, 89, 54, 71, 97 };
		Console.WriteLine("Quick Sort:");
		sp.Restart();
		SortingComparison.Sorting(arr2, 0, arr2.Length - 1);
		sp.Stop();
		Console.WriteLine(string.Join(",", arr2));
		Console.WriteLine("Time: " + sp.ElapsedMilliseconds + " ms");
*/

/*

		// Search a Target in a Large Dataset
		int n = 1000000;
		int[] data = new int[n];
		for(int i = 0; i < n; i++)
		data[i] = i;
		int target = n - 1;
		Stopwatch sw = new Stopwatch();
		// Linear Search
		sw.Start();
		SearchComparison.LinearSearch(data, target);
		sw.Stop();
		Console.WriteLine("Linear Search Time: " + sw.ElapsedMilliseconds + " ms");
		// Binary Search
		sw.Restart();
		SearchComparison.BinarySearch(data, target);
		sw.Stop();
		Console.WriteLine("Binary Search Time: " + sw.ElapsedMilliseconds + " ms");
*/

	}
}