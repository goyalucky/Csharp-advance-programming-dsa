/*Simple Event Example

Create a Button class that raises a Click event. Handle the event in another class.
Event with Custom Message Create an event that passes a message string to the subscriber.
Event Subscription & Unsubscription Demonstrate subscribing and unsubscribing to an event at runtime.*/


using System;

class Button
{
	public event Action Click;

	public event Action<string> MessageClick;
	
	public void Press()
	{
		Console.WriteLine("button pressed");
		Click?.Invoke();
	}
	public void PressWithMessage()
	{
		MessageClick?.Invoke("Hello!, Button clicked");
	}
}

class User
{
	public void HandleClick()
	{
		Console.WriteLine("Button clicked event handled");
	}
}