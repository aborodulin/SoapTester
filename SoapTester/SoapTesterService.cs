namespace SoapTester
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net;
    using System.Web.Services.Protocols;
    using System.Xml;

    public class SoapTesterService
    {
        #region Constructors
        public SoapTesterService(SoapRequest request)
        {
            this.Request = request;
        }
        #endregion Constructors

        #region Properties
        public SoapRequest Request { get; private set; }
        
        #endregion Properties

        public static SoapResponse Execute(SoapRequest request)
        {
            SoapTesterService soapService = new SoapTesterService(request);
            return soapService.Execute();
        }

        private SoapResponse Execute()
        {
            SoapResponse soapResponse = new SoapResponse();
            try
            {
                HttpWebRequest request = this.CreateWebRequest(this.Request.Url);
                XmlDocument soapEnvelopeXml = new XmlDocument();
                soapEnvelopeXml.LoadXml(this.Request.SoapXml);

                using (Stream stream = request.GetRequestStream())
                {
                    soapEnvelopeXml.Save(stream);
                }

                using (WebResponse response = request.GetResponse())
                {
                    using (StreamReader rd = new StreamReader(response.GetResponseStream()))
                    {
                        string soapResult = rd.ReadToEnd();
                        soapResponse.Response = soapResult;
                    }
                }

            }
            catch (SoapException soapEx)
            {
                soapResponse.Response += soapEx.Detail.ToString();
                soapResponse.Error = soapEx.ToString();
            }
            catch (Exception ex)
            {
                soapResponse.Error = ex.ToString();
            }

            return soapResponse;
        }
                
        /// <summary>
        /// Create a soap webrequest to [Url]
        /// </summary>
        /// <returns></returns>
        private HttpWebRequest CreateWebRequest(String url)
        {
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
            if (this.Request.Headers != null)
            {
                this.Request.Headers.ForEach(h=> {
                    webRequest.Headers.Add(h);
                });                
            }
            webRequest.ContentType = this.Request.ContentType;
            webRequest.Accept = this.Request.Accept;
            webRequest.Method = this.Request.Method;
            return webRequest;
        }
    }
}
 