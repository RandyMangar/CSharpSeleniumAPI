public class Clear()
{
	private RemoteWebDriver _remoteWebDriver;
	
	//Constructor
	public Clear(RemoteWebDriver remoteWebDriver)
	{
		_remoteWebDriver = remoteWebDriver
	}
	
	//ClearElement
	public void ClearElement(IWebElement webElement)
	{
		try
		{
			webElement.Clear();
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//ClearElements
	public void ClearElements(ReadOnlyCollection<IWebElement> webElements)
	{
		try
		{
			foreach(var webElement in webElements)
			{
				webElements.Clear();
			}
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//ClearElementByClassName
	public void ClearElementByClassName(string className)
	{
		try
		{
			_remoteWebDriver.FindElement(By.ClassName(className)).Clear();
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public void ClearElementByClassName(string className, int timeOutInSeconds)
	{
		try
		{
			var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
            webDriverWait.Until(d => d.FindElement(By.ClassName(className))).Clear();
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//ClearElementsByClassName
	public void ClearElementsByClassName(string className)
	{
		try
		{
			var webElements = _remoteWebDriver.FindElements(By.ClassName(className));
			foreach(var webElement in webElements)
			{
				webElements.Clear();
			}
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public void ClearElementsByClassName(string className, int timeOutInSeconds)
	{
		try
		{
			var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
            var webElements = webDriverWait.Until(d => d.FindElements(By.ClassName(className)));
			foreach(var webElement in webElements)
			{
				webElements.Clear();
			}
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//ClearElementByCssSelector
	public void ClearElementByCssSelector(string cssSelector)
	{
		try
		{
			_remoteWebDriver.FindElement(By.CssSelector(cssSelector)).Clear();
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public void ClearElementByCssSelector(string cssSelector, int timeOutInSeconds)
	{
		try
		{
			var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
            webDriverWait.Until(d => d.FindElement(By.CssSelector(cssSelector))).Clear();
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//ClearElementsByCssSelector
	public void ClearElementsByCssSelector(string cssSelector)
	{
		try
		{
			var webElements = _remoteWebDriver.FindElements(By.CssSelector(cssSelector));
			foreach(var webElement in webElements)
			{
				webElements.Clear();
			}
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public void ClearElementsByCssSelector(string cssSelector, int timeOutInSeconds)
	{
		try
		{
			var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
            var webElements = webDriverWait.Until(d => d.FindElements(By.CssSelector(cssSelector)));
			foreach(var webElement in webElements)
			{
				webElements.Clear();
			}
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//ClearElementById
	public void ClearElementById(string id)
	{
		try
		{
			_remoteWebDriver.FindElement(By.Id(id)).Clear();
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public void ClearElementById(string id, int timeOutInSeconds)
	{
		try
		{
			var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
            webDriverWait.Until(d => d.FindElement(By.Id(id))).Clear();
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//ClearElementsById
	public void ClearElementsById(string id)
	{
		try
		{
			var webElements = _remoteWebDriver.FindElement(By.Id(id));
			foreach(var webElement in webElements)
			{
				webElements.Clear();
			}
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public void ClearElementsById(string id, int timeOutInSeconds)
	{
		try
		{
			var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
            var webElements = webDriverWait.Until(d => d.FindElement(By.Id(id)));
			foreach(var webElement in webElements)
			{
				webElements.Clear();
			}
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//ClearElementByLinkText
	public void ClearElementByLinkText(string linkText)
	{
		try
		{
			_remoteWebDriver.FindElement(By.LinkText(linkText)).Clear();
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public void ClearElementByLinkText(string linkText, int timeOutInSeconds)
	{
		try
		{
			var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
            webDriverWait.Until(d => d.FindElement(By.LinkText(linkText))).Clear();
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//ClearElementsByLinkText
	public void ClearElementsByLinkText(string linkText)
	{
		try
		{
			var webElements = _remoteWebDriver.FindElement(By.LinkText(linkText));
			foreach(var webElement in webElements)
			{
				webElements.Clear();
			}
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public void ClearElementsByLinkText(string linkText, int timeOutInSeconds)
	{
		try
		{
			var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
            var webElements = webDriverWait.Until(d => d.FindElement(By.LinkText(linkText)));
			foreach(var webElement in webElements)
			{
				webElements.Clear();
			}
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//ClearElementByName
	public void ClearElementByName(string name)
	{
		try
		{
			_remoteWebDriver.FindElement(By.Name(name)).Clear();
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public void ClearElementByName(string name, int timeOutInSeconds)
	{
		try
		{
			var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
            webDriverWait.Until(d => d.FindElement(By.Name(name))).Clear();
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//ClearElementsByName
	public void ClearElementsByName(string name)
	{
		try
		{
			var webElements = _remoteWebDriver.FindElement(By.Name(name));
			foreach(var webElement in webElements)
			{
				webElements.Clear();
			}
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public void ClearElementsByName(string name, int timeOutInSeconds)
	{
		try
		{
			var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
            var webElements = webDriverWait.Until(d => d.FindElement(By.Name(name)));
			foreach(var webElement in webElements)
			{
				webElements.Clear();
			}
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//ClearElementByTagName
	public void ClearElementByTagName(string tagName)
	{
		try
		{
			_remoteWebDriver.FindElement(By.TagName(tagName)).Clear();
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public void ClearElementByTagName(string tagName, int timeOutInSeconds)
	{
		try
		{
			var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
            webDriverWait.Until(d => d.FindElement(By.TagName(tagName))).Clear();
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//ClearElementsByTagName
	public void ClearElementsByTagName(string tagName)
	{
		try
		{
			var webElements = _remoteWebDriver.FindElement(By.TagName(tagName));
			foreach(var webElement in webElements)
			{
				webElements.Clear();
			}
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public void ClearElementsByTagName(string tagName, int timeOutInSeconds)
	{
		try
		{
			var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
            var webElements = webDriverWait.Until(d => d.FindElement(By.TagName(tagName)));
			foreach(var webElement in webElements)
			{
				webElements.Clear();
			}
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//ClearElementByXPath
	public void ClearElementByXPath(string xPath)
	{
		try
		{
			_remoteWebDriver.FindElement(By.XPath(xPath)).Clear();
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public void ClearElementByXPath(string xPath, int timeOutInSeconds)
	{
		try
		{
			var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
            webDriverWait.Until(d => d.FindElement(By.XPath(xPath))).Clear();
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//ClearElementsByXPath
	public void ClearElementsByXPath(string xPath)
	{
		try
		{
			var webElements = _remoteWebDriver.FindElements(By.XPath(xPath));
			foreach(var webElement in webElements)
			{
				webElements.Clear();
			}
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public void ClearElementsByXPath(string xPath, int timeOutInSeconds)
	{
		try
		{
			var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
            var webElements = webDriverWait.Until(d => d.FindElements(By.XPath(xPath)));
			foreach(var webElement in webElements)
			{
				webElements.Clear();
			}
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
}