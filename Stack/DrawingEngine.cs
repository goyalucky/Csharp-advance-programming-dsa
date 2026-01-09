/* Undo Functionality in Drawing App
Use Case: Maintain stack of actions (line drawn, shape added) and support undo.
OOP Concepts:
● Interface: DrawingAction
● Polymorphism: Multiple actions(line, circle, erase) handled uniformly.
● Encapsulation: Undo stack wrapped inside the app logic.*/


using System.Collections.Generic;

interface DrawingAction
{
	void Draw();
	void Undo();
}

class Line : DrawingAction
{
	public void Draw() => System.Console.WriteLine("Line Drawn");
	public void Undo() => System.Console.WriteLine("Line Removed");
}

class Circle : DrawingAction
{
	public void Draw() => System.Console.WriteLine("Circle Drawn");
	public void Undo() => System.Console.WriteLine("Circle Removed");
}

class DrawingApp
{
	Stack<DrawingAction> actions = new Stack<DrawingAction>();
	public void Do(DrawingAction action)
	{
		action.Draw();
		actions.Push(action);
	}

	public void Undo()
	{
		if (actions.Count == 0) return;
		actions.Pop().Undo();
	}
}
