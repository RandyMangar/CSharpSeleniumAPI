using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace SeleniumAPI
{
    public class Visibility
    {
        private readonly RemoteWebDriver _remoteWebDriver;

        //Constructor
        public Visibility(RemoteWebDriver remoteWebDriver)
        {
            _remoteWebDriver = remoteWebDriver;
        }

        //GetVisibilityOfElement
        public bool GetVisibilityOfElement(IWebElement webElement)
        {
            try
            {
                return webElement.Displayed;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetVisibilityOfElements
        public List<bool> GetVisibilityOfElements(ReadOnlyCollection<IWebElement> webElements)
        {
            try
            {
                var visibilityList = new List<bool>();
                foreach (var webElement in webElements)
                {
                    visibilityList.Add(webElement.Displayed);
                }
                return visibilityList;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetVisibilityOfElementByClassName
        public bool GetVisibilityOfElementByClassName(string className)
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

        public bool GetVisibilityOfElementByClassName(string className, int timeOutInSeconds)
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

        //GetVisibilityOfElementsByClassName
        public List<bool> GetVisibilityOfElementsByClassName(string className)
        {
            try
            {
                var visibilityList = new List<bool>();

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<bool> GetVisibilityOfElementsByClassName(string className, int timeOutInSeconds)
        {
            try
            {
                var visibilityList = new List<bool>();

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetVisibilityOfElementByCssSelector
        public bool GetVisibilityOfElementByCssSelector(string cssSelector)
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

        public bool GetVisibilityOfElementByCssSelector(string cssSelector, int timeOutInSeconds)
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

        //GetVisibilityOfElementsByCssSelector
        public List<bool> GetVisibilityOfElementsByCssSelector(string cssSelector)
        {
            try
            {
                var visibilityList = new List<bool>();

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<bool> GetVisibilityOfElementsByCssSelector(string cssSelector, int timeOutInSeconds)
        {
            try
            {
                var visibilityList = new List<bool>();

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetVisibilityOfElementById
        public bool GetVisibilityOfElementById(string id)
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

        public bool GetVisibilityOfElementById(string id, int timeOutInSeconds)
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

        //GetVisibilityOfElementsById
        public List<bool> GetVisibilityOfElementsById(string id)
        {
            try
            {
                var visibilityList = new List<bool>();

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<bool> GetVisibilityOfElementsById(string id, int timeOutInSeconds)
        {
            try
            {
                var visibilityList = new List<bool>();

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetVisibilityOfElementByLinkText
        public bool GetVisibilityOfElementByLinkText(string linkText)
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

        public bool GetVisibilityOfElementByLinkText(string linkText, int timeOutInSeconds)
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

        //GetVisibilityOfElementsByLinkText
        public List<bool> GetVisibilityOfElementsByLinkText(string linkText)
        {
            try
            {
                var visibilityList = new List<bool>();

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<bool> GetVisibilityOfElementsByLinkText(string linkText, int timeOutInSeconds)
        {
            try
            {
                var visibilityList = new List<bool>();

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetVisibilityOfElementByName
        public bool GetVisibilityOfElementByName(string name)
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

        public bool GetVisibilityOfElementByName(string name, int timeOutInSeconds)
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

        //GetVisibilityOfElementsByName
        public List<bool> GetVisibilityOfElementsByName(string name)
        {
            try
            {
                var visibilityList = new List<bool>();

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<bool> GetVisibilityOfElementsByName(string name, int timeOutInSeconds)
        {
            try
            {
                var visibilityList = new List<bool>();

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetVisibilityOfElementByTagName
        public bool GetVisibilityOfElementByTagName(string tagName)
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

        public bool GetVisibilityOfElementByTagName(string tagName, int timeOutInSeconds)
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

        //GetVisibilityOfElementsByTagName
        public List<bool> GetVisibilityOfElementsByTagName(string tagName)
        {
            try
            {
                var visibilityList = new List<bool>();

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<bool> GetVisibilityOfElementsByTagName(string tagName, int timeOutInSeconds)
        {
            try
            {
                var visibilityList = new List<bool>();

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        //GetVisibilityOfElementByXPath
        public bool GetVisibilityOfElementByXPath(string xPath)
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

        public bool GetVisibilityOfElementByXPath(string xPath, int timeOutInSeconds)
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

        //GetVisibilityOfElementsByXPath
        public List<bool> GetVisibilityOfElementsByXPath(string xPath)
        {
            try
            {
                var visibilityList = new List<bool>();

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }

        public List<bool> GetVisibilityOfElementsByXPath(string xPath, int timeOutInSeconds)
        {
            try
            {
                var visibilityList = new List<bool>();

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                throw;
            }
        }
    }
}