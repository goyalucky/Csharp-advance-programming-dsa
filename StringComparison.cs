/*3.String Concatenation Performance
Objective - Compare the performance of string (O(N2)), StringBuilder (O(N)), and StringBuffer (O(N)) when concatenating a million strings.
Approach-
● Using string (Immutable, creates a new object each time)
● Using StringBuilder (Fast, mutable, thread-unsafe)
Operations Count(N) string(O(N2)) StringBuilder(O(N))
1,000 10ms 1ms
10,000 1s 10ms
1,000,000 30m (Unusable) 50ms
Expected Result - StringBuilder is much more efficient than string for concatenation.*/


using System;
using System.Diagnostics;
using System.Text;

class StringComparison 
{
	public static void Compare()
	{
		int n = 100000;
		Stopwatch sw = new Stopwatch();
		// StringBuffer
		sw.Start();
		string s = "";
		for (int i = 0; i < n; i++)
			s += "a";
		sw.Stop();
		Console.WriteLine($"StringBuffer Time: {sw.ElapsedMilliseconds} ms");

		// StringBuilder
		sw.Restart();
		StringBuilder sb = new StringBuilder();
		for (int i = 0; i < n; i++)
			sb.Append("a");
		sw.Stop();
		Console.WriteLine($"StringBuilder Time: {sw.ElapsedMilliseconds} ms");
	}
}
