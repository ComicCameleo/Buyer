using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AmazonProductAdvtApi;
using AmazonApiBuyer.AmazonOperations;
using System.Configuration;

namespace AmazonApiBuyer.RequestBasic
{
    public class RequestConstructor
    {

        //SignedRequestHelper helper = new SignedRequestHelper(MY_AWS_ACCESS_KEY_ID, MY_AWS_SECRET_KEY, DESTINATION);

        static readonly string awsAccessKeyId = ConfigurationManager.AppSettings["awsAccessKeyId"];
        static readonly string awsSecretKey = ConfigurationManager.AppSettings["awsSecretKey"];
        static readonly string endpoint = ConfigurationManager.AppSettings["endpoint"];
        static readonly string associateTag = ConfigurationManager.AppSettings["AssociateTag"];

        //public RequestConstructor


        SignedRequestHelper helper = new SignedRequestHelper(awsAccessKeyId, awsSecretKey, endpoint);

        public string buildRequest(BasicAmazonOperation opertionData)
        {
            IDictionary<string, string> requestParams = new Dictionary<string, String>();
            requestParams["AssociateTag"] = associateTag;
            //requestParams["Operation"] = "ItemLookup";
            //requestParams["ItemId"] = "B00IZ1Y2XM";
            requestParams["Service"] = "AWSECommerceService";
            requestParams["Version"] = "2011-08-01";
            requestParams["Operation"] = opertionData.OperationName;

            var requestUrl = requestParams.Concat(opertionData.requestParameters).ToDictionary(i => i.Key, i => i.Value);
            return helper.Sign(requestUrl);
        }
        


    }
}
