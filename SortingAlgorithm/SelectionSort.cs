/* Selection Sort - Sort Exam Scores
Problem Statement:
A university needs to sort students’ exam scores in ascending order. Implement Selection Sort in C# to achieve this.
Hint:
● Find the minimum element in the array.
● Swap it with the first unsorted element.
● Repeat the process for the remaining elements.*/


using System; 

class SelectionSort
{
	public void SelectionSorting()
	{
		int []arr = { 92, 76, 83, 87, 81, 98 };
		for(int i=0;i<arr.Length-1; i++)
		{
			int min = i;
			for(int j = i + 1; j < arr.Length; j++)
			{
				if (arr[j] < arr[min])
				{
					min = j;
				}
			}
			int temp = arr[min];
			arr[min] = arr[i];
			arr[i] = temp;
		}
		Console.WriteLine("Selection Sorting array");
		foreach(int x in arr)
			Console.Write(x+" ");
	}
}