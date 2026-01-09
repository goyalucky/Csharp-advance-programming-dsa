using System.Collections.Generic;

interface GradeReport
{
	string GetGrade();
}

class CBSEGrade : GradeReport
{
	int marks;
	public CBSEGrade(int m) { marks = m; }
	public string GetGrade() => marks >= 90 ? "A" : marks >= 75 ? "B" : "C";
}

class GPAGrade : GradeReport
{
	double gpa;
	public GPAGrade(double g) { gpa = g; }
	public string GetGrade() => gpa >= 8.5 ? "Excellent" : gpa >= 6.5 ? "Good" : "Average";
}

class GradeService
{
	Dictionary<int, GradeReport> grades = new Dictionary<int, GradeReport>();

	public void Add(int roll, GradeReport report) => grades[roll] = report;

	public GradeReport Get(int roll) => grades.ContainsKey(roll) ? grades[roll] : null;
}
