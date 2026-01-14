//Employee Attendance System Raise an event when employee checks in late.


using System;

public class LateCheckInEventArgs : EventArgs
{
	public string EmployeeName { get; }
	public int CheckInTime { get; }

	public LateCheckInEventArgs(string name, int time)
	{
		EmployeeName = name;
		CheckInTime = time;
	}
}

public class AttendanceSystem
{
	public event EventHandler<LateCheckInEventArgs> LateCheckIn;

	public void CheckIn(string name, int hour)
	{
		if (hour > 9)
			LateCheckIn?.Invoke(this, new LateCheckInEventArgs(name, hour));
		else
			Console.WriteLine(name + " checked in on time");
	}
}

public class HR
{
	public static void Notify(object s, LateCheckInEventArgs e)
	{
		Console.WriteLine("HR notified: " + e.EmployeeName);
	}
}

public class Manager
{
	public static void Alert(object s, LateCheckInEventArgs e)
	{
		Console.WriteLine("Manager alerted: " + e.EmployeeName +
						  " checked in at " + e.CheckInTime);
	}
}
