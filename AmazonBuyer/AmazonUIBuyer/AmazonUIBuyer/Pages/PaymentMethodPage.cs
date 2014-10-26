using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using AmazonUIBuyer.ObjectHelpers;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace AmazonUIBuyer.Pages
{
    public class PaymentMethodPage:BasePage
    {

        private const string PaymentMethodFirstOptionId = "pm_0";
        private const string ContinueButtonCssSelector = "input[value='Continue']";
        private const string CreditCardNumberFieldId="addCreditCardNumber";
        private const string ConfirmCardButtonId="confirm-card";
        private const string AddNewCreditCardExpanderCssSelector = "a[data-expander-content='new-cc']";


        private const string NewCreditCardNameFieldId = "ccName";
        private const string NewCreditCardNumberFieldId = "addCreditCardNumber";

        private const string NewCreditCardExpMonthDropDownExpanderXpath = "//*[@id='ccMonth']/..//button";
        private const string NewCreditCardExpYearDropDownExpanderXpath = "//*[@id='ccYear']/..//button";

        private const string NewCreditCardExpMonthDropDownSearchString = "//ul[@id='1_dropdown_combobox']//a[@data-value='{0}']";
        private const string NewCreditCardExpYearDropDownSearchString = "//ul[@id='2_dropdown_combobox']//a[@data-value='{0}']";


        private const string AddNewCreditCardButtonId = "ccAddCard";

        //private IWebDriver _driver;

        public PaymentMethodPage(IWebDriver driver)
            : base(driver)
        {
            this._driver = driver;

            //if (driver.Title != "")
               // throw new NoSuchWindowException("This is not the Home page");
        }

        public IWebElement PaymentMethodFirstOption
        {
            get
            {
                return WaitFindElement(By.Id(PaymentMethodFirstOptionId));
            }
        }

        public IWebElement ContinueButton
        {
            get
            {
                return _driver.FindElements(By.CssSelector(ContinueButtonCssSelector)).First();
            }
        }

        public IWebElement ConfirmCardButton
        {
            get
            {
                return WaitFindElement(By.Id(ConfirmCardButtonId));
            }
        }

        public IWebElement CreditCardNumberField
        {
            get
            {
                return WaitFindElement(By.Id(CreditCardNumberFieldId));
            }
        }

        public IWebElement NewCreditCardExpander
        {
            get
            {
                return WaitFindElement(By.CssSelector(AddNewCreditCardExpanderCssSelector));
            }
        }

        public IWebElement NewCreditCardNameField
        {
            get
            {
                return WaitFindElement(By.Id(NewCreditCardNameFieldId));
            }
        }

        public IWebElement NewCreditCardNumberField
        {
            get
            {
                return WaitFindElement(By.Id(NewCreditCardNumberFieldId));
            }
        }

        public IWebElement NewCreditCardExpMonthDropDownExpander
        {
            get
            {
                return WaitFindElement(By.XPath(NewCreditCardExpMonthDropDownExpanderXpath));
            }
        }

        public IWebElement NewCreditCardExpYearDropDownExpander
        {
            get
            {
                return WaitFindElement(By.XPath(NewCreditCardExpYearDropDownExpanderXpath));
            }
        }

        public IWebElement AddNewCreditCardButton
        {
            get
            {
                return WaitFindElement(By.Id(AddNewCreditCardButtonId));
            }
        }

        public IWebElement NewCreditCardExpYearDropDown(string yearValue)
        {
            string elementIdentifier = String.Format(NewCreditCardExpYearDropDownSearchString, yearValue);
            return WaitFindElement(By.XPath(elementIdentifier));
        }

        public IWebElement NewCreditCardExpMonthDropDown(string monthValue)
        {
            string elementIdentifier = String.Format(NewCreditCardExpMonthDropDownSearchString, monthValue);
            return WaitFindElement(By.XPath(elementIdentifier));
        }

        public PlaceOrderPage ProvideCardInformation(string cardName, string cardNumber, string expMonth, string expYear)
        {

            //PaymentMethodFirstOption.Click();
            //CreditCardNumberField.Clear();
            //CreditCardNumberField.SendKeys(cardNumber);
            //ConfirmCardButton.Click();
            //ObjectWaiter ObjectWaiter = new ObjectWaiter();
            //ObjectWaiter.WaitGetElement()
            //ContinueButton.Click();
            //return new SelectShippingAddress(_driver);

            NewCreditCardExpander.Click();

            NewCreditCardNameField.Clear();
            NewCreditCardNameField.SendKeys(cardName);

            NewCreditCardNumberField.Clear();
            NewCreditCardNumberField.SendKeys(cardNumber);

            //!!!!!!!DELETE!!!!!!!!!
            Thread.Sleep(5000);

            NewCreditCardExpMonthDropDownExpander.Click();
            NewCreditCardExpMonthDropDown(expMonth).Click();

            //!!!!!!!DELETE!!!!!!!!!
            Thread.Sleep(5000);

            NewCreditCardExpYearDropDownExpander.Click();
            NewCreditCardExpYearDropDown(expYear).Click();

            AddNewCreditCardButton.Click();

            //!!!!!!!DELETE!!!!!!!!!
            Thread.Sleep(5000);

            ContinueButton.Click();
            return new PlaceOrderPage(_driver);
        }
    }
}
