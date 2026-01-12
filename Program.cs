using System;

class Program
{
	public static void Main(string[] args)
	{
		
		Downloader.Download("file.zip", f => Console.WriteLine("Done: " + f));


		MyDelegate del = Handlers.LogToConsole;
		del += Handlers.LogToFile;
		del += Handlers.SendEmail;
		Console.WriteLine("After Chaining:");
		del("System Started");
		del -= Handlers.LogToFile;
		Console.WriteLine("\nAfter Removing LogToFile:");
		del("System Running");



		ValidationDelegate emailCheck = Validators.ValidateEmail;
		ValidationDelegate passwordCheck = Validators.ValidatePassword;
		ValidationDelegate phoneCheck = Validators.ValidatePhone;
		Console.WriteLine("Email Valid: " + emailCheck("test@gmail.com"));
		Console.WriteLine("Password Valid: " + passwordCheck("password123"));
		Console.WriteLine("Phone Valid: " + phoneCheck("9876543210"));



		List<Student> students = new List<Student>()
		{
			new Student { Name = "Rahul", Marks = 85, Age = 21 },
			new Student { Name = "Aman", Marks = 92, Age = 20 },
			new Student { Name = "Neha", Marks = 78, Age = 22 }
		};

		// Sort by Name
		students.Sort(StudentSorter.SortByName);
		Console.WriteLine("Sorted by Name:");
		Print(students);

		// Sort by Marks
		students.Sort(StudentSorter.SortByMarks);
		Console.WriteLine("\nSorted by Marks:");
		Print(students);

		// Sort by Age
		students.Sort(StudentSorter.SortByAge);
		Console.WriteLine("\nSorted by Age:");
		Print(students);

		static void Print(List<Student> students)
		{
			foreach (var s in students)
				Console.WriteLine(s);
		}


		AnonymousMethodDelegate.SquareDelegate square =
		AnonymousMethodDelegate.GetSquare();
		int result = square(5);
		Console.WriteLine("Square: " + result);


		MulticastDelegate.Notify notify;
		notify = MulticastDelegate.MethodA;
		notify += MulticastDelegate.MethodB;
		notify += MulticastDelegate.MethodC;
		notify();


		OperationDelegate.PerformOperation(10, 5, OperationDelegate.Add);
		OperationDelegate.PerformOperation(10, 5, OperationDelegate.Subtract);
		OperationDelegate.PerformOperation(10, 5, OperationDelegate.Multiply);


		DelegateMessage dm = new DelegateMessage();
		DelegateMessage.DelgateMess dgm = dm.Welcome;
		dgm += dm.Error;
		dgm += dm.Success;
		dgm();


		DelegateInvocation di = new DelegateInvocation();
		DelegateInvocation.DelegateInvok dgi = di.Add;
		dgi += di.Multiply;
		dgi += di.Subtract;
		dgi();


		Button b = new Button();
		b.Click += () => Console.WriteLine("Button Clicked");
		b.OnClick();

		/*
				//Multi cast Delegate used in event handling

				DelegateExample obj = new DelegateExample();
				DelegateExample.mydelegate md = obj.fun;
				md += obj.fun1; (if we want to also use fun1)
				md -= obj.fun1; (if we dont want to use fun1)
				md();
		*/

		/*
				//Delegate Example (Single cast Delegate)

				DelegateExample obj = new DelegateExample();
				DelegateExample.mydelegate md = obj.fun;
				md();
		*/

	}
}