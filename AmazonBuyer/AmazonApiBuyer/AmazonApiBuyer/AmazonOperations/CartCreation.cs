using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AmazonApiBuyer.AmazonOperations
{
    public class CartCreation : BasicAmazonOperation
    {
       private IDictionary<string, string> _requestParams = new Dictionary<string, String>();

       public CartCreation(string asin, string quantity)
        {
            _requestParams.Add("Item.1.ASIN", asin);
            _requestParams.Add("Item.1.Quantity", quantity);
        }

        public string OperationName
        {
            get
            {
                return "CartCreate";
            }

        }

        public IDictionary<string, string> requestParameters
        {
            get
            {
                return _requestParams;
            }

            set
            {
                _requestParams = value;
            }
        }
        

    }
}
