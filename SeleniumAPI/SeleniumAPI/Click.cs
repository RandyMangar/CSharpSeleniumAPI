using System;
using System.Collections.ObjectModel;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace SeleniumAPI
{
    public class Click
    {
        private readonly RemoteWebDriver _remoteWebDriver;

        //Constructor
        public Click(RemoteWebDriver remoteWebDriver)
        {
            _remoteWebDriver = remoteWebDriver;
        }

        //ClickElement
        public void ClickElement(IWebElement webElement)
        {
            try
            {
                webElement.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        //ClickElements
        public void ClickElements(ReadOnlyCollection<IWebElement> webElements)
        {
            try
            {
                foreach (var webElement in webElements)
                {
                    webElement.Click();
                }
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        //ClickElementByClassName
        public void ClickElementByClassName(string className)
        {
            try
            {
                _remoteWebDriver.FindElement(By.ClassName(className)).Click();
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        public void ClickElementByClassName(string className, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                webDriverWait.Until(d => d.FindElement(By.ClassName(className))).Click();
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        //ClickElementsByClassName
        public void ClickElementsByClassName(string className)
        {
            try
            {
                var webElements = _remoteWebDriver.FindElements(By.ClassName(className));
                foreach (var webElement in webElements)
                {
                    webElement.Click();
                }
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        public void ClickElementsByClassName(string className, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                var webElements = webDriverWait.Until(d => d.FindElements(By.ClassName(className)));
                foreach (var webElement in webElements)
                {
                    webElement.Click();
                }
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        //ClickElementByCssSelector
        public void ClickElementByCssSelector(string cssSelector)
        {
            try
            {
                _remoteWebDriver.FindElement(By.CssSelector(cssSelector)).Click();
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        public void ClickElementByCssSelector(string cssSelector, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                webDriverWait.Until(d => d.FindElement(By.CssSelector(cssSelector))).Click();
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        //ClickElementsByCssSelector
        public void ClickElementsByCssSelector(string cssSelector)
        {
            try
            {
                var webElements = _remoteWebDriver.FindElements(By.CssSelector(cssSelector));
                foreach (var webElement in webElements)
                {
                    webElement.Click();
                }
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        public void ClickElementsByCssSelector(string cssSelector, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                var webElements = webDriverWait.Until(d => d.FindElements(By.CssSelector(cssSelector)));
                foreach (var webElement in webElements)
                {
                    webElement.Click();
                }
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        //ClickElementById
        public void ClickElementById(string id)
        {
            try
            {
                _remoteWebDriver.FindElement(By.Id(id)).Click();
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        public void ClickElementById(string id, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                webDriverWait.Until(d => d.FindElement(By.Id(id))).Click();
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        //ClickElementsById
        public void ClickElementsById(string id)
        {
            try
            {
                var webElements = _remoteWebDriver.FindElements(By.Id(id));
                foreach (var webElement in webElements)
                {
                    webElement.Click();
                }
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        public void ClickElementsById(string id, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                var webElements = webDriverWait.Until(d => d.FindElements(By.Id(id)));
                foreach (var webElement in webElements)
                {
                    webElement.Click();
                }
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        //ClickElementByLinkText
        public void ClickElementByLinkText(string linkText)
        {
            try
            {
                _remoteWebDriver.FindElement(By.LinkText(linkText)).Click();
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        public void ClickElementByLinkText(string linkText, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                webDriverWait.Until(d => d.FindElement(By.LinkText(linkText))).Click();
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        //ClickElementsByLinkText
        public void ClickElementsByLinkText(string linkText)
        {
            try
            {
                var webElements = _remoteWebDriver.FindElements(By.LinkText(linkText));
                foreach (var webElement in webElements)
                {
                    webElement.Click();
                }
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        public void ClickElementsByLinkText(string linkText, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                var webElements = webDriverWait.Until(d => d.FindElements(By.LinkText(linkText)));
                foreach (var webElement in webElements)
                {
                    webElement.Click();
                }
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        //ClickElementByName
        public void ClickElementByName(string name)
        {
            try
            {
                _remoteWebDriver.FindElement(By.Name(name)).Click();
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        public void ClickElementByName(string name, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                webDriverWait.Until(d => d.FindElement(By.Name(name))).Click();
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        //ClickElementsByName
        public void ClickElementsByName(string name)
        {
            try
            {
                var webElements = _remoteWebDriver.FindElements(By.Name(name));
                foreach (var webElement in webElements)
                {
                    webElement.Click();
                }
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        public void ClickElementsByName(string name, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                var webElements = webDriverWait.Until(d => d.FindElements(By.Name(name)));
                foreach (var webElement in webElements)
                {
                    webElement.Click();
                }
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        //ClickElementByTagName
        public void ClickElementByTagName(string tagName)
        {
            try
            {
                _remoteWebDriver.FindElement(By.TagName(tagName)).Click();
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        public void ClickElementByTagName(string tagName, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                webDriverWait.Until(d => d.FindElement(By.TagName(tagName))).Click();
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        //ClickElementsByTagName
        public void ClickElementsByTagName(string tagName)
        {
            try
            {
                var webElements = _remoteWebDriver.FindElements(By.TagName(tagName));
                foreach (var webElement in webElements)
                {
                    webElement.Click();
                }
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        public void ClickElementsByTagName(string tagName, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                var webElements = webDriverWait.Until(d => d.FindElements(By.TagName(tagName)));
                foreach (var webElement in webElements)
                {
                    webElement.Click();
                }
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        //ClickElementByXPath
        public void ClickElementByXPath(string xPath)
        {
            try
            {
                _remoteWebDriver.FindElement(By.XPath(xPath)).Click();
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        public void ClickElementByXPath(string xPath, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                webDriverWait.Until(d => d.FindElement(By.XPath(xPath))).Click();
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        //ClickElementsByXPath
        public void ClickElementsByXPath(string xPath)
        {
            try
            {
                var webElements = _remoteWebDriver.FindElements(By.XPath(xPath));
                foreach (var webElement in webElements)
                {
                    webElement.Click();
                }
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        public void ClickElementsByXPath(string xPath, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                var webElements = webDriverWait.Until(d => d.FindElements(By.XPath(xPath)));
                foreach (var webElement in webElements)
                {
                    webElement.Click();
                }
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}
