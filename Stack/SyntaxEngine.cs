/*Syntax Checker for Code Editors
Use Case: Validate matched parentheses, brackets, or braces ({}, [], ()).
OOP Concepts:
● Interface: SyntaxChecker
● Encapsulation: Stack logic is hidden inside the implementation.
● Polymorphism: Can create multiple syntax checkers for different file types.*/



using System.Collections.Generic;

interface SyntaxChecker
{
	bool IsValid(string code);
}

class BracketSyntaxChecker : SyntaxChecker
{
	public bool IsValid(string code)
	{
		Stack<char> s = new Stack<char>();

		foreach (char c in code)
		{
			if (c == '(' || c == '[' || c == '{')
				s.Push(c);
			else if (c == ')' || c == ']' || c == '}')
			{
				if (s.Count == 0) return false;
				char o = s.Pop();
				if ((o == '(' && c != ')') ||
					(o == '[' && c != ']') ||
					(o == '{' && c != '}'))
					return false;
			}
		}
		return s.Count == 0;
	}
}
