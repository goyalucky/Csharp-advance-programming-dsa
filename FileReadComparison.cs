/* Large File Reading Efficiency
Objective - Compare StreamReader and FileStream when reading a large file (500MB).
Approach-
● StreamReader: Reads character by character (slower for binary files).
● FileStream: Reads bytes and converts to characters (more efficient).
File Size StreamReader Time FileStream Time
1MB 50ms 30ms
100MB 3s 1.5s
500MB 10s 5s
Expected Result - FileStream is more efficient for large files. StreamReader is preferable for text-based data.*/


using System;
using System.Diagnostics;
using System.IO;

class FileReadComparison
{
	public static void Compare()
	{
		string filePath = "sample.txt"; 
		Stopwatch sw = new Stopwatch();

		// StreamReader
		sw.Start();
		using (StreamReader sr = new StreamReader(filePath))
		{
			while (sr.Read() != -1) { }
		}
		sw.Stop();
		Console.WriteLine("StreamReader Time: " + sw.ElapsedMilliseconds + " ms");

		// FileStream
		sw.Restart();
		using (FileStream fs = new FileStream(filePath, FileMode.Open))
		{
			byte[] buffer = new byte[4096];
			while (fs.Read(buffer, 0, buffer.Length) > 0) { }
		}
		sw.Stop();
		Console.WriteLine("FileStream Time: " + sw.ElapsedMilliseconds + " ms");
	}
}
