using System;

class Program
{
	static void Main()
	{
		URLStorage store = new MemoryURLStorage();
		store.Put("portfolio", "https://fullstackbyluckygoyal.netlify.app/");
		store.Put("Github", "https://github.com/goyalucky");
		Console.WriteLine(store.Get("portfolio"));
		Console.WriteLine(store.Get("Github"));


		/*GradeService service = new GradeService();
		service.Add(1, new CBSEGrade(88));
		service.Add(2, new GPAGrade(9.1));
		Console.WriteLine(service.Get(1).GetGrade());
		Console.WriteLine(service.Get(2).GetGrade());*/


		/*AuthSystem auth = new AuthSystem();
		auth.Assign("Rishabh", new AdminRole());
		auth.Assign("lucky", new UserRole());
		Console.WriteLine(auth.CheckAccess("Rishabh", "Dashboard"));
		Console.WriteLine(auth.CheckAccess("lucky", "Dashboard"));
		Console.WriteLine(auth.CheckAccess("lucky", "Profile"));*/


		/*InventoryManager inventory = new InventoryManager();
		inventory.Add(101, new Electronics());
		inventory.Add(102, new Clothing());
		Console.WriteLine(inventory.Get(101).Info());
		Console.WriteLine(inventory.Get(102).Info());*/
	}
}