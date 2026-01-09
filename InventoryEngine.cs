using System.Collections.Generic;

interface Product
{
	string Info();
}

class Electronics : Product
{
	public string Info() => "Electronics Product";
}

class Clothing : Product
{
	public string Info() => "Clothing Product";
}

class InventoryManager
{
	Dictionary<int, Product> items = new Dictionary<int, Product>();

	public void Add(int id, Product product) => items[id] = product;

	public Product Get(int id) => items.ContainsKey(id) ? items[id] : null;
}
