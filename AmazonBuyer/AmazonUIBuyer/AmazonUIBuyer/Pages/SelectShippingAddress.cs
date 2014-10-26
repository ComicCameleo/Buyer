using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AmazonUIBuyer.Pages
{
    public class SelectShippingAddress: BasePage
    {
        private const string FullNameFieldId = "enterAddressFullName";
        private const string AddressLineFirstFieldId = "enterAddressAddressLine1";
        private const string AddressLineSecondFieldId = "enterAddressAddressLine2";
        private const string CityFieldId = "enterAddressCity";
        private const string StateProvinceRegionFieldId = "enterAddressStateOrRegion";
        private const string ZIPFieldId = "enterAddressPostalCode";
        private const string CountryDropDownId = "enterAddressCountryCode";
        private const string PhoneNumberFieldId = "enterAddressPhoneNumber";
        private const string WeekendDeliveryFieldId = "AddressType";
        private const string SecurityAccessCodeFieldId = "GateCode";

        private const string ShipTothisAdressButtonCssSelector = "input[name='shipToThisAddress']";

        //private IWebDriver _driver;

        public SelectShippingAddress(IWebDriver driver)
            : base(driver)
        {
            this._driver = driver;

            //if (driver.Title != "")
               // throw new NoSuchWindowException("This is not the Home page");
        }


        public IWebElement FullNameField
        {
            get
            {
                return WaitFindElement(By.Id(FullNameFieldId));
            }
        }
        public IWebElement AddressLineFirstField
        {
            get
            {
                return WaitFindElement(By.Id(AddressLineFirstFieldId));
            }
        }
        public IWebElement AddressLineSecondField
        {
            get
            {
                return WaitFindElement(By.Id(AddressLineSecondFieldId));
            }
        }
        public IWebElement CityField
        {
            get
            {
                return WaitFindElement(By.Id(CityFieldId));
            }
        }
        public IWebElement StateProvinceRegionField
        {
            get
            {
                return WaitFindElement(By.Id(StateProvinceRegionFieldId));
            }
        }
        public IWebElement ZIPField
        {
            get
            {
                return WaitFindElement(By.Id(ZIPFieldId));
            }
        }
        public IWebElement Country
        {
            get
            {
                return WaitFindElement(By.Id(CountryDropDownId));
            }
        }
        public IWebElement PhoneNumberField
        {
            get
            {
                return WaitFindElement(By.Id(PhoneNumberFieldId));
            }
        }
        public IWebElement WeekendDelivery
        {
            get
            {
                return WaitFindElement(By.Id(WeekendDeliveryFieldId));
            }
        }
        public IWebElement SecurityAccessCodeField
        {
            get
            {
                return WaitFindElement(By.Id(SecurityAccessCodeFieldId));
            }
        }

        public IWebElement ShipTothisAdressButton
        {
            get
            {
                return WaitFindElement(By.CssSelector(ShipTothisAdressButtonCssSelector));
            }
        }

        public ShippingOptionPage CreateShippingAddress(ShippingAddressInfo shippingAddressInfo)
        {
            FullNameField.Clear();
            FullNameField.SendKeys(shippingAddressInfo.FullName);

            AddressLineFirstField.Clear();
            AddressLineFirstField.SendKeys(shippingAddressInfo.AddressLineFirst);

            AddressLineSecondField.Clear();
            AddressLineSecondField.SendKeys(shippingAddressInfo.AddressLineSecond);

            CityField.Clear();
            CityField.SendKeys(shippingAddressInfo.City);

            StateProvinceRegionField.Clear();
            StateProvinceRegionField.SendKeys(shippingAddressInfo.StateProvinceRegion);

            ZIPField.Clear();
            ZIPField.SendKeys(shippingAddressInfo.ZIP);

            SelectElement CountryDropDown = new SelectElement(Country);
            CountryDropDown.SelectByText(shippingAddressInfo.Country);

            PhoneNumberField.Clear();
            PhoneNumberField.SendKeys(shippingAddressInfo.PhoneNumber);

            //SelectElement WeekendDeliveryDropDown = new SelectElement(WeekendDelivery);
            //WeekendDeliveryDropDown.SelectByText(shippingAddressInfo.WeekendDelivery);

            SecurityAccessCodeField.Clear();
            SecurityAccessCodeField.SendKeys(shippingAddressInfo.SecurityAccessCode);

            ShipTothisAdressButton.Click();
            return new ShippingOptionPage(_driver);
        }

        public class ShippingAddressInfo
        {
            public string FullName { get; set; }
            public string AddressLineFirst { get; set; }
            public string AddressLineSecond { get; set; }
            public string City { get; set; }
            public string StateProvinceRegion { get; set; }
            public string ZIP { get; set; }
            public string Country { get; set; }
            public string PhoneNumber { get; set; }
            public string WeekendDelivery { get; set; }
            public string SecurityAccessCode { get; set; }
        }

    }
}
