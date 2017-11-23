public class Read()
{
	private RemoteWebDriver _remoteWebDriver;
	
	public Read(RemoteWebDriver remoteWebDriver)
	{
		_remoteWebDriver = remoteWebDriver
	}
	
	//ClassName
	
	//CssSelector
	public IWebElement FindElementByCssSelector(string cssSelector)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public IWebElement FindElementByCssSelector(string cssSelector, int timeOutInSeconds)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//CssSelectors
	public ReadOnlyCollection<IWebElement> FindElementsByCssSelector(string cssSelector)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public ReadOnlyCollection<IWebElement> FindElementsByCssSelector(string cssSelector, int timeOutInSeconds)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//CssSelector counts
	public int CountElementsById(string cssSelector)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public int CountElementsById(string cssSelector, int timeOutInSeconds)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//Id
	public IWebElement FindElementById(string id)
	{
		try
		{
			return _remoteWebDriver.FindElement(By.Id(id));
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public IWebElement FindElementById(string id, int timeOutInSeconds)
	{
		try
		{
			var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
            return webDriverWait.Until(d => d.FindElement(By.Id(id)));
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//Ids
	public ReadOnlyCollection<IWebElement> FindElementsById(string id)
	{
		try
		{
			return _remoteWebDriver.FindElements(By.Id(id));
		}
		catch(Exception ex)
		{
			Assert.Fail();
		}
	}
	
	public ReadOnlyCollection<IWebElement> FindElementsById(string id, int timeOutInSeconds)
	{
		try
		{
			var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
            return webDriverWait.Until(d => d.FindElements(By.Id(id)));
		}
		catch(Exception ex)
		{
			Assert.Fail();
		}
	}
	
	//Ids count
	public int CountElementsById(string id)
	{
		try
		{
			return _remoteWebDriver.FindElements(By.Id(id)).Count;
		}
		catch(Exception ex)
		{
			Assert.Fail();
		}
	}
	
	public int CountElementsById(string id, int timeOutInSeconds)
	{
		try
		{
			var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
            return webDriverWait.Until(d => d.FindElements(By.Id(id))).Count;
		}
		catch(Exception ex)
		{
			Assert.Fail();
		}
	}
	
	//LinkText
	
	//Name
	
	//TagName
	
	//XPath
	
	
}