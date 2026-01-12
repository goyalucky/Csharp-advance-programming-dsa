/*Anonymous Method with Delegate

Use an anonymous method to calculate the square of a number using a delegate.*/


using System;

public class AnonymousMethodDelegate
{

	public delegate int SquareDelegate(int number);

	public static SquareDelegate GetSquare()
	{
		SquareDelegate square = delegate (int n)
		{
			return n * n;
		};

		return square;
	}
}
