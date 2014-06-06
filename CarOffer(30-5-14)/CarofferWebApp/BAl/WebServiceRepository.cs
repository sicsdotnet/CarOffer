using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Web;
using Newtonsoft.Json;


namespace CarofferWebApp.BAl
{
    public class WebServiceRepository
    {
        public VehicleSpecification CallLink(string data)
        {

            String url = "https://api.dataonesoftware.com/webservices/vindecoder/decode";
            String postData = "client_id=9330&authorization_code=03ec4d1c5223bfda6a68fa0e7c78cc4509ed9736&decoder_query=";
            postData += data;

            // set up the request object        
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = postData.Length;

            // set the SSL certificate validation function
            ServicePointManager.ServerCertificateValidationCallback += new System.Net.Security.RemoteCertificateValidationCallback(ValidateServerCertificate);
            Stream writeStream = request.GetRequestStream();

            // Encode the string to be posted
            UTF8Encoding encoding = new UTF8Encoding();
            byte[] bytes = encoding.GetBytes(postData);
            writeStream.Write(bytes, 0, bytes.Length);
            writeStream.Close();

            // get Response
            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {

                StreamReader reader = new StreamReader(response.GetResponseStream());
                string st = Convert.ToString(reader.ReadLine());
                ResponseModal modalobject = new ResponseModal();
                modalobject = JsonConvert.DeserializeObject<ResponseModal>(st);
                VehicleSpecification specification = new VehicleSpecification();

                string errorcode = modalobject.query_responses.Request_Sample.query_error.error_code;
                if (errorcode == null)
                {


                    specification.isValid = true;
                    specification.full_location = "http://img.dataonesoftware.com/" + (modalobject.query_responses.Request_Sample.us_market_data.us_styles).FirstOrDefault().media.single_stock_image.full_location;
                    specification.thumb_location = "http://img.dataonesoftware.com/" + (modalobject.query_responses.Request_Sample.us_market_data.us_styles).FirstOrDefault().media.single_stock_image.thumb_location;
                    specification.Year = (modalobject.query_responses.Request_Sample.us_market_data.us_styles).FirstOrDefault().basic_data.year;
                    specification.model = (modalobject.query_responses.Request_Sample.us_market_data.us_styles).FirstOrDefault().basic_data.model;
                    specification.make = (modalobject.query_responses.Request_Sample.us_market_data.us_styles).FirstOrDefault().basic_data.make;
                     specification.Style = (modalobject.query_responses.Request_Sample.us_market_data.us_styles).FirstOrDefault().basic_data.body_type;
                    //specification.Series =           (modalobject.query_responses.Request_Sample.us_market_data.us_styles).FirstOrDefault().basic_data.drive_type + (modalobject.query_responses.Request_Sample.us_market_data.us_styles).FirstOrDefault().basic_data.trim;
                    specification.Series = GetSeriesList(modalobject);
                     specification.Transmission = (modalobject.query_responses.Request_Sample.us_market_data.us_styles).FirstOrDefault().transmissions.FirstOrDefault().name;
                     specification.Engine = (modalobject.query_responses.Request_Sample.us_market_data.us_styles).FirstOrDefault().engines.FirstOrDefault().name;

                }
                else
                {
                    specification.isValid = false;
                    specification.ErrorMessage = modalobject.query_responses.Request_Sample.query_error.error_message;
                }
                // reader now contains the data returne by the response

                return specification;
            }



        }

        public List<string> GetSeriesList(ResponseModal rm)
        {

            VehicleSpecification spec = new VehicleSpecification();
            spec.Series = new List<string>();
            List<UsStyles> usstyle = new List<UsStyles>();
            usstyle = rm.query_responses.Request_Sample.us_market_data.us_styles;
            foreach (UsStyles us in usstyle)
            {
                spec.Series.Add(us.basic_data.drive_type + us.basic_data.trim);

                // spec.Series.
            }
            spec.Series = spec.Series.AsEnumerable().Distinct().ToList();
            return spec.Series;

        }

        // This is a validation function that accepts any SSL certificate
        public static bool ValidateServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }

    }
}