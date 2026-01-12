/*Delegate with void Return Type
Define a delegate that prints a message.Pass different methods to display-
Welcome message
Error message
Success message*/


using System;

class DelegateMessage {

	public void Welcome() {
		Console.WriteLine("Welcome message");
	}
	public void Error(){
		Console.WriteLine("Error message");
	}
	public void Success()
	{
		Console.WriteLine("Success message");
	}
	public delegate void DelgateMess();
	
}