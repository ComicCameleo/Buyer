using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;

namespace AmazonUIBuyer.RunnerHelpers
{
    public abstract class BaseBrowserRunner
    {
        public abstract IWebDriver startWebDriver();
        public abstract void finishWebDriver();
        public abstract void Navigate(string url);
        public abstract void SetCookie(string name, string value, DateTime expiryDate);
        public abstract void DeleteCookie(string name);
    }
}
