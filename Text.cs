public class Text()
{
	private RemoteWebDriver _remoteWebDriver;
	
	//Constructor
	public Text(RemoteWebDriver remoteWebDriver)
	{
		_remoteWebDriver = remoteWebDriver
	}
	
	//GetTextFromElement
	public string GetTextFromElement(IWebElement webElement)
	{
		try
		{
			return webElement.Text;
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//GetTextFromElements
	public List<string> GetTextFromElements(ReadOnlyCollection<IWebElement> webElements)
	{
		try
		{
			var textList = new List<string>();
			foreach(var webElement in webElements)
			{
				textList.Add(webElement.Text);
			}
			return textList;
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//GetTextFromElementByClassName
	public string GetTextFromElementByClassName(string className)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public string GetTextFromElementByClassName(string className, int timeOutInSeconds)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//GetTextFromElementsByClassName
	public List<string> GetTextFromElementsByClassName(string className)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public List<string> GetTextFromElementsByClassName(string className, int timeOutInSeconds)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//GetTextFromElementByCssSelector
	public string GetTextFromElementByCssSelector(string cssSelector)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public string GetTextFromElementByCssSelector(string cssSelector, int timeOutInSeconds)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//GetTextFromElementsByCssSelector
	public List<string> GetTextFromElementsByCssSelector(string cssSelector)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public List<string> GetTextFromElementsByCssSelector(string cssSelector, int timeOutInSeconds)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//GetTextFromElementById
	public string GetTextFromElementById(string id)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public string GetTextFromElementById(string id, int timeOutInSeconds)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//GetTextFromElementsById
	public List<string> GetTextFromElementsById(string id)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public List<string> GetTextFromElementsById(string id, int timeOutInSeconds)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//GetTextFromElementByLinkText
	public string GetTextFromElementByLinkText(string linkText)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public string GetTextFromElementByLinkText(string linkText, int timeOutInSeconds)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//GetTextFromElementsByLinkText
	public List<string> GetTextFromElementsByLinkText(string linkText)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public List<string> GetTextFromElementsByLinkText(string linkText, int timeOutInSeconds)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//GetTextFromElementByName
	public string GetTextFromElementByName(string name)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public string GetTextFromElementByName(string name, int timeOutInSeconds)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//GetTextFromElementsByName
	public List<string> GetTextFromElementsByName(string name)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public List<string> GetTextFromElementsByName(string name, int timeOutInSeconds)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//GetTextFromElementByTagName
	public string GetTextFromElementByTagName(string tagName)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public string GetTextFromElementByTagName(string tagName, int timeOutInSeconds)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//GetTextFromElementsByTagName
	public List<string> GetTextFromElementsByTagName(string tagName)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public List<string> GetTextFromElementsByTagName(string tagName, int timeOutInSeconds)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//GetTextFromElementByXPath
	public string GetTextFromElementByXPath(string xPath)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public string GetTextFromElementByXPath(string xPath, int timeOutInSeconds)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//GetTextFromElementsByXPath
	public List<string> GetTextFromElementsByXPath(string xPath)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public List<string> GetTextFromElementsByXPath(string xPath, int timeOutInSeconds)
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