using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using AmazonUIBuyer.RunnerHelpers;
using AmazonUIBuyer.Steps;

namespace AmazonUIBuyer
{
    public class UIBuyerRunner
    {
        public void buyProduct(string cartUrl)
        {
            AmazonSteps amazonSteps = new AmazonSteps();
            amazonSteps.openAmazon(cartUrl);
            amazonSteps.BuyProductFromCart();
            //amazonSteps.closeAmazon();
        }
    }
}
