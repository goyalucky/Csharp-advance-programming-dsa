/* Scenario 1: Browser History Navigation
Use Case: Maintain a user’s browsing history with the ability to move back and forth.
Why LinkedList? Doubly linked list makes it easy to navigate both backward and forward.
OOP Concepts:
● Encapsulation: Browser history data is wrapped inside a class.
● Abstraction: Navigation methods hide internal implementation.
● Inheritance & Polymorphism: Reusable navigation for other apps like music players.*/


using System;
using System.Collections.Generic;

// Abstraction + Polymorphism
abstract class NavigationBase
{
	public abstract void Visit(string item);
	public abstract void Back();
	public abstract void Forward();
}

// Encapsulation + LinkedList Implementation
class BrowserHistory : NavigationBase
{
	private LinkedList<string> history = new LinkedList<string>();
	private LinkedListNode<string> curr;

	public override void Visit(string url)
	{
		if (curr != null)
		{
			while (curr.Next != null)
				history.Remove(curr.Next);
		}

		history.AddLast(url);
		curr = history.Last;

		Console.WriteLine("Visited: " + url);
	}

	public override void Back()
	{
		if (curr != null && curr.Previous != null)
		{
			curr = curr.Previous;
			Console.WriteLine("Back to: " + curr.Value);
		}
		else
		{
			Console.WriteLine("No previous page.");
		}
	}

	public override void Forward()
	{
		if (curr != null && curr.Next != null)
		{
			curr = curr.Next;
			Console.WriteLine("Forward to: " + curr.Value);
		}
		else
		{
			Console.WriteLine("No next page.");
		}
	}
}
