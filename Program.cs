using System;

class Program
{
	public static void Main(string[] args)
	{
		Chat c = new Chat();
		c.MsgReceived += GameUI.Show;
		c.MsgReceived += DB.Store;
		c.MsgReceived += Notify.Send;
		c.RecvMsg("Hello!");
		c.RecvMsg("How are you?");

		/*
        TemperatureSensor sensor = new TemperatureSensor(75);
        sensor.ThresholdExceeded += AlertSystem.SendAlert;
        sensor.ThresholdExceeded += Logger.Log;
        sensor.RecordTemperature(70);
        sensor.RecordTemperature(80);
        sensor.RecordTemperature(90);

        AttendanceSystem system = new AttendanceSystem();
        system.LateCheckIn += HR.Notify;
        system.LateCheckIn += Manager.Alert;
        system.CheckIn("luckygoyal", 10);

        Game game = new Game();
        game.ScoreChanged += UI.Update;
        game.ScoreChanged += Bonus.Check;
        game.ScoreChanged += ScoreStorage.Save;
        game.AddScore(120);

        BankAccount account = new BankAccount(5000);
        account.Withdrawal += BalanceChecker.Check;
        account.Withdrawal += TransactionLogger.Log;
        account.Withdrawal += SmsService.Send;
        account.Withdraw(1500);

        ShoppingCart cart = new ShoppingCart();
        cart.ItemAdded += Billing.UpdateTotal;
        cart.ItemAdded += Discount.Apply;
        cart.ItemAdded += Notification.Send;
        cart.AddItem(1500);

        Student s = new Student();
        s.MarksChanged += Teacher.Notify;
        s.MarksChanged += Parent.Notify;
        s.Marks = 70;

        Record r = new Record();
        r.Deleting += Admin.Validate;
        r.Delete();

        Button btn = new Button();
        User user = new User();

        btn.Click += user.HandleClick;
        btn.Press();
        btn.Click -= user.HandleClick;
        btn.Press();

        btn.MessageClick += ShowMessage;
        btn.PressWithMessage();
        */
	}

	static void ShowMessage(string msg)
	{
		Console.WriteLine("Message Received: " + msg);
	}
}
