using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace SeleniumAPI
{

    public class Attribute
    {
        private readonly RemoteWebDriver _remoteWebDriver;

        //Constructor
        public Attribute(RemoteWebDriver remoteWebDriver)
        {
            _remoteWebDriver = remoteWebDriver;

        }

        //GetAttributeFromElement
        public string GetAttributeFromElement(IWebElement webElement, string attribute)
        {
            try
            {
                return webElement.GetAttribute(attribute);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        //GetAttributeFromElements
        public List<string> GetAttributeFromElements(ReadOnlyCollection<IWebElement> webElements, string attribute)
        {
            try
            {
                var attributeValues = new List<string>();
                foreach (var webElement in webElements)
                {
                    attributeValues.Add(webElement.GetAttribute(attribute));

                }
                return attributeValues;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        //GetAttributeFromElementByClassName
        public string GetAttributeFromElementByClassName()
        {
            try
            {

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        public string GetAttributeFromElementByClassName()
        {
            try
            {

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        //GetAttributeFromElementsByClassName
        public List<string> GetAttributeFromElementsByClassName()
        {
            try
            {

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        public List<string> GetAttributeFromElementsByClassName()
        {
            try
            {

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        //GetAttributeFromElementByCssSelector
        public string GetAttributeFromElementByCssSelector()
        {
            try
            {

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        public string GetAttributeFromElementByCssSelector()
        {
            try
            {

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        //GetAttributeFromElementsByCssSelector
        public List<string> GetAttributeFromElementsByCssSelector()
        {
            try
            {

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        public List<string> GetAttributeFromElementsByCssSelector()
        {
            try
            {

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        //GetAttributeFromElementById
        public string GetAttributeFromElementById()
        {
            try
            {

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        public string GetAttributeFromElementById()
        {
            try
            {

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        //GetAttributeFromElementsById
        public List<string> GetAttributeFromElementsById()
        {
            try
            {

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        public List<string> GetAttributeFromElementsById()
        {
            try
            {

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        //GetAttributeFromElementByLinkText
        public string GetAttributeFromElementByLinkText()
        {
            try
            {

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        public string GetAttributeFromElementByLinkText()
        {
            try
            {

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        //GetAttributeFromElementsByLinkText
        public List<string> GetAttributeFromElementsByLinkText()
        {
            try
            {

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        public List<string> GetAttributeFromElementsByLinkText()
        {
            try
            {

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        //GetAttributeFromElementByName
        public string GetAttributeFromElementByName()
        {
            try
            {

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        public string GetAttributeFromElementByName()
        {
            try
            {

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        //GetAttributeFromElementsByName
        public List<string> GetAttributeFromElementsByName()
        {
            try
            {

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        public List<string> GetAttributeFromElementsByName()
        {
            try
            {

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        //GetAttributeFromElementByTagName
        public string GetAttributeFromElementByTagName()
        {
            try
            {

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        public string GetAttributeFromElementByTagName()
        {
            try
            {

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        //GetAttributeFromElementsByTagName
        public List<string> GetAttributeFromElementsByTagName()
        {
            try
            {

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        public List<string> GetAttributeFromElementsByTagName()
        {
            try
            {

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        //GetAttributeFromElementByXPath
        public string GetAttributeFromElementByXPath()
        {
            try
            {

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        public string GetAttributeFromElementByXPath()
        {
            try
            {

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        //GetAttributeFromElementsByXPath
        public List<string> GetAttributeFromElementsByXPath()
        {
            try
            {

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        public List<string> GetAttributeFromElementsByXPath()
        {
            try
            {

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}

