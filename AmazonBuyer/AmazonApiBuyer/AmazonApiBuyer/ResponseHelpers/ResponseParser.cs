using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Linq;
using System.Xml;

namespace AmazonApiBuyer.ResponseHelpers
{
    [Obsolete("Need to be updated", true)]
    public class ResponseParser
    {
        public Dictionary<string, string> responseElements;

        private StreamReader _reader;

        public ResponseParser(StreamReader reader)
        {       
            _reader=reader;
        }

        public void GetData()
        {
            try
            {

                XElement xelement = XElement.Load(_reader);
                Console.WriteLine(xelement.ToString());
                Console.ReadLine();

                var url = from p in xelement.Elements()
                          select p;
                var oururl = url.Last().Nodes().AsEnumerable().ElementAt(1);
                XDocument doc = XDocument.Parse(oururl.ToString());
                var els = doc.Nodes();
                els.ToList();
                var oi = els.Last().Document;
                var dnodes = oi.DescendantNodes();
                var urlresult = dnodes.ElementAt(3).ToString();
                XmlDocument ndoc = new XmlDocument();
                ndoc.LoadXml(urlresult);
                XmlNode xn = ndoc.DocumentElement.FirstChild;
                var pureurl = xn.InnerText;

                Console.WriteLine(pureurl);
                Console.ReadLine();
            }
            catch (Exception e)
            {
                //If there is an error capture it.
                //If you get an error, it could be either because of invalid keyword or you provided wrong access key.
                System.Console.WriteLine("Caught Exception: " + e.Message);
                System.Console.WriteLine("Stack Trace: " + e.StackTrace);
                System.Console.ReadLine();
            }
        }
    }
}
