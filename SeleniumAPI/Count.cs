using System;
using System.Collections.ObjectModel;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace SeleniumAPI
{
    public class Count
    {
        private readonly RemoteWebDriver _remoteWebDriver;

        //Constructor
        public Count(RemoteWebDriver remoteWebDriver)
        {
            _remoteWebDriver = remoteWebDriver;
        }

        //CountElements
        public int CountElements(ReadOnlyCollection<IWebElement> webElements)
        {
            try
            {
                return webElements.Count;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //CountElementsByClassName
        public int CountElementsByClassName(string className)
        {
            try
            {
                return _remoteWebDriver.FindElements(By.ClassName(className)).Count;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public int CountElementsByclassName(string className, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElements(By.ClassName(className))).Count;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //CountElementsByCssSelector
        public int CountElementsByCssSelector(string cssSelector)
        {
            try
            {
                return _remoteWebDriver.FindElements(By.CssSelector(cssSelector)).Count;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public int CountElementsByCssSelector(string cssSelector, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElements(By.CssSelector(cssSelector))).Count;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //CountElementsById
        public int CountElementsById(string id)
        {
            try
            {
                return _remoteWebDriver.FindElements(By.Id(id)).Count;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public int CountElementsById(string id, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElements(By.Id(id))).Count;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //CountElementsByLinkText
        public int CountElementsByLinkText(string linkText)
        {
            try
            {
                return _remoteWebDriver.FindElements(By.LinkText(linkText)).Count;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public int CountElementsByLinkText(string linkText, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElements(By.LinkText(linkText))).Count;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //CountElementsByName
        public int CountElementsByName(string name)
        {
            try
            {
                return _remoteWebDriver.FindElements(By.Name(name)).Count;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public int CountElementsByName(string name, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElements(By.Name(name))).Count;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //CountElementsByTagName
        public int CountElementsByTagName(string tagName)
        {
            try
            {
                return _remoteWebDriver.FindElements(By.TagName(tagName)).Count;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public int CountElementsByTagName(string tagName, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElements(By.TagName(tagName))).Count;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //CountElementsByXPath
        public int CountElementsByXPath(string xPath)
        {
            try
            {
                return _remoteWebDriver.FindElements(By.XPath(xPath)).Count;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public int CountElementsByXPath(string xPath, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElements(By.XPath(xPath))).Count;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }
    }
}
