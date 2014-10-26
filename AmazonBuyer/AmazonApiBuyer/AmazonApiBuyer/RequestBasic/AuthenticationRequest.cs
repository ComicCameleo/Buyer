using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Web;
using System.Security.Cryptography;

namespace AmazonApiBuyer.RequestBasic
{
    [Obsolete("Use SignedRequestHelper class", true)]
    public class AuthenticationRequest
    {

        //1
  //      private const string DefaultDateFormat = "yyyy-MM-dd'T'HH:mm:ss'Z'";
  //      private const string DefaultTimeZone = "Eastern Standard Time";


  //      private static const String UTF8_CHARSET = "UTF-8";
  //      private static const String HMAC_SHA256_ALGORITHM = "HmacSHA256";
  //      private static const String REQUEST_URI = "/onca/xml";
  //      private static const String REQUEST_METHOD = "GET";

  //      private String endpoint = ConfigurationManager.AppSettings["endpoint"];
  //      private String awsAccessKeyId = ConfigurationManager.AppSettings["awsAccessKeyId"];
  //      private String awsSecretKey = ConfigurationManager.AppSettings["awsSecretKey"];

  //      //private SecretKeySpec secretKeySpec = null;
  //      //private Mac mac = null;

  //      public AuthenticationRequest() {
  //          //byte[] secretyKeyBytes = Encoding.UTF8.GetBytes(awsSecretKey);
  //          //secretKeySpec = new SecretKeySpec(secretyKeyBytes, HMAC_SHA256_ALGORITHM);
  //         // mac = Mac.getInstance(HMAC_SHA256_ALGORITHM);
  //  //mac.init(secretKeySpec);
  //}






  //public String sign(Map<String, String> params) {
  //  params.put("AWSAccessKeyId", awsAccessKeyId);
  //  params.put("Timestamp", timestamp());

  //  SortedMap<String, String> sortedParamMap =
  //    new TreeMap<String, String>(params);
  //  String canonicalQS = canonicalize(sortedParamMap);
  //  String toSign =
  //    REQUEST_METHOD + "\n"
  //    + endpoint + "\n"
  //    + REQUEST_URI + "\n"
  //    + canonicalQS;

  //  String hmac = hmac(toSign);
  //  String sig = percentEncodeRfc3986(hmac);
  //  String url = "http://" + endpoint + REQUEST_URI + "?" +
  //  canonicalQS + "&Signature=" + sig;

  //  return url;
  //}

  //private String hmac(String stringToSign) {
  //  String signature = null;
  //  byte[] data;
  //  byte[] rawHmac;
  //  try {
  //    data = stringToSign.getBytes(UTF8_CHARSET);
  //    rawHmac = mac.doFinal(data);
  //    Base64 encoder = new Base64();
  //    signature = new String(encoder.encode(rawHmac));
  //  } catch (UnsupportedEncodingException e) {
  //    throw new RuntimeException(UTF8_CHARSET + " is unsupported!", e);
  //  }
  //  return signature;
  //}

    //1
    //get time stamp
//    public string timeStamp() 
//    {
//        DateTime currentDateTime = DateTime.UtcNow;
//        currentDateTime=TimeZoneInfo.ConvertTimeBySystemTimeZoneId(currentDateTime, DefaultTimeZone);
//        return currentDateTime.ToString(DefaultDateFormat);
//    }

//    //2
//    //convert to RFC 3986 specifications
//    public string percentEncodeRfc3986(string s)
//    {
//        var

//        return;
//    }

//        DivideByZeroException 




//  private String canonicalize(SortedMap<String, String> sortedParamMap)
//{
//    if (sortedParamMap.isEmpty()) {
//      return "";
//    }

//    StringBuffer buffer = new StringBuffer();
//    Iterator<Map.Entry<String, String>> iter =
//      sortedParamMap.entrySet().iterator();

//    while (iter.hasNext()) {
//      Map.Entry<String, String> kvpair = iter.next();
//      buffer.append(percentEncodeRfc3986(kvpair.getKey()));
//      buffer.append("=");
//      buffer.append(percentEncodeRfc3986(kvpair.getValue()));
//      if (iter.hasNext()) {
//        buffer.append("&");
//      }
//    }
//    String canonical = buffer.toString();
//    return canonical;
//  }

//  private String percentEncodeRfc3986(String s) {
//    String out;
//    try {
//      out = URLEncoder.encode(s, UTF8_CHARSET)
//      .replace("+", "%20")
//      .replace("*", "%2A")
//      .replace("%7E", "~");
//    } catch (UnsupportedEncodingException e) {
//      out = s;
//    }
//    return out;
//  }



    }
}
