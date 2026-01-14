/*Online Shopping Cart
When an item is added:
Update total price
Apply discount
Send notification
(Use events)*/


using System;

public class ItemAddedEventArgs : EventArgs
{
	public double Price { get; }
	public ItemAddedEventArgs(double price)
	{
		Price = price;
	}
}

public class ShoppingCart
{
	public event EventHandler<ItemAddedEventArgs> ItemAdded;

	public void AddItem(double price)
	{
		Console.WriteLine("Item added to cart");
		ItemAdded?.Invoke(this, new ItemAddedEventArgs(price));
	}
}

public class Billing
{
	static double total;

	public static void UpdateTotal(object s, ItemAddedEventArgs e)
	{
		total += e.Price;
		Console.WriteLine("Total Price: " + total);
	}
}

public class Discount
{
	public static void Apply(object s, ItemAddedEventArgs e)
	{
		if (e.Price > 1000)
			Console.WriteLine("Discount Applied: 10%");
	}
}

public class Notification
{
	public static void Send(object s, ItemAddedEventArgs e)
	{
		Console.WriteLine("Notification sent");
	}
}
