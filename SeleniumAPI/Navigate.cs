using System;
using NUnit.Framework;
using OpenQA.Selenium.Remote;

namespace SeleniumAPI
{

    public class Navigate
    {
        private readonly RemoteWebDriver _remoteWebDriver;

        //Constructor
        public Navigate(RemoteWebDriver remoteWebDriver)
        {
            _remoteWebDriver = remoteWebDriver;
        }

        //GoToUrl
        public void GoToUrl(string url)
        {
            try
            {
                _remoteWebDriver.Navigate().GoToUrl(url);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        //Refresh
        public void Refresh()
        {
            try
            {
                _remoteWebDriver.Navigate().Refresh();
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        //Forward
        public void Forward()
        {
            try
            {
                _remoteWebDriver.Navigate().Forward();
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        //Back
        public void Back()
        {
            try
            {
                _remoteWebDriver.Navigate().Back();
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}