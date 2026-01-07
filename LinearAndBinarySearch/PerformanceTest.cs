/* Problem 2: Compare StringBuilder Performance
Problem: Write a program that compares the performance of StringBuilder for
concatenating strings multiple times.*/


using System;
using System.Diagnostics;
using System.Text;

class PerformanceTest
{
	public static void Compare()
	{
		int n = 100000;
		Stopwatch sw = new Stopwatch();
		// String 
		sw.Start();
		string s = "";
		for (int i = 0; i < n; i++)
			s += "a";
		sw.Stop();
		Console.WriteLine($"String Time: {sw.ElapsedMilliseconds} ms");

		// StringBuilder
		sw.Restart();
		StringBuilder sb = new StringBuilder();
		for (int i = 0; i < n; i++)
			sb.Append("a");
		sw.Stop();
		Console.WriteLine($"StringBuilder Time: {sw.ElapsedMilliseconds} ms");
	}
}
