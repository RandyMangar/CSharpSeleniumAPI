# C# Selenium API
A wrapper on top of Selenium in C# to make it easier to use, meant to be used in Unit/Acceptance tests, useful to use along with SpecFlow.

Currently implemented:

Clear.cs - To clear WebElements.

Click.cs - To click WebElements.

Count.cs - To count WebElements.

Find.cs - To find WebElements.

Navigate.cs - To navigate to pages.

SendKeys.cs - To send keys to WebElements.

*Example of how to use:*

```
public class TestClass()
{
  private RemoteWebDriver _remoteWebDriver;
  private Clear _clear;
  private Click _click;
  private Count _count;
  private Find _find;
  private Navigate _navigate;
  private SendKeys _sendKeys;
  
  public TestClass()
  {
    _remoteWebDriver = new RemoteWebDriver();
    _clear = new Clear(_remoteWebDriver);
    _click = new Click(_remoteWebDriver);
    _count = new Count(_remoteWebDriver);
    _find = new Find(_remoteWebDriver);
    _navigate = new Navigate(_remoteWebDriver);
    _sendKeys = new SendKeys(_remoteWebDriver);
  }
  
  public FirstTest()
  {
    _clear.ClearElementById("testId");
    _click.ClickElementsByClassName("testClass");
    var elementsCount = _count.countElementByLinkText("http://www.github.com/");
    var elements = _find.FindElementsByTagName("a");
    _navigate.GoToUrl("http://www.github.com");
    _sendKeys.SendKeysToElementBy(elements, "test");
  }
}
```

