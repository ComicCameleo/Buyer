using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;

namespace AmazonUIBuyer.Pages
{
    public class ConfirmAddToCartStartPage: BasePage
    {

        private const string ContinueButtonCssSelector="input[name='add']";
        //private IWebDriver _driver;

        public ConfirmAddToCartStartPage(IWebDriver driver): base(driver)
        {
            this._driver = driver;

            //if (driver.Title != "")
               // throw new NoSuchWindowException("This is not the Home page");
        }


        public IWebElement ContinueButton
        {
            get
            {
                return WaitFindElement(By.CssSelector(ContinueButtonCssSelector));
            }
        }

        public ShoppingCartPage OpenShoppingCartPage()
        {
            ContinueButton.Click();
            return new ShoppingCartPage(_driver);
        }
    }
}
