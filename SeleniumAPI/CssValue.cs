using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace SeleniumAPI
{
    //Version 1.0
    public class CssValue
    {
        private readonly RemoteWebDriver _remoteWebDriver;

        //Constructor
        public CssValue(RemoteWebDriver remoteWebDriver)
        {
            _remoteWebDriver = remoteWebDriver;
        }

        public string GetCssValueFromElement(IWebElement webElement, string cssPropertyName)
        {
            try
            {
                return webElement.GetCssValue(cssPropertyName);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<string> GetCssValuesFromElements(ReadOnlyCollection<IWebElement> webElements, string cssPropertyName)
        {
            try
            {
                var cssValueList = new List<string>();
                foreach (var webElement in webElements)
                {
                    cssValueList.Add(webElement.GetCssValue(cssPropertyName));
                }
                return cssValueList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public string GetCssValueFromElementByClassName(string className, string cssPropertyName)
        {
            try
            {
                return _remoteWebDriver.FindElement(By.ClassName(className)).GetCssValue(cssPropertyName);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public string GetCssValueFromElementByClassName(string className, string cssPropertyName, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElement(By.ClassName(className))).GetCssValue(cssPropertyName);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<string> GetCssValueFromElementsByClassName(string className, string cssPropertyName)
        {
            try
            {
                var cssValueList = new List<string>();
                var webElements = _remoteWebDriver.FindElements(By.ClassName(className));
				foreach (var webElement in webElements)
                {
                    cssValueList.Add(webElement.GetCssValue(cssPropertyName));
                }
                return cssValueList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<string> GetCssValueFromElementsByClassName(string className, string cssPropertyName, int timeOutInSeconds)
        {
            try
            {
                var cssValueList = new List<string>();
				var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                var webElements = webDriverWait.Until(d => d.FindElements(By.ClassName(className)));
				foreach (var webElement in webElements)
                {
                    cssValueList.Add(webElement.GetCssValue(cssPropertyName));
                }
                return cssValueList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public string GetCssValueFromElementByCssSelector(string cssSelector, string cssPropertyName)
        {
            try
            {
                return _remoteWebDriver.FindElement(By.CssSelector(cssSelector)).GetCssValue(cssPropertyName);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public string GetCssValueFromElementByCssSelector(string cssSelector, string cssPropertyName, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElement(By.CssSelector(cssSelector))).GetCssValue(cssPropertyName);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<string> GetCssValueFromElementsByCssSelector(string cssSelector, string cssPropertyName)
        {
            try
            {
                var cssValueList = new List<string>();
                var webElements = _remoteWebDriver.FindElements(By.CssSelector(cssSelector));
				foreach (var webElement in webElements)
                {
                    cssValueList.Add(webElement.GetCssValue(cssPropertyName));
                }
                return cssValueList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<string> GetCssValueFromElementsByCssSelector(string cssSelector, string cssPropertyName, int timeOutInSeconds)
        {
            try
            {
                var cssValueList = new List<string>();
				var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                var webElements = webDriverWait.Until(d => d.FindElements(By.CssSelector(cssSelector)));
				foreach (var webElement in webElements)
                {
                    cssValueList.Add(webElement.GetCssValue(cssPropertyName));
                }
                return cssValueList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public string GetCssValueFromElementById(string id, string cssPropertyName)
        {
            try
            {
                return _remoteWebDriver.FindElement(By.Id(id)).GetCssValue(cssPropertyName);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public string GetCssValueFromElementById(string id, string cssPropertyName, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElement(By.Id(id))).GetCssValue(cssPropertyName);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<string> GetCssValueFromElementsById(string id, string cssPropertyName)
        {
            try
            {
                var cssValueList = new List<string>();
                var webElements = _remoteWebDriver.FindElements(By.Id(id));
				foreach (var webElement in webElements)
                {
                    cssValueList.Add(webElement.GetCssValue(cssPropertyName));
                }
                return cssValueList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<string> GetCssValueFromElementsById(string id, string cssPropertyName, int timeOutInSeconds)
        {
            try
            {
                var cssValueList = new List<string>();
				var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                var webElements = webDriverWait.Until(d => d.FindElements(By.Id(id)));
				foreach (var webElement in webElements)
                {
                    cssValueList.Add(webElement.GetCssValue(cssPropertyName));
                }
                return cssValueList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public string GetCssValueFromElementByLinkText(string linkText, string cssPropertyName)
        {
            try
            {
                return _remoteWebDriver.FindElement(By.LinkText(linkText)).GetCssValue(cssPropertyName);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public string GetCssValueFromElementByLinkText(string linkText, string cssPropertyName, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElement(By.LinkText(linkText))).GetCssValue(cssPropertyName);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<string> GetCssValueFromElementsByLinkText(string linkText, string cssPropertyName)
        {
            try
            {
                var cssValueList = new List<string>();
                var webElements = _remoteWebDriver.FindElements(By.LinkText(linkText));
				foreach (var webElement in webElements)
                {
                    cssValueList.Add(webElement.GetCssValue(cssPropertyName));
                }
                return cssValueList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<string> GetCssValueFromElementsByLinkText(string linkText, string cssPropertyName, int timeOutInSeconds)
        {
            try
            {
                var cssValueList = new List<string>();
				var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                var webElements = webDriverWait.Until(d => d.FindElements(By.LinkText(linkText)));
				foreach (var webElement in webElements)
                {
                    cssValueList.Add(webElement.GetCssValue(cssPropertyName));
                }
                return cssValueList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public string GetCssValueFromElementByName(string name, string cssPropertyName)
        {
            try
            {
                return _remoteWebDriver.FindElement(By.Name(name)).GetCssValue(cssPropertyName);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public string GetCssValueFromElementByName(string name, string cssPropertyName, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElement(By.Name(name))).GetCssValue(cssPropertyName);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<string> GetCssValueFromElementsByName(string name, string cssPropertyName)
        {
            try
            {
                var cssValueList = new List<string>();
                var webElements = _remoteWebDriver.FindElements(By.Name(name));
				foreach (var webElement in webElements)
                {
                    cssValueList.Add(webElement.GetCssValue(cssPropertyName));
                }
                return cssValueList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<string> GetCssValueFromElementsByName(string name, string cssPropertyName, int timeOutInSeconds)
        {
            try
            {
                var cssValueList = new List<string>();
				var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                var webElements = webDriverWait.Until(d => d.FindElements(By.Name(name)));
				foreach (var webElement in webElements)
                {
                    cssValueList.Add(webElement.GetCssValue(cssPropertyName));
                }
                return cssValueList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public string GetCssValueFromElementByTagName(string tagName, string cssPropertyName)
        {
            try
            {
                return _remoteWebDriver.FindElement(By.TagName(tagName)).GetCssValue(cssPropertyName);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public string GetCssValueFromElementByTagName(string tagName, string cssPropertyName, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElement(By.TagName(tagName))).GetCssValue(cssPropertyName);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<string> GetCssValueFromElementsByTagName(string tagName, string cssPropertyName)
        {
            try
            {
                var cssValueList = new List<string>();
                var webElements = _remoteWebDriver.FindElements(By.TagName(tagName));
				foreach (var webElement in webElements)
                {
                    cssValueList.Add(webElement.GetCssValue(cssPropertyName));
                }
                return cssValueList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<string> GetCssValueFromElementsByTagName(string tagName, string cssPropertyName, int timeOutInSeconds)
        {
            try
            {
                var cssValueList = new List<string>();
				var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                var webElements = webDriverWait.Until(d => d.FindElements(By.TagName(tagName)));
				foreach (var webElement in webElements)
                {
                    cssValueList.Add(webElement.GetCssValue(cssPropertyName));
                }
                return cssValueList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public string GetCssValueFromElementByXPath(string xPath, string cssPropertyName)
        {
            try
            {
                return _remoteWebDriver.FindElement(By.XPath(xPath)).GetCssValue(cssPropertyName);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public string GetCssValueFromElementByXPath(string xPath, string cssPropertyName, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElement(By.XPath(xPath))).GetCssValue(cssPropertyName);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<string> GetCssValueFromElementsByXPath(string xPath, string cssPropertyName)
        {
            try
            {
                var cssValueList = new List<string>();
                var webElements = _remoteWebDriver.FindElements(By.XPath(xPath));
				foreach (var webElement in webElements)
                {
                    cssValueList.Add(webElement.GetCssValue(cssPropertyName));
                }
                return cssValueList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<string> GetCssValueFromElementsByXPath(string xPath, string cssPropertyName, int timeOutInSeconds)
        {
            try
            {
                var cssValueList = new List<string>();
				var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                var webElements = webDriverWait.Until(d => d.FindElements(By.XPath(xPath)));
				foreach (var webElement in webElements)
                {
                    cssValueList.Add(webElement.GetCssValue(cssPropertyName));
                }
                return cssValueList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }
    }
}