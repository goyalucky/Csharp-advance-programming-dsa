/*Simple Delegate Invocation

Create a delegate that takes two integers and returns an integer.Implement methods for Add, Subtract, Multiply, and invoke them using the delegate.*/



using System;

class DelegateInvocation
{
	int a = 5;
	int b = 6;
	public void Add()
	{
		Console.WriteLine(a + b);
	}
	public void Multiply()
	{
		Console.WriteLine(a * b);
	}
	public void Subtract()
	{
		Console.WriteLine(a - b);
	}

	public delegate void DelegateInvok();
}