# C# Selenium API
A wrapper on top of Selenium in C# to make it easier to use, meant to be used in Unit/Acceptance tests, useful to use along with SpecFlow.

*Currently implemented:*
```
  Attribute.cs - To get attributes from WebElements.
  Clear.cs - To clear WebElements.
  Click.cs - To click WebElements.
  Count.cs - To count WebElements.
  CssValue.cs - To get css values from WebElements.
  Find.cs - To find WebElements.
  Location.cs - To get Location values from WebElements.
  Navigate.cs - To navigate to pages.
  Selected.cs - To get Selected values from WebElements.
  SendKeys.cs - To send keys to WebElements.
  Text.cs - To get the Text of WebElements.
  Visibility.cs - To get the visibility of WebElements.
```
*Currently working on:*
```
  Size.cs - To get Size values from WebElements.
  TagName.cs - To get TagName values from WebElements.
```

*Example of how to use:*

```
[TestClass]
public class ExampleTestClass()
{
  private RemoteWebDriver _remoteWebDriver;
  private Attribute _attribute;
  private Clear _clear;
  private Click _click;
  private Count _count;
  private CssValue _cssValue;
  private Find _find;
  private Navigate _navigate;
  private SendKeys _sendKeys;
  private Text _text;
  private Visibility _visibility;
  
  public ExampleTestClass()
  {
    var chromeOptions = new ChromeOptions();
    _remoteWebDriver = new ChromeDriver(chromeoptions);
    _attribute = new Attribute(_remoteWebDriver);
    _clear = new Clear(_remoteWebDriver);
    _click = new Click(_remoteWebDriver);
    _count = new Count(_remoteWebDriver);
    _cssValue = new CssValue(_remoteWebDriver);
    _find = new Find(_remoteWebDriver);
    _navigate = new Navigate(_remoteWebDriver);
    _sendKeys = new SendKeys(_remoteWebDriver);
    _text = new Text(_remoteWebDriver);
    _visibility = new Visibility(_remoteWebDriver);
  }
  
  [TestMethod]
  public void FirstTest()
  {
    var attribute = _attribute.GetAttributeFromElementByClassName("testClass", "href");
    _clear.ClearElementById("testId");
    _click.ClickElementsByClassName("testClass");
    var elementsCount = _count.CountElementsByLinkText("http://www.github.com/");
    var cssValue = _cssValue = GetCssValueFromElementsByClassName("testClass", "border-color");
    var elements = _find.FindElementsByTagName("input");
    _navigate.GoToUrl("http://www.github.com/");
    _sendKeys.SendKeysToElements(elements, "test");
    var elementText = _text.GetTextFromElementById("textId");
    var visibilities = _visibility.GetVisibilityFromElements(elements);
  }
}
```
