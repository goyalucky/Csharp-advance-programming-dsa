using System;

public class MsgEventArgs : EventArgs
{
	public string Msg { get; }
	public MsgEventArgs(string m) => Msg = m;
}

public class Chat
{
	public event EventHandler<MsgEventArgs> MsgReceived;

	public void RecvMsg(string m) => MsgReceived?.Invoke(this, new MsgEventArgs(m));
}

public class GameUI
{
	public static void Show(object s, MsgEventArgs e) => Console.WriteLine("UI: " + e.Msg);
}

public class DB
{
	public static void Store(object s, MsgEventArgs e) => Console.WriteLine("Stored: " + e.Msg);
}

public class Notify
{
	public static void Send(object s, MsgEventArgs e) => Console.WriteLine("Notification: " + e.Msg);
}
