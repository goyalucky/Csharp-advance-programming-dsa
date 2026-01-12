/*Delegate for Sorting - Use a delegate to sort a list of students based on:
Name
Marks
Age*/


class Student
{
	public string Name { get; set; }
	public int Marks { get; set; }
	public int Age { get; set; }

	public override string ToString()
	{
		return $"{Name} - Marks: {Marks}, Age: {Age}";
	}
}
