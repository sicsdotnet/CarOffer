using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarofferWebApp.BAl
{

    public class Model
    {
        public decodersettings decoder_settings { get; set; }
        public queryrequest query_requests { get; set; }
    }

    public class decodersettings
    {
        public string version { get; set; }
        public string display { get; set; }
        public string styles { get; set; }
        public string common_data { get; set; }
        public commondatapacks common_data_packs { get; set; }
        public styledatapacks style_data_packs { get; set; }
    }

    public class styledatapacks
    {
        public string basic_data { get; set; }
        public string engines { get; set; }
        public string transmissions { get; set; }
        public string single_stock { get; set; }
    }

    public class commondatapacks
    {
        public string basic_data { get; set; }
        public string single_stock { get; set; }
    }

    public class queryrequest
    {
        public requestsample Request_Sample { get; set; }
    }

    public class requestsample
    {
        public string vin { get; set; }
        public string year { get; set; }
    }

    //-----------------------

    public class ResponseModal
    {
        public DecodeMessages decoder_messages { get; set; }

        public QueryResponses query_responses { get; set; }
    }
    public class DecodeMessages
    {
        public string service_provider { get; set; }
        public string decoder_version { get; set; }
        //  public string decoder_errors { get; set; }
    }
    public class QueryResponses
    {
        public ReqSample Request_Sample { get; set; }
    }

    public class ReqSample
    {
        public string transaction_id { get; set; }
        public QueryError query_error { get; set; }
        public UsMarkerData us_market_data { get; set; }
    }

    public class QueryError
    {
        public string error_code { get; set; }
        public string error_message { get; set; }
    }

    public class UsMarkerData
    {
        public List<UsStyles> us_styles { get; set; }
    }

    public class UsStyles
    {
        public BasicData basic_data { get; set; }
        public Media media { get; set; }
        public List<Engines> engines { get; set; }
        public List<Transmissions> transmissions { get; set; }
    }
    public class BasicData
    {
        public string market { get; set; }
        public string year { get; set; }
        public string make { get; set; }
        public string model { get; set; }
        public string body_type { get; set; }
        public string drive_type { get; set; }
        public string trim { get; set; }
    }
    public class Media
    {
        public SingleStockImage single_stock_image { get; set; }
    }
    public class SingleStockImage
    {
        public string description { get; set; }
        public string thumb_location { get; set; }
        public string full_location { get; set; }
    }
    public class Engines
    {
        public string name { get; set; }
    }

    public class Transmissions
    {
        public string name { get; set; }
    }

  
    //--------------------------------------------

    public class VehicleSpecification
    {
        public string ErrorMessage { get; set; }
        public bool isValid { get; set; }
        public string VIN { get; set; }
        public string Year { get; set; }
        public string make { get; set; }
        public string model { get; set; }
        public string Style { get; set; }
        public List<string> Series;
        public string Transmission { get; set; }
        public string Engine { get; set; }
        public string full_location { get; set; }
        public string thumb_location { get; set; }
    }
}