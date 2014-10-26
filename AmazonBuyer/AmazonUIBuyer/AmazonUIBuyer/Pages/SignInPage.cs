using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;

namespace AmazonUIBuyer.Pages
{
    public class SignInPage: BasePage
    {
        private const string EmailAddressFieldId = "ap_email";
        private const string UserPasswordFieldId = "ap_password";
        private const string SignInButtonId = "signInSubmit-input";

        //private IWebDriver _driver;

        public SignInPage(IWebDriver driver)
            : base(driver)
        {
            this._driver = driver;

            //if (driver.Title != "")
               // throw new NoSuchWindowException("This is not the Home page");
        }


        public IWebElement EmailAddressField
        {
            get
            {
                return WaitFindElement(By.Id(EmailAddressFieldId));
            }
        }

        public IWebElement UserPasswordField
        {
            get
            {
                return WaitFindElement(By.Id(UserPasswordFieldId));
            }
        }

        public IWebElement SignInButton
        {
            get
            {
                return WaitFindElement(By.Id(SignInButtonId));
            }
        }

        public SelectShippingAddress OpenShippingAddressPageWithCredentials(string email, string password)
        {
            EmailAddressField.Clear();
            EmailAddressField.SendKeys(email);

            UserPasswordField.Clear();
            UserPasswordField.SendKeys(password);

            //TODO: use basepage clickbutton 
            SignInButton.Click();
            return new SelectShippingAddress(_driver);
        }

    }
}
