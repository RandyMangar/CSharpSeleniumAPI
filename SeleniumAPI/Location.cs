using System;
using System.Collections.Generic;
using System.Drawing;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

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


        //ClassName


        //ListClassName


        //CssSelector


        //ListCssSelector


        //Id


        //ListId


        //LinkText


        //ListLinkText


        //Name


        //ListName


        //TagName


        //ListTagName


        //XPath


        //ListXPath

    }
}
