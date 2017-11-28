public class CssValue()
{
	private RemoteWebDriver _remoteWebDriver;
	
	//Constructor
	public CssValue(RemoteWebDriver remoteWebDriver)
	{
		_remoteWebDriver = remoteWebDriver
	}
	
	//GetCssValueOfElement
	public string GetCssValueOfElement(IWebElement webElement, string cssPropertyName)
	{
		try
		{
			return webElement.GetCssValue(cssPropertyName);
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//GetCssValuesOfElements
	public List<string> GetCssValuesOfElements(ReadOnlyCollection<IWebElement> webElements, string cssPropertyName)
	{
		try
		{
			var cssValueList = new List<string>();
			foreach(var webElement in webElements)
			{
				cssValueList.Add(webElement.GetCssValue(cssPropertyName));
			}
			return cssValueList;
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//GetCssValueOfElementByClassName
	public string GetCssValueOfElementByClassName(string className, string cssPropertyName)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public string GetCssValueOfElementByClassName(string className, string cssPropertyName, int timeOutInSeconds)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//GetCssValueOfElementsByClassName
	public List<string> GetCssValueOfElementsByClassName(string className, string cssPropertyName)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public List<string> GetCssValueOfElementsByClassName(string className, string cssPropertyName, int timeOutInSeconds)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//GetCssValueOfElementByCssSelector
	public string GetCssValueOfElementByCssSelector(string cssSelector, string cssPropertyName)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public string GetCssValueOfElementByCssSelector(string cssSelector, string cssPropertyName, int timeOutInSeconds)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//GetCssValueOfElementsByCssSelector
	public List<string> GetCssValueOfElementsByCssSelector(string cssSelector, string cssPropertyName)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public List<string> GetCssValueOfElementsByCssSelector(string cssSelector, string cssPropertyName, int timeOutInSeconds)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//GetCssValueOfElementById
	public string GetCssValueOfElementById(string id, string cssPropertyName)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public string GetCssValueOfElementById(string id, string cssPropertyName, int timeOutInSeconds)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//GetCssValueOfElementsById
	public List<string> GetCssValueOfElementsById(string id, string cssPropertyName)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public List<string> GetCssValueOfElementsById(string id, string cssPropertyName, int timeOutInSeconds)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//GetCssValueOfElementByLinkText
	public string GetCssValueOfElementByLinkText(string linkText, string cssPropertyName)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public string GetCssValueOfElementByLinkText(string linkText, string cssPropertyName, int timeOutInSeconds)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//GetCssValueOfElementsByLinkText
	public List<string> GetCssValueOfElementsByLinkText(string linkText, string cssPropertyName)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public List<string> GetCssValueOfElementsByLinkText(string linkText, string cssPropertyName, int timeOutInSeconds)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//GetCssValueOfElementByName
	public string GetCssValueOfElementByName(string name, string cssPropertyName)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public string GetCssValueOfElementByName(string name, string cssPropertyName, int timeOutInSeconds)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//GetCssValueOfElementsByName
	public List<string> GetCssValueOfElementsByName(string name, string cssPropertyName)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public List<string> GetCssValueOfElementsByName(string name, string cssPropertyName, int timeOutInSeconds)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//GetCssValueOfElementByTagName
	public string GetCssValueOfElementByTagName(string tagName, string cssPropertyName)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public string GetCssValueOfElementByTagName(string tagName, string cssPropertyName, int timeOutInSeconds)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//GetCssValueOfElementsByTagName
	public List<string> GetCssValueOfElementsByTagName(string tagName, string cssPropertyName)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public List<string> GetCssValueOfElementsByTagName(string tagName, string cssPropertyName, int timeOutInSeconds)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//GetCssValueOfElementByXPath
	public string GetCssValueOfElementByXPath(string xPath, string cssPropertyName)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public string GetCssValueOfElementByXPath(string xPath, string cssPropertyName, int timeOutInSeconds)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//GetCssValueOfElementsByXPath
	public List<string> GetCssValueOfElementsByXPath(string xPath, string cssPropertyName)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public List<string> GetCssValueOfElementsByXPath(string xPath, string cssPropertyName, int timeOutInSeconds)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
}