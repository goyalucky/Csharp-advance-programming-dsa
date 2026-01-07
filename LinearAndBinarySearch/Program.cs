using System;

class Program
{
	static void Main(string[] args)
	{
		int[] arr3 = { 3, 4, -1, 1, 5 };
		int tar = 4;
		int missing = ChallengingProblem.FirstMissingPositive(arr3);
		Console.WriteLine("First Missing Positive: " + missing);
		Array.Sort(arr3);
		int idx = ChallengingProblem.BinarySearch(arr3, tar);
		Console.WriteLine("Index of Target (" + tar + "): " + idx);


		int[] arr2 = { 1, 2, 2, 2, 3, 4, 5 };
		int t = 2;
		int first = FirstAndLastOccurence.FindFirstAndLast(arr2, t, true);
		int last = FirstAndLastOccurence.FindFirstAndLast(arr2, t, false);
		Console.WriteLine("First Occurrence Index: " + first);
		Console.WriteLine("Last Occurrence Index: " + last);


		int[][] matrix =
		{
			new int[] { 1, 3, 5, 7 },
			new int[] { 10, 11, 16, 20 },
			new int[] { 23, 30, 34, 60 }
		};
		int target = 16;
		bool r = Search2DMatrix.Search(matrix, target);
		Console.WriteLine(r ? "Target Found" : "Target Not Found");


		int[] arr1 = { 4, 5, 6, 7, 0, 1, 2 };
		int i = RotateSortedArray.FindRotationPoint(arr1);
		Console.WriteLine("Peak element Index: " + i);
		Console.WriteLine("Peak Element: " + arr1[i]);


		int[] arr = { 4, 5, 6, 7, 0, 1, 2 };
		int index = RotateSortedArray.FindRotationPoint(arr);
		Console.WriteLine("Rotation Point Index: " + index);
		Console.WriteLine("Smallest Element: " + arr[index]);


		string[] sentence =
		 {
			"My name is Lucky Goyal",
			"i m a Full Stack Developer",
			"Rishabh is my best friend",
			"i currently working on c# language"
		};
		string w = "Rishabh";
		SpecificWordSentences.FindSpecificWord(sentence, w);


		FirstNegativeNumber fn = new FirstNegativeNumber();
		fn.FirstNegative();

		string pa = "user_input.txt";
		UserInputToFile.WriteToFile(pa);

		string p = "sample1.txt"; 
		FileByteToChar.ConvertAndPrint(p);

		string path = "sample.txt";     
		string word = "C#";              
		int res = FileWordCounter.CountWord(path, word);
		Console.WriteLine($"The word '{word}' appears {res} times in the file.");
		FileReader.ReadFile("sample.txt"); 

		PerformanceTest.Compare();

		string[] words = { "Hello", " ", "World", "!", " Welcome", " to", " C#" };
		string result = StringConcantenate.ConcantenateStrings(words);
		Console.WriteLine("Concatenated String:");
		Console.WriteLine(result);

		RemoveDuplicates rd = new RemoveDuplicates();
		rd.ShowRemoveDuplicate();

		ReverseString rs = new ReverseString();
		rs.StringReverse();
	}
}
