using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace SeleniumAPI
{
    public class Visibility
    {
        private readonly RemoteWebDriver _remoteWebDriver;

        //Constructor
        public Visibility(RemoteWebDriver remoteWebDriver)
        {
            _remoteWebDriver = remoteWebDriver;
        }

        //GetVisibilityOfElement
        public bool GetVisibilityOfElement(IWebElement webElement)
        {
            try
            {
                return webElement.Displayed;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetVisibilityOfElements
        public List<bool> GetVisibilityOfElements(ReadOnlyCollection<IWebElement> webElements)
        {
            try
            {
                var visibilityList = new List<bool>();
                foreach (var webElement in webElements)
                {
                    visibilityList.Add(webElement.Displayed);
                }
                return visibilityList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetVisibilityOfElementByClassName
        public bool GetVisibilityOfElementByClassName(string className)
        {
            try
            {
                return _remoteWebDriver.FindElement(By.ClassName(className)).Displayed;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public bool GetVisibilityOfElementByClassName(string className, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElement(By.ClassName(className))).Displayed;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetVisibilityOfElementsByClassName
        public List<bool> GetVisibilityOfElementsByClassName(string className)
        {
            try
            {
                var visibilityList = new List<bool>();
                var webElements = _remoteWebDriver.FindElements(By.ClassName(className));
                foreach (var webElement in webElements)
                {
                    visibilityList.Add(webElement.Displayed);
                }
                return visibilityList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<bool> GetVisibilityOfElementsByClassName(string className, int timeOutInSeconds)
        {
            try
            {
                var visibilityList = new List<bool>();
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                var webElements = webDriverWait.Until(d => d.FindElements(By.ClassName(className)));
                foreach (var webElement in webElements)
                {
                    visibilityList.Add(webElement.Displayed);
                }
                return visibilityList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetVisibilityOfElementByCssSelector
        public bool GetVisibilityOfElementByCssSelector(string cssSelector)
        {
            try
            {
                return _remoteWebDriver.FindElement(By.CssSelector(cssSelector)).Displayed;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public bool GetVisibilityOfElementByCssSelector(string cssSelector, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElement(By.CssSelector(cssSelector))).Displayed;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetVisibilityOfElementsByCssSelector
        public List<bool> GetVisibilityOfElementsByCssSelector(string cssSelector)
        {
            try
            {
                var visibilityList = new List<bool>();
                var webElements = _remoteWebDriver.FindElements(By.CssSelector(cssSelector));
                foreach (var webElement in webElements)
                {
                    visibilityList.Add(webElement.Displayed);
                }
                return visibilityList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<bool> GetVisibilityOfElementsByCssSelector(string cssSelector, int timeOutInSeconds)
        {
            try
            {
                var visibilityList = new List<bool>();
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                var webElements = webDriverWait.Until(d => d.FindElements(By.CssSelector(cssSelector)));
                foreach (var webElement in webElements)
                {
                    visibilityList.Add(webElement.Displayed);
                }
                return visibilityList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetVisibilityOfElementById
        public bool GetVisibilityOfElementById(string id)
        {
            try
            {
                return _remoteWebDriver.FindElement(By.Id(id)).Displayed;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public bool GetVisibilityOfElementById(string id, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElement(By.Id(id))).Displayed;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetVisibilityOfElementsById
        public List<bool> GetVisibilityOfElementsById(string id)
        {
            try
            {
                var visibilityList = new List<bool>();
                var webElements = _remoteWebDriver.FindElements(By.Id(id));
                foreach (var webElement in webElements)
                {
                    visibilityList.Add(webElement.Displayed);
                }
                return visibilityList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<bool> GetVisibilityOfElementsById(string id, int timeOutInSeconds)
        {
            try
            {
                var visibilityList = new List<bool>();
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                var webElements = webDriverWait.Until(d => d.FindElements(By.Id(id)));
                foreach (var webElement in webElements)
                {
                    visibilityList.Add(webElement.Displayed);
                }
                return visibilityList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetVisibilityOfElementByLinkText
        public bool GetVisibilityOfElementByLinkText(string linkText)
        {
            try
            {
                return _remoteWebDriver.FindElement(By.LinkText(linkText)).Displayed;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public bool GetVisibilityOfElementByLinkText(string linkText, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElement(By.LinkText(linkText))).Displayed;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetVisibilityOfElementsByLinkText
        public List<bool> GetVisibilityOfElementsByLinkText(string linkText)
        {
            try
            {
                var visibilityList = new List<bool>();
                var webElements = _remoteWebDriver.FindElements(By.LinkText(linkText));
                foreach (var webElement in webElements)
                {
                    visibilityList.Add(webElement.Displayed);
                }
                return visibilityList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<bool> GetVisibilityOfElementsByLinkText(string linkText, int timeOutInSeconds)
        {
            try
            {
                var visibilityList = new List<bool>();
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                var webElements = webDriverWait.Until(d => d.FindElements(By.LinkText(linkText)));
                foreach (var webElement in webElements)
                {
                    visibilityList.Add(webElement.Displayed);
                }
                return visibilityList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetVisibilityOfElementByName
        public bool GetVisibilityOfElementByName(string name)
        {
            try
            {
                return _remoteWebDriver.FindElement(By.Name(name)).Displayed;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public bool GetVisibilityOfElementByName(string name, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElement(By.Name(name))).Displayed;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetVisibilityOfElementsByName
        public List<bool> GetVisibilityOfElementsByName(string name)
        {
            try
            {
                var visibilityList = new List<bool>();
                var webElements = _remoteWebDriver.FindElements(By.Name(name));
                foreach (var webElement in webElements)
                {
                    visibilityList.Add(webElement.Displayed);
                }
                return visibilityList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<bool> GetVisibilityOfElementsByName(string name, int timeOutInSeconds)
        {
            try
            {
                var visibilityList = new List<bool>();
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                var webElements = webDriverWait.Until(d => d.FindElements(By.Name(name)));
                foreach (var webElement in webElements)
                {
                    visibilityList.Add(webElement.Displayed);
                }
                return visibilityList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetVisibilityOfElementByTagName
        public bool GetVisibilityOfElementByTagName(string tagName)
        {
            try
            {
                return _remoteWebDriver.FindElement(By.TagName(tagName)).Displayed;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public bool GetVisibilityOfElementByTagName(string tagName, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElement(By.TagName(tagName))).Displayed;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetVisibilityOfElementsByTagName
        public List<bool> GetVisibilityOfElementsByTagName(string tagName)
        {
            try
            {
                var visibilityList = new List<bool>();
                var webElements = _remoteWebDriver.FindElements(By.TagName(tagName));
                foreach (var webElement in webElements)
                {
                    visibilityList.Add(webElement.Displayed);
                }
                return visibilityList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<bool> GetVisibilityOfElementsByTagName(string tagName, int timeOutInSeconds)
        {
            try
            {
                var visibilityList = new List<bool>();
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                var webElements = webDriverWait.Until(d => d.FindElements(By.TagName(tagName)));
                foreach (var webElement in webElements)
                {
                    visibilityList.Add(webElement.Displayed);
                }
                return visibilityList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetVisibilityOfElementByXPath
        public bool GetVisibilityOfElementByXPath(string xPath)
        {
            try
            {
                return _remoteWebDriver.FindElement(By.XPath(xPath)).Displayed;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public bool GetVisibilityOfElementByXPath(string xPath, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElement(By.XPath(xPath))).Displayed;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetVisibilityOfElementsByXPath
        public List<bool> GetVisibilityOfElementsByXPath(string xPath)
        {
            try
            {
                var visibilityList = new List<bool>();
                var webElements = _remoteWebDriver.FindElements(By.XPath(xPath));
                foreach (var webElement in webElements)
                {
                    visibilityList.Add(webElement.Displayed);
                }
                return visibilityList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<bool> GetVisibilityOfElementsByXPath(string xPath, int timeOutInSeconds)
        {
            try
            {
                var visibilityList = new List<bool>();
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                var webElements = webDriverWait.Until(d => d.FindElements(By.XPath(xPath)));
                foreach (var webElement in webElements)
                {
                    visibilityList.Add(webElement.Displayed);
                }
                return visibilityList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }
    }
}