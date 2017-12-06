using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace SeleniumAPI
{
    public class CssValue
    {
        private readonly RemoteWebDriver _remoteWebDriver;

        //Constructor
        public CssValue(RemoteWebDriver remoteWebDriver)
        {
            _remoteWebDriver = remoteWebDriver;
        }

        //GetCssValueOfElement
        public string GetCssValueOfElement(IWebElement webElement, string cssPropertyName)
        {
            try
            {
                return webElement.GetCssValue(cssPropertyName);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetCssValuesOfElements
        public List<string> GetCssValuesOfElements(ReadOnlyCollection<IWebElement> webElements, string cssPropertyName)
        {
            try
            {
                var cssValueList = new List<string>();
                foreach (var webElement in webElements)
                {
                    cssValueList.Add(webElement.GetCssValue(cssPropertyName));
                }
                return cssValueList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetCssValueOfElementByClassName
        public string GetCssValueOfElementByClassName(string className, string cssPropertyName)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public string GetCssValueOfElementByClassName(string className, string cssPropertyName, int timeOutInSeconds)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetCssValueOfElementsByClassName
        public List<string> GetCssValueOfElementsByClassName(string className, string cssPropertyName)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<string> GetCssValueOfElementsByClassName(string className, string cssPropertyName, int timeOutInSeconds)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetCssValueOfElementByCssSelector
        public string GetCssValueOfElementByCssSelector(string cssSelector, string cssPropertyName)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public string GetCssValueOfElementByCssSelector(string cssSelector, string cssPropertyName, int timeOutInSeconds)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetCssValueOfElementsByCssSelector
        public List<string> GetCssValueOfElementsByCssSelector(string cssSelector, string cssPropertyName)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<string> GetCssValueOfElementsByCssSelector(string cssSelector, string cssPropertyName, int timeOutInSeconds)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetCssValueOfElementById
        public string GetCssValueOfElementById(string id, string cssPropertyName)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public string GetCssValueOfElementById(string id, string cssPropertyName, int timeOutInSeconds)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetCssValueOfElementsById
        public List<string> GetCssValueOfElementsById(string id, string cssPropertyName)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<string> GetCssValueOfElementsById(string id, string cssPropertyName, int timeOutInSeconds)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetCssValueOfElementByLinkText
        public string GetCssValueOfElementByLinkText(string linkText, string cssPropertyName)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public string GetCssValueOfElementByLinkText(string linkText, string cssPropertyName, int timeOutInSeconds)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetCssValueOfElementsByLinkText
        public List<string> GetCssValueOfElementsByLinkText(string linkText, string cssPropertyName)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<string> GetCssValueOfElementsByLinkText(string linkText, string cssPropertyName, int timeOutInSeconds)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetCssValueOfElementByName
        public string GetCssValueOfElementByName(string name, string cssPropertyName)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public string GetCssValueOfElementByName(string name, string cssPropertyName, int timeOutInSeconds)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetCssValueOfElementsByName
        public List<string> GetCssValueOfElementsByName(string name, string cssPropertyName)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<string> GetCssValueOfElementsByName(string name, string cssPropertyName, int timeOutInSeconds)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetCssValueOfElementByTagName
        public string GetCssValueOfElementByTagName(string tagName, string cssPropertyName)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public string GetCssValueOfElementByTagName(string tagName, string cssPropertyName, int timeOutInSeconds)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetCssValueOfElementsByTagName
        public List<string> GetCssValueOfElementsByTagName(string tagName, string cssPropertyName)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<string> GetCssValueOfElementsByTagName(string tagName, string cssPropertyName, int timeOutInSeconds)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetCssValueOfElementByXPath
        public string GetCssValueOfElementByXPath(string xPath, string cssPropertyName)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public string GetCssValueOfElementByXPath(string xPath, string cssPropertyName, int timeOutInSeconds)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetCssValueOfElementsByXPath
        public List<string> GetCssValueOfElementsByXPath(string xPath, string cssPropertyName)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<string> GetCssValueOfElementsByXPath(string xPath, string cssPropertyName, int timeOutInSeconds)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }
    }
}