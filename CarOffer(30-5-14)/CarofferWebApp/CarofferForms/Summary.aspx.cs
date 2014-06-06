using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarofferWebApp.BAl;
using System.Data;
using System.Data.SqlClient;

namespace CarofferWebApp.CarofferForms
{
    public partial class Summary : System.Web.UI.Page
    {
        PropertyManager pm = new PropertyManager();
        public DataTable dt = null;
        
        
        protected void Page_Load(object sender, EventArgs e)
        { 
            if (!IsPostBack)
            {    // Vehicle Specification
                VehicleSpecification_Fill();

                // Owner Information
                VehicleOwnerInformation_Fill();

                // Vehicle Details
                VehicleDetailsFill();

                //Vehicle options and Features
                VehicleOptionFeatures_summaryfill();


                // vehicle condition details [image map]
                FIllImageMapData_summary_admin();
                // vehicle images uploaded
                VehicleUploadedImagesFill();

 
            }

        }
        public void VehicleSpecification_Fill()
        {
            int vinid =Convert.ToInt32( Request.QueryString["vinid"].ToString());
            try
            {

                dt = pm.getVehicleSpecSummaryAdmin(vinid);
                if (dt != null)
                {
                    string vin = ""; string year = ""; string make = ""; string model = ""; string style = ""; string transmission = ""; string engine = "";
                    foreach (DataRow dr in dt.Rows)
                    {
                        vin = dr["VIN"].ToString();
                        year = dr["YEAR"].ToString();
                        make = dr["MAKE"].ToString();
                        model = dr["MODEL"].ToString();
                        style = dr["STYLE"].ToString();
                        transmission = dr["TRANSMISSION"].ToString();
                        engine = dr["ENGINE"].ToString();
                    }
                    Vin_valueFil_lb.Text = vin;
                    Year_valueFil_lb.Text = year;
                    Make_valueFil_lb.Text = make;
                    Model_valueFil_lb.Text = model;
                    Style_valueFil_lb.Text = style;
                    Transmission_valueFil_lb.Text = transmission;
                    Engine_valueFil_lb.Text = engine;



                }
            }
            catch (Exception e)
            {
            }

        }
        public void VehicleOwnerInformation_Fill()
        {
            int vinid =Convert.ToInt32( Request.QueryString["vinid"].ToString());
            try
            {
                dt = pm.getVehicleOwnerSummaryAdmin(vinid);
            }
            catch (Exception e)
            {
            }
            string firstname = "";
            string lastname = "";
            string email = "";
            string zipcode = "";
            string telephone = "";
            string financing_leasing = "";
            string hearabout = "";
            string expectedAmount = "";
            string registerstate = "";


            string FinanceCompanyname = "";
            string LeasingCompanyname = "";

            string financeAmount = "";
            string LeasingAmount = "";

            try
            {
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        firstname = dr["FIRST_NAME"].ToString();
                        lastname = dr["LAST_NAME"].ToString();
                        email = dr["EMAIL"].ToString();
                        zipcode = dr["ZIP_CODE"].ToString();
                        telephone = dr["TELEPHONE"].ToString();
                        financing_leasing = dr["LEASING_FINANCING"].ToString();
                        hearabout = dr["HEAR_ABOUT"].ToString();
                        expectedAmount = dr["AMOUNT_EXPECTED"].ToString();
                        registerstate = dr["REGISTRATION_STATE"].ToString();

                        FinanceCompanyname = dr["FINANCING_COMPANY_NAME"].ToString();
                        financeAmount = dr["F_BALANCE_DUE"].ToString();

                        LeasingCompanyname = dr["LEASING_COMPANY_NAME"].ToString();
                        LeasingAmount = dr["LEASING_COMPANY_NAME"].ToString();

                    }

                    First_name_value_lbl.Text = firstname;
                    Lastname_value_lbl.Text = lastname;
                    Email_value_lbl.Text = email;
                    Zip_code_value_lbl.Text = zipcode;
                    Telephone_value_Filllbl.Text = telephone;
                    Financing_Leasing_Filllbl.Text = financing_leasing;
                    Hear_about_value_lbl.Text = hearabout;
                 //   || (expectedAmount != "$.00"))
                    if (expectedAmount != "") 
                    {
                        Expctd_Amount_value_lbl.Text = expectedAmount;
                        tr_Expected_Amount.Visible = true;

                    }
                    else
                    {
                        tr_Expected_Amount.Visible = false;
                        //Expctd_Amount_value_lbl.Text = "0";
                    }
                    Vehicle_registrd_value_lbl.Text = registerstate;






                    if (financeAmount != "")
                    {
                        tr_financeAmount_financing.Visible = true;
                        Finance_Amount_Fill_lbl.Text = financeAmount;
                    }
                    else
                    {
                        tr_financeAmount_financing.Visible = false;
                    }


                    if (LeasingAmount != "")
                    {
                        tr_LeasedAmount.Visible = true;
                        Leased_Amount_fill_lbl.Text = LeasingAmount;
                    }
                    else
                    {
                        tr_financeAmount_financing.Visible = false;
                    }



                    if (FinanceCompanyname != "")
                    {
                        tr_financecompname_financing.Visible = true;
                        FinanceCompany_name_Fill_lbl.Text = FinanceCompanyname;

                    }
                    else
                    {
                        tr_financecompname_financing.Visible = false;
                    }


                    if (LeasingCompanyname != "")
                    {
                        tr_leasingCompanyName.Visible = true;
                        LeasingCompName_fill_Lbl.Text = FinanceCompanyname;

                    }
                    else
                    {
                        tr_leasingCompanyName.Visible = false;
                    }

                }

            }
            catch (Exception e)
            {

            }
    }
        public void VehicleDetailsFill() 
        {
            int vinid = Convert.ToInt32(Request.QueryString["vinid"].ToString());
            try
            {
                dt = pm.getVehicleDetailsSummaryAdmin(vinid);
            }
            catch (Exception e)
            {
            }
            
            string currentmileage = "";
            string ActualMileage = "";
            string ExteriorColor = "";
            string InteriorColor = "";
            string OriginslOwner = "";
            string Owned90days="";
            string PurchasedFrom = "";
            string smoke_badodor = "";
            string serviceHistory = "";
            string keysets = "";
            string taxi_rental = "";
            string insuranceClaimed = "";
            string insuranceclaimdate = "";
            string insuranceclaimamount = "";
            string performancemodification = "";
            string performancedesciption = "";
            string equipmentinstalled = "";
            string equipmntinstalleddescription = "";
            try
            {
                
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        currentmileage = Convert.ToString(dr["VEHICLE_MILAGE"]);
                        ActualMileage = Convert.ToString(dr["ACTUAL_ACCURATE"]);
                        ExteriorColor = Convert.ToString(dr["EXTERIOR_COLOR"]);
                        InteriorColor = Convert.ToString(dr["INTERIOR_COLOR"]);
                        OriginslOwner = Convert.ToString(dr["ORIGINAL_OWNER"]);
                        Owned90days = Convert.ToString(dr["OWNED_90DAYS"]);
                        PurchasedFrom = Convert.ToString(dr["PURCHASED_FROM"]);
                        smoke_badodor = Convert.ToString(dr["PURCHASED_FROM"]);
                        serviceHistory = Convert.ToString(dr["SERVICE_HISTORY_RECORD"]);
                        keysets = Convert.ToString(dr["KEY_ALARM_PAD"]);
                        taxi_rental = Convert.ToString(dr["TAXI_RENTAL"]);
                        insuranceClaimed = Convert.ToString(dr["INSURANCE_CLAIM_FILED"]);
                        insuranceclaimdate = Convert.ToString(dr["INSURANCE_CLAIM_DATE"]);
                        insuranceclaimamount = Convert.ToString(dr["INSURANCE_CLAIM_AMOUNT"]);
                        performancemodification = Convert.ToString(dr["PERFORMANCE_MODIFICTIONS"]);
                        performancedesciption = Convert.ToString(dr["PERFORMANCE_MODIFICTIONS_DETAILS"]);
                        equipmentinstalled = Convert.ToString(dr["EQUIPMENTS_INSTALLED"]);
                        equipmntinstalleddescription = Convert.ToString(dr["EQUIPMENTS_INSTALLED_DETAILS"]);


                    }

                    Current_Milg_Fill_lbl.Text = currentmileage;
                    Actual_Accurate_Milege_fill_lbl.Text = ActualMileage;
                    Exterior_color_Fill_lbl.Text = ExteriorColor;
                    Interior_color_Fil_lbl.Text = InteriorColor;
                    Original_Owner_Fill_lbl.Text = OriginslOwner;


                    Smoked_Bad_odor_fil_lbl.Text = smoke_badodor;
                    Servic_histry_fill_lbl.Text = serviceHistory;
                    Set_2_keys_fill_lbl.Text = keysets;
                    Taxi_rental_fill_lbl.Text = taxi_rental;
                    Insurance_claimed_fill_lbl.Text = insuranceClaimed;

                    Performance_Modificaion_fill_lbl.Text = performancemodification;

                    After_Equipmnt_installed_fil_lbl.Text = equipmentinstalled;



                    if (Original_Owner_Fill_lbl.Text == "NO")
                    {
                        if (Owned90days == "Yes")
                        {
                            Purchased_from_Fill_lbl.Text = PurchasedFrom;
                            tr_Purchased_from.Visible = true;
                        }
                    }
                    else
                    {
                        tr_Purchased_from.Visible = false;

                    }

                    if ((Insurance_claimed_fill_lbl.Text == "No") || (Insurance_claimed_fill_lbl.Text == "Not Sure"))
                    {
                        tr_insurance_Claimed_date.Visible = false;
                        tr_insurance_claimed_Amount.Visible = false;
                    }

                    if (Insurance_claimed_fill_lbl.Text == "Yes")
                    {
                        Insurance_claim_date_fill_lbl.Text = insuranceclaimdate;
                        Insurance_Claim_amount_fill_lbl.Text = insuranceclaimamount;
                        tr_insurance_Claimed_date.Visible = true;
                        tr_insurance_claimed_Amount.Visible = true;

                    }


                    if ((Performance_Modificaion_fill_lbl.Text == "No") || (Performance_Modificaion_fill_lbl.Text == "Not Sure"))
                    {
                        tr_Performance_description.Visible = false;
                    }
                    if (Performance_Modificaion_fill_lbl.Text == "Yes")
                    {
                        Performance_description_fill_lbl.Text = performancedesciption;
                        tr_Performance_description.Visible = true;
                    }

                    if ((After_Equipmnt_installed_fil_lbl.Text == "No") || (After_Equipmnt_installed_fil_lbl.Text == "No"))
                    {
                        tr_Equipment_description.Visible = false;
                    }
                    if (After_Equipmnt_installed_fil_lbl.Text == "Yes")
                    {
                        Equipment_description_fill_lbl.Text = equipmntinstalleddescription;
                        tr_Equipment_description.Visible = true;
                    }
                }
            }
            catch (Exception e)
            {

            }
        }

        public void VehicleOptionFeatures_summaryfill()
        {
            int vinid = Convert.ToInt32(Request.QueryString["vinid"].ToString());
            string htmlStr = "";
            htmlStr = "<centre><table style=\"width:80%;margin-top:1%;\">";
            try
            {
                DataTable dt = pm.getVehicleoptionfetures_summary_admin(vinid);
            }
            catch (Exception eg)
            {
            }

            DataTable dt1 = new DataTable();
            dt1.Columns.Add("Head1");
            dt1.Columns.Add("Head2");
            DataRow dr;
            try
            {
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        if (i % 2 == 0)
                        {
                            dr = dt1.NewRow();

                            dr["Head1"] = dt.Rows[i][0].ToString();
                            dt1.Rows.Add(dr);
                            ViewState["count"] = dt1.Rows.Count;
                        }

                    //        dr["Head1"] = dtt.Rows[i].ToString();

                        else
                        {
                            int count = Convert.ToInt32(ViewState["count"]);
                            dr = dt1.Rows[count - 1];

                            dr["Head2"] = dt.Rows[i][0].ToString();
                            // dt1.Rows.Add(dr);
                        }

                    }
                }
            }
            catch (Exception e)
            {

            }


            try
            {
                if (dt1 != null)
                {
                    foreach (DataRow dr1 in dt1.Rows)
                    {
                        string first = Convert.ToString(dr1["Head1"]);
                        string second = Convert.ToString((dr1["Head2"]));
                        htmlStr += "<tr style=\"width:100%;\"><td style=\"width:320px;border-bottom: solid 1px;\">" + first + "</td><td style=\"width: 100px;\"></td>";

                        if (second != "")
                        {
                            htmlStr += "<td style=\"width:320px;border-bottom:solid 1px;\">" + second + "</td>";
                        }

                        htmlStr += "</tr>";

                        //<td style=\"width:320px;border-bottom:solid 1px;\">" + second + "</td></tr>";

                    }
                }
            }
            catch (Exception e)
            {

            }
            htmlStr += "</table></centre>";
            maindiv_tale.InnerHtml = htmlStr;

           
        }




        public void VehicleUploadedImagesFill()
        {
            int vinid =Convert.ToInt32( Request.QueryString["vinid"].ToString());
            try
            {

                dt = pm.getVehicleUploadedImages_Summary_Admin_fill(vinid);
            }
            catch (Exception ey)
            {
            }

            string htmlStr = "";
            try
            {
                if (dt.Rows.Count != 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        string path = Convert.ToString(dr["IMAGE_PATH"]);
                        path = path.Replace("~/", " ../");
                        htmlStr += "<img src=\"" + path + "\" style=\"width:10%;margin-bottom:1%;\"/>&nbsp;&nbsp;&nbsp;";
                        imagediv.InnerHtml = htmlStr;

                    }
                }
            }
            catch (Exception e)
            {

            }




        }


        public void FIllImageMapData_summary_admin()
        {
           int vinid = Convert.ToInt32(Request.QueryString["vinid"].ToString());

           try
           {
               DataTable DT1 = pm.getFrontBumperData_Summry_Admin_fill(vinid);
               try
               {
                   if (DT1.Rows.Count > 0)
                   {
                       Fb_Div_Summary.Visible = true;
                       Gvd_FrontBumper.DataSource = DT1;
                       Gvd_FrontBumper.DataBind();
                   }
               }
               catch (Exception e1)
               {

               }

           }
           catch (Exception t1)
           {
           }
           try
           {
               DataTable DT2 = pm.getHoodData_Summry_Admin_fill(vinid);
                try
            {
                if (DT2.Rows.Count > 0)
                {
                    Hood_Div_Summary.Visible = true;
                    Gvd_Hood.DataSource = DT2;
                    Gvd_Hood.DataBind();
                }
            }
                catch (Exception e2)
                {

                }
           }
           catch (Exception t2)
           {
           }

            try{
            DataTable DT3 = pm.getRoofData_Summry_Admin_fill(vinid);
            try
            {
                if (DT3.Rows.Count > 0)
                {
                    Roof_Div_Summary.Visible = true;
                    Gvd_Rooof.DataSource = DT3;
                    Gvd_Rooof.DataBind();
                }
            }
            catch (Exception e3)
            {

            }
            }
            catch (Exception t3)
            {
            }


            try
            {
                DataTable DT4 = pm.getFront_Left_fenderData_Summry_Admin_fill(vinid);
                try
                {
                    if (DT4.Rows.Count > 0)
                    {
                        Front_Left_fender_Div_Summary.Visible = true;
                        Gvd_Front_left_Fender.DataSource = DT4;
                        Gvd_Front_left_Fender.DataBind();
                    }
                }
                catch (Exception e4)
                {

                }
            }
            catch (Exception t4)
            {
            }

            try
            {
                DataTable DT5 = pm.getFront_Left_DoorData_Summry_Admin_fill(vinid);
                try
                {
                    if (DT5.Rows.Count > 0)
                    {
                        Front_Left_Door_Div_Summary.Visible = true;
                        Gvd_FrontLeftDoor.DataSource = DT5;
                        Gvd_FrontLeftDoor.DataBind();
                    }
                }
                catch (Exception e5)
                {

                }

            }
            catch (Exception t5)
            {
            }
            try{
            DataTable DT6 = pm.getRearLeftDoorData_Summry_Admin_fill(vinid);
            try
            {
                if (DT6.Rows.Count > 0)
                {
                    RearLeftDoor_Div_Summary.Visible = true;
                    Gvd_Rear_Left_door.DataSource = DT6;
                    Gvd_Rear_Left_door.DataBind();
                }
            }
            catch (Exception e6)
            {

            }
            }
            catch (Exception t6)
            {
            }

            try
            {
                DataTable DT7 = pm.getRearLeftQuarterPanelData_Summry_Admin_fill(vinid);
                try
                {
                    if (DT7.Rows.Count > 0)
                    {
                        RearLeftQuarterPanel_Div_Summary.Visible = true;
                        Gvd_RearLeftQuarterPanel.DataSource = DT7;
                        Gvd_RearLeftQuarterPanel.DataBind();
                    }
                }
                catch (Exception e7)
                {

                }

            }
            catch (Exception t7)
            {
            }
            try
            {
                DataTable DT8 = pm.getFrontLeftWindowData_Summry_Admin_fill(vinid);
                try
                {
                    if (DT8.Rows.Count > 0)
                    {
                        FrontLeftWindow_Div_summary.Visible = true;
                        Gvd_FrontLeftWindow.DataSource = DT8;
                        Gvd_FrontLeftWindow.DataBind();
                    }
                }
                catch (Exception e8)
                {

                }
            }

           catch (Exception t8)
           {
           }
            try{
            DataTable DT9 = pm.getRearLeftWindowData_Summry_Admin_fill(vinid);
            try
            {
                if (DT9.Rows.Count > 0)
                {
                    RearLeftWindow_Div_summary.Visible = true;
                    Gvd_RearLeftWindow.DataSource = DT9;
                    Gvd_RearLeftWindow.DataBind();
                }
            }
            catch (Exception e9)
            {

            }
            }
            catch (Exception t9)
            {
            }


            try{
            DataTable DT10 = pm.getFrontWindshieldData_Summry_Admin_fill(vinid);
            try
            {
                if (DT10.Rows.Count > 0)
                {
                    FrontWindshield_Div_summary.Visible = true;
                    Gvd_FrontWindshield.DataSource = DT10;
                    Gvd_FrontWindshield.DataBind();
                }
            }
            catch (Exception e10)
            {

            }
            }
            catch (Exception t10)
            {
            }

            try
            {
            DataTable DT11 = pm.getFrontLeftWheelTireData_Summry_Admin_fill(vinid);
            try
            {
                if (DT11.Rows.Count > 0)
                {
                    FrontLeftWheelTire_Div_summary.Visible = true;
                    Gvd_FrontLeftWheelTire.DataSource = DT11;
                    Gvd_FrontLeftWheelTire.DataBind();
                }
            }
            catch (Exception e11)
            {

            }


            }
            catch (Exception t11)
            {
            }
            try{
            DataTable DT12 = pm.getRearLeftWheelTireData_Summry_Admin_fill(vinid);
            try
            {
                if (DT12.Rows.Count > 0)
                {
                    RearLeftWheelTire_Div_Summary.Visible = true;
                    Gvd_RearLeftWheelTire.DataSource = DT12;
                    Gvd_RearLeftWheelTire.DataBind();
                }
            }
            catch (Exception e12)
            {

            }
            }
            catch (Exception t12)
            {
            }

            try
            {
            DataTable DT13 = pm.getFrontLeftHeadlightData_Summry_Admin_fill(vinid);
            // 13 FrontLeftHeadligh_Div_Summary
            try
            {
                if (DT13.Rows.Count > 0)
                {
                    FrontLeftHeadligh_Div_Summary.Visible = true;
                    Gvd_FrontLeftHeadligh.DataSource = DT13;
                    Gvd_FrontLeftHeadligh.DataBind();
                }
            }
            catch (Exception e13)
            {

            }

            }
            catch (Exception t13)
            {
            }
            try{
            DataTable DT14 = pm.getFrontRighttHeadlightData_Summry_Admin_fill(vinid);
            // 14 FrontRighttHeadligh_Div_Summary

            try
            {
                if (DT14.Rows.Count > 0)
                {
                    FrontRighttHeadligh_Div_Summary.Visible = true;
                    Gvd_FrontrightHeadlight.DataSource = DT14;
                    Gvd_FrontrightHeadlight.DataBind();
                }
            }
            catch (Exception e14)
            {

            }
            }
            catch (Exception t14)
            {
            }
            try
            {
                DataTable DT15 = pm.getLeftMirrorData_Summry_Admin_fill(vinid);
                // 15 LeftMirror_Div_Summary
                try
                {
                    if (DT15.Rows.Count > 0)
                    {
                        LeftMirror_Div_Summary.Visible = true;
                        Gvd_LeftMirror.DataSource = DT15;
                        Gvd_LeftMirror.DataBind();
                    }
                }
                catch (Exception e15)
                {

                }
            }
            catch (Exception t15)
            {
            }


            try{

            DataTable DT16 = pm.getTrunkData_Summry_Admin_fill(vinid);
            // 16 Trunk_Div_Summary
            try
            {
                if (DT16.Rows.Count > 0)
                {
                    Trunk_Div_Summary.Visible = true;
                    Gvd_Trunk.DataSource = DT16;
                    Gvd_Trunk.DataBind();
                }
            }
            catch (Exception e16)
            {

            }

            }
            catch (Exception t16)
            {
            }

            try
            {
                DataTable DT17 = pm.getRearBumperData_Summry_Admin_fill(vinid);
                // 17 RearBumper_Div_Summary
                try
                {
                    if (DT17.Rows.Count > 0)
                    {
                        RearBumper_Div_Summary.Visible = true;
                        Gvd_RearBumper.DataSource = DT17;
                        Gvd_RearBumper.DataBind();
                    }
                }
                catch (Exception e17)
                {

                }

            }
            catch (Exception t17)
            {
            }
            try
            {
                DataTable DT18 = pm.getRearRightQuarterPanelData_Summry_Admin_fill(vinid);
                try
                {
                    if (DT18.Rows.Count > 0)
                    {
                        RearRightQuarterPanel_Div_Summary.Visible = true;
                        Gvd_RearRightQuarterPanel.DataSource = DT18;
                        Gvd_RearRightQuarterPanel.DataBind();
                    }
                }
                catch (Exception e18)
                {

                }


            }
           catch (Exception t18)
           {
           }
            try
            {
                DataTable DT19 = pm.getFrontRightFenderData_Summry_Admin_fill(vinid);
                // 19 FrontRightFender_Div_Summary
                try
                {
                    if (DT19.Rows.Count > 0)
                    {
                        FrontRightFender_Div_Summary.Visible = true;
                        Gvd_FrontRightFender.DataSource = DT19;
                        Gvd_FrontRightFender.DataBind();
                    }
                }
                catch (Exception e19)
                {

                }
            }
            catch (Exception t19)
            {
            }
            try
            {
                DataTable DT20 = pm.getFrontRightDoorData_Summry_Admin_fill(vinid);
                // 20 FrontRightDoor_Div_Summary
                try
                {
                    if (DT20.Rows.Count > 0)
                    {
                        FrontRightDoor_Div_Summary.Visible = true;
                        Gvd_FrontRightDoor.DataSource = DT20;
                        Gvd_FrontRightDoor.DataBind();
                    }
                }
                catch (Exception e20)
                {

                }

            }
            catch (Exception t20)
            {
            }


            try
            {
                DataTable DT21 = pm.getRearRightDoorData_Summry_Admin_fill(vinid);
                try
                {
                    if (DT21.Rows.Count > 0)
                    {
                        RearRightDoor_Div_Summary.Visible = true;
                        Gvd_RearRightDoor.DataSource = DT21;
                        Gvd_RearRightDoor.DataBind();
                    }
                }
                catch (Exception e21)
                {

                }
            }
            catch (Exception t21)
            {
            }

            try
            {
            DataTable DT22 = pm.getFrontRightWindowData_Summry_Admin_fill(vinid);
            // 22 FrontRightWindow_Div_Summary

            try
            {
                if (DT22.Rows.Count > 0)
                {
                    FrontRightWindow_Div_Summary.Visible = true;
                    Gvd_FrontRightWindow.DataSource = DT22;
                    Gvd_FrontRightWindow.DataBind();
                }
            }
            catch (Exception e22)
            {

            }
            }
            catch (Exception t22)
            {
            }
            try
            {
                DataTable DT23 = pm.getRearRightWindowData_Summry_Admin_fill(vinid);

                // 23 RearRightWindow_Div_Summary
                try
                {
                    if (DT23.Rows.Count > 0)
                    {
                        RearRightWindow_Div_Summary.Visible = true;
                        Gvd_RearRightWindow.DataSource = DT23;
                        Gvd_RearRightWindow.DataBind();
                    }
                }
                catch (Exception e23)
                {

                }
            }
            catch (Exception t23)
            {
            }
            try
            {
            DataTable DT24 = pm.getRearWindshieldData_Summry_Admin_fill(vinid);
            // 24 RearWindshield_Div_summary
            try
            {
                if (DT24.Rows.Count > 0)
                {
                    RearWindshield_Div_summary.Visible = true;
                    Gvd_RearWindshield.DataSource = DT24;
                    Gvd_RearWindshield.DataBind();
                }
            }
            catch (Exception e24)
            {

            }
            }
            catch (Exception t1)
            {
            }
            try
            {
                DataTable DT25 = pm.getFrontRightWheelTireData_Summry_Admin_fill(vinid);
                // 25  FrontRightWheelTire_Div_Summary
                try
                {
                    if (DT25.Rows.Count > 0)
                    {
                        FrontRightWheelTire_Div_Summary.Visible = true;
                        Gvd_FrontRightWheelTire.DataSource = DT25;
                        Gvd_FrontRightWheelTire.DataBind();
                    }
                }
                catch (Exception e25)
                {

                }

            }
            catch (Exception t1)
            {
            }

            try
            {
                DataTable DT26 = pm.getRearRightWheelTireData_Summry_Admin_fill(vinid);

                // 26 RearRightWheelTire_Div_Summary
                try
                {
                    if (DT26.Rows.Count > 0)
                    {
                        RearRightWheelTire_Div_Summary.Visible = true;
                        Gvd_RearRightWheelTire.DataSource = DT26;
                        Gvd_RearRightWheelTire.DataBind();
                    }
                }
                catch (Exception e26)
                {

                }

            }
            catch (Exception t1)
            {
            }
            try
            {
                DataTable DT27 = pm.getRightTailLightData_Summry_Admin_fill(vinid);
                // 27 RightTailLight_Div_Summary
                try
                {
                    if (DT27.Rows.Count > 0)
                    {
                        RightTailLight_Div_Summary.Visible = true;
                        Gvd_RightTailLight.DataSource = DT27;
                        Gvd_RightTailLight.DataBind();
                    }
                }
                catch (Exception e27)
                {

                }
            }
           catch (Exception t1)
           {
           }
            try
            {
                DataTable DT28 = pm.getLeftTailLightData_Summry_Admin_fill(vinid);
                // 28 LeftTailLight_Div_summary
                try
                {
                    if (DT28.Rows.Count > 0)
                    {
                        LeftTailLight_Div_summary.Visible = true;
                        Gvd_LeftTailLight.DataSource = DT28;
                        Gvd_LeftTailLight.DataBind();
                    }
                }
                catch (Exception e28)
                {

                }

            }
            catch (Exception t1)
            {
            }
            try
            {
                DataTable DT29 = pm.getRightMirrorData_Summry_Admin_fill(vinid);

                // 29 RightMirror_Div_Summary

                try
                {
                    if (DT29.Rows.Count > 0)
                    {
                        RightMirror_Div_Summary.Visible = true;
                        Gvd_RightMirror.DataSource = DT29;
                        Gvd_RightMirror.DataBind();
                    }
                }
                catch (Exception e29)
                {

                }
            }
            catch (Exception t1)
            {
            }


        }
    }

}