/*Linear Search Problem 2: Search for a Specific Word in a List of Sentences
Problem: You are given an array of sentences. Write a program that performs Linear Search
to find the first sentence containing a specific word.*/


using System; 

class SpecificWordSentences
{
	public static void FindSpecificWord(string[] sentence, string w)
	{
		for(int i = 0; i < sentence.Length; i++)
		{
			if(sentence[i].Contains(w))
			{
				Console.WriteLine("Word found!");
				Console.WriteLine("Index: " + i);
				Console.WriteLine("Sentence: " + sentence[i]);
				return;
			}
		}
	}
}