/*Expression Evaluation Engine (Infix to Postfix + Evaluation)
Use Case: Parse and evaluate mathematical expressions in calculators or compilers.
OOP Concepts:
● Interface: ExpressionEvaluator
● Encapsulation: Stack operations hidden inside evaluator.
● Polymorphism: Different strategies like PostfixEvaluator, PrefixEvaluator.*/



using System.Collections.Generic;

interface IExpressionEvaluator
{
	int Evaluate(string expression);
}

class PostfixEvaluator : IExpressionEvaluator
{
	public int Evaluate(string postfix)
	{
		Stack<int> s = new Stack<int>();

		foreach (char c in postfix)
			if (char.IsDigit(c)) s.Push(c - '0');
			else
			{
				int b = s.Pop();
				int a = s.Pop();
				s.Push(c == '+' ? a + b :
					   c == '-' ? a - b :
					   c == '*' ? a * b :
								  a / b);
			}
		return s.Pop();
	}
}

class InfixToPostfix
{
	static int P(char c) => (c == '+' || c == '-') ? 1 : 2;

	public static string Convert(string infix)
	{
		Stack<char> s = new Stack<char>();
		string post = "";

		foreach (char c in infix)
			if (char.IsDigit(c)) post += c;
			else
			{
				while (s.Count > 0 && P(s.Peek()) >= P(c))
					post += s.Pop();
				s.Push(c);
			}

		while (s.Count > 0) post += s.Pop();
		return post;
	}
}




































































