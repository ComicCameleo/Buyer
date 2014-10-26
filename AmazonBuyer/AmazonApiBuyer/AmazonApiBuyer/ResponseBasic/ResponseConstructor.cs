using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Xml.Linq;

namespace AmazonApiBuyer.ResponseBasic
{
   public class ResponseConstructor
    {
       public void buildResponse(string requestUrl)
       {
           //Create a request object using signed URL.
           WebRequest request = HttpWebRequest.Create(requestUrl) as HttpWebRequest;

           //Get response in a stream
           StreamReader reader = new StreamReader(request.GetResponse().GetResponseStream());
           XDocument xl = XDocument.Parse(reader.ReadToEnd().ToString());
           //Console.WriteLine(xl);
           xl.Save("response.xml");

           //Console.Read();
       }

    }
}
