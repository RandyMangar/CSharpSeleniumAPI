using System;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace SeleniumAPI
{
    public class TagName
    {
        private readonly RemoteWebDriver _remoteWebDriver;

        //Constructor
        public TagName(RemoteWebDriver remoteWebDriver)
        {
            _remoteWebDriver = remoteWebDriver;
        }

        //GetTagNameFromElement
        public string GetTagNameFromElement(IWebElement webElement)
        {
            try
            {
                return webElement.TagName;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetTagNameFromElements
        public List<string> GetTagNameFromElements(List<IWebElement> webElements, string cssPropertyName)
        {
            try
            {
                var tagNameList = new List<string>();
                foreach (var webElement in webElements)
                {
                    tagNameList.Add(webElement.TagName);
                }
                return tagNameList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }


        //GetTagNameFromElementByClassName
        public string GetTagNameFromElementByClassName(string className)
        {
            try
            {
                return _remoteWebDriver.FindElement(By.ClassName(className)).TagName;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public string GetTagNameFromElementByClassName(string className, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElement(By.ClassName(className))).TagName;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetTagNameFromElementsByClassName
        public List<string> GetTagNameFromElementsByClassName(string className)
        {
            try
            {
                var tagNameList = new List<string>();
                var webElements = _remoteWebDriver.FindElements(By.ClassName(className));
                foreach (var webElement in webElements)
                {
                    tagNameList.Add(webElement.TagName);
                }
                return tagNameList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<string> GetTagNameFromElementsByClassName(string className, int timeOutInSeconds)
        {
            try
            {
                var tagNameList = new List<string>();
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                var webElements = webDriverWait.Until(d => d.FindElements(By.ClassName(className)));
                foreach (var webElement in webElements)
                {
                    tagNameList.Add(webElement.TagName);
                }
                return tagNameList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetTagNameFromElementByCssSelector
        public string GetTagNameFromElementByCssSelector(string cssSelector)
        {
            try
            {
                return _remoteWebDriver.FindElement(By.CssSelector(cssSelector)).TagName;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public string GetTagNameFromElementByCssSelector(string cssSelector, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElement(By.CssSelector(cssSelector))).TagName;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetTagNameFromElementsByCssSelector
        public List<string> GetTagNameFromElementsByCssSelector(string cssSelector)
        {
            try
            {
                var tagNameList = new List<string>();
                var webElements = _remoteWebDriver.FindElements(By.CssSelector(cssSelector));
                foreach (var webElement in webElements)
                {
                    tagNameList.Add(webElement.TagName);
                }
                return tagNameList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<string> GetTagNameFromElementsByCssSelector(string cssSelector, int timeOutInSeconds)
        {
            try
            {
                var tagNameList = new List<string>();
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                var webElements = webDriverWait.Until(d => d.FindElements(By.CssSelector(cssSelector)));
                foreach (var webElement in webElements)
                {
                    tagNameList.Add(webElement.TagName);
                }
                return tagNameList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetTagNameFromElementById
        public string GetTagNameFromElementById(string id)
        {
            try
            {
                return _remoteWebDriver.FindElement(By.Id(id)).TagName;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public string GetTagNameFromElementById(string id, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElement(By.Id(id))).TagName;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetTagNameFromElementsById
        public List<string> GetTagNameFromElementsById(string id)
        {
            try
            {
                var tagNameList = new List<string>();
                var webElements = _remoteWebDriver.FindElements(By.Id(id));
                foreach (var webElement in webElements)
                {
                    tagNameList.Add(webElement.TagName);
                }
                return tagNameList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<string> GetTagNameFromElementsById(string id, int timeOutInSeconds)
        {
            try
            {
                var tagNameList = new List<string>();
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                var webElements = webDriverWait.Until(d => d.FindElements(By.Id(id)));
                foreach (var webElement in webElements)
                {
                    tagNameList.Add(webElement.TagName);
                }
                return tagNameList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetTagNameFromElementByLinkText
        public string GetTagNameFromElementByLinkText(string linkText)
        {
            try
            {
                return _remoteWebDriver.FindElement(By.LinkText(linkText)).TagName;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public string GetTagNameFromElementByLinkText(string linkText, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElement(By.LinkText(linkText))).TagName;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetTagNameFromElementsByLinkText
        public List<string> GetTagNameFromElementsByLinkText(string linkText)
        {
            try
            {
                var tagNameList = new List<string>();
                var webElements = _remoteWebDriver.FindElements(By.LinkText(linkText));
                foreach (var webElement in webElements)
                {
                    tagNameList.Add(webElement.TagName);
                }
                return tagNameList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<string> GetTagNameFromElementsByLinkText(string linkText, int timeOutInSeconds)
        {
            try
            {
                var tagNameList = new List<string>();
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                var webElements = webDriverWait.Until(d => d.FindElements(By.LinkText(linkText)));
                foreach (var webElement in webElements)
                {
                    tagNameList.Add(webElement.TagName);
                }
                return tagNameList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetTagNameFromElementByName
        public string GetTagNameFromElementByName(string name)
        {
            try
            {
                return _remoteWebDriver.FindElement(By.Name(name)).TagName;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public string GetTagNameFromElementByName(string name, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElement(By.Name(name))).TagName;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetTagNameFromElementsByName
        public List<string> GetTagNameFromElementsByName(string name)
        {
            try
            {
                var tagNameList = new List<string>();
                var webElements = _remoteWebDriver.FindElements(By.Name(name));
                foreach (var webElement in webElements)
                {
                    tagNameList.Add(webElement.TagName);
                }
                return tagNameList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<string> GetTagNameFromElementsByName(string name, int timeOutInSeconds)
        {
            try
            {
                var tagNameList = new List<string>();
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                var webElements = webDriverWait.Until(d => d.FindElements(By.Name(name)));
                foreach (var webElement in webElements)
                {
                    tagNameList.Add(webElement.TagName);
                }
                return tagNameList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetTagNameFromElementByTagName
        public string GetTagNameFromElementByTagName(string tagName)
        {
            try
            {
                return _remoteWebDriver.FindElement(By.TagName(tagName)).TagName;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public string GetTagNameFromElementByTagName(string tagName, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElement(By.TagName(tagName))).TagName;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetTagNameFromElementsByTagName
        public List<string> GetTagNameFromElementsByTagName(string tagName)
        {
            try
            {
                var tagNameList = new List<string>();
                var webElements = _remoteWebDriver.FindElements(By.TagName(tagName));
                foreach (var webElement in webElements)
                {
                    tagNameList.Add(webElement.TagName);
                }
                return tagNameList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<string> GetTagNameFromElementsByTagName(string tagName, int timeOutInSeconds)
        {
            try
            {
                var tagNameList = new List<string>();
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                var webElements = webDriverWait.Until(d => d.FindElements(By.TagName(tagName)));
                foreach (var webElement in webElements)
                {
                    tagNameList.Add(webElement.TagName);
                }
                return tagNameList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetTagNameFromElementByXPath
        public string GetTagNameFromElementByXPath(string xPath)
        {
            try
            {
                return _remoteWebDriver.FindElement(By.XPath(xPath)).TagName;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public string GetTagNameFromElementByXPath(string xPath, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElement(By.XPath(xPath))).TagName;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetTagNameFromElementsByXPath
        public List<string> GetTagNameFromElementsByXPath(string xPath)
        {
            try
            {
                var tagNameList = new List<string>();
                var webElements = _remoteWebDriver.FindElements(By.XPath(xPath));
                foreach (var webElement in webElements)
                {
                    tagNameList.Add(webElement.TagName);
                }
                return tagNameList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<string> GetTagNameFromElementsByXPath(string xPath, int timeOutInSeconds)
        {
            try
            {
                var tagNameList = new List<string>();
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                var webElements = webDriverWait.Until(d => d.FindElements(By.XPath(xPath)));
                foreach (var webElement in webElements)
                {
                    tagNameList.Add(webElement.TagName);
                }
                return tagNameList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }
    }
}
