using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace SeleniumAPI
{
    public class Size
    {
        private readonly RemoteWebDriver _remoteWebDriver;

        //Constructor
        public Size(RemoteWebDriver remoteWebDriver)
        {
            _remoteWebDriver = remoteWebDriver;
        }

        //GetSizeFromElement
        public System.Drawing.Size GetSizeFromElement(IWebElement webElement)
        {
            try
            {
                return webElement.Size;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetSizeFromElements
        public List<System.Drawing.Size> GetSizeFromElements(List<IWebElement> webElements, string cssPropertyName)
        {
            try
            {
                var sizeList = new List<System.Drawing.Size>();
                foreach (var webElement in webElements)
                {
                    sizeList.Add(webElement.Size);
                }
                return sizeList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }


        //GetSizeFromElementByClassName
        public System.Drawing.Size GetSizeFromElementByClassName(string className)
        {
            try
            {
                return _remoteWebDriver.FindElement(By.ClassName(className)).Size;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public System.Drawing.Size GetSizeFromElementByClassName(string className, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElement(By.ClassName(className))).Size;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetSizeFromElementsByClassName
        public List<System.Drawing.Size> GetSizeFromElementsByClassName(string className)
        {
            try
            {
                var locationList = new List<System.Drawing.Size>();
                var webElements = _remoteWebDriver.FindElements(By.ClassName(className));
                foreach (var webElement in webElements)
                {
                    locationList.Add(webElement.Size);
                }
                return locationList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<System.Drawing.Size> GetLocationFromElementsByClassName(string className, int timeOutInSeconds)
        {
            try
            {
                var sizeList = new List<System.Drawing.Size>();
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                var webElements = webDriverWait.Until(d => d.FindElements(By.ClassName(className)));
                foreach (var webElement in webElements)
                {
                    sizeList.Add(webElement.Size);
                }
                return sizeList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetSizeFromElementByCssSelector
        public System.Drawing.Size GetSizeFromElementByCssSelector(string cssSelector)
        {
            try
            {
                return _remoteWebDriver.FindElement(By.CssSelector(cssSelector)).Size;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public System.Drawing.Size GetSizeFromElementByCssSelector(string cssSelector, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElement(By.CssSelector(cssSelector))).Size;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetSizeFromElementsByCssSelector
        public List<System.Drawing.Size> GetSizeFromElementsByCssSelector(string cssSelector)
        {
            try
            {
                var sizeList = new List<System.Drawing.Size>();
                var webElements = _remoteWebDriver.FindElements(By.CssSelector(cssSelector));
                foreach (var webElement in webElements)
                {
                    sizeList.Add(webElement.Size);
                }
                return sizeList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<System.Drawing.Size> GetSizeFromElementsByCssSelector(string cssSelector, int timeOutInSeconds)
        {
            try
            {
                var sizeList = new List<System.Drawing.Size>();
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                var webElements = webDriverWait.Until(d => d.FindElements(By.CssSelector(cssSelector)));
                foreach (var webElement in webElements)
                {
                    sizeList.Add(webElement.Size);
                }
                return sizeList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetSizeFromElementById
        public System.Drawing.Size GetSizeFromElementById(string id)
        {
            try
            {
                return _remoteWebDriver.FindElement(By.Id(id)).Size;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public System.Drawing.Size GetSizeFromElementById(string id, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElement(By.Id(id))).Size;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetSizeFromElementsById
        public List<System.Drawing.Size> GetSizeFromElementsById(string id)
        {
            try
            {
                var sizeList = new List<System.Drawing.Size>();
                var webElements = _remoteWebDriver.FindElements(By.Id(id));
                foreach (var webElement in webElements)
                {
                    sizeList.Add(webElement.Size);
                }
                return sizeList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<System.Drawing.Size> GetSizeFromElementsById(string id, int timeOutInSeconds)
        {
            try
            {
                var sizeList = new List<System.Drawing.Size>();
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                var webElements = webDriverWait.Until(d => d.FindElements(By.Id(id)));
                foreach (var webElement in webElements)
                {
                    sizeList.Add(webElement.Size);
                }
                return sizeList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetSizeFromElementByLinkText
        public System.Drawing.Size GetSizeFromElementByLinkText(string linkText)
        {
            try
            {
                return _remoteWebDriver.FindElement(By.Id(linkText)).Size;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public System.Drawing.Size GetSizeFromElementByLinkText(string linkText, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElement(By.LinkText(linkText))).Size;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetSizeFromElementsByLinkText
        public List<System.Drawing.Size> GetSizeFromElementsByLinkText(string linkText)
        {
            try
            {
                var sizeList = new List<System.Drawing.Size>();
                var webElements = _remoteWebDriver.FindElements(By.LinkText(linkText));
                foreach (var webElement in webElements)
                {
                    sizeList.Add(webElement.Size);
                }
                return sizeList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<System.Drawing.Size> GetSizeFromElementsByLinkText(string linkText, int timeOutInSeconds)
        {
            try
            {
                var sizeList = new List<System.Drawing.Size>();
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                var webElements = webDriverWait.Until(d => d.FindElements(By.LinkText(linkText)));
                foreach (var webElement in webElements)
                {
                    sizeList.Add(webElement.Size);
                }
                return sizeList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetSizeFromElementByName
        public System.Drawing.Size GetSizeFromElementByName(string name)
        {
            try
            {
                return _remoteWebDriver.FindElement(By.Name(name)).Size;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public System.Drawing.Size GetSizeFromElementByName(string name, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElement(By.Name(name))).Size;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetSizeFromElementsByName
        public List<System.Drawing.Size> GetSizeFromElementsByName(string name)
        {
            try
            {
                var sizeList = new List<System.Drawing.Size>();
                var webElements = _remoteWebDriver.FindElements(By.Name(name));
                foreach (var webElement in webElements)
                {
                    sizeList.Add(webElement.Size);
                }
                return sizeList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<System.Drawing.Size> GetSizeFromElementsByName(string name, int timeOutInSeconds)
        {
            try
            {
                var sizeList = new List<System.Drawing.Size>();
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                var webElements = webDriverWait.Until(d => d.FindElements(By.Name(name)));
                foreach (var webElement in webElements)
                {
                    sizeList.Add(webElement.Size);
                }
                return sizeList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetSizeFromElementByTagName
        public System.Drawing.Size GetSizeFromElementByTagName(string tagName)
        {
            try
            {
                return _remoteWebDriver.FindElement(By.TagName(tagName)).Size;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public System.Drawing.Size GetSizeFromElementByTagName(string tagName, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElement(By.TagName(tagName))).Size;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetSizeFromElementsByTagName
        public List<System.Drawing.Size> GetSizeFromElementsByTagName(string tagName)
        {
            try
            {
                var sizeList = new List<System.Drawing.Size>();
                var webElements = _remoteWebDriver.FindElements(By.TagName(tagName));
                foreach (var webElement in webElements)
                {
                    sizeList.Add(webElement.Size);
                }
                return sizeList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<System.Drawing.Size> GetSizeFromElementsByTagName(string tagName, int timeOutInSeconds)
        {
            try
            {
                var sizeList = new List<System.Drawing.Size>();
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                var webElements = webDriverWait.Until(d => d.FindElements(By.TagName(tagName)));
                foreach (var webElement in webElements)
                {
                    sizeList.Add(webElement.Size);
                }
                return sizeList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetSizeFromElementByXPath
        public System.Drawing.Size GetSizeFromElementByXPath(string xPath)
        {
            try
            {
                return _remoteWebDriver.FindElement(By.XPath(xPath)).Size;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public System.Drawing.Size GetSizeFromElementByXPath(string xPath, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElement(By.XPath(xPath))).Size;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetSizeFromElementsByXPath
        public List<System.Drawing.Size> GetSizeFromElementsByXPath(string xPath)
        {
            try
            {
                var sizeList = new List<System.Drawing.Size>();
                var webElements = _remoteWebDriver.FindElements(By.TagName(xPath));
                foreach (var webElement in webElements)
                {
                    sizeList.Add(webElement.Size);
                }
                return sizeList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<System.Drawing.Size> GetSizeFromElementsByXPath(string xPath, int timeOutInSeconds)
        {
            try
            {
                var sizeList = new List<System.Drawing.Size>();
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                var webElements = webDriverWait.Until(d => d.FindElements(By.XPath(xPath)));
                foreach (var webElement in webElements)
                {
                    sizeList.Add(webElement.Size);
                }
                return sizeList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }
    }
}
