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
    public class Attribute
    {
        private readonly RemoteWebDriver _remoteWebDriver;

        public Attribute(RemoteWebDriver remoteWebDriver)
        {
            _remoteWebDriver = remoteWebDriver;

        }

        public string GetAttributeFromElement(IWebElement webElement, string attributeName)
        {
            try
            {
                return webElement.GetAttribute(attributeName);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<string> GetAttributeFromElements(ReadOnlyCollection<IWebElement> webElements, string attributeName)
        {
            try
            {
                var attributeValues = new List<string>();
                foreach (var webElement in webElements)
                {
                    attributeValues.Add(webElement.GetAttribute(attributeName));
                }
                return attributeValues;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public string GetAttributeFromElementByClassName(string className, string attributeName)
        {
            try
            {
				return _remoteWebDriver.FindElement(By.ClassName(className)).GetAttribute(attributeName);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public string GetAttributeFromElementByClassName(string className, string attributeName, int timeOutInSeconds)
        {
            try
            {
				var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElement(By.ClassName(className))).GetAttribute(attributeName);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<string> GetAttributeFromElementsByClassName(string className, string attributeName)
        {
            try
            {
				var webElements = _remoteWebDriver.FindElements(By.ClassName(className));
				var attributeValues = new List<string>();
				foreach (var webElement in webElements)
                {
                    attributeValues.Add(webElement.GetAttribute(attributeName));
                }
                return attributeValues;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<string> GetAttributeFromElementsByClassName(string className, string attributeName, int timeOutInSeconds)
        {
            try
            {
				var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                var webElements = webDriverWait.Until(d => d.FindElements(By.ClassName(className)));
				var attributeValues = new List<string>();
				foreach (var webElement in webElements)
                {
                    attributeValues.Add(webElement.GetAttribute(attributeName));
                }
                return attributeValues;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public string GetAttributeFromElementByCssSelector(string cssSelector, string attributeName)
        {
            try
            {
				return _remoteWebDriver.FindElement(By.CssSelector(cssSelector)).GetAttribute(attributeName);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public string GetAttributeFromElementByCssSelector(string cssSelector, string attributeName, int timeOutInSeconds)
        {
            try
            {
				var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElement(By.CssSelector(cssSelector))).GetAttribute(attributeName);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<string> GetAttributeFromElementsByCssSelector(string cssSelector, string attributeName)
        {
            try
            {
				var webElements = _remoteWebDriver.FindElements(By.CssSelector(cssSelector));
				var attributeValues = new List<string>();
				foreach (var webElement in webElements)
                {
                    attributeValues.Add(webElement.GetAttribute(attributeName));
                }
                return attributeValues;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<string> GetAttributeFromElementsByCssSelector(string cssSelector, string attributeName, int timeOutInSeconds)
        {
            try
            {
				var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                var webElements = webDriverWait.Until(d => d.FindElements(By.CssSelector(cssSelector)));
				var attributeValues = new List<string>();
				foreach (var webElement in webElements)
                {
                    attributeValues.Add(webElement.GetAttribute(attributeName));
                }
                return attributeValues;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public string GetAttributeFromElementById(string id, string attributeName)
        {
            try
            {
				return _remoteWebDriver.FindElement(By.Id(id)).GetAttribute(attributeName);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public string GetAttributeFromElementById(string id, string attributeName, int timeOutInSeconds)
        {
            try
            {
				var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElement(By.Id(id))).GetAttribute(attributeName);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<string> GetAttributeFromElementsById(string id, string attributeName)
        {
            try
            {
				var webElements = _remoteWebDriver.FindElements(By.Id(id));
				var attributeValues = new List<string>();
				foreach (var webElement in webElements)
                {
                    attributeValues.Add(webElement.GetAttribute(attributeName));
                }
                return attributeValues;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<string> GetAttributeFromElementsById(string id, string attributeName, int timeOutInSeconds)
        {
            try
            {
				var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                var webElements = webDriverWait.Until(d => d.FindElements(By.Id(id)));
				var attributeValues = new List<string>();
				foreach (var webElement in webElements)
                {
                    attributeValues.Add(webElement.GetAttribute(attributeName));
                }
                return attributeValues;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public string GetAttributeFromElementByLinkText(string linkText, string attributeName)
        {
            try
            {
				return _remoteWebDriver.FindElement(By.LinkText(linkText)).GetAttribute(attributeName);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public string GetAttributeFromElementByLinkText(string linkText, string attributeName, int timeOutInSeconds)
        {
            try
            {
				var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElement(By.LinkText(linkText))).GetAttribute(attributeName);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<string> GetAttributeFromElementsByLinkText(string linkText, string attributeName)
        {
            try
            {
				var webElements = _remoteWebDriver.FindElements(By.LinkText(linkText));
				var attributeValues = new List<string>();
				foreach (var webElement in webElements)
                {
                    attributeValues.Add(webElement.GetAttribute(attributeName));
                }
                return attributeValues;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<string> GetAttributeFromElementsByLinkText(string linkText, string attributeName, int timeOutInSeconds)
        {
            try
            {
				var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                var webElements = webDriverWait.Until(d => d.FindElements(By.LinkText(linkText)));
				var attributeValues = new List<string>();
				foreach (var webElement in webElements)
                {
                    attributeValues.Add(webElement.GetAttribute(attributeName));
                }
                return attributeValues;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public string GetAttributeFromElementByName(string name, string attributeName)
        {
            try
            {
				return _remoteWebDriver.FindElement(By.Name(name)).GetAttribute(attributeName);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public string GetAttributeFromElementByName(string name, string attributeName, int timeOutInSeconds)
        {
            try
            {
				var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElement(By.Name(name))).GetAttribute(attributeName);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<string> GetAttributeFromElementsByName(string name, string attributeName)
        {
            try
            {
				var webElements = _remoteWebDriver.FindElements(By.Name(name));
				var attributeValues = new List<string>();
				foreach (var webElement in webElements)
                {
                    attributeValues.Add(webElement.GetAttribute(attributeName));
                }
                return attributeValues;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<string> GetAttributeFromElementsByName(string name, string attributeName, int timeOutInSeconds)
        {
            try
            {
				var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                var webElements = webDriverWait.Until(d => d.FindElements(By.Name(name)));
				var attributeValues = new List<string>();
				foreach (var webElement in webElements)
                {
                    attributeValues.Add(webElement.GetAttribute(attributeName));
                }
                return attributeValues;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public string GetAttributeFromElementByTagName(string tagName, string attributeName)
        {
            try
            {
				return _remoteWebDriver.FindElement(By.TagName(tagName)).GetAttribute(attributeName);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public string GetAttributeFromElementByTagName(string tagName, string attributeName, int timeOutInSeconds)
        {
            try
            {
				var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElement(By.TagName(tagName))).GetAttribute(attributeName);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<string> GetAttributeFromElementsByTagName(string tagName, string attributeName)
        {
            try
            {
				var webElements = _remoteWebDriver.FindElements(By.TagName(tagName));
				var attributeValues = new List<string>();
				foreach (var webElement in webElements)
                {
                    attributeValues.Add(webElement.GetAttribute(attributeName));
                }
                return attributeValues;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<string> GetAttributeFromElementsByTagName(string tagName, string attributeName, int timeOutInSeconds)
        {
            try
            {
				var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                var webElements = webDriverWait.Until(d => d.FindElements(By.TagName(tagName)));
				var attributeValues = new List<string>();
				foreach (var webElement in webElements)
                {
                    attributeValues.Add(webElement.GetAttribute(attributeName));
                }
                return attributeValues;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public string GetAttributeFromElementByXPath(string xPath, string attributeName)
        {
            try
            {
				return _remoteWebDriver.FindElement(By.XPath(xPath)).GetAttribute(attributeName);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public string GetAttributeFromElementByXPath(string xPath, string attributeName, int timeOutInSeconds)
        {
            try
            {
				var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElement(By.XPath(xPath))).GetAttribute(attributeName);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<string> GetAttributeFromElementsByXPath(string xPath, string attributeName)
        {
            try
            {
				var webElements = _remoteWebDriver.FindElements(By.XPath(xPath));
				var attributeValues = new List<string>();
				foreach (var webElement in webElements)
                {
                    attributeValues.Add(webElement.GetAttribute(attributeName));
                }
                return attributeValues;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<string> GetAttributeFromElementsByXPath(string xPath, string attributeName, int timeOutInSeconds)
        {
            try
            {
				var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                var webElements = webDriverWait.Until(d => d.FindElements(By.XPath(xPath)));
				var attributeValues = new List<string>();
				foreach (var webElement in webElements)
                {
                    attributeValues.Add(webElement.GetAttribute(attributeName));
                }
                return attributeValues;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }
    }
}

