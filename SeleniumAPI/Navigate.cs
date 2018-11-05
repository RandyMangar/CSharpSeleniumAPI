using System;
using NUnit.Framework;
using OpenQA.Selenium.Remote;

namespace SeleniumAPI
{
    //Version 1.0
    public class Navigate
    {
        private readonly RemoteWebDriver _remoteWebDriver;

        public Navigate(RemoteWebDriver remoteWebDriver)
        {
            _remoteWebDriver = remoteWebDriver;
        }

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