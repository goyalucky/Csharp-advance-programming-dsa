using System;
using System.Threading;

delegate void Callback(string file);

class Downloader
{
	public static void Download(string file, Callback cb)
	{
		Thread.Sleep(1000);
		cb(file);
	}
}