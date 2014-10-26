using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Net;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Data;
using AmazonProductAdvtApi;
using System.Collections;
using System.Xml;
using System.Xml.Linq;
using AmazonApiBuyer.RequestBasic;
using AmazonApiBuyer.AmazonOperations;
using AmazonApiBuyer.ResponseHelpers;
using AmazonApiBuyer.ResponseBasic;
using System.Configuration;

namespace AmazonApiBuyer
{
    public class ApiRunner
    {

        public void generateResponseApiBuyer()
        {

            //Use SignedRequesthelper class to generate signed request. 

            RequestConstructor RequestConstructor = new RequestConstructor();
            ResponseConstructor ResponseConstructor = new ResponseConstructor();

            BasicAmazonOperation opertion = new CartCreation(ConfigurationManager.AppSettings["productASIN"], "1");

            //Get signed URL in a variable
            string requestUrl = RequestConstructor.buildRequest(opertion);

            ResponseConstructor.buildResponse(requestUrl); 
        }
       
    }
}
