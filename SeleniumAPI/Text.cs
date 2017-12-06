using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace SeleniumAPI
{
    public class Text
    {
        private readonly RemoteWebDriver _remoteWebDriver;

        //Constructor
        public Text(RemoteWebDriver remoteWebDriver)
        {
            _remoteWebDriver = remoteWebDriver;
        }

        //GetTextFromElement
        public string GetTextFromElement(IWebElement webElement)
        {
            try
            {
                return webElement.Text;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetTextFromElements
        public List<string> GetTextFromElements(ReadOnlyCollection<IWebElement> webElements)
        {
            try
            {
                var textList = new List<string>();
                foreach (var webElement in webElements)
                {
                    textList.Add(webElement.Text);
                }
                return textList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetTextFromElementByClassName
        public string GetTextFromElementByClassName(string className)
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

        public string GetTextFromElementByClassName(string className, int timeOutInSeconds)
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

        //GetTextFromElementsByClassName
        public List<string> GetTextFromElementsByClassName(string className)
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

        public List<string> GetTextFromElementsByClassName(string className, int timeOutInSeconds)
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

        //GetTextFromElementByCssSelector
        public string GetTextFromElementByCssSelector(string cssSelector)
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

        public string GetTextFromElementByCssSelector(string cssSelector, int timeOutInSeconds)
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

        //GetTextFromElementsByCssSelector
        public List<string> GetTextFromElementsByCssSelector(string cssSelector)
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

        public List<string> GetTextFromElementsByCssSelector(string cssSelector, int timeOutInSeconds)
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

        //GetTextFromElementById
        public string GetTextFromElementById(string id)
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

        public string GetTextFromElementById(string id, int timeOutInSeconds)
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

        //GetTextFromElementsById
        public List<string> GetTextFromElementsById(string id)
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

        public List<string> GetTextFromElementsById(string id, int timeOutInSeconds)
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

        //GetTextFromElementByLinkText
        public string GetTextFromElementByLinkText(string linkText)
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

        public string GetTextFromElementByLinkText(string linkText, int timeOutInSeconds)
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

        //GetTextFromElementsByLinkText
        public List<string> GetTextFromElementsByLinkText(string linkText)
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

        public List<string> GetTextFromElementsByLinkText(string linkText, int timeOutInSeconds)
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

        //GetTextFromElementByName
        public string GetTextFromElementByName(string name)
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

        public string GetTextFromElementByName(string name, int timeOutInSeconds)
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

        //GetTextFromElementsByName
        public List<string> GetTextFromElementsByName(string name)
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

        public List<string> GetTextFromElementsByName(string name, int timeOutInSeconds)
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

        //GetTextFromElementByTagName
        public string GetTextFromElementByTagName(string tagName)
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

        public string GetTextFromElementByTagName(string tagName, int timeOutInSeconds)
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

        //GetTextFromElementsByTagName
        public List<string> GetTextFromElementsByTagName(string tagName)
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

        public List<string> GetTextFromElementsByTagName(string tagName, int timeOutInSeconds)
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

        //GetTextFromElementByXPath
        public string GetTextFromElementByXPath(string xPath)
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

        public string GetTextFromElementByXPath(string xPath, int timeOutInSeconds)
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

        //GetTextFromElementsByXPath
        public List<string> GetTextFromElementsByXPath(string xPath)
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

        public List<string> GetTextFromElementsByXPath(string xPath, int timeOutInSeconds)
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