using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using AmazonUIBuyer.RunnerHelpers;
using AmazonUIBuyer.Pages;
using OpenQA.Selenium.Support.PageObjects;
using System.Configuration;

namespace AmazonUIBuyer.Steps
{
    public class AmazonSteps
    {
        //private const string AmazonUrl = "https://www.amazon.com/gp/cart/aws-merge.html?cart-id=184-8990611-0175757%26associate-id=0925-5541-7892%26hmac=1XtOOKwMCBn53olmBrkogs95mbk=%26SubscriptionId=AKIAJD3AKNWLJZWFC25A%26MergeCart=False";

        private FireFoxRunner FFRunner;
        private IWebDriver FFDriver;

       

        public AmazonSteps()
        {
            FFRunner = new FireFoxRunner();
        }

        public void openAmazon(string virtualCartUrl)
        {
            FFDriver = FFRunner.startWebDriver();
            FFRunner.Navigate(virtualCartUrl);
        }

        public void closeAmazon()
        {
            FFRunner.finishWebDriver();
        }

        public void BuyProductFromCart()
        {

            ConfirmAddToCartStartPage ConfirmAddToCartStartPage=new ConfirmAddToCartStartPage(FFDriver);
            PageFactory.InitElements(FFDriver, (new ConfirmAddToCartStartPage(this.FFDriver)));

            ShoppingCartPage ShoppingCartPage=ConfirmAddToCartStartPage.OpenShoppingCartPage();
            SignInPage SignInPage=ShoppingCartPage.OpenSignInPage();
            //TODO:retrieving data from file
            string login=ConfigurationManager.AppSettings["login"];
            string password = ConfigurationManager.AppSettings["password"];
            SelectShippingAddress SelectShippingAddress = SignInPage.OpenShippingAddressPageWithCredentials(login, password);
            AmazonUIBuyer.Pages.SelectShippingAddress.ShippingAddressInfo ShippingAddressInfo=new AmazonUIBuyer.Pages.SelectShippingAddress.ShippingAddressInfo();

            //TODO: retriving and setting values
            ShippingAddressInfo.FullName = ConfigurationManager.AppSettings["FullName"];
            ShippingAddressInfo.AddressLineFirst = ConfigurationManager.AppSettings["AddressLineFirst"];
            ShippingAddressInfo.AddressLineSecond = ConfigurationManager.AppSettings["AddressLineSecond"];
            ShippingAddressInfo.City = ConfigurationManager.AppSettings["City"];
            ShippingAddressInfo.StateProvinceRegion = ConfigurationManager.AppSettings["StateProvinceRegion"];
            ShippingAddressInfo.ZIP = ConfigurationManager.AppSettings["ZIP"];
            ShippingAddressInfo.Country = ConfigurationManager.AppSettings["Country"];
            ShippingAddressInfo.PhoneNumber = ConfigurationManager.AppSettings["PhoneNumber"];
            ShippingAddressInfo.WeekendDelivery = ConfigurationManager.AppSettings["WeekendDelivery"];
            ShippingAddressInfo.SecurityAccessCode = ConfigurationManager.AppSettings["SecurityAccessCode"];

            ShippingOptionPage ShippingOptionPage = SelectShippingAddress.CreateShippingAddress(ShippingAddressInfo);
            PaymentMethodPage PaymentMethodPage=ShippingOptionPage.SelectShippingOption("free");
            PlaceOrderPage PlaceOrderPage = PaymentMethodPage.ProvideCardInformation(ConfigurationManager.AppSettings["cardName"], ConfigurationManager.AppSettings["cardNumber"], ConfigurationManager.AppSettings["expCardMonth"], ConfigurationManager.AppSettings["expCardYear"]);
            //PlaceOrderPage.PlaceOrder();
        }
    }
}
