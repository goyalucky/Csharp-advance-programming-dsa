/*Delegate Chaining & Removal

Add multiple methods to a delegate and remove one method at runtime.*/


using System;

// Delegate declaration
delegate void MyDelegate(string message);

// Handler methods (same file)
class Handlers
{
	public static void LogToConsole(string msg)
	{
		Console.WriteLine("Console Log: " + msg);
	}

	public static void LogToFile(string msg)
	{
		Console.WriteLine("File Log: " + msg);
	}

	public static void SendEmail(string msg)
	{
		Console.WriteLine("Email Sent: " + msg);
	}
}
