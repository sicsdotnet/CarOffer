using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarofferWebApp.BAl;
using Newtonsoft.Json;

namespace CarofferWebApp.CarofferForms
{
    public partial class AppraisalForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public VehicleSpecification GetWebdata()
        {
            Model modal = new Model();
            decodersettings decoder_settings = new decodersettings();

            commondatapacks common_data_packs = new commondatapacks();

            styledatapacks style_data_packs = new styledatapacks();

            queryrequest query_requests = new queryrequest();

            requestsample Request_Sample = new requestsample();

            Request_Sample.vin = vinApprisal_txb.Value.ToString();
            Request_Sample.year = "";

            query_requests.Request_Sample = Request_Sample;

            common_data_packs.basic_data = "on";
            common_data_packs.single_stock = "on";

            style_data_packs.basic_data = "on";
            style_data_packs.engines = "on";
            style_data_packs.transmissions = "on";
            style_data_packs.single_stock = "on";

            decoder_settings.common_data_packs = common_data_packs;
            decoder_settings.style_data_packs = style_data_packs;
            decoder_settings.display = "full";
            decoder_settings.version = "7.0.1";
            decoder_settings.styles = "on";
            decoder_settings.common_data = "on";

            modal.decoder_settings = decoder_settings;
            modal.query_requests = query_requests;


            string jsondata = JsonConvert.SerializeObject(modal);
            //CallLink();
            VehicleSpecification spec = new VehicleSpecification();
            spec.VIN = vinApprisal_txb.Value.ToString();
            WebServiceRepository wr = new WebServiceRepository();
            spec = wr.CallLink(jsondata);
            return spec;
        }

        protected void VehiclApprislForm_nextbtn_Click(object sender, ImageClickEventArgs e)
        {
            VehicleSpecification spec1 = GetWebdata();
            if (spec1.isValid)
            {
                Session["vin_data"] = spec1;
                Response.Redirect("Caroffers.aspx");
            }
            else
            {
                Response.Write(spec1.ErrorMessage);
            }

           // string vin = vinApprisal_txb.Value.ToString();
           // Session["vin"] = vin;
           // Response.Redirect("caroffers.aspx");
        }
    }
}