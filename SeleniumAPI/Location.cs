using System;
using System.Collections.Generic;
using System.Drawing;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace SeleniumAPI
{
    public class Location
    {
        private readonly RemoteWebDriver _remoteWebDriver;

        //Constructor
        public Location(RemoteWebDriver remoteWebDriver)
        {
            _remoteWebDriver = remoteWebDriver;
        }

        //GetLocationFromElement
        public Point GetLocationFromElement(IWebElement webElement)
        {
            try
            {
                return webElement.Location;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetLocationFromElements
        public List<Point> GetLocationsFromElement(List<IWebElement> webElements)
        {
            try
            {
                var locationList = new List<Point>();
                foreach (var webElement in webElements)
                {
                    locationList.Add(webElement.Location);
                }

                return locationList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }


        //GetLocationFromElementByClassName
        public Point GetLocationFromElementByClassName(string className)
        {
            try
            {
                return _remoteWebDriver.FindElement(By.ClassName(className)).Location;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public Point GetLocationFromElementByClassName(string className, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElement(By.ClassName(className))).Location;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetLocationFromElementsByClassName
        public List<Point> GetLocationFromElementsByClassName(string className)
        {
            try
            {
                var locationList = new List<Point>();
                var webElements = _remoteWebDriver.FindElements(By.ClassName(className));
                foreach (var webElement in webElements)
                {
                    locationList.Add(webElement.Location);
                }
                return locationList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<Point> GetLocationFromElementsByClassName(string className, int timeOutInSeconds)
        {
            try
            {
                var cssValueList = new List<Point>();
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                var webElements = webDriverWait.Until(d => d.FindElements(By.ClassName(className)));
                foreach (var webElement in webElements)
                {
                    cssValueList.Add(webElement.Location);
                }
                return cssValueList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetLocationFromElementByCssSelector
        public Point GetLocationFromElementByCssSelector(string cssSelector)
        {
            try
            {
                return _remoteWebDriver.FindElement(By.CssSelector(cssSelector)).Location;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public Point GetLocationFromElementByCssSelector(string cssSelector, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElement(By.CssSelector(cssSelector))).Location;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetLocationFromElementsByCssSelector
        public List<Point> GetLocationFromElementsByCssSelector(string cssSelector)
        {
            try
            {
                var locationList = new List<Point>();
                var webElements = _remoteWebDriver.FindElements(By.CssSelector(cssSelector));
                foreach (var webElement in webElements)
                {
                    locationList.Add(webElement.Location);
                }
                return locationList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<Point> GetLocationFromElementsByCssSelector(string cssSelector, int timeOutInSeconds)
        {
            try
            {
                var cssValueList = new List<Point>();
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                var webElements = webDriverWait.Until(d => d.FindElements(By.CssSelector(cssSelector)));
                foreach (var webElement in webElements)
                {
                    cssValueList.Add(webElement.Location);
                }
                return cssValueList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetLocationFromElementById
        public Point GetLocationFromElementById(string id)
        {
            try
            {
                return _remoteWebDriver.FindElement(By.Id(id)).Location;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public Point GetLocationFromElementById(string id, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElement(By.Id(id))).Location;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetLocationFromElementsById
        public List<Point> GetLocationFromElementsById(string id)
        {
            try
            {
                var locationList = new List<Point>();
                var webElements = _remoteWebDriver.FindElements(By.Id(id));
                foreach (var webElement in webElements)
                {
                    locationList.Add(webElement.Location);
                }
                return locationList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<Point> GetLocationFromElementsById(string id, int timeOutInSeconds)
        {
            try
            {
                var cssValueList = new List<Point>();
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                var webElements = webDriverWait.Until(d => d.FindElements(By.Id(id)));
                foreach (var webElement in webElements)
                {
                    cssValueList.Add(webElement.Location);
                }
                return cssValueList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetLocationFromElementByLinkText
        public Point GetLocationFromElementByLinkText(string linkText)
        {
            try
            {
                return _remoteWebDriver.FindElement(By.LinkText(linkText)).Location;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public Point GetLocationFromElementByLinkText(string linkText, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElement(By.LinkText(linkText))).Location;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetLocationFromElementsByLinkText
        public List<Point> GetLocationFromElementsByLinkText(string linkText)
        {
            try
            {
                var locationList = new List<Point>();
                var webElements = _remoteWebDriver.FindElements(By.LinkText(linkText));
                foreach (var webElement in webElements)
                {
                    locationList.Add(webElement.Location);
                }
                return locationList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<Point> GetLocationFromElementsByLinkText(string linkText, int timeOutInSeconds)
        {
            try
            {
                var cssValueList = new List<Point>();
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                var webElements = webDriverWait.Until(d => d.FindElements(By.LinkText(linkText)));
                foreach (var webElement in webElements)
                {
                    cssValueList.Add(webElement.Location);
                }
                return cssValueList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetLocationFromElementByName
        public Point GetLocationFromElementByName(string name)
        {
            try
            {
                return _remoteWebDriver.FindElement(By.Name(name)).Location;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public Point GetLocationFromElementByName(string name, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElement(By.Name(name))).Location;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetLocationFromElementsByName
        public List<Point> GetLocationFromElementsByName(string name)
        {
            try
            {
                var locationList = new List<Point>();
                var webElements = _remoteWebDriver.FindElements(By.Name(name));
                foreach (var webElement in webElements)
                {
                    locationList.Add(webElement.Location);
                }
                return locationList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<Point> GetLocationFromElementsByName(string name, int timeOutInSeconds)
        {
            try
            {
                var cssValueList = new List<Point>();
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                var webElements = webDriverWait.Until(d => d.FindElements(By.Name(name)));
                foreach (var webElement in webElements)
                {
                    cssValueList.Add(webElement.Location);
                }
                return cssValueList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetLocationFromElementByTagName
        public Point GetLocationFromElementByTagName(string tagName)
        {
            try
            {
                return _remoteWebDriver.FindElement(By.TagName(tagName)).Location;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public Point GetLocationFromElementByTagName(string tagName, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElement(By.TagName(tagName))).Location;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetLocationFromElementsByTagName
        public List<Point> GetLocationFromElementsByTagName(string tagName)
        {
            try
            {
                var locationList = new List<Point>();
                var webElements = _remoteWebDriver.FindElements(By.TagName(tagName));
                foreach (var webElement in webElements)
                {
                    locationList.Add(webElement.Location);
                }
                return locationList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<Point> GetLocationFromElementsByTagName(string tagName, int timeOutInSeconds)
        {
            try
            {
                var cssValueList = new List<Point>();
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                var webElements = webDriverWait.Until(d => d.FindElements(By.TagName(tagName)));
                foreach (var webElement in webElements)
                {
                    cssValueList.Add(webElement.Location);
                }
                return cssValueList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetLocationFromElementByXPath
        public Point GetLocationFromElementByXPath(string xPath)
        {
            try
            {
                return _remoteWebDriver.FindElement(By.XPath(xPath)).Location;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public Point GetLocationFromElementByXPath(string xPath, int timeOutInSeconds)
        {
            try
            {
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                return webDriverWait.Until(d => d.FindElement(By.XPath(xPath))).Location;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetLocationFromElementsByListXPath
        public List<Point> GetLocationFromElementsByListXPath(string xPath)
        {
            try
            {
                var locationList = new List<Point>();
                var webElements = _remoteWebDriver.FindElements(By.XPath(xPath));
                foreach (var webElement in webElements)
                {
                    locationList.Add(webElement.Location);
                }
                return locationList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<Point> GetLocationFromElementsByListXPath(string xPath, int timeOutInSeconds)
        {
            try
            {
                var cssValueList = new List<Point>();
                var webDriverWait = new WebDriverWait(_remoteWebDriver, TimeSpan.FromSeconds(timeOutInSeconds));
                var webElements = webDriverWait.Until(d => d.FindElements(By.XPath(xPath)));
                foreach (var webElement in webElements)
                {
                    cssValueList.Add(webElement.Location);
                }
                return cssValueList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }
    }
}
