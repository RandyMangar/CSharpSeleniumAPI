public class Visibility()
{
	private RemoteWebDriver _remoteWebDriver;
	
	//Constructor
	public Visibility(RemoteWebDriver remoteWebDriver)
	{
		_remoteWebDriver = remoteWebDriver
	}
	
	//GetVisibilityOfElement
	public bool GetVisibilityOfElement(IWebElement webElement)
	{
		try
		{
			return webElement.Displayed;
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//GetVisibilityOfElements
	public void GetVisibilityOfElements(ReadOnlyCollection<IWebElement> webElements)
	{
		try
		{
			var visibilityList = new List<bool>();
			foreach(var webElement in webElements)
			{
				visibilityList.Add(webElement.Displayed);
			}
			return visibilityList;
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//GetVisibilityOfElementByClassName
	public bool GetVisibilityOfElementByClassName(string className)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public bool GetVisibilityOfElementByClassName(string className, int timeOutInSeconds)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//GetVisibilityOfElementsByClassName
	public List<bool> GetVisibilityOfElementsByClassName(string className)
	{
		try
		{
			var visibilityList = new List<bool>();
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public List<bool> GetVisibilityOfElementsByClassName(string className, int timeOutInSeconds)
	{
		try
		{
			var visibilityList = new List<bool>();
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//GetVisibilityOfElementByCssSelector
	public bool GetVisibilityOfElementByCssSelector(string cssSelector)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public bool GetVisibilityOfElementByCssSelector(string cssSelector, int timeOutInSeconds)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//GetVisibilityOfElementsByCssSelector
	public List<bool> GetVisibilityOfElementsByCssSelector(string cssSelector)
	{
		try
		{
			var visibilityList = new List<bool>();
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public List<bool> GetVisibilityOfElementsByCssSelector(string cssSelector, int timeOutInSeconds)
	{
		try
		{
			var visibilityList = new List<bool>();
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//GetVisibilityOfElementById
	public bool GetVisibilityOfElementById(string id)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public bool GetVisibilityOfElementById(string id, int timeOutInSeconds)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//GetVisibilityOfElementsById
	public List<bool> GetVisibilityOfElementsById(string id)
	{
		try
		{
			var visibilityList = new List<bool>();
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public List<bool> GetVisibilityOfElementsById(string id, int timeOutInSeconds)
	{
		try
		{
			var visibilityList = new List<bool>();
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//GetVisibilityOfElementByLinkText
	public bool GetVisibilityOfElementByLinkText(string linkText)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public bool GetVisibilityOfElementByLinkText(string linkText, int timeOutInSeconds)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//GetVisibilityOfElementsByLinkText
	public List<bool> GetVisibilityOfElementsByLinkText(string linkText)
	{
		try
		{
			var visibilityList = new List<bool>();
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public List<bool> GetVisibilityOfElementsByLinkText(string linkText, int timeOutInSeconds)
	{
		try
		{
			var visibilityList = new List<bool>();
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//GetVisibilityOfElementByName
	public bool GetVisibilityOfElementByName(string name)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public bool GetVisibilityOfElementByName(string name, int timeOutInSeconds)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//GetVisibilityOfElementsByName
	public List<bool>GetVisibilityOfElementsByName(string name)
	{
		try
		{
			var visibilityList = new List<bool>();
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public List<bool>GetVisibilityOfElementsByName(string name, int timeOutInSeconds)
	{
		try
		{
			var visibilityList = new List<bool>();
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//GetVisibilityOfElementByTagName
	public bool GetVisibilityOfElementByTagName(string tagName)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public bool GetVisibilityOfElementByTagName(string tagName, int timeOutInSeconds)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//GetVisibilityOfElementsByTagName
	public List<bool> GetVisibilityOfElementsByTagName(string tagName)
	{
		try
		{
			var visibilityList = new List<bool>();
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public List<bool> GetVisibilityOfElementsByTagName(string tagName, int timeOutInSeconds)
	{
		try
		{
			var visibilityList = new List<bool>();
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//GetVisibilityOfElementByXPath
	public bool GetVisibilityOfElementByXPath(string xPath)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public bool GetVisibilityOfElementByXPath(string xPath, int timeOutInSeconds)
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//GetVisibilityOfElementsByXPath
	public List<bool> GetVisibilityOfElementsByXPath(string xPath)
	{
		try
		{
			var visibilityList = new List<bool>();
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public List<bool> GetVisibilityOfElementsByXPath(string xPath, int timeOutInSeconds)
	{
		try
		{
			var visibilityList = new List<bool>();
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
}