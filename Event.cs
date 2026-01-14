/*Custom EventArgs
Create a Student class that raises an event when marks change.
Pass:
Old Marks
New Marks
Use a custom EventArgs class.

Multiple Subscribers Attach multiple listeners to a single event and show how all are notified.

Event vs Delegate Difference Convert an existing delegate-based implementation into an event-based one.

Event with Validation Raise an event before deleting a record and allow subscribers to cancel deletion.*/


using System;

public class MarksChangedEventArgs : EventArgs
{
	public int OldMarks { get; }
	public int NewMarks { get; }

	public MarksChangedEventArgs(int oldM, int newM)
	{
		OldMarks = oldM;
		NewMarks = newM;
	}
}

public class Student
{
	public event EventHandler<MarksChangedEventArgs> MarksChanged;
	int marks;

	public int Marks
	{
		get => marks;
		set
		{
			MarksChanged?.Invoke(this, new MarksChangedEventArgs(marks, value));
			marks = value;
		}
	}
}

public class Teacher
{
	public static void Notify(object s, MarksChangedEventArgs e)
	{
		Console.WriteLine($"Teacher notified: {e.OldMarks} -> {e.NewMarks}");
	}
}

public class Parent
{
	public static void Notify(object s, MarksChangedEventArgs e)
	{
		Console.WriteLine($"Parent notified: {e.OldMarks} -> {e.NewMarks}");
	}
}

public class DeleteEventArgs : EventArgs
{
	public bool Cancel { get; set; }
}

public class Record
{
	public event EventHandler<DeleteEventArgs> Deleting;

	public void Delete()
	{
		var e = new DeleteEventArgs();
		Deleting?.Invoke(this, e);
		Console.WriteLine(e.Cancel ? "Delete Cancelled" : "Record Deleted");
	}
}

public class Admin
{
	public static void Validate(object s, DeleteEventArgs e)
	{
		e.Cancel = true;
	}
}
