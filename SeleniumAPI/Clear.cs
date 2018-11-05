using System;
using System.Collections.ObjectModel;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace SeleniumAPI
{
    //Version 1.0
    public class Clear
    {
        private readonly RemoteWebDriver _remoteWebDriver;
	
        public Clear(RemoteWebDriver remoteWebDriver)
        {
            _remoteWebDriver = remoteWebDriver;
        }
	
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
	
        public void ClearElements(ReadOnlyCollection<IWebElement> webElements)
        {
            try
            {
                foreach(var webElement in webElements)
                {
                    webElement.Clear();
                }
            }
            catch(Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
	
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
	
        public void ClearElementsByClassName(string className)
        {
            try
            {
                var webElements = _remoteWebDriver.FindElements(By.ClassName(className));
                foreach(var webElement in webElements)
                {
                    webElement.Clear();
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
                    webElement.Clear();
                }
            }
            catch(Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
	
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
	
        public void ClearElementsByCssSelector(string cssSelector)
        {
            try
            {
                var webElements = _remoteWebDriver.FindElements(By.CssSelector(cssSelector));
                foreach(var webElement in webElements)
                {
                    webElement.Clear();
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
                    webElement.Clear();
                }
            }
            catch(Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
	
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
	
        public void ClearElementsById(string id)
        {
            try
            {
                var webElements = _remoteWebDriver.FindElements(By.Id(id));
                foreach(var webElement in webElements)
                {
                    webElement.Clear();
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
                var webElements = webDriverWait.Until(d => d.FindElements(By.Id(id)));
                foreach(var webElement in webElements)
                {
                    webElement.Clear();
                }
            }
            catch(Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
	
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
	
        public void ClearElementsByLinkText(string linkText)
        {
            try
            {
                var webElements = _remoteWebDriver.FindElements(By.LinkText(linkText));
                foreach(var webElement in webElements)
                {
                    webElement.Clear();
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
                var webElements = webDriverWait.Until(d => d.FindElements(By.LinkText(linkText)));
                foreach(var webElement in webElements)
                {
                    webElement.Clear();
                }
            }
            catch(Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
	
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
	
        public void ClearElementsByName(string name)
        {
            try
            {
                var webElements = _remoteWebDriver.FindElements(By.Name(name));
                foreach(var webElement in webElements)
                {
                    webElement.Clear();
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
                var webElements = webDriverWait.Until(d => d.FindElements(By.Name(name)));
                foreach(var webElement in webElements)
                {
                    webElement.Clear();
                }
            }
            catch(Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
	
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
	
        public void ClearElementsByTagName(string tagName)
        {
            try
            {
                var webElements = _remoteWebDriver.FindElements(By.TagName(tagName));
                foreach(var webElement in webElements)
                {
                    webElement.Clear();
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
                var webElements = webDriverWait.Until(d => d.FindElements(By.TagName(tagName)));
                foreach(var webElement in webElements)
                {
                    webElement.Clear();
                }
            }
            catch(Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
	
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
	
        public void ClearElementsByXPath(string xPath)
        {
            try
            {
                var webElements = _remoteWebDriver.FindElements(By.XPath(xPath));
                foreach(var webElement in webElements)
                {
                    webElement.Clear();
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
                    webElement.Clear();
                }
            }
            catch(Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}