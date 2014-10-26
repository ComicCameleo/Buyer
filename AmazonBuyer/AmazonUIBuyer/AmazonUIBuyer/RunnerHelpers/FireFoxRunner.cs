using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AmazonUIBuyer.RunnerHelpers
{
    public class FireFoxRunner: BaseBrowserRunner
    {

        private IWebDriver _webDriver;

        public override IWebDriver startWebDriver()
        {
            //var firefoxProfile = new FirefoxProfile
            //{
            //    AcceptUntrustedCertificates = true,
            //    EnableNativeEvents = true
            //};

            //_webDriver = new FirefoxDriver(firefoxProfile);
            _webDriver = new ChromeDriver(@".");
            _webDriver.Manage().Window.Maximize();
            return _webDriver;
        }

        public override void finishWebDriver()
        {
            if (_webDriver == null) return;

            _webDriver.Quit();
            _webDriver = null;
        }

        public override void Navigate(string url)
        {
            _webDriver.Navigate().GoToUrl(url);
        }

        public override void SetCookie(string name, string value, DateTime expiryDate)
        {
            var cookie = new Cookie(name, value, "/", expiryDate.ToUniversalTime());
            _webDriver.Manage().Cookies.AddCookie(cookie);
        }

        public override void DeleteCookie(string name)
        {
            _webDriver.Manage().Cookies.DeleteCookieNamed(name);
        }
    }
}
