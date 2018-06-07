using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace SeleniumAPI
{
    public class Selected
    {
        private readonly RemoteWebDriver _remoteWebDriver;

        //Constructor
        public Selected(RemoteWebDriver remoteWebDriver)
        {
            _remoteWebDriver = remoteWebDriver;
        }

        //GetSelectedFromElement
        public bool GetSelectedFromElement(IWebElement webElement)
        {
            try
            {
                return webElement.Selected;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetSelectedFromElements
        public List<bool> GetSelectedFromElements(ReadOnlyCollection<IWebElement> webElements)
        {
            try
            {
                var selectedList = new List<bool>();
                foreach (var webElement in webElements)
                {
                    selectedList.Add(webElement.Selected);
                }

                return selectedList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }


        //GetSelectedFromElementByClassName
        public bool GetSelectedFromElementByClassName(string className)
        {
            try
            {
                return _remoteWebDriver.FindElement(By.ClassName(className)).Selected;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public bool GetSelectedFromElementByClassName(string className, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElement(By.ClassName(className))).Selected;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetSelectedFromElementsByClassName
        public List<bool> GetSelectedFromElementsByClassName(string className)
        {
            try
            {
                var selectedList = new List<bool>();
                var webElements = _remoteWebDriver.FindElements(By.ClassName(className));
                foreach (var webElement in webElements)
                {
                    selectedList.Add(webElement.Selected);
                }
                return selectedList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<bool> GetSelectedFromElementsByClassName(string className, int timeOutInSeconds)
        {
            try
            {
                var selectedList = new List<bool>();
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                var webElements = webDriverWait.Until(d => d.FindElements(By.ClassName(className)));
                foreach (var webElement in webElements)
                {
                    selectedList.Add(webElement.Selected);
                }
                return selectedList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetSelectedFromElementByCssSelector
        public bool GetSelectedFromElementByCssSelector(string cssSelector)
        {
            try
            {
                return _remoteWebDriver.FindElement(By.CssSelector(cssSelector)).Selected;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public bool GetSelectedFromElementByCssSelector(string cssSelector, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElement(By.CssSelector(cssSelector))).Selected;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetSelectedFromElementsByCssSelector
        public List<bool> GetSelectedFromElementsByCssSelector(string cssSelector)
        {
            try
            {
                var selectedList = new List<bool>();
                var webElements = _remoteWebDriver.FindElements(By.CssSelector(cssSelector));
                foreach (var webElement in webElements)
                {
                    selectedList.Add(webElement.Selected);
                }
                return selectedList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<bool> GetSelectedFromElementsByCssSelector(string cssSelector, int timeOutInSeconds)
        {
            try
            {
                var selectedList = new List<bool>();
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                var webElements = webDriverWait.Until(d => d.FindElements(By.CssSelector(cssSelector)));
                foreach (var webElement in webElements)
                {
                    selectedList.Add(webElement.Selected);
                }
                return selectedList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetSelectedFromElementById
        public bool GetSelectedFromElementById(string id)
        {
            try
            {
                return _remoteWebDriver.FindElement(By.Id(id)).Selected;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public bool GetSelectedFromElementById(string id, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElement(By.Id(id))).Selected;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetSelectedFromElementsById
        public List<bool> GetSelectedFromElementsById(string id)
        {
            try
            {
                var selectedList = new List<bool>();
                var webElements = _remoteWebDriver.FindElements(By.Id(id));
                foreach (var webElement in webElements)
                {
                    selectedList.Add(webElement.Selected);
                }
                return selectedList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<bool> GetSelectedFromElementsById(string id, int timeOutInSeconds)
        {
            try
            {
                var selectedList = new List<bool>();
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                var webElements = webDriverWait.Until(d => d.FindElements(By.Id(id)));
                foreach (var webElement in webElements)
                {
                    selectedList.Add(webElement.Selected);
                }
                return selectedList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetSelectedFromElementByLinkText
        public bool GetSelectedFromElementByLinkText(string linkText)
        {
            try
            {
                return _remoteWebDriver.FindElement(By.LinkText(linkText)).Selected;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public bool GetSelectedFromElementByLinkText(string linkText, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElement(By.LinkText(linkText))).Selected;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetSelectedFromElementsByLinkText
        public List<bool> GetSelectedFromElementsByLinkText(string linkText)
        {
            try
            {
                var selectedList = new List<bool>();
                var webElements = _remoteWebDriver.FindElements(By.LinkText(linkText));
                foreach (var webElement in webElements)
                {
                    selectedList.Add(webElement.Selected);
                }
                return selectedList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<bool> GetSelectedFromElementsByLinkText(string linkText, int timeOutInSeconds)
        {
            try
            {
                var selectedList = new List<bool>();
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                var webElements = webDriverWait.Until(d => d.FindElements(By.LinkText(linkText)));
                foreach (var webElement in webElements)
                {
                    selectedList.Add(webElement.Selected);
                }
                return selectedList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetSelectedFromElementByName
        public bool GetSelectedFromElementByName(string name)
        {
            try
            {
                return _remoteWebDriver.FindElement(By.Name(name)).Selected;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public bool GetSelectedFromElementByName(string name, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElement(By.Name(name))).Selected;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetSelectedFromElementsByName
        public List<bool> GetSelectedFromElementsByName(string name)
        {
            try
            {
                var selectedList = new List<bool>();
                var webElements = _remoteWebDriver.FindElements(By.Name(name));
                foreach (var webElement in webElements)
                {
                    selectedList.Add(webElement.Selected);
                }
                return selectedList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<bool> GetSelectedFromElementsByName(string name, int timeOutInSeconds)
        {
            try
            {
                var selectedList = new List<bool>();
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                var webElements = webDriverWait.Until(d => d.FindElements(By.Name(name)));
                foreach (var webElement in webElements)
                {
                    selectedList.Add(webElement.Selected);
                }
                return selectedList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetSelectedFromElementByTagName
        public bool GetSelectedFromElementByTagName(string tagName)
        {
            try
            {
                return _remoteWebDriver.FindElement(By.TagName(tagName)).Selected;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public bool GetSelectedFromElementByTagName(string tagName, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElement(By.TagName(tagName))).Selected;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetSelectedFromElementsByTagName
        public List<bool> GetSelectedFromElementsByTagName(string tagName)
        {
            try
            {
                var selectedList = new List<bool>();
                var webElements = _remoteWebDriver.FindElements(By.TagName(tagName));
                foreach (var webElement in webElements)
                {
                    selectedList.Add(webElement.Selected);
                }
                return selectedList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<bool> GetSelectedFromElementsByTagName(string tagName, int timeOutInSeconds)
        {
            try
            {
                var selectedList = new List<bool>();
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                var webElements = webDriverWait.Until(d => d.FindElements(By.TagName(tagName)));
                foreach (var webElement in webElements)
                {
                    selectedList.Add(webElement.Selected);
                }
                return selectedList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetSelectedFromElementByXPath
        public bool GetSelectedFromElementByXPath(string xPath)
        {
            try
            {
                return _remoteWebDriver.FindElement(By.XPath(xPath)).Selected;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public bool GetSelectedFromElementByXPath(string xPath, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElement(By.XPath(xPath))).Selected;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetSelectedFromElementsByXPath
        public List<bool> GetSelectedFromElementsByXPath(string xPath)
        {
            try
            {
                var selectedList = new List<bool>();
                var webElements = _remoteWebDriver.FindElements(By.XPath(xPath));
                foreach (var webElement in webElements)
                {
                    selectedList.Add(webElement.Selected);
                }
                return selectedList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<bool> GetSelectedFromElementsByXPath(string xPath, int timeOutInSeconds)
        {
            try
            {
                var selectedList = new List<bool>();
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                var webElements = webDriverWait.Until(d => d.FindElements(By.XPath(xPath)));
                foreach (var webElement in webElements)
                {
                    selectedList.Add(webElement.Selected);
                }
                return selectedList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }
    }
}
