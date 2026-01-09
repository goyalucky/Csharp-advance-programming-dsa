/*Web Browser Tab Navigation (Back/Forward Tabs)
Use Case: Users can navigate back and forward between opened tabs.
OOP Concepts:
● Interface: NavigationManager
● Encapsulation: Two stacks handle navigation state.
● Polymorphism: Could extend for mobile vs desktop browser.*/


using System.Collections.Generic;

interface NavigationManager
{
	void Visit(string tab);
	string Back();
	string Forward();
}

class BrowserNavigation : NavigationManager
{
	Stack<string> back = new Stack<string>();
	Stack<string> forward = new Stack<string>();
	string current;

	public void Visit(string tab)
	{
		if (current != null) back.Push(current);
		current = tab;
		forward.Clear();
	}
	
	public string Back()
	{
		if (back.Count == 0) return current;
		forward.Push(current);
		current = back.Pop();
		return current;
	}

	public string Forward()
	{
		if (forward.Count == 0) return current;
		back.Push(current);
		current = forward.Pop();
		return current;
	}
}

































































