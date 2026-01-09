/*5.Recursive vs Iterative Fibonacci Computation
Objective
Compare Recursive (O(2^N)) vs Iterative (O(N)) Fibonacci solutions.
Fibonacci (N) Recursive (O(2^N)) Iterative (O(N))
10 1ms 0.01ms
30 5s 0.05ms
50 Unfeasible (>1hr) 0.1ms
Expected Result - Recursive approach is infeasible for large values of N due to exponential growth. The iterative approach is significantly 
faster and memory-efficient.*/


using System;
using System.Diagnostics;

class FibonacciComparison
{
	public static int fibonacciRecursive(int n)
	{
		if(n<=1) return n;
		return fibonacciRecursive(n - 1) + fibonacciRecursive(n - 2);
	}

	public static int fibonacciIterative(int n)
	{
		int a = 0, b = 1;
		int sum = 0;
		for(int i = 2; i < n; i++)
		{
			sum = a + b;
			a = b;
			b = sum;
		}
		return b;
	}
}
