/*Delegate for Sorting - Use a delegate to sort a list of students based on:
Name
Marks
Age*/


delegate int SortDelegate(Student s1, Student s2);

class StudentSorter
{
	public static string SortByName(Student s1, Student s2)
	{
		return s1.Name.CompareTo(s2.Name);
	}

	public static int SortByMarks(Student s1, Student s2)
	{
		return s2.Marks.CompareTo(s1.Marks); // Descending
	}

	public static int SortByAge(Student s1, Student s2)
	{
		return s1.Age.CompareTo(s2.Age);
	}
}
