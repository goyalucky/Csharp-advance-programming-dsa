using System;

class Program
{
	static void Main()
	{
		CallCenterManager cc = new CallCenterManager();
		cc.Receive(new SupportCall());
		cc.Receive(new SalesCall());
		cc.Process();

		/*TaskQueue tq = new TaskQueue();
		tq.Add(new UploadTask());
		tq.Add(new ReportTask());
		tq.Process();*/

		/*TicketService ts = new TicketService();
		ts.Add(new BusTicket());
		ts.Add(new TrainTicket());
		ts.Add(new FlightTicket());
		ts.Process();*/

		/* PrintQueue pq = new PrintQueue();
		pq.Add(new TextDocument());
		pq.Add(new ImageFile());
		pq.Process(); */
	}
}

