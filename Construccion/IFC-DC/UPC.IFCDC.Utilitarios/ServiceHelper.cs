using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Newtonsoft.Json;
using System.Net;
using System.IO;

namespace UPC.IFCDC.Utilitarios
{
    public class ServiceHelper
    {
        public HttpWebRequest createHttpWebRequest(String servicio)
        {
            return (HttpWebRequest)WebRequest.Create("http://localhost:37016/SSIA2013.svc/" + servicio);
        }

        public String serializeObjectToJson(Object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        public StreamReader getObject(HttpWebRequest hwr, string json)
        {
            try
            {
                hwr.Method = "POST";
                hwr.ContentType = @"application/json";
                hwr.ContentLength = json.Length;
                System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
                Byte[] byteArray = encoding.GetBytes(json);

                using (Stream dataStream = hwr.GetRequestStream())
                {
                    dataStream.Write(byteArray, 0, byteArray.Length);

                    HttpWebResponse response = (HttpWebResponse)hwr.GetResponse();
                    Stream stream1 = response.GetResponseStream();
                    StreamReader sr = new StreamReader(stream1);
                    return sr;
                }
            }
            catch (Exception ex) { throw ex; }

        }
    }
}
