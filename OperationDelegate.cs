/*Delegate as Method Parameter

Write a method PerformOperation(int a, int b, DelegateName op). Pass different operations using delegates.*/


using System;

public class OperationDelegate
{
	// Delegate declaration
	public delegate int Operation(int a, int b);

	// Method that accepts delegate
	public static void PerformOperation(int a, int b, Operation op)
	{
		int result = op(a, b);
		Console.WriteLine("Result: " + result);
	}

	// Methods matching delegate signature
	public static int Add(int a, int b) => a + b;
	public static int Subtract(int a, int b) => a - b;
	public static int Multiply(int a, int b) => a * b;
}
