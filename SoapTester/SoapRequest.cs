using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Protocols;
namespace SoapTester
{
    public class SoapRequest
    {
        public SoapRequest(String url, String soapXml, String method, String accept, String headers = null, String contentType = null, SoapProtocolVersion version = SoapProtocolVersion.Soap11)
        {
            this.Url = url;
            this.SoapXml = soapXml;
            this.Headers = ParseHeaders(headers);
            this.ContentType = contentType;
            this.Version = version;
            this.Method = method;
            this.Accept = accept;
        }

        public String Url { get; private set; }

        public String SoapXml
        {
            get; private set;
        }

        public List<String> Headers { get; set; }

        public String ContentType { get; set; }

        public SoapProtocolVersion Version { get; set; }

        public String Method { get; set; }

        public String Accept { get; set; }

        private List<String> ParseHeaders(String headersRaw)
        {
            if (headersRaw == null)
            {
                return null;
            }

            return headersRaw.Split(new String[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
        }
    }
    
}
