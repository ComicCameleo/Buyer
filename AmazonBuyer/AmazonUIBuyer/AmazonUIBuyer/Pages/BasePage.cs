using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AmazonUIBuyer.Pages
{
    public abstract class BasePage
    {
        protected IWebDriver _driver;

        public BasePage(IWebDriver driver)
        {
            this._driver = driver;
        }


        protected void TypeTextValue(IWebElement webElement, String text)
        {
            webElement.Clear();
            webElement.SendKeys(text);
        }

        protected void clickButton(IWebElement webElement)
        {
            if (webElement.Displayed)
            {
                webElement.Click();
            }
            else
            {
                throw new ArgumentException("Requested button not shown");
            
            }
        }

        protected IWebElement WaitFindElement(By by, int timeoutInSeconds=5)
        {
            if (timeoutInSeconds > 0)
            {
                var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(timeoutInSeconds));
                return wait.Until(drv => drv.FindElement(by));
            }
            return _driver.FindElement(by);
        }
    }
}
