using System;
using System.Collections.ObjectModel;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace SeleniumAPI
{
    public class Find
    {
        private readonly RemoteWebDriver _remoteWebDriver;

        //Constructor
        public Find(RemoteWebDriver remoteWebDriver)
        {
            _remoteWebDriver = remoteWebDriver;
        }

        //FindElementByClassName
        public IWebElement FindElementByClassName(string className)
        {
            try
            {
                return _remoteWebDriver.FindElement(By.ClassName(className));
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public IWebElement FindElementByclassName(string className, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElement(By.ClassName(className)));
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //FindElementsByClassName
        public ReadOnlyCollection<IWebElement> FindElementsByClassName(string className)
        {
            try
            {
                return _remoteWebDriver.FindElements(By.ClassName(className));
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public ReadOnlyCollection<IWebElement> FindElementsByclassName(string className, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElements(By.ClassName(className)));
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //FindElementByCssSelector
        public IWebElement FindElementByCssSelector(string cssSelector)
        {
            try
            {
                return _remoteWebDriver.FindElement(By.CssSelector(cssSelector));
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public IWebElement FindElementByCssSelector(string cssSelector, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElement(By.CssSelector(cssSelector)));
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //FindElementsByCssSelector
        public ReadOnlyCollection<IWebElement> FindElementsByCssSelector(string cssSelector)
        {
            try
            {
                return _remoteWebDriver.FindElements(By.CssSelector(cssSelector));
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public ReadOnlyCollection<IWebElement> FindElementsByCssSelector(string cssSelector, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElements(By.CssSelector(cssSelector)));
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //FindElementById
        public IWebElement FindElementById(string id)
        {
            try
            {
                return _remoteWebDriver.FindElement(By.Id(id));
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public IWebElement FindElementById(string id, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElement(By.Id(id)));
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //FindElementsById
        public ReadOnlyCollection<IWebElement> FindElementsById(string id)
        {
            try
            {
                return _remoteWebDriver.FindElements(By.Id(id));
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public ReadOnlyCollection<IWebElement> FindElementsById(string id, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElements(By.Id(id)));
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //FindElementByLinkText
        public IWebElement FindElementByLinkText(string linkText)
        {
            try
            {
                return _remoteWebDriver.FindElement(By.LinkText(linkText));
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public IWebElement FindElementByLinkText(string linkText, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElement(By.LinkText(linkText)));
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //FindElementsByLinkText
        public ReadOnlyCollection<IWebElement> FindElementsByLinkText(string linkText)
        {
            try
            {
                return _remoteWebDriver.FindElements(By.LinkText(linkText));
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public ReadOnlyCollection<IWebElement> FindElementsByLinkText(string linkText, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElements(By.LinkText(linkText)));
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //FindElementByName
        public IWebElement FindElementByName(string name)
        {
            try
            {
                return _remoteWebDriver.FindElement(By.Name(name));
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public IWebElement FindElementByName(string name, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElement(By.Name(name)));
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //FindElementsByName
        public ReadOnlyCollection<IWebElement> FindElementsByName(string name)
        {
            try
            {
                return _remoteWebDriver.FindElements(By.Name(name));
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public ReadOnlyCollection<IWebElement> FindElementsByName(string name, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElements(By.Name(name)));
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //FindElementByTagName
        public IWebElement FindElementByTagName(string tagName)
        {
            try
            {
                return _remoteWebDriver.FindElement(By.TagName(tagName));
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public IWebElement FindElementByTagName(string tagName, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElement(By.TagName(tagName)));
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //FindElementsByTagName
        public ReadOnlyCollection<IWebElement> FindElementsByTagName(string tagName)
        {
            try
            {
                return _remoteWebDriver.FindElements(By.TagName(tagName));
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public ReadOnlyCollection<IWebElement> FindElementsByTagName(string tagName, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElements(By.TagName(tagName)));
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //FindElementXPath
        public IWebElement FindElementByXPath(string xPath)
        {
            try
            {
                return _remoteWebDriver.FindElement(By.XPath(xPath));
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public IWebElement FindElementByXPath(string xPath, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElement(By.XPath(xPath)));
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //FindElementsByXPath
        public ReadOnlyCollection<IWebElement> FindElementsByXPath(string xPath)
        {
            try
            {
                return _remoteWebDriver.FindElements(By.XPath(xPath));
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public ReadOnlyCollection<IWebElement> FindElementsByXPath(string xPath, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElements(By.XPath(xPath)));
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }
    }
}