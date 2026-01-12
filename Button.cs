delegate void MyEventHandler();

class Button
{
	public event MyEventHandler Click;

	public void OnClick()
	{
		if (Click != null)
			Click();
	}
}