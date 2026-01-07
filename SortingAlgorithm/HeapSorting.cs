/* Heap Sort - Sort Job Applicants by Salary
Problem Statement:
A company receives job applications with different expected salary demands. Implement Heap Sort in C# to sort these salary demands in ascending order.
Hint:
● Build a Max Heap from the array.
● Extract the largest element (root) and place it at the end.
● Reheapify the remaining elements and repeat until sorted.*/

using System; 

class HeapSorting
{
	public static void Heapify(int[] a, int n, int i)
	{
		int max = i, l = 2 * i + 1, r = 2 * i + 2;
		if (l < n && a[l] > a[max]) max = l;
		if (r < n && a[r] > a[max]) max = r;
		if (max != i)
		{
			(a[i], a[max]) = (a[max], a[i]);
			Heapify(a, n, max);
		}
	}
}