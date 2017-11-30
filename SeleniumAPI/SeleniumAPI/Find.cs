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
            }
        }
    }
}