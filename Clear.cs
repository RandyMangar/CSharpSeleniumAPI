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
	
	
	//ClearElementsByClassName
	
	
	//ClearElementByCssSelector
	
	
	//ClearElementsByCssSelector
	
	
	//ClearElementById
	
	
	//ClearElementsById
	
	
	//ClearElementByLinkText
	
	
	//ClearElementsByLinkText
	
	
	//ClearElementByName
	
	
	//ClearElementsByName
	
	
	//ClearElementByTagName
	
	
	//ClearElementsByTagName
	
	
	//ClearElementByXPath
	
	
	//ClearElementsByXPath
}