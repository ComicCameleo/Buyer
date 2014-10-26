using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml;
using System.IO;



namespace xml2
{
  public  class ResponseBuyerParser
    {
      public string doctext;
      string elementExtractor(ExtractedElement elcol)
        {
            int first = doctext.IndexOf(elcol.frontDelimiter) + elcol.frontDelimiter.Length;
            int last = doctext.LastIndexOf(elcol.backDelimeter);
            elcol.elementValue = doctext.Substring(first, last - first);
            return elcol.elementValue;
        }
      

      public void text() {
           StreamReader sr = new StreamReader("response.xml");
           doctext = sr.ReadToEnd().ToString();
       
       
       }

        public string getUrlFromResponse()
        {
            //<!--вытянуть нужно CartId, HMAC, URLEncodedHMAC, PurchaseURL-->

            string purchaseUrl = "";
            try
            {

               
                {
                   
                    ExtractedElement CartId = new ExtractedElement("CartId", "<CartId>", "</CartId>");
                    ExtractedElement HMAC = new ExtractedElement("HMAC", "<HMAC>", "</HMAC>");
                    ExtractedElement URLEncodedHMAC = new ExtractedElement("URLEncodedHMAC", "<URLEncodedHMAC>", "</URLEncodedHMAC>");
                    ExtractedElement PurchaseURL = new ExtractedElement("PurchaseURL", "<PurchaseURL>", "</PurchaseURL>");
                    ExtractedElement[] elcol = { CartId, HMAC, URLEncodedHMAC, PurchaseURL };
                    //ResponseBuyerParser pr = new ResponseBuyerParser();
                    text();
                    foreach (var el in elcol) {
                        
                        elementExtractor(el);
                        System.Console.WriteLine("Element: {0}, Value:{1}", el.ElementName, el.elementValue);
                        
                    }

                    purchaseUrl = elementExtractor(PurchaseURL);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error, my bro! Error...:");
                Console.WriteLine(e.Message);
            }

        //Console.ReadLine();
        return purchaseUrl;
        }
    }

    public class ExtractedElement {
        public string ElementName, frontDelimiter, backDelimeter, elementValue;
  public  ExtractedElement(string name, string frDelimiter,string bDelimeter){
        ElementName=name;
        frontDelimiter=frDelimiter;
   backDelimeter= bDelimeter;
   elementValue = "";
    }
    }
}
