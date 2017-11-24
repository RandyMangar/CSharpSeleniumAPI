public class SendKeys()
{
	private RemoteWebDriver _remoteWebDriver;
	
	//Constructor
	public SendKeys(RemoteWebDriver remoteWebDriver)
	{
		_remoteWebDriver = remoteWebDriver
	}
	
	//SendKeysToElement
	public void SendKeysToElement(IWebElement webElement, string keys)
	{
		try
		{
			webElement.SendKeys(keys);
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//SendKeysToElements
	public void SendKeysToElements(ReadOnlyCollection<IWebElement> webElements, string keys)
	{
		try
		{
			foreach(var webElement in webElements)
			{
				webElement.SendKeys(keys);
			}
		}
		catch(Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
	
	//SendKeysToElementByClassName
	
	
	//SendKeysToElementsByClassName
	
	
	//SendKeysToElementByCssSelector
	
	
	//SendKeysToElemenstByCssSelector
	
	
	//SendKeysToElementById
	
	
	//SendKeysToElementsById
	
	
	//SendKeysToElementByLinkText
	
	
	//SendKeysToElementsByLinkText
	
	
	//SendKeysToElementByName
	
	
	//SendKeysToElementsByName
	
	
	//SendKeysToElementByTagName
	
	
	//SendKeysToElementsByTagName
	
	
	//SendKeysToElementByXPath
	
	
	//SendKeysToElementsByXPath
	
	
}