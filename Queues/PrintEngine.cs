using System.Collections.Generic;

interface Printable
{
	void Print();
}

class TextDocument : Printable
{
	public void Print() => System.Console.WriteLine("Printing Text Document");
}

class ImageFile : Printable
{
	public void Print() => System.Console.WriteLine("Printing Image File");
}

class PrintQueue
{
	Queue<Printable> queue = new Queue<Printable>();
	public void Add(Printable job) => queue.Enqueue(job);
	public void Process()
	{
		while (queue.Count > 0)
			queue.Dequeue().Print();
	}
}
