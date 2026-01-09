using System.Collections.Generic;

interface CallRequest
{
	void Handle();
}

class SupportCall : CallRequest
{
	public void Handle() => System.Console.WriteLine("Support Call Handled");
}

class SalesCall : CallRequest
{
	public void Handle() => System.Console.WriteLine("Sales Call Handled");
}

class CallCenterManager
{
	Queue<CallRequest> queue = new Queue<CallRequest>();

	public void Receive(CallRequest call) => queue.Enqueue(call);

	public void Process()
	{
		while (queue.Count > 0)
			queue.Dequeue().Handle();
	}
}
