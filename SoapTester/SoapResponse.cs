using System;
using System.Xml.Linq;

namespace SoapTester
{
    public class SoapResponse
    {
        public String response;

        public SoapResponse()
        {

        }

        #region Properties
        public String Response
        {
            get
            {
                return response;
            }
            set
            {
                try
                {
                    this.response = XElement.Parse(value).ToString();
                }
                catch
                {
                    this.response = value;
                }
            }
        }

        public String Error { get; set; }

        public Boolean IsError
        {
            get
            {
                return !String.IsNullOrEmpty(this.Error);
            }
        }

        #endregion Properties
    }

}
