using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarofferWebApp.Utilities
{
    public class VehicleDetails
    {
        public int Vehicle_Milage { get; set; }
        public string Miles_Atual { get; set; }
        public string Exterior_Color { get; set; }
        public string Interior_Color { get; set; }
        public string Vehicle_Owner { get; set; }
        public string Owned_90_Hidden_ddl { get; set; }
        public string Dealer_Individual_Hddl { get; set; }
        public string Service_History_Record { get; set; }
        //
        //public DateTime Last_Major_Service { get; set; }
        //
        public string Last_Major_Service { get; set; }
        public string Insurance_Claim_Done { get; set; }
        //
        //public DateTime Insurance_Claim_Date { get; set; }
        //
        public string Insurance_Claim_Date { get; set; }
        public string Insurance_Claim_Amoount { get; set; }
        public string Smoke_BOdour { get; set; }
        public string Key_Alarm_Pad_Available { get; set; }
        public string Taxi_Rental { get; set; }
        public string AfterMarket_Equipment_Installed { get; set; }
        public string AfterMarket_Equipment_Detals { get; set; }
        public string Performance_Modifications { get; set; }
        public string Performance_Modifications_Details { get; set; }
    }
}