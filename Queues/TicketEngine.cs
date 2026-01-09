using System.Collections.Generic;

interface TicketRequest
{
	void Book();
}

class BusTicket : TicketRequest
{
	public void Book() => System.Console.WriteLine("Bus Ticket Booked");
}

class TrainTicket : TicketRequest
{
	public void Book() => System.Console.WriteLine("Train Ticket Booked");
}

class FlightTicket : TicketRequest
{
	public void Book() => System.Console.WriteLine("Flight Ticket Booked");
}

class TicketService
{
	Queue<TicketRequest> queue = new Queue<TicketRequest>();
	public void Add(TicketRequest ticket) => queue.Enqueue(ticket);
	public void Process()
	{
		while (queue.Count > 0)
			queue.Dequeue().Book();
	}
}
