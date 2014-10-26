using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;

namespace AmazonUIBuyer.Pages
{
    public class ShippingOptionPage: BasePage
    {
        private const string SheepingSpeedOptionFreeId = "order_0_ShippingSpeed_sss-us";
        private const string ContinueButtonCssSelector = "input[value='Continue']";

       // private IWebDriver _driver;

        public ShippingOptionPage(IWebDriver driver)
            : base(driver)
        {
            this._driver = driver;

            //if (driver.Title != "")
               // throw new NoSuchWindowException("This is not the Home page");
        }

        //options can vary!!!!
        public IWebElement SheepingSpeedOptionFree
        {
            get
            {
                return WaitFindElement(By.Id(SheepingSpeedOptionFreeId));
            }
        }

        public IWebElement ContinueButton
        {
            get
            {
                return _driver.FindElements(By.CssSelector(ContinueButtonCssSelector)).First();
            }
        }

        public PaymentMethodPage SelectShippingOption(string option)
        {
            //ToDO: choosing option - 
            //find var options =page.FindElements(By.CssSelector("div.ship-speed div.description");
            //enum with shippping option
            //add enum parser
            //options.SingleOrDefault(a=>a.Text.Equals(option.toEnum())
            //find neccessary checkboox
            //click these checkbox

            //SheepingSpeedOptionFree.Click();
            ContinueButton.Click();
            return new PaymentMethodPage(_driver);
        }

    }
}
