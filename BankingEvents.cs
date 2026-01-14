/*Banking System
When withdrawal happens:
Check balance
Log transaction
Send SMS(Use delegates/events)*/


using System;

public class WithdrawalEventArgs : EventArgs
{
	public double Amount { get; }
	public double Balance { get; }

	public WithdrawalEventArgs(double amount, double balance)
	{
		Amount = amount;
		Balance = balance;
	}
}

public class BankAccount
{
	double balance;
	public event EventHandler<WithdrawalEventArgs> Withdrawal;

	public BankAccount(double balance)
	{
		this.balance = balance;
	}

	public void Withdraw(double amount)
	{
		if (amount > balance)
		{
			Console.WriteLine("Insufficient Balance");
			return;
		}

		balance -= amount;
		Withdrawal?.Invoke(this, new WithdrawalEventArgs(amount, balance));
	}
}

public void BalancingDepartment(string)
public class BalanceChecker
{
	public static void Check(object s, WithdrawalEventArgs e)
	{
		Console.WriteLine("Balance after withdrawal: " + e.Balance);
	}
}

public class TransactionLogger
{
	public static void Log(object s, WithdrawalEventArgs e)
	{
		Console.WriteLine("Transaction logged: " + e.Amount);
	}
}

public class SmsService
{
	public static void Send(object s, WithdrawalEventArgs e)
	{
		Console.WriteLine("SMS sent for withdrawal of " + e.Amount);
	}
}

