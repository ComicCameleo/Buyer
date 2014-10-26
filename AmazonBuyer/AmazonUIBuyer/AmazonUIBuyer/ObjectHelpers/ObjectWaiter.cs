using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AmazonUIBuyer.ObjectHelpers
{
    public class ObjectWaiter
    {
        public IWebElement WaitGetElement(IWebDriver driver, By by, int timeoutInSeconds, bool checkIsVisible = false)
        {
            IWebElement element;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));

            try
            {
                if (checkIsVisible)
                {
                    element = wait.Until(ExpectedConditions.ElementIsVisible(by));
                }
                else
                {
                    element = wait.Until(ExpectedConditions.ElementExists(by));
                }
            }
            catch (NoSuchElementException) { element = null; }
            catch (WebDriverTimeoutException) { element = null; }
            catch (TimeoutException) { element = null; }

            return element;
        }
    }
}
