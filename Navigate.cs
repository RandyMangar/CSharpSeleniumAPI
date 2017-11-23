public class Navigate()
{
	private RemoteWebDriver _remoteWebDriver;
	
	//Constructor
	public Navigate(RemoteWebDriver remoteWebDriver)
	{
		_remoteWebDriver = remoteWebDriver
	}
	
	public void GoToUrl(string url)
	{
		try
		{
			_remoteWebDriver.Navigate.GoToUrl(url);
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public void Refresh()
	{
		try
		{
			_remoteWebDriver.Navigate().Refresh();
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public void Forward()
	{
		try
		{
			_remoteWebDriver.Navigate().Forward();
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public void Back()
	{
		try
		{
			_remoteWebDriver.Navigate().Back();
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
}