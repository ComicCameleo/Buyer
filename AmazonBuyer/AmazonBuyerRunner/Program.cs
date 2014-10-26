using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using xml2;
using AmazonUIBuyer;
using AmazonApiBuyer;

namespace AmazonBuyerRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            ApiRunner ApiRunner= new ApiRunner();
            ApiRunner.generateResponseApiBuyer();

            ResponseBuyerParser ResponseBuyerParser = new ResponseBuyerParser();
            string cartUrl=ResponseBuyerParser.getUrlFromResponse();

            UIBuyerRunner UIBuyerRunner = new UIBuyerRunner();
            UIBuyerRunner.buyProduct(cartUrl);

        }
    }
}
