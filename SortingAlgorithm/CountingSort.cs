/*Counting Sort - Sort Student Ages
Problem Statement:
A school collects students’ ages (ranging from 10 to 18) and wants them sorted. Implement Counting Sort in C# for this task.
Hint:
● Create a count array to store the frequency of each age.
● Compute cumulative frequencies to determine positions.
● Place elements in their correct positions in the output array.*/


using System;

class CountingSort
{
	public static void CountSort(int[] arr)
	{
		int max = arr[0];
		foreach (int x in arr)
			if (x > max) max = x;

		int[] count = new int[max + 1];

		foreach (int x in arr)
			count[x]++;

		int k = 0;
		for (int i = 0; i <= max; i++)
			while (count[i]-- > 0)
				arr[k++] = i;
	}
}
