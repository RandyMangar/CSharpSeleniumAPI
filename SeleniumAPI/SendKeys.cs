using System;
using System.Collections.ObjectModel;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace SeleniumAPI
{
    public class SendKeys
    {
        private readonly RemoteWebDriver _remoteWebDriver;

        //Constructor
        public SendKeys(RemoteWebDriver remoteWebDriver)
        {
            _remoteWebDriver = remoteWebDriver;
        }

        //SendKeysToElement
        public void SendKeysToElement(IWebElement webElement, string keys)
        {
            try
            {
                webElement.SendKeys(keys);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        //SendKeysToElements
        public void SendKeysToElements(ReadOnlyCollection<IWebElement> webElements, string keys)
        {
            try
            {
                foreach (var webElement in webElements)
                {
                    webElement.SendKeys(keys);
                }
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        //SendKeysToElementByClassName
        public void SendKeysToElementByClassName(string className, string keys)
        {
            try
            {
                _remoteWebDriver.FindElement(By.ClassName(className)).SendKeys(keys);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        public void SendKeysToElementByClassName(string className, string keys, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                webDriverWait.Until(d => d.FindElement(By.ClassName(className))).SendKeys(keys);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        //SendKeysToElementsByClassName
        public void SendKeysToElementsByClassName(string className, string keys)
        {
            try
            {
                var webElements = _remoteWebDriver.FindElements(By.ClassName(className));
                foreach (var webElement in webElements)
                {
                    webElement.SendKeys(keys);
                }
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        public void SendKeysToElementsByClassName(string className, string keys, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                var webElements = webDriverWait.Until(d => d.FindElements(By.ClassName(className)));
                foreach (var webElement in webElements)
                {
                    webElement.SendKeys(keys);
                }
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        //SendKeysToElementByCssSelector
        public void SendKeysToElementByCssSelector(string cssSelector, string keys)
        {
            try
            {
                _remoteWebDriver.FindElement(By.CssSelector(cssSelector)).SendKeys(keys);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        public void SendKeysToElementByCssSelector(string cssSelector, string keys, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                webDriverWait.Until(d => d.FindElement(By.CssSelector(cssSelector))).SendKeys(keys);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        //SendKeysToElementsByCssSelector
        public void SendKeysToElementsByCssSelector(string cssSelector, string keys)
        {
            try
            {
                var webElements = _remoteWebDriver.FindElements(By.CssSelector(cssSelector));
                foreach (var webElement in webElements)
                {
                    webElement.SendKeys(keys);
                }
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        public void SendKeysToElementsByCssSelector(string cssSelector, string keys, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                var webElements = webDriverWait.Until(d => d.FindElements(By.CssSelector(cssSelector)));
                foreach (var webElement in webElements)
                {
                    webElement.SendKeys(keys);
                }
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        //SendKeysToElementById
        public void SendKeysToElementById(string id, string keys)
        {
            try
            {
                _remoteWebDriver.FindElement(By.Id(id)).SendKeys(keys);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        public void SendKeysToElementById(string id, string keys, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                webDriverWait.Until(d => d.FindElement(By.Id(id))).SendKeys(keys);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        //SendKeysToElementsById
        public void SendKeysToElementsById(string id, string keys)
        {
            try
            {
                var webElements = _remoteWebDriver.FindElements(By.Id(id));
                foreach (var webElement in webElements)
                {
                    webElement.SendKeys(keys);
                }
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        public void SendKeysToElementsById(string id, string keys, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                var webElements = webDriverWait.Until(d => d.FindElements(By.Id(id)));
                foreach (var webElement in webElements)
                {
                    webElement.SendKeys(keys);
                }
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        //SendKeysToElementByLinkText
        public void SendKeysToElementByLinkText(string linkText, string keys)
        {
            try
            {
                _remoteWebDriver.FindElement(By.LinkText(linkText)).SendKeys(keys);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        public void SendKeysToElementByLinkText(string linkText, string keys, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                webDriverWait.Until(d => d.FindElement(By.LinkText(linkText))).SendKeys(keys);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        //SendKeysToElementsByLinkText
        public void SendKeysToElementsByLinkText(string linkText, string keys)
        {
            try
            {
                var webElements = _remoteWebDriver.FindElements(By.LinkText(linkText));
                foreach (var webElement in webElements)
                {
                    webElement.SendKeys(keys);
                }
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        public void SendKeysToElementsByLinkText(string linkText, string keys, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                var webElements = webDriverWait.Until(d => d.FindElements(By.LinkText(linkText)));
                foreach (var webElement in webElements)
                {
                    webElement.SendKeys(keys);
                }
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        //SendKeysToElementByName
        public void SendKeysToElementByName(string name, string keys)
        {
            try
            {
                _remoteWebDriver.FindElement(By.Name(name)).SendKeys(keys);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        public void SendKeysToElementByName(string name, string keys, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                webDriverWait.Until(d => d.FindElement(By.Name(name))).SendKeys(keys);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        //SendKeysToElementsByName
        public void SendKeysToElementsByName(string name, string keys)
        {
            try
            {
                var webElements = _remoteWebDriver.FindElements(By.Name(name));
                foreach (var webElement in webElements)
                {
                    webElement.SendKeys(keys);
                }
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        public void SendKeysToElementsByName(string name, string keys, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                var webElements = webDriverWait.Until(d => d.FindElements(By.Name(name)));
                foreach (var webElement in webElements)
                {
                    webElement.SendKeys(keys);
                }
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        //SendKeysToElementByTagName
        public void SendKeysToElementByTagName(string tagName, string keys)
        {
            try
            {
                _remoteWebDriver.FindElement(By.TagName(tagName)).SendKeys(keys);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        public void SendKeysToElementByTagName(string tagName, string keys, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                webDriverWait.Until(d => d.FindElement(By.TagName(tagName))).SendKeys(keys);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        //SendKeysToElementsByTagName
        public void SendKeysToElementsByTagName(string tagName, string keys)
        {
            try
            {
                var webElements = _remoteWebDriver.FindElements(By.TagName(tagName));
                foreach (var webElement in webElements)
                {
                    webElement.SendKeys(keys);
                }
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        public void SendKeysToElementsByTagName(string tagName, string keys, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                var webElements = webDriverWait.Until(d => d.FindElements(By.TagName(tagName)));
                foreach (var webElement in webElements)
                {
                    webElement.SendKeys(keys);
                }
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        //SendKeysToElementByXPath
        public void SendKeysToElementByXPath(string xPath, string keys)
        {
            try
            {
                _remoteWebDriver.FindElement(By.XPath(xPath)).SendKeys(keys);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        public void SendKeysToElementByXPath(string xPath, string keys, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                webDriverWait.Until(d => d.FindElement(By.XPath(xPath))).SendKeys(keys);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        //SendKeysToElementsByXPath
        public void SendKeysToElementsByXPath(string xPath, string keys)
        {
            try
            {
                var webElements = _remoteWebDriver.FindElements(By.XPath(xPath));
                foreach (var webElement in webElements)
                {
                    webElement.SendKeys(keys);
                }
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        public void SendKeysToElementsByXPath(string xPath, string keys, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                var webElements = webDriverWait.Until(d => d.FindElements(By.XPath(xPath)));
                foreach (var webElement in webElements)
                {
                    webElement.SendKeys(keys);
                }
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}