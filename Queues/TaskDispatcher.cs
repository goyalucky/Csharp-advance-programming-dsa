using System.Collections.Generic;

interface BackgroundTask
{
	void Execute();
}

class UploadTask : BackgroundTask
{
	public void Execute() => System.Console.WriteLine("File Uploaded");
}

class ReportTask : BackgroundTask
{
	public void Execute() => System.Console.WriteLine("Report Generated");
}

class TaskQueue
{
	Queue<BackgroundTask> queue = new Queue<BackgroundTask>();

	public void Add(BackgroundTask task) => queue.Enqueue(task);

	public void Process()
	{
		while (queue.Count > 0)
			queue.Dequeue().Execute();
	}
}
