using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;

namespace AmazonUIBuyer.Pages
{
    public class ShoppingCartPage: BasePage
    {
        private const string ProceedToChekoutButtonNameCssSelector = "input[name='proceedToCheckout']";
        //private IWebDriver _driver;

        public ShoppingCartPage(IWebDriver driver)
            : base(driver)
        {
            this._driver = driver;

            //if (driver.Title != "")
               // throw new NoSuchWindowException("This is not the Home page");
        }


        public IWebElement ProceedToChekoutButton
        {
            get
            {
                return WaitFindElement(By.CssSelector(ProceedToChekoutButtonNameCssSelector));
            }
        }

        public SignInPage OpenSignInPage()
        {
            //TODO: use basepage clickbutton 
            ProceedToChekoutButton.Click();
            return new SignInPage(_driver);
        }
    }
}
