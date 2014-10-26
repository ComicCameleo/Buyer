using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AmazonApiBuyer.AmazonOperations
{
    public interface BasicAmazonOperation
    {
       string OperationName
        {
            get;
        }

        IDictionary<string, string> requestParameters
        {
            get;
        }

    }
}
