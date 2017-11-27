public class Attribute()
{
	private RemoteWebDriver _remoteWebDriver;
	
	//Constructor
	public Attribute(RemoteWebDriver remoteWebDriver)
	{
		_remoteWebDriver = remoteWebDriver
	}
	
	//GetAttributeFromElement
	public string GetAttributeFromElement(IWebElement webElement, string attribute)
	{
		try
		{
			return webElement.GetAttribute(attribute);
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public List<string> GetAttributeFromElement(ReadOnlyCollection<IWebElement> webElements, string attribute)
	{
		try
		{
			var attributeValues = new List<string>();
			foreach(var element in elements)
			{
				attributeValues.Add(element.GetAttribute)
			}
			return attributeValues;
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//GetAttributeFromElements
	public List<string> GetAttributeFromElements()
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public List<string> GetAttributeFromElements()
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//GetAttributeFromElementByClassName
	public string GetAttributeFromElementByClassName()
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public string GetAttributeFromElementByClassName()
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//GetAttributeFromElementsByClassName
	public List<string> GetAttributeFromElementsByClassName()
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public List<string> GetAttributeFromElementsByClassName()
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//GetAttributeFromElementByCssSelector
	public string GetAttributeFromElementByCssSelector()
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public string GetAttributeFromElementByCssSelector()
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//GetAttributeFromElementsByCssSelector
	public List<string> GetAttributeFromElementsByCssSelector()
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public List<string> GetAttributeFromElementsByCssSelector()
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//GetAttributeFromElementById
	public string GetAttributeFromElementById()
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public string GetAttributeFromElementById()
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//GetAttributeFromElementsById
	public List<string> GetAttributeFromElementsById()
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public List<string> GetAttributeFromElementsById()
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//GetAttributeFromElementByLinkText
	public string GetAttributeFromElementByLinkText()
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public string GetAttributeFromElementByLinkText()
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//GetAttributeFromElementsByLinkText
	public List<string> GetAttributeFromElementsByLinkText()
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public List<string> GetAttributeFromElementsByLinkText()
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//GetAttributeFromElementByName
	public string GetAttributeFromElementByName()
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public string GetAttributeFromElementByName()
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//GetAttributeFromElementsByName
	public List<string> GetAttributeFromElementsByName()
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public List<string> GetAttributeFromElementsByName()
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//GetAttributeFromElementByTagName
	public string GetAttributeFromElementByTagName()
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public string GetAttributeFromElementByTagName()
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//GetAttributeFromElementsByTagName
	public List<string> GetAttributeFromElementsByTagName()
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public List<string> GetAttributeFromElementsByTagName()
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//GetAttributeFromElementByXPath
	public string GetAttributeFromElementByXPath()
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public string GetAttributeFromElementByXPath()
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//GetAttributeFromElementsByXPath
	public List<string> GetAttributeFromElementsByXPath()
	{
		try
		{
			
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	public List<string> GetAttributeFromElementsByXPath()
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