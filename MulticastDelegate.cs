/*Multicast Delegate

Create a delegate that returns void. Attach multiple methods and observe the execution order.*/



using System;

public class MulticastDelegate
{
	// Step 1: Delegate returning void
	public delegate void Notify();

	// Step 2: Methods to attach
	public static void MethodA()
	{
		Console.WriteLine("Method A executed");
	}

	public static void MethodB()
	{
		Console.WriteLine("Method B executed");
	}

	public static void MethodC()
	{
		Console.WriteLine("Method C executed");
	}
}
