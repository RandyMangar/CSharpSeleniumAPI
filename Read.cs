public class Read()
{
	private RemoteWebDriver _remoteWebDriver;
	
	//Constructor
	public Read(RemoteWebDriver remoteWebDriver)
	{
		_remoteWebDriver = remoteWebDriver
	}
	
	//FindElementByClassName
	public IWebElement FindElementByClassName(string className)
	{
		try
		{
			return _remoteWebDriver.FindElement(By.ClassName(className));
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public IWebElement FindElementByclassName(string className, int timeOutInSeconds)
	{
		try
		{
			var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
            return webDriverWait.Until(d => d.FindElement(By.ClassName(className)));
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//FindElementsByClassName
	public IWebElement FindElementsByClassName(string className)
	{
		try
		{
			return _remoteWebDriver.FindElements(By.ClassName(className));
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public IWebElement FindElementsByclassName(string className, int timeOutInSeconds)
	{
		try
		{
			var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
            return webDriverWait.Until(d => d.FindElements(By.ClassName(className)));
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//CountElementsByClassName
	public IWebElement CountElementsByClassName(string className)
	{
		try
		{
			return _remoteWebDriver.FindElements(By.ClassName(className)).Count;
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public IWebElement CountElementsByclassName(string className, int timeOutInSeconds)
	{
		try
		{
			var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
            return webDriverWait.Until(d => d.FindElements(By.ClassName(className))).Count;
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//FindElementByCssSelector
	public IWebElement FindElementByCssSelector(string cssSelector)
	{
		try
		{
			return _remoteWebDriver.FindElement(By.CssSelector(cssSelector));
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
			var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
            return webDriverWait.Until(d => d.FindElement(By.CssSelector(cssSelector)));
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//FindElementsByCssSelector
	public ReadOnlyCollection<IWebElement> FindElementsByCssSelector(string cssSelector)
	{
		try
		{
			return _remoteWebDriver.FindElements(By.CssSelector(cssSelector));
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
			var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
            return webDriverWait.Until(d => d.FindElements(By.CssSelector(cssSelector)));
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//CountElementsByCssSelector
	public int CountElementsByCssSelector(string cssSelector)
	{
		try
		{
			return _remoteWebDriver.FindElements(By.CssSelector(cssSelector)).Count;
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public int CountElementsByCssSelector(string cssSelector, int timeOutInSeconds)
	{
		try
		{
			var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
            return webDriverWait.Until(d => d.FindElements(By.CssSelector(cssSelector))).Count;
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//FindElementById
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
	
	//FindElementsById
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
	
	//CountElementsById
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
	
	//FindElementByLinkText
	public IWebElement FindElementByLinkText(string linkText)
	{
		try
		{
			return _remoteWebDriver.FindElement(By.LinkText(linkText));
		}
		catch(Exception ex)
		{
			Assert.Fail();
		}
	}
	
	public IWebElement FindElementByLinkText(string linkText, int timeOutInSeconds)
	{
		try
		{
			var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
            return webDriverWait.Until(d => d.FindElement(By.LinkText(linkText)));
		}
		catch(Exception ex)
		{
			Assert.Fail();
		}
	}
	
	//FindElementsByLinkText
	public ReadOnlyCollection<IWebElement> FindElementsByLinkText(string linkText)
	{
		try
		{
			return _remoteWebDriver.FindElements(By.LinkText(linkText));
		}
		catch(Exception ex)
		{
			Assert.Fail();
		}
	}
	
	public ReadOnlyCollection<IWebElement> FindElementsByLinkText(string linkText, int timeOutInSeconds)
	{
		try
		{
			var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
            return webDriverWait.Until(d => d.FindElements(By.LinkText(linkText)));
		}
		catch(Exception ex)
		{
			Assert.Fail();
		}
	}
	
	//CountElementsByLinkText
	public int CountElementsByLinkText(string linkText)
	{
		try
		{
			return _remoteWebDriver.FindElements(By.LinkText(linkText)).Count;
		}
		catch(Exception ex)
		{
			Assert.Fail();
		}
	}
	
	public int CountElementsByLinkText(string linkText, int timeOutInSeconds)
	{
		try
		{
			var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
            return webDriverWait.Until(d => d.FindElements(By.LinkText(linkText))).Count;
		}
		catch(Exception ex)
		{
			Assert.Fail();
		}
	}
	
	//FindElementByName
	public IWebElement FindElementByName(string name)
	{
		try
		{
			return _remoteWebDriver.FindElement(By.Name(name));
		}
		catch(Exception ex)
		{
			Assert.Fail();
		}
	}
	
	public IWebElement FindElementByName(string name, int timeOutInSeconds)
	{
		try
		{
			var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
            return webDriverWait.Until(d => d.FindElement(By.Name(name)));
		}
		catch(Exception ex)
		{
			Assert.Fail();
		}
	}
	
	//FindElementsByName
	public ReadOnlyCollection<IWebElement> FindElementsByName(string name)
	{
		try
		{
			return _remoteWebDriver.FindElements(By.Name(name));
		}
		catch(Exception ex)
		{
			Assert.Fail();
		}
	}
	
	public ReadOnlyCollection<IWebElement> FindElementsByName(string name, int timeOutInSeconds)
	{
		try
		{
			var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
            return webDriverWait.Until(d => d.FindElements(By.Name(name)));
		}
		catch(Exception ex)
		{
			Assert.Fail();
		}
	}
	
	//CountElementsByName
	public int CountElementsByName(string name)
	{
		try
		{
			return _remoteWebDriver.FindElements(By.Name(name)).Count;
		}
		catch(Exception ex)
		{
			Assert.Fail();
		}
	}
	
	public int CountElementsByName(string name, int timeOutInSeconds)
	{
		try
		{
			var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
            return webDriverWait.Until(d => d.FindElements(By.Name(name))).Count;
		}
		catch(Exception ex)
		{
			Assert.Fail();
		}
	}
	
	//FindElementByTagName
	public IWebElement FindElementByTagName(string tagName)
	{
		try
		{
			return _remoteWebDriver.FindElement(By.TagName(tagName));
		}
		catch(Exception ex)
		{
			Assert.Fail();
		}
	}
	
	public IWebElement FindElementByTagName(string tagName, int timeOutInSeconds)
	{
		try
		{
			var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
            return webDriverWait.Until(d => d.FindElement(By.TagName(tagName)));
		}
		catch(Exception ex)
		{
			Assert.Fail();
		}
	}
	
	//FindElementsByTagName
	public ReadOnlyCollection<IWebElement> FindElementsByTagName(string tagName)
	{
		try
		{
			return _remoteWebDriver.FindElements(By.TagName(tagName));
		}
		catch(Exception ex)
		{
			Assert.Fail();
		}
	}
	
	public ReadOnlyCollection<IWebElement> FindElementsByTagName(string tagName, int timeOutInSeconds)
	{
		try
		{
			var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
            return webDriverWait.Until(d => d.FindElements(By.TagName(tagName)));
		}
		catch(Exception ex)
		{
			Assert.Fail();
		}
	}
	
	//CountElementsByTagName
	public IWebElement CountElementsByTagName(string tagName)
	{
		try
		{
			return _remoteWebDriver.FindElements(By.TagName(tagName)).Count;
		}
		catch(Exception ex)
		{
			Assert.Fail();
		}
	}
	
	public IWebElement CountElementsByTagName(string tagName, int timeOutInSeconds)
	{
		try
		{
			var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
            return webDriverWait.Until(d => d.FindElements(By.TagName(tagName))).Count;
		}
		catch(Exception ex)
		{
			Assert.Fail();
		}
	}
	
	//FindElementXPath
	public IWebElement FindElementByXPath(string xPath)
	{
		try
		{
			return _remoteWebDriver.FindElement(By.XPath(xPath));
		}
		catch(Exception ex)
		{
			Assert.Fail();
		}
	}
	
	public IWebElement FindElementByXPath(string xPath, int timeOutInSeconds)
	{
		try
		{
			var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
            return webDriverWait.Until(d => d.FindElement(By.XPath(xPath)));
		}
		catch(Exception ex)
		{
			Assert.Fail();
		}
	}
	
	//FindElementsByXPath
	public ReadOnlyCollection<IWebElement> FindElementsByXPath(string xPath)
	{
		try
		{
			return _remoteWebDriver.FindElements(By.XPath(xPath));
		}
		catch(Exception ex)
		{
			Assert.Fail();
		}
	}
	
	public ReadOnlyCollection<IWebElement> FindElementsByXPath(string xPath, int timeOutInSeconds)
	{
		try
		{
			var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
            return webDriverWait.Until(d => d.FindElements(By.XPath(xPath)));
		}
		catch(Exception ex)
		{
			Assert.Fail();
		}
	}
	
	//CountElementsByXPath
	public int CountElementsByXPath(string xPath)
	{
		try
		{
			return _remoteWebDriver.FindElements(By.XPath(xPath)).Count;
		}
		catch(Exception ex)
		{
			Assert.Fail();
		}
	}
	
	public int CountElementsByXPath(string xPath, int timeOutInSeconds)
	{
		try
		{
			var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
            return webDriverWait.Until(d => d.FindElements(By.XPath(xPath))).Count;
		}
		catch(Exception ex)
		{
			Assert.Fail();
		}
	}
}