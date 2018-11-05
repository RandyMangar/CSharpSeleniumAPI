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
    //Version 1.0
    public class Size
    {
        private readonly RemoteWebDriver _remoteWebDriver;
        public Size(RemoteWebDriver remoteWebDriver)
        {
            _remoteWebDriver = remoteWebDriver;
        }

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

        public List<System.Drawing.Size> GetSizesFromElements(ReadOnlyCollection<IWebElement> webElements, string cssPropertyName)
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

        public List<System.Drawing.Size> GetSizesFromElementsByClassName(string className)
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

        public List<System.Drawing.Size> GetSizesFromElementsByClassName(string className, int timeOutInSeconds)
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

        public List<System.Drawing.Size> GetSizesFromElementsByCssSelector(string cssSelector)
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

        public List<System.Drawing.Size> GetSizesFromElementsByCssSelector(string cssSelector, int timeOutInSeconds)
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

        public List<System.Drawing.Size> GetSizesFromElementsById(string id)
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

        public List<System.Drawing.Size> GetSizesFromElementsById(string id, int timeOutInSeconds)
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

        public List<System.Drawing.Size> GetSizesFromElementsByLinkText(string linkText)
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

        public List<System.Drawing.Size> GetSizesFromElementsByLinkText(string linkText, int timeOutInSeconds)
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

        public List<System.Drawing.Size> GetSizesFromElementsByName(string name)
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

        public List<System.Drawing.Size> GetSizesFromElementsByName(string name, int timeOutInSeconds)
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

        public List<System.Drawing.Size> GetSizesFromElementsByTagName(string tagName)
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

        public List<System.Drawing.Size> GetSizesFromElementsByTagName(string tagName, int timeOutInSeconds)
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

        public List<System.Drawing.Size> GetSizesFromElementsByXPath(string xPath)
        {
            try
            {
                var sizeList = new List<System.Drawing.Size>();
                var webElements = _remoteWebDriver.FindElements(By.XPath(xPath));
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

        public List<System.Drawing.Size> GetSizesFromElementsByXPath(string xPath, int timeOutInSeconds)
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
