//Temperature Monitoring System - Raise an alert event when temperature exceeds threshold.

using System;

public class TemperatureEventArgs : EventArgs
{
	public double Temperature { get; }
	public TemperatureEventArgs(double temp) => Temperature = temp;
}

public class TemperatureSensor
{
	private double threshold;
	public event EventHandler<TemperatureEventArgs> ThresholdExceeded;

	public TemperatureSensor(double threshold) => this.threshold = threshold;

	public void RecordTemperature(double temp)
	{
		Console.WriteLine("Temperature recorded: " + temp + "°C");
		if (temp > threshold)
			ThresholdExceeded?.Invoke(this, new TemperatureEventArgs(temp));
	}
}

public class AlertSystem
{
	public static void SendAlert(object s, TemperatureEventArgs e)
	{
		Console.WriteLine("ALERT! Temperature exceeded: " + e.Temperature + "°C");
	}
}

public class Logger
{
	public static void Log(object s, TemperatureEventArgs e)
	{
		Console.WriteLine("Logged high temperature: " + e.Temperature + "°C");
	}
}
