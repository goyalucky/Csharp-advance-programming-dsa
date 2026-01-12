/*Delegate for Validation

Create a delegate that validates:
Email
Password
Phone number*/

using System;
using System.Text.RegularExpressions;

delegate bool ValidationDelegate(string input);
class Validators
{
	public static bool ValidateEmail(string email)
	{
		return Regex.IsMatch(
			email,
			@"^[^@\s]+@[^@\s]+\.[^@\s]+$"
		);
	}

	public static bool ValidatePassword(string password)
	{
		// At least 8 characters
		return password.Length >= 8;
	}

	public static bool ValidatePhone(string phone)
	{
		// 10-digit phone number
		return Regex.IsMatch(phone, @"^\d{10}$");
	}
}
