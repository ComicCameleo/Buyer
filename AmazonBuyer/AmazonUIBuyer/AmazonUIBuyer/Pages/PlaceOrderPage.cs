using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;

namespace AmazonUIBuyer.Pages
{
    public class PlaceOrderPage: BasePage
    {
        private const string PlaceOrderButtonCssSelector = "input[name='placeYourOrder1']";
        //private IWebDriver _driver;

        public PlaceOrderPage(IWebDriver driver)
            : base(driver)
        {
            this._driver = driver;

            //if (driver.Title != "")
               // throw new NoSuchWindowException("This is not the Home page");
        }


        public IWebElement PlaceOrderButton
        {
            get
            {
                return WaitFindElement(By.CssSelector(PlaceOrderButtonCssSelector));
            }
        }

        public void PlaceOrder()
        {
            //TODO: use basepage clickbutton 
            PlaceOrderButton.Click();
           
        }
    }
}
