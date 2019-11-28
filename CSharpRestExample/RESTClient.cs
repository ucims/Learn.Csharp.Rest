using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace CSharpRestExample
{
    public enum httpVerb
    {
        GET,
        POST,
        PUT,
        DELETE
    }
    class RESTClient
    {
        public string endPoint { get; set; }
        public httpVerb httpMethod { get; set; }

        public RESTClient()
        {
            endPoint = "";
            httpMethod = httpVerb.GET;
        }

        public string makeResponse()
        {
            string strResponseValue = string.Empty;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint);
            request.Method = httpMethod.ToString();
           // HttpWebResponse response = null;

            using(HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                if(response.StatusCode != HttpStatusCode.OK)
                {
                    throw new ApplicationException("Error code is  " + response.StatusCode.ToString());
                }

                using (Stream responseStream = response.GetResponseStream())
                {
                    if(responseStream != null)
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                        {
                            strResponseValue = reader.ReadToEnd();
                        }
                    }
                }
            }
            /*
            try
            {
                response = (HttpWebResponse)request.GetResponse();
                //process the response stream (could be json, xml, or html)
                using(Stream responseStream = response.GetResponseStream())
                {
                    if(responseStream != null)
                    {
                        using(StreamReader reader = new StreamReader(responseStream))
                        {
                            strResponseValue = reader.ReadToEnd();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                // we catch non 200 response 
                strResponseValue = "{\" errorMessage\":[\"" + ex.Message.ToString() + "\"], \"error\":{}}";
            }
            finally
            {
                if(response != null)
                {
                    ((IDisposable)response).Dispose();
                }
            }
            */
            return strResponseValue;
        }

    }
}
