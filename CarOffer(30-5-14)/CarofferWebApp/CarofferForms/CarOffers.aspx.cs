using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarofferWebApp.Utilities;
using CarofferWebApp.BAl;
using System.Data;
using System.Data.SqlClient;
using AjaxControlToolkit;
using System.IO;
using System.ComponentModel;



namespace CarofferWebApp.CarofferForms
{
    public partial class CarOffers : System.Web.UI.Page
    {
        //ListtoDataTableConverter converter = new ListtoDataTableConverter();
        ImageMapBLL imgbll = new ImageMapBLL();
        VehicleSpecifications vs = new VehicleSpecifications();
        VehicleOwnerInformation voi = new VehicleOwnerInformation();
        VehicleDetails vd = new VehicleDetails();
        VehicleConditionDetails vcd = new VehicleConditionDetails();

        PropertyManager pm = new PropertyManager();
        // public static DataTable dt = new DataTable();
        public DataTable dt = new DataTable();
        public ListItem item = new ListItem();
        public DataTable dtt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {

            CalendarExtender2.EndDate = DateTime.Now;
            CalendarExtender1.EndDate = DateTime.Now;
            for (int i = 0; i < 4; i++)
            {

                Interior_COndition_RadiobtnLst.Items[i].Attributes.CssStyle.Add("margin-left", "50px");
                Mechanical_COndition_radiobtn.Items[i].Attributes.CssStyle.Add("margin-left", "50px");
            }


            if (!IsPostBack)
            {
                for (int i = 0; i < 4; i++)
                {

                    Interior_COndition_RadiobtnLst.Items[i].Attributes.CssStyle.Add("margin-left", "50px");
                    Mechanical_COndition_radiobtn.Items[i].Attributes.CssStyle.Add("margin-left", "50px");
                }
                ImageMap2.Visible = false;
                MultiView1.ActiveViewIndex = 0;
                //MultiView1.ActiveViewIndex = 3;
                //MultiView1.ActiveViewIndex =4;
                setdatatable();
                loadcheckboxlist();
                VehicleSpecification spec = (VehicleSpecification)Session["vin_data"];
                vin_txb.Text = Convert.ToString(spec.VIN);
                vs.Vin = vin_txb.Text.ToString();
                Year_txt.Text = Convert.ToString(spec.Year);
                Make_txt.Text = Convert.ToString(spec.make);
                Model_txt.Text = Convert.ToString(spec.model);
                Style_txt.Text = Convert.ToString(spec.Style);
                Series_txt.Text = " ";
                    //Convert.ToString(spec.Series);
                Transmsn_txt.Text = Convert.ToString(spec.Transmission);
                Engine_txt.Text = Convert.ToString(spec.Engine);
                Fullimage.ImageUrl = spec.full_location.ToString();
                Session["summaryimage"] = spec.full_location.ToString();
                item.Text = "Please select";
                item.Value = "0";
                Drop_Trim_style.DataSource = spec.Series;
                Drop_Trim_style.DataBind();
                Drop_Trim_style.Items.Insert(0, item);
                NoImageUploadedText.Visible = true;
                VehiclesOptionsText.Visible = true;
                //NoImageTagText.Visible = true;
            }


        }
        public void setdatatable()
        {
            dt.Columns.Add("url");
            dt.Columns.Add("Filename");
            dt.Columns.Add("VIN_ID");
            ViewState["dt"] = dt;
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            // this.MultiView1.ActiveViewIndex = 5;

            //this.MultiView1.ActiveViewIndex = 0;
        }

        public string GetNewImagepath()
        {
            string imagePath = "";
            // if(FileUpload1.HasFile)
            // {
            if (System.IO.File.Exists(Server.MapPath("~/imagess/" + FileUpload1.FileName)))
            {
                string fileName = System.IO.Path.GetFileNameWithoutExtension(FileUpload1.FileName);
                FileUpload1.SaveAs(Server.MapPath("~/imagess/" + fileName + "1" + System.IO.Path.GetExtension(FileUpload1.FileName)));
                imagePath = "~/imagess/" + fileName + "1" + System.IO.Path.GetExtension(FileUpload1.FileName);
                //return imagePath;
            }
            else
            {
                FileUpload1.SaveAs(Server.MapPath("~/imagess/" + FileUpload1.FileName));
                imagePath = "~/imagess/" + FileUpload1.FileName;
                // return imagePath;
            }
            //   }
            dt = (DataTable)ViewState["dt"];
            DataRow dr = dt.NewRow();
            dr["url"] = imagePath;
            dt.Rows.Add(dr);
            ViewState["dt"] = dt;
            return imagePath;

        }

        public void loadcheckboxlist()
        {
            DataTable dt = null;
            try
            {
                dt = pm.getdatatable_forChecklist();
            }
            catch (Exception e)
            {
            }
            ViewState["dt_chkload"] = dt;
            CheckBoxList1.DataSource = dt;

            // CheckBoxList1.DataBind();
            CheckBoxList1.DataTextField = "VEHICLE_STYLES";
            CheckBoxList1.DataValueField = "VEHICLE_STYLE_ID";
            try
            {
                if (dt.Rows.Count > 0)
                {
                    CheckBoxList1.DataBind();
                }
            }
            catch (Exception rt)
            {
            }
        }

        protected void VehiclSpecfctn_nextbtn_Click(object sender, ImageClickEventArgs e)
        {
            vs.Vin = vin_txb.Text;

            // insertion to DB
            string vin_number = vs.Vin;
            int vin_id = pm.insertvinnumber(vin_number);
            Session["id_vin"] = vin_id;



            vs.Year = Year_txt.Text.ToString();
            vs.Make = Make_txt.Text.ToString();
            vs.Model = Model_txt.Text.ToString();
            vs.Style = Style_txt.Text.ToString();
            vs.Series = Series_txt.Text.ToString();
            vs.Transmission = Transmsn_txt.Text.ToString();
            vs.Engine = Engine_txt.Text.ToString();
            vs.Trim_style = Drop_Trim_style.SelectedItem.Text.ToString();
            Session["webinfo"] = vs;
            MultiView1.ActiveViewIndex = 1;
        }

        protected void vehcl_Owner_next_Click(object sender, ImageClickEventArgs e)
        {
            voi.First_Name = FirstN_txt.Value.ToString();
            voi.Last_Name = LastN_txt.Value.ToString();
            voi.Email = Email_txt.Value.ToString();
            voi.Zip_Code = Zipcode_txt.Value.ToString();
            voi.telephone = Telephn_txt.Value.ToString();
            voi.State_Registerd = Drop_state_registrtd.SelectedItem.Text.ToString();
            voi.leasing_Financing = Drop_Leasing_financing.SelectedItem.Text.ToString();
            voi.Hear_About = Drop_HearAbout.SelectedItem.Text.ToString();
            voi.Amount_Expected = Amount_Expected_Txt.Value.ToString();
            voi.Financing_CompnyName_H = Financing_Company_HTxt.Value.ToString();
            voi.Leasing_CompnyNmae_H = Leasing_CompnyName_Htxt.Value.ToString();
            voi.Estimated_Amount_Leased_H = Estimated_Payoff_Leased_Htxt.Value.ToString();
            voi.Estimated_Amount_Financing_H = Estimated_Financing_HTxt.Value.ToString();
            // voi.Estimated_Amount_Leased_H = String.IsNullOrEmpty(Estimated_Payoff_Leased_Htxt.Value) ? 0 : Convert.ToDouble(Estimated_Payoff_Leased_Htxt.Value);
            // voi.Estimated_Amount_Financing_H = String.IsNullOrEmpty(Estimated_Financing_HTxt.Value) ? 0 : Convert.ToDouble(Estimated_Financing_HTxt.Value);
            Session["Vehicle_Owner_Info"] = voi;
            MultiView1.ActiveViewIndex = 2;
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // voi.State_Registerd = Drop_state_registrtd.SelectedItem.Value.ToString();
        }

        protected void Drop_Leasing_financing_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Drop_Leasing_financing.SelectedIndex == 1)
            {
                div_hidden_Financing.Visible = true;
                Drop_Leasing_leasing.Visible = false;
                Financing_Company_HTxt.Focus();
            }
            if (Drop_Leasing_financing.SelectedIndex == 2)
            {
                Drop_Leasing_leasing.Visible = true;
                div_hidden_Financing.Visible = false;
                Leasing_CompnyName_Htxt.Focus();
            }
            if (Drop_Leasing_financing.SelectedIndex == 0)
            {
                div_hidden_Financing.Visible = false;
                Drop_Leasing_leasing.Visible = false;

            }
            if (Drop_Leasing_financing.SelectedIndex == 3)
            {
                div_hidden_Financing.Visible = false;
                Drop_Leasing_leasing.Visible = false;
            }

        }

        protected void OriginalOwner_DDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OriginalOwner_DDL.SelectedIndex == 2)
            {
                DivHidden_Owner.Visible = true;
            }
            if (OriginalOwner_DDL.SelectedIndex == 0 || OriginalOwner_DDL.SelectedIndex == 01)
            {
                DivHidden_Owner.Visible = false;
                div_Dealer_Hidden.Visible = false;
            }
        }

        protected void Owned_90_HiddenDDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Owned_90_HiddenDDL.SelectedIndex == 1)
            {
                div_Dealer_Hidden.Visible = true;
            }

            if (Owned_90_HiddenDDL.SelectedIndex == 0 || Owned_90_HiddenDDL.SelectedIndex == 2)
            {
                div_Dealer_Hidden.Visible = false;
            }

        }

        protected void service_record_DDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (service_record_DDL.SelectedIndex == 1 || service_record_DDL.SelectedIndex == 2)
            {
                div_Records_Hidden.Visible = true;
            }
            if (service_record_DDL.SelectedIndex == 0 || service_record_DDL.SelectedIndex == 3)
            {
                div_Records_Hidden.Visible = false;
            }
        }

        protected void Insurance_claim_DDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Insurance_claim_DDL.SelectedIndex == 0 || Insurance_claim_DDL.SelectedIndex == 2 || Insurance_claim_DDL.SelectedIndex == 3)
            {
                Div_Insurance_ClaimDetails_Hidden.Visible = false;

            }
            if (Insurance_claim_DDL.SelectedIndex == 1)
            {
                Div_Insurance_ClaimDetails_Hidden.Visible = true;
            }



        }

        protected void After_Market_DDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (After_Market_DDL.SelectedIndex == 1)
            {
                Equipment_Hidden_Div.Visible = true;
            }
            if (After_Market_DDL.SelectedIndex == 0 || After_Market_DDL.SelectedIndex == 2 || After_Market_DDL.SelectedIndex == 3)
            {
                Equipment_Hidden_Div.Visible = false;

            }
        }

        protected void Performance_MOdification_DLL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Performance_MOdification_DLL.SelectedIndex == 1)
            {
                PerformaneModified_Hidden_DIv.Visible = true;
            }
            if (Performance_MOdification_DLL.SelectedIndex == 0 || Performance_MOdification_DLL.SelectedIndex == 2 || Performance_MOdification_DLL.SelectedIndex == 3)
            {
                PerformaneModified_Hidden_DIv.Visible = false;
            }
        }

        protected void Vehicle_Details_Nextbtn_Click(object sender, ImageClickEventArgs e)
        {
            vd.Vehicle_Milage = String.IsNullOrEmpty(Vehicle_Milage_txt.Value) ? 0 : Convert.ToInt32(Vehicle_Milage_txt.Value.ToString());
            vd.Miles_Atual = Miles_Actual_Acurate_DDL.SelectedItem.Text.ToString();
            vd.Exterior_Color = ExteriorColor_DDL.SelectedItem.Text.ToString();
            vd.Interior_Color = InteriorColor_DDL.SelectedItem.Text.ToString();
            vd.Vehicle_Owner = OriginalOwner_DDL.SelectedItem.Text;
            vd.Owned_90_Hidden_ddl = Owned_90_HiddenDDL.SelectedItem.Text;
            vd.Dealer_Individual_Hddl = Dealer_HiddenDDL.SelectedItem.Text.ToString();
            vd.Last_Major_Service = Convert.ToString(MajorService_Txt1.Text);
            //vd.Last_Major_Service = string.IsNullOrEmpty(MajorService_Txt1.Text) ? DateTime.Now : Convert.ToDateTime(MajorService_Txt1.Text.ToString());
            //vd.Insurance_Claim_Date = String.IsNullOrEmpty(Insurance_Date_Hidden_Txt1.Text) ? DateTime.Now :Convert.ToDateTime(Insurance_Date_Hidden_Txt1.Text.ToString());
            vd.Insurance_Claim_Date = Insurance_Date_Hidden_Txt1.Text.ToString();
            vd.Insurance_Claim_Amoount = Insurance_Claim_Amount_HiddenTxt.Value.ToString();
            // vd.Insurance_Claim_Amoount = String.IsNullOrEmpty(Insurance_Claim_Amount_HiddenTxt.Value)? 0: Convert.ToDouble(Insurance_Claim_Amount_HiddenTxt.Value.ToString());
            vd.Service_History_Record = service_record_DDL.SelectedItem.Text.ToString();
            vd.Insurance_Claim_Done = Insurance_claim_DDL.SelectedItem.Text.ToString();
            vd.Smoke_BOdour = Smoked_Bad_Odor_DDL.SelectedItem.Text;
            vd.Key_Alarm_Pad_Available = (KeySets_Alarm_DDL.SelectedItem.Text);
            vd.Taxi_Rental = Taxi_rental_DLL.SelectedItem.Text.ToString();
            vd.AfterMarket_Equipment_Installed = After_Market_DDL.SelectedItem.ToString();
            vd.AfterMarket_Equipment_Detals = Equipment_Hidden_TextArea1.Value.ToString();
            vd.Performance_Modifications = Performance_MOdification_DLL.SelectedItem.Text.ToString();
            vd.Performance_Modifications_Details = PerformaneModified_Hidden_TextArea.Value.ToString();
            Session["Vehile_detials_fill"] = vd;

            MultiView1.ActiveViewIndex = 3;
        }

        protected void Vehicle_Details_Back_Click(object sender, ImageClickEventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
        }

        protected void Vehicle_OptionFeatures_Click(object sender, ImageClickEventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {

                Interior_COndition_RadiobtnLst.Items[i].Attributes.CssStyle.Add("margin-left", "50px");
                Mechanical_COndition_radiobtn.Items[i].Attributes.CssStyle.Add("margin-left", "50px");
            }

            ViewState["FrontBumper_fill_summary"] = null;
            ViewState["Hood_fill_summary"] = null;
            ViewState["Roof_fill_summary"] = null;
            ViewState["FrontLeftFender_fill_summary"] = null;
            ViewState["FrontLeftDoor_Fill_summary"] = null;
            ViewState["RearLeftDoor_fill_summary"] = null;
            ViewState["RearLeftQuarterPanel_fill_summary"] = null;
            ViewState["FrontLeftWindow_fill_summary"] = null;
            ViewState["RearLeftWindow_fill_summary"] = null;
            ViewState["FrontWindshield_fill_summary"] = null;
            ViewState["FrontLeftWheelTire_fill_summary"] = null;
            ViewState["RearLeftWheelTire_fill_summary"] = null;
            ViewState["FrontLeftHeadlight_fill_summary"] = null;
            ViewState["FrontRightHeadlight_fill_summary"] = null;
            ViewState["LeftMirror_fill_summary"] = null;
            ViewState["Trunk_fill_summary"] = null;
            ViewState["RearBumper_fill_summary"] = null;
            ViewState["RearRightQuarterPanel_fill_summary"] = null;
            ViewState["FrontRightFender_fill_summary"] = null;
            ViewState["FrontRightDoor_fill_summary"] = null;
            ViewState["RearRightDoor_fill_summary"] = null;
            ViewState["FrontRightWindow_fill_summary"] = null;
            ViewState["RearRightWindow_fill_summary"] = null;
            ViewState["RearWindshield_fill_summary"] = null;
            ViewState["FrontRightWheelTire_fill_summary"] = null;
            ViewState["RearRightWheelTire_fill_summary"] = null;
            ViewState["RightTailLight_fill_summary"] = null;
            ViewState["LeftTailLightdriverside_fill_summary"] = null;
            ViewState["RightMirror_fill_summary"] = null;

            // session


            Session["FrontBumper"] = null;
            Session["Hood"] = null;
            Session["Roof"] = null;
            Session["FrontLeftFender"] = null;
            Session["FrontLeftDoor"] = null;
            Session["RearLeftDoor"] = null;
            Session["RearLeftQuarterPanel"] = null;
            Session["FrontLeftWindow"] = null;
            Session["RearLeftWindow"] = null;
            Session["FrontWindshield"] = null;
            Session["FrontLeftWheelTire"] = null;
            Session["RearLeftWheelTire"] = null;
            Session["FrontLeftHeadlight"] = null;
            Session["FrontRightHeadlight"] = null;
            Session["LeftMirror"] = null;
            Session["Trunk"] = null;
            Session["RearBumper"] = null;
            Session["RearRightQuarterPanel"] = null;
            Session["FrontRightFender"] = null;
            Session["FrontRightDoor"] = null;
            Session["RearRightDoor"] = null;
            Session["FrontRightWindow"] = null;
            Session["RearRightWindow"] = null;
            Session["RearWindshield"] = null;
            Session["FrontRightWheelTire"] = null;
            Session["RearRightWheelTire"] = null;
            Session["RightTailLight"] = null;
            Session["LeftTailLightdriverside"] = null;
            Session["RightMirror"] = null;




            // to be put in submit btn
            // callSp_InsertDT();
            //  InsertImagesDT();


            MultiView1.ActiveViewIndex = 4;
        }

        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {

            dt.Columns.Add("EquipmentInstalled");
            dt.Columns.Add("STATUS");
            dt.Columns.Add("VIN_ID");
            dt.Columns.Add("Check_id");
            try
            {
                for (int i = 0; i < CheckBoxList1.Items.Count; i++)
                {
                    // dt.Columns.Add("header1");
                    if (CheckBoxList1.Items[i].Selected == true)
                    {
                        DataRow dr = dt.NewRow();
                        dr["EquipmentInstalled"] = CheckBoxList1.Items[i].Text.ToString();
                        dr["STATUS"] = 0;
                        int vinid = Convert.ToInt32(Session["id_vin"]);
                        dr["VIN_ID"] = vinid;
                        dr["Check_id"] = CheckBoxList1.Items[i].Value;
                        dt.Rows.Add(dr);
                        VehiclesOptionsText.Visible = false;
                    }
                    ViewState["datatb_chklist"] = dt;
                    Session["summary_dt_fill_chkbox"] = dt;
                    GridView1.DataSource = dt;
                    ViewState["datatb"] = dt;
                    GridView1.DataBind();


                }
            }
            catch (Exception ez)
            {

            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            GridViewRow row = (GridViewRow)(((ImageButton)e.CommandSource).NamingContainer);
            try
            {

                if (e.CommandName == "Delete")
                {
                    DataTable dt = (DataTable)ViewState["datatb_chklist"];

                    string idd = e.CommandArgument.ToString();
                    int id = row.RowIndex;
                    dt.Rows.RemoveAt(id);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                    Session["summary_dt_fill_chkbox"] = dt;
                    DataTable dt2 = (DataTable)ViewState["dt_chkload"];
                    foreach (DataRow dr in dt2.Rows)
                    {

                        if (Convert.ToInt32(dr["VEHICLE_STYLE_ID"]) == Convert.ToInt32(idd))
                        {
                            for (int i = 0; i < CheckBoxList1.Items.Count; i++)
                            {
                                if (Convert.ToInt32(CheckBoxList1.Items[i].Value) == Convert.ToInt32(dr["VEHICLE_STYLE_ID"]))
                                {
                                    VehiclesOptionsText.Visible = false;
                                    CheckBoxList1.Items[i].Selected = false;

                                }
                            }
                        }

                    }
                    try
                    {
                        if (dt.Rows.Count == 0)
                        {
                            VehiclesOptionsText.Visible = true;

                        }
                    }
                    catch (Exception ex)
                    {
                        VehiclesOptionsText.Visible = true;
                    }

                }

            }
            catch (Exception ey)
            {

            }




        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void FileUpload_normal_Click(object sender, EventArgs e)
        {
            //GetNewImagepath();
            string imagePath = "";
            string filename = "";
            if (FileUpload1.HasFile)
            {
                if (System.IO.File.Exists(Server.MapPath("~/imagess/" + FileUpload1.FileName)))
                {
                    string fileName = System.IO.Path.GetFileNameWithoutExtension(FileUpload1.FileName);
                    FileUpload1.SaveAs(Server.MapPath("~/imagess/" + fileName + "1" + System.IO.Path.GetExtension(FileUpload1.FileName)));
                    imagePath = "~/imagess/" + fileName + "1" + System.IO.Path.GetExtension(FileUpload1.FileName);
                    //return imagePath;
                    filename = FileUpload1.FileName;
                }
                //else
                //{
                //    Label1.ForeColor = System.Drawing.Color.Red;
                //    Label1.Text = "Please select a file first!";
                //}  
                else
                {

                    FileUpload1.SaveAs(Server.MapPath("~/imagess/" + FileUpload1.FileName));
                    imagePath = "~/imagess/" + FileUpload1.FileName;
                    filename = FileUpload1.FileName;
                    // return imagePath;
                }
                dt = (DataTable)ViewState["dt"];
                DataRow dr = dt.NewRow();
                dr["url"] = imagePath;
                dr["Filename"] = filename;
                dr["vin_id"] = Convert.ToInt32(Session["id_vin"]);
                dt.Rows.Add(dr);
                ViewState["dt"] = dt;
                Session["dt_imagesUploaded"] = dt;

                DataTable dt1 = (DataTable)ViewState["dt"];
                GridView2.DataSource = dt1;
                GridView2.DataBind();
                int count = dt.Rows.Count;
                ImageCountText.Text = count + "  " + "<b>image successfully uploaded.";
                NoImageUploadedText.Visible = false;
                ImageCountText.Visible = true;

            }
        }

        protected void GridView2_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            GridViewRow row = (GridViewRow)(((ImageButton)e.CommandSource).NamingContainer);
            if (e.CommandName == "Delete")
            {
                DataTable dt = (DataTable)ViewState["dt"];
                int dtindex = dt.Rows.Count;
                int id = row.RowIndex;
                dt.Rows.RemoveAt(id);
                Session["dt_imagesUploaded"] = dt;
                GridView2.DataSource = dt;
                GridView2.DataBind();
                NoImageUploadedText.Visible = false;
                try
                {
                    if (dtindex == 0 || dtindex == 1)
                    {
                        NoImageUploadedText.Visible = true;
                        ImageCountText.Visible = false;
                    }
                    else
                    {
                        if (dtindex > 1)
                        {
                            dtindex = dtindex - 1;
                            ImageCountText.Text = dtindex + "  " + "image successfully uploaded.";
                            NoImageUploadedText.Visible = false;
                            ImageCountText.Visible = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    NoImageUploadedText.Visible = true;
                    ImageCountText.Visible = false;
                }
                //int count = dt.Rows.Count;

            }
        }

        protected void GridView2_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void Edit_btn_Appriaslform_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void Drop_Trim_style_SelectedIndexChanged(object sender, EventArgs e)
        {
            Series_txt.Text = Drop_Trim_style.SelectedItem.Value;
        }
        // //////////
        protected void Vehicle_condition_detail_nextbtn_Click(object sender, ImageClickEventArgs e)
        {
            vcd.InteriorConditionData = Interior_COndition_RadiobtnLst.SelectedItem.Text.ToString();
            vcd.MechanicalConditionData = Mechanical_COndition_radiobtn.SelectedItem.Text.ToString();
            VehicleSpecifications vs = (VehicleSpecifications)Session["webinfo"];
            VehicleOwnerInformation voi = (VehicleOwnerInformation)Session["Vehicle_Owner_Info"];
            Vin_valueFil_lb.Text = vs.Vin;
            Year_valueFil_lb.Text = vs.Year;
            Make_valueFil_lb.Text = vs.Make;
            Model_valueFil_lb.Text = vs.Model;
            Style_valueFil_lb.Text = vs.Style;
            Transmission_valueFil_lb.Text = vs.Transmission;
            Engine_valueFil_lb.Text = vs.Engine;
            Image2.ImageUrl = Convert.ToString(Session["summaryimage"]);

            First_name_value_lbl.Text = voi.First_Name;
            Lastname_value_lbl.Text = voi.Last_Name;
            Email_value_lbl.Text = voi.Email;
            Zip_code_value_lbl.Text = voi.Zip_Code;
            Telephone_value_Filllbl.Text = voi.telephone;
            Financing_Leasing_Filllbl.Text = voi.leasing_Financing;
            if (((Drop_Leasing_financing.SelectedItem.Text) == " Please Select ") || ((Drop_Leasing_financing.SelectedItem.Text) == " No my vehicle is paid off "))
            {
                tr_financecompname_financing.Visible = false;
                tr_financeAmount_financing.Visible = false;
                tr_leasingCompanyName.Visible = false;
                tr_LeasedAmount.Visible = false;


            }

            if (((Drop_Leasing_financing.SelectedItem.Value) == "-1") || ((Drop_Leasing_financing.SelectedItem.Value) == "2"))
            {
                tr_financecompname_financing.Visible = false;
                tr_financeAmount_financing.Visible = false;
                tr_leasingCompanyName.Visible = false;
                tr_LeasedAmount.Visible = false;

            }

            if (((Drop_Leasing_financing.SelectedItem.Value) == "0") && ((Drop_Leasing_financing.SelectedItem.Text) == " Yes I'm Financing "))
            {
                tr_leasingCompanyName.Visible = false;
                tr_LeasedAmount.Visible = false;
                FinanceCompany_name_Fill_lbl.Text = voi.Financing_CompnyName_H;
                Finance_Amount_Fill_lbl.Text = Convert.ToString(voi.Estimated_Amount_Financing_H);
                tr_financecompname_financing.Visible = true;
                tr_financeAmount_financing.Visible = true;
            }

            if (((Drop_Leasing_financing.SelectedItem.Value) == "1") && ((Drop_Leasing_financing.SelectedItem.Text) == " Yes I'm Leasing "))
            {
                tr_financecompname_financing.Visible = false;
                tr_financeAmount_financing.Visible = false;
                LeasingCompName_fill_Lbl.Text = voi.Leasing_CompnyNmae_H;
                Leased_Amount_fill_lbl.Text = Convert.ToString(voi.Estimated_Amount_Leased_H);
                tr_leasingCompanyName.Visible = true;
                tr_LeasedAmount.Visible = true;
            }
            Hear_about_value_lbl.Text = voi.Hear_About;
            if ((Amount_Expected_Txt.Value == "$.00") || (Amount_Expected_Txt.Value == ""))
            {
                tr_Expected_Amount.Visible = false;
            }
            else
            {

                Expctd_Amount_value_lbl.Text = voi.Amount_Expected;
                tr_Expected_Amount.Visible = true;
            }
            Vehicle_registrd_value_lbl.Text = voi.State_Registerd;


            //Vehicle Details
            VehicleDetails vd = (VehicleDetails)Session["Vehile_detials_fill"];
            Current_Milg_Fill_lbl.Text = Convert.ToString(vd.Vehicle_Milage);
            Actual_Accurate_Milege_fill_lbl.Text = vd.Miles_Atual;
            Exterior_color_Fill_lbl.Text = vd.Exterior_Color;
            Interior_color_Fil_lbl.Text = vd.Interior_Color;
            Original_Owner_Fill_lbl.Text = vd.Vehicle_Owner;
            //  Vehicl_90_days_fill_lbl.Text = vd.Owned_90_Hidden_ddl;

            if ((OriginalOwner_DDL.SelectedItem.Text == "No") || (OriginalOwner_DDL.SelectedItem.Value == "1"))
            {
                if ((Owned_90_HiddenDDL.SelectedItem.Text == "Yes") || (Owned_90_HiddenDDL.SelectedItem.Value == "0"))
                {

                    Purchased_from_Fill_lbl.Text = vd.Dealer_Individual_Hddl;
                    tr_Purchased_from.Visible = true;
                }
            }
            else
            {
                tr_Purchased_from.Visible = false;

            }
            // Purchased_from_Fill_lbl.Text = vd.Dealer_Individual_Hddl;

            Smoked_Bad_odor_fil_lbl.Text = vd.Smoke_BOdour;
            Servic_histry_fill_lbl.Text = vd.Service_History_Record;
            Set_2_keys_fill_lbl.Text = vd.Key_Alarm_Pad_Available;
            Taxi_rental_fill_lbl.Text = vd.Taxi_Rental;
            Insurance_claimed_fill_lbl.Text = vd.Insurance_Claim_Done;

            if ((Insurance_claim_DDL.SelectedItem.Value == "1") || (Insurance_claim_DDL.SelectedItem.Value == "2") || (Insurance_claim_DDL.SelectedItem.Text == "No") || (Insurance_claim_DDL.SelectedItem.Text == "Not Sure"))
            {
                tr_insurance_Claimed_date.Visible = false;
                tr_insurance_claimed_Amount.Visible = false;
            }

            if ((Insurance_claim_DDL.SelectedItem.Value == "0") || (Insurance_claim_DDL.SelectedItem.Text == "Yes"))
            {     // vd.Insurance_Claim_Date.ToString("dd/MM/yyyy");
                Insurance_claim_date_fill_lbl.Text = Convert.ToString(vd.Insurance_Claim_Date);
                Insurance_Claim_amount_fill_lbl.Text = Convert.ToString(vd.Insurance_Claim_Amoount);
                tr_insurance_Claimed_date.Visible = true;
                tr_insurance_claimed_Amount.Visible = true;
            }

            Performance_Modificaion_fill_lbl.Text = vd.Performance_Modifications;

            if ((Performance_MOdification_DLL.SelectedItem.Text == "No") || (Performance_MOdification_DLL.SelectedItem.Text == "Not Sure") || (Performance_MOdification_DLL.SelectedItem.Value == "1") || (Performance_MOdification_DLL.SelectedItem.Value == "2"))
            {
                tr_Performance_description.Visible = false;
            }

            if ((Performance_MOdification_DLL.SelectedItem.Text == "Yes") || (Performance_MOdification_DLL.SelectedItem.Value == "0"))
            {
                Performance_description_fill_lbl.Text = vd.Performance_Modifications_Details;

                tr_Performance_description.Visible = true;
            }


            After_Equipmnt_installed_fil_lbl.Text = vd.AfterMarket_Equipment_Installed;


            if ((After_Market_DDL.SelectedItem.Text == "No") || (After_Market_DDL.SelectedItem.Text == "Not Sure") || (After_Market_DDL.SelectedItem.Value == "1") || (After_Market_DDL.SelectedItem.Value == "2"))
            {
                tr_Equipment_description.Visible = false;
            }

            if ((After_Market_DDL.SelectedItem.Text == "Yes") || (After_Market_DDL.SelectedItem.Value == "0"))
            {
                Equipment_description_fill_lbl.Text = vd.AfterMarket_Equipment_Detals;

                tr_Equipment_description.Visible = true;
            }


            //VehicleConditionDetails

            DataTable DT1 = (DataTable)ViewState["FrontBumper_fill_summary"];
            DataTable DT2 = (DataTable)ViewState["Hood_fill_summary"];
            DataTable DT3 = (DataTable)ViewState["Roof_fill_summary"];
            DataTable DT4 = (DataTable)ViewState["FrontLeftFender_fill_summary"];
            DataTable DT5 = (DataTable)ViewState["FrontLeftDoor_Fill_summary"];
            DataTable DT6 = (DataTable)ViewState["RearLeftDoor_fill_summary"];
            DataTable DT7 = (DataTable)ViewState["RearLeftQuarterPanel_fill_summary"];
            DataTable DT8 = (DataTable)ViewState["FrontLeftWindow_fill_summary"];
            DataTable DT9 = (DataTable)ViewState["RearLeftWindow_fill_summary"];
            DataTable DT10 = (DataTable)ViewState["FrontWindshield_fill_summary"];
            DataTable DT11 = (DataTable)ViewState["FrontLeftWheelTire_fill_summary"];
            DataTable DT12 = (DataTable)ViewState["RearLeftWheelTire_fill_summary"];
            DataTable DT13 = (DataTable)ViewState["FrontLeftHeadlight_fill_summary"];
            DataTable DT14 = (DataTable)ViewState["FrontRightHeadlight_fill_summary"];
            DataTable DT15 = (DataTable)ViewState["LeftMirror_fill_summary"];
            DataTable DT16 = (DataTable)ViewState["Trunk_fill_summary"];
            DataTable DT17 = (DataTable)ViewState["RearBumper_fill_summary"];
            DataTable DT18 = (DataTable)ViewState["RearRightQuarterPanel_fill_summary"];
            DataTable DT19 = (DataTable)ViewState["FrontRightFender_fill_summary"];
            DataTable DT20 = (DataTable)ViewState["FrontRightDoor_fill_summary"];
            DataTable DT21 = (DataTable)ViewState["RearRightDoor_fill_summary"];
            DataTable DT22 = (DataTable)ViewState["FrontRightWindow_fill_summary"];
            DataTable DT23 = (DataTable)ViewState["RearRightWindow_fill_summary"];
            DataTable DT24 = (DataTable)ViewState["RearWindshield_fill_summary"];
            DataTable DT25 = (DataTable)ViewState["FrontRightWheelTire_fill_summary"];
            DataTable DT26 = (DataTable)ViewState["RearRightWheelTire_fill_summary"];
            DataTable DT27 = (DataTable)ViewState["RightTailLight_fill_summary"];
            DataTable DT28 = (DataTable)ViewState["LeftTailLightdriverside_fill_summary"];
            DataTable DT29 = (DataTable)ViewState["RightMirror_fill_summary"];

            // 1 FrontBumper
            try
            {
                if (DT1.Rows.Count > 0)
                {
                    //Fb_Div_Summary.Visible = true;
                    Gvd_FrontBumper.DataSource = DT1;
                    Gvd_FrontBumper.DataBind();
                }
                else
                {
                   // Fb_Div_Summary.Visible = false;
                    Gvd_FrontBumper.DataSource = DT1;
                    Gvd_FrontBumper.DataBind();
                }
            }
            catch (Exception e1)
            {

            }

            // 2. hood
            try
            {
                if (DT2.Rows.Count > 0)
                {
                   // Hood_Div_Summary.Visible = true;
                    Gvd_Hood.DataSource = DT2;
                    Gvd_Hood.DataBind();
                }
                else
                {
                   // Hood_Div_Summary.Visible = false;
                    Gvd_Hood.DataSource = DT2;
                    Gvd_Hood.DataBind();
                }
            }
            catch (Exception e2)
            {

            }


            // 3 Roof
            try
            {
                if (DT3.Rows.Count > 0)
                {
                  //  Roof_Div_Summary.Visible = true;
                    Gvd_Rooof.DataSource = DT3;
                    Gvd_Rooof.DataBind();
                }
                else
                {
                   // Roof_Div_Summary.Visible = false;
                    Gvd_Rooof.DataSource = DT3;
                    Gvd_Rooof.DataBind();
                }
            }
            catch (Exception e3)
            {

            }

            // 4    FrontLeftFender

            try
            {
                if (DT4.Rows.Count > 0)
                {
                   // Front_Left_fender_Div_Summary.Visible = true;
                    Gvd_Front_left_Fender.DataSource = DT4;
                    Gvd_Front_left_Fender.DataBind();
                }
                else
                {
                   // Front_Left_fender_Div_Summary.Visible = false;
                    Gvd_Front_left_Fender.DataSource = DT4;
                    Gvd_Front_left_Fender.DataBind();
                }
            }
            catch (Exception e4)
            {

            }


            // 5.FrontLeftDoor

            try
            {
                if (DT5.Rows.Count > 0)
                {
                   // Front_Left_Door_Div_Summary.Visible = true;
                    Gvd_FrontLeftDoor.DataSource = DT5;
                    Gvd_FrontLeftDoor.DataBind();
                }
                else
                {
                   // Front_Left_Door_Div_Summary.Visible = false;
                    Gvd_FrontLeftDoor.DataSource = DT5;
                    Gvd_FrontLeftDoor.DataBind();
                }
            }
            catch (Exception e5)
            {

            }


            // 6 RearLeftDoor

            try
            {
                if (DT6.Rows.Count > 0)
                {
                   // RearLeftDoor_Div_Summary.Visible = true;
                    Gvd_Rear_Left_door.DataSource = DT6;
                    Gvd_Rear_Left_door.DataBind();
                }
                else
                {
                   // RearLeftDoor_Div_Summary.Visible = false;
                    Gvd_Rear_Left_door.DataSource = DT6;
                    Gvd_Rear_Left_door.DataBind();
                }
            }
            catch (Exception e6)
            {

            }


            // 7 RearLeftQuarterPanel_Div_Summary
            try
            {
                if (DT7.Rows.Count > 0)
                {
                   // RearLeftQuarterPanel_Div_Summary.Visible = true;
                    Gvd_RearLeftQuarterPanel.DataSource = DT7;
                    Gvd_RearLeftQuarterPanel.DataBind();
                }
                else
                {
                  //  RearLeftQuarterPanel_Div_Summary.Visible = false;
                    Gvd_RearLeftQuarterPanel.DataSource = DT7;
                    Gvd_RearLeftQuarterPanel.DataBind();
                }
            }
            catch (Exception e7)
            {

            }


            // 8 FrontLeftWindow

            try
            {
                if (DT8.Rows.Count > 0)
                {
                   // FrontLeftWindow_Div_summary.Visible = true;
                    Gvd_FrontLeftWindow.DataSource = DT8;
                    Gvd_FrontLeftWindow.DataBind();
                }
                else
                {
                   // FrontLeftWindow_Div_summary.Visible = false;
                    Gvd_FrontLeftWindow.DataSource = DT8;
                    Gvd_FrontLeftWindow.DataBind();
                }

            }
            catch (Exception e8)
            {

            }


            // 9 RearLeftWindow_Div_summary

            try
            {
                if (DT9.Rows.Count > 0)
                {
                    //RearLeftWindow_Div_summary.Visible = true;
                    Gvd_RearLeftWindow.DataSource = DT9;
                    Gvd_RearLeftWindow.DataBind();
                }
                else
                {
                    //RearLeftWindow_Div_summary.Visible = false;
                    Gvd_RearLeftWindow.DataSource = DT9;
                    Gvd_RearLeftWindow.DataBind();
                }

            }
            catch (Exception e9)
            {

            }


            // 10 FrontWindshield_Div_summary

            try
            {
                if (DT10.Rows.Count > 0)
                {
                   // FrontWindshield_Div_summary.Visible = true;
                    Gvd_FrontWindshield.DataSource = DT10;
                    Gvd_FrontWindshield.DataBind();
                }
                else
                {
                   // FrontWindshield_Div_summary.Visible = false;
                    Gvd_FrontWindshield.DataSource = DT10;
                    Gvd_FrontWindshield.DataBind();
                }
            }
            catch (Exception e10)
            {

            }

            // 11.FrontLeftWheelTire_Div_summary

            try
            {
                if (DT11.Rows.Count > 0)
                {
                    //FrontLeftWheelTire_Div_summary.Visible = true;
                    Gvd_FrontLeftWheelTire.DataSource = DT11;
                    Gvd_FrontLeftWheelTire.DataBind();
                }
                else
                {
                    //FrontLeftWheelTire_Div_summary.Visible = false;
                    Gvd_FrontLeftWheelTire.DataSource = DT11;
                    Gvd_FrontLeftWheelTire.DataBind();
                }
            }
            catch (Exception e11)
            {

            }


            // 12 RearLeftWheelTire_Div_Summary
            try
            {
                if (DT12.Rows.Count > 0)
                {
                   // RearLeftWheelTire_Div_Summary.Visible = true;
                    Gvd_RearLeftWheelTire.DataSource = DT12;
                    Gvd_RearLeftWheelTire.DataBind();
                }
                else
                {
                    //RearLeftWheelTire_Div_Summary.Visible = false;
                    Gvd_RearLeftWheelTire.DataSource = DT12;
                    Gvd_RearLeftWheelTire.DataBind();
                }
            }
            catch (Exception e12)
            {

            }

            // 13 FrontLeftHeadligh_Div_Summary
            try
            {
                if (DT13.Rows.Count > 0)
                {
                    //FrontLeftHeadligh_Div_Summary.Visible = true;
                    Gvd_FrontLeftHeadligh.DataSource = DT13;
                    Gvd_FrontLeftHeadligh.DataBind();
                }
                else
                {
                    //FrontLeftHeadligh_Div_Summary.Visible = false;
                    Gvd_FrontLeftHeadligh.DataSource = DT13;
                    Gvd_FrontLeftHeadligh.DataBind();
                }
            }
            catch (Exception e13)
            {

            }


            // 14 FrontRighttHeadligh_Div_Summary

            try
            {
                if (DT14.Rows.Count > 0)
                {
                   // FrontRighttHeadligh_Div_Summary.Visible = true;
                    Gvd_FrontrightHeadlight.DataSource = DT14;
                    Gvd_FrontrightHeadlight.DataBind();
                }
                else
                {
                   // FrontRighttHeadligh_Div_Summary.Visible = false;
                    Gvd_FrontrightHeadlight.DataSource = DT14;
                    Gvd_FrontrightHeadlight.DataBind();
                }
            }
            catch (Exception e14)
            {

            }

            // 15 LeftMirror_Div_Summary
            try
            {
                if (DT15.Rows.Count > 0)
                {
                   // LeftMirror_Div_Summary.Visible = true;
                    Gvd_LeftMirror.DataSource = DT15;
                    Gvd_LeftMirror.DataBind();
                }
                else
                {
                   // LeftMirror_Div_Summary.Visible = false;
                    Gvd_LeftMirror.DataSource = DT15;
                    Gvd_LeftMirror.DataBind();
                }
            }
            catch (Exception e15)
            {

            }

            // 16 Trunk_Div_Summary
            try
            {
                if (DT16.Rows.Count > 0)
                {
                    //Trunk_Div_Summary.Visible = true;
                    Gvd_Trunk.DataSource = DT16;
                    Gvd_Trunk.DataBind();
                }
                else
                {
                   // Trunk_Div_Summary.Visible = false;
                    Gvd_Trunk.DataSource = DT16;
                    Gvd_Trunk.DataBind();
                }
            }
            catch (Exception e16)
            {

            }

            // 17 RearBumper_Div_Summary
            try
            {
                if (DT17.Rows.Count > 0)
                {
                   // RearBumper_Div_Summary.Visible = true;
                    Gvd_RearBumper.DataSource = DT17;
                    Gvd_RearBumper.DataBind();
                }
                else
                {
                    //RearBumper_Div_Summary.Visible = false;
                    Gvd_RearBumper.DataSource = DT17;
                    Gvd_RearBumper.DataBind();
                }
            }
            catch (Exception e17)
            {

            }

            // 18 RearRightQuarterPanel_Div_Summary
            try
            {
                if (DT18.Rows.Count > 0)
                {
                   // RearRightQuarterPanel_Div_Summary.Visible = true;
                    Gvd_RearRightQuarterPanel.DataSource = DT18;
                    Gvd_RearRightQuarterPanel.DataBind();
                }
                else
                {
                   // RearRightQuarterPanel_Div_Summary.Visible = false;
                    Gvd_RearRightQuarterPanel.DataSource = DT18;
                    Gvd_RearRightQuarterPanel.DataBind();
                }
            }
            catch (Exception e18)
            {

            }


            // 19 FrontRightFender_Div_Summary
            try
            {
                if (DT19.Rows.Count > 0)
                {
                    //FrontRightFender_Div_Summary.Visible = true;
                    Gvd_FrontRightFender.DataSource = DT19;
                    Gvd_FrontRightFender.DataBind();
                }
                else
                {
                   // FrontRightFender_Div_Summary.Visible = false;
                    Gvd_FrontRightFender.DataSource = DT19;
                    Gvd_FrontRightFender.DataBind();
                }
            }
            catch (Exception e19)
            {

            }

            // 20 FrontRightDoor_Div_Summary
            try
            {
                if (DT20.Rows.Count > 0)
                {
                   // FrontRightDoor_Div_Summary.Visible = true;
                    Gvd_FrontRightDoor.DataSource = DT20;
                    Gvd_FrontRightDoor.DataBind();
                }
                else
                {
                   // FrontRightDoor_Div_Summary.Visible = false;
                    Gvd_FrontRightDoor.DataSource = DT20;
                    Gvd_FrontRightDoor.DataBind();
                }
            }
            catch (Exception e20)
            {

            }

            // 21 RearRightDoor_Div_Summary

            try
            {
                if (DT21.Rows.Count > 0)
                {
                   // RearRightDoor_Div_Summary.Visible = true;
                    Gvd_RearRightDoor.DataSource = DT21;
                    Gvd_RearRightDoor.DataBind();
                }
                else
                {
                   // RearRightDoor_Div_Summary.Visible = false;
                    Gvd_RearRightDoor.DataSource = DT21;
                    Gvd_RearRightDoor.DataBind();

                }
            }
            catch (Exception e21)
            {

            }


            // 22 FrontRightWindow_Div_Summary

            try
            {
                if (DT22.Rows.Count > 0)
                {
                   // FrontRightWindow_Div_Summary.Visible = true;
                    Gvd_FrontRightWindow.DataSource = DT22;
                    Gvd_FrontRightWindow.DataBind();
                }
                else
                {
                   // FrontRightWindow_Div_Summary.Visible = false;
                    Gvd_FrontRightWindow.DataSource = DT22;
                    Gvd_FrontRightWindow.DataBind();
                }

            }
            catch (Exception e22)
            {

            }

            // 23 RearRightWindow_Div_Summary
            try
            {
                if (DT23.Rows.Count > 0)
                {
                   // RearRightWindow_Div_Summary.Visible = true;
                    Gvd_RearRightWindow.DataSource = DT23;
                    Gvd_RearRightWindow.DataBind();
                }
                else
                {
                   // RearRightWindow_Div_Summary.Visible = false;
                    Gvd_RearRightWindow.DataSource = DT23;
                    Gvd_RearRightWindow.DataBind();
                }
            }
            catch (Exception e23)
            {

            }

            // 24 RearWindshield_Div_summary
            try
            {
                if (DT24.Rows.Count > 0)
                {
                   // RearWindshield_Div_summary.Visible = true;
                    Gvd_RearWindshield.DataSource = DT24;
                    Gvd_RearWindshield.DataBind();
                }
                else
                {
                   // RearWindshield_Div_summary.Visible = false;
                    Gvd_RearWindshield.DataSource = DT24;
                    Gvd_RearWindshield.DataBind();
                }
            }
            catch (Exception e24)
            {

            }

            // 25  FrontRightWheelTire_Div_Summary
            try
            {
                if (DT25.Rows.Count > 0)
                {
                  //  FrontRightWheelTire_Div_Summary.Visible = true;
                    Gvd_FrontRightWheelTire.DataSource = DT25;
                    Gvd_FrontRightWheelTire.DataBind();
                }
                else
                {
                    //FrontRightWheelTire_Div_Summary.Visible = false;
                    Gvd_FrontRightWheelTire.DataSource = DT25;
                    Gvd_FrontRightWheelTire.DataBind();
                }
            }
            catch (Exception e25)
            {

            }

            // 26 RearRightWheelTire_Div_Summary
            try
            {
                if (DT26.Rows.Count > 0)
                {
                   // RearRightWheelTire_Div_Summary.Visible = true;
                    Gvd_RearRightWheelTire.DataSource = DT26;
                    Gvd_RearRightWheelTire.DataBind();
                }
                else
                {
                   // RearRightWheelTire_Div_Summary.Visible = false;
                    Gvd_RearRightWheelTire.DataSource = DT26;
                    Gvd_RearRightWheelTire.DataBind();
                }
            }
            catch (Exception e26)
            {

            }

            // 27 RightTailLight_Div_Summary
            try
            {
                if (DT27.Rows.Count > 0)
                {
                   // RightTailLight_Div_Summary.Visible = true;
                    Gvd_RightTailLight.DataSource = DT27;
                    Gvd_RightTailLight.DataSource = DT27;
                    Gvd_RightTailLight.DataBind();
                }
                else
                {
                  //  RightTailLight_Div_Summary.Visible = false;
                    Gvd_RightTailLight.DataSource = DT27;
                    Gvd_RightTailLight.DataSource = DT27;
                    Gvd_RightTailLight.DataBind();
                }

            }
            catch (Exception e27)
            {

            }

            // 28 LeftTailLight_Div_summary
            try
            {
                if (DT28.Rows.Count > 0)
                {
                   // LeftTailLight_Div_summary.Visible = true;
                    Gvd_LeftTailLight.DataSource = DT28;
                    Gvd_LeftTailLight.DataBind();
                }
                else
                {
                   // LeftTailLight_Div_summary.Visible = false;
                    Gvd_LeftTailLight.DataSource = DT28;
                    Gvd_LeftTailLight.DataBind();
                }
            }
            catch (Exception e28)
            {

            }

            // 29 RightMirror_Div_Summary

            try
            {
                if (DT29.Rows.Count > 0)
                {
                   // RightMirror_Div_Summary.Visible = true;
                    Gvd_RightMirror.DataSource = DT29;
                    Gvd_RightMirror.DataBind();
                }
                else
                {
                   // RightMirror_Div_Summary.Visible = false;
                    Gvd_RightMirror.DataSource = DT29;
                    Gvd_RightMirror.DataBind();
                }

            }
            catch (Exception e29)
            {

            }

            try
            {
                if ((DT1.Rows.Count == 0 || DT1 == null) &&
                        (DT2.Rows.Count == 0 || DT2 == null) &&
                        (DT3.Rows.Count == 0 || DT3 == null) &&
                        (DT4.Rows.Count == 0 || DT4 == null) &&
                        (DT5.Rows.Count == 0 || DT5 == null) &&
                         (DT6.Rows.Count == 0 || DT6 == null) &&
                        (DT7.Rows.Count == 0 || DT7 == null) &&
                        (DT8.Rows.Count == 0 || DT8 == null) &&
                        (DT9.Rows.Count == 0 || DT9 == null) &&
                        (DT10.Rows.Count == 0 || DT10 == null) &&
                        (DT11.Rows.Count == 0 || DT11 == null) &&
                        (DT12.Rows.Count == 0 || DT12 == null) &&
                        (DT13.Rows.Count == 0 || DT13 == null) &&
                        (DT14.Rows.Count == 0 || DT14 == null) &&
                        (DT15.Rows.Count == 0 || DT15 == null) &&
                        (DT16.Rows.Count == 0 || DT16 == null) &&
                        (DT17.Rows.Count == 0 || DT17 == null) &&
                        (DT18.Rows.Count == 0 || DT18 == null) &&
                        (DT19.Rows.Count == 0 || DT19 == null) &&
                        (DT20.Rows.Count == 0 || DT20 == null) &&
                        (DT21.Rows.Count == 0 || DT21 == null) &&
                        (DT22.Rows.Count == 0 || DT22 == null) &&
                        (DT23.Rows.Count == 0 || DT23 == null) &&
                        (DT24.Rows.Count == 0 || DT24 == null) &&
                        (DT25.Rows.Count == 0 || DT25 == null) &&
                        (DT26.Rows.Count == 0 || DT26 == null) &&
                        (DT27.Rows.Count == 0 || DT27 == null) &&
                        (DT28.Rows.Count == 0 || DT28 == null) &&
                        (DT29.Rows.Count == 0 || DT29 == null))
                {
                    noselection.Visible = true;
                    hadselection.Visible = false;
                }

                else
                {
                    noselection.Visible = false;
                    hadselection.Visible = true;
                }

            }
            catch (Exception et)
            {
                noselection.Visible = true;
                hadselection.Visible = false;
            }

            // show mech&interior condition of radio btns to summary page
            vcd.InteriorConditionData = Interior_COndition_RadiobtnLst.SelectedItem.Text.ToString();

            vcd.MechanicalConditionData = Mechanical_COndition_radiobtn.SelectedItem.Text.ToString();
            OverallinteriorconditionText.Text = vcd.InteriorConditionData;
            OverallmechanicalconditionText.Text = vcd.MechanicalConditionData;            

            getOptionsfeaturesData();
            getVehiclePhotos();
            getConditionDetailsData();
            MultiView1.ActiveViewIndex = 5;



        }

        protected void Vehicle_optionFeatures_Back_Click(object sender, ImageClickEventArgs e)
        {
            MultiView1.ActiveViewIndex = 2;
        }

        protected void Vehicle_condition_detail_Backbtn_Click(object sender, ImageClickEventArgs e)
        {
            ViewState["FrontBumper_fill_summary"] =null;
            ViewState["Hood_fill_summary"]=null;
            ViewState["Roof_fill_summary"] = null;
            ViewState["FrontLeftFender_fill_summary"] = null;
            ViewState["FrontLeftDoor_Fill_summary"] = null;
            ViewState["RearLeftDoor_fill_summary"] = null;
            ViewState["RearLeftQuarterPanel_fill_summary"] = null;
            ViewState["FrontLeftWindow_fill_summary"] = null;
            ViewState["RearLeftWindow_fill_summary"] = null;
            ViewState["FrontWindshield_fill_summary"] = null;
            ViewState["FrontLeftWheelTire_fill_summary"] = null;
            ViewState["RearLeftWheelTire_fill_summary"] = null;
            ViewState["FrontLeftHeadlight_fill_summary"] = null;
            ViewState["FrontRightHeadlight_fill_summary"] = null;
            ViewState["LeftMirror_fill_summary"] = null;
            ViewState["Trunk_fill_summary"] = null;
            ViewState["RearBumper_fill_summary"] = null;
            ViewState["RearRightQuarterPanel_fill_summary"] = null;
            ViewState["FrontRightFender_fill_summary"] = null;
            ViewState["FrontRightDoor_fill_summary"]=null;
            ViewState["RearRightDoor_fill_summary"] = null;
            ViewState["FrontRightWindow_fill_summary"] = null;
            ViewState["RearRightWindow_fill_summary"] = null;
            ViewState["RearWindshield_fill_summary"] = null;
            ViewState["FrontRightWheelTire_fill_summary"] = null;
            ViewState["RearRightWheelTire_fill_summary"] = null;
            ViewState["RightTailLight_fill_summary"] = null;
            ViewState["LeftTailLightdriverside_fill_summary"] = null;
            ViewState["RightMirror_fill_summary"] = null;

            // session


Session["FrontBumper"]=null;
Session["Hood"]=null;
Session["Roof"]=null;
Session["FrontLeftFender"]=null;
Session["FrontLeftDoor"]=null;

Session["RearLeftDoor"]=null;
Session["RearLeftQuarterPanel"]=null;
Session["FrontLeftWindow"]=null;
Session["RearLeftWindow"]=null;
 Session["FrontWindshield"]=null;
Session["FrontLeftWheelTire"]=null;
Session["RearLeftWheelTire"]=null;
Session["FrontLeftHeadlight"]=null;
Session["FrontRightHeadlight"]=null;
Session["LeftMirror"]=null;
Session["Trunk"]=null;
Session["RearBumper"]=null;
Session["RearRightQuarterPanel"]=null;
Session["FrontRightFender"]=null;
Session["FrontRightDoor"]=null;
Session["RearRightDoor"]=null;
Session["FrontRightWindow"]=null;
Session["RearRightWindow"]=null;
 Session["RearWindshield"]=null;
Session["FrontRightWheelTire"]=null;
Session["RearRightWheelTire"]=null;
 Session["RightTailLight"]=null;
Session["LeftTailLightdriverside"]=null;
Session["RightMirror"] = null;




            MultiView1.ActiveViewIndex = 3;

        }

        public void getConditionDetailsData()
        {




        }

        public void getVehiclePhotos()
        {
            DataTable dt = (DataTable)Session["dt_imagesUploaded"];
            string htmlStr = "";
            try
            {
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        string path = Convert.ToString(dr["url"]);
                        path = path.Replace("~/", " ../");
                        htmlStr += "<img src=\"" + path + "\" style=\"width:10%;margin-bottom:1%;\"/>&nbsp;&nbsp;&nbsp;";
                        imagediv.InnerHtml = htmlStr;

                    }
                }
                else
                {
                    htmlStr = "";
                    htmlStr+="<label id=\"imagetxt\">You have not uploaded photos yet. Uploading photos could make a difference in the value of your vehicle.</label>";


                   // NoImageTagText.Visible = true;
                    imagediv.InnerHtml = htmlStr;
                    

                }

               
            }
            catch (Exception e)
            {
               // htmlStr = "";
                //NoImageTagText.Visible = true;
                //imagediv.InnerHtml = htmlStr;
                
            }

            if (dt == null)
            {
                htmlStr = "";
                htmlStr += "<label id=\"imagetxt\">You have not uploaded photos yet. Uploading photos could make a difference in the value of your vehicle.</label>";
                imagediv.InnerHtml = htmlStr;
            }
           
        }

        public void getOptionsfeaturesData()
        {
            string htmlStr = "";
            

            dtt = (DataTable)Session["summary_dt_fill_chkbox"];
               try
              {
                if (dtt.Rows.Count > 0)
                {
                    htmlStr = "<centre><table style=\"width:80%;margin-top:1%;\">";
                    DataTable dt1 = new DataTable();
                    dt1.Columns.Add("Head1");
                    dt1.Columns.Add("Head2");
                    DataRow dr;
                    for (int i = 0; i < dtt.Rows.Count; i++)
                    {

                        if (i % 2 == 0)
                        {
                            dr = dt1.NewRow();

                            dr["Head1"] = dtt.Rows[i][0].ToString();
                            dt1.Rows.Add(dr);
                            ViewState["count"] = dt1.Rows.Count;
                        }

                    //        dr["Head1"] = dtt.Rows[i].ToString();

                        else
                        {
                            int count = Convert.ToInt32(ViewState["count"]);
                            dr = dt1.Rows[count - 1];

                            dr["Head2"] = dtt.Rows[i][0].ToString();
                            // dt1.Rows.Add(dr);
                        }

                    }

                    //   grid_options.DataSource = dt1;
                    //  grid_options.DataBind();

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
                    htmlStr += "</table></centre>";
                    maindiv_tale.InnerHtml = htmlStr;
                }
                else
                {
                    VehicleOptFeaturesNoSelectionText.Visible =false;
                    htmlStr = "";
                    htmlStr += "<label id=\"vehicleoption\">You have have not selected any options.<br />Our appraisal could be thousands of dollars higher or lower based on this information alone.<br />Click the “edit” button if you would like to go back and correct step #4.</label>";



                  //  htmlStr += "</table></centre>";

                    maindiv_tale.InnerHtml = htmlStr;
                }
            }
            catch (Exception e)
            {
            }
            if (dtt == null)
            {
                VehicleOptFeaturesNoSelectionText.Visible = true;
            }
        }

        protected void Edit_btn_OwnerInformation_Click(object sender, ImageClickEventArgs e)
        {
            vehcl_Owner_next.Visible = false;
            vehicle_ownerBack_anchorbtn.Visible = false;
            vehcl_Owner_Update_btn.Visible = true;
            MultiView1.ActiveViewIndex = 1;

        }

        protected void vehcl_Owner_Update_btn_Click1(object sender, ImageClickEventArgs e)
        {
            VehicleOwnerInformation voi = new VehicleOwnerInformation();
            vehcl_Owner_next.Visible = true;
            vehicle_ownerBack_anchorbtn.Visible = true;
            vehcl_Owner_Update_btn.Visible = false;

            //code from next btn 
            voi.First_Name = FirstN_txt.Value.ToString();
            voi.Last_Name = LastN_txt.Value.ToString();
            voi.Email = Email_txt.Value.ToString();
            voi.Zip_Code = Zipcode_txt.Value.ToString();
            voi.telephone = Telephn_txt.Value.ToString();
            voi.State_Registerd = Drop_state_registrtd.SelectedItem.Text.ToString();
            voi.leasing_Financing = Drop_Leasing_financing.SelectedItem.Text.ToString();
            voi.Hear_About = Drop_HearAbout.SelectedItem.Text.ToString();
            voi.Amount_Expected = Amount_Expected_Txt.Value.ToString();
            voi.Financing_CompnyName_H = Financing_Company_HTxt.Value.ToString();
            voi.Leasing_CompnyNmae_H = Leasing_CompnyName_Htxt.Value.ToString();
            voi.Estimated_Amount_Leased_H = Estimated_Payoff_Leased_Htxt.Value.ToString();
            voi.Estimated_Amount_Financing_H = Estimated_Financing_HTxt.Value.ToString();
            // voi.Estimated_Amount_Leased_H = String.IsNullOrEmpty(Estimated_Payoff_Leased_Htxt.Value) ? 0 : Convert.ToDouble(Estimated_Payoff_Leased_Htxt.Value);
            // voi.Estimated_Amount_Financing_H = String.IsNullOrEmpty(Estimated_Financing_HTxt.Value) ? 0 : Convert.ToDouble(Estimated_Financing_HTxt.Value);
            Session["Vehicle_Owner_Info"] = voi;
            First_name_value_lbl.Text = voi.First_Name;
            Lastname_value_lbl.Text = voi.Last_Name;
            Email_value_lbl.Text = voi.Email;
            Zip_code_value_lbl.Text = voi.Zip_Code;
            Telephone_value_Filllbl.Text = voi.telephone;
            Financing_Leasing_Filllbl.Text = voi.leasing_Financing;
            if (((Drop_Leasing_financing.SelectedItem.Text) == " Please Select ") || ((Drop_Leasing_financing.SelectedItem.Text) == " No my vehicle is paid off "))
            {
                tr_financecompname_financing.Visible = false;
                tr_financeAmount_financing.Visible = false;
                tr_leasingCompanyName.Visible = false;
                tr_LeasedAmount.Visible = false;


            }

            if (((Drop_Leasing_financing.SelectedItem.Value) == "-1") || ((Drop_Leasing_financing.SelectedItem.Value) == "2"))
            {
                tr_financecompname_financing.Visible = false;
                tr_financeAmount_financing.Visible = false;
                tr_leasingCompanyName.Visible = false;
                tr_LeasedAmount.Visible = false;

            }

            if (((Drop_Leasing_financing.SelectedItem.Value) == "0") && ((Drop_Leasing_financing.SelectedItem.Text) == " Yes I'm Financing "))
            {
                tr_leasingCompanyName.Visible = false;
                tr_LeasedAmount.Visible = false;
                FinanceCompany_name_Fill_lbl.Text = voi.Financing_CompnyName_H;
                Finance_Amount_Fill_lbl.Text = Convert.ToString(voi.Estimated_Amount_Financing_H);
                tr_financecompname_financing.Visible = true;
                tr_financeAmount_financing.Visible = true;
            }

            if (((Drop_Leasing_financing.SelectedItem.Value) == "1") && ((Drop_Leasing_financing.SelectedItem.Text) == " Yes I'm Leasing "))
            {
                tr_financecompname_financing.Visible = false;
                tr_financeAmount_financing.Visible = false;
                LeasingCompName_fill_Lbl.Text = voi.Leasing_CompnyNmae_H;
                Leased_Amount_fill_lbl.Text = Convert.ToString(voi.Estimated_Amount_Leased_H);
                tr_leasingCompanyName.Visible = true;
                tr_LeasedAmount.Visible = true;
            }
            Hear_about_value_lbl.Text = voi.Hear_About;
            if ((Amount_Expected_Txt.Value == "$.00") || (Amount_Expected_Txt.Value == ""))
            {
                tr_Expected_Amount.Visible = false;
            }
            else
            {

                Expctd_Amount_value_lbl.Text = voi.Amount_Expected;
                tr_Expected_Amount.Visible = true;
            }
            Vehicle_registrd_value_lbl.Text = voi.State_Registerd;
            // VehicleOwnerInformation voi = (VehicleOwnerInformation)Session["Vehicle_Owner_Info"];



            MultiView1.ActiveViewIndex = 5;
        }

        protected void VehicleDetails_editbtn_Click(object sender, ImageClickEventArgs e)
        {

            Vehicle_Details_Nextbtn.Visible = false;
            Vehicle_Details_Back.Visible = false;
            VehicleDetails_Updatebtn.Visible = true;
            MultiView1.ActiveViewIndex = 2;

        }

        protected void VehicleDetails_Updatebtn_Click(object sender, ImageClickEventArgs e)
        {
            //if((Interior_COndition_RadiobtnLst.SelectedItem.Text=="Excellent") || (Interior_COndition_RadiobtnLst.SelectedItem.Value=="Excellent"))
            //{

            //}
            VehicleDetails vd = new VehicleDetails();
            VehicleDetails_Updatebtn.Visible = false;
            Vehicle_Details_Nextbtn.Visible = true;
            Vehicle_Details_Back.Visible = true;
            vd.Vehicle_Milage = String.IsNullOrEmpty(Vehicle_Milage_txt.Value) ? 0 : Convert.ToInt32(Vehicle_Milage_txt.Value.ToString());
            vd.Miles_Atual = Miles_Actual_Acurate_DDL.SelectedItem.Text.ToString();
            vd.Exterior_Color = ExteriorColor_DDL.SelectedItem.Text.ToString();
            vd.Interior_Color = InteriorColor_DDL.SelectedItem.Text.ToString();
            vd.Vehicle_Owner = OriginalOwner_DDL.SelectedItem.Text;
            vd.Owned_90_Hidden_ddl = Owned_90_HiddenDDL.SelectedItem.Text;
            vd.Dealer_Individual_Hddl = Dealer_HiddenDDL.SelectedItem.Text.ToString();
            vd.Last_Major_Service = Convert.ToString(MajorService_Txt1.Text);
            // vd.Last_Major_Service = string.IsNullOrEmpty(MajorService_Txt1.Text) ? DateTime.Now : Convert.ToDateTime(MajorService_Txt1.Text.ToString());
            // vd.Insurance_Claim_Date = String.IsNullOrEmpty(Insurance_Date_Hidden_Txt1.Text) ? DateTime.Now :Convert.ToDateTime(Insurance_Date_Hidden_Txt1.Text.ToString());
            vd.Insurance_Claim_Date = Convert.ToString(Insurance_Date_Hidden_Txt1.Text);
            vd.Insurance_Claim_Amoount = Convert.ToString(Insurance_Claim_Amount_HiddenTxt.Value);
            //vd.Insurance_Claim_Amoount = String.IsNullOrEmpty(Insurance_Claim_Amount_HiddenTxt.Value) ? 0 : Convert.ToDouble(Insurance_Claim_Amount_HiddenTxt.Value.ToString());
            vd.Service_History_Record = service_record_DDL.SelectedItem.Text.ToString();
            vd.Insurance_Claim_Done = Insurance_claim_DDL.SelectedItem.Text.ToString();
            vd.Smoke_BOdour = Smoked_Bad_Odor_DDL.SelectedItem.Text;
            vd.Key_Alarm_Pad_Available = (KeySets_Alarm_DDL.SelectedItem.Text);
            vd.Taxi_Rental = Taxi_rental_DLL.SelectedItem.Text.ToString();
            vd.AfterMarket_Equipment_Installed = After_Market_DDL.SelectedItem.ToString();
            vd.AfterMarket_Equipment_Detals = Equipment_Hidden_TextArea1.Value.ToString();
            vd.Performance_Modifications = Performance_MOdification_DLL.SelectedItem.Text.ToString();
            vd.Performance_Modifications_Details = PerformaneModified_Hidden_TextArea.Value.ToString();
            Session["Vehile_detials_fill"] = vd;


            Current_Milg_Fill_lbl.Text = Convert.ToString(vd.Vehicle_Milage);
            Actual_Accurate_Milege_fill_lbl.Text = vd.Miles_Atual;
            Exterior_color_Fill_lbl.Text = vd.Exterior_Color;
            Interior_color_Fil_lbl.Text = vd.Interior_Color;
            Original_Owner_Fill_lbl.Text = vd.Vehicle_Owner;
            //  Vehicl_90_days_fill_lbl.Text = vd.Owned_90_Hidden_ddl;

            if ((OriginalOwner_DDL.SelectedItem.Text == "No") || (OriginalOwner_DDL.SelectedItem.Value == "1"))
            {
                if ((Owned_90_HiddenDDL.SelectedItem.Text == "Yes") || (Owned_90_HiddenDDL.SelectedItem.Value == "0"))
                {

                    Purchased_from_Fill_lbl.Text = vd.Dealer_Individual_Hddl;
                    tr_Purchased_from.Visible = true;
                }
            }
            else
            {
                tr_Purchased_from.Visible = false;

            }
            // Purchased_from_Fill_lbl.Text = vd.Dealer_Individual_Hddl;

            Smoked_Bad_odor_fil_lbl.Text = vd.Smoke_BOdour;
            Servic_histry_fill_lbl.Text = vd.Service_History_Record;
            Set_2_keys_fill_lbl.Text = vd.Key_Alarm_Pad_Available;
            Taxi_rental_fill_lbl.Text = vd.Taxi_Rental;
            Insurance_claimed_fill_lbl.Text = vd.Insurance_Claim_Done;

            if ((Insurance_claim_DDL.SelectedItem.Value == "1") || (Insurance_claim_DDL.SelectedItem.Value == "2") || (Insurance_claim_DDL.SelectedItem.Text == "No") || (Insurance_claim_DDL.SelectedItem.Text == "Not Sure"))
            {
                tr_insurance_Claimed_date.Visible = false;
                tr_insurance_claimed_Amount.Visible = false;
            }

            if ((Insurance_claim_DDL.SelectedItem.Value == "0") || (Insurance_claim_DDL.SelectedItem.Text == "Yes"))
            {     // vd.Insurance_Claim_Date.ToString("dd/MM/yyyy");
                Insurance_claim_date_fill_lbl.Text = Convert.ToString(vd.Insurance_Claim_Date);
                Insurance_Claim_amount_fill_lbl.Text = Convert.ToString(vd.Insurance_Claim_Amoount);
                tr_insurance_Claimed_date.Visible = true;
                tr_insurance_claimed_Amount.Visible = true;
            }

            Performance_Modificaion_fill_lbl.Text = vd.Performance_Modifications;

            if ((Performance_MOdification_DLL.SelectedItem.Text == "No") || (Performance_MOdification_DLL.SelectedItem.Text == "Not Sure") || (Performance_MOdification_DLL.SelectedItem.Value == "1") || (Performance_MOdification_DLL.SelectedItem.Value == "2"))
            {
                tr_Performance_description.Visible = false;
            }

            if ((Performance_MOdification_DLL.SelectedItem.Text == "Yes") || (Performance_MOdification_DLL.SelectedItem.Value == "0"))
            {
                Performance_description_fill_lbl.Text = vd.Performance_Modifications_Details;

                tr_Performance_description.Visible = true;
            }


            After_Equipmnt_installed_fil_lbl.Text = vd.AfterMarket_Equipment_Installed;


            if ((After_Market_DDL.SelectedItem.Text == "No") || (After_Market_DDL.SelectedItem.Text == "Not Sure") || (After_Market_DDL.SelectedItem.Value == "1") || (After_Market_DDL.SelectedItem.Value == "2"))
            {
                tr_Equipment_description.Visible = false;
            }

            if ((After_Market_DDL.SelectedItem.Text == "Yes") || (After_Market_DDL.SelectedItem.Value == "0"))
            {
                Equipment_description_fill_lbl.Text = vd.Performance_Modifications_Details;

                tr_Equipment_description.Visible = true;
            }

            MultiView1.ActiveViewIndex = 5;

        }

        protected void Vehicle_options_Features_Editbtn_Click(object sender, ImageClickEventArgs e)
        {
            Vehicle_optionFeatures_Back.Visible = false;
            Vehicle_OptionsFeatures_Nextbtn.Visible = false;
            Vehicle_optionsFeatures_Updatebtn.Visible = true;
            MultiView1.ActiveViewIndex = 3;
        }

        protected void Vehicle_optionsFeatures_Updatebtn_Click(object sender, ImageClickEventArgs e)
        {
            getOptionsfeaturesData();
            Vehicle_optionFeatures_Back.Visible = true;
            Vehicle_OptionsFeatures_Nextbtn.Visible = true;
            Vehicle_optionsFeatures_Updatebtn.Visible = false;


            //image
            getVehiclePhotos();
            Vehicle_optionFeatures_Back.Visible = true;
            Vehicle_OptionsFeatures_Nextbtn.Visible = true;
            Vehicle_optionsFeatures_Updatebtn.Visible = false;

            MultiView1.ActiveViewIndex = 5;
        }

        protected void Vehicle_photos_Editbtn_Click(object sender, ImageClickEventArgs e)
        {
            Vehicle_optionFeatures_Back.Visible = false;
            Vehicle_OptionsFeatures_Nextbtn.Visible = false;
            Vehicle_optionsFeatures_Updatebtn.Visible = true;
            MultiView1.ActiveViewIndex = 3;
        }
        //if (dtt.Rows.Count >= 1)
        //{
        //    for (int i = 0; i < dtt.Rows.Count; i = i + 2)
        //    {
        //        string first = Convert.ToString(dtt.Rows[i][0]);
        //        htmlStr += "<tr><td>" + first + "</td><td>";
        //        if (dtt.Rows.Count > (i + 1))
        //        {
        //            string second = Convert.ToString(dtt.Rows[i + 1][0]);
        //            htmlStr += "<tr><td>" + second + "</td><td>";
        //        }
        //        else
        //        {
        //            htmlStr += "<tr><td></td><td>";
        //        }
        //    //    htmlStr += "<tr><td>" + first + "</td><td>" + second + "</td></tr>";

        //        //  td_checkboxdetails.InnerHtml = htmlStr;
        //    }
        //}










        //protected void AajaxFileUpload1_UploadComplete1(object sender, AjaxFileUploadEventArgs e)
        //{
        //    string filename = e.FileName;
        //    string strDestPath = Server.MapPath("~/images_uploaded/");
        //    AjaxFileUpload1.SaveAs(@strDestPath + filename);
        //}

        //       protected void AjaxFileUpload1_UploadComplete1(object sender, AjaxFileUploadEventArgs e)
        //       {
        //           string filename = e.FileName;
        //           string strDestPath = Server.MapPath("~/imagess/");
        //           string path = strDestPath + filename;
        //           dt = (DataTable)ViewState["dt"];
        //           DataRow dr = dt.NewRow();
        //           string imagepath = "~/imagess/" + filename;
        //           dr["url"] = path;
        //           dt.Rows.Add(dr);
        //           GridView2.DataSource = dt;
        //           GridView2.DataBind();
        //           ViewState["dt_image_url"] = dt;
        //          // btnUpload_Click(sender, e);
        //            AjaxFileUpload1.SaveAs(path);
        //          //  __doPostBack("<%= HiddenButton.UniqueID %>", "");
        //         //  __doPostBack('btnUpload', '');
        //}





        //protected void btnUpload_Click(object sender, EventArgs e)
        //{
        //    DataTable dt = (DataTable)ViewState["dt_image_url"];
        //    GridView2.DataSource = dt;
        //    GridView2.DataBind();
        //}


        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //     GetNewImagepath();
        //   // DataTable dt1 = (DataTable)ViewState["dt"];

        //   // GridView1.DataSource = dt1;
        //   // GridView1.DataBind();
        //}
        //public  void Setdatatable()
        //{
        //    DataTable dt=new DataTable();
        //    dt.Columns.Add("url");
        //    ViewState["dt_crtd"]=dt;
        //}

        //protected void AjaxFileUpload1_UploadComplete(object sender, AjaxControlToolkit.AjaxFileUploadEventArgs e)
        //{
        //    string filename = e.FileName;
        //    string strDestPath = Server.MapPath("~/images_uploaded/");
        //    AjaxFileUpload1.SaveAs(@strDestPath + filename);
        //}

        //protected void AjaxFileUpload2_UploadComplete(object sender, AjaxControlToolkit.AjaxFileUploadEventArgs e)
        //{
        //    string filename = e.FileName;
        //    string strDestPath = Server.MapPath("~/images_uploaded/");
        //    AjaxFileUpload2.SaveAs(@strDestPath + filename);
        //}




        //public string GetNewImagepath()
        //{
        //    string imagePath="";
        //    if (FileUpload1.HasFile)
        //    {
        //        if (System.IO.File.Exists(Server.MapPath("~/images_uploaded/" + FileUpload1.FileName)))
        //        {
        //            string fileName = System.IO.Path.GetFileNameWithoutExtension(FileUpload1.FileName);
        //            FileUpload1.SaveAs(Server.MapPath("~/images_uploaded/" + fileName + "1" + System.IO.Path.GetExtension(FileUpload1.FileName)));
        //            imagePath = "~/images_uploaded/" + fileName + "1" + System.IO.Path.GetExtension(FileUpload1.FileName);
        //            //return imagePath;
        //        }
        //        else
        //        {
        //            FileUpload1.SaveAs(Server.MapPath("~/images_uploaded/" + FileUpload1.FileName));
        //            imagePath = "~/images_uploaded/" + FileUpload1.FileName;
        //           // return imagePath;
        //        }
        //    }

        //   // return imagePath;
        //   // Image1.ImageUrl = imagePath;
        //    dt = (DataTable)ViewState["dt_crtd"];
        //    DataRow dr = dt.NewRow();
        //    dr["url"] = imagePath;
        //    dt.Rows.Add(dr);
        //    ViewState["dt"] = dt;
        //    return imagePath;
        //  }

        //protected void Upload_btn_Click(object sender, EventArgs e)
        //{
        //    GetNewImagepath();
        //    DataTable dt1 = (DataTable)ViewState["dt"];

        //    GridView2.DataSource = dt1;
        //    GridView2.DataBind();
        //}




        //image mapping functionality

        protected void ChooseOne(object sender, ImageMapEventArgs e)
        {

            //1.Front Bumper
            if (e.PostBackValue == "Front Bumper")
            {

                cbl_Hood.Visible = false;
                cbl_Roof.Visible = false;
                cbl_FrontLeftFender.Visible = false;
                cbl_FrontLeftDoor.Visible = false;
                cbl_RearLeftDoor.Visible = false;
                cbl_RearLeftQuarterPanel.Visible = false;
                cbl_FrontLeftWindow.Visible = false;
                cbl_RearLeftWindow.Visible = false;
                cbl_FrontWindshield.Visible = false;
                cbl_FrontLeftWheelTire.Visible = false;
                cbl_RearLeftWheelTire.Visible = false;
                cbl_FrontLeftHeadlight.Visible = false;
                cbl_FrontRightHeadlight.Visible = false;
                cbl_LeftMirror.Visible = false;
                cbl_Trunk.Visible = false;
                cbl_RearBumper.Visible = false;
                cbl_RearRightQuarterPanel.Visible = false;
                cbl_FrontRightFender.Visible = false;
                cbl_FrontRightDoor.Visible = false;
                cbl_RearRightDoor.Visible = false;
                cbl_FrontRightWindow.Visible = false;
                cbl_RearRightWindow.Visible = false;
                cbl_RearWindshield.Visible = false;
                cbl_FrontRightWheelTire.Visible = false;
                cbl_RearRightWheelTire.Visible = false;
                cbl_RightTailLight.Visible = false;
                cbl_LeftTailLightdriverside.Visible = false;
                cbl_RightMirror.Visible = false;
                cbl_FrontBumper.Visible = true;
                DataTable dt = null;
                dt = imgbll.get_frontbumper();
                cbl_FrontBumper.DataSource = dt;
                cbl_FrontBumper.DataValueField = "FRONTBUMPERID";
                cbl_FrontBumper.DataTextField = "FRONTBUMPERDATA";
                cbl_FrontBumper.DataBind();
                ViewState["Frontbumper_tableCkbind_dt"] = dt;
                Partname.Text = "Front Bumper";
                //get's list of selected item's stored from session
                List<string> FrontBumperSelectedItems1 = new List<string>();
                if (Session["FrontBumper"] != null)
                {
                    FrontBumperSelectedItems1 = (List<string>)Session["FrontBumper"];

                }

                //select items which values match with values from session values
                foreach (string value in FrontBumperSelectedItems1)
                {
                    for (int i = 0; i < cbl_FrontBumper.Items.Count; i++)
                    {
                        //string.Format(Checkbox1.Items[i].Text)
                        //selectedItems.Add(string.Format(Checkbox1.Items[i].Text.ToString()));   string.Format(Checkbox1.Items[i].Text.ToString()))
                        if (value == cbl_FrontBumper.Items[i].Value)
                        {
                            cbl_FrontBumper.Items[i].Selected = true;
                        }
                    }
                }

            }
            //2.Hood
            if (e.PostBackValue == "Hood")
            {
                cbl_FrontBumper.Visible = false;
                cbl_Roof.Visible = false;
                cbl_FrontLeftFender.Visible = false;
                cbl_FrontLeftDoor.Visible = false;
                cbl_RearLeftDoor.Visible = false;
                cbl_RearLeftQuarterPanel.Visible = false;
                cbl_FrontLeftWindow.Visible = false;
                cbl_RearLeftWindow.Visible = false;
                cbl_FrontWindshield.Visible = false;
                cbl_FrontLeftWheelTire.Visible = false;
                cbl_RearLeftWheelTire.Visible = false;
                cbl_FrontLeftHeadlight.Visible = false;
                cbl_FrontRightHeadlight.Visible = false;
                cbl_LeftMirror.Visible = false;
                cbl_Trunk.Visible = false;
                cbl_RearBumper.Visible = false;
                cbl_RearRightQuarterPanel.Visible = false;
                cbl_FrontRightFender.Visible = false;
                cbl_FrontRightDoor.Visible = false;
                cbl_RearRightDoor.Visible = false;
                cbl_FrontRightWindow.Visible = false;
                cbl_RearRightWindow.Visible = false;
                cbl_RearWindshield.Visible = false;
                cbl_FrontRightWheelTire.Visible = false;
                cbl_RearRightWheelTire.Visible = false;
                cbl_RightTailLight.Visible = false;
                cbl_LeftTailLightdriverside.Visible = false;
                cbl_RightMirror.Visible = false;
                cbl_Hood.Visible = true;
                DataTable dt = new DataTable();
                dt = imgbll.get_hood();
                cbl_Hood.DataSource = dt;
                cbl_Hood.DataValueField = "HOODID";
                cbl_Hood.DataTextField = "HOODDATA";
                cbl_Hood.DataBind();
                ViewState["Hood_tableCkbind_dt"] = dt;
                Partname.Text = "Hood";
                //get's list of selected item's stored from session
                List<string> HoodSelectedItems1 = new List<string>();
                if (Session["Hood"] != null)
                {
                    HoodSelectedItems1 = (List<string>)Session["Hood"];
                }

                //select items which values match with values from session values
                foreach (string value in HoodSelectedItems1)
                {
                    for (int i = 0; i < cbl_Hood.Items.Count; i++)
                    {
                        //string.Format(Checkbox1.Items[i].Text)
                        //selectedItems.Add(string.Format(Checkbox1.Items[i].Text.ToString())); 
                        //string.Format(Checkbox1.Items[i].Text.ToString()))
                        if (value == cbl_Hood.Items[i].Value)
                        {
                            cbl_Hood.Items[i].Selected = true;
                        }
                    }
                }
            }
            //3.Roof
            if (e.PostBackValue == "Roof")
            {
                cbl_FrontBumper.Visible = false;
                cbl_Hood.Visible = false;
                cbl_FrontLeftFender.Visible = false;
                cbl_FrontLeftDoor.Visible = false;
                cbl_RearLeftDoor.Visible = false;
                cbl_RearLeftQuarterPanel.Visible = false;
                cbl_FrontLeftWindow.Visible = false;
                cbl_RearLeftWindow.Visible = false;
                cbl_FrontWindshield.Visible = false;
                cbl_FrontLeftWheelTire.Visible = false;
                cbl_RearLeftWheelTire.Visible = false;
                cbl_FrontLeftHeadlight.Visible = false;
                cbl_FrontRightHeadlight.Visible = false;
                cbl_LeftMirror.Visible = false;
                cbl_Trunk.Visible = false;
                cbl_RearBumper.Visible = false;
                cbl_RearRightQuarterPanel.Visible = false;
                cbl_FrontRightFender.Visible = false;
                cbl_FrontRightDoor.Visible = false;
                cbl_RearRightDoor.Visible = false;
                cbl_FrontRightWindow.Visible = false;
                cbl_RearRightWindow.Visible = false;
                cbl_RearWindshield.Visible = false;
                cbl_FrontRightWheelTire.Visible = false;
                cbl_RearRightWheelTire.Visible = false;
                cbl_RightTailLight.Visible = false;
                cbl_LeftTailLightdriverside.Visible = false;
                cbl_RightMirror.Visible = false;
                cbl_Roof.Visible = true;
                DataTable dt = new DataTable();
                dt = imgbll.get_roof();
                cbl_Roof.DataSource = dt;
                cbl_Roof.DataValueField = "ROOFID";
                cbl_Roof.DataTextField = "ROOFDATA";
                cbl_Roof.DataBind();
                ViewState["Roof_tableCkbind_dt"] = dt;
                Partname.Text = "Roof";
                //get's list of selected item's stored from session
                List<string> RoofSelectedItems1 = new List<string>();
                if (Session["Roof"] != null)
                {
                    RoofSelectedItems1 = (List<string>)Session["Roof"];
                }

                //select items which values match with values from session values
                foreach (string value in RoofSelectedItems1)
                {
                    for (int i = 0; i < cbl_Roof.Items.Count; i++)
                    {
                        //string.Format(Checkbox1.Items[i].Text)
                        //selectedItems.Add(string.Format(Checkbox1.Items[i].Text.ToString())); 
                        //string.Format(Checkbox1.Items[i].Text.ToString()))
                        if (value == cbl_Roof.Items[i].Value)
                        {
                            cbl_Roof.Items[i].Selected = true;
                        }
                    }
                }
            }
            //4.Front Left Fender
            if (e.PostBackValue == "Front Left Fender")
            {

                cbl_FrontBumper.Visible = false;
                cbl_Hood.Visible = false;
                cbl_Roof.Visible = false;
                cbl_FrontLeftDoor.Visible = false;
                cbl_RearLeftDoor.Visible = false;
                cbl_RearLeftQuarterPanel.Visible = false;
                cbl_FrontLeftWindow.Visible = false;
                cbl_RearLeftWindow.Visible = false;
                cbl_FrontWindshield.Visible = false;
                cbl_FrontLeftWheelTire.Visible = false;
                cbl_RearLeftWheelTire.Visible = false;
                cbl_FrontLeftHeadlight.Visible = false;
                cbl_FrontRightHeadlight.Visible = false;
                cbl_LeftMirror.Visible = false;
                cbl_Trunk.Visible = false;
                cbl_RearBumper.Visible = false;
                cbl_RearRightQuarterPanel.Visible = false;
                cbl_FrontRightFender.Visible = false;
                cbl_FrontRightDoor.Visible = false;
                cbl_RearRightDoor.Visible = false;
                cbl_FrontRightWindow.Visible = false;
                cbl_RearRightWindow.Visible = false;
                cbl_RearWindshield.Visible = false;
                cbl_FrontRightWheelTire.Visible = false;
                cbl_RearRightWheelTire.Visible = false;
                cbl_RightTailLight.Visible = false;
                cbl_LeftTailLightdriverside.Visible = false;
                cbl_RightMirror.Visible = false;
                cbl_FrontLeftFender.Visible = true;
                DataTable dt = new DataTable();
                dt = imgbll.get_frontleftfender();
                cbl_FrontLeftFender.DataSource = dt;
                cbl_FrontLeftFender.DataValueField = "FRONTLEFTFENDERID";
                cbl_FrontLeftFender.DataTextField = "FRONTLEFTFENDERDATA";
                cbl_FrontLeftFender.DataBind();
                ViewState["FrontLeftFender_tableCkbind_dt"] = dt;
                Partname.Text = "Front Left Fender";
                //cbl_FrontLeftFender.Visible = true;
                //get's list of selected item's stored from session
                List<string> FrontLeftFenderSelectedItems1 = new List<string>();
                if (Session["FrontLeftFender"] != null)
                {
                    FrontLeftFenderSelectedItems1 = (List<string>)Session["FrontLeftFender"];
                }

                //select items which values match with values from session values
                foreach (string value in FrontLeftFenderSelectedItems1)
                {
                    for (int i = 0; i < cbl_FrontLeftFender.Items.Count; i++)
                    {
                        //string.Format(Checkbox1.Items[i].Text)
                        //selectedItems.Add(string.Format(Checkbox1.Items[i].Text.ToString())); 
                        //string.Format(Checkbox1.Items[i].Text.ToString()))
                        if (value == cbl_FrontLeftFender.Items[i].Value)
                        {
                            cbl_FrontLeftFender.Items[i].Selected = true;
                        }
                    }
                }
            }
            //5.Front Left Door
            if (e.PostBackValue == "Front Left Door")
            {
                cbl_FrontBumper.Visible = false;
                cbl_Hood.Visible = false;
                cbl_Roof.Visible = false;
                cbl_FrontLeftFender.Visible = false;
                cbl_RearLeftDoor.Visible = false;
                cbl_RearLeftQuarterPanel.Visible = false;
                cbl_FrontLeftWindow.Visible = false;
                cbl_RearLeftWindow.Visible = false;
                cbl_FrontWindshield.Visible = false;
                cbl_FrontLeftWheelTire.Visible = false;
                cbl_RearLeftWheelTire.Visible = false;
                cbl_FrontLeftHeadlight.Visible = false;
                cbl_FrontRightHeadlight.Visible = false;
                cbl_LeftMirror.Visible = false;
                cbl_Trunk.Visible = false;
                cbl_RearBumper.Visible = false;
                cbl_RearRightQuarterPanel.Visible = false;
                cbl_FrontRightFender.Visible = false;
                cbl_FrontRightDoor.Visible = false;
                cbl_RearRightDoor.Visible = false;
                cbl_FrontRightWindow.Visible = false;
                cbl_RearRightWindow.Visible = false;
                cbl_RearWindshield.Visible = false;
                cbl_FrontRightWheelTire.Visible = false;
                cbl_RearRightWheelTire.Visible = false;
                cbl_RightTailLight.Visible = false;
                cbl_LeftTailLightdriverside.Visible = false;
                cbl_RightMirror.Visible = false;
                cbl_FrontLeftDoor.Visible = true;
                DataTable dt = new DataTable();
                dt = imgbll.get_frontleftdoor();
                cbl_FrontLeftDoor.DataSource = dt;
                cbl_FrontLeftDoor.DataValueField = "FRONTLEFTDOORID";
                cbl_FrontLeftDoor.DataTextField = "FRONTLEFTDOORDATA";
                cbl_FrontLeftDoor.DataBind();
                // cbl_FrontLeftDoor.DataBind();
                ViewState["FrontLeftDoor_tableCkbind_dt"] = dt;
                Partname.Text = "Front Left Door";
                //get's list of selected item's stored from session
                List<string> FrontLeftDoorSelectedItems1 = new List<string>();
                if (Session["FrontLeftDoor"] != null)
                {
                    FrontLeftDoorSelectedItems1 = (List<string>)Session["FrontLeftDoor"];
                }

                //select items which values match with values from session values
                foreach (string value in FrontLeftDoorSelectedItems1)
                {
                    for (int i = 0; i < cbl_FrontLeftDoor.Items.Count; i++)
                    {
                        //string.Format(Checkbox1.Items[i].Text)
                        //selectedItems.Add(string.Format(Checkbox1.Items[i].Text.ToString())); 
                        //string.Format(Checkbox1.Items[i].Text.ToString()))
                        if (value == cbl_FrontLeftDoor.Items[i].Value)
                        {
                            cbl_FrontLeftDoor.Items[i].Selected = true;
                        }
                    }
                }

            }
            //6.Rear Left Door
            if (e.PostBackValue == "Rear Left Door")
            {
                cbl_FrontBumper.Visible = false;
                cbl_Hood.Visible = false;
                cbl_Roof.Visible = false;
                cbl_FrontLeftFender.Visible = false;
                cbl_FrontLeftDoor.Visible = false;
                cbl_RearLeftQuarterPanel.Visible = false;
                cbl_FrontLeftWindow.Visible = false;
                cbl_RearLeftWindow.Visible = false;
                cbl_FrontWindshield.Visible = false;
                cbl_FrontLeftWheelTire.Visible = false;
                cbl_RearLeftWheelTire.Visible = false;
                cbl_FrontLeftHeadlight.Visible = false;
                cbl_FrontRightHeadlight.Visible = false;
                cbl_LeftMirror.Visible = false;
                cbl_Trunk.Visible = false;
                cbl_RearBumper.Visible = false;
                cbl_RearRightQuarterPanel.Visible = false;
                cbl_FrontRightFender.Visible = false;
                cbl_FrontRightDoor.Visible = false;
                cbl_RearRightDoor.Visible = false;
                cbl_FrontRightWindow.Visible = false;
                cbl_RearRightWindow.Visible = false;
                cbl_RearWindshield.Visible = false;
                cbl_FrontRightWheelTire.Visible = false;
                cbl_RearRightWheelTire.Visible = false;
                cbl_RightTailLight.Visible = false;
                cbl_LeftTailLightdriverside.Visible = false;
                cbl_RightMirror.Visible = false;
                cbl_RearLeftDoor.Visible = true;
                DataTable dt = new DataTable();
                dt = imgbll.get_rearleftdoor();

                cbl_RearLeftDoor.DataSource = dt;
                cbl_RearLeftDoor.DataValueField = "REARLEFTDOORID";
                cbl_RearLeftDoor.DataTextField = "REARLEFTDOORDATA";
                cbl_RearLeftDoor.DataBind();
                ViewState["RearLeftDoor_tableCkbind_dt"] = dt;
                Partname.Text = "Rear Left Door";
                //get's list of selected item's stored from session
                List<string> RearLeftDoorSelectedItems1 = new List<string>();
                if (Session["RearLeftDoor"] != null)
                {
                    RearLeftDoorSelectedItems1 = (List<string>)Session["RearLeftDoor"];
                }

                //select items which values match with values from session values
                foreach (string value in RearLeftDoorSelectedItems1)
                {
                    for (int i = 0; i < cbl_RearLeftDoor.Items.Count; i++)
                    {
                        //string.Format(Checkbox1.Items[i].Text)
                        //selectedItems.Add(string.Format(Checkbox1.Items[i].Text.ToString())); 
                        //string.Format(Checkbox1.Items[i].Text.ToString()))
                        if (value == cbl_RearLeftDoor.Items[i].Value)
                        {
                            cbl_RearLeftDoor.Items[i].Selected = true;
                        }
                    }
                }

            }
            //7.Rear Left Quarter Panel
            if (e.PostBackValue == "Rear Left Quarter Panel")
            {
                cbl_FrontBumper.Visible = false;
                cbl_Hood.Visible = false;
                cbl_Roof.Visible = false;
                cbl_FrontLeftFender.Visible = false;
                cbl_FrontLeftDoor.Visible = false;
                cbl_RearLeftDoor.Visible = false;
                cbl_FrontLeftWindow.Visible = false;
                cbl_RearLeftWindow.Visible = false;
                cbl_FrontWindshield.Visible = false;
                cbl_FrontLeftWheelTire.Visible = false;
                cbl_RearLeftWheelTire.Visible = false;
                cbl_FrontLeftHeadlight.Visible = false;
                cbl_FrontRightHeadlight.Visible = false;
                cbl_LeftMirror.Visible = false;
                cbl_Trunk.Visible = false;
                cbl_RearBumper.Visible = false;
                cbl_RearRightQuarterPanel.Visible = false;
                cbl_FrontRightFender.Visible = false;
                cbl_FrontRightDoor.Visible = false;
                cbl_RearRightDoor.Visible = false;
                cbl_FrontRightWindow.Visible = false;
                cbl_RearRightWindow.Visible = false;
                cbl_RearWindshield.Visible = false;
                cbl_FrontRightWheelTire.Visible = false;
                cbl_RearRightWheelTire.Visible = false;
                cbl_RightTailLight.Visible = false;
                cbl_LeftTailLightdriverside.Visible = false;
                cbl_RightMirror.Visible = false;
                cbl_RearLeftQuarterPanel.Visible = true;
                DataTable dt = new DataTable();
                dt = imgbll.get_rearleftquarterpanel();
                cbl_RearLeftQuarterPanel.DataSource = dt;
                cbl_RearLeftQuarterPanel.DataValueField = "REARLEFTQUARTERPANELID";
                cbl_RearLeftQuarterPanel.DataTextField = "REARLEFTQUARTERPANELDATA";
                cbl_RearLeftQuarterPanel.DataBind();
                ViewState["RearLeftQuarterPanel_tableCkbind_dt"] = dt;
                Partname.Text = "Rear Left Quarter Panel";
                //get's list of selected item's stored from session
                List<string> RearLeftQuarterPanelSelectedItems1 = new List<string>();
                if (Session["RearLeftQuarterPanel"] != null)
                {
                    RearLeftQuarterPanelSelectedItems1 = (List<string>)Session["RearLeftQuarterPanel"];
                }

                //select items which values match with values from session values
                foreach (string value in RearLeftQuarterPanelSelectedItems1)
                {
                    for (int i = 0; i < cbl_RearLeftQuarterPanel.Items.Count; i++)
                    {
                        //string.Format(Checkbox1.Items[i].Text)
                        //selectedItems.Add(string.Format(Checkbox1.Items[i].Text.ToString())); 
                        //string.Format(Checkbox1.Items[i].Text.ToString()))
                        if (value == cbl_RearLeftQuarterPanel.Items[i].Value)
                        {
                            cbl_RearLeftQuarterPanel.Items[i].Selected = true;
                        }
                    }
                }
            }

            //8.Front Left Window
            if (e.PostBackValue == "Front Left Window")
            {
                cbl_FrontBumper.Visible = false;
                cbl_Hood.Visible = false;
                cbl_Roof.Visible = false;
                cbl_FrontLeftFender.Visible = false;
                cbl_FrontLeftDoor.Visible = false;
                cbl_RearLeftDoor.Visible = false;
                cbl_RearLeftQuarterPanel.Visible = false;
                cbl_RearLeftWindow.Visible = false;
                cbl_FrontWindshield.Visible = false;
                cbl_FrontLeftWheelTire.Visible = false;
                cbl_RearLeftWheelTire.Visible = false;
                cbl_FrontLeftHeadlight.Visible = false;
                cbl_FrontRightHeadlight.Visible = false;
                cbl_LeftMirror.Visible = false;
                cbl_Trunk.Visible = false;
                cbl_RearBumper.Visible = false;
                cbl_RearRightQuarterPanel.Visible = false;
                cbl_FrontRightFender.Visible = false;
                cbl_FrontRightDoor.Visible = false;
                cbl_RearRightDoor.Visible = false;
                cbl_FrontRightWindow.Visible = false;
                cbl_RearRightWindow.Visible = false;
                cbl_RearWindshield.Visible = false;
                cbl_FrontRightWheelTire.Visible = false;
                cbl_RearRightWheelTire.Visible = false;
                cbl_RightTailLight.Visible = false;
                cbl_LeftTailLightdriverside.Visible = false;
                cbl_RightMirror.Visible = false;
                cbl_FrontLeftWindow.Visible = true;
                DataTable dt = new DataTable();
                dt = imgbll.get_frontleftwindow();
                cbl_FrontLeftWindow.DataSource = dt;
                cbl_FrontLeftWindow.DataValueField = "FRONTLEFTWINDOWID";
                cbl_FrontLeftWindow.DataTextField = "FRONTLEFTWINDOWDATA";
                cbl_FrontLeftWindow.DataBind();
                ViewState["FrontLeftWindow_tableCkbind_dt"] = dt;
                Partname.Text = "Front Left Window";
                //get's list of selected item's stored from session
                List<string> FrontLeftWindowSelectedItems1 = new List<string>();
                if (Session["FrontLeftWindow"] != null)
                {
                    FrontLeftWindowSelectedItems1 = (List<string>)Session["FrontLeftWindow"];
                }

                //select items which values match with values from session values
                foreach (string value in FrontLeftWindowSelectedItems1)
                {
                    for (int i = 0; i < cbl_FrontLeftWindow.Items.Count; i++)
                    {
                        //string.Format(Checkbox1.Items[i].Text)
                        //selectedItems.Add(string.Format(Checkbox1.Items[i].Text.ToString())); 
                        //string.Format(Checkbox1.Items[i].Text.ToString()))
                        if (value == cbl_FrontLeftWindow.Items[i].Value)
                        {
                            cbl_FrontLeftWindow.Items[i].Selected = true;
                        }
                    }
                }
            }

            //9.Rear Left Window
            if (e.PostBackValue == "Rear Left Window")
            {
                cbl_FrontBumper.Visible = false;
                cbl_Hood.Visible = false;
                cbl_Roof.Visible = false;
                cbl_FrontLeftFender.Visible = false;
                cbl_FrontLeftDoor.Visible = false;
                cbl_RearLeftDoor.Visible = false;
                cbl_RearLeftQuarterPanel.Visible = false;
                cbl_FrontLeftWindow.Visible = false;
                cbl_FrontWindshield.Visible = false;
                cbl_FrontLeftWheelTire.Visible = false;
                cbl_RearLeftWheelTire.Visible = false;
                cbl_FrontLeftHeadlight.Visible = false;
                cbl_FrontRightHeadlight.Visible = false;
                cbl_LeftMirror.Visible = false;
                cbl_Trunk.Visible = false;
                cbl_RearBumper.Visible = false;
                cbl_RearRightQuarterPanel.Visible = false;
                cbl_FrontRightFender.Visible = false;
                cbl_FrontRightDoor.Visible = false;
                cbl_RearRightDoor.Visible = false;
                cbl_FrontRightWindow.Visible = false;
                cbl_RearRightWindow.Visible = false;
                cbl_RearWindshield.Visible = false;
                cbl_FrontRightWheelTire.Visible = false;
                cbl_RearRightWheelTire.Visible = false;
                cbl_RightTailLight.Visible = false;
                cbl_LeftTailLightdriverside.Visible = false;
                cbl_RightMirror.Visible = false;
                cbl_RearLeftWindow.Visible = true;
                DataTable dt = new DataTable();
                dt = imgbll.get_rearleftwindow();

                cbl_RearLeftWindow.DataSource = dt;
                cbl_RearLeftWindow.DataValueField = "REARLEFTWINDOWID";
                cbl_RearLeftWindow.DataTextField = "REARLEFTWINDOWDATA";
                cbl_RearLeftWindow.DataBind();
                ViewState["RearLeftWindow_tableCkbind_dt"] = dt;
                Partname.Text = "Rear Left Window";
                //get's list of selected item's stored from session
                List<string> RearLeftWindowSelectedItems1 = new List<string>();
                if (Session["RearLeftWindow"] != null)
                {
                    RearLeftWindowSelectedItems1 = (List<string>)Session["RearLeftWindow"];
                }

                //select items which values match with values from session values
                foreach (string value in RearLeftWindowSelectedItems1)
                {
                    for (int i = 0; i < cbl_RearLeftWindow.Items.Count; i++)
                    {
                        //string.Format(Checkbox1.Items[i].Text)
                        //selectedItems.Add(string.Format(Checkbox1.Items[i].Text.ToString())); 
                        //string.Format(Checkbox1.Items[i].Text.ToString()))
                        if (value == cbl_RearLeftWindow.Items[i].Value)
                        {
                            cbl_RearLeftWindow.Items[i].Selected = true;
                        }
                    }
                }
            }
            //10.Front Windshield
            if (e.PostBackValue == "Front Windshield")
            {
                cbl_FrontBumper.Visible = false;
                cbl_Hood.Visible = false;
                cbl_Roof.Visible = false;
                cbl_FrontLeftFender.Visible = false;
                cbl_FrontLeftDoor.Visible = false;
                cbl_RearLeftDoor.Visible = false;
                cbl_RearLeftQuarterPanel.Visible = false;
                cbl_FrontLeftWindow.Visible = false;
                cbl_RearLeftWindow.Visible = false;
                cbl_FrontLeftWheelTire.Visible = false;
                cbl_RearLeftWheelTire.Visible = false;
                cbl_FrontLeftHeadlight.Visible = false;
                cbl_FrontRightHeadlight.Visible = false;
                cbl_LeftMirror.Visible = false;
                cbl_Trunk.Visible = false;
                cbl_RearBumper.Visible = false;
                cbl_RearRightQuarterPanel.Visible = false;
                cbl_FrontRightFender.Visible = false;
                cbl_FrontRightDoor.Visible = false;
                cbl_RearRightDoor.Visible = false;
                cbl_FrontRightWindow.Visible = false;
                cbl_RearRightWindow.Visible = false;
                cbl_RearWindshield.Visible = false;
                cbl_FrontRightWheelTire.Visible = false;
                cbl_RearRightWheelTire.Visible = false;
                cbl_RightTailLight.Visible = false;
                cbl_LeftTailLightdriverside.Visible = false;
                cbl_RightMirror.Visible = false;
                cbl_FrontWindshield.Visible = true;
                DataTable dt = new DataTable();
                dt = imgbll.get_frontwindshield();
                cbl_FrontWindshield.DataSource = dt;
                cbl_FrontWindshield.DataValueField = "FRONTWINDSHIELDID";
                cbl_FrontWindshield.DataTextField = "FRONTWINDSHIELDDATA";
                cbl_FrontWindshield.DataBind();
                ViewState["FrontWindshield_tableCkbind_dt"] = dt;
                Partname.Text = "Front Windshield";
                //get's list of selected item's stored from session
                List<string> FrontWindshieldSelectedItems1 = new List<string>();
                if (Session["FrontWindshield"] != null)
                {
                    FrontWindshieldSelectedItems1 = (List<string>)Session["FrontWindshield"];
                }

                //select items which values match with values from session values
                foreach (string value in FrontWindshieldSelectedItems1)
                {
                    for (int i = 0; i < cbl_FrontWindshield.Items.Count; i++)
                    {
                        //string.Format(Checkbox1.Items[i].Text)
                        //selectedItems.Add(string.Format(Checkbox1.Items[i].Text.ToString())); 
                        //string.Format(Checkbox1.Items[i].Text.ToString()))
                        if (value == cbl_FrontWindshield.Items[i].Value)
                        {
                            cbl_FrontWindshield.Items[i].Selected = true;
                        }
                    }
                }
            }
            //11.Front Left Wheel & Tire
            if (e.PostBackValue == "Front Left Wheel & Tire")
            {
                cbl_FrontBumper.Visible = false;
                cbl_Hood.Visible = false;
                cbl_Roof.Visible = false;
                cbl_FrontLeftFender.Visible = false;
                cbl_FrontLeftDoor.Visible = false;
                cbl_RearLeftDoor.Visible = false;
                cbl_RearLeftQuarterPanel.Visible = false;
                cbl_FrontLeftWindow.Visible = false;
                cbl_RearLeftWindow.Visible = false;
                cbl_FrontWindshield.Visible = false;
                cbl_RearLeftWheelTire.Visible = false;
                cbl_FrontLeftHeadlight.Visible = false;
                cbl_FrontRightHeadlight.Visible = false;
                cbl_LeftMirror.Visible = false;
                cbl_Trunk.Visible = false;
                cbl_RearBumper.Visible = false;
                cbl_RearRightQuarterPanel.Visible = false;
                cbl_FrontRightFender.Visible = false;
                cbl_FrontRightDoor.Visible = false;
                cbl_RearRightDoor.Visible = false;
                cbl_FrontRightWindow.Visible = false;
                cbl_RearRightWindow.Visible = false;
                cbl_RearWindshield.Visible = false;
                cbl_FrontRightWheelTire.Visible = false;
                cbl_RearRightWheelTire.Visible = false;
                cbl_RightTailLight.Visible = false;
                cbl_LeftTailLightdriverside.Visible = false;
                cbl_RightMirror.Visible = false;
                cbl_FrontLeftWheelTire.Visible = true;
                DataTable dt = new DataTable();
                dt = imgbll.get_frontleftwheeltire();
                cbl_FrontLeftWheelTire.DataSource = dt;
                cbl_FrontLeftWheelTire.DataValueField = "FRONTLEFTWHEELTIREID";
                cbl_FrontLeftWheelTire.DataTextField = "FRONTLEFTWHEELTIREDATA";
                cbl_FrontLeftWheelTire.DataBind();
                ViewState["FrontLeftWheelTire_tableCkbind_dt"] = dt;
                Partname.Text = "Front Left Wheel & Tire";
                //get's list of selected item's stored from session
                List<string> FrontLeftWheelTireSelectedItems1 = new List<string>();
                if (Session["FrontLeftWheelTire"] != null)
                {
                    FrontLeftWheelTireSelectedItems1 = (List<string>)Session["FrontLeftWheelTire"];
                }

                //select items which values match with values from session values
                foreach (string value in FrontLeftWheelTireSelectedItems1)
                {
                    for (int i = 0; i < cbl_FrontLeftWheelTire.Items.Count; i++)
                    {
                        //string.Format(Checkbox1.Items[i].Text)
                        //selectedItems.Add(string.Format(Checkbox1.Items[i].Text.ToString())); 
                        //string.Format(Checkbox1.Items[i].Text.ToString()))
                        if (value == cbl_FrontLeftWheelTire.Items[i].Value)
                        {
                            cbl_FrontLeftWheelTire.Items[i].Selected = true;
                        }
                    }
                }
            }
            //12.Rear Left Wheel & Tire
            if (e.PostBackValue == "Rear Left Wheel & Tire")
            {
                cbl_FrontBumper.Visible = false;
                cbl_Hood.Visible = false;
                cbl_Roof.Visible = false;
                cbl_FrontLeftFender.Visible = false;
                cbl_FrontLeftDoor.Visible = false;
                cbl_RearLeftDoor.Visible = false;
                cbl_RearLeftQuarterPanel.Visible = false;
                cbl_FrontLeftWindow.Visible = false;
                cbl_RearLeftWindow.Visible = false;
                cbl_FrontWindshield.Visible = false;
                cbl_FrontLeftWheelTire.Visible = false;
                cbl_FrontLeftHeadlight.Visible = false;
                cbl_FrontRightHeadlight.Visible = false;
                cbl_LeftMirror.Visible = false;
                cbl_Trunk.Visible = false;
                cbl_RearBumper.Visible = false;
                cbl_RearRightQuarterPanel.Visible = false;
                cbl_FrontRightFender.Visible = false;
                cbl_FrontRightDoor.Visible = false;
                cbl_RearRightDoor.Visible = false;
                cbl_FrontRightWindow.Visible = false;
                cbl_RearRightWindow.Visible = false;
                cbl_RearWindshield.Visible = false;
                cbl_FrontRightWheelTire.Visible = false;
                cbl_RearRightWheelTire.Visible = false;
                cbl_RightTailLight.Visible = false;
                cbl_LeftTailLightdriverside.Visible = false;
                cbl_RightMirror.Visible = false;
                cbl_RearLeftWheelTire.Visible = true;
                DataTable dt = new DataTable();
                dt = imgbll.get_rearleftwheeltire();
                cbl_RearLeftWheelTire.DataSource = dt;
                cbl_RearLeftWheelTire.DataValueField = "REARLEFTWHEELTIREID";
                cbl_RearLeftWheelTire.DataTextField = "REARLEFTWHEELTIREDATA";
                cbl_RearLeftWheelTire.DataBind();
                ViewState["RearLeftWheelTire_tableCkbind_dt"] = dt;
                Partname.Text = "Rear Left Wheel & Tire";
                //get's list of selected item's stored from session
                List<string> RearLeftWheelTireSelectedItems1 = new List<string>();
                if (Session["RearLeftWheelTire"] != null)
                {
                    RearLeftWheelTireSelectedItems1 = (List<string>)Session["RearLeftWheelTire"];
                }

                //select items which values match with values from session values
                foreach (string value in RearLeftWheelTireSelectedItems1)
                {
                    for (int i = 0; i < cbl_RearLeftWheelTire.Items.Count; i++)
                    {
                        //string.Format(Checkbox1.Items[i].Text)
                        //selectedItems.Add(string.Format(Checkbox1.Items[i].Text.ToString())); 
                        //string.Format(Checkbox1.Items[i].Text.ToString()))
                        if (value == cbl_RearLeftWheelTire.Items[i].Value)
                        {
                            cbl_RearLeftWheelTire.Items[i].Selected = true;
                        }
                    }
                }
            }

            //13.Front Left Headlight
            if (e.PostBackValue == "Front Left Headlight")
            {
                cbl_FrontBumper.Visible = false;
                cbl_Hood.Visible = false;
                cbl_Roof.Visible = false;
                cbl_FrontLeftFender.Visible = false;
                cbl_FrontLeftDoor.Visible = false;
                cbl_RearLeftDoor.Visible = false;
                cbl_RearLeftQuarterPanel.Visible = false;
                cbl_FrontLeftWindow.Visible = false;
                cbl_RearLeftWindow.Visible = false;
                cbl_FrontWindshield.Visible = false;
                cbl_FrontLeftWheelTire.Visible = false;
                cbl_RearLeftWheelTire.Visible = false;
                cbl_FrontRightHeadlight.Visible = false;
                cbl_LeftMirror.Visible = false;
                cbl_Trunk.Visible = false;
                cbl_RearBumper.Visible = false;
                cbl_RearRightQuarterPanel.Visible = false;
                cbl_FrontRightFender.Visible = false;
                cbl_FrontRightDoor.Visible = false;
                cbl_RearRightDoor.Visible = false;
                cbl_FrontRightWindow.Visible = false;
                cbl_RearRightWindow.Visible = false;
                cbl_RearWindshield.Visible = false;
                cbl_FrontRightWheelTire.Visible = false;
                cbl_RearRightWheelTire.Visible = false;
                cbl_RightTailLight.Visible = false;
                cbl_LeftTailLightdriverside.Visible = false;
                cbl_RightMirror.Visible = false;
                cbl_FrontLeftHeadlight.Visible = true;
                DataTable dt = new DataTable();
                dt = imgbll.get_fronleftheadlight();
                cbl_FrontLeftHeadlight.DataSource = dt;
                cbl_FrontLeftHeadlight.DataValueField = "FRONTLEFTHEADLIGHTID";
                cbl_FrontLeftHeadlight.DataTextField = "FRONTLEFTHEADLIGHTDATA";
                cbl_FrontLeftHeadlight.DataBind();
                ViewState["FrontLeftHeadlight_tableCkbind_dt"] = dt;
                Partname.Text = "Front Left Headlight";
                //get's list of selected item's stored from session
                List<string> FrontLeftHeadlightSelectedItems1 = new List<string>();
                if (Session["FrontLeftHeadlight"] != null)
                {
                    FrontLeftHeadlightSelectedItems1 = (List<string>)Session["FrontLeftHeadlight"];
                }

                //select items which values match with values from session values
                foreach (string value in FrontLeftHeadlightSelectedItems1)
                {
                    for (int i = 0; i < cbl_FrontLeftHeadlight.Items.Count; i++)
                    {
                        //string.Format(Checkbox1.Items[i].Text)
                        //selectedItems.Add(string.Format(Checkbox1.Items[i].Text.ToString())); 
                        //string.Format(Checkbox1.Items[i].Text.ToString()))
                        if (value == cbl_FrontLeftHeadlight.Items[i].Value)
                        {
                            cbl_FrontLeftHeadlight.Items[i].Selected = true;
                        }
                    }
                }
            }
            //14.Front Right Headlight
            if (e.PostBackValue == "Front Right Headlight")
            {
                cbl_FrontBumper.Visible = false;
                cbl_Hood.Visible = false;
                cbl_Roof.Visible = false;
                cbl_FrontLeftFender.Visible = false;
                cbl_FrontLeftDoor.Visible = false;
                cbl_RearLeftDoor.Visible = false;
                cbl_RearLeftQuarterPanel.Visible = false;
                cbl_FrontLeftWindow.Visible = false;
                cbl_RearLeftWindow.Visible = false;
                cbl_FrontWindshield.Visible = false;
                cbl_FrontLeftWheelTire.Visible = false;
                cbl_RearLeftWheelTire.Visible = false;
                cbl_FrontLeftHeadlight.Visible = false;
                cbl_LeftMirror.Visible = false;
                cbl_Trunk.Visible = false;
                cbl_RearBumper.Visible = false;
                cbl_RearRightQuarterPanel.Visible = false;
                cbl_FrontRightFender.Visible = false;
                cbl_FrontRightDoor.Visible = false;
                cbl_RearRightDoor.Visible = false;
                cbl_FrontRightWindow.Visible = false;
                cbl_RearRightWindow.Visible = false;
                cbl_RearWindshield.Visible = false;
                cbl_FrontRightWheelTire.Visible = false;
                cbl_RearRightWheelTire.Visible = false;
                cbl_RightTailLight.Visible = false;
                cbl_LeftTailLightdriverside.Visible = false;
                cbl_RightMirror.Visible = false;
                cbl_FrontRightHeadlight.Visible = true;
                DataTable dt = new DataTable();
                dt = imgbll.get_frontrightheadlight();
                cbl_FrontRightHeadlight.DataSource = dt;
                cbl_FrontRightHeadlight.DataValueField = "FRONTRIGHTHEADLIGHTID";
                cbl_FrontRightHeadlight.DataTextField = "FRONTRIGHTHEADLIGHTDATA";
                cbl_FrontRightHeadlight.DataBind();
                ViewState["FrontRightHeadlight_tableCkbind_dt"] = dt;
                Partname.Text = "Front Right Headlight";
                //get's list of selected item's stored from session
                List<string> selectedItems = new List<string>();
                if (Session["FrontRightHeadlight"] != null)
                {
                    selectedItems = (List<string>)Session["FrontRightHeadlight"];
                }

                //select items which values match with values from session values
                foreach (string value in selectedItems)
                {
                    for (int i = 0; i < cbl_FrontRightHeadlight.Items.Count; i++)
                    {
                        //string.Format(Checkbox1.Items[i].Text)
                        //selectedItems.Add(string.Format(Checkbox1.Items[i].Text.ToString())); 
                        //string.Format(Checkbox1.Items[i].Text.ToString()))
                        if (value == cbl_FrontRightHeadlight.Items[i].Value)
                        {
                            cbl_FrontRightHeadlight.Items[i].Selected = true;
                        }
                    }
                }
            }

            //15.Left Mirror
            if (e.PostBackValue == "Left Mirror")
            {
                cbl_FrontBumper.Visible = false;
                cbl_Hood.Visible = false;
                cbl_Roof.Visible = false;
                cbl_FrontLeftFender.Visible = false;
                cbl_FrontLeftDoor.Visible = false;
                cbl_RearLeftDoor.Visible = false;
                cbl_RearLeftQuarterPanel.Visible = false;
                cbl_FrontLeftWindow.Visible = false;
                cbl_RearLeftWindow.Visible = false;
                cbl_FrontWindshield.Visible = false;
                cbl_FrontLeftWheelTire.Visible = false;
                cbl_RearLeftWheelTire.Visible = false;
                cbl_FrontLeftHeadlight.Visible = false;
                cbl_FrontRightHeadlight.Visible = false;
                cbl_Trunk.Visible = false;
                cbl_RearBumper.Visible = false;
                cbl_RearRightQuarterPanel.Visible = false;
                cbl_FrontRightFender.Visible = false;
                cbl_FrontRightDoor.Visible = false;
                cbl_RearRightDoor.Visible = false;
                cbl_FrontRightWindow.Visible = false;
                cbl_RearRightWindow.Visible = false;
                cbl_RearWindshield.Visible = false;
                cbl_FrontRightWheelTire.Visible = false;
                cbl_RearRightWheelTire.Visible = false;
                cbl_RightTailLight.Visible = false;
                cbl_LeftTailLightdriverside.Visible = false;
                cbl_RightMirror.Visible = false;
                cbl_LeftMirror.Visible = true;
                DataTable dt = new DataTable();
                dt = imgbll.get_leftmirror();
                cbl_LeftMirror.DataSource = dt;
                cbl_LeftMirror.DataValueField = "LEFTMIRRORID";
                cbl_LeftMirror.DataTextField = "LEFTMIRRORDATA";
                cbl_LeftMirror.DataBind();
                ViewState["LeftMirror_tableCkbind_dt"] = dt;
                Partname.Text = "Left Mirror";
                //get's list of selected item's stored from session
                List<string> LeftMirrorSelectedItems1 = new List<string>();
                if (Session["LeftMirror"] != null)
                {
                    LeftMirrorSelectedItems1 = (List<string>)Session["LeftMirror"];
                }

                //select items which values match with values from session values
                foreach (string value in LeftMirrorSelectedItems1)
                {
                    for (int i = 0; i < cbl_LeftMirror.Items.Count; i++)
                    {
                        //string.Format(Checkbox1.Items[i].Text)
                        //selectedItems.Add(string.Format(Checkbox1.Items[i].Text.ToString())); 
                        //string.Format(Checkbox1.Items[i].Text.ToString()))
                        if (value == cbl_LeftMirror.Items[i].Value)
                        {
                            cbl_LeftMirror.Items[i].Selected = true;
                        }
                    }
                }
            }
            //16.Roof
            if (e.PostBackValue == "Roof")
            {
                cbl_FrontBumper.Visible = false;
                cbl_Hood.Visible = false;
                cbl_FrontLeftFender.Visible = false;
                cbl_FrontLeftDoor.Visible = false;
                cbl_RearLeftDoor.Visible = false;
                cbl_RearLeftQuarterPanel.Visible = false;
                cbl_FrontLeftWindow.Visible = false;
                cbl_RearLeftWindow.Visible = false;
                cbl_FrontWindshield.Visible = false;
                cbl_FrontLeftWheelTire.Visible = false;
                cbl_RearLeftWheelTire.Visible = false;
                cbl_FrontLeftHeadlight.Visible = false;
                cbl_FrontRightHeadlight.Visible = false;
                cbl_LeftMirror.Visible = false;
                cbl_Trunk.Visible = false;
                cbl_RearBumper.Visible = false;
                cbl_RearRightQuarterPanel.Visible = false;
                cbl_FrontRightFender.Visible = false;
                cbl_FrontRightDoor.Visible = false;
                cbl_RearRightDoor.Visible = false;
                cbl_FrontRightWindow.Visible = false;
                cbl_RearRightWindow.Visible = false;
                cbl_RearWindshield.Visible = false;
                cbl_FrontRightWheelTire.Visible = false;
                cbl_RearRightWheelTire.Visible = false;
                cbl_RightTailLight.Visible = false;
                cbl_LeftTailLightdriverside.Visible = false;
                cbl_RightMirror.Visible = false;
                cbl_Roof.Visible = true;
                DataTable dt = new DataTable();
                dt = imgbll.get_roof();
                cbl_Roof.DataSource = dt;
                cbl_Roof.DataValueField = "ROOFID";
                cbl_Roof.DataTextField = "ROOFDATA";
                cbl_Roof.DataBind();
                ViewState["Roof_tableCkbind_dt"] = dt;
                Partname.Text = "Roof";
                //get's list of selected item's stored from session
                List<string> RoofSelectedItems1 = new List<string>();
                if (Session["Roof"] != null)
                {
                    RoofSelectedItems1 = (List<string>)Session["Roof"];
                }

                //select items which values match with values from session values
                foreach (string value in RoofSelectedItems1)
                {
                    for (int i = 0; i < cbl_Roof.Items.Count; i++)
                    {
                        //string.Format(Checkbox1.Items[i].Text)
                        //selectedItems.Add(string.Format(Checkbox1.Items[i].Text.ToString())); 
                        //string.Format(Checkbox1.Items[i].Text.ToString()))
                        if (value == cbl_Roof.Items[i].Value)
                        {
                            cbl_Roof.Items[i].Selected = true;
                        }
                    }
                }
            }
            //17.Trunk
            if (e.PostBackValue == "Trunk")
            {
                cbl_FrontBumper.Visible = false;
                cbl_Hood.Visible = false;
                cbl_Roof.Visible = false;
                cbl_FrontLeftFender.Visible = false;
                cbl_FrontLeftDoor.Visible = false;
                cbl_RearLeftDoor.Visible = false;
                cbl_RearLeftQuarterPanel.Visible = false;
                cbl_FrontLeftWindow.Visible = false;
                cbl_RearLeftWindow.Visible = false;
                cbl_FrontWindshield.Visible = false;
                cbl_FrontLeftWheelTire.Visible = false;
                cbl_RearLeftWheelTire.Visible = false;
                cbl_FrontLeftHeadlight.Visible = false;
                cbl_FrontRightHeadlight.Visible = false;
                cbl_LeftMirror.Visible = false;
                cbl_RearBumper.Visible = false;
                cbl_RearRightQuarterPanel.Visible = false;
                cbl_FrontRightFender.Visible = false;
                cbl_FrontRightDoor.Visible = false;
                cbl_RearRightDoor.Visible = false;
                cbl_FrontRightWindow.Visible = false;
                cbl_RearRightWindow.Visible = false;
                cbl_RearWindshield.Visible = false;
                cbl_FrontRightWheelTire.Visible = false;
                cbl_RearRightWheelTire.Visible = false;
                cbl_RightTailLight.Visible = false;
                cbl_LeftTailLightdriverside.Visible = false;
                cbl_RightMirror.Visible = false;
                cbl_Trunk.Visible = true;
                DataTable dt = new DataTable();
                dt = imgbll.get_trunk();
                cbl_Trunk.DataSource = dt;
                cbl_Trunk.DataValueField = "TRUNKID";
                cbl_Trunk.DataTextField = "TRUNKDATA";
                cbl_Trunk.DataBind();
                ViewState["Trunk_tableCkbind_dt"] = dt;
                Partname.Text = "Trunk";
                //get's list of selected item's stored from session
                List<string> TrunkSelectedItems1 = new List<string>();
                if (Session["Trunk"] != null)
                {
                    TrunkSelectedItems1 = (List<string>)Session["Trunk"];
                }

                //select items which values match with values from session values
                foreach (string value in TrunkSelectedItems1)
                {
                    for (int i = 0; i < cbl_Trunk.Items.Count; i++)
                    {
                        //string.Format(Checkbox1.Items[i].Text)
                        //selectedItems.Add(string.Format(Checkbox1.Items[i].Text.ToString())); 
                        //string.Format(Checkbox1.Items[i].Text.ToString()))
                        if (value == cbl_Trunk.Items[i].Value)
                        {
                            cbl_Trunk.Items[i].Selected = true;
                        }
                    }
                }
            }
            //18.Rear Bumper
            if (e.PostBackValue == "Rear Bumper")
            {
                cbl_FrontBumper.Visible = false;
                cbl_Hood.Visible = false;
                cbl_Roof.Visible = false;
                cbl_FrontLeftFender.Visible = false;
                cbl_FrontLeftDoor.Visible = false;
                cbl_RearLeftDoor.Visible = false;
                cbl_RearLeftQuarterPanel.Visible = false;
                cbl_FrontLeftWindow.Visible = false;
                cbl_RearLeftWindow.Visible = false;
                cbl_FrontWindshield.Visible = false;
                cbl_FrontLeftWheelTire.Visible = false;
                cbl_RearLeftWheelTire.Visible = false;
                cbl_FrontLeftHeadlight.Visible = false;
                cbl_FrontRightHeadlight.Visible = false;
                cbl_LeftMirror.Visible = false;
                cbl_Trunk.Visible = false;
                cbl_RearRightQuarterPanel.Visible = false;
                cbl_FrontRightFender.Visible = false;
                cbl_FrontRightDoor.Visible = false;
                cbl_RearRightDoor.Visible = false;
                cbl_FrontRightWindow.Visible = false;
                cbl_RearRightWindow.Visible = false;
                cbl_RearWindshield.Visible = false;
                cbl_FrontRightWheelTire.Visible = false;
                cbl_RearRightWheelTire.Visible = false;
                cbl_RightTailLight.Visible = false;
                cbl_LeftTailLightdriverside.Visible = false;
                cbl_RightMirror.Visible = false;
                cbl_RearBumper.Visible = true;
                DataTable dt = new DataTable();
                dt = imgbll.get_rearbumper();
                cbl_RearBumper.DataSource = dt;
                cbl_RearBumper.DataValueField = "REARBUMPERID";
                cbl_RearBumper.DataTextField = "REARBUMPERDATA";
                cbl_RearBumper.DataBind();
                ViewState["RearBumper_tableCkbind_dt"] = dt;
                Partname.Text = "Rear Bumper";
                //get's list of selected item's stored from session
                List<string> RearBumperSelectedItems1 = new List<string>();
                if (Session["RearBumper"] != null)
                {
                    RearBumperSelectedItems1 = (List<string>)Session["RearBumper"];
                }

                //select items which values match with values from session values
                foreach (string value in RearBumperSelectedItems1)
                {
                    for (int i = 0; i < cbl_RearBumper.Items.Count; i++)
                    {
                        //string.Format(Checkbox1.Items[i].Text)
                        //selectedItems.Add(string.Format(Checkbox1.Items[i].Text.ToString())); 
                        //string.Format(Checkbox1.Items[i].Text.ToString()))
                        if (value == cbl_RearBumper.Items[i].Value)
                        {
                            cbl_RearBumper.Items[i].Selected = true;
                        }
                    }
                }
            }

            //19.Rear Right Quarter Panel
            if (e.PostBackValue == "Rear Right Quarter Panel")
            {
                cbl_FrontBumper.Visible = false;
                cbl_Hood.Visible = false;
                cbl_Roof.Visible = false;
                cbl_FrontLeftFender.Visible = false;
                cbl_FrontLeftDoor.Visible = false;
                cbl_RearLeftDoor.Visible = false;
                cbl_RearLeftQuarterPanel.Visible = false;
                cbl_FrontLeftWindow.Visible = false;
                cbl_RearLeftWindow.Visible = false;
                cbl_FrontWindshield.Visible = false;
                cbl_FrontLeftWheelTire.Visible = false;
                cbl_RearLeftWheelTire.Visible = false;
                cbl_FrontLeftHeadlight.Visible = false;
                cbl_FrontRightHeadlight.Visible = false;
                cbl_LeftMirror.Visible = false;
                cbl_Trunk.Visible = false;
                cbl_RearBumper.Visible = false;
                cbl_FrontRightFender.Visible = false;
                cbl_FrontRightDoor.Visible = false;
                cbl_RearRightDoor.Visible = false;
                cbl_FrontRightWindow.Visible = false;
                cbl_RearRightWindow.Visible = false;
                cbl_RearWindshield.Visible = false;
                cbl_FrontRightWheelTire.Visible = false;
                cbl_RearRightWheelTire.Visible = false;
                cbl_RightTailLight.Visible = false;
                cbl_LeftTailLightdriverside.Visible = false;
                cbl_RightMirror.Visible = false;
                cbl_RearRightQuarterPanel.Visible = true;
                DataTable dt = new DataTable();
                dt = imgbll.get_rearrightquarterpanel();
                cbl_RearRightQuarterPanel.DataSource = dt;
                cbl_RearRightQuarterPanel.DataValueField = "REARRIGHTQUARTERPANELID";
                cbl_RearRightQuarterPanel.DataTextField = "REARRIGHTQUARTERPANELDATA";
                cbl_RearRightQuarterPanel.DataBind();
                ViewState["RearRightQuarterPanel_tableCkbind_dt"] = dt;
                Partname.Text = "Rear Right Quarter Panel";
                //get's list of selected item's stored from session
                List<string> RearRightQuarterPanelSelectedItems1 = new List<string>();
                if (Session["RearRightQuarterPanel"] != null)
                {
                    RearRightQuarterPanelSelectedItems1 = (List<string>)Session["RearRightQuarterPanel"];
                }

                //select items which values match with values from session values
                foreach (string value in RearRightQuarterPanelSelectedItems1)
                {
                    for (int i = 0; i < cbl_RearRightQuarterPanel.Items.Count; i++)
                    {
                        //string.Format(Checkbox1.Items[i].Text)
                        //selectedItems.Add(string.Format(Checkbox1.Items[i].Text.ToString())); 
                        //string.Format(Checkbox1.Items[i].Text.ToString()))
                        if (value == cbl_RearRightQuarterPanel.Items[i].Value)
                        {
                            cbl_RearRightQuarterPanel.Items[i].Selected = true;
                        }
                    }
                }
            }
            //20.Front Right Fender
            if (e.PostBackValue == "Front Right Fender")
            {
                cbl_FrontBumper.Visible = false;
                cbl_Hood.Visible = false;
                cbl_Roof.Visible = false;
                cbl_FrontLeftFender.Visible = false;
                cbl_FrontLeftDoor.Visible = false;
                cbl_RearLeftDoor.Visible = false;
                cbl_RearLeftQuarterPanel.Visible = false;
                cbl_FrontLeftWindow.Visible = false;
                cbl_RearLeftWindow.Visible = false;
                cbl_FrontWindshield.Visible = false;
                cbl_FrontLeftWheelTire.Visible = false;
                cbl_RearLeftWheelTire.Visible = false;
                cbl_FrontLeftHeadlight.Visible = false;
                cbl_FrontRightHeadlight.Visible = false;
                cbl_LeftMirror.Visible = false;
                cbl_Trunk.Visible = false;
                cbl_RearBumper.Visible = false;
                cbl_RearRightQuarterPanel.Visible = false;
                cbl_FrontRightDoor.Visible = false;
                cbl_RearRightDoor.Visible = false;
                cbl_FrontRightWindow.Visible = false;
                cbl_RearRightWindow.Visible = false;
                cbl_RearWindshield.Visible = false;
                cbl_FrontRightWheelTire.Visible = false;
                cbl_RearRightWheelTire.Visible = false;
                cbl_RightTailLight.Visible = false;
                cbl_LeftTailLightdriverside.Visible = false;
                cbl_RightMirror.Visible = false;
                cbl_FrontRightFender.Visible = true;
                DataTable dt = new DataTable();
                dt = imgbll.get_frontrightfender();
                cbl_FrontRightFender.DataSource = dt;
                cbl_FrontRightFender.DataValueField = "FRONTRIGHTFENDERID";
                cbl_FrontRightFender.DataTextField = "FRONTRIGHTFENDERDATA";
                cbl_FrontRightFender.DataBind();
                ViewState["FrontRightFender_tableCkbind_dt"] = dt;
                Partname.Text = "Front Right Fender";
                //get's list of selected item's stored from session
                List<string> FrontRightFenderSelectedItems1 = new List<string>();
                if (Session["FrontRightFender"] != null)
                {
                    FrontRightFenderSelectedItems1 = (List<string>)Session["FrontRightFender"];
                }

                //select items which values match with values from session values
                foreach (string value in FrontRightFenderSelectedItems1)
                {
                    for (int i = 0; i < cbl_FrontRightFender.Items.Count; i++)
                    {
                        //string.Format(Checkbox1.Items[i].Text)
                        //selectedItems.Add(string.Format(Checkbox1.Items[i].Text.ToString())); 
                        //string.Format(Checkbox1.Items[i].Text.ToString()))
                        if (value == cbl_FrontRightFender.Items[i].Value)
                        {
                            cbl_FrontRightFender.Items[i].Selected = true;
                        }
                    }
                }
            }
            //21.Front Right Door
            if (e.PostBackValue == "Front Right Door")
            {
                cbl_FrontBumper.Visible = false;
                cbl_Hood.Visible = false;
                cbl_Roof.Visible = false;
                cbl_FrontLeftFender.Visible = false;
                cbl_FrontLeftDoor.Visible = false;
                cbl_RearLeftDoor.Visible = false;
                cbl_RearLeftQuarterPanel.Visible = false;
                cbl_FrontLeftWindow.Visible = false;
                cbl_RearLeftWindow.Visible = false;
                cbl_FrontWindshield.Visible = false;
                cbl_FrontLeftWheelTire.Visible = false;
                cbl_RearLeftWheelTire.Visible = false;
                cbl_FrontLeftHeadlight.Visible = false;
                cbl_FrontRightHeadlight.Visible = false;
                cbl_LeftMirror.Visible = false;
                cbl_Trunk.Visible = false;
                cbl_RearBumper.Visible = false;
                cbl_RearRightQuarterPanel.Visible = false;
                cbl_FrontRightFender.Visible = false;
                cbl_RearRightDoor.Visible = false;
                cbl_FrontRightWindow.Visible = false;
                cbl_RearRightWindow.Visible = false;
                cbl_RearWindshield.Visible = false;
                cbl_FrontRightWheelTire.Visible = false;
                cbl_RearRightWheelTire.Visible = false;
                cbl_RightTailLight.Visible = false;
                cbl_LeftTailLightdriverside.Visible = false;
                cbl_RightMirror.Visible = false;
                cbl_FrontRightDoor.Visible = true;
                DataTable dt = new DataTable();
                dt = imgbll.get_frontrightdoor();
                cbl_FrontRightDoor.DataSource = dt;
                cbl_FrontRightDoor.DataValueField = "FRONTRIGHTDOORID";
                cbl_FrontRightDoor.DataTextField = "FRONTRIGHTDOORDATA";
                cbl_FrontRightDoor.DataBind();
                ViewState["RearRightQuarterPanel_tableCkbind_dt"] = dt;
                Partname.Text = "Front Right Door";
                //get's list of selected item's stored from session
                List<string> FrontRightDoorSelectedItems1 = new List<string>();
                if (Session["FrontRightDoor"] != null)
                {
                    FrontRightDoorSelectedItems1 = (List<string>)Session["FrontRightDoor"];
                }

                //select items which values match with values from session values
                foreach (string value in FrontRightDoorSelectedItems1)
                {
                    for (int i = 0; i < cbl_FrontRightDoor.Items.Count; i++)
                    {
                        //string.Format(Checkbox1.Items[i].Text)
                        //selectedItems.Add(string.Format(Checkbox1.Items[i].Text.ToString())); 
                        //string.Format(Checkbox1.Items[i].Text.ToString()))
                        if (value == cbl_FrontRightDoor.Items[i].Value)
                        {
                            cbl_FrontRightDoor.Items[i].Selected = true;
                        }
                    }
                }
            }
            //22.Rear Right Door
            if (e.PostBackValue == "Rear Right Door")
            {
                cbl_FrontBumper.Visible = false;
                cbl_Hood.Visible = false;
                cbl_Roof.Visible = false;
                cbl_FrontLeftFender.Visible = false;
                cbl_FrontLeftDoor.Visible = false;
                cbl_RearLeftDoor.Visible = false;
                cbl_RearLeftQuarterPanel.Visible = false;
                cbl_FrontLeftWindow.Visible = false;
                cbl_RearLeftWindow.Visible = false;
                cbl_FrontWindshield.Visible = false;
                cbl_FrontLeftWheelTire.Visible = false;
                cbl_RearLeftWheelTire.Visible = false;
                cbl_FrontLeftHeadlight.Visible = false;
                cbl_FrontRightHeadlight.Visible = false;
                cbl_LeftMirror.Visible = false;
                cbl_Trunk.Visible = false;
                cbl_RearBumper.Visible = false;
                cbl_RearRightQuarterPanel.Visible = false;
                cbl_FrontRightFender.Visible = false;
                cbl_FrontRightDoor.Visible = false;
                cbl_FrontRightWindow.Visible = false;
                cbl_RearRightWindow.Visible = false;
                cbl_RearWindshield.Visible = false;
                cbl_FrontRightWheelTire.Visible = false;
                cbl_RearRightWheelTire.Visible = false;
                cbl_RightTailLight.Visible = false;
                cbl_LeftTailLightdriverside.Visible = false;
                cbl_RightMirror.Visible = false;
                cbl_RearRightDoor.Visible = true;
                DataTable dt = new DataTable();
                dt = imgbll.get_rearrightdoor();
                cbl_RearRightDoor.DataSource = dt;
                cbl_RearRightDoor.DataValueField = "REARRIGHTDOORID";
                cbl_RearRightDoor.DataTextField = "REARRIGHTDOORDATA";
                cbl_RearRightDoor.DataBind();
                ViewState["RearRightDoor_tableCkbind_dt"] = dt;
                Partname.Text = "Rear Right Door";
                //get's list of selected item's stored from session
                List<string> RearRightDoorselectedItems1 = new List<string>();
                if (Session["RearRightDoor"] != null)
                {
                    RearRightDoorselectedItems1 = (List<string>)Session["RearRightDoor"];
                }

                //select items which values match with values from session values
                foreach (string value in RearRightDoorselectedItems1)
                {
                    for (int i = 0; i < cbl_RearRightDoor.Items.Count; i++)
                    {
                        //string.Format(Checkbox1.Items[i].Text)
                        //selectedItems.Add(string.Format(Checkbox1.Items[i].Text.ToString())); 
                        //string.Format(Checkbox1.Items[i].Text.ToString()))
                        if (value == cbl_RearRightDoor.Items[i].Value)
                        {
                            cbl_RearRightDoor.Items[i].Selected = true;
                        }
                    }
                }
            }
            //23.Front Right Window
            if (e.PostBackValue == "Front Right Window")
            {
                cbl_FrontBumper.Visible = false;
                cbl_Hood.Visible = false;
                cbl_Roof.Visible = false;
                cbl_FrontLeftFender.Visible = false;
                cbl_FrontLeftDoor.Visible = false;
                cbl_RearLeftDoor.Visible = false;
                cbl_RearLeftQuarterPanel.Visible = false;
                cbl_FrontLeftWindow.Visible = false;
                cbl_RearLeftWindow.Visible = false;
                cbl_FrontWindshield.Visible = false;
                cbl_FrontLeftWheelTire.Visible = false;
                cbl_RearLeftWheelTire.Visible = false;
                cbl_FrontLeftHeadlight.Visible = false;
                cbl_FrontRightHeadlight.Visible = false;
                cbl_LeftMirror.Visible = false;
                cbl_Trunk.Visible = false;
                cbl_RearBumper.Visible = false;
                cbl_RearRightQuarterPanel.Visible = false;
                cbl_FrontRightFender.Visible = false;
                cbl_FrontRightDoor.Visible = false;
                cbl_RearRightDoor.Visible = false;
                cbl_RearRightWindow.Visible = false;
                cbl_RearWindshield.Visible = false;
                cbl_FrontRightWheelTire.Visible = false;
                cbl_RearRightWheelTire.Visible = false;
                cbl_RightTailLight.Visible = false;
                cbl_LeftTailLightdriverside.Visible = false;
                cbl_RightMirror.Visible = false;
                cbl_FrontRightWindow.Visible = true;
                DataTable dt = new DataTable();
                dt = imgbll.get_frontrightwindow();
                cbl_FrontRightWindow.DataSource = dt;
                cbl_FrontRightWindow.DataValueField = "FRONTRIGHTWINDOWID";
                cbl_FrontRightWindow.DataTextField = "FRONTRIGHTWINDOWDATA";
                cbl_FrontRightWindow.DataBind();
                ViewState["FrontRightWindow_tableCkbind_dt"] = dt;
                Partname.Text = "Front Right Window";
                //get's list of selected item's stored from session
                List<string> FrontRightWindowselectedItems1 = new List<string>();
                if (Session["FrontRightWindow"] != null)
                {
                    FrontRightWindowselectedItems1 = (List<string>)Session["FrontRightWindow"];
                }

                //select items which values match with values from session values
                foreach (string value in FrontRightWindowselectedItems1)
                {
                    for (int i = 0; i < cbl_FrontRightWindow.Items.Count; i++)
                    {
                        //string.Format(Checkbox1.Items[i].Text)
                        //selectedItems.Add(string.Format(Checkbox1.Items[i].Text.ToString())); 
                        //string.Format(Checkbox1.Items[i].Text.ToString()))
                        if (value == cbl_FrontRightWindow.Items[i].Value)
                        {
                            cbl_FrontRightWindow.Items[i].Selected = true;
                        }
                    }
                }
            }
            //24.Rear Right Window
            if (e.PostBackValue == "Rear Right Window")
            {
                cbl_FrontBumper.Visible = false;
                cbl_Hood.Visible = false;
                cbl_Roof.Visible = false;
                cbl_FrontLeftFender.Visible = false;
                cbl_FrontLeftDoor.Visible = false;
                cbl_RearLeftDoor.Visible = false;
                cbl_RearLeftQuarterPanel.Visible = false;
                cbl_FrontLeftWindow.Visible = false;
                cbl_RearLeftWindow.Visible = false;
                cbl_FrontWindshield.Visible = false;
                cbl_FrontLeftWheelTire.Visible = false;
                cbl_RearLeftWheelTire.Visible = false;
                cbl_FrontLeftHeadlight.Visible = false;
                cbl_FrontRightHeadlight.Visible = false;
                cbl_LeftMirror.Visible = false;
                cbl_Trunk.Visible = false;
                cbl_RearBumper.Visible = false;
                cbl_RearRightQuarterPanel.Visible = false;
                cbl_FrontRightFender.Visible = false;
                cbl_FrontRightDoor.Visible = false;
                cbl_RearRightDoor.Visible = false;
                cbl_FrontRightWindow.Visible = false;
                cbl_RearWindshield.Visible = false;
                cbl_FrontRightWheelTire.Visible = false;
                cbl_RearRightWheelTire.Visible = false;
                cbl_RightTailLight.Visible = false;
                cbl_LeftTailLightdriverside.Visible = false;
                cbl_RightMirror.Visible = false;
                cbl_RearRightWindow.Visible = true;
                DataTable dt = new DataTable();
                dt = imgbll.get_rearrightwindow();
                cbl_RearRightWindow.DataSource = dt;
                cbl_RearRightWindow.DataValueField = "REARRIGHTWINDOWID";
                cbl_RearRightWindow.DataTextField = "REARRIGHTWINDOWDATA";
                cbl_RearRightWindow.DataBind();
                ViewState["RearRightWindow_tableCkbind_dt"] = dt;
                Partname.Text = "Rear Right Window";
                //get's list of selected item's stored from session
                List<string> RearRightWindowselectedItems1 = new List<string>();
                if (Session["RearRightWindow"] != null)
                {
                    RearRightWindowselectedItems1 = (List<string>)Session["RearRightWindow"];
                }

                //select items which values match with values from session values
                foreach (string value in RearRightWindowselectedItems1)
                {
                    for (int i = 0; i < cbl_RearRightWindow.Items.Count; i++)
                    {
                        //string.Format(Checkbox1.Items[i].Text)
                        //selectedItems.Add(string.Format(Checkbox1.Items[i].Text.ToString())); 
                        //string.Format(Checkbox1.Items[i].Text.ToString()))
                        if (value == cbl_RearRightWindow.Items[i].Value)
                        {
                            cbl_RearRightWindow.Items[i].Selected = true;
                        }
                    }
                }
            }
            //25.Rear Windshield
            if (e.PostBackValue == "Rear Windshield")
            {
                cbl_FrontBumper.Visible = false;
                cbl_Hood.Visible = false;
                cbl_Roof.Visible = false;
                cbl_FrontLeftFender.Visible = false;
                cbl_FrontLeftDoor.Visible = false;
                cbl_RearLeftDoor.Visible = false;
                cbl_RearLeftQuarterPanel.Visible = false;
                cbl_FrontLeftWindow.Visible = false;
                cbl_RearLeftWindow.Visible = false;
                cbl_FrontWindshield.Visible = false;
                cbl_FrontLeftWheelTire.Visible = false;
                cbl_RearLeftWheelTire.Visible = false;
                cbl_FrontLeftHeadlight.Visible = false;
                cbl_FrontRightHeadlight.Visible = false;
                cbl_LeftMirror.Visible = false;
                cbl_Trunk.Visible = false;
                cbl_RearBumper.Visible = false;
                cbl_RearRightQuarterPanel.Visible = false;
                cbl_FrontRightFender.Visible = false;
                cbl_FrontRightDoor.Visible = false;
                cbl_RearRightDoor.Visible = false;
                cbl_FrontRightWindow.Visible = false;
                cbl_RearRightWindow.Visible = false;
                cbl_FrontRightWheelTire.Visible = false;
                cbl_RearRightWheelTire.Visible = false;
                cbl_RightTailLight.Visible = false;
                cbl_LeftTailLightdriverside.Visible = false;
                cbl_RightMirror.Visible = false;
                cbl_RearWindshield.Visible = true;
                DataTable dt = new DataTable();
                dt = imgbll.get_rearwindshield();
                cbl_RearWindshield.DataSource = dt;
                cbl_RearWindshield.DataValueField = "REARWINDSHIELDID";
                cbl_RearWindshield.DataTextField = "REARWINDSHIELDDATA";
                cbl_RearWindshield.DataBind();
                ViewState["RearWindshield_tableCkbind_dt"] = dt;
                Partname.Text = "Rear Windshield";
                //get's list of selected item's stored from session
                List<string> RearWindshieldselectedItems1 = new List<string>();
                if (Session["RearWindshield"] != null)
                {
                    RearWindshieldselectedItems1 = (List<string>)Session["RearWindshield"];
                }

                //select items which values match with values from session values
                foreach (string value in RearWindshieldselectedItems1)
                {
                    for (int i = 0; i < cbl_RearWindshield.Items.Count; i++)
                    {
                        //string.Format(Checkbox1.Items[i].Text)
                        //selectedItems.Add(string.Format(Checkbox1.Items[i].Text.ToString())); 
                        //string.Format(Checkbox1.Items[i].Text.ToString()))
                        if (value == cbl_RearWindshield.Items[i].Value)
                        {
                            cbl_RearWindshield.Items[i].Selected = true;
                        }
                    }
                }
            }
            //26.Front Right Wheel & Tire
            if (e.PostBackValue == "Front Right Wheel & Tire")
            {
                cbl_FrontBumper.Visible = false;
                cbl_Hood.Visible = false;
                cbl_Roof.Visible = false;
                cbl_FrontLeftFender.Visible = false;
                cbl_FrontLeftDoor.Visible = false;
                cbl_RearLeftDoor.Visible = false;
                cbl_RearLeftQuarterPanel.Visible = false;
                cbl_FrontLeftWindow.Visible = false;
                cbl_RearLeftWindow.Visible = false;
                cbl_FrontWindshield.Visible = false;
                cbl_FrontLeftWheelTire.Visible = false;
                cbl_RearLeftWheelTire.Visible = false;
                cbl_FrontLeftHeadlight.Visible = false;
                cbl_FrontRightHeadlight.Visible = false;
                cbl_LeftMirror.Visible = false;
                cbl_Trunk.Visible = false;
                cbl_RearBumper.Visible = false;
                cbl_RearRightQuarterPanel.Visible = false;
                cbl_FrontRightFender.Visible = false;
                cbl_FrontRightDoor.Visible = false;
                cbl_RearRightDoor.Visible = false;
                cbl_FrontRightWindow.Visible = false;
                cbl_RearRightWindow.Visible = false;
                cbl_RearWindshield.Visible = false;
                cbl_RearRightWheelTire.Visible = false;
                cbl_RightTailLight.Visible = false;
                cbl_LeftTailLightdriverside.Visible = false;
                cbl_RightMirror.Visible = false;
                cbl_FrontRightWheelTire.Visible = true;
                DataTable dt = new DataTable();
                dt = imgbll.get_frontrightwheeltire();
                cbl_FrontRightWheelTire.DataSource = dt;
                cbl_FrontRightWheelTire.DataValueField = "FRONTRIGHTWHEELTIREID";
                cbl_FrontRightWheelTire.DataTextField = "FRONTRIGHTWHEELTIREDATA";
                cbl_FrontRightWheelTire.DataBind();
                ViewState["FrontRightWheelTire_tableCkbind_dt"] = dt;
                Partname.Text = "Front Right Wheel & Tire";
                //get's list of selected item's stored from session
                List<string> FrontRightWheelTireselectedItems1 = new List<string>();
                if (Session["FrontRightWheelTire"] != null)
                {
                    FrontRightWheelTireselectedItems1 = (List<string>)Session["FrontRightWheelTire"];
                }

                //select items which values match with values from session values
                foreach (string value in FrontRightWheelTireselectedItems1)
                {
                    for (int i = 0; i < cbl_FrontRightWheelTire.Items.Count; i++)
                    {
                        //string.Format(Checkbox1.Items[i].Text)
                        //selectedItems.Add(string.Format(Checkbox1.Items[i].Text.ToString())); 
                        //string.Format(Checkbox1.Items[i].Text.ToString()))
                        if (value == cbl_FrontRightWheelTire.Items[i].Value)
                        {
                            cbl_FrontRightWheelTire.Items[i].Selected = true;
                        }
                    }
                }
            }
            //27.Rear Right Wheel & Tire
            if (e.PostBackValue == "Rear Right Wheel & Tire")
            {
                cbl_FrontBumper.Visible = false;
                cbl_Hood.Visible = false;
                cbl_Roof.Visible = false;
                cbl_FrontLeftFender.Visible = false;
                cbl_FrontLeftDoor.Visible = false;
                cbl_RearLeftDoor.Visible = false;
                cbl_RearLeftQuarterPanel.Visible = false;
                cbl_FrontLeftWindow.Visible = false;
                cbl_RearLeftWindow.Visible = false;
                cbl_FrontWindshield.Visible = false;
                cbl_FrontLeftWheelTire.Visible = false;
                cbl_RearLeftWheelTire.Visible = false;
                cbl_FrontLeftHeadlight.Visible = false;
                cbl_FrontRightHeadlight.Visible = false;
                cbl_LeftMirror.Visible = false;
                cbl_Trunk.Visible = false;
                cbl_RearBumper.Visible = false;
                cbl_RearRightQuarterPanel.Visible = false;
                cbl_FrontRightFender.Visible = false;
                cbl_FrontRightDoor.Visible = false;
                cbl_RearRightDoor.Visible = false;
                cbl_FrontRightWindow.Visible = false;
                cbl_RearRightWindow.Visible = false;
                cbl_RearWindshield.Visible = false;
                cbl_FrontRightWheelTire.Visible = false;
                cbl_RightTailLight.Visible = false;
                cbl_LeftTailLightdriverside.Visible = false;
                cbl_RightMirror.Visible = false;
                cbl_RearRightWheelTire.Visible = true;
                DataTable dt = new DataTable();
                dt = imgbll.get_rearrightwheeltire();
                cbl_RearRightWheelTire.DataSource = dt;
                cbl_RearRightWheelTire.DataValueField = "REARRIGHTWHEELTIREID";
                cbl_RearRightWheelTire.DataTextField = "REARRIGHTWHEELTIREDATA";
                cbl_RearRightWheelTire.DataBind();
                ViewState["RearRightWheelTire_tableCkbind_dt"] = dt;
                Partname.Text = "Rear Right Wheel & Tire";
                //get's list of selected item's stored from session
                List<string> RearRightWheelTireselectedItems1 = new List<string>();
                if (Session["RearRightWheelTire"] != null)
                {
                    RearRightWheelTireselectedItems1 = (List<string>)Session["RearRightWheelTire"];
                }

                //select items which values match with values from session values
                foreach (string value in RearRightWheelTireselectedItems1)
                {
                    for (int i = 0; i < cbl_RearRightWheelTire.Items.Count; i++)
                    {
                        //string.Format(Checkbox1.Items[i].Text)
                        //selectedItems.Add(string.Format(Checkbox1.Items[i].Text.ToString())); 
                        //string.Format(Checkbox1.Items[i].Text.ToString()))
                        if (value == cbl_RearRightWheelTire.Items[i].Value)
                        {
                            cbl_RearRightWheelTire.Items[i].Selected = true;
                        }
                    }
                }
            }
            //28.Right Tail Light
            if (e.PostBackValue == "Right Tail Light")
            {
                cbl_FrontBumper.Visible = false;
                cbl_Hood.Visible = false;
                cbl_Roof.Visible = false;
                cbl_FrontLeftFender.Visible = false;
                cbl_FrontLeftDoor.Visible = false;
                cbl_RearLeftDoor.Visible = false;
                cbl_RearLeftQuarterPanel.Visible = false;
                cbl_FrontLeftWindow.Visible = false;
                cbl_RearLeftWindow.Visible = false;
                cbl_FrontWindshield.Visible = false;
                cbl_FrontLeftWheelTire.Visible = false;
                cbl_RearLeftWheelTire.Visible = false;
                cbl_FrontLeftHeadlight.Visible = false;
                cbl_FrontRightHeadlight.Visible = false;
                cbl_LeftMirror.Visible = false;
                cbl_Trunk.Visible = false;
                cbl_RearBumper.Visible = false;
                cbl_RearRightQuarterPanel.Visible = false;
                cbl_FrontRightFender.Visible = false;
                cbl_FrontRightDoor.Visible = false;
                cbl_RearRightDoor.Visible = false;
                cbl_FrontRightWindow.Visible = false;
                cbl_RearRightWindow.Visible = false;
                cbl_RearWindshield.Visible = false;
                cbl_FrontRightWheelTire.Visible = false;
                cbl_RearRightWheelTire.Visible = false;
                cbl_LeftTailLightdriverside.Visible = false;
                cbl_RightMirror.Visible = false;
                cbl_RightTailLight.Visible = true;
                DataTable dt = new DataTable();
                dt = imgbll.get_righttaillight();
                cbl_RightTailLight.DataSource = dt;
                cbl_RightTailLight.DataValueField = "RIGHTTAILLIGHTID";
                cbl_RightTailLight.DataTextField = "RIGHTTAILLIGHTDATA";
                cbl_RightTailLight.DataBind();
                ViewState["RightTailLight_tableCkbind_dt"] = dt;
                Partname.Text = "Right Tail Light";
                //get's list of selected item's stored from session
                List<string> RightTailLightselectedItems1 = new List<string>();
                if (Session["RightTailLight"] != null)
                {
                    RightTailLightselectedItems1 = (List<string>)Session["RightTailLight"];
                }

                //select items which values match with values from session values
                foreach (string value in RightTailLightselectedItems1)
                {
                    for (int i = 0; i < cbl_RightTailLight.Items.Count; i++)
                    {
                        //string.Format(Checkbox1.Items[i].Text)
                        //selectedItems.Add(string.Format(Checkbox1.Items[i].Text.ToString())); 
                        //string.Format(Checkbox1.Items[i].Text.ToString()))
                        if (value == cbl_RightTailLight.Items[i].Value)
                        {
                            cbl_RightTailLight.Items[i].Selected = true;
                        }
                    }
                }
            }
            //29.Left Tail Light(driver side)
            if (e.PostBackValue == "Left Tail Light(driver side)")
            {
                cbl_FrontBumper.Visible = false;
                cbl_Hood.Visible = false;
                cbl_Roof.Visible = false;
                cbl_FrontLeftFender.Visible = false;
                cbl_FrontLeftDoor.Visible = false;
                cbl_RearLeftDoor.Visible = false;
                cbl_RearLeftQuarterPanel.Visible = false;
                cbl_FrontLeftWindow.Visible = false;
                cbl_RearLeftWindow.Visible = false;
                cbl_FrontWindshield.Visible = false;
                cbl_FrontLeftWheelTire.Visible = false;
                cbl_RearLeftWheelTire.Visible = false;
                cbl_FrontLeftHeadlight.Visible = false;
                cbl_FrontRightHeadlight.Visible = false;
                cbl_LeftMirror.Visible = false;
                cbl_Trunk.Visible = false;
                cbl_RearBumper.Visible = false;
                cbl_RearRightQuarterPanel.Visible = false;
                cbl_FrontRightFender.Visible = false;
                cbl_FrontRightDoor.Visible = false;
                cbl_RearRightDoor.Visible = false;
                cbl_FrontRightWindow.Visible = false;
                cbl_RearRightWindow.Visible = false;
                cbl_RearWindshield.Visible = false;
                cbl_FrontRightWheelTire.Visible = false;
                cbl_RearRightWheelTire.Visible = false;
                cbl_RightTailLight.Visible = false;
                cbl_RightMirror.Visible = false;
                cbl_LeftTailLightdriverside.Visible = true;
                DataTable dt = new DataTable();
                dt = imgbll.get_lefttaillightdriverside();
                cbl_LeftTailLightdriverside.DataSource = dt;
                cbl_LeftTailLightdriverside.DataValueField = "LEFTTAILLIGHTDRIVERSIDEID";
                cbl_LeftTailLightdriverside.DataTextField = "LEFTTAILLIGHTDRIVERSIDEDATA";
                cbl_LeftTailLightdriverside.DataBind();
                ViewState["LeftTailLightdriverside_tableCkbind_dt"] = dt;
                Partname.Text = "Left Tail Light(driver side)";
                //get's list of selected item's stored from session
                List<string> LeftTailLightdriversideselectedItems1 = new List<string>();
                if (Session["LeftTailLightdriverside)"] != null)
                {
                    LeftTailLightdriversideselectedItems1 = (List<string>)Session["LeftTailLightdriverside"];
                }

                //select items which values match with values from session values
                foreach (string value in LeftTailLightdriversideselectedItems1)
                {
                    for (int i = 0; i < cbl_LeftTailLightdriverside.Items.Count; i++)
                    {
                        //string.Format(Checkbox1.Items[i].Text)
                        //selectedItems.Add(string.Format(Checkbox1.Items[i].Text.ToString())); 
                        //string.Format(Checkbox1.Items[i].Text.ToString()))
                        if (value == cbl_LeftTailLightdriverside.Items[i].Value)
                        {
                            cbl_LeftTailLightdriverside.Items[i].Selected = true;
                        }
                    }
                }
            }
            //30.Right Mirror
            if (e.PostBackValue == "Right Mirror")
            {
                cbl_FrontBumper.Visible = false;
                cbl_Hood.Visible = false;
                cbl_Roof.Visible = false;
                cbl_FrontLeftFender.Visible = false;
                cbl_FrontLeftDoor.Visible = false;
                cbl_RearLeftDoor.Visible = false;
                cbl_RearLeftQuarterPanel.Visible = false;
                cbl_FrontLeftWindow.Visible = false;
                cbl_RearLeftWindow.Visible = false;
                cbl_FrontWindshield.Visible = false;
                cbl_FrontLeftWheelTire.Visible = false;
                cbl_RearLeftWheelTire.Visible = false;
                cbl_FrontLeftHeadlight.Visible = false;
                cbl_FrontRightHeadlight.Visible = false;
                cbl_LeftMirror.Visible = false;
                cbl_Trunk.Visible = false;
                cbl_RearBumper.Visible = false;
                cbl_RearRightQuarterPanel.Visible = false;
                cbl_FrontRightFender.Visible = false;
                cbl_FrontRightDoor.Visible = false;
                cbl_RearRightDoor.Visible = false;
                cbl_FrontRightWindow.Visible = false;
                cbl_RearRightWindow.Visible = false;
                cbl_RearWindshield.Visible = false;
                cbl_FrontRightWheelTire.Visible = false;
                cbl_RearRightWheelTire.Visible = false;
                cbl_RightTailLight.Visible = false;
                cbl_LeftTailLightdriverside.Visible = false;
                cbl_RightMirror.Visible = true;
                DataTable dt = new DataTable();
                dt = imgbll.get_rightmirror();
                cbl_RightMirror.DataSource = dt;
                cbl_RightMirror.DataValueField = "RIGHTMIRRORID";
                cbl_RightMirror.DataTextField = "RIGHTMIRRORDATA";
                cbl_RightMirror.DataBind();
                ViewState["RightMirror_tableCkbind_dt"] = dt;
                Partname.Text = "Right Mirror";
                //get's list of selected item's stored from session
                List<string> RightMirrorselectedItems1 = new List<string>();
                if (Session["RightMirror"] != null)
                {
                    RightMirrorselectedItems1 = (List<string>)Session["RightMirror"];
                }

                //select items which values match with values from session values
                foreach (string value in RightMirrorselectedItems1)
                {
                    for (int i = 0; i < cbl_RightMirror.Items.Count; i++)
                    {
                        //string.Format(Checkbox1.Items[i].Text)
                        //selectedItems.Add(string.Format(Checkbox1.Items[i].Text.ToString())); 
                        //string.Format(Checkbox1.Items[i].Text.ToString()))
                        if (value == cbl_RightMirror.Items[i].Value)
                        {
                            cbl_RightMirror.Items[i].Selected = true;
                        }
                    }
                }
            }
            //Rotate View Front Image
            else if (e.PostBackValue == "Rotate View Front Image")
            {
                ImageMap2.Visible = false;
                ImageMap1.Visible = true;
            }
            //Rotate View Back Image
            else if (e.PostBackValue == "Rotate View Back Image")
            {
                ImageMap2.Visible = true;
                ImageMap1.Visible = false;
            }
        }

        //OnSelected Index Changed Events//
        //1.Front Bumper
        protected void FrontBumper_SelectedItems(object sender, EventArgs e)
        {
            //string name = Partname.Text.ToString();
            //dt.Columns.Add(name);
            dt.Columns.Add("Content");
            dt.Columns.Add("id");
            dt.Columns.Add("STATUS");
            dt.Columns.Add("VIN_ID");

            for (int i = 0; i < cbl_FrontBumper.Items.Count; i++)
            {
                if (cbl_FrontBumper.Items[i].Selected == true)
                {
                    DataRow dr = dt.NewRow();
                    dr["Content"] = cbl_FrontBumper.Items[i].Text.ToString();
                    dr["STATUS"] = 0;
                    int vinid = Convert.ToInt32(Session["id_vin"]);
                    dr["VIN_ID"] = vinid;
                    dr["id"] = cbl_FrontBumper.Items[i].Value;
                    dt.Rows.Add(dr);

                }

                if (Partname.Text == "Front Bumper")
                {
                    //FrontBumper_Div.Visible = true;
                    //FrontBumper_lbl.Visible = true;
                    ViewState["FrontBumper_dt"] = dt;
                    if (dt.Rows.Count != 0)
                    {
                        gv_FrontBumper.DataSource = dt;
                        gv_FrontBumper.DataBind();
                        ViewState["FrontBumper_fill_summary"] = dt;
                        //FrontBumper_Div.Visible = true;

                        //  Session["FrontBumper_fill_summary"] = dt;
                        //List for selected items
                        List<string> FrontBumperSelectedItems2 = new List<string>();

                        //Loop's thouhgt CheckboxList items to check which values are checked
                        for (int j = 0; j < cbl_FrontBumper.Items.Count; j++)
                        {
                            if (cbl_FrontBumper.Items[j].Selected)
                            {
                                // selectedItems.Add(string.Format(Checkbox1.Items[i].Text.ToString()));
                                FrontBumperSelectedItems2.Add(cbl_FrontBumper.Items[j].Value);

                            }
                        }
                        Session["FrontBumper"] = FrontBumperSelectedItems2;
                    }
                }
            }
        }
        //2.Hood
        protected void Hood_SelectedItems(object sender, EventArgs e)
        {
            //string name = Partname.Text.ToString();
            //dt.Columns.Add(name);
            dt.Columns.Add("Content");
            dt.Columns.Add("id");
            dt.Columns.Add("STATUS");
            dt.Columns.Add("VIN_ID");

            for (int i = 0; i < cbl_Hood.Items.Count; i++)
            {
                if (cbl_Hood.Items[i].Selected == true)
                {
                    DataRow dr = dt.NewRow();
                    dr["Content"] = cbl_Hood.Items[i].Text.ToString();
                    dr["STATUS"] = 0;
                    int vinid = Convert.ToInt32(Session["id_vin"]);
                    dr["VIN_ID"] = vinid;
                    dr["id"] = cbl_Hood.Items[i].Value;
                    dt.Rows.Add(dr);

                }

                if (Partname.Text == "Hood")
                {
                    ViewState["Hood_dt"] = dt;
                    if (dt.Rows.Count != 0)
                    {
                        gv_Hood.DataSource = dt;
                        gv_Hood.DataBind();
                       // gv_Hood_Div.Visible = true;

                        ViewState["Hood_fill_summary"] = dt;
                        //List for selected items
                        List<string> HoodSelectedItems2 = new List<string>();

                        //Loop's thouhgt CheckboxList items to check which values are checked
                        for (int j = 0; j < cbl_Hood.Items.Count; j++)
                        {
                            if (cbl_Hood.Items[j].Selected)
                            {
                                // selectedItems.Add(string.Format(Checkbox1.Items[i].Text.ToString()));
                                HoodSelectedItems2.Add(cbl_Hood.Items[j].Value);

                            }
                        }
                        Session["Hood"] = HoodSelectedItems2;
                    }
                }
            }
        }
        //3.Roof
        protected void Roof_SelectedItems(object sender, EventArgs e)
        {
            //string name = Partname.Text.ToString();
            //dt.Columns.Add(name);
            dt.Columns.Add("Content");
            dt.Columns.Add("id");
            dt.Columns.Add("STATUS");
            dt.Columns.Add("VIN_ID");

            for (int i = 0; i < cbl_Roof.Items.Count; i++)
            {
                if (cbl_Roof.Items[i].Selected == true)
                {
                    DataRow dr = dt.NewRow();
                    dr["Content"] = cbl_Roof.Items[i].Text.ToString();
                    dr["STATUS"] = 0;
                    int vinid = Convert.ToInt32(Session["id_vin"]);
                    dr["VIN_ID"] = vinid;
                    dr["id"] = cbl_Roof.Items[i].Value;
                    dt.Rows.Add(dr);

                }

                if (Partname.Text == "Roof")
                {
                    ViewState["Roof_dt"] = dt;
                    if (dt.Rows.Count != 0)
                    {
                        gv_Roof.DataSource = dt;
                        gv_Roof.DataBind();
                       // gv_Roof_div.Visible = true;
                        ViewState["Roof_fill_summary"] = dt;
                        //List for selected items
                        List<string> RoofSelectedItems2 = new List<string>();

                        //Loop's thouhgt CheckboxList items to check which values are checked
                        for (int j = 0; j < cbl_Roof.Items.Count; j++)
                        {
                            if (cbl_Roof.Items[j].Selected)
                            {
                                // selectedItems.Add(string.Format(Checkbox1.Items[i].Text.ToString()));
                                RoofSelectedItems2.Add(cbl_Roof.Items[j].Value);

                            }
                        }
                        Session["Roof"] = RoofSelectedItems2;
                    }
                }
            }
        }
        //4.Front Left Fender
        protected void FrontLeftFender_SelectedItems(object sender, EventArgs e)
        {
            //string name = Partname.Text.ToString();
            //dt.Columns.Add(name);
            dt.Columns.Add("Content");
            dt.Columns.Add("id");
            dt.Columns.Add("STATUS");
            dt.Columns.Add("VIN_ID");

            
            for (int i = 0; i < cbl_FrontLeftFender.Items.Count; i++)
            {
                if (cbl_FrontLeftFender.Items[i].Selected == true)
                {
                    DataRow dr = dt.NewRow();
                    dr["Content"] = cbl_FrontLeftFender.Items[i].Text.ToString();
                    dr["STATUS"] = 0;
                    int vinid = Convert.ToInt32(Session["id_vin"]);
                    dr["VIN_ID"] = vinid;
                    dr["id"] = cbl_FrontLeftFender.Items[i].Value;
                    dt.Rows.Add(dr);

                }
                if (Partname.Text == "Front Left Fender")
                {
                    ViewState["FrontLeftFender_dt"] = dt;
                    if (dt.Rows.Count != 0)
                    {
                        gv_FrontLeftFender.DataSource = dt;

                        gv_FrontLeftFender.DataBind();
                       // gv_FrontLeftFender_Div.Visible = true;
                        ViewState["FrontLeftFender_fill_summary"] = dt;
                        //List for selected items
                        List<string> FrontLeftFenderselectedItems2 = new List<string>();

                        //Loop's thouhgt CheckboxList items to check which values are checked
                        for (int j = 0; j < cbl_FrontLeftFender.Items.Count; j++)
                        {
                            if (cbl_FrontLeftFender.Items[j].Selected)
                            {
                                // selectedItems.Add(string.Format(Checkbox1.Items[i].Text.ToString()));
                                FrontLeftFenderselectedItems2.Add(cbl_FrontLeftFender.Items[j].Value);

                            }
                        }
                        Session["FrontLeftFender"] = FrontLeftFenderselectedItems2;
                    }
                }
            }
        }
        //5.Front Left Door
        protected void FrontLeftDoor_SelectedItems(object sender, EventArgs e)
        {
            //string name = Partname.Text.ToString();
            //dt.Columns.Add(name);
            dt.Columns.Add("Content");
            dt.Columns.Add("id");
            dt.Columns.Add("STATUS");
            dt.Columns.Add("VIN_ID");


            for (int i = 0; i < cbl_FrontLeftDoor.Items.Count; i++)
            {
                if (cbl_FrontLeftDoor.Items[i].Selected == true)
                {
                    DataRow dr = dt.NewRow();
                    dr["Content"] = cbl_FrontLeftDoor.Items[i].Text.ToString();
                    dr["STATUS"] = 0;
                    int vinid = Convert.ToInt32(Session["id_vin"]);
                    dr["VIN_ID"] = vinid;
                    dr["id"] = cbl_FrontLeftDoor.Items[i].Value;
                    dt.Rows.Add(dr);

                }
                if (Partname.Text == "Front Left Door")
                {
                    ViewState["FrontLeftDoor_dt"] = dt;
                    if (dt.Rows.Count != 0)
                    {
                        gv_FrontLeftDoor.DataSource = dt;
                        gv_FrontLeftDoor.DataBind();
                       // gv_FrontLeftDoor_Div.Visible = true;
                        ViewState["FrontLeftDoor_Fill_summary"] = dt;
                        //List for selected items
                        List<string> FrontLeftDoorselectedItems2 = new List<string>();

                        //Loop's thouhgt CheckboxList items to check which values are checked
                        for (int j = 0; j < cbl_FrontLeftDoor.Items.Count; j++)
                        {
                            if (cbl_FrontLeftDoor.Items[j].Selected)
                            {
                                // selectedItems.Add(string.Format(Checkbox1.Items[i].Text.ToString()));
                                FrontLeftDoorselectedItems2.Add(cbl_FrontLeftDoor.Items[j].Value);

                            }
                        }
                        Session["FrontLeftDoor"] = FrontLeftDoorselectedItems2;
                    }
                }
            }
        }
        //6.Rear Left Door
        protected void RearLeftDoor_SelectedItems(object sender, EventArgs e)
        {
            //string name = Partname.Text.ToString();
            //dt.Columns.Add(name);
            dt.Columns.Add("Content");
            dt.Columns.Add("id");
            dt.Columns.Add("STATUS");
            dt.Columns.Add("VIN_ID");


            for (int i = 0; i < cbl_RearLeftDoor.Items.Count; i++)
            {
                if (cbl_RearLeftDoor.Items[i].Selected == true)
                {
                    DataRow dr = dt.NewRow();
                    dr["Content"] = cbl_RearLeftDoor.Items[i].Text.ToString();
                    dr["STATUS"] = 0;
                    int vinid = Convert.ToInt32(Session["id_vin"]);
                    dr["VIN_ID"] = vinid;
                    dr["id"] = cbl_RearLeftDoor.Items[i].Value;
                    dt.Rows.Add(dr);

                }
                if (Partname.Text == "Rear Left Door")
                {
                    ViewState["RearLeftDoor_dt"] = dt;
                    if (dt.Rows.Count != 0)
                    {
                        gv_RearLeftDoor.DataSource = dt;
                        gv_RearLeftDoor.DataBind();
                       // gv_RearLeftDoor_Div.Visible = true;
                        ViewState["RearLeftDoor_fill_summary"] = dt;
                        //List for selected items
                        List<string> RearLeftDoorselectedItems2 = new List<string>();

                        //Loop's thouhgt CheckboxList items to check which values are checked
                        for (int j = 0; j < cbl_RearLeftDoor.Items.Count; j++)
                        {
                            if (cbl_RearLeftDoor.Items[j].Selected)
                            {
                                // selectedItems.Add(string.Format(Checkbox1.Items[i].Text.ToString()));
                                RearLeftDoorselectedItems2.Add(cbl_RearLeftDoor.Items[j].Value);

                            }
                        }
                        Session["RearLeftDoor"] = RearLeftDoorselectedItems2;
                    }
                }
            }
        }
        //7.Rear Left Quarter Panel
        protected void RearLeftQuarterPanel_SelectedItems(object sender, EventArgs e)
        {
            //string name = Partname.Text.ToString();
            //dt.Columns.Add(name);
            dt.Columns.Add("Content");
            dt.Columns.Add("id");
            dt.Columns.Add("STATUS");
            dt.Columns.Add("VIN_ID");

            for (int i = 0; i < cbl_RearLeftQuarterPanel.Items.Count; i++)
            {
                if (cbl_RearLeftQuarterPanel.Items[i].Selected == true)
                {
                    DataRow dr = dt.NewRow();
                    dr["Content"] = cbl_RearLeftQuarterPanel.Items[i].Text.ToString();
                    dr["STATUS"] = 0;
                    int vinid = Convert.ToInt32(Session["id_vin"]);
                    dr["VIN_ID"] = vinid;

                    dr["id"] = cbl_RearLeftQuarterPanel.Items[i].Value;
                    dt.Rows.Add(dr);

                }
                if (Partname.Text == "Rear Left Quarter Panel")
                {
                    ViewState["RearLeftQuarterPanel_dt"] = dt;
                    if (dt.Rows.Count != 0)
                    {
                        gv_RearLeftQuarterPanel.DataSource = dt;
                        gv_RearLeftQuarterPanel.DataBind();
                       // gv_RearLeftQuarterPanelDiv10.Visible = true;
                        ViewState["RearLeftQuarterPanel_fill_summary"] = dt;
                        //List for selected items
                        List<string> RearLeftQuarterPanelselectedItems2 = new List<string>();

                        //Loop's thouhgt CheckboxList items to check which values are checked
                        for (int j = 0; j < cbl_RearLeftQuarterPanel.Items.Count; j++)
                        {
                            if (cbl_RearLeftQuarterPanel.Items[j].Selected)
                            {
                                // selectedItems.Add(string.Format(Checkbox1.Items[i].Text.ToString()));
                                RearLeftQuarterPanelselectedItems2.Add(cbl_RearLeftQuarterPanel.Items[j].Value);

                            }
                        }
                        Session["RearLeftQuarterPanel"] = RearLeftQuarterPanelselectedItems2;
                    }
                }
            }
        }
        //8.Front Left Window
        protected void FrontLeftWindow_SelectedItems(object sender, EventArgs e)
        {
            //string name = Partname.Text.ToString();
            //dt.Columns.Add(name);
            dt.Columns.Add("Content");
            dt.Columns.Add("id");
            dt.Columns.Add("STATUS");
            dt.Columns.Add("VIN_ID");

            for (int i = 0; i < cbl_FrontLeftWindow.Items.Count; i++)
            {
                if (cbl_FrontLeftWindow.Items[i].Selected == true)
                {
                    DataRow dr = dt.NewRow();
                    dr["Content"] = cbl_FrontLeftWindow.Items[i].Text.ToString();
                    dr["STATUS"] = 0;
                    int vinid = Convert.ToInt32(Session["id_vin"]);
                    dr["VIN_ID"] = vinid;

                    dr["id"] = cbl_FrontLeftWindow.Items[i].Value;
                    dt.Rows.Add(dr);

                }
                if (Partname.Text == "Front Left Window")
                {
                    ViewState["FrontLeftWindow_dt"] = dt;
                    if (dt.Rows.Count != 0)
                    {
                        gv_FrontLeftWindow.DataSource = dt;
                        gv_FrontLeftWindow.DataBind();
                       // gv_FrontLeftWindowDiv11.Visible = true;
                        ViewState["FrontLeftWindow_fill_summary"] = dt;
                        //List for selected items
                        List<string> FrontLeftWindowselectedItems2 = new List<string>();

                        //Loop's thouhgt CheckboxList items to check which values are checked
                        for (int j = 0; j < cbl_FrontLeftWindow.Items.Count; j++)
                        {
                            if (cbl_FrontLeftWindow.Items[j].Selected)
                            {
                                // selectedItems.Add(string.Format(Checkbox1.Items[i].Text.ToString()));
                                FrontLeftWindowselectedItems2.Add(cbl_FrontLeftWindow.Items[j].Value);

                            }
                        }
                        Session["FrontLeftWindow"] = FrontLeftWindowselectedItems2;
                    }
                }
            }
        }
        //9.Rear Left Window
        protected void RearLeftWindow_SelectedItems(object sender, EventArgs e)
        {
            //string name = Partname.Text.ToString();
            //dt.Columns.Add(name);
            dt.Columns.Add("Content");
            dt.Columns.Add("id");
            dt.Columns.Add("STATUS");
            dt.Columns.Add("VIN_ID");


            for (int i = 0; i < cbl_RearLeftWindow.Items.Count; i++)
            {
                if (cbl_RearLeftWindow.Items[i].Selected == true)
                {
                    DataRow dr = dt.NewRow();
                    dr["Content"] = cbl_RearLeftWindow.Items[i].Text.ToString();
                    dr["STATUS"] = 0;
                    int vinid = Convert.ToInt32(Session["id_vin"]);
                    dr["VIN_ID"] = vinid;
                    dr["id"] = cbl_RearLeftWindow.Items[i].Value;
                    dt.Rows.Add(dr);

                }
                if (Partname.Text == "Rear Left Window")
                {
                    ViewState["RearLeftWindow_dt"] = dt;
                    if (dt.Rows.Count != 0)
                    {
                        gv_RearLeftWindow.DataSource = dt;
                        gv_RearLeftWindow.DataBind();
                       // gv_RearLeftWindowDiv12.Visible = true;
                        ViewState["RearLeftWindow_fill_summary"] = dt;
                        //List for selected items
                        List<string> RearLeftWindowselectedItems2 = new List<string>();

                        //Loop's thouhgt CheckboxList items to check which values are checked
                        for (int j = 0; j < cbl_RearLeftWindow.Items.Count; j++)
                        {
                            if (cbl_RearLeftWindow.Items[j].Selected)
                            {
                                // selectedItems.Add(string.Format(Checkbox1.Items[i].Text.ToString()));
                                RearLeftWindowselectedItems2.Add(cbl_RearLeftWindow.Items[j].Value);

                            }
                        }
                        Session["RearLeftWindow"] = RearLeftWindowselectedItems2;
                    }
                }
            }
        }
        //10.Front Windshield
        protected void FrontWindshield_SelectedItems(object sender, EventArgs e)
        {
            dt.Columns.Add("Content");
            dt.Columns.Add("id");
            dt.Columns.Add("STATUS");
            dt.Columns.Add("VIN_ID");

            for (int i = 0; i < cbl_FrontWindshield.Items.Count; i++)
            {
                if (cbl_FrontWindshield.Items[i].Selected == true)
                {
                    DataRow dr = dt.NewRow();
                    dr["Content"] = cbl_FrontWindshield.Items[i].Text.ToString();
                    dr["STATUS"] = 0;
                    int vinid = Convert.ToInt32(Session["id_vin"]);
                    dr["VIN_ID"] = vinid;
                    dr["id"] = cbl_FrontWindshield.Items[i].Value;
                    dt.Rows.Add(dr);

                }
                if (Partname.Text == "Front Windshield")
                {
                    ViewState["FrontWindshield_dt"] = dt;
                    if (dt.Rows.Count != 0)
                    {
                        gv_FrontWindshield.DataSource = dt;
                        gv_FrontWindshield.DataBind();
                        //gv_FrontWindshieldDiv13.Visible = true;
                        ViewState["FrontWindshield_fill_summary"] = dt;
                        //List for selected items
                        List<string> FrontWindshieldselectedItems2 = new List<string>();

                        //Loop's thouhgt CheckboxList items to check which values are checked
                        for (int j = 0; j < cbl_FrontWindshield.Items.Count; j++)
                        {
                            if (cbl_FrontWindshield.Items[j].Selected)
                            {
                                // selectedItems.Add(string.Format(Checkbox1.Items[i].Text.ToString()));
                                FrontWindshieldselectedItems2.Add(cbl_FrontWindshield.Items[j].Value);

                            }
                        }
                        Session["FrontWindshield"] = FrontWindshieldselectedItems2;
                    }
                }
            }
        }
        //11.Front Left Wheel & Tire
        protected void FrontLeftWheelTire_SelectedItems(object sender, EventArgs e)
        {
            dt.Columns.Add("Content");
            dt.Columns.Add("id");
            dt.Columns.Add("STATUS");
            dt.Columns.Add("VIN_ID");

            for (int i = 0; i < cbl_FrontLeftWheelTire.Items.Count; i++)
            {
                if (cbl_FrontLeftWheelTire.Items[i].Selected == true)
                {
                    DataRow dr = dt.NewRow();
                    dr["Content"] = cbl_FrontLeftWheelTire.Items[i].Text.ToString();
                    dr["STATUS"] = 0;
                    int vinid = Convert.ToInt32(Session["id_vin"]);
                    dr["VIN_ID"] = vinid;
                    dr["id"] = cbl_FrontLeftWheelTire.Items[i].Value;
                    dt.Rows.Add(dr);

                }
                if (Partname.Text == "Front Left Wheel & Tire")
                {
                    ViewState["FrontLeftWheelTire_dt"] = dt;
                    if (dt.Rows.Count != 0)
                    {
                        gv_FrontLeftWheelTire.DataSource = dt;
                        gv_FrontLeftWheelTire.DataBind();
                       // gv_FrontLeftWheelTireDiv14.Visible = true;
                        ViewState["FrontLeftWheelTire_fill_summary"] = dt;
                        //List for selected items
                        List<string> FrontLeftWheelTireselectedItems2 = new List<string>();

                        //Loop's thouhgt CheckboxList items to check which values are checked
                        for (int j = 0; j < cbl_FrontLeftWheelTire.Items.Count; j++)
                        {
                            if (cbl_FrontLeftWheelTire.Items[j].Selected)
                            {
                                // selectedItems.Add(string.Format(Checkbox1.Items[i].Text.ToString()));
                                FrontLeftWheelTireselectedItems2.Add(cbl_FrontLeftWheelTire.Items[j].Value);

                            }
                        }
                        Session["FrontLeftWheelTire"] = FrontLeftWheelTireselectedItems2;
                    }
                }

            }
        }
        //12.Rear Left Wheel & Tire
        protected void RearLeftWheelTire_SelectedItems(object sender, EventArgs e)
        {
            dt.Columns.Add("Content");
            dt.Columns.Add("id");
            dt.Columns.Add("STATUS");
            dt.Columns.Add("VIN_ID");

            for (int i = 0; i < cbl_RearLeftWheelTire.Items.Count; i++)
            {
                if (cbl_RearLeftWheelTire.Items[i].Selected == true)
                {
                    DataRow dr = dt.NewRow();
                    dr["Content"] = cbl_RearLeftWheelTire.Items[i].Text.ToString();
                    dr["STATUS"] = 0;
                    int vinid = Convert.ToInt32(Session["id_vin"]);
                    dr["VIN_ID"] = vinid;
                    dr["id"] = cbl_RearLeftWheelTire.Items[i].Value;
                    dt.Rows.Add(dr);

                }
                if (Partname.Text == "Rear Left Wheel & Tire")
                {
                    ViewState["RearLeftWheelTire_dt"] = dt;
                    if (dt.Rows.Count != 0)
                    {
                        gv_RearLeftWheelTire.DataSource = dt;
                        gv_RearLeftWheelTire.DataBind();
                       // gv_RearLeftWheelTireDiv15.Visible = true;
                        ViewState["RearLeftWheelTire_fill_summary"] = dt;
                        //List for selected items
                        List<string> RearLeftWheelTireselectedItems2 = new List<string>();

                        //Loop's thouhgt CheckboxList items to check which values are checked
                        for (int j = 0; j < cbl_RearLeftWheelTire.Items.Count; j++)
                        {
                            if (cbl_RearLeftWheelTire.Items[j].Selected)
                            {
                                // selectedItems.Add(string.Format(Checkbox1.Items[i].Text.ToString()));
                                RearLeftWheelTireselectedItems2.Add(cbl_RearLeftWheelTire.Items[j].Value);

                            }
                        }
                        Session["RearLeftWheelTire"] = RearLeftWheelTireselectedItems2;
                    }
                }

            }
        }
        //13.Front Left Headlight
        protected void FrontLeftHeadlight_SelectedItems(object sender, EventArgs e)
        {
            dt.Columns.Add("Content");
            dt.Columns.Add("id");
            dt.Columns.Add("STATUS");
            dt.Columns.Add("VIN_ID");

            for (int i = 0; i < cbl_FrontLeftHeadlight.Items.Count; i++)
            {
                if (cbl_FrontLeftHeadlight.Items[i].Selected == true)
                {
                    DataRow dr = dt.NewRow();
                    dr["Content"] = cbl_FrontLeftHeadlight.Items[i].Text.ToString();
                    dr["STATUS"] = 0;
                    int vinid = Convert.ToInt32(Session["id_vin"]);
                    dr["VIN_ID"] = vinid;
                    dr["id"] = cbl_FrontLeftHeadlight.Items[i].Value;
                    dt.Rows.Add(dr);

                }
                if (Partname.Text == "Front Left Headlight")
                {
                    ViewState["FrontLeftHeadlight_dt"] = dt;
                    if (dt.Rows.Count != 0)
                    {
                        gv_FrontLeftHeadlight.DataSource = dt;
                        gv_FrontLeftHeadlight.DataBind();
                       // gv_FrontLeftHeadlightDiv16.Visible = true;
                        ViewState["FrontLeftHeadlight_fill_summary"] = dt;
                        //List for selected items
                        List<string> FrontLeftHeadlightselectedItems2 = new List<string>();

                        //Loop's thouhgt CheckboxList items to check which values are checked
                        for (int j = 0; j < cbl_FrontLeftHeadlight.Items.Count; j++)
                        {
                            if (cbl_FrontLeftHeadlight.Items[j].Selected)
                            {
                                // selectedItems.Add(string.Format(Checkbox1.Items[i].Text.ToString()));
                                FrontLeftHeadlightselectedItems2.Add(cbl_FrontLeftHeadlight.Items[j].Value);

                            }
                        }
                        Session["FrontLeftHeadlight"] = FrontLeftHeadlightselectedItems2;
                    }
                }
            }
        }
        //14.Front Right Headlight
        protected void FrontRightHeadlight_SelectedItems(object sender, EventArgs e)
        {
            dt.Columns.Add("Content");
            dt.Columns.Add("id");
            dt.Columns.Add("STATUS");
            dt.Columns.Add("VIN_ID");

            for (int i = 0; i < cbl_FrontRightHeadlight.Items.Count; i++)
            {
                if (cbl_FrontRightHeadlight.Items[i].Selected == true)
                {
                    DataRow dr = dt.NewRow();
                    dr["Content"] = cbl_FrontRightHeadlight.Items[i].Text.ToString();
                    dr["STATUS"] = 0;
                    int vinid = Convert.ToInt32(Session["id_vin"]);
                    dr["VIN_ID"] = vinid;
                    dr["id"] = cbl_FrontRightHeadlight.Items[i].Value;
                    dt.Rows.Add(dr);

                }
                if (Partname.Text == "Front Right Headlight")
                {
                    ViewState["FrontRightHeadlight_dt"] = dt;
                    if (dt.Rows.Count != 0)
                    {
                        gv_FrontRightHeadlight.DataSource = dt;
                        gv_FrontRightHeadlight.DataBind();
                        //gv_FrontRightHeadlightDiv17.Visible = true;
                        ViewState["FrontRightHeadlight_fill_summary"] = dt;
                        //List for selected items
                        List<string> FrontRightHeadlightselectedItems2 = new List<string>();

                        //Loop's thouhgt CheckboxList items to check which values are checked
                        for (int j = 0; j < cbl_FrontRightHeadlight.Items.Count; j++)
                        {
                            if (cbl_FrontRightHeadlight.Items[j].Selected)
                            {
                                // selectedItems.Add(string.Format(Checkbox1.Items[i].Text.ToString()));
                                FrontRightHeadlightselectedItems2.Add(cbl_FrontRightHeadlight.Items[j].Value);

                            }
                        }
                        Session["FrontRightHeadlight"] = FrontRightHeadlightselectedItems2;
                    }
                }

            }
        }
        //15.Left Mirror
        protected void LeftMirror_SelectedItems(object sender, EventArgs e)
        {
            dt.Columns.Add("Content");
            dt.Columns.Add("id");
            dt.Columns.Add("STATUS");
            dt.Columns.Add("VIN_ID");

            for (int i = 0; i < cbl_LeftMirror.Items.Count; i++)
            {
                if (cbl_LeftMirror.Items[i].Selected == true)
                {
                    DataRow dr = dt.NewRow();
                    dr["Content"] = cbl_LeftMirror.Items[i].Text.ToString();
                    dr["STATUS"] = 0;
                    int vinid = Convert.ToInt32(Session["id_vin"]);
                    dr["VIN_ID"] = vinid;
                    dr["id"] = cbl_LeftMirror.Items[i].Value;
                    dt.Rows.Add(dr);

                }
                if (Partname.Text == "Left Mirror")
                {
                    ViewState["LeftMirror_dt"] = dt;
                    if (dt.Rows.Count != 0)
                    {
                        gv_LeftMirror.DataSource = dt;
                        gv_LeftMirror.DataBind();
                      //  gv_LeftMirrorDiv18.Visible = true;
                        ViewState["LeftMirror_fill_summary"] = dt;
                        //List for selected items
                        List<string> LeftMirrorselectedItems2 = new List<string>();

                        //Loop's thouhgt CheckboxList items to check which values are checked
                        for (int j = 0; j < cbl_LeftMirror.Items.Count; j++)
                        {
                            if (cbl_LeftMirror.Items[j].Selected)
                            {
                                // selectedItems.Add(string.Format(Checkbox1.Items[i].Text.ToString()));
                                LeftMirrorselectedItems2.Add(cbl_LeftMirror.Items[j].Value);

                            }
                        }
                        Session["LeftMirror"] = LeftMirrorselectedItems2;
                    }
                }

            }
        }
        //17.Trunk
        protected void Trunk_SelectedItems(object sender, EventArgs e)
        {
            dt.Columns.Add("Content");
            dt.Columns.Add("id");
            dt.Columns.Add("STATUS");
            dt.Columns.Add("VIN_ID");

            for (int i = 0; i < cbl_Trunk.Items.Count; i++)
            {
                if (cbl_Trunk.Items[i].Selected == true)
                {
                    DataRow dr = dt.NewRow();
                    dr["Content"] = cbl_Trunk.Items[i].Text.ToString();
                    dr["STATUS"] = 0;
                    int vinid = Convert.ToInt32(Session["id_vin"]);
                    dr["VIN_ID"] = vinid;
                    dr["id"] = cbl_Trunk.Items[i].Value;
                    dt.Rows.Add(dr);

                }
                if (Partname.Text == "Trunk")
                {
                    ViewState["Trunk_dt"] = dt;
                    if (dt.Rows.Count != 0)
                    {
                        gv_Trunk.DataSource = dt;
                        gv_Trunk.DataBind();
                       // gv_TrunkDiv19.Visible = true;
                        ViewState["Trunk_fill_summary"] = dt;
                        //List for selected items
                        List<string> TrunkselectedItems2 = new List<string>();

                        //Loop's thouhgt CheckboxList items to check which values are checked
                        for (int j = 0; j < cbl_Trunk.Items.Count; j++)
                        {
                            if (cbl_Trunk.Items[j].Selected)
                            {
                                // selectedItems.Add(string.Format(Checkbox1.Items[i].Text.ToString()));
                                TrunkselectedItems2.Add(cbl_Trunk.Items[j].Value);

                            }
                        }
                        Session["Trunk"] = TrunkselectedItems2;
                    }
                }

            }
        }
        //18.Rear Bumper
        protected void RearBumper_SelectedItems(object sender, EventArgs e)
        {
            dt.Columns.Add("Content");
            dt.Columns.Add("id");
            dt.Columns.Add("STATUS");
            dt.Columns.Add("VIN_ID");

            for (int i = 0; i < cbl_RearBumper.Items.Count; i++)
            {
                if (cbl_RearBumper.Items[i].Selected == true)
                {
                    DataRow dr = dt.NewRow();
                    dr["Content"] = cbl_RearBumper.Items[i].Text.ToString();
                    dr["STATUS"] = 0;
                    int vinid = Convert.ToInt32(Session["id_vin"]);
                    dr["VIN_ID"] = vinid;
                    dr["id"] = cbl_RearBumper.Items[i].Value;
                    dt.Rows.Add(dr);

                }
                if (Partname.Text == "Rear Bumper")
                {
                    ViewState["RearBumper_dt"] = dt;
                    if (dt.Rows.Count != 0)
                    {
                        gv_RearBumper.DataSource = dt;
                        gv_RearBumper.DataBind();
                      //  gv_RearBumperDiv20.Visible = true;
                        ViewState["RearBumper_fill_summary"] = dt;
                        //List for selected items
                        List<string> RearBumperselectedItems2 = new List<string>();

                        //Loop's thouhgt CheckboxList items to check which values are checked
                        for (int j = 0; j < cbl_RearBumper.Items.Count; j++)
                        {
                            if (cbl_RearBumper.Items[j].Selected)
                            {
                                // selectedItems.Add(string.Format(Checkbox1.Items[i].Text.ToString()));
                                RearBumperselectedItems2.Add(cbl_RearBumper.Items[j].Value);

                            }
                        }
                        Session["RearBumper"] = RearBumperselectedItems2;
                    }
                }

            }
        }
        //19.Rear Right Quarter Panel
        protected void RearRightQuarterPanel_SelectedItems(object sender, EventArgs e)
        {
            dt.Columns.Add("Content");
            dt.Columns.Add("id");
            dt.Columns.Add("STATUS");
            dt.Columns.Add("VIN_ID");

            for (int i = 0; i < cbl_RearRightQuarterPanel.Items.Count; i++)
            {
                if (cbl_RearRightQuarterPanel.Items[i].Selected == true)
                {
                    DataRow dr = dt.NewRow();
                    dr["Content"] = cbl_RearRightQuarterPanel.Items[i].Text.ToString();
                    dr["STATUS"] = 0;
                    int vinid = Convert.ToInt32(Session["id_vin"]);
                    dr["VIN_ID"] = vinid;
                    dr["id"] = cbl_RearRightQuarterPanel.Items[i].Value;
                    dt.Rows.Add(dr);

                }
                if (Partname.Text == "Rear Right Quarter Panel")
                {
                    ViewState["RearRightQuarterPanel_dt"] = dt;
                    if (dt.Rows.Count != 0)
                    {
                        gv_RearRightQuarterPanel.DataSource = dt;
                        gv_RearRightQuarterPanel.DataBind();
                      //  gv_RearRightQuarterPanelDiv21.Visible = true;
                        ViewState["RearRightQuarterPanel_fill_summary"] = dt;
                        //List for selected items
                        List<string> RearRightQuarterPanelselectedItems2 = new List<string>();

                        //Loop's thouhgt CheckboxList items to check which values are checked
                        for (int j = 0; j < cbl_RearRightQuarterPanel.Items.Count; j++)
                        {
                            if (cbl_RearRightQuarterPanel.Items[j].Selected)
                            {
                                // selectedItems.Add(string.Format(Checkbox1.Items[i].Text.ToString()));
                                RearRightQuarterPanelselectedItems2.Add(cbl_RearRightQuarterPanel.Items[j].Value);

                            }
                        }
                        Session["RearRightQuarterPanel"] = RearRightQuarterPanelselectedItems2;
                    }
                }

            }
        }
        //20.Front Right Fender
        protected void FrontRightFender_SelectedItems(object sender, EventArgs e)
        {
            dt.Columns.Add("Content");
            dt.Columns.Add("id");
            dt.Columns.Add("STATUS");
            dt.Columns.Add("VIN_ID");

            for (int i = 0; i < cbl_FrontRightFender.Items.Count; i++)
            {
                if (cbl_FrontRightFender.Items[i].Selected == true)
                {
                    DataRow dr = dt.NewRow();
                    dr["Content"] = cbl_FrontRightFender.Items[i].Text.ToString();
                    dr["STATUS"] = 0;
                    int vinid = Convert.ToInt32(Session["id_vin"]);
                    dr["VIN_ID"] = vinid;
                    dr["id"] = cbl_FrontRightFender.Items[i].Value;
                    dt.Rows.Add(dr);

                }
                if (Partname.Text == "Front Right Fender")
                {
                    ViewState["FrontRightFender_dt"] = dt;
                    if (dt.Rows.Count != 0)
                    {
                        gv_FrontRightFender.DataSource = dt;
                        gv_FrontRightFender.DataBind();
                       // gv_FrontRightFenderDiv22.Visible = true;
                        ViewState["FrontRightFender_fill_summary"] = dt;
                        //List for selected items
                        List<string> FrontRightFenderselectedItems2 = new List<string>();

                        //Loop's thouhgt CheckboxList items to check which values are checked
                        for (int j = 0; j < cbl_FrontRightFender.Items.Count; j++)
                        {
                            if (cbl_FrontRightFender.Items[j].Selected)
                            {
                                // selectedItems.Add(string.Format(Checkbox1.Items[i].Text.ToString()));
                                FrontRightFenderselectedItems2.Add(cbl_FrontRightFender.Items[j].Value);

                            }
                        }
                        Session["FrontRightFender"] = FrontRightFenderselectedItems2;
                    }
                }

            }
        }
        //21.Front Right Door
        protected void FrontRightDoor_SelectedItems(object sender, EventArgs e)
        {
            dt.Columns.Add("Content");
            dt.Columns.Add("id");
            dt.Columns.Add("STATUS");
            dt.Columns.Add("VIN_ID");

            for (int i = 0; i < cbl_FrontRightDoor.Items.Count; i++)
            {
                if (cbl_FrontRightDoor.Items[i].Selected == true)
                {
                    DataRow dr = dt.NewRow();
                    dr["Content"] = cbl_FrontRightDoor.Items[i].Text.ToString();
                    dr["STATUS"] = 0;
                    int vinid = Convert.ToInt32(Session["id_vin"]);
                    dr["VIN_ID"] = vinid;
                    dr["id"] = cbl_FrontRightDoor.Items[i].Value;
                    dt.Rows.Add(dr);

                }
                if (Partname.Text == "Front Right Door")
                {
                    ViewState["FrontRightDoor_dt"] = dt;
                    if (dt.Rows.Count != 0)
                    {
                        gv_FrontRightDoor.DataSource = dt;
                        gv_FrontRightDoor.DataBind();
                       // gv_FrontRightDoorDiv23.Visible = true;
                        ViewState["FrontRightDoor_fill_summary"] = dt;
                        //List for selected items
                        List<string> FrontRightDoorselectedItems2 = new List<string>();

                        //Loop's thouhgt CheckboxList items to check which values are checked
                        for (int j = 0; j < cbl_FrontRightDoor.Items.Count; j++)
                        {
                            if (cbl_FrontRightDoor.Items[j].Selected)
                            {
                                // selectedItems.Add(string.Format(Checkbox1.Items[i].Text.ToString()));
                                FrontRightDoorselectedItems2.Add(cbl_FrontRightDoor.Items[j].Value);

                            }
                        }
                        Session["FrontRightDoor"] = FrontRightDoorselectedItems2;
                    }
                }

            }
        }
        //22.Rear Right Door
        protected void RearRightDoor_SelectedItems(object sender, EventArgs e)
        {
            dt.Columns.Add("Content");
            dt.Columns.Add("id");
            dt.Columns.Add("STATUS");
            dt.Columns.Add("VIN_ID");

            for (int i = 0; i < cbl_RearRightDoor.Items.Count; i++)
            {
                if (cbl_RearRightDoor.Items[i].Selected == true)
                {
                    DataRow dr = dt.NewRow();
                    dr["Content"] = cbl_RearRightDoor.Items[i].Text.ToString();
                    dr["STATUS"] = 0;
                    int vinid = Convert.ToInt32(Session["id_vin"]);
                    dr["VIN_ID"] = vinid;
                    dr["id"] = cbl_RearRightDoor.Items[i].Value;
                    dt.Rows.Add(dr);

                }
                if (Partname.Text == "Rear Right Door")
                {
                    ViewState["RearRightDoor_dt"] = dt;
                    if (dt.Rows.Count != 0)
                    {
                        gv_RearRightDoor.DataSource = dt;
                        gv_RearRightDoor.DataBind();
                       // gv_RearRightDoorDiv24.Visible = true;
                        ViewState["RearRightDoor_fill_summary"] = dt;
                        //List for selected items
                        List<string> RearRightDoorselectedItems2 = new List<string>();

                        //Loop's thouhgt CheckboxList items to check which values are checked
                        for (int j = 0; j < cbl_RearRightDoor.Items.Count; j++)
                        {
                            if (cbl_RearRightDoor.Items[j].Selected)
                            {
                                // selectedItems.Add(string.Format(Checkbox1.Items[i].Text.ToString()));
                                RearRightDoorselectedItems2.Add(cbl_RearRightDoor.Items[j].Value);

                            }
                        }
                        Session["RearRightDoor"] = RearRightDoorselectedItems2;
                    }
                }

            }
        }
        //23.Front Right Window
        protected void FrontRightWindow_SelectedItems(object sender, EventArgs e)
        {
            dt.Columns.Add("Content");
            dt.Columns.Add("id");
            dt.Columns.Add("STATUS");
            dt.Columns.Add("VIN_ID");

            for (int i = 0; i < cbl_FrontRightWindow.Items.Count; i++)
            {
                if (cbl_FrontRightWindow.Items[i].Selected == true)
                {
                    DataRow dr = dt.NewRow();
                    dr["Content"] = cbl_FrontRightWindow.Items[i].Text.ToString();
                    dr["STATUS"] = 0;
                    int vinid = Convert.ToInt32(Session["id_vin"]);
                    dr["VIN_ID"] = vinid;
                    dr["id"] = cbl_FrontRightWindow.Items[i].Value;
                    dt.Rows.Add(dr);

                }
                if (Partname.Text == "Front Right Window")
                {
                    ViewState["FrontRightWindow_dt"] = dt;
                    if (dt.Rows.Count != 0)
                    {
                        gv_FrontRightWindow.DataSource = dt;
                        gv_FrontRightWindow.DataBind();
                      //  gv_FrontRightWindowDiv25.Visible = true;
                        ViewState["FrontRightWindow_fill_summary"] = dt;
                        //List for selected items
                        List<string> FrontRightWindowselectedItems2 = new List<string>();

                        //Loop's thouhgt CheckboxList items to check which values are checked
                        for (int j = 0; j < cbl_FrontRightWindow.Items.Count; j++)
                        {
                            if (cbl_FrontRightWindow.Items[j].Selected)
                            {
                                // selectedItems.Add(string.Format(Checkbox1.Items[i].Text.ToString()));
                                FrontRightWindowselectedItems2.Add(cbl_FrontRightWindow.Items[j].Value);

                            }
                        }
                        Session["FrontRightWindow"] = FrontRightWindowselectedItems2;
                    }
                }

            }
        }
        //24.Rear Right Window
        protected void RearRightWindow_SelectedItems(object sender, EventArgs e)
        {
            dt.Columns.Add("Content");
            dt.Columns.Add("id");
            dt.Columns.Add("STATUS");
            dt.Columns.Add("VIN_ID");

            for (int i = 0; i < cbl_RearRightWindow.Items.Count; i++)
            {
                if (cbl_RearRightWindow.Items[i].Selected == true)
                {
                    DataRow dr = dt.NewRow();
                    dr["Content"] = cbl_RearRightWindow.Items[i].Text.ToString();
                    dr["STATUS"] = 0;
                    int vinid = Convert.ToInt32(Session["id_vin"]);
                    dr["VIN_ID"] = vinid;
                    dr["id"] = cbl_RearRightWindow.Items[i].Value;
                    dt.Rows.Add(dr);

                }
                if (Partname.Text == "Rear Right Window")
                {
                    ViewState["RearRightWindow_dt"] = dt;
                    if (dt.Rows.Count != 0)
                    {
                        gv_RearRightWindow.DataSource = dt;
                        gv_RearRightWindow.DataBind();
                      //  gv_RearRightWindowDiv26.Visible = true;
                        ViewState["RearRightWindow_fill_summary"] = dt;
                        //List for selected items
                        List<string> RearRightWindowselectedItems2 = new List<string>();

                        //Loop's thouhgt CheckboxList items to check which values are checked
                        for (int j = 0; j < cbl_RearRightWindow.Items.Count; j++)
                        {
                            if (cbl_RearRightWindow.Items[j].Selected)
                            {
                                // selectedItems.Add(string.Format(Checkbox1.Items[i].Text.ToString()));
                                RearRightWindowselectedItems2.Add(cbl_RearRightWindow.Items[j].Value);

                            }
                        }
                        Session["RearRightWindow"] = RearRightWindowselectedItems2;
                    }
                }

            }
        }
        //25.Rear Windshield
        protected void RearWindshield_SelectedItems(object sender, EventArgs e)
        {
            dt.Columns.Add("Content");
            dt.Columns.Add("id");
            dt.Columns.Add("STATUS");
            dt.Columns.Add("VIN_ID");

            for (int i = 0; i < cbl_RearWindshield.Items.Count; i++)
            {
                if (cbl_RearWindshield.Items[i].Selected == true)
                {
                    DataRow dr = dt.NewRow();
                    dr["Content"] = cbl_RearWindshield.Items[i].Text.ToString();
                    dr["STATUS"] = 0;
                    int vinid = Convert.ToInt32(Session["id_vin"]);
                    dr["VIN_ID"] = vinid;
                    dr["id"] = cbl_RearWindshield.Items[i].Value;
                    dt.Rows.Add(dr);

                }
                if (Partname.Text == "Rear Windshield")
                {
                    ViewState["RearWindshield_dt"] = dt;
                    if (dt.Rows.Count != 0)
                    {
                        gv_RearWindshield.DataSource = dt;
                        gv_RearWindshield.DataBind();
                      //  gv_RearWindshieldDiv27.Visible = true;
                        ViewState["RearWindshield_fill_summary"] = dt;
                        //List for selected items
                        List<string> RearWindshieldselectedItems2 = new List<string>();

                        //Loop's thouhgt CheckboxList items to check which values are checked
                        for (int j = 0; j < cbl_RearWindshield.Items.Count; j++)
                        {
                            if (cbl_RearWindshield.Items[j].Selected)
                            {
                                // selectedItems.Add(string.Format(Checkbox1.Items[i].Text.ToString()));
                                RearWindshieldselectedItems2.Add(cbl_RearWindshield.Items[j].Value);

                            }
                        }
                        Session["RearWindshield"] = RearWindshieldselectedItems2;
                    }
                }

            }
        }
        //26.Front Right Wheel & Tire
        protected void FrontRightWheelTire_SelectedItems(object sender, EventArgs e)
        {
            dt.Columns.Add("Content");
            dt.Columns.Add("id");
            dt.Columns.Add("STATUS");
            dt.Columns.Add("VIN_ID");

            for (int i = 0; i < cbl_FrontRightWheelTire.Items.Count; i++)
            {
                if (cbl_FrontRightWheelTire.Items[i].Selected == true)
                {
                    DataRow dr = dt.NewRow();
                    dr["Content"] = cbl_FrontRightWheelTire.Items[i].Text.ToString();
                    dr["STATUS"] = 0;
                    int vinid = Convert.ToInt32(Session["id_vin"]);
                    dr["VIN_ID"] = vinid;
                    dr["id"] = cbl_FrontRightWheelTire.Items[i].Value;
                    dt.Rows.Add(dr);

                }
                if (Partname.Text == "Front Right Wheel & Tire")
                {
                    ViewState["FrontRightWheelTire_dt"] = dt;
                    if (dt.Rows.Count != 0)
                    {
                        gv_FrontRightWheelTire.DataSource = dt;
                        gv_FrontRightWheelTire.DataBind();
                       // gv_FrontRightWheelTireDiv28.Visible = true;
                        ViewState["FrontRightWheelTire_fill_summary"] = dt;
                        //List for selected items
                        List<string> FrontRightWheelTireselectedItems2 = new List<string>();

                        //Loop's thouhgt CheckboxList items to check which values are checked
                        for (int j = 0; j < cbl_FrontRightWheelTire.Items.Count; j++)
                        {
                            if (cbl_FrontRightWheelTire.Items[j].Selected)
                            {
                                // selectedItems.Add(string.Format(Checkbox1.Items[i].Text.ToString()));
                                FrontRightWheelTireselectedItems2.Add(cbl_FrontRightWheelTire.Items[j].Value);

                            }
                        }
                        Session["FrontRightWheelTire"] = FrontRightWheelTireselectedItems2;
                    }
                }
            }
        }
        //27.Rear Right Wheel & Tire
        protected void RearRightWheelTire_SelectedItems(object sender, EventArgs e)
        {
            dt.Columns.Add("Content");
            dt.Columns.Add("id");
            dt.Columns.Add("STATUS");
            dt.Columns.Add("VIN_ID");

            for (int i = 0; i < cbl_RearRightWheelTire.Items.Count; i++)
            {
                if (cbl_RearRightWheelTire.Items[i].Selected == true)
                {
                    DataRow dr = dt.NewRow();
                    dr["Content"] = cbl_RearRightWheelTire.Items[i].Text.ToString();
                    dr["STATUS"] = 0;
                    int vinid = Convert.ToInt32(Session["id_vin"]);
                    dr["VIN_ID"] = vinid;
                    dr["id"] = cbl_RearRightWheelTire.Items[i].Value;
                    dt.Rows.Add(dr);

                }
                if (Partname.Text == "Rear Right Wheel & Tire")
                {
                    ViewState["RearRightWheelTire_dt"] = dt;
                    if (dt.Rows.Count != 0)
                    {
                        gv_RearRightWheelTire.DataSource = dt;
                        gv_RearRightWheelTire.DataBind();
                      //  gv_RearRightWheelTireDiv29.Visible = true;
                        ViewState["RearRightWheelTire_fill_summary"] = dt;
                        //List for selected items
                        List<string> RearRightWheelTireselectedItems2 = new List<string>();

                        //Loop's thouhgt CheckboxList items to check which values are checked
                        for (int j = 0; j < cbl_RearRightWheelTire.Items.Count; j++)
                        {
                            if (cbl_RearRightWheelTire.Items[j].Selected)
                            {
                                // selectedItems.Add(string.Format(Checkbox1.Items[i].Text.ToString()));
                                RearRightWheelTireselectedItems2.Add(cbl_RearRightWheelTire.Items[j].Value);

                            }
                        }
                        Session["RearRightWheelTire"] = RearRightWheelTireselectedItems2;
                    }
                }
            }
        }
        //28.Right Tail Light
        protected void RightTailLight_SelectedItems(object sender, EventArgs e)
        {
            dt.Columns.Add("Content");
            dt.Columns.Add("id");
            dt.Columns.Add("STATUS");
            dt.Columns.Add("VIN_ID");

            for (int i = 0; i < cbl_RightTailLight.Items.Count; i++)
            {
                if (cbl_RightTailLight.Items[i].Selected == true)
                {
                    DataRow dr = dt.NewRow();
                    dr["Content"] = cbl_RightTailLight.Items[i].Text.ToString();
                    dr["STATUS"] = 0;
                    int vinid = Convert.ToInt32(Session["id_vin"]);
                    dr["VIN_ID"] = vinid;
                    dr["id"] = cbl_RightTailLight.Items[i].Value;
                    dt.Rows.Add(dr);

                }
                if (Partname.Text == "Right Tail Light")
                {
                    ViewState["RightTailLight_dt"] = dt;
                    if (dt.Rows.Count != 0)
                    {
                        gv_RightTailLight.DataSource = dt;
                        gv_RightTailLight.DataBind();
                      //  gv_RightTailLightDiv30.Visible = true;
                        ViewState["RightTailLight_fill_summary"] = dt;
                        //List for selected items
                        List<string> RightTailLightselectedItems2 = new List<string>();

                        //Loop's thouhgt CheckboxList items to check which values are checked
                        for (int j = 0; j < cbl_RightTailLight.Items.Count; j++)
                        {
                            if (cbl_RightTailLight.Items[j].Selected)
                            {
                                // selectedItems.Add(string.Format(Checkbox1.Items[i].Text.ToString()));
                                RightTailLightselectedItems2.Add(cbl_RightTailLight.Items[j].Value);

                            }
                        }
                        Session["RightTailLight"] = RightTailLightselectedItems2;
                    }
                }
            }
        }
        //29.Left Tail Light(driver side)
        protected void LeftTailLightdriverside_SelectedItems(object sender, EventArgs e)
        {
            dt.Columns.Add("Content");
            dt.Columns.Add("id");
            dt.Columns.Add("STATUS");
            dt.Columns.Add("VIN_ID");

            for (int i = 0; i < cbl_LeftTailLightdriverside.Items.Count; i++)
            {
                if (cbl_LeftTailLightdriverside.Items[i].Selected == true)
                {
                    DataRow dr = dt.NewRow();
                    dr["Content"] = cbl_LeftTailLightdriverside.Items[i].Text.ToString();
                    dr["STATUS"] = 0;
                    int vinid = Convert.ToInt32(Session["id_vin"]);
                    dr["VIN_ID"] = vinid;
                    dr["id"] = cbl_LeftTailLightdriverside.Items[i].Value;
                    dt.Rows.Add(dr);

                }
                if (Partname.Text == "Left Tail Light(driver side)")
                {
                    ViewState["LeftTailLightdriverside_dt"] = dt;
                    if (dt.Rows.Count != 0)
                    {
                        gv_LeftTailLightdriverside.DataSource = dt;
                        gv_LeftTailLightdriverside.DataBind();
                      //  gv_LeftTailLightdriversideDiv31.Visible = true;
                        ViewState["LeftTailLightdriverside_fill_summary"] = dt;
                        //List for selected items
                        List<string> LeftTailLightdriversideselectedItems2 = new List<string>();

                        //Loop's thouhgt CheckboxList items to check which values are checked
                        for (int j = 0; j < cbl_LeftTailLightdriverside.Items.Count; j++)
                        {
                            if (cbl_LeftTailLightdriverside.Items[j].Selected)
                            {
                                // selectedItems.Add(string.Format(Checkbox1.Items[i].Text.ToString()));
                                LeftTailLightdriversideselectedItems2.Add(cbl_LeftTailLightdriverside.Items[j].Value);

                            }
                        }
                        Session["LeftTailLightdriverside"] = LeftTailLightdriversideselectedItems2;
                    }
                }
            }
        }
        //30.Right Mirror
        protected void RightMirror_SelectedItems(object sender, EventArgs e)
        {
            dt.Columns.Add("Content");
            dt.Columns.Add("id");
            dt.Columns.Add("STATUS");
            dt.Columns.Add("VIN_ID");

            for (int i = 0; i < cbl_RightMirror.Items.Count; i++)
            {
                if (cbl_RightMirror.Items[i].Selected == true)
                {
                    DataRow dr = dt.NewRow();
                    dr["Content"] = cbl_RightMirror.Items[i].Text.ToString();
                    dr["STATUS"] = 0;
                    int vinid = Convert.ToInt32(Session["id_vin"]);
                    dr["VIN_ID"] = vinid;
                    dr["id"] = cbl_RightMirror.Items[i].Value;
                    dt.Rows.Add(dr);

                }
                if (Partname.Text == "Right Mirror")
                {
                    ViewState["RightMirror_dt"] = dt;
                    if (dt.Rows.Count != 0)
                    {
                        gv_RightMirror.DataSource = dt;
                        gv_RightMirror.DataBind();
                      //  gv_RightMirrorDiv32.Visible = true;
                        ViewState["RightMirror_fill_summary"] = dt;
                        //List for selected items
                        List<string> RightMirrorselectedItems2 = new List<string>();

                        //Loop's thouhgt CheckboxList items to check which values are checked
                        for (int j = 0; j < cbl_RightMirror.Items.Count; j++)
                        {
                            if (cbl_RightMirror.Items[j].Selected)
                            {
                                // selectedItems.Add(string.Format(Checkbox1.Items[i].Text.ToString()));
                                RightMirrorselectedItems2.Add(cbl_RightMirror.Items[j].Value);

                            }
                        }
                        Session["RightMirror"] = RightMirrorselectedItems2;
                    }
                }
            }
        }

        //RowCommand Events

        //1.Front Bumper
        protected void gv_FrontBumper_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            GridViewRow row = (GridViewRow)(((ImageButton)e.CommandSource).NamingContainer);
            if (e.CommandName == "Delete")
            {
                //cbl_Hood.Visible = false;
                //cbl_FrontBumper.Visible = true;
                DataTable dt = (DataTable)ViewState["FrontBumper_dt"];
                string idd = e.CommandArgument.ToString();
                int id = row.RowIndex;
                dt.Rows.RemoveAt(id);
                gv_FrontBumper.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    
                  //  FrontBumper_Div.Visible = false;

                }
                
                gv_FrontBumper.DataBind();
                
                ViewState["FrontBumper_fill_summary"] = dt;
                DataTable dt2 = (DataTable)ViewState["Frontbumper_tableCkbind_dt"];

                foreach (DataRow dr in dt2.Rows)
                {
                    if (Convert.ToInt32(dr["FRONTBUMPERID"]) == Convert.ToInt32(idd))
                    {
                        for (int i = 0; i < cbl_FrontBumper.Items.Count; i++)
                        {
                            if (Convert.ToInt32(cbl_FrontBumper.Items[i].Value) == Convert.ToInt32(dr["FRONTBUMPERID"]))
                            {
                                if (cbl_FrontBumper.Items[i].Text.ToString() == Convert.ToString(dr["FRONTBUMPERDATA"]))
                                {
                                    cbl_FrontBumper.Items[i].Selected = false;
                                    List<string> FrontBumperSelectedItems3 = (List<string>)Session["FrontBumper"];
                                    List<string> FrontBumperRemovedItems = new List<string>();
                                    foreach (string s in FrontBumperSelectedItems3)
                                    {
                                        if (s != cbl_FrontBumper.Items[i].Value)
                                        {
                                            FrontBumperRemovedItems.Add(s);
                                            cbl_Hood.Visible = false;
                                            cbl_Roof.Visible = false;
                                            cbl_FrontLeftFender.Visible = false;
                                            cbl_FrontLeftDoor.Visible = false;
                                            cbl_RearLeftDoor.Visible = false;
                                            cbl_RearLeftQuarterPanel.Visible = false;
                                            cbl_FrontLeftWindow.Visible = false;
                                            cbl_RearLeftWindow.Visible = false;
                                            cbl_FrontWindshield.Visible = false;
                                            cbl_FrontLeftWheelTire.Visible = false;
                                            cbl_RearLeftWheelTire.Visible = false;
                                            cbl_FrontLeftHeadlight.Visible = false;
                                            cbl_FrontRightHeadlight.Visible = false;
                                            cbl_LeftMirror.Visible = false;
                                            cbl_Trunk.Visible = false;
                                            cbl_RearBumper.Visible = false;
                                            cbl_RearRightQuarterPanel.Visible = false;
                                            cbl_FrontRightFender.Visible = false;
                                            cbl_FrontRightDoor.Visible = false;
                                            cbl_RearRightDoor.Visible = false;
                                            cbl_FrontRightWindow.Visible = false;
                                            cbl_RearRightWindow.Visible = false;
                                            cbl_RearWindshield.Visible = false;
                                            cbl_FrontRightWheelTire.Visible = false;
                                            cbl_RearRightWheelTire.Visible = false;
                                            cbl_RightTailLight.Visible = false;
                                            cbl_LeftTailLightdriverside.Visible = false;
                                            cbl_RightMirror.Visible = false;
                                            cbl_FrontBumper.Visible = true;

                                            int count = FrontBumperRemovedItems.Count;
                                            Partname.Text = "Front Bumper";

                                        }
                                    }
                                    Session["FrontBumper"] = FrontBumperRemovedItems;

                                }
                            }
                        }
                    }
                }
            }
        }
        //2.Hood
        protected void gv_Hood_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            GridViewRow row = (GridViewRow)(((ImageButton)e.CommandSource).NamingContainer);
            if (e.CommandName == "Delete")
            {
                //cbl_FrontBumper.Visible = false;
                //cbl_Hood.Visible = true;
                DataTable dt = (DataTable)ViewState["Hood_dt"];
                string idd = e.CommandArgument.ToString();
                int id = row.RowIndex;
                dt.Rows.RemoveAt(id);
                gv_Hood.DataSource = dt;
                gv_Hood.DataBind();
                if (dt.Rows.Count == 0)
                {
                   // gv_Hood_Div.Visible = false;
                }
                ViewState["Hood_fill_summary"] = dt;
                DataTable dt2 = (DataTable)ViewState["Hood_tableCkbind_dt"];
                foreach (DataRow dr in dt2.Rows)
                {
                    if (Convert.ToInt32(dr["HOODID"]) == Convert.ToInt32(idd))
                    {
                        for (int i = 0; i < cbl_Hood.Items.Count; i++)
                        {
                            if (Convert.ToInt32(cbl_Hood.Items[i].Value) == Convert.ToInt32(dr["HOODID"]))
                            {
                                if (cbl_Hood.Items[i].Text.ToString() == Convert.ToString(dr["HOODDATA"]))
                                {
                                    cbl_Hood.Items[i].Selected = false;
                                    List<string> HoodSelectedItems3 = (List<string>)Session["Hood"];
                                    List<string> Hood_RemovedItems = new List<string>();
                                    foreach (string s in HoodSelectedItems3)
                                    {
                                        if (s != cbl_Hood.Items[i].Value)
                                        {
                                            Hood_RemovedItems.Add(s);
                                            cbl_FrontBumper.Visible = false;

                                            cbl_Roof.Visible = false;
                                            cbl_FrontLeftFender.Visible = false;
                                            cbl_FrontLeftDoor.Visible = false;
                                            cbl_RearLeftDoor.Visible = false;
                                            cbl_RearLeftQuarterPanel.Visible = false;
                                            cbl_FrontLeftWindow.Visible = false;
                                            cbl_RearLeftWindow.Visible = false;
                                            cbl_FrontWindshield.Visible = false;
                                            cbl_FrontLeftWheelTire.Visible = false;
                                            cbl_RearLeftWheelTire.Visible = false;
                                            cbl_FrontLeftHeadlight.Visible = false;
                                            cbl_FrontRightHeadlight.Visible = false;
                                            cbl_LeftMirror.Visible = false;
                                            cbl_Trunk.Visible = false;
                                            cbl_RearBumper.Visible = false;
                                            cbl_RearRightQuarterPanel.Visible = false;
                                            cbl_FrontRightFender.Visible = false;
                                            cbl_FrontRightDoor.Visible = false;
                                            cbl_RearRightDoor.Visible = false;
                                            cbl_FrontRightWindow.Visible = false;
                                            cbl_RearRightWindow.Visible = false;
                                            cbl_RearWindshield.Visible = false;
                                            cbl_FrontRightWheelTire.Visible = false;
                                            cbl_RearRightWheelTire.Visible = false;
                                            cbl_RightTailLight.Visible = false;
                                            cbl_LeftTailLightdriverside.Visible = false;
                                            cbl_RightMirror.Visible = false;
                                            cbl_Hood.Visible = true;
                                            int count = Hood_RemovedItems.Count;
                                            Partname.Text = "Hood";
                                        }
                                    }
                                    Session["Hood"] = Hood_RemovedItems;
                                }
                            }
                        }
                    }
                }
            }
        }
        //3.Roof
        protected void gv_Roof_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            GridViewRow row = (GridViewRow)(((ImageButton)e.CommandSource).NamingContainer);
            if (e.CommandName == "Delete")
            {
                DataTable dt = (DataTable)ViewState["Roof_dt"];

                string idd = e.CommandArgument.ToString();
                int id = row.RowIndex;
                dt.Rows.RemoveAt(id);
                gv_Roof.DataSource = dt;
                gv_Roof.DataBind();
                if (dt.Rows.Count == 0)
                {
                   // gv_Roof_div.Visible = false;
                }
                ViewState["Roof_fill_summary"] = dt;
                DataTable dt2 = (DataTable)ViewState["Roof_tableCkbind_dt"];

                foreach (DataRow dr in dt2.Rows)
                {
                    if (Convert.ToInt32(dr["ROOFID"]) == Convert.ToInt32(idd))
                    {
                        for (int i = 0; i < cbl_Roof.Items.Count; i++)
                        {
                            if (Convert.ToInt32(cbl_Roof.Items[i].Value) == Convert.ToInt32(dr["ROOFID"]))
                            {
                                if (cbl_Roof.Items[i].Text.ToString() == Convert.ToString(dr["ROOFDATA"]))
                                {
                                    cbl_Roof.Items[i].Selected = false;
                                    List<string> l_Roof = (List<string>)Session["Roof"];
                                    List<string> l_Roof_removed = new List<string>();
                                    foreach (string s in l_Roof)
                                    {
                                        if (s != cbl_Roof.Items[i].Value)
                                        {
                                            l_Roof_removed.Add(s);
                                            cbl_FrontBumper.Visible = false;
                                            cbl_Hood.Visible = false;

                                            cbl_FrontLeftFender.Visible = false;
                                            cbl_FrontLeftDoor.Visible = false;
                                            cbl_RearLeftDoor.Visible = false;
                                            cbl_RearLeftQuarterPanel.Visible = false;
                                            cbl_FrontLeftWindow.Visible = false;
                                            cbl_RearLeftWindow.Visible = false;
                                            cbl_FrontWindshield.Visible = false;
                                            cbl_FrontLeftWheelTire.Visible = false;
                                            cbl_RearLeftWheelTire.Visible = false;
                                            cbl_FrontLeftHeadlight.Visible = false;
                                            cbl_FrontRightHeadlight.Visible = false;
                                            cbl_LeftMirror.Visible = false;
                                            cbl_Trunk.Visible = false;
                                            cbl_RearBumper.Visible = false;
                                            cbl_RearRightQuarterPanel.Visible = false;
                                            cbl_FrontRightFender.Visible = false;
                                            cbl_FrontRightDoor.Visible = false;
                                            cbl_RearRightDoor.Visible = false;
                                            cbl_FrontRightWindow.Visible = false;
                                            cbl_RearRightWindow.Visible = false;
                                            cbl_RearWindshield.Visible = false;
                                            cbl_FrontRightWheelTire.Visible = false;
                                            cbl_RearRightWheelTire.Visible = false;
                                            cbl_RightTailLight.Visible = false;
                                            cbl_LeftTailLightdriverside.Visible = false;
                                            cbl_RightMirror.Visible = false;
                                            cbl_Roof.Visible = true;
                                            int count = l_Roof_removed.Count;
                                            Partname.Text = "Roof";
                                            // l_frontBumper.Remove(s);
                                            //Session["FrontBumper"]
                                        }
                                    }
                                    Session["Roof"] = l_Roof_removed;
                                }
                            }
                        }
                    }
                }
            }
        }
        //4.Front Left Fender
        protected void gv_FrontLeftFender_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            GridViewRow row = (GridViewRow)(((ImageButton)e.CommandSource).NamingContainer);
            if (e.CommandName == "Delete")
            {
                DataTable dt = (DataTable)ViewState["FrontLeftFender_dt"];

                string idd = e.CommandArgument.ToString();
                int id = row.RowIndex;
                dt.Rows.RemoveAt(id);
                gv_FrontLeftFender.DataSource = dt;
                gv_FrontLeftFender.DataBind();
                if (dt.Rows.Count == 0)
                {
                   // gv_FrontLeftFender_Div.Visible = false;
                }
                ViewState["FrontLeftFender_fill_summary"] = dt;
                DataTable dt2 = (DataTable)ViewState["FrontLeftFender_tableCkbind_dt"];

                foreach (DataRow dr in dt2.Rows)
                {
                    if (Convert.ToInt32(dr["FRONTLEFTFENDERID"]) == Convert.ToInt32(idd))
                    {
                        for (int i = 0; i < cbl_FrontLeftFender.Items.Count; i++)
                        {
                            if (Convert.ToInt32(cbl_FrontLeftFender.Items[i].Value) == Convert.ToInt32(dr["FRONTLEFTFENDERID"]))
                            {
                                if (cbl_FrontLeftFender.Items[i].Text.ToString() == Convert.ToString(dr["FRONTLEFTFENDERDATA"]))
                                {
                                    cbl_FrontLeftFender.Items[i].Selected = false;
                                    List<string> l_FrontLeftFender = (List<string>)Session["FrontLeftFender"];
                                    List<string> l_FrontLeftFender_removed = new List<string>();
                                    foreach (string s in l_FrontLeftFender)
                                    {
                                        if (s != cbl_FrontLeftFender.Items[i].Value)
                                        {
                                            l_FrontLeftFender_removed.Add(s);
                                            cbl_FrontBumper.Visible = false;
                                            cbl_Hood.Visible = false;
                                            cbl_Roof.Visible = false;

                                            cbl_FrontLeftDoor.Visible = false;
                                            cbl_RearLeftDoor.Visible = false;
                                            cbl_RearLeftQuarterPanel.Visible = false;
                                            cbl_FrontLeftWindow.Visible = false;
                                            cbl_RearLeftWindow.Visible = false;
                                            cbl_FrontWindshield.Visible = false;
                                            cbl_FrontLeftWheelTire.Visible = false;
                                            cbl_RearLeftWheelTire.Visible = false;
                                            cbl_FrontLeftHeadlight.Visible = false;
                                            cbl_FrontRightHeadlight.Visible = false;
                                            cbl_LeftMirror.Visible = false;
                                            cbl_Trunk.Visible = false;
                                            cbl_RearBumper.Visible = false;
                                            cbl_RearRightQuarterPanel.Visible = false;
                                            cbl_FrontRightFender.Visible = false;
                                            cbl_FrontRightDoor.Visible = false;
                                            cbl_RearRightDoor.Visible = false;
                                            cbl_FrontRightWindow.Visible = false;
                                            cbl_RearRightWindow.Visible = false;
                                            cbl_RearWindshield.Visible = false;
                                            cbl_FrontRightWheelTire.Visible = false;
                                            cbl_RearRightWheelTire.Visible = false;
                                            cbl_RightTailLight.Visible = false;
                                            cbl_LeftTailLightdriverside.Visible = false;
                                            cbl_RightMirror.Visible = false;
                                            cbl_FrontLeftFender.Visible = true;
                                            int count = l_FrontLeftFender_removed.Count;
                                            Partname.Text = "Front Left Fender";
                                            // l_frontBumper.Remove(s);
                                            //Session["FrontBumper"]
                                        }
                                    }
                                    Session["FrontLeftFender"] = l_FrontLeftFender_removed;
                                }
                            }
                        }
                    }
                }
            }
        }
        //5.Front Left Door
        protected void gv_FrontLeftDoor_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            GridViewRow row = (GridViewRow)(((ImageButton)e.CommandSource).NamingContainer);
            if (e.CommandName == "Delete")
            {
                DataTable dt = (DataTable)ViewState["FrontLeftDoor_dt"];

                string idd = e.CommandArgument.ToString();
                int id = row.RowIndex;
                dt.Rows.RemoveAt(id);
                gv_FrontLeftDoor.DataSource = dt;
                gv_FrontLeftDoor.DataBind();
                if (dt.Rows.Count == 0)
                {
                   // gv_FrontLeftDoor_Div.Visible = false;
                }
                ViewState["FrontLeftDoor_Fill_summary"] = dt;
                DataTable dt2 = (DataTable)ViewState["FrontLeftDoor_tableCkbind_dt"];

                foreach (DataRow dr in dt2.Rows)
                {
                    if (Convert.ToInt32(dr["FRONTLEFTDOORID"]) == Convert.ToInt32(idd))
                    {
                        for (int i = 0; i < cbl_FrontLeftDoor.Items.Count; i++)
                        {
                            if (Convert.ToInt32(cbl_FrontLeftDoor.Items[i].Value) == Convert.ToInt32(dr["FRONTLEFTDOORID"]))
                            {
                                if (cbl_FrontLeftDoor.Items[i].Text.ToString() == Convert.ToString(dr["FRONTLEFTDOORDATA"]))
                                {
                                    cbl_FrontLeftDoor.Items[i].Selected = false;
                                    List<string> l_FrontLeftDoor = (List<string>)Session["FrontLeftDoor"];
                                    List<string> l_FrontLeftDoor_removed = new List<string>();
                                    foreach (string s in l_FrontLeftDoor)
                                    {
                                        if (s != cbl_FrontLeftDoor.Items[i].Value)
                                        {
                                            l_FrontLeftDoor_removed.Add(s);
                                            cbl_FrontBumper.Visible = false;
                                            cbl_Hood.Visible = false;
                                            cbl_Roof.Visible = false;
                                            cbl_FrontLeftFender.Visible = false;

                                            cbl_RearLeftQuarterPanel.Visible = false;
                                            cbl_FrontLeftWindow.Visible = false;
                                            cbl_RearLeftWindow.Visible = false;
                                            cbl_FrontWindshield.Visible = false;
                                            cbl_FrontLeftWheelTire.Visible = false;
                                            cbl_RearLeftWheelTire.Visible = false;
                                            cbl_FrontLeftHeadlight.Visible = false;
                                            cbl_FrontRightHeadlight.Visible = false;
                                            cbl_LeftMirror.Visible = false;
                                            cbl_Trunk.Visible = false;
                                            cbl_RearBumper.Visible = false;
                                            cbl_RearRightQuarterPanel.Visible = false;
                                            cbl_FrontRightFender.Visible = false;
                                            cbl_FrontRightDoor.Visible = false;
                                            cbl_RearRightDoor.Visible = false;
                                            cbl_FrontRightWindow.Visible = false;
                                            cbl_RearRightWindow.Visible = false;
                                            cbl_RearWindshield.Visible = false;
                                            cbl_FrontRightWheelTire.Visible = false;
                                            cbl_RearRightWheelTire.Visible = false;
                                            cbl_RightTailLight.Visible = false;
                                            cbl_LeftTailLightdriverside.Visible = false;
                                            cbl_RightMirror.Visible = false;
                                            cbl_RearLeftDoor.Visible = false;
                                            cbl_FrontLeftDoor.Visible = true;
                                            int count = l_FrontLeftDoor_removed.Count;
                                            Partname.Text = "Front Left Door";
                                            // l_frontBumper.Remove(s);
                                            //Session["FrontBumper"]
                                        }
                                    }
                                    Session["FrontLeftDoor"] = l_FrontLeftDoor_removed;
                                }
                            }
                        }
                    }
                }
            }
        }
        //6.Rear Left Door
        protected void gv_RearLeftDoor_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            GridViewRow row = (GridViewRow)(((ImageButton)e.CommandSource).NamingContainer);
            if (e.CommandName == "Delete")
            {
                DataTable dt = (DataTable)ViewState["RearLeftDoor_dt"];

                string idd = e.CommandArgument.ToString();
                int id = row.RowIndex;
                dt.Rows.RemoveAt(id);
                gv_RearLeftDoor.DataSource = dt;
                gv_RearLeftDoor.DataBind();
                if (dt.Rows.Count == 0)
                {
                   // gv_RearLeftDoor_Div.Visible = false;
                }
                ViewState["RearLeftDoor_fill_summary"] = dt;
                DataTable dt2 = (DataTable)ViewState["RearLeftDoor_tableCkbind_dt"];

                foreach (DataRow dr in dt2.Rows)
                {
                    if (Convert.ToInt32(dr["REARLEFTDOORID"]) == Convert.ToInt32(idd))
                    {
                        for (int i = 0; i < cbl_RearLeftDoor.Items.Count; i++)
                        {
                            if (Convert.ToInt32(cbl_RearLeftDoor.Items[i].Value) == Convert.ToInt32(dr["REARLEFTDOORID"]))
                            {
                                if (cbl_RearLeftDoor.Items[i].Text.ToString() == Convert.ToString(dr["REARLEFTDOORDATA"]))
                                {
                                    cbl_RearLeftDoor.Items[i].Selected = false;
                                    List<string> l_RearLeftDoor = (List<string>)Session["RearLeftDoor"];
                                    List<string> l_RearLeftDoor_removed = new List<string>();
                                    foreach (string s in l_RearLeftDoor)
                                    {
                                        if (s != cbl_RearLeftDoor.Items[i].Value)
                                        {
                                            l_RearLeftDoor_removed.Add(s);
                                            cbl_FrontBumper.Visible = false;
                                            cbl_Hood.Visible = false;
                                            cbl_Roof.Visible = false;
                                            cbl_FrontLeftFender.Visible = false;
                                            cbl_FrontLeftDoor.Visible = false;
                                            cbl_RearLeftQuarterPanel.Visible = false;
                                            cbl_FrontLeftWindow.Visible = false;
                                            cbl_RearLeftWindow.Visible = false;
                                            cbl_FrontWindshield.Visible = false;
                                            cbl_FrontLeftWheelTire.Visible = false;
                                            cbl_RearLeftWheelTire.Visible = false;
                                            cbl_FrontLeftHeadlight.Visible = false;
                                            cbl_FrontRightHeadlight.Visible = false;
                                            cbl_LeftMirror.Visible = false;
                                            cbl_Trunk.Visible = false;
                                            cbl_RearBumper.Visible = false;
                                            cbl_RearRightQuarterPanel.Visible = false;
                                            cbl_FrontRightFender.Visible = false;
                                            cbl_FrontRightDoor.Visible = false;
                                            cbl_RearRightDoor.Visible = false;
                                            cbl_FrontRightWindow.Visible = false;
                                            cbl_RearRightWindow.Visible = false;
                                            cbl_RearWindshield.Visible = false;
                                            cbl_FrontRightWheelTire.Visible = false;
                                            cbl_RearRightWheelTire.Visible = false;
                                            cbl_RightTailLight.Visible = false;
                                            cbl_LeftTailLightdriverside.Visible = false;
                                            cbl_RightMirror.Visible = false;
                                            cbl_RearLeftDoor.Visible = true;
                                            int count = l_RearLeftDoor_removed.Count;
                                            Partname.Text = "Rear Left Door";
                                            // l_frontBumper.Remove(s);
                                            //Session["FrontBumper"]
                                        }
                                    }
                                    Session["RearLeftDoor"] = l_RearLeftDoor_removed;
                                }
                            }
                        }
                    }
                }
            }
        }
        //7.Rear Left Quarter Panel
        protected void gv_RearLeftQuarterPanel_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            GridViewRow row = (GridViewRow)(((ImageButton)e.CommandSource).NamingContainer);
            if (e.CommandName == "Delete")
            {
                DataTable dt = (DataTable)ViewState["RearLeftQuarterPanel_dt"];

                string idd = e.CommandArgument.ToString();
                int id = row.RowIndex;
                dt.Rows.RemoveAt(id);
                gv_RearLeftQuarterPanel.DataSource = dt;
                gv_RearLeftQuarterPanel.DataBind();
                if (dt.Rows.Count == 0)
                {
                   // gv_RearLeftQuarterPanelDiv10.Visible = false;
                }

                ViewState["RearLeftQuarterPanel_fill_summary"] = dt;
                DataTable dt2 = (DataTable)ViewState["RearLeftQuarterPanel_tableCkbind_dt"];

                foreach (DataRow dr in dt2.Rows)
                {
                    if (Convert.ToInt32(dr["REARLEFTQUARTERPANELID"]) == Convert.ToInt32(idd))
                    {
                        for (int i = 0; i < cbl_RearLeftQuarterPanel.Items.Count; i++)
                        {
                            if (Convert.ToInt32(cbl_RearLeftQuarterPanel.Items[i].Value) == Convert.ToInt32(dr["REARLEFTQUARTERPANELID"]))
                            {
                                if (cbl_RearLeftQuarterPanel.Items[i].Text.ToString() == Convert.ToString(dr["REARLEFTQUARTERPANELDATA"]))
                                {
                                    cbl_RearLeftQuarterPanel.Items[i].Selected = false;
                                    List<string> l_RearLeftQuarterPanel = (List<string>)Session["RearLeftQuarterPanel"];
                                    List<string> l_RearLeftQuarterPanel_removed = new List<string>();
                                    foreach (string s in l_RearLeftQuarterPanel)
                                    {
                                        if (s != cbl_RearLeftQuarterPanel.Items[i].Value)
                                        {
                                            l_RearLeftQuarterPanel_removed.Add(s);
                                            cbl_FrontBumper.Visible = false;
                                            cbl_Hood.Visible = false;
                                            cbl_Roof.Visible = false;
                                            cbl_FrontLeftFender.Visible = false;
                                            cbl_FrontLeftDoor.Visible = false;
                                            cbl_RearLeftDoor.Visible = false;
                                            cbl_FrontLeftWindow.Visible = false;
                                            cbl_RearLeftWindow.Visible = false;
                                            cbl_FrontWindshield.Visible = false;
                                            cbl_FrontLeftWheelTire.Visible = false;
                                            cbl_RearLeftWheelTire.Visible = false;
                                            cbl_FrontLeftHeadlight.Visible = false;
                                            cbl_FrontRightHeadlight.Visible = false;
                                            cbl_LeftMirror.Visible = false;
                                            cbl_Trunk.Visible = false;
                                            cbl_RearBumper.Visible = false;
                                            cbl_RearRightQuarterPanel.Visible = false;
                                            cbl_FrontRightFender.Visible = false;
                                            cbl_FrontRightDoor.Visible = false;
                                            cbl_RearRightDoor.Visible = false;
                                            cbl_FrontRightWindow.Visible = false;
                                            cbl_RearRightWindow.Visible = false;
                                            cbl_RearWindshield.Visible = false;
                                            cbl_FrontRightWheelTire.Visible = false;
                                            cbl_RearRightWheelTire.Visible = false;
                                            cbl_RightTailLight.Visible = false;
                                            cbl_LeftTailLightdriverside.Visible = false;
                                            cbl_RightMirror.Visible = false;
                                            cbl_RearLeftQuarterPanel.Visible = true;
                                            int count = l_RearLeftQuarterPanel_removed.Count;
                                            Partname.Text = "Rear Left Quarter Panel";
                                            // l_frontBumper.Remove(s);
                                            //Session["FrontBumper"]
                                        }
                                    }
                                    Session["RearLeftQuarterPanel"] = l_RearLeftQuarterPanel_removed;
                                }
                            }
                        }
                    }
                }
            }
        }
        //8.Front Left Window
        protected void gv_FrontLeftWindow_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            GridViewRow row = (GridViewRow)(((ImageButton)e.CommandSource).NamingContainer);
            if (e.CommandName == "Delete")
            {
                DataTable dt = (DataTable)ViewState["FrontLeftWindow_dt"];
                string idd = e.CommandArgument.ToString();
                int id = row.RowIndex;
                dt.Rows.RemoveAt(id);
                gv_FrontLeftWindow.DataSource = dt;
                gv_FrontLeftWindow.DataBind();
                if (dt.Rows.Count == 0)
                {
                   // gv_FrontLeftWindowDiv11.Visible = false;
                }
                ViewState["FrontLeftWindow_fill_summary"] = dt;
                DataTable dt2 = (DataTable)ViewState["FrontLeftWindow_tableCkbind_dt"];

                foreach (DataRow dr in dt2.Rows)
                {
                    if (Convert.ToInt32(dr["FRONTLEFTWINDOWID"]) == Convert.ToInt32(idd))
                    {
                        for (int i = 0; i < cbl_FrontLeftWindow.Items.Count; i++)
                        {
                            if (Convert.ToInt32(cbl_FrontLeftWindow.Items[i].Value) == Convert.ToInt32(dr["FRONTLEFTWINDOWID"]))
                            {
                                if (cbl_FrontLeftWindow.Items[i].Text.ToString() == Convert.ToString(dr["FRONTLEFTWINDOWDATA"]))
                                {
                                    cbl_FrontLeftWindow.Items[i].Selected = false;
                                    List<string> l_FrontLeftWindow = (List<string>)Session["FrontLeftWindow"];
                                    List<string> l_FrontLeftWindow_removed = new List<string>();
                                    foreach (string s in l_FrontLeftWindow)
                                    {
                                        if (s != cbl_FrontLeftWindow.Items[i].Value)
                                        {
                                            l_FrontLeftWindow_removed.Add(s);
                                            cbl_FrontBumper.Visible = false;
                                            cbl_Hood.Visible = false;
                                            cbl_Roof.Visible = false;
                                            cbl_FrontLeftFender.Visible = false;
                                            cbl_FrontLeftDoor.Visible = false;
                                            cbl_RearLeftDoor.Visible = false;
                                            cbl_RearLeftQuarterPanel.Visible = false;
                                            cbl_RearLeftWindow.Visible = false;
                                            cbl_FrontWindshield.Visible = false;
                                            cbl_FrontLeftWheelTire.Visible = false;
                                            cbl_RearLeftWheelTire.Visible = false;
                                            cbl_FrontLeftHeadlight.Visible = false;
                                            cbl_FrontRightHeadlight.Visible = false;
                                            cbl_LeftMirror.Visible = false;
                                            cbl_Trunk.Visible = false;
                                            cbl_RearBumper.Visible = false;
                                            cbl_RearRightQuarterPanel.Visible = false;
                                            cbl_FrontRightFender.Visible = false;
                                            cbl_FrontRightDoor.Visible = false;
                                            cbl_RearRightDoor.Visible = false;
                                            cbl_FrontRightWindow.Visible = false;
                                            cbl_RearRightWindow.Visible = false;
                                            cbl_RearWindshield.Visible = false;
                                            cbl_FrontRightWheelTire.Visible = false;
                                            cbl_RearRightWheelTire.Visible = false;
                                            cbl_RightTailLight.Visible = false;
                                            cbl_LeftTailLightdriverside.Visible = false;
                                            cbl_RightMirror.Visible = false;
                                            cbl_FrontLeftWindow.Visible = true;
                                            int count = l_FrontLeftWindow_removed.Count;
                                            Partname.Text = "Front Left Window";
                                            // l_frontBumper.Remove(s);
                                            //Session["FrontBumper"]
                                        }
                                    }
                                    Session["FrontLeftWindow"] = l_FrontLeftWindow_removed;
                                }
                            }
                        }
                    }
                }
            }
        }
        //9.Rear Left Window
        protected void gv_RearLeftWindow_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            GridViewRow row = (GridViewRow)(((ImageButton)e.CommandSource).NamingContainer);
            if (e.CommandName == "Delete")
            {
                DataTable dt = (DataTable)ViewState["RearLeftWindow_dt"];

                string idd = e.CommandArgument.ToString();
                int id = row.RowIndex;
                dt.Rows.RemoveAt(id);
                gv_RearLeftWindow.DataSource = dt;
                gv_RearLeftWindow.DataBind();
                if (dt.Rows.Count == 0)
                {
                   // gv_RearLeftWindowDiv12.Visible = false;
                }
                ViewState["RearLeftWindow_fill_summary"] = dt;
                DataTable dt2 = (DataTable)ViewState["RearLeftWindow_tableCkbind_dt"];

                foreach (DataRow dr in dt2.Rows)
                {
                    if (Convert.ToInt32(dr["REARLEFTWINDOWID"]) == Convert.ToInt32(idd))
                    {
                        for (int i = 0; i < cbl_RearLeftWindow.Items.Count; i++)
                        {
                            if (Convert.ToInt32(cbl_RearLeftWindow.Items[i].Value) == Convert.ToInt32(dr["REARLEFTWINDOWID"]))
                            {
                                if (cbl_RearLeftWindow.Items[i].Text.ToString() == Convert.ToString(dr["REARLEFTWINDOWDATA"]))
                                {
                                    cbl_RearLeftWindow.Items[i].Selected = false;
                                    List<string> l_RearLeftWindow = (List<string>)Session["RearLeftWindow"];
                                    List<string> l_RearLeftWindow_removed = new List<string>();
                                    foreach (string s in l_RearLeftWindow)
                                    {
                                        if (s != cbl_RearLeftWindow.Items[i].Value)
                                        {
                                            l_RearLeftWindow_removed.Add(s);
                                            cbl_FrontBumper.Visible = false;
                                            cbl_Hood.Visible = false;
                                            cbl_Roof.Visible = false;
                                            cbl_FrontLeftFender.Visible = false;
                                            cbl_FrontLeftDoor.Visible = false;
                                            cbl_RearLeftDoor.Visible = false;
                                            cbl_RearLeftQuarterPanel.Visible = false;
                                            cbl_FrontLeftWindow.Visible = false;
                                            cbl_FrontWindshield.Visible = false;
                                            cbl_FrontLeftWheelTire.Visible = false;
                                            cbl_RearLeftWheelTire.Visible = false;
                                            cbl_FrontLeftHeadlight.Visible = false;
                                            cbl_FrontRightHeadlight.Visible = false;
                                            cbl_LeftMirror.Visible = false;
                                            cbl_Trunk.Visible = false;
                                            cbl_RearBumper.Visible = false;
                                            cbl_RearRightQuarterPanel.Visible = false;
                                            cbl_FrontRightFender.Visible = false;
                                            cbl_FrontRightDoor.Visible = false;
                                            cbl_RearRightDoor.Visible = false;
                                            cbl_FrontRightWindow.Visible = false;
                                            cbl_RearRightWindow.Visible = false;
                                            cbl_RearWindshield.Visible = false;
                                            cbl_FrontRightWheelTire.Visible = false;
                                            cbl_RearRightWheelTire.Visible = false;
                                            cbl_RightTailLight.Visible = false;
                                            cbl_LeftTailLightdriverside.Visible = false;
                                            cbl_RightMirror.Visible = false;
                                            cbl_RearLeftWindow.Visible = true;
                                            int count = l_RearLeftWindow_removed.Count;
                                            Partname.Text = "Rear Left Window";
                                            // l_frontBumper.Remove(s);
                                            //Session["FrontBumper"]
                                        }
                                    }
                                    Session["RearLeftWindow"] = l_RearLeftWindow_removed;
                                }
                            }
                        }
                    }
                }
            }
        }
        //10.Front Windshield
        protected void gv_FrontWindshield_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            GridViewRow row = (GridViewRow)(((ImageButton)e.CommandSource).NamingContainer);
            if (e.CommandName == "Delete")
            {
                DataTable dt = (DataTable)ViewState["FrontWindshield_dt"];

                string idd = e.CommandArgument.ToString();
                int id = row.RowIndex;
                dt.Rows.RemoveAt(id);
                gv_FrontWindshield.DataSource = dt;
                gv_FrontWindshield.DataBind();
                if (dt.Rows.Count == 0)
                {
                   // gv_FrontWindshieldDiv13.Visible = false;
                }
                ViewState["FrontWindshield_fill_summary"] = dt;
                DataTable dt2 = (DataTable)ViewState["FrontWindshield_tableCkbind_dt"];

                foreach (DataRow dr in dt2.Rows)
                {
                    if (Convert.ToInt32(dr["FRONTWINDSHIELDID"]) == Convert.ToInt32(idd))
                    {
                        for (int i = 0; i < cbl_FrontWindshield.Items.Count; i++)
                        {
                            if (Convert.ToInt32(cbl_FrontWindshield.Items[i].Value) == Convert.ToInt32(dr["FRONTWINDSHIELDID"]))
                            {
                                if (cbl_FrontWindshield.Items[i].Text.ToString() == Convert.ToString(dr["FRONTWINDSHIELDDATA"]))
                                {
                                    cbl_FrontWindshield.Items[i].Selected = false;
                                    List<string> l_FrontWindshield = (List<string>)Session["FrontWindshield"];
                                    List<string> l_FrontWindshield_removed = new List<string>();
                                    foreach (string s in l_FrontWindshield)
                                    {
                                        if (s != cbl_FrontWindshield.Items[i].Value)
                                        {
                                            l_FrontWindshield_removed.Add(s);
                                            cbl_FrontBumper.Visible = false;
                                            cbl_Hood.Visible = false;
                                            cbl_Roof.Visible = false;
                                            cbl_FrontLeftFender.Visible = false;
                                            cbl_FrontLeftDoor.Visible = false;
                                            cbl_RearLeftDoor.Visible = false;
                                            cbl_RearLeftQuarterPanel.Visible = false;
                                            cbl_FrontLeftWindow.Visible = false;
                                            cbl_RearLeftWindow.Visible = false;

                                            cbl_FrontLeftWheelTire.Visible = false;
                                            cbl_RearLeftWheelTire.Visible = false;
                                            cbl_FrontLeftHeadlight.Visible = false;
                                            cbl_FrontRightHeadlight.Visible = false;
                                            cbl_LeftMirror.Visible = false;
                                            cbl_Trunk.Visible = false;
                                            cbl_RearBumper.Visible = false;
                                            cbl_RearRightQuarterPanel.Visible = false;
                                            cbl_FrontRightFender.Visible = false;
                                            cbl_FrontRightDoor.Visible = false;
                                            cbl_RearRightDoor.Visible = false;
                                            cbl_FrontRightWindow.Visible = false;
                                            cbl_RearRightWindow.Visible = false;
                                            cbl_RearWindshield.Visible = false;
                                            cbl_FrontRightWheelTire.Visible = false;
                                            cbl_RearRightWheelTire.Visible = false;
                                            cbl_RightTailLight.Visible = false;
                                            cbl_LeftTailLightdriverside.Visible = false;
                                            cbl_RightMirror.Visible = false;
                                            cbl_FrontWindshield.Visible = true;
                                            int count = l_FrontWindshield_removed.Count;
                                            Partname.Text = "Front Windshield";
                                            // l_frontBumper.Remove(s);
                                            //Session["FrontBumper"]
                                        }
                                    }
                                    Session["FrontWindshield"] = l_FrontWindshield_removed;
                                }
                            }
                        }
                    }
                }
            }
        }
        //11.Front Left Wheel & Tire
        protected void gv_FrontLeftWheelTire_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            GridViewRow row = (GridViewRow)(((ImageButton)e.CommandSource).NamingContainer);
            if (e.CommandName == "Delete")
            {
                DataTable dt = (DataTable)ViewState["FrontLeftWheelTire_dt"];

                string idd = e.CommandArgument.ToString();
                int id = row.RowIndex;
                dt.Rows.RemoveAt(id);
                gv_FrontLeftWheelTire.DataSource = dt;
                gv_FrontLeftWheelTire.DataBind();
                if (dt.Rows.Count == 0)
                {
                   // gv_FrontLeftWheelTireDiv14.Visible = false;
                }
                ViewState["FrontLeftWheelTire_fill_summary"] = dt;
                DataTable dt2 = (DataTable)ViewState["FrontLeftWheelTire_tableCkbind_dt"];

                foreach (DataRow dr in dt2.Rows)
                {
                    if (Convert.ToInt32(dr["FRONTLEFTWHEELTIREID"]) == Convert.ToInt32(idd))
                    {
                        for (int i = 0; i < cbl_FrontLeftWheelTire.Items.Count; i++)
                        {
                            if (Convert.ToInt32(cbl_FrontLeftWheelTire.Items[i].Value) == Convert.ToInt32(dr["FRONTLEFTWHEELTIREID"]))
                            {
                                if (cbl_FrontLeftWheelTire.Items[i].Text.ToString() == Convert.ToString(dr["FRONTLEFTWHEELTIREDATA"]))
                                {
                                    cbl_FrontLeftWheelTire.Items[i].Selected = false;
                                    List<string> l_FrontLeftWheelTire = (List<string>)Session["FrontLeftWheelTire"];
                                    List<string> l_FrontLeftWheelTire_removed = new List<string>();
                                    foreach (string s in l_FrontLeftWheelTire)
                                    {
                                        if (s != cbl_FrontLeftWheelTire.Items[i].Value)
                                        {
                                            l_FrontLeftWheelTire_removed.Add(s);
                                            cbl_FrontBumper.Visible = false;
                                            cbl_Hood.Visible = false;
                                            cbl_Roof.Visible = false;
                                            cbl_FrontLeftFender.Visible = false;
                                            cbl_FrontLeftDoor.Visible = false;
                                            cbl_RearLeftDoor.Visible = false;
                                            cbl_RearLeftQuarterPanel.Visible = false;
                                            cbl_FrontLeftWindow.Visible = false;
                                            cbl_RearLeftWindow.Visible = false;
                                            cbl_FrontWindshield.Visible = false;

                                            cbl_RearLeftWheelTire.Visible = false;
                                            cbl_FrontLeftHeadlight.Visible = false;
                                            cbl_FrontRightHeadlight.Visible = false;
                                            cbl_LeftMirror.Visible = false;
                                            cbl_Trunk.Visible = false;
                                            cbl_RearBumper.Visible = false;
                                            cbl_RearRightQuarterPanel.Visible = false;
                                            cbl_FrontRightFender.Visible = false;
                                            cbl_FrontRightDoor.Visible = false;
                                            cbl_RearRightDoor.Visible = false;
                                            cbl_FrontRightWindow.Visible = false;
                                            cbl_RearRightWindow.Visible = false;
                                            cbl_RearWindshield.Visible = false;
                                            cbl_FrontRightWheelTire.Visible = false;
                                            cbl_RearRightWheelTire.Visible = false;
                                            cbl_RightTailLight.Visible = false;
                                            cbl_LeftTailLightdriverside.Visible = false;
                                            cbl_RightMirror.Visible = false;
                                            cbl_FrontLeftWheelTire.Visible = true;
                                            int count = l_FrontLeftWheelTire_removed.Count;
                                            Partname.Text = "Front Left Wheel & Tire";
                                            // l_frontBumper.Remove(s);
                                            //Session["FrontBumper"]
                                        }
                                    }
                                    Session["FrontLeftWheelTire"] = l_FrontLeftWheelTire_removed;
                                }
                            }
                        }
                    }
                }
            }
        }
        //12.Rear Left Wheel & Tire
        protected void gv_RearLeftWheelTire_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            GridViewRow row = (GridViewRow)(((ImageButton)e.CommandSource).NamingContainer);
            if (e.CommandName == "Delete")
            {
                DataTable dt = (DataTable)ViewState["RearLeftWheelTire_dt"];
                string idd = e.CommandArgument.ToString();
                int id = row.RowIndex;
                dt.Rows.RemoveAt(id);
                gv_RearLeftWheelTire.DataSource = dt;
                gv_RearLeftWheelTire.DataBind();
                if (dt.Rows.Count == 0)
                {
                  //  gv_RearLeftWheelTireDiv15.Visible = false;
                }
                ViewState["RearLeftWheelTire_fill_summary"] = dt;
                DataTable dt2 = (DataTable)ViewState["RearLeftWheelTire_tableCkbind_dt"];

                foreach (DataRow dr in dt2.Rows)
                {
                    if (Convert.ToInt32(dr["REARLEFTWHEELTIREID"]) == Convert.ToInt32(idd))
                    {
                        for (int i = 0; i < cbl_RearLeftWheelTire.Items.Count; i++)
                        {
                            if (Convert.ToInt32(cbl_RearLeftWheelTire.Items[i].Value) == Convert.ToInt32(dr["REARLEFTWHEELTIREID"]))
                            {
                                if (cbl_RearLeftWheelTire.Items[i].Text.ToString() == Convert.ToString(dr["REARLEFTWHEELTIREDATA"]))
                                {
                                    cbl_RearLeftWheelTire.Items[i].Selected = false;
                                    List<string> l_RearLeftWheelTire = (List<string>)Session["RearLeftWheelTire"];
                                    List<string> l_RearLeftWheelTire_removed = new List<string>();
                                    foreach (string s in l_RearLeftWheelTire)
                                    {
                                        if (s != cbl_RearLeftWheelTire.Items[i].Value)
                                        {
                                            l_RearLeftWheelTire_removed.Add(s);
                                            cbl_FrontBumper.Visible = false;
                                            cbl_Hood.Visible = false;
                                            cbl_Roof.Visible = false;
                                            cbl_FrontLeftFender.Visible = false;
                                            cbl_FrontLeftDoor.Visible = false;
                                            cbl_RearLeftDoor.Visible = false;
                                            cbl_RearLeftQuarterPanel.Visible = false;
                                            cbl_FrontLeftWindow.Visible = false;
                                            cbl_RearLeftWindow.Visible = false;
                                            cbl_FrontWindshield.Visible = false;
                                            cbl_FrontLeftWheelTire.Visible = false;

                                            cbl_FrontLeftHeadlight.Visible = false;
                                            cbl_FrontRightHeadlight.Visible = false;
                                            cbl_LeftMirror.Visible = false;
                                            cbl_Trunk.Visible = false;
                                            cbl_RearBumper.Visible = false;
                                            cbl_RearRightQuarterPanel.Visible = false;
                                            cbl_FrontRightFender.Visible = false;
                                            cbl_FrontRightDoor.Visible = false;
                                            cbl_RearRightDoor.Visible = false;
                                            cbl_FrontRightWindow.Visible = false;
                                            cbl_RearRightWindow.Visible = false;
                                            cbl_RearWindshield.Visible = false;
                                            cbl_FrontRightWheelTire.Visible = false;
                                            cbl_RearRightWheelTire.Visible = false;
                                            cbl_RightTailLight.Visible = false;
                                            cbl_LeftTailLightdriverside.Visible = false;
                                            cbl_RightMirror.Visible = false;
                                            cbl_RearLeftWheelTire.Visible = true;
                                            int count = l_RearLeftWheelTire_removed.Count;
                                            Partname.Text = "Rear Left Wheel & Tire";
                                            // l_frontBumper.Remove(s);
                                            //Session["FrontBumper"]
                                        }
                                    }
                                    Session["RearLeftWheelTire"] = l_RearLeftWheelTire_removed;
                                }
                            }
                        }
                    }
                }
            }
        }
        //13.Front Left Headlight
        protected void gv_FrontLeftHeadlight_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            GridViewRow row = (GridViewRow)(((ImageButton)e.CommandSource).NamingContainer);
            if (e.CommandName == "Delete")
            {
                DataTable dt = (DataTable)ViewState["FrontLeftHeadlight_dt"];

                string idd = e.CommandArgument.ToString();
                int id = row.RowIndex;
                dt.Rows.RemoveAt(id);
                gv_FrontLeftHeadlight.DataSource = dt;
                gv_FrontLeftHeadlight.DataBind();
                if (dt.Rows.Count == 0)
                {
                   // gv_FrontLeftHeadlightDiv16.Visible = false;
                }
                ViewState["FrontLeftHeadlight_fill_summary"] = dt;
                DataTable dt2 = (DataTable)ViewState["FrontLeftHeadlight_tableCkbind_dt"];

                foreach (DataRow dr in dt2.Rows)
                {
                    if (Convert.ToInt32(dr["FRONTLEFTHEADLIGHTID"]) == Convert.ToInt32(idd))
                    {
                        for (int i = 0; i < cbl_FrontLeftHeadlight.Items.Count; i++)
                        {
                            if (Convert.ToInt32(cbl_FrontLeftHeadlight.Items[i].Value) == Convert.ToInt32(dr["FRONTLEFTHEADLIGHTID"]))
                            {
                                if (cbl_FrontLeftHeadlight.Items[i].Text.ToString() == Convert.ToString(dr["FRONTLEFTHEADLIGHTDATA"]))
                                {
                                    cbl_FrontLeftHeadlight.Items[i].Selected = false;
                                    List<string> l_FrontLeftHeadlight = (List<string>)Session["FrontLeftHeadlight"];
                                    List<string> l_FrontLeftHeadlight_removed = new List<string>();
                                    foreach (string s in l_FrontLeftHeadlight)
                                    {
                                        if (s != cbl_FrontLeftHeadlight.Items[i].Value)
                                        {
                                            l_FrontLeftHeadlight_removed.Add(s);
                                            cbl_FrontBumper.Visible = false;
                                            cbl_Hood.Visible = false;
                                            cbl_Roof.Visible = false;
                                            cbl_FrontLeftFender.Visible = false;
                                            cbl_FrontLeftDoor.Visible = false;
                                            cbl_RearLeftDoor.Visible = false;
                                            cbl_RearLeftQuarterPanel.Visible = false;
                                            cbl_FrontLeftWindow.Visible = false;
                                            cbl_RearLeftWindow.Visible = false;
                                            cbl_FrontWindshield.Visible = false;
                                            cbl_FrontLeftWheelTire.Visible = false;
                                            cbl_RearLeftWheelTire.Visible = false;

                                            cbl_FrontRightHeadlight.Visible = false;
                                            cbl_LeftMirror.Visible = false;
                                            cbl_Trunk.Visible = false;
                                            cbl_RearBumper.Visible = false;
                                            cbl_RearRightQuarterPanel.Visible = false;
                                            cbl_FrontRightFender.Visible = false;
                                            cbl_FrontRightDoor.Visible = false;
                                            cbl_RearRightDoor.Visible = false;
                                            cbl_FrontRightWindow.Visible = false;
                                            cbl_RearRightWindow.Visible = false;
                                            cbl_RearWindshield.Visible = false;
                                            cbl_FrontRightWheelTire.Visible = false;
                                            cbl_RearRightWheelTire.Visible = false;
                                            cbl_RightTailLight.Visible = false;
                                            cbl_LeftTailLightdriverside.Visible = false;
                                            cbl_RightMirror.Visible = false;
                                            cbl_FrontLeftHeadlight.Visible = true;
                                            int count = l_FrontLeftHeadlight_removed.Count;
                                            Partname.Text = "Front Left Headlight";
                                            // l_frontBumper.Remove(s);
                                            //Session["FrontBumper"]
                                        }
                                    }
                                    Session["FrontLeftHeadlight"] = l_FrontLeftHeadlight_removed;
                                }
                            }
                        }
                    }
                }
            }
        }
        //14.Front Right Headlight
        protected void gv_FrontRightHeadlight_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            GridViewRow row = (GridViewRow)(((ImageButton)e.CommandSource).NamingContainer);
            if (e.CommandName == "Delete")
            {
                DataTable dt = (DataTable)ViewState["FrontRightHeadlight_dt"];
                string idd = e.CommandArgument.ToString();
                int id = row.RowIndex;
                dt.Rows.RemoveAt(id);
                gv_FrontRightHeadlight.DataSource = dt;
                gv_FrontRightHeadlight.DataBind();
                if (dt.Rows.Count == 0)
                {
                  //  gv_FrontRightHeadlightDiv17.Visible = false;
                }
                ViewState["FrontRightHeadlight_fill_summary"] = dt;
                DataTable dt2 = (DataTable)ViewState["FrontRightHeadlight_tableCkbind_dt"];

                foreach (DataRow dr in dt2.Rows)
                {
                    if (Convert.ToInt32(dr["FRONTRIGHTHEADLIGHTID"]) == Convert.ToInt32(idd))
                    {
                        for (int i = 0; i < cbl_FrontRightHeadlight.Items.Count; i++)
                        {
                            if (Convert.ToInt32(cbl_FrontRightHeadlight.Items[i].Value) == Convert.ToInt32(dr["FRONTRIGHTHEADLIGHTID"]))
                            {
                                if (cbl_FrontRightHeadlight.Items[i].Text.ToString() == Convert.ToString(dr["FRONTRIGHTHEADLIGHTDATA"]))
                                {
                                    cbl_FrontRightHeadlight.Items[i].Selected = false;
                                    List<string> l_FrontRightHeadlight = (List<string>)Session["FrontRightHeadlight"];
                                    List<string> l_FrontRightHeadlight_removed = new List<string>();
                                    foreach (string s in l_FrontRightHeadlight)
                                    {
                                        if (s != cbl_FrontRightHeadlight.Items[i].Value)
                                        {
                                            l_FrontRightHeadlight_removed.Add(s);
                                            cbl_FrontBumper.Visible = false;
                                            cbl_Hood.Visible = false;
                                            cbl_Roof.Visible = false;
                                            cbl_FrontLeftFender.Visible = false;
                                            cbl_FrontLeftDoor.Visible = false;
                                            cbl_RearLeftDoor.Visible = false;
                                            cbl_RearLeftQuarterPanel.Visible = false;
                                            cbl_FrontLeftWindow.Visible = false;
                                            cbl_RearLeftWindow.Visible = false;
                                            cbl_FrontWindshield.Visible = false;
                                            cbl_FrontLeftWheelTire.Visible = false;
                                            cbl_RearLeftWheelTire.Visible = false;
                                            cbl_FrontLeftHeadlight.Visible = false;
                                            cbl_LeftMirror.Visible = false;
                                            cbl_Trunk.Visible = false;
                                            cbl_RearBumper.Visible = false;
                                            cbl_RearRightQuarterPanel.Visible = false;
                                            cbl_FrontRightFender.Visible = false;
                                            cbl_FrontRightDoor.Visible = false;
                                            cbl_RearRightDoor.Visible = false;
                                            cbl_FrontRightWindow.Visible = false;
                                            cbl_RearRightWindow.Visible = false;
                                            cbl_RearWindshield.Visible = false;
                                            cbl_FrontRightWheelTire.Visible = false;
                                            cbl_RearRightWheelTire.Visible = false;
                                            cbl_RightTailLight.Visible = false;
                                            cbl_LeftTailLightdriverside.Visible = false;
                                            cbl_RightMirror.Visible = false;
                                            cbl_FrontRightHeadlight.Visible = true;
                                            int count = l_FrontRightHeadlight_removed.Count;
                                            Partname.Text = "Front Right Headlight";
                                            // l_frontBumper.Remove(s);
                                            //Session["FrontBumper"]
                                        }
                                    }
                                    Session["FrontRightHeadlight"] = l_FrontRightHeadlight_removed;
                                }
                            }
                        }
                    }
                }
            }
        }
        //15.Left Mirror
        protected void gv_LeftMirror_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            GridViewRow row = (GridViewRow)(((ImageButton)e.CommandSource).NamingContainer);
            if (e.CommandName == "Delete")
            {
                DataTable dt = (DataTable)ViewState["LeftMirror_dt"];

                string idd = e.CommandArgument.ToString();
                int id = row.RowIndex;
                dt.Rows.RemoveAt(id);
                gv_LeftMirror.DataSource = dt;
                gv_LeftMirror.DataBind();
                if (dt.Rows.Count == 0)
                {
                   // gv_LeftMirrorDiv18.Visible = false;
                }
                ViewState["LeftMirror_fill_summary"] = dt;
                DataTable dt2 = (DataTable)ViewState["LeftMirror_tableCkbind_dt"];

                foreach (DataRow dr in dt2.Rows)
                {
                    if (Convert.ToInt32(dr["LEFTMIRRORID"]) == Convert.ToInt32(idd))
                    {
                        for (int i = 0; i < cbl_LeftMirror.Items.Count; i++)
                        {
                            if (Convert.ToInt32(cbl_LeftMirror.Items[i].Value) == Convert.ToInt32(dr["LEFTMIRRORID"]))
                            {
                                if (cbl_LeftMirror.Items[i].Text.ToString() == Convert.ToString(dr["LEFTMIRRORDATA"]))
                                {
                                    cbl_LeftMirror.Items[i].Selected = false;
                                    List<string> l_LeftMirror = (List<string>)Session["LeftMirror"];
                                    List<string> l_LeftMirror_removed = new List<string>();
                                    foreach (string s in l_LeftMirror)
                                    {
                                        if (s != cbl_LeftMirror.Items[i].Value)
                                        {
                                            l_LeftMirror_removed.Add(s);
                                            cbl_FrontBumper.Visible = false;
                                            cbl_Hood.Visible = false;
                                            cbl_Roof.Visible = false;
                                            cbl_FrontLeftFender.Visible = false;
                                            cbl_FrontLeftDoor.Visible = false;
                                            cbl_RearLeftDoor.Visible = false;
                                            cbl_RearLeftQuarterPanel.Visible = false;
                                            cbl_FrontLeftWindow.Visible = false;
                                            cbl_RearLeftWindow.Visible = false;
                                            cbl_FrontWindshield.Visible = false;
                                            cbl_FrontLeftWheelTire.Visible = false;
                                            cbl_RearLeftWheelTire.Visible = false;
                                            cbl_FrontLeftHeadlight.Visible = false;
                                            cbl_FrontRightHeadlight.Visible = false;
                                            cbl_Trunk.Visible = false;
                                            cbl_RearBumper.Visible = false;
                                            cbl_RearRightQuarterPanel.Visible = false;
                                            cbl_FrontRightFender.Visible = false;
                                            cbl_FrontRightDoor.Visible = false;
                                            cbl_RearRightDoor.Visible = false;
                                            cbl_FrontRightWindow.Visible = false;
                                            cbl_RearRightWindow.Visible = false;
                                            cbl_RearWindshield.Visible = false;
                                            cbl_FrontRightWheelTire.Visible = false;
                                            cbl_RearRightWheelTire.Visible = false;
                                            cbl_RightTailLight.Visible = false;
                                            cbl_LeftTailLightdriverside.Visible = false;
                                            cbl_RightMirror.Visible = false;
                                            cbl_LeftMirror.Visible = true;
                                            int count = l_LeftMirror_removed.Count;
                                            Partname.Text = "Left Mirror";
                                            // l_frontBumper.Remove(s);
                                            //Session["FrontBumper"]
                                        }
                                    }
                                    Session["LeftMirror"] = l_LeftMirror_removed;
                                }
                            }
                        }
                    }
                }
            }
        }
        //17.Trunk
        protected void gv_Trunk_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            GridViewRow row = (GridViewRow)(((ImageButton)e.CommandSource).NamingContainer);
            if (e.CommandName == "Delete")
            {
                DataTable dt = (DataTable)ViewState["Trunk_dt"];

                string idd = e.CommandArgument.ToString();
                int id = row.RowIndex;
                dt.Rows.RemoveAt(id);
                gv_Trunk.DataSource = dt;
                gv_Trunk.DataBind();
                if (dt.Rows.Count == 0)
                {
                   // gv_TrunkDiv19.Visible = false;
                }

                ViewState["Trunk_fill_summary"] = dt;
                DataTable dt2 = (DataTable)ViewState["Trunk_tableCkbind_dt"];

                foreach (DataRow dr in dt2.Rows)
                {
                    if (Convert.ToInt32(dr["TRUNKID"]) == Convert.ToInt32(idd))
                    {
                        for (int i = 0; i < cbl_Trunk.Items.Count; i++)
                        {
                            if (Convert.ToInt32(cbl_Trunk.Items[i].Value) == Convert.ToInt32(dr["TRUNKID"]))
                            {
                                if (cbl_Trunk.Items[i].Text.ToString() == Convert.ToString(dr["TRUNKDATA"]))
                                {
                                    cbl_Trunk.Items[i].Selected = false;
                                    List<string> l_Trunk = (List<string>)Session["Trunk"];
                                    List<string> l_Trunk_removed = new List<string>();
                                    foreach (string s in l_Trunk)
                                    {
                                        if (s != cbl_Trunk.Items[i].Value)
                                        {
                                            l_Trunk_removed.Add(s);
                                            cbl_FrontBumper.Visible = false;
                                            cbl_Hood.Visible = false;
                                            cbl_Roof.Visible = false;
                                            cbl_FrontLeftFender.Visible = false;
                                            cbl_FrontLeftDoor.Visible = false;
                                            cbl_RearLeftDoor.Visible = false;
                                            cbl_RearLeftQuarterPanel.Visible = false;
                                            cbl_FrontLeftWindow.Visible = false;
                                            cbl_RearLeftWindow.Visible = false;
                                            cbl_FrontWindshield.Visible = false;
                                            cbl_FrontLeftWheelTire.Visible = false;
                                            cbl_RearLeftWheelTire.Visible = false;
                                            cbl_FrontLeftHeadlight.Visible = false;
                                            cbl_FrontRightHeadlight.Visible = false;
                                            cbl_LeftMirror.Visible = false;
                                            cbl_RearBumper.Visible = false;
                                            cbl_RearRightQuarterPanel.Visible = false;
                                            cbl_FrontRightFender.Visible = false;
                                            cbl_FrontRightDoor.Visible = false;
                                            cbl_RearRightDoor.Visible = false;
                                            cbl_FrontRightWindow.Visible = false;
                                            cbl_RearRightWindow.Visible = false;
                                            cbl_RearWindshield.Visible = false;
                                            cbl_FrontRightWheelTire.Visible = false;
                                            cbl_RearRightWheelTire.Visible = false;
                                            cbl_RightTailLight.Visible = false;
                                            cbl_LeftTailLightdriverside.Visible = false;
                                            cbl_RightMirror.Visible = false;
                                            cbl_Trunk.Visible = true;
                                            int count = l_Trunk_removed.Count;
                                            Partname.Text = "Trunk";
                                            // l_frontBumper.Remove(s);
                                            //Session["FrontBumper"]
                                        }
                                    }
                                    Session["Trunk"] = l_Trunk_removed;
                                }
                            }
                        }
                    }
                }
            }
        }
        //18.Rear Bumper
        protected void gv_RearBumper_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            GridViewRow row = (GridViewRow)(((ImageButton)e.CommandSource).NamingContainer);
            if (e.CommandName == "Delete")
            {
                DataTable dt = (DataTable)ViewState["RearBumper_dt"];

                string idd = e.CommandArgument.ToString();
                int id = row.RowIndex;
                dt.Rows.RemoveAt(id);
                gv_RearBumper.DataSource = dt;
                gv_RearBumper.DataBind();
                if (dt.Rows.Count == 0)
                {
                   // gv_RearBumperDiv20.Visible = false;
                }
                ViewState["RearBumper_fill_summary"] = dt;
                DataTable dt2 = (DataTable)ViewState["RearBumper_tableCkbind_dt"];

                foreach (DataRow dr in dt2.Rows)
                {
                    if (Convert.ToInt32(dr["REARBUMPERID"]) == Convert.ToInt32(idd))
                    {
                        for (int i = 0; i < cbl_RearBumper.Items.Count; i++)
                        {
                            if (Convert.ToInt32(cbl_RearBumper.Items[i].Value) == Convert.ToInt32(dr["REARBUMPERID"]))
                            {
                                if (cbl_RearBumper.Items[i].Text.ToString() == Convert.ToString(dr["REARBUMPERDATA"]))
                                {
                                    cbl_RearBumper.Items[i].Selected = false;
                                    List<string> l_RearBumper = (List<string>)Session["RearBumper"];
                                    List<string> l_RearBumper_removed = new List<string>();
                                    foreach (string s in l_RearBumper)
                                    {
                                        if (s != cbl_RearBumper.Items[i].Value)
                                        {
                                            l_RearBumper_removed.Add(s);
                                            cbl_FrontBumper.Visible = false;
                                            cbl_Hood.Visible = false;
                                            cbl_Roof.Visible = false;
                                            cbl_FrontLeftFender.Visible = false;
                                            cbl_FrontLeftDoor.Visible = false;
                                            cbl_RearLeftDoor.Visible = false;
                                            cbl_RearLeftQuarterPanel.Visible = false;
                                            cbl_FrontLeftWindow.Visible = false;
                                            cbl_RearLeftWindow.Visible = false;
                                            cbl_FrontWindshield.Visible = false;
                                            cbl_FrontLeftWheelTire.Visible = false;
                                            cbl_RearLeftWheelTire.Visible = false;
                                            cbl_FrontLeftHeadlight.Visible = false;
                                            cbl_FrontRightHeadlight.Visible = false;
                                            cbl_LeftMirror.Visible = false;
                                            cbl_Trunk.Visible = false;
                                            cbl_RearRightQuarterPanel.Visible = false;
                                            cbl_FrontRightFender.Visible = false;
                                            cbl_FrontRightDoor.Visible = false;
                                            cbl_RearRightDoor.Visible = false;
                                            cbl_FrontRightWindow.Visible = false;
                                            cbl_RearRightWindow.Visible = false;
                                            cbl_RearWindshield.Visible = false;
                                            cbl_FrontRightWheelTire.Visible = false;
                                            cbl_RearRightWheelTire.Visible = false;
                                            cbl_RightTailLight.Visible = false;
                                            cbl_LeftTailLightdriverside.Visible = false;
                                            cbl_RightMirror.Visible = false;
                                            cbl_RearBumper.Visible = true;
                                            int count = l_RearBumper_removed.Count;
                                            Partname.Text = "Rear Bumper";
                                            // l_frontBumper.Remove(s);
                                            //Session["FrontBumper"]
                                        }
                                    }
                                    Session["RearBumper"] = l_RearBumper_removed;
                                }
                            }
                        }
                    }
                }
            }
        }
        //19.Rear Right Quarter Panel
        protected void gv_RearRightQuarterPanel_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            GridViewRow row = (GridViewRow)(((ImageButton)e.CommandSource).NamingContainer);
            if (e.CommandName == "Delete")
            {
                DataTable dt = (DataTable)ViewState["RearRightQuarterPanel_dt"];

                string idd = e.CommandArgument.ToString();
                int id = row.RowIndex;
                dt.Rows.RemoveAt(id);
                gv_RearRightQuarterPanel.DataSource = dt;
                gv_RearRightQuarterPanel.DataBind();
                if (dt.Rows.Count == 0)
                {
                  //  gv_RearRightQuarterPanelDiv21.Visible = false;
                }
                ViewState["RearRightQuarterPanel_fill_summary"] = dt;
                DataTable dt2 = (DataTable)ViewState["RearRightQuarterPanel_tableCkbind_dt"];

                foreach (DataRow dr in dt2.Rows)
                {
                    if (Convert.ToInt32(dr["REARRIGHTQUARTERPANELID"]) == Convert.ToInt32(idd))
                    {
                        for (int i = 0; i < cbl_RearRightQuarterPanel.Items.Count; i++)
                        {
                            if (Convert.ToInt32(cbl_RearRightQuarterPanel.Items[i].Value) == Convert.ToInt32(dr["REARRIGHTQUARTERPANELID"]))
                            {
                                if (cbl_RearRightQuarterPanel.Items[i].Text.ToString() == Convert.ToString(dr["REARRIGHTQUARTERPANELDATA"]))
                                {
                                    cbl_RearRightQuarterPanel.Items[i].Selected = false;
                                    List<string> l_RearRightQuarterPanel = (List<string>)Session["RearRightQuarterPanel"];
                                    List<string> l_RearRightQuarterPanel_removed = new List<string>();
                                    foreach (string s in l_RearRightQuarterPanel)
                                    {
                                        if (s != cbl_RearRightQuarterPanel.Items[i].Value)
                                        {
                                            l_RearRightQuarterPanel_removed.Add(s);
                                            cbl_FrontBumper.Visible = false;
                                            cbl_Hood.Visible = false;
                                            cbl_Roof.Visible = false;
                                            cbl_FrontLeftFender.Visible = false;
                                            cbl_FrontLeftDoor.Visible = false;
                                            cbl_RearLeftDoor.Visible = false;
                                            cbl_RearLeftQuarterPanel.Visible = false;
                                            cbl_FrontLeftWindow.Visible = false;
                                            cbl_RearLeftWindow.Visible = false;
                                            cbl_FrontWindshield.Visible = false;
                                            cbl_FrontLeftWheelTire.Visible = false;
                                            cbl_RearLeftWheelTire.Visible = false;
                                            cbl_FrontLeftHeadlight.Visible = false;
                                            cbl_FrontRightHeadlight.Visible = false;
                                            cbl_LeftMirror.Visible = false;
                                            cbl_Trunk.Visible = false;
                                            cbl_RearBumper.Visible = false;
                                            cbl_FrontRightFender.Visible = false;
                                            cbl_FrontRightDoor.Visible = false;
                                            cbl_RearRightDoor.Visible = false;
                                            cbl_FrontRightWindow.Visible = false;
                                            cbl_RearRightWindow.Visible = false;
                                            cbl_RearWindshield.Visible = false;
                                            cbl_FrontRightWheelTire.Visible = false;
                                            cbl_RearRightWheelTire.Visible = false;
                                            cbl_RightTailLight.Visible = false;
                                            cbl_LeftTailLightdriverside.Visible = false;
                                            cbl_RightMirror.Visible = false;
                                            cbl_RearRightQuarterPanel.Visible = true;
                                            int count = l_RearRightQuarterPanel_removed.Count;
                                            Partname.Text = "Rear Right Quarter Panel";
                                            // l_frontBumper.Remove(s);
                                            //Session["FrontBumper"]
                                        }
                                    }
                                    Session["RearRightQuarterPanel"] = l_RearRightQuarterPanel_removed;
                                }
                            }
                        }
                    }
                }
            }
        }
        //20.Front Right Fender
        protected void gv_FrontRightFender_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            GridViewRow row = (GridViewRow)(((ImageButton)e.CommandSource).NamingContainer);
            if (e.CommandName == "Delete")
            {
                DataTable dt = (DataTable)ViewState["FrontRightFender_dt"];

                string idd = e.CommandArgument.ToString();
                int id = row.RowIndex;
                dt.Rows.RemoveAt(id);
                gv_FrontRightFender.DataSource = dt;
                gv_FrontRightFender.DataBind();
                if (dt.Rows.Count == 0)
                {
                   // gv_FrontRightFenderDiv22.Visible = false;
                }
                ViewState["FrontRightFender_fill_summary"] = dt;
                DataTable dt2 = (DataTable)ViewState["FrontRightFender_tableCkbind_dt"];

                foreach (DataRow dr in dt2.Rows)
                {
                    if (Convert.ToInt32(dr["FRONTRIGHTFENDERID"]) == Convert.ToInt32(idd))
                    {
                        for (int i = 0; i < cbl_FrontRightFender.Items.Count; i++)
                        {
                            if (Convert.ToInt32(cbl_FrontRightFender.Items[i].Value) == Convert.ToInt32(dr["FRONTRIGHTFENDERID"]))
                            {
                                if (cbl_FrontRightFender.Items[i].Text.ToString() == Convert.ToString(dr["FRONTRIGHTFENDERDATA"]))
                                {
                                    cbl_FrontRightFender.Items[i].Selected = false;
                                    List<string> l_FrontRightFender = (List<string>)Session["FrontRightFender"];
                                    List<string> l_FrontRightFender_removed = new List<string>();
                                    foreach (string s in l_FrontRightFender)
                                    {
                                        if (s != cbl_FrontRightFender.Items[i].Value)
                                        {
                                            l_FrontRightFender_removed.Add(s);
                                            cbl_FrontBumper.Visible = false;
                                            cbl_Hood.Visible = false;
                                            cbl_Roof.Visible = false;
                                            cbl_FrontLeftFender.Visible = false;
                                            cbl_FrontLeftDoor.Visible = false;
                                            cbl_RearLeftDoor.Visible = false;
                                            cbl_RearLeftQuarterPanel.Visible = false;
                                            cbl_FrontLeftWindow.Visible = false;
                                            cbl_RearLeftWindow.Visible = false;
                                            cbl_FrontWindshield.Visible = false;
                                            cbl_FrontLeftWheelTire.Visible = false;
                                            cbl_RearLeftWheelTire.Visible = false;
                                            cbl_FrontLeftHeadlight.Visible = false;
                                            cbl_FrontRightHeadlight.Visible = false;
                                            cbl_LeftMirror.Visible = false;
                                            cbl_Trunk.Visible = false;
                                            cbl_RearBumper.Visible = false;
                                            cbl_RearRightQuarterPanel.Visible = false;
                                            cbl_FrontRightDoor.Visible = false;
                                            cbl_RearRightDoor.Visible = false;
                                            cbl_FrontRightWindow.Visible = false;
                                            cbl_RearRightWindow.Visible = false;
                                            cbl_RearWindshield.Visible = false;
                                            cbl_FrontRightWheelTire.Visible = false;
                                            cbl_RearRightWheelTire.Visible = false;
                                            cbl_RightTailLight.Visible = false;
                                            cbl_LeftTailLightdriverside.Visible = false;
                                            cbl_RightMirror.Visible = false;
                                            cbl_FrontRightFender.Visible = true;
                                            int count = l_FrontRightFender_removed.Count;
                                            Partname.Text = "Front Right Fender";
                                            // l_frontBumper.Remove(s);
                                            //Session["FrontBumper"]
                                        }
                                    }
                                    Session["FrontRightFender"] = l_FrontRightFender_removed;
                                }
                            }
                        }
                    }
                }
            }
        }
        //21.Front Right Door
        protected void gv_FrontRightDoor_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            GridViewRow row = (GridViewRow)(((ImageButton)e.CommandSource).NamingContainer);
            if (e.CommandName == "Delete")
            {
                DataTable dt = (DataTable)ViewState["FrontRightDoor_dt"];

                string idd = e.CommandArgument.ToString();
                int id = row.RowIndex;
                dt.Rows.RemoveAt(id);
                gv_FrontRightDoor.DataSource = dt;
                gv_FrontRightDoor.DataBind();
                if (dt.Rows.Count == 0)
                {
                   // gv_FrontRightDoorDiv23.Visible = false;
                }
                ViewState["FrontRightDoor_fill_summary"] = dt;
                DataTable dt2 = (DataTable)ViewState["FrontRightDoor_tableCkbind_dt"];

                foreach (DataRow dr in dt2.Rows)
                {
                    if (Convert.ToInt32(dr["FRONTRIGHTDOORID"]) == Convert.ToInt32(idd))
                    {
                        for (int i = 0; i < cbl_FrontRightDoor.Items.Count; i++)
                        {
                            if (Convert.ToInt32(cbl_FrontRightDoor.Items[i].Value) == Convert.ToInt32(dr["FRONTRIGHTDOORID"]))
                            {
                                if (cbl_FrontRightDoor.Items[i].Text.ToString() == Convert.ToString(dr["FRONTRIGHTDOORDATA"]))
                                {
                                    cbl_FrontRightDoor.Items[i].Selected = false;
                                    List<string> l_FrontRightDoor = (List<string>)Session["FrontRightDoor"];
                                    List<string> l_FrontRightDoor_removed = new List<string>();
                                    foreach (string s in l_FrontRightDoor)
                                    {
                                        if (s != cbl_FrontRightDoor.Items[i].Value)
                                        {
                                            l_FrontRightDoor_removed.Add(s);
                                            cbl_FrontBumper.Visible = false;
                                            cbl_Hood.Visible = false;
                                            cbl_Roof.Visible = false;
                                            cbl_FrontLeftFender.Visible = false;
                                            cbl_FrontLeftDoor.Visible = false;
                                            cbl_RearLeftDoor.Visible = false;
                                            cbl_RearLeftQuarterPanel.Visible = false;
                                            cbl_FrontLeftWindow.Visible = false;
                                            cbl_RearLeftWindow.Visible = false;
                                            cbl_FrontWindshield.Visible = false;
                                            cbl_FrontLeftWheelTire.Visible = false;
                                            cbl_RearLeftWheelTire.Visible = false;
                                            cbl_FrontLeftHeadlight.Visible = false;
                                            cbl_FrontRightHeadlight.Visible = false;
                                            cbl_LeftMirror.Visible = false;
                                            cbl_Trunk.Visible = false;
                                            cbl_RearBumper.Visible = false;
                                            cbl_RearRightQuarterPanel.Visible = false;
                                            cbl_FrontRightFender.Visible = false;
                                            cbl_RearRightDoor.Visible = false;
                                            cbl_FrontRightWindow.Visible = false;
                                            cbl_RearRightWindow.Visible = false;
                                            cbl_RearWindshield.Visible = false;
                                            cbl_FrontRightWheelTire.Visible = false;
                                            cbl_RearRightWheelTire.Visible = false;
                                            cbl_RightTailLight.Visible = false;
                                            cbl_LeftTailLightdriverside.Visible = false;
                                            cbl_RightMirror.Visible = false;
                                            cbl_FrontRightDoor.Visible = true;
                                            int count = l_FrontRightDoor_removed.Count;
                                            Partname.Text = "Front Right Door";
                                            // l_frontBumper.Remove(s);
                                            //Session["FrontBumper"]
                                        }
                                    }
                                    Session["FrontRightDoor"] = l_FrontRightDoor_removed;
                                }
                            }
                        }
                    }
                }
            }
        }
        //22.Rear Right Door
        protected void gv_RearRightDoor_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            GridViewRow row = (GridViewRow)(((ImageButton)e.CommandSource).NamingContainer);
            if (e.CommandName == "Delete")
            {
                DataTable dt = (DataTable)ViewState["RearRightDoor_dt"];

                string idd = e.CommandArgument.ToString();
                int id = row.RowIndex;
                dt.Rows.RemoveAt(id);
                gv_RearRightDoor.DataSource = dt;
                gv_RearRightDoor.DataBind();
                if (dt.Rows.Count == 0)
                {
                  //  gv_RearRightDoorDiv24.Visible = false;
                }
                ViewState["RearRightDoor_fill_summary"] = dt;
                DataTable dt2 = (DataTable)ViewState["RearRightDoor_tableCkbind_dt"];

                foreach (DataRow dr in dt2.Rows)
                {
                    if (Convert.ToInt32(dr["REARRIGHTDOORID"]) == Convert.ToInt32(idd))
                    {
                        for (int i = 0; i < cbl_RearRightDoor.Items.Count; i++)
                        {
                            if (Convert.ToInt32(cbl_RearRightDoor.Items[i].Value) == Convert.ToInt32(dr["REARRIGHTDOORID"]))
                            {
                                if (cbl_RearRightDoor.Items[i].Text.ToString() == Convert.ToString(dr["REARRIGHTDOORDATA"]))
                                {
                                    cbl_RearRightDoor.Items[i].Selected = false;
                                    List<string> l_RearRightDoor = (List<string>)Session["RearRightDoor"];
                                    List<string> l_RearRightDoor_removed = new List<string>();
                                    foreach (string s in l_RearRightDoor)
                                    {
                                        if (s != cbl_RearRightDoor.Items[i].Value)
                                        {
                                            l_RearRightDoor_removed.Add(s);
                                            cbl_FrontBumper.Visible = false;
                                            cbl_Hood.Visible = false;
                                            cbl_Roof.Visible = false;
                                            cbl_FrontLeftFender.Visible = false;
                                            cbl_FrontLeftDoor.Visible = false;
                                            cbl_RearLeftDoor.Visible = false;
                                            cbl_RearLeftQuarterPanel.Visible = false;
                                            cbl_FrontLeftWindow.Visible = false;
                                            cbl_RearLeftWindow.Visible = false;
                                            cbl_FrontWindshield.Visible = false;
                                            cbl_FrontLeftWheelTire.Visible = false;
                                            cbl_RearLeftWheelTire.Visible = false;
                                            cbl_FrontLeftHeadlight.Visible = false;
                                            cbl_FrontRightHeadlight.Visible = false;
                                            cbl_LeftMirror.Visible = false;
                                            cbl_Trunk.Visible = false;
                                            cbl_RearBumper.Visible = false;
                                            cbl_RearRightQuarterPanel.Visible = false;
                                            cbl_FrontRightFender.Visible = false;
                                            cbl_FrontRightDoor.Visible = false;
                                            cbl_FrontRightWindow.Visible = false;
                                            cbl_RearRightWindow.Visible = false;
                                            cbl_RearWindshield.Visible = false;
                                            cbl_FrontRightWheelTire.Visible = false;
                                            cbl_RearRightWheelTire.Visible = false;
                                            cbl_RightTailLight.Visible = false;
                                            cbl_LeftTailLightdriverside.Visible = false;
                                            cbl_RightMirror.Visible = false;
                                            cbl_RearRightDoor.Visible = true;
                                            int count = l_RearRightDoor_removed.Count;
                                            Partname.Text = "Rear Right Door";
                                            // l_frontBumper.Remove(s);
                                            //Session["FrontBumper"]
                                        }
                                    }
                                    Session["RearRightDoor"] = l_RearRightDoor_removed;
                                }
                            }
                        }
                    }
                }
            }
        }
        //23.Front Right Window
        protected void gv_FrontRightWindow_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            GridViewRow row = (GridViewRow)(((ImageButton)e.CommandSource).NamingContainer);
            if (e.CommandName == "Delete")
            {
                DataTable dt = (DataTable)ViewState["FrontRightWindow_dt"];

                string idd = e.CommandArgument.ToString();
                int id = row.RowIndex;
                dt.Rows.RemoveAt(id);
                gv_FrontRightWindow.DataSource = dt;
                gv_FrontRightWindow.DataBind();
                if (dt.Rows.Count == 0)
                {
                  //  gv_FrontRightWindowDiv25.Visible = false;
                }
                ViewState["FrontRightWindow_fill_summary"] = dt;
                DataTable dt2 = (DataTable)ViewState["FrontRightWindow_tableCkbind_dt"];

                foreach (DataRow dr in dt2.Rows)
                {
                    if (Convert.ToInt32(dr["FRONTRIGHTWINDOWID"]) == Convert.ToInt32(idd))
                    {
                        for (int i = 0; i < cbl_FrontRightWindow.Items.Count; i++)
                        {
                            if (Convert.ToInt32(cbl_FrontRightWindow.Items[i].Value) == Convert.ToInt32(dr["FRONTRIGHTWINDOWID"]))
                            {
                                if (cbl_FrontRightWindow.Items[i].Text.ToString() == Convert.ToString(dr["FRONTRIGHTWINDOWDATA"]))
                                {
                                    cbl_FrontRightWindow.Items[i].Selected = false;
                                    List<string> l_FrontRightWindow = (List<string>)Session["FrontRightWindow"];
                                    List<string> l_FrontRightWindow_removed = new List<string>();
                                    foreach (string s in l_FrontRightWindow)
                                    {
                                        if (s != cbl_FrontRightWindow.Items[i].Value)
                                        {
                                            l_FrontRightWindow_removed.Add(s);
                                            cbl_FrontBumper.Visible = false;
                                            cbl_Hood.Visible = false;
                                            cbl_Roof.Visible = false;
                                            cbl_FrontLeftFender.Visible = false;
                                            cbl_FrontLeftDoor.Visible = false;
                                            cbl_RearLeftDoor.Visible = false;
                                            cbl_RearLeftQuarterPanel.Visible = false;
                                            cbl_FrontLeftWindow.Visible = false;
                                            cbl_RearLeftWindow.Visible = false;
                                            cbl_FrontWindshield.Visible = false;
                                            cbl_FrontLeftWheelTire.Visible = false;
                                            cbl_RearLeftWheelTire.Visible = false;
                                            cbl_FrontLeftHeadlight.Visible = false;
                                            cbl_FrontRightHeadlight.Visible = false;
                                            cbl_LeftMirror.Visible = false;
                                            cbl_Trunk.Visible = false;
                                            cbl_RearBumper.Visible = false;
                                            cbl_RearRightQuarterPanel.Visible = false;
                                            cbl_FrontRightFender.Visible = false;
                                            cbl_FrontRightDoor.Visible = false;
                                            cbl_RearRightDoor.Visible = false;
                                            cbl_RearRightWindow.Visible = false;
                                            cbl_RearWindshield.Visible = false;
                                            cbl_FrontRightWheelTire.Visible = false;
                                            cbl_RearRightWheelTire.Visible = false;
                                            cbl_RightTailLight.Visible = false;
                                            cbl_LeftTailLightdriverside.Visible = false;
                                            cbl_RightMirror.Visible = false;
                                            cbl_FrontRightWindow.Visible = true;
                                            int count = l_FrontRightWindow_removed.Count;
                                            Partname.Text = "Front Right Window";
                                            // l_frontBumper.Remove(s);
                                            //Session["FrontBumper"]
                                        }
                                    }
                                    Session["FrontRightWindow"] = l_FrontRightWindow_removed;
                                }
                            }
                        }
                    }
                }
            }
        }
        //24.Rear Right Window
        protected void gv_RearRightWindow_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            GridViewRow row = (GridViewRow)(((ImageButton)e.CommandSource).NamingContainer);
            if (e.CommandName == "Delete")
            {
                DataTable dt = (DataTable)ViewState["RearRightWindow_dt"];

                string idd = e.CommandArgument.ToString();
                int id = row.RowIndex;
                dt.Rows.RemoveAt(id);
                gv_RearRightWindow.DataSource = dt;
                gv_RearRightWindow.DataBind();
                if (dt.Rows.Count == 0)
                {
                   // gv_RearRightWindowDiv26.Visible = false;
                }

                ViewState["RearRightWindow_fill_summary"] = dt;
                DataTable dt2 = (DataTable)ViewState["RearRightWindow_tableCkbind_dt"];

                foreach (DataRow dr in dt2.Rows)
                {
                    if (Convert.ToInt32(dr["REARRIGHTWINDOWID"]) == Convert.ToInt32(idd))
                    {
                        for (int i = 0; i < cbl_RearRightWindow.Items.Count; i++)
                        {
                            if (Convert.ToInt32(cbl_RearRightWindow.Items[i].Value) == Convert.ToInt32(dr["REARRIGHTWINDOWID"]))
                            {
                                if (cbl_RearRightWindow.Items[i].Text.ToString() == Convert.ToString(dr["REARRIGHTWINDOWDATA"]))
                                {
                                    cbl_RearRightWindow.Items[i].Selected = false;
                                    List<string> l_RearRightWindow = (List<string>)Session["RearRightWindow"];
                                    List<string> l_RearRightWindow_removed = new List<string>();
                                    foreach (string s in l_RearRightWindow)
                                    {
                                        if (s != cbl_RearRightWindow.Items[i].Value)
                                        {
                                            l_RearRightWindow_removed.Add(s);
                                            cbl_FrontBumper.Visible = false;
                                            cbl_Hood.Visible = false;
                                            cbl_Roof.Visible = false;
                                            cbl_FrontLeftFender.Visible = false;
                                            cbl_FrontLeftDoor.Visible = false;
                                            cbl_RearLeftDoor.Visible = false;
                                            cbl_RearLeftQuarterPanel.Visible = false;
                                            cbl_FrontLeftWindow.Visible = false;
                                            cbl_RearLeftWindow.Visible = false;
                                            cbl_FrontWindshield.Visible = false;
                                            cbl_FrontLeftWheelTire.Visible = false;
                                            cbl_RearLeftWheelTire.Visible = false;
                                            cbl_FrontLeftHeadlight.Visible = false;
                                            cbl_FrontRightHeadlight.Visible = false;
                                            cbl_LeftMirror.Visible = false;
                                            cbl_Trunk.Visible = false;
                                            cbl_RearBumper.Visible = false;
                                            cbl_RearRightQuarterPanel.Visible = false;
                                            cbl_FrontRightFender.Visible = false;
                                            cbl_FrontRightDoor.Visible = false;
                                            cbl_RearRightDoor.Visible = false;
                                            cbl_FrontRightWindow.Visible = false;
                                            cbl_RearWindshield.Visible = false;
                                            cbl_FrontRightWheelTire.Visible = false;
                                            cbl_RearRightWheelTire.Visible = false;
                                            cbl_RightTailLight.Visible = false;
                                            cbl_LeftTailLightdriverside.Visible = false;
                                            cbl_RightMirror.Visible = false;
                                            cbl_RearRightWindow.Visible = true;
                                            int count = l_RearRightWindow_removed.Count;
                                            Partname.Text = "Rear Right Window";
                                            // l_frontBumper.Remove(s);
                                            //Session["FrontBumper"]
                                        }
                                    }
                                    Session["RearRightWindow"] = l_RearRightWindow_removed;
                                }
                            }
                        }
                    }
                }
            }
        }
        //25.Rear Windshield
        protected void gv_RearWindshield_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            GridViewRow row = (GridViewRow)(((ImageButton)e.CommandSource).NamingContainer);
            if (e.CommandName == "Delete")
            {
                DataTable dt = (DataTable)ViewState["RearWindshield_dt"];

                string idd = e.CommandArgument.ToString();
                int id = row.RowIndex;
                dt.Rows.RemoveAt(id);
                gv_RearWindshield.DataSource = dt;
                gv_RearWindshield.DataBind();
                if (dt.Rows.Count == 0)
                {
                   // gv_RearWindshieldDiv27.Visible = false;
                }
                ViewState["RearWindshield_fill_summary"] = dt;
                DataTable dt2 = (DataTable)ViewState["RearWindshield_tableCkbind_dt"];

                foreach (DataRow dr in dt2.Rows)
                {
                    if (Convert.ToInt32(dr["REARWINDSHIELDID"]) == Convert.ToInt32(idd))
                    {
                        for (int i = 0; i < cbl_RearWindshield.Items.Count; i++)
                        {
                            if (Convert.ToInt32(cbl_RearWindshield.Items[i].Value) == Convert.ToInt32(dr["REARWINDSHIELDID"]))
                            {
                                if (cbl_RearWindshield.Items[i].Text.ToString() == Convert.ToString(dr["REARWINDSHIELDDATA"]))
                                {
                                    cbl_RearWindshield.Items[i].Selected = false;
                                    List<string> l_RearWindshield = (List<string>)Session["RearWindshield"];
                                    List<string> l_RearWindshield_removed = new List<string>();
                                    foreach (string s in l_RearWindshield)
                                    {
                                        if (s != cbl_RearWindshield.Items[i].Value)
                                        {
                                            l_RearWindshield_removed.Add(s);
                                            cbl_FrontBumper.Visible = false;
                                            cbl_Hood.Visible = false;
                                            cbl_Roof.Visible = false;
                                            cbl_FrontLeftFender.Visible = false;
                                            cbl_FrontLeftDoor.Visible = false;
                                            cbl_RearLeftDoor.Visible = false;
                                            cbl_RearLeftQuarterPanel.Visible = false;
                                            cbl_FrontLeftWindow.Visible = false;
                                            cbl_RearLeftWindow.Visible = false;
                                            cbl_FrontWindshield.Visible = false;
                                            cbl_FrontLeftWheelTire.Visible = false;
                                            cbl_RearLeftWheelTire.Visible = false;
                                            cbl_FrontLeftHeadlight.Visible = false;
                                            cbl_FrontRightHeadlight.Visible = false;
                                            cbl_LeftMirror.Visible = false;
                                            cbl_Trunk.Visible = false;
                                            cbl_RearBumper.Visible = false;
                                            cbl_RearRightQuarterPanel.Visible = false;
                                            cbl_FrontRightFender.Visible = false;
                                            cbl_FrontRightDoor.Visible = false;
                                            cbl_RearRightDoor.Visible = false;
                                            cbl_FrontRightWindow.Visible = false;
                                            cbl_RearRightWindow.Visible = false;
                                            cbl_FrontRightWheelTire.Visible = false;
                                            cbl_RearRightWheelTire.Visible = false;
                                            cbl_RightTailLight.Visible = false;
                                            cbl_LeftTailLightdriverside.Visible = false;
                                            cbl_RightMirror.Visible = false;
                                            cbl_RearWindshield.Visible = true;
                                            int count = l_RearWindshield_removed.Count;
                                            Partname.Text = "Rear Windshield";
                                            // l_frontBumper.Remove(s);
                                            //Session["FrontBumper"]
                                        }
                                    }
                                    Session["RearWindshield"] = l_RearWindshield_removed;
                                }
                            }
                        }
                    }
                }
            }
        }
        //26.Front Right Wheel & Tire
        protected void gv_FrontRightWheelTire_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            GridViewRow row = (GridViewRow)(((ImageButton)e.CommandSource).NamingContainer);
            if (e.CommandName == "Delete")
            {
                DataTable dt = (DataTable)ViewState["FrontRightWheelTire_dt"];

                string idd = e.CommandArgument.ToString();
                int id = row.RowIndex;
                dt.Rows.RemoveAt(id);
                gv_FrontRightWheelTire.DataSource = dt;
                gv_FrontRightWheelTire.DataBind();
                if (dt.Rows.Count == 0)
                {
                  //  gv_FrontRightWheelTireDiv28.Visible = false;
                }
                ViewState["FrontRightWheelTire_fill_summary"] = dt;
                DataTable dt2 = (DataTable)ViewState["FrontRightWheelTire_tableCkbind_dt"];

                foreach (DataRow dr in dt2.Rows)
                {
                    if (Convert.ToInt32(dr["FRONTRIGHTWHEELTIREID"]) == Convert.ToInt32(idd))
                    {
                        for (int i = 0; i < cbl_FrontRightWheelTire.Items.Count; i++)
                        {
                            if (Convert.ToInt32(cbl_FrontRightWheelTire.Items[i].Value) == Convert.ToInt32(dr["FRONTRIGHTWHEELTIREID"]))
                            {
                                if (cbl_FrontRightWheelTire.Items[i].Text.ToString() == Convert.ToString(dr["FRONTRIGHTWHEELTIREDATA"]))
                                {
                                    cbl_FrontRightWheelTire.Items[i].Selected = false;
                                    List<string> l_FrontRightWheelTire = (List<string>)Session["FrontRightWheelTire"];
                                    List<string> l_FrontRightWheelTire_removed = new List<string>();
                                    foreach (string s in l_FrontRightWheelTire)
                                    {
                                        if (s != cbl_FrontRightWheelTire.Items[i].Value)
                                        {
                                            l_FrontRightWheelTire_removed.Add(s);
                                            cbl_FrontBumper.Visible = false;
                                            cbl_Hood.Visible = false;
                                            cbl_Roof.Visible = false;
                                            cbl_FrontLeftFender.Visible = false;
                                            cbl_FrontLeftDoor.Visible = false;
                                            cbl_RearLeftDoor.Visible = false;
                                            cbl_RearLeftQuarterPanel.Visible = false;
                                            cbl_FrontLeftWindow.Visible = false;
                                            cbl_RearLeftWindow.Visible = false;
                                            cbl_FrontWindshield.Visible = false;
                                            cbl_FrontLeftWheelTire.Visible = false;
                                            cbl_RearLeftWheelTire.Visible = false;
                                            cbl_FrontLeftHeadlight.Visible = false;
                                            cbl_FrontRightHeadlight.Visible = false;
                                            cbl_LeftMirror.Visible = false;
                                            cbl_Trunk.Visible = false;
                                            cbl_RearBumper.Visible = false;
                                            cbl_RearRightQuarterPanel.Visible = false;
                                            cbl_FrontRightFender.Visible = false;
                                            cbl_FrontRightDoor.Visible = false;
                                            cbl_RearRightDoor.Visible = false;
                                            cbl_FrontRightWindow.Visible = false;
                                            cbl_RearRightWindow.Visible = false;
                                            cbl_RearWindshield.Visible = false;
                                            cbl_RearRightWheelTire.Visible = false;
                                            cbl_RightTailLight.Visible = false;
                                            cbl_LeftTailLightdriverside.Visible = false;
                                            cbl_RightMirror.Visible = false;
                                            cbl_FrontRightWheelTire.Visible = true;
                                            int count = l_FrontRightWheelTire_removed.Count;
                                            Partname.Text = "Front Right Wheel & Tire";
                                            // l_frontBumper.Remove(s);
                                            //Session["FrontBumper"]
                                        }
                                    }
                                    Session["FrontRightWheelTire"] = l_FrontRightWheelTire_removed;
                                }
                            }
                        }
                    }
                }
            }
        }
        //27.Rear Right Wheel & Tire
        protected void gv_RearRightWheelTire_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            GridViewRow row = (GridViewRow)(((ImageButton)e.CommandSource).NamingContainer);
            if (e.CommandName == "Delete")
            {
                DataTable dt = (DataTable)ViewState["RearRightWheelTire_dt"];

                string idd = e.CommandArgument.ToString();
                int id = row.RowIndex;
                dt.Rows.RemoveAt(id);
                gv_RearRightWheelTire.DataSource = dt;
                gv_RearRightWheelTire.DataBind();
                if (dt.Rows.Count == 0)
                {
                  //  gv_RearRightWheelTireDiv29.Visible = false;
                }
                ViewState["RearRightWheelTire_fill_summary"] = dt;
                DataTable dt2 = (DataTable)ViewState["RearRightWheelTire_tableCkbind_dt"];

                foreach (DataRow dr in dt2.Rows)
                {
                    if (Convert.ToInt32(dr["REARRIGHTWHEELTIREID"]) == Convert.ToInt32(idd))
                    {
                        for (int i = 0; i < cbl_RearRightWheelTire.Items.Count; i++)
                        {
                            if (Convert.ToInt32(cbl_RearRightWheelTire.Items[i].Value) == Convert.ToInt32(dr["REARRIGHTWHEELTIREID"]))
                            {
                                if (cbl_RearRightWheelTire.Items[i].Text.ToString() == Convert.ToString(dr["REARRIGHTWHEELTIREDATA"]))
                                {
                                    cbl_RearRightWheelTire.Items[i].Selected = false;
                                    List<string> l_RearRightWheelTire = (List<string>)Session["RearRightWheelTire"];
                                    List<string> l_RearRightWheelTire_removed = new List<string>();
                                    foreach (string s in l_RearRightWheelTire)
                                    {
                                        if (s != cbl_RearRightWheelTire.Items[i].Value)
                                        {
                                            l_RearRightWheelTire_removed.Add(s);
                                            cbl_FrontBumper.Visible = false;
                                            cbl_Hood.Visible = false;
                                            cbl_Roof.Visible = false;
                                            cbl_FrontLeftFender.Visible = false;
                                            cbl_FrontLeftDoor.Visible = false;
                                            cbl_RearLeftDoor.Visible = false;
                                            cbl_RearLeftQuarterPanel.Visible = false;
                                            cbl_FrontLeftWindow.Visible = false;
                                            cbl_RearLeftWindow.Visible = false;
                                            cbl_FrontWindshield.Visible = false;
                                            cbl_FrontLeftWheelTire.Visible = false;
                                            cbl_RearLeftWheelTire.Visible = false;
                                            cbl_FrontLeftHeadlight.Visible = false;
                                            cbl_FrontRightHeadlight.Visible = false;
                                            cbl_LeftMirror.Visible = false;
                                            cbl_Trunk.Visible = false;
                                            cbl_RearBumper.Visible = false;
                                            cbl_RearRightQuarterPanel.Visible = false;
                                            cbl_FrontRightFender.Visible = false;
                                            cbl_FrontRightDoor.Visible = false;
                                            cbl_RearRightDoor.Visible = false;
                                            cbl_FrontRightWindow.Visible = false;
                                            cbl_RearRightWindow.Visible = false;
                                            cbl_RearWindshield.Visible = false;
                                            cbl_FrontRightWheelTire.Visible = false;
                                            cbl_RightTailLight.Visible = false;
                                            cbl_LeftTailLightdriverside.Visible = false;
                                            cbl_RightMirror.Visible = false;
                                            cbl_RearRightWheelTire.Visible = true;
                                            int count = l_RearRightWheelTire_removed.Count;
                                            Partname.Text = "Rear Right Wheel & Tire";
                                            // l_frontBumper.Remove(s);
                                            //Session["FrontBumper"]
                                        }
                                    }
                                    Session["RearRightWheelTire"] = l_RearRightWheelTire_removed;
                                }
                            }
                        }
                    }
                }
            }
        }
        //28.Right Tail Light
        protected void gv_RightTailLight_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            GridViewRow row = (GridViewRow)(((ImageButton)e.CommandSource).NamingContainer);
            if (e.CommandName == "Delete")
            {
                DataTable dt = (DataTable)ViewState["RightTailLight_dt"];

                string idd = e.CommandArgument.ToString();
                int id = row.RowIndex;
                dt.Rows.RemoveAt(id);
                gv_RightTailLight.DataSource = dt;
                gv_RightTailLight.DataBind();
                if (dt.Rows.Count == 0)
                {
                  //  gv_RightTailLightDiv30.Visible = false;
                }
                ViewState["RightTailLight_fill_summary"] = dt;
                DataTable dt2 = (DataTable)ViewState["RightTailLight_tableCkbind_dt"];

                foreach (DataRow dr in dt2.Rows)
                {
                    if (Convert.ToInt32(dr["RIGHTTAILLIGHTID"]) == Convert.ToInt32(idd))
                    {
                        for (int i = 0; i < cbl_RightTailLight.Items.Count; i++)
                        {
                            if (Convert.ToInt32(cbl_RightTailLight.Items[i].Value) == Convert.ToInt32(dr["RIGHTTAILLIGHTID"]))
                            {
                                if (cbl_RightTailLight.Items[i].Text.ToString() == Convert.ToString(dr["RIGHTTAILLIGHTDATA"]))
                                {
                                    cbl_RightTailLight.Items[i].Selected = false;
                                    List<string> l_RightTailLight = (List<string>)Session["RightTailLight"];
                                    List<string> l_RightTailLight_removed = new List<string>();
                                    foreach (string s in l_RightTailLight)
                                    {
                                        if (s != cbl_RightTailLight.Items[i].Value)
                                        {
                                            l_RightTailLight_removed.Add(s);
                                            cbl_FrontBumper.Visible = false;
                                            cbl_Hood.Visible = false;
                                            cbl_Roof.Visible = false;
                                            cbl_FrontLeftFender.Visible = false;
                                            cbl_FrontLeftDoor.Visible = false;
                                            cbl_RearLeftDoor.Visible = false;
                                            cbl_RearLeftQuarterPanel.Visible = false;
                                            cbl_FrontLeftWindow.Visible = false;
                                            cbl_RearLeftWindow.Visible = false;
                                            cbl_FrontWindshield.Visible = false;
                                            cbl_FrontLeftWheelTire.Visible = false;
                                            cbl_RearLeftWheelTire.Visible = false;
                                            cbl_FrontLeftHeadlight.Visible = false;
                                            cbl_FrontRightHeadlight.Visible = false;
                                            cbl_LeftMirror.Visible = false;
                                            cbl_Trunk.Visible = false;
                                            cbl_RearBumper.Visible = false;
                                            cbl_RearRightQuarterPanel.Visible = false;
                                            cbl_FrontRightFender.Visible = false;
                                            cbl_FrontRightDoor.Visible = false;
                                            cbl_RearRightDoor.Visible = false;
                                            cbl_FrontRightWindow.Visible = false;
                                            cbl_RearRightWindow.Visible = false;
                                            cbl_RearWindshield.Visible = false;
                                            cbl_FrontRightWheelTire.Visible = false;
                                            cbl_RearRightWheelTire.Visible = false;
                                            cbl_LeftTailLightdriverside.Visible = false;
                                            cbl_RightMirror.Visible = false;
                                            cbl_RightTailLight.Visible = true;
                                            int count = l_RightTailLight_removed.Count;
                                            Partname.Text = "Right Tail Light";
                                            // l_frontBumper.Remove(s);
                                            //Session["FrontBumper"]
                                        }
                                    }
                                    Session["RightTailLight"] = l_RightTailLight_removed;
                                }
                            }
                        }
                    }
                }
            }
        }
        //29.Left Tail Light(driver side)
        protected void gv_LeftTailLightdriverside_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            GridViewRow row = (GridViewRow)(((ImageButton)e.CommandSource).NamingContainer);
            if (e.CommandName == "Delete")
            {
                DataTable dt = (DataTable)ViewState["LeftTailLightdriverside_dt"];

                string idd = e.CommandArgument.ToString();
                int id = row.RowIndex;
                dt.Rows.RemoveAt(id);
                gv_LeftTailLightdriverside.DataSource = dt;
                gv_LeftTailLightdriverside.DataBind();
                if (dt.Rows.Count == 0)
                {
                  //  gv_LeftTailLightdriversideDiv31.Visible = false;
                }
                ViewState["LeftTailLightdriverside_fill_summary"] = dt;
                DataTable dt2 = (DataTable)ViewState["LeftTailLightdriverside_tableCkbind_dt"];

                foreach (DataRow dr in dt2.Rows)
                {
                    if (Convert.ToInt32(dr["LEFTTAILLIGHTDRIVERSIDEID"]) == Convert.ToInt32(idd))
                    {
                        for (int i = 0; i < cbl_LeftTailLightdriverside.Items.Count; i++)
                        {
                            if (Convert.ToInt32(cbl_LeftTailLightdriverside.Items[i].Value) == Convert.ToInt32(dr["LEFTTAILLIGHTDRIVERSIDEID"]))
                            {
                                if (cbl_LeftTailLightdriverside.Items[i].Text.ToString() == Convert.ToString(dr["LEFTTAILLIGHTDRIVERSIDEDATA"]))
                                {
                                    cbl_LeftTailLightdriverside.Items[i].Selected = false;
                                    List<string> l_LeftTailLightdriverside = (List<string>)Session["LeftTailLightdriverside"];
                                    List<string> l_LeftTailLightdriverside_removed = new List<string>();
                                    foreach (string s in l_LeftTailLightdriverside)
                                    {
                                        if (s != cbl_LeftTailLightdriverside.Items[i].Value)
                                        {
                                            l_LeftTailLightdriverside_removed.Add(s);
                                            cbl_FrontBumper.Visible = false;
                                            cbl_Hood.Visible = false;
                                            cbl_Roof.Visible = false;
                                            cbl_FrontLeftFender.Visible = false;
                                            cbl_FrontLeftDoor.Visible = false;
                                            cbl_RearLeftDoor.Visible = false;
                                            cbl_RearLeftQuarterPanel.Visible = false;
                                            cbl_FrontLeftWindow.Visible = false;
                                            cbl_RearLeftWindow.Visible = false;
                                            cbl_FrontWindshield.Visible = false;
                                            cbl_FrontLeftWheelTire.Visible = false;
                                            cbl_RearLeftWheelTire.Visible = false;
                                            cbl_FrontLeftHeadlight.Visible = false;
                                            cbl_FrontRightHeadlight.Visible = false;
                                            cbl_LeftMirror.Visible = false;
                                            cbl_Trunk.Visible = false;
                                            cbl_RearBumper.Visible = false;
                                            cbl_RearRightQuarterPanel.Visible = false;
                                            cbl_FrontRightFender.Visible = false;
                                            cbl_FrontRightDoor.Visible = false;
                                            cbl_RearRightDoor.Visible = false;
                                            cbl_FrontRightWindow.Visible = false;
                                            cbl_RearRightWindow.Visible = false;
                                            cbl_RearWindshield.Visible = false;
                                            cbl_FrontRightWheelTire.Visible = false;
                                            cbl_RearRightWheelTire.Visible = false;
                                            cbl_RightTailLight.Visible = false;
                                            cbl_RightMirror.Visible = false;
                                            cbl_LeftTailLightdriverside.Visible = true;

                                            int count = l_LeftTailLightdriverside_removed.Count;
                                            Partname.Text = "Left Tail Light(driver side)";
                                            // l_frontBumper.Remove(s);
                                            //Session["FrontBumper"]
                                        }
                                    }
                                    Session["LeftTailLightdriverside"] = l_LeftTailLightdriverside_removed;
                                }
                            }
                        }
                    }
                }
            }
        }
        //30.Right Mirror
        protected void gv_RightMirror_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            GridViewRow row = (GridViewRow)(((ImageButton)e.CommandSource).NamingContainer);
            if (e.CommandName == "Delete")
            {
                DataTable dt = (DataTable)ViewState["RightMirror_dt"];

                string idd = e.CommandArgument.ToString();
                int id = row.RowIndex;
                dt.Rows.RemoveAt(id);
                gv_RightMirror.DataSource = dt;
                gv_RightMirror.DataBind();
                if (dt.Rows.Count == 0)
                {
                  //  gv_RightMirrorDiv32.Visible = false;
                }
                ViewState["RightMirror_fill_summary"] = dt;
                DataTable dt2 = (DataTable)ViewState["RightMirror_tableCkbind_dt"];

                foreach (DataRow dr in dt2.Rows)
                {
                    if (Convert.ToInt32(dr["RIGHTMIRRORID"]) == Convert.ToInt32(idd))
                    {
                        for (int i = 0; i < cbl_RightMirror.Items.Count; i++)
                        {
                            if (Convert.ToInt32(cbl_RightMirror.Items[i].Value) == Convert.ToInt32(dr["RIGHTMIRRORID"]))
                            {
                                if (cbl_RightMirror.Items[i].Text.ToString() == Convert.ToString(dr["RIGHTMIRRORDATA"]))
                                {
                                    cbl_RightMirror.Items[i].Selected = false;
                                    List<string> l_RightMirror = (List<string>)Session["RightMirror"];
                                    List<string> l_RightMirror_removed = new List<string>();
                                    foreach (string s in l_RightMirror)
                                    {
                                        if (s != cbl_RightMirror.Items[i].Value)
                                        {
                                            l_RightMirror_removed.Add(s);
                                            cbl_FrontBumper.Visible = false;
                                            cbl_Hood.Visible = false;
                                            cbl_Roof.Visible = false;
                                            cbl_FrontLeftFender.Visible = false;
                                            cbl_FrontLeftDoor.Visible = false;
                                            cbl_RearLeftDoor.Visible = false;
                                            cbl_RearLeftQuarterPanel.Visible = false;
                                            cbl_FrontLeftWindow.Visible = false;
                                            cbl_RearLeftWindow.Visible = false;
                                            cbl_FrontWindshield.Visible = false;
                                            cbl_FrontLeftWheelTire.Visible = false;
                                            cbl_RearLeftWheelTire.Visible = false;
                                            cbl_FrontLeftHeadlight.Visible = false;
                                            cbl_FrontRightHeadlight.Visible = false;
                                            cbl_LeftMirror.Visible = false;
                                            cbl_Trunk.Visible = false;
                                            cbl_RearBumper.Visible = false;
                                            cbl_RearRightQuarterPanel.Visible = false;
                                            cbl_FrontRightFender.Visible = false;
                                            cbl_FrontRightDoor.Visible = false;
                                            cbl_RearRightDoor.Visible = false;
                                            cbl_FrontRightWindow.Visible = false;
                                            cbl_RearRightWindow.Visible = false;
                                            cbl_RearWindshield.Visible = false;
                                            cbl_FrontRightWheelTire.Visible = false;
                                            cbl_RearRightWheelTire.Visible = false;
                                            cbl_RightTailLight.Visible = false;
                                            cbl_LeftTailLightdriverside.Visible = false;
                                            cbl_RightMirror.Visible = true;
                                            int count = l_RightMirror_removed.Count;
                                            Partname.Text = "Right Mirror";
                                            // l_frontBumper.Remove(s);
                                            //Session["FrontBumper"]
                                        }
                                    }
                                    Session["RightMirror"] = l_RightMirror_removed;
                                }
                            }
                        }
                    }
                }
            }
        }

        //RowDeleting Events

        protected void gv_FrontBumper_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
        protected void gv_Hood_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
        protected void gv_Roof_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
        protected void gv_FrontLeftFender_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
        protected void gv_FrontLeftDoor_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
        protected void gv_RearLeftDoor_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
        protected void gv_RearLeftQuarterPanel_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
        protected void gv_FrontLeftWindow_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
        protected void gv_RearLeftWindow_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
        protected void gv_FrontWindshield_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
        protected void gv_FrontLeftWheelTire_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
        protected void gv_RearLeftWheelTire_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
        protected void gv_FrontLeftHeadlight_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
        protected void gv_FrontRightHeadlight_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
        protected void gv_LeftMirror_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
        protected void gv_Trunk_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
        protected void gv_RearBumper_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
        protected void gv_RearRightQuarterPanel_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
        protected void gv_FrontRightFender_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
        protected void gv_FrontRightDoor_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
        protected void gv_RearRightDoor_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
        protected void gv_FrontRightWindow_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
        protected void gv_RearRightWindow_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
        protected void gv_RearWindshield_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
        protected void gv_FrontRightWheelTire_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
        protected void gv_RearRightWheelTire_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
        protected void gv_RightTailLight_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
        protected void gv_LeftTailLightdriverside_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
        protected void gv_RightMirror_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
        protected void Vehicle_Condition_Details_EditBtn_Click(object sender, ImageClickEventArgs e)
        {

            MultiView1.ActiveViewIndex = 4;
            Vehicle_condition_detail_nextbtn.Visible = false;
            Vehicle_condition_detail_Backbtn.Visible = false;
            Vehicle_condition_details_updateBtn.Visible = true;
        }


        protected void submit_btn_Click(object sender, ImageClickEventArgs e)
        {

            VehicleSpecifications vs = (VehicleSpecifications)Session["webinfo"];
            VehicleOwnerInformation voi = (VehicleOwnerInformation)Session["Vehicle_Owner_Info"];
            Vin_valueFil_lb.Text = vs.Vin;
            // Session["VIN_id"] = vs.Vin;
            string vin_number = vs.Vin;

            int vin_id = Convert.ToInt32(Session["id_vin"]);
            // int vin_id = pm.insertvinnumber(vin_number);

            //insertion of vehicle specification into database

            pm.insertvincardetails(vs, vin_id);



            //inserting vehicle owner details

            pm.insertvehicleownerinformation(voi, vin_id);


            //Vehicle Details
            VehicleDetails vd = (VehicleDetails)Session["Vehile_detials_fill"];

            //insert Vehicle Details
            pm.insertvehicledetails(vd, vin_id);

            // insertion of radio btns to db
            vcd.InteriorConditionData = Interior_COndition_RadiobtnLst.SelectedItem.Text.ToString();

            vcd.MechanicalConditionData = Mechanical_COndition_radiobtn.SelectedItem.Text.ToString();
            pm.insertinteriorconditiondetails(vcd, vin_id);
            pm.insertmechanicalconditiondetails(vcd, vin_id);

            // insertion of Vehicle options and features
            callSp_InsertDT();

            //insertion of image uploaded to DB
            InsertImagesDT();

            //insertion of image map data to DB

            DBInsertFrontbumper();
            DBInsertHood();
            DBInsertRoof();
            DBInsertFrontLeftFender();
            DBInsertFrontLeftDoor();
            DBInsertRearLeftDoor();
            DBInsertRearLeftQuarterPanel();
            DBInsertFrontLeftWindowFrontLeftWindow();
            DBInsertRearLeftWindow();
            DBInsertFrontWindshield();
            DBInsertFrontLeftWheelTire();
            DBInsertRearLeftWheelTire();
            DBInsertFrontLeftHeadlight();
            DBInsertFrontRightHeadlight();
            DBInsertLeftMirror();
            DBInsertTrunk();
            DBInsertRearBumper();
            DBInsertRearRightQuarterPanel();
            DBInsertFrontRightFender();
            DBInsertFrontRightDoor();
            DBInsertRearRightDoor();
            DBInsertFrontRightWindow();
            DBInsertRearRightWindow();
            DBInsertRearWindshield();
            DBInsertFrontRightWheelTire();
            DBInsertRearRightWheelTire();
            DBInsertRightTailLight();
            DBInsertLeftTailLightdriverside();
            DBInsertRightMirror();




        }


        // inserting dt (vehicle options and features) into DB using xml
        public void callSp_InsertDT()
        {
            DataTable dt = (DataTable)Session["summary_dt_fill_chkbox"];
            if (dt != null)
            {
                dt.TableName = "TableXML";
                DataSet ds = new DataSet();
                ds.Tables.Add(dt.Copy());
                string childdata = ds.GetXml();
                pm.insertVehicleoptfeatures(childdata);
            }
            else
            {
                int vinid = Convert.ToInt32(Session["id_vin"]);
                pm.DeleteVehicleoptFeaturesByVInid(vinid);
            }
        }

        //inserting dt (ImageMap) into DB using xml
        //1.Front Bumper
        public void DBInsertFrontbumper()
        {
            DataTable dt = (DataTable)ViewState["FrontBumper_fill_summary"];
            if (dt != null)
            {
                dt.TableName = "TableXML";
                DataSet ds = new DataSet();
                ds.Tables.Add(dt.Copy());
                string childdata = ds.GetXml();
                pm.InsertFrontBumperDT(childdata);
           }
            else
            {
               int vinid = Convert.ToInt32(Session["id_vin"]);
               pm.Delete_FrontBumperdata(vinid);

            }
        }
        //2.Hood
        public void DBInsertHood()
        {
            DataTable dt = (DataTable)ViewState["Hood_fill_summary"];
            if (dt != null)
            {
                dt.TableName = "TableXML";
                DataSet ds = new DataSet();
                ds.Tables.Add(dt.Copy());
                string childdata = ds.GetXml();
                pm.InsertHoodDT(childdata);
            }
            else
            {
                int vinid = Convert.ToInt32(Session["id_vin"]);
                pm.Delete_HOODdata(vinid);
                 
            }
        }
        //3.Roof
        public void DBInsertRoof()
        {
            DataTable dt = (DataTable)ViewState["Roof_fill_summary"];
            if (dt != null)
            {
                dt.TableName = "TableXML";
                DataSet ds = new DataSet();
                ds.Tables.Add(dt.Copy());
                string childdata = ds.GetXml();
                pm.InsertRoofDT(childdata);
            }
            else
            {
                int vinid = Convert.ToInt32(Session["id_vin"]);
                pm.Delete_ROOFdata(vinid);
            }
        }
        //4.Front Left Fender
        public void DBInsertFrontLeftFender()
        {
            DataTable dt = (DataTable)ViewState["FrontLeftFender_fill_summary"];
            if (dt != null)
            {
                dt.TableName = "TableXML";
                DataSet ds = new DataSet();
                ds.Tables.Add(dt.Copy());
                string childdata = ds.GetXml();
                pm.InsertFrontLeftFenderDT(childdata);
            }
            else
            {
                int vinid = Convert.ToInt32(Session["id_vin"]);
                pm.Delete_FRONTLEFTFENDERdata(vinid);

            }
        }
        //5.Front Left Door
        public void DBInsertFrontLeftDoor()
        {
            DataTable dt = (DataTable)ViewState["FrontLeftDoor_Fill_summary"];
            if (dt != null)
            {
                dt.TableName = "TableXML";
                DataSet ds = new DataSet();
                ds.Tables.Add(dt.Copy());
                string childdata = ds.GetXml();
                pm.InsertFrontLeftDoorDT(childdata);
            }
            else
            {
                int vinid = Convert.ToInt32(Session["id_vin"]);
                pm.Delete_FrontLeftDoordata(vinid);

            }
        }
        //6.Rear Left Door
        public void DBInsertRearLeftDoor()
        {
            DataTable dt = (DataTable)ViewState["RearLeftDoor_fill_summary"];
            if (dt != null)
            {
                dt.TableName = "TableXML";
                DataSet ds = new DataSet();
                ds.Tables.Add(dt.Copy());
                string childdata = ds.GetXml();
                pm.InsertRearLeftDoorDT(childdata);
            }
            else
            {
                int vinid = Convert.ToInt32(Session["id_vin"]);
                pm.Delete_REARLEFTDOORdata(vinid);

            }
        }
        //7.Rear Left Quarter Panel
        public void DBInsertRearLeftQuarterPanel()
        {
            DataTable dt = (DataTable)ViewState["RearLeftQuarterPanel_fill_summary"];
            if (dt != null)
            {
                dt.TableName = "TableXML";
                DataSet ds = new DataSet();
                ds.Tables.Add(dt.Copy());
                string childdata = ds.GetXml();
                pm.InsertRearLeftQuarterPanelDT(childdata);
            }
            else
            {
                int vinid = Convert.ToInt32(Session["id_vin"]);
                pm.Delete_REARLEFTQUARTERPANELdata(vinid);

            }
        }
        //8.Front Left Window
        public void DBInsertFrontLeftWindowFrontLeftWindow()
        {
            DataTable dt = (DataTable)ViewState["FrontLeftWindow_fill_summary"];
            if (dt != null)
            {
                dt.TableName = "TableXML";
                DataSet ds = new DataSet();
                ds.Tables.Add(dt.Copy());
                string childdata = ds.GetXml();
                pm.InsertFrontLeftWindowDT(childdata);
            }
            else
            {
                int vinid = Convert.ToInt32(Session["id_vin"]);
                pm.Delete_FRONTLEFTWINDOWdata(vinid);

            }
        }
        //9.Rear Left Window
        public void DBInsertRearLeftWindow()
        {
            DataTable dt = (DataTable)ViewState["RearLeftWindow_fill_summary"];
            if (dt != null)
            {
                dt.TableName = "TableXML";
                DataSet ds = new DataSet();
                ds.Tables.Add(dt.Copy());
                string childdata = ds.GetXml();
                pm.InsertRearLeftWindowDT(childdata);
            }
            else
            {
                int vinid = Convert.ToInt32(Session["id_vin"]);
                pm.Delete_REARLEFTWINDOWdata(vinid);

            }
        }
        //10.Front Windshield
        public void DBInsertFrontWindshield()
        {
            DataTable dt = (DataTable)ViewState["FrontWindshield_fill_summary"];
            if (dt != null)
            {
                dt.TableName = "TableXML";
                DataSet ds = new DataSet();
                ds.Tables.Add(dt.Copy());
                string childdata = ds.GetXml();
                pm.InsertFrontWindshieldDT(childdata);
            }
            else
            {
                int vinid = Convert.ToInt32(Session["id_vin"]);
                pm.Delete_FRONTWINDSHIELDdata(vinid);

            }
        }
        //11.Front Left Wheel& Tire
        public void DBInsertFrontLeftWheelTire()
        {
            DataTable dt = (DataTable)ViewState["FrontLeftWheelTire_fill_summary"];
            if (dt != null)
            {
                dt.TableName = "TableXML";
                DataSet ds = new DataSet();
                ds.Tables.Add(dt.Copy());
                string childdata = ds.GetXml();
                pm.InsertFrontLeftWheelTireDT(childdata);
            }
            else
            {
                int vinid = Convert.ToInt32(Session["id_vin"]);
                pm.Delete_FRONTRIGHTWHEELTIREdata(vinid);

            }
        }
        //12.Rear Left Wheel& Tire
        public void DBInsertRearLeftWheelTire()
        {
            DataTable dt = (DataTable)ViewState["RearLeftWheelTire_fill_summary"];
            if (dt != null)
            {
                dt.TableName = "TableXML";
                DataSet ds = new DataSet();
                ds.Tables.Add(dt.Copy());
                string childdata = ds.GetXml();
                pm.InsertRearLeftWheelTireDT(childdata);
            }
            else
            {
                int vinid = Convert.ToInt32(Session["id_vin"]);
                pm.Delete_REARLEFTWHEELTIREdata(vinid);

            }
        }
        //13.Front Left Headlight
        public void DBInsertFrontLeftHeadlight()
        {
            DataTable dt = (DataTable)ViewState["FrontLeftHeadlight_fill_summary"];
            if (dt != null)
            {
                dt.TableName = "TableXML";
                DataSet ds = new DataSet();
                ds.Tables.Add(dt.Copy());
                string childdata = ds.GetXml();
                pm.InsertFrontLeftHeadlightDT(childdata);
            }
            else
            {
                int vinid = Convert.ToInt32(Session["id_vin"]);
                pm.Delete_FRONTLEFTHEADLIGHTdata(vinid);

            }
        }
        //14.Front Right Headlight
        public void DBInsertFrontRightHeadlight()
        {
            DataTable dt = (DataTable)ViewState["FrontRightHeadlight_fill_summary"];
            if (dt != null)
            {
                dt.TableName = "TableXML";
                DataSet ds = new DataSet();
                ds.Tables.Add(dt.Copy());
                string childdata = ds.GetXml();
                pm.InsertFrontRightHeadlightDT(childdata);
            }
            else
            {
                int vinid = Convert.ToInt32(Session["id_vin"]);
                pm.Delete_FRONTRIGHTHEADLIGHTdata(vinid);

            }
        }
        //15.Left Mirror
        public void DBInsertLeftMirror()
        {
            DataTable dt = (DataTable)ViewState["LeftMirror_fill_summary"];
            if (dt != null)
            {
                dt.TableName = "TableXML";
                DataSet ds = new DataSet();
                ds.Tables.Add(dt.Copy());
                string childdata = ds.GetXml();
                pm.InsertLeftMirrorDT(childdata);
            }
            else
            {
                int vinid = Convert.ToInt32(Session["id_vin"]);
                pm.Delete_LEFTMIRRORdata(vinid);

            }
        }
        //16.Repeat Previous Roof//
        //17.Trunk
        public void DBInsertTrunk()
        {
            DataTable dt = (DataTable)ViewState["Trunk_fill_summary"];
            if (dt != null)
            {
                dt.TableName = "TableXML";
                DataSet ds = new DataSet();
                ds.Tables.Add(dt.Copy());
                string childdata = ds.GetXml();
                pm.InsertTrunkDT(childdata);
            }
            else
            {
                int vinid = Convert.ToInt32(Session["id_vin"]);
                pm.Delete_TRUNKdata(vinid);

            }
        }
        //18.Rear Bumper
        public void DBInsertRearBumper()
        {
            DataTable dt = (DataTable)ViewState["RearBumper_fill_summary"];
            if (dt != null)
            {
                dt.TableName = "TableXML";
                DataSet ds = new DataSet();
                ds.Tables.Add(dt.Copy());
                string childdata = ds.GetXml();
                pm.InsertRearBumperDT(childdata);
            }
            else
            {
                int vinid = Convert.ToInt32(Session["id_vin"]);
                pm.Delete_REARBUMPERdata(vinid);

            }
        }
        //19.Rear Right Quarter Panel
        public void DBInsertRearRightQuarterPanel()
        {
            DataTable dt = (DataTable)ViewState["RearRightQuarterPanel_fill_summary"];
            if (dt != null)
            {
                dt.TableName = "TableXML";
                DataSet ds = new DataSet();
                ds.Tables.Add(dt.Copy());
                string childdata = ds.GetXml();
                pm.InsertRearRightQuarterPanelDT(childdata);
            }
            else
            {
                int vinid = Convert.ToInt32(Session["id_vin"]);
                pm.Delete_REARRIGHTQUARTERPANELdata(vinid);

            }
        }
        //20.Front Right Fender
        public void DBInsertFrontRightFender()
        {
            DataTable dt = (DataTable)ViewState["FrontRightFender_fill_summary"];
            if (dt != null)
            {
                dt.TableName = "TableXML";
                DataSet ds = new DataSet();
                ds.Tables.Add(dt.Copy());
                string childdata = ds.GetXml();
                pm.InsertFrontRightFenderDT(childdata);
            }
            else
            {
                int vinid = Convert.ToInt32(Session["id_vin"]);
                pm.Delete_FRONTRIGHTFENDERdata(vinid);

            }
        }
        //21.Front Right Door
        public void DBInsertFrontRightDoor()
        {
            DataTable dt = (DataTable)ViewState["FrontRightDoor_fill_summary"];
            if (dt != null)
            {
                dt.TableName = "TableXML";
                DataSet ds = new DataSet();
                ds.Tables.Add(dt.Copy());
                string childdata = ds.GetXml();
                pm.InsertFrontRightDoorDT(childdata);
            }
            else
            {
                int vinid = Convert.ToInt32(Session["id_vin"]);
                pm.Delete_FRONTRIGHTDOORdata(vinid);

            }
        }
        //22.Rear Right Door
        public void DBInsertRearRightDoor()
        {
            DataTable dt = (DataTable)ViewState["RearRightDoor_fill_summary"];
            if (dt != null)
            {
                dt.TableName = "TableXML";
                DataSet ds = new DataSet();
                ds.Tables.Add(dt.Copy());
                string childdata = ds.GetXml();
                pm.InsertRearRightDoorDT(childdata);
            }
            else
            {
                int vinid = Convert.ToInt32(Session["id_vin"]);
                pm.Delete_REARRIGHTDOORdata(vinid);

            }
        }
        //23.Front Right Window
        public void DBInsertFrontRightWindow()
        {
            DataTable dt = (DataTable)ViewState["FrontRightWindow_fill_summary"];
            if (dt != null)
            {
                dt.TableName = "TableXML";
                DataSet ds = new DataSet();
                ds.Tables.Add(dt.Copy());
                string childdata = ds.GetXml();
                pm.InsertFrontRightWindowDT(childdata);
            }
            else
            {
                int vinid = Convert.ToInt32(Session["id_vin"]);
                pm.Delete_FRONTRIGHTWINDOWdata(vinid);

            }
        }
        //24.Rear Right Window
        public void DBInsertRearRightWindow()
        {
            DataTable dt = (DataTable)ViewState["RearRightWindow_fill_summary"];
            if (dt != null)
            {
                dt.TableName = "TableXML";
                DataSet ds = new DataSet();
                ds.Tables.Add(dt.Copy());
                string childdata = ds.GetXml();
                pm.InsertRearRightWindowDT(childdata);
            }
            else
            {
                int vinid = Convert.ToInt32(Session["id_vin"]);
                pm.Delete_REARRIGHTWINDOWdata(vinid);

            }
        }
        //25.Rear Windshield
        public void DBInsertRearWindshield()
        {
            DataTable dt = (DataTable)ViewState["RearWindshield_fill_summary"];
            if (dt != null)
            {
                dt.TableName = "TableXML";
                DataSet ds = new DataSet();
                ds.Tables.Add(dt.Copy());
                string childdata = ds.GetXml();
                pm.InsertRearWindshieldDT(childdata);
            }
            else
            {
                int vinid = Convert.ToInt32(Session["id_vin"]);
                pm.Delete_REARWINDSHIELDdata(vinid);

            }
        }
        //26.Front Right Wheel & Tire
        public void DBInsertFrontRightWheelTire()
        {
            DataTable dt = (DataTable)ViewState["FrontRightWheelTire_fill_summary"];
            if (dt != null)
            {
                dt.TableName = "TableXML";
                DataSet ds = new DataSet();
                ds.Tables.Add(dt.Copy());
                string childdata = ds.GetXml();
                pm.InsertFrontRightWheelTireDT(childdata);
            }
            else
            {
                int vinid = Convert.ToInt32(Session["id_vin"]);
                pm.Delete_FRONTRIGHTWHEELTIREdata(vinid);

            }
        }
        //27.Rear Right Wheel & Tire
        public void DBInsertRearRightWheelTire()
        {
            DataTable dt = (DataTable)ViewState["RearRightWheelTire_fill_summary"];
            if (dt != null)
            {
                dt.TableName = "TableXML";
                DataSet ds = new DataSet();
                ds.Tables.Add(dt.Copy());
                string childdata = ds.GetXml();
                pm.InsertRearRightWheelTireDT(childdata);
            }
            else
            {
                int vinid = Convert.ToInt32(Session["id_vin"]);
                pm.Delete_REARRIGHTWHEELTIREdata(vinid);

            }
        }
        //28.Right Tail Light
        public void DBInsertRightTailLight()
        {
            DataTable dt = (DataTable)ViewState["RightTailLight_fill_summary"];
            if (dt != null)
            {
                dt.TableName = "TableXML";
                DataSet ds = new DataSet();
                ds.Tables.Add(dt.Copy());
                string childdata = ds.GetXml();
                pm.InsertRightTailLightDT(childdata);
            }
            else
            {
                int vinid = Convert.ToInt32(Session["id_vin"]);
                pm.Delete_RIGHTTAILLIGHTdata(vinid);

            }
        }
        //29.Left Tail Light(driver side)
        public void DBInsertLeftTailLightdriverside()
        {
            DataTable dt = (DataTable)ViewState["LeftTailLightdriverside_fill_summary"];
            if (dt != null)
            {
                dt.TableName = "TableXML";
                DataSet ds = new DataSet();
                ds.Tables.Add(dt.Copy());
                string childdata = ds.GetXml();
                pm.InsertLeftTailLightdriversideDT(childdata);
            }
            else
            {
                int vinid = Convert.ToInt32(Session["id_vin"]);
                pm.Delete_LEFTTAILLIGHTdata(vinid);

            }
        }
        //30.Right Mirror
        public void DBInsertRightMirror()
        {

            DataTable dt = (DataTable)ViewState["RightMirror_fill_summary"];
            if (dt != null)
            {
                dt.TableName = "TableXML";
                DataSet ds = new DataSet();
                ds.Tables.Add(dt.Copy());
                string childdata = ds.GetXml();
                pm.InsertRightMirrorDT(childdata);
            }
            else
            {
                int vinid = Convert.ToInt32(Session["id_vin"]);
                pm.Delete_RIGHTMIRRORdata(vinid);

            }
        }

        protected void Vehicle_condition_details_updateBtn_Click(object sender, ImageClickEventArgs e)
        {
            UpdateVehicleConditionDetails_UpdateClick();

            Vehicle_condition_detail_nextbtn.Visible = true;
        }

        public void UpdateVehicleConditionDetails_UpdateClick()
        {
            DataTable DT1 = (DataTable)ViewState["FrontBumper_fill_summary"];
            DataTable DT2 = (DataTable)ViewState["Hood_fill_summary"];
            DataTable DT3 = (DataTable)ViewState["Roof_fill_summary"];
            DataTable DT4 = (DataTable)ViewState["FrontLeftFender_fill_summary"];
            DataTable DT5 = (DataTable)ViewState["FrontLeftDoor_Fill_summary"];
            DataTable DT6 = (DataTable)ViewState["RearLeftDoor_fill_summary"];
            DataTable DT7 = (DataTable)ViewState["RearLeftQuarterPanel_fill_summary"];
            DataTable DT8 = (DataTable)ViewState["FrontLeftWindow_fill_summary"];
            DataTable DT9 = (DataTable)ViewState["RearLeftWindow_fill_summary"];
            DataTable DT10 = (DataTable)ViewState["FrontWindshield_fill_summary"];
            DataTable DT11 = (DataTable)ViewState["FrontLeftWheelTire_fill_summary"];
            DataTable DT12 = (DataTable)ViewState["RearLeftWheelTire_fill_summary"];
            DataTable DT13 = (DataTable)ViewState["FrontLeftHeadlight_fill_summary"];
            DataTable DT14 = (DataTable)ViewState["FrontRightHeadlight_fill_summary"];
            DataTable DT15 = (DataTable)ViewState["LeftMirror_fill_summary"];
            DataTable DT16 = (DataTable)ViewState["Trunk_fill_summary"];
            DataTable DT17 = (DataTable)ViewState["RearBumper_fill_summary"];
            DataTable DT18 = (DataTable)ViewState["RearRightQuarterPanel_fill_summary"];
            DataTable DT19 = (DataTable)ViewState["FrontRightFender_fill_summary"];
            DataTable DT20 = (DataTable)ViewState["FrontRightDoor_fill_summary"];
            DataTable DT21 = (DataTable)ViewState["RearRightDoor_fill_summary"];
            DataTable DT22 = (DataTable)ViewState["FrontRightWindow_fill_summary"];
            DataTable DT23 = (DataTable)ViewState["RearRightWindow_fill_summary"];
            DataTable DT24 = (DataTable)ViewState["RearWindshield_fill_summary"];
            DataTable DT25 = (DataTable)ViewState["FrontRightWheelTire_fill_summary"];
            DataTable DT26 = (DataTable)ViewState["RearRightWheelTire_fill_summary"];
            DataTable DT27 = (DataTable)ViewState["RightTailLight_fill_summary"];
            DataTable DT28 = (DataTable)ViewState["LeftTailLightdriverside_fill_summary"];
            DataTable DT29 = (DataTable)ViewState["RightMirror_fill_summary"];
            
                    // 1 FrontBumper
                    try
                    {
                        if (DT1.Rows.Count > 0)
                        {
                            //Fb_Div_Summary.Visible = true;
                            Gvd_FrontBumper.DataSource = DT1;
                            Gvd_FrontBumper.DataBind();
                        }
                        else
                        {
                            //Fb_Div_Summary.Visible = false;
                            Gvd_FrontBumper.DataSource = DT1;
                            Gvd_FrontBumper.DataBind();
                        }
                    }
                    catch (Exception e1)
                    {

                    }

                    // 2. hood
                    try
                    {
                        if (DT2.Rows.Count > 0)
                        {
                           // Hood_Div_Summary.Visible =true;
                            Gvd_Hood.DataSource = DT2;
                            Gvd_Hood.DataBind();
                        }
                        else
                        {
                           // Hood_Div_Summary.Visible = false;
                            Gvd_Hood.DataSource = DT2;
                            Gvd_Hood.DataBind();
                        }
                    }
                    catch (Exception e2)
                    {

                    }


                    // 3 Roof
                    try
                    {
                        if (DT3.Rows.Count > 0)
                        {
                           // Roof_Div_Summary.Visible = true;
                            Gvd_Rooof.DataSource = DT3;
                            Gvd_Rooof.DataBind();
                        }
                        else
                        {
                           // Roof_Div_Summary.Visible =false;
                            Gvd_Rooof.DataSource = DT3;
                            Gvd_Rooof.DataBind();
                        }
                    }
                    catch (Exception e3)
                    {

                    }

                    // 4    FrontLeftFender

                    try
                    {
                        if (DT4.Rows.Count > 0)
                        {
                            //Front_Left_fender_Div_Summary.Visible = true;
                            Gvd_Front_left_Fender.DataSource = DT4;
                            Gvd_Front_left_Fender.DataBind();
                        }
                        else
                        {
                           // Front_Left_fender_Div_Summary.Visible = false;
                            Gvd_Front_left_Fender.DataSource = DT4;
                            Gvd_Front_left_Fender.DataBind();
                        }
                    }
                    catch (Exception e4)
                    {

                    }


                    // 5.FrontLeftDoor

                    try
                    {
                        if (DT5.Rows.Count > 0)
                        {
                           // Front_Left_Door_Div_Summary.Visible = true;
                            Gvd_FrontLeftDoor.DataSource = DT5;
                            Gvd_FrontLeftDoor.DataBind();
                        }
                        else
                        {
                           // Front_Left_Door_Div_Summary.Visible = false;
                            Gvd_FrontLeftDoor.DataSource = DT5;
                            Gvd_FrontLeftDoor.DataBind();
                        }
                    }
                    catch (Exception e5)
                    {

                    }


                    // 6 RearLeftDoor

                    try
                    {
                        if (DT6.Rows.Count > 0)
                        {
                           // RearLeftDoor_Div_Summary.Visible = true;
                            Gvd_Rear_Left_door.DataSource = DT6;
                            Gvd_Rear_Left_door.DataBind();
                        }
                        else
                        {
                           // RearLeftDoor_Div_Summary.Visible = false;
                            Gvd_Rear_Left_door.DataSource = DT6;
                            Gvd_Rear_Left_door.DataBind();
                        }
                    }
                    catch (Exception e6)
                    {

                    }


                    // 7 RearLeftQuarterPanel_Div_Summary
                    try
                    {
                        if (DT7.Rows.Count > 0)
                        {
                           // RearLeftQuarterPanel_Div_Summary.Visible = true;
                            Gvd_RearLeftQuarterPanel.DataSource = DT7;
                            Gvd_RearLeftQuarterPanel.DataBind();
                        }
                        else
                        {
                           // RearLeftQuarterPanel_Div_Summary.Visible = false;
                            Gvd_RearLeftQuarterPanel.DataSource = DT7;
                            Gvd_RearLeftQuarterPanel.DataBind();
                        }
                    }
                    catch (Exception e7)
                    {

                    }


                    // 8 FrontLeftWindow

                    try
                    {
                        if (DT8.Rows.Count > 0)
                        {
                           // FrontLeftWindow_Div_summary.Visible = true;
                            Gvd_FrontLeftWindow.DataSource = DT8;
                            Gvd_FrontLeftWindow.DataBind();
                        }
                        else 
                        {
                          //  FrontLeftWindow_Div_summary.Visible = false;
                            Gvd_FrontLeftWindow.DataSource = DT8;
                            Gvd_FrontLeftWindow.DataBind();
                        }

                    }
                    catch (Exception e8)
                    {

                    }


                    // 9 RearLeftWindow_Div_summary

                    try
                    {
                        if (DT9.Rows.Count > 0)
                        {
                           // RearLeftWindow_Div_summary.Visible = true;
                            Gvd_RearLeftWindow.DataSource = DT9;
                            Gvd_RearLeftWindow.DataBind();
                        }
                        else
                        {
                           // RearLeftWindow_Div_summary.Visible = false;
                            Gvd_RearLeftWindow.DataSource = DT9;
                            Gvd_RearLeftWindow.DataBind();
                        }

                    }
                    catch (Exception e9)
                    {

                    }


                    // 10 FrontWindshield_Div_summary

                    try
                    {
                        if (DT10.Rows.Count > 0)
                        {
                           // FrontWindshield_Div_summary.Visible = true;
                            Gvd_FrontWindshield.DataSource = DT10;
                            Gvd_FrontWindshield.DataBind();
                        }
                        else
                        {
                           // FrontWindshield_Div_summary.Visible = false;
                            Gvd_FrontWindshield.DataSource = DT10;
                            Gvd_FrontWindshield.DataBind();
                        }
                    }
                    catch (Exception e10)
                    {

                    }

                    // 11.FrontLeftWheelTire_Div_summary

                    try
                    {
                        if (DT11.Rows.Count > 0)
                        {
                           // FrontLeftWheelTire_Div_summary.Visible = true;
                            Gvd_FrontLeftWheelTire.DataSource = DT11;
                            Gvd_FrontLeftWheelTire.DataBind();
                        }
                        else
                        {
                           // FrontLeftWheelTire_Div_summary.Visible =false;
                            Gvd_FrontLeftWheelTire.DataSource = DT11;
                            Gvd_FrontLeftWheelTire.DataBind();
                        }
                    }
                    catch (Exception e11)
                    {

                    }


                    // 12 RearLeftWheelTire_Div_Summary
                    try
                    {
                        if (DT12.Rows.Count > 0)
                        {
                            //RearLeftWheelTire_Div_Summary.Visible = true;
                            Gvd_RearLeftWheelTire.DataSource = DT12;
                            Gvd_RearLeftWheelTire.DataBind();
                        }
                        else
                        {
                           // RearLeftWheelTire_Div_Summary.Visible = false;
                            Gvd_RearLeftWheelTire.DataSource = DT12;
                            Gvd_RearLeftWheelTire.DataBind();
                        }
                    }
                    catch (Exception e12)
                    {

                    }

                    // 13 FrontLeftHeadligh_Div_Summary
                    try
                    {
                        if (DT13.Rows.Count > 0)
                        {
                           // FrontLeftHeadligh_Div_Summary.Visible = true;
                            Gvd_FrontLeftHeadligh.DataSource = DT13;
                            Gvd_FrontLeftHeadligh.DataBind();
                        }
                        else
                        {
                           // FrontLeftHeadligh_Div_Summary.Visible = false;
                            Gvd_FrontLeftHeadligh.DataSource = DT13;
                            Gvd_FrontLeftHeadligh.DataBind();
                        }
                    }
                    catch (Exception e13)
                    {

                    }


                    // 14 FrontRighttHeadligh_Div_Summary

                    try
                    {
                        if (DT14.Rows.Count > 0)
                        {
                           // FrontRighttHeadligh_Div_Summary.Visible = true;
                            Gvd_FrontrightHeadlight.DataSource = DT14;
                            Gvd_FrontrightHeadlight.DataBind();
                        }
                        else
                        {
                          //  FrontRighttHeadligh_Div_Summary.Visible = false;
                            Gvd_FrontrightHeadlight.DataSource = DT14;
                            Gvd_FrontrightHeadlight.DataBind();
                        }
                    }
                    catch (Exception e14)
                    {

                    }

                    // 15 LeftMirror_Div_Summary
                    try
                    {
                        if (DT15.Rows.Count > 0)
                        {
                           // LeftMirror_Div_Summary.Visible = true;
                            Gvd_LeftMirror.DataSource = DT15;
                            Gvd_LeftMirror.DataBind();
                        }
                        else
                        {
                          //  LeftMirror_Div_Summary.Visible = false;
                            Gvd_LeftMirror.DataSource = DT15;
                            Gvd_LeftMirror.DataBind();
                        }
                    }
                    catch (Exception e15)
                    {

                    }

                    // 16 Trunk_Div_Summary
                    try
                    {
                        if (DT16.Rows.Count > 0)
                        {
                           // Trunk_Div_Summary.Visible = true;
                            Gvd_Trunk.DataSource = DT16;
                            Gvd_Trunk.DataBind();
                        }
                        else
                        {
                         //   Trunk_Div_Summary.Visible = false;
                            Gvd_Trunk.DataSource = DT16;
                            Gvd_Trunk.DataBind();
                        }
                    }
                    catch (Exception e16)
                    {

                    }

                    // 17 RearBumper_Div_Summary
                    try
                    {
                        if (DT17.Rows.Count > 0)
                        {
                           // RearBumper_Div_Summary.Visible = true;
                            Gvd_RearBumper.DataSource = DT17;
                            Gvd_RearBumper.DataBind();
                        }
                        else
                        {
                           // RearBumper_Div_Summary.Visible =false;
                            Gvd_RearBumper.DataSource = DT17;
                            Gvd_RearBumper.DataBind();
                        }
                    }
                    catch (Exception e17)
                    {

                    }

                    // 18 RearRightQuarterPanel_Div_Summary
                    try
                    {
                        if (DT18.Rows.Count > 0)
                        {
                           // RearRightQuarterPanel_Div_Summary.Visible = true;
                            Gvd_RearRightQuarterPanel.DataSource = DT18;
                            Gvd_RearRightQuarterPanel.DataBind();
                        }
                        else
                        {
                           // RearRightQuarterPanel_Div_Summary.Visible = false;
                            Gvd_RearRightQuarterPanel.DataSource = DT18;
                            Gvd_RearRightQuarterPanel.DataBind();
                        }
                    }
                    catch (Exception e18)
                    {

                    }


                    // 19 FrontRightFender_Div_Summary
                    try
                    {
                        if (DT19.Rows.Count > 0)
                        {
                           // FrontRightFender_Div_Summary.Visible = true;
                            Gvd_FrontRightFender.DataSource = DT19;
                            Gvd_FrontRightFender.DataBind();
                        }
                        else
                        {
                           // FrontRightFender_Div_Summary.Visible = false;
                            Gvd_FrontRightFender.DataSource = DT19;
                            Gvd_FrontRightFender.DataBind();
                        }
                    }
                    catch (Exception e19)
                    {

                    }

                    // 20 FrontRightDoor_Div_Summary
                    try
                    {
                        if (DT20.Rows.Count > 0)
                        {
                           // FrontRightDoor_Div_Summary.Visible = true;
                            Gvd_FrontRightDoor.DataSource = DT20;
                            Gvd_FrontRightDoor.DataBind();
                        }
                        else
                        {
                           // FrontRightDoor_Div_Summary.Visible = false;
                            Gvd_FrontRightDoor.DataSource = DT20;
                            Gvd_FrontRightDoor.DataBind();
                        }
                    }
                    catch (Exception e20)
                    {

                    }

                    // 21 RearRightDoor_Div_Summary

                    try
                    {
                        if (DT21.Rows.Count > 0)
                        {
                           // RearRightDoor_Div_Summary.Visible = true;
                            Gvd_RearRightDoor.DataSource = DT21;
                            Gvd_RearRightDoor.DataBind();
                        }
                        else
                        {
                          //  RearRightDoor_Div_Summary.Visible = false;
                            Gvd_RearRightDoor.DataSource = DT21;
                            Gvd_RearRightDoor.DataBind();

                        }
                    }
                    catch (Exception e21)
                    {

                    }


                    // 22 FrontRightWindow_Div_Summary

                    try
                    {
                        if (DT22.Rows.Count > 0)
                        {
                           // FrontRightWindow_Div_Summary.Visible = true;
                            Gvd_FrontRightWindow.DataSource = DT22;
                            Gvd_FrontRightWindow.DataBind();
                        }
                        else
                        {
                           // FrontRightWindow_Div_Summary.Visible = false;
                            Gvd_FrontRightWindow.DataSource = DT22;
                            Gvd_FrontRightWindow.DataBind();
                        }

                    }
                    catch (Exception e22)
                    {

                    }

                    // 23 RearRightWindow_Div_Summary
                    try
                    {
                        if (DT23.Rows.Count > 0)
                        {
                            //RearRightWindow_Div_Summary.Visible = true;
                            Gvd_RearRightWindow.DataSource = DT23;
                            Gvd_RearRightWindow.DataBind();
                        }
                        else
                        {
                           // RearRightWindow_Div_Summary.Visible = false;
                            Gvd_RearRightWindow.DataSource = DT23;
                            Gvd_RearRightWindow.DataBind();
                        }
                    }
                    catch (Exception e23)
                    {

                    }

                    // 24 RearWindshield_Div_summary
                    try
                    {
                        if (DT24.Rows.Count > 0)
                        {
                           // RearWindshield_Div_summary.Visible = true;
                            Gvd_RearWindshield.DataSource = DT24;
                            Gvd_RearWindshield.DataBind();
                        }
                        else
                        {
                           // RearWindshield_Div_summary.Visible = false;
                            Gvd_RearWindshield.DataSource = DT24;
                            Gvd_RearWindshield.DataBind();
                        }
                    }
                    catch (Exception e24)
                    {

                    }

                    // 25  FrontRightWheelTire_Div_Summary
                    try
                    {
                        if (DT25.Rows.Count > 0)
                        {
                           // FrontRightWheelTire_Div_Summary.Visible = true;
                            Gvd_FrontRightWheelTire.DataSource = DT25;
                            Gvd_FrontRightWheelTire.DataBind();
                        }
                        else
                        {
                           // FrontRightWheelTire_Div_Summary.Visible = false;
                            Gvd_FrontRightWheelTire.DataSource = DT25;
                            Gvd_FrontRightWheelTire.DataBind();
                        }
                    }
                    catch (Exception e25)
                    {

                    }

                    // 26 RearRightWheelTire_Div_Summary
                    try
                    {
                        if (DT26.Rows.Count > 0)
                        {
                           // RearRightWheelTire_Div_Summary.Visible = true;
                            Gvd_RearRightWheelTire.DataSource = DT26;
                            Gvd_RearRightWheelTire.DataBind();
                        }
                        else
                        {
                           // RearRightWheelTire_Div_Summary.Visible = false;
                            Gvd_RearRightWheelTire.DataSource = DT26;
                            Gvd_RearRightWheelTire.DataBind();
                        }
                    }
                    catch (Exception e26)
                    {

                    }

                    // 27 RightTailLight_Div_Summary
                    try
                    {
                        if (DT27.Rows.Count > 0)
                        {
                           // RightTailLight_Div_Summary.Visible = true;
                            Gvd_RightTailLight.DataSource = DT27;
                            Gvd_RightTailLight.DataSource = DT27;
                            Gvd_RightTailLight.DataBind();
                        }
                        else
                        {
                          //  RightTailLight_Div_Summary.Visible =false;
                            Gvd_RightTailLight.DataSource = DT27;
                            Gvd_RightTailLight.DataSource = DT27;
                            Gvd_RightTailLight.DataBind();
                        }

                    }
                    catch (Exception e27)
                    {

                    }

                    // 28 LeftTailLight_Div_summary
                    try
                    {
                        if (DT28.Rows.Count > 0)
                        {
                          //  LeftTailLight_Div_summary.Visible = true;
                            Gvd_LeftTailLight.DataSource = DT28;
                            Gvd_LeftTailLight.DataBind();
                        }
                        else
                        {
                           // LeftTailLight_Div_summary.Visible =false;
                            Gvd_LeftTailLight.DataSource = DT28;
                            Gvd_LeftTailLight.DataBind();
                        }
                    }
                    catch (Exception e28)
                    {

                    }

                    // 29 RightMirror_Div_Summary

                    try
                    {
                        if (DT29.Rows.Count > 0)
                        {
                           // RightMirror_Div_Summary.Visible = true;
                            Gvd_RightMirror.DataSource = DT29;
                            Gvd_RightMirror.DataBind();
                        }
                        else
                        {
                          //  RightMirror_Div_Summary.Visible = false;
                            Gvd_RightMirror.DataSource = DT29;
                            Gvd_RightMirror.DataBind();
                        }

                    }
                    catch (Exception e29)
                    {

                    }

                    try
                    {
                        if ((DT1.Rows.Count == 0 || DT1 == null) &&
                                (DT2.Rows.Count == 0 || DT2 == null) &&
                                (DT3.Rows.Count == 0 || DT3 == null) &&
                                (DT4.Rows.Count == 0 || DT4 == null) &&
                                (DT5.Rows.Count == 0 || DT5 == null) &&
                                 (DT6.Rows.Count == 0 || DT6 == null) &&
                                (DT7.Rows.Count == 0 || DT7 == null) &&
                                (DT8.Rows.Count == 0 || DT8 == null) &&
                                (DT9.Rows.Count == 0 || DT9 == null) &&
                                (DT10.Rows.Count == 0 || DT10 == null) &&
                                (DT11.Rows.Count == 0 || DT11 == null) &&
                                (DT12.Rows.Count == 0 || DT12 == null) &&
                                (DT13.Rows.Count == 0 || DT13 == null) &&
                                (DT14.Rows.Count == 0 || DT14 == null) &&
                                (DT15.Rows.Count == 0 || DT15 == null) &&
                                (DT16.Rows.Count == 0 || DT16 == null) &&
                                (DT17.Rows.Count == 0 || DT17 == null) &&
                                (DT18.Rows.Count == 0 || DT18 == null) &&
                                (DT19.Rows.Count == 0 || DT19 == null) &&
                                (DT20.Rows.Count == 0 || DT20 == null) &&
                                (DT21.Rows.Count == 0 || DT21 == null) &&
                                (DT22.Rows.Count == 0 || DT22 == null) &&
                                (DT23.Rows.Count == 0 || DT23 == null) &&
                                (DT24.Rows.Count == 0 || DT24 == null) &&
                                (DT25.Rows.Count == 0 || DT25 == null) &&
                                (DT26.Rows.Count == 0 || DT26 == null) &&
                                (DT27.Rows.Count == 0 || DT27 == null) &&
                                (DT28.Rows.Count == 0 || DT28 == null) &&
                                (DT29.Rows.Count == 0 || DT29 == null))
                        {
                            noselection.Visible = true;
                            hadselection.Visible = false;
                        }

                        else
                        {
                            noselection.Visible = false;
                            hadselection.Visible = true;
                        }

                    }
                    catch (Exception et)
                    {
                        noselection.Visible = true;
                        hadselection.Visible = false;
                    }



                    vcd.InteriorConditionData = Interior_COndition_RadiobtnLst.SelectedItem.Text.ToString();

                    vcd.MechanicalConditionData = Mechanical_COndition_radiobtn.SelectedItem.Text.ToString();
                    OverallinteriorconditionText.Text = vcd.InteriorConditionData;
                    OverallmechanicalconditionText.Text = vcd.MechanicalConditionData;
                    MultiView1.ActiveViewIndex = 5;
        }

        // inserying image DT to DB

        public void InsertImagesDT()
        {
            int vinidforimage = Convert.ToInt32(Session["id_vin"]);
            DataTable dt = (DataTable)Session["dt_imagesUploaded"];
            if (dt != null)
            {
                dt.TableName = "ImageXML";
                DataSet ds = new DataSet();
                ds.Tables.Add(dt.Copy());
                string childdata = ds.GetXml();
                pm.InsertImages_DT(vinidforimage, childdata);
            }
            else
            {
                int vinid = Convert.ToInt32(Session["id_vin"]);
                pm.Delete_imagesUploaded(vinid);
            }
        }

        //public DataTable ConvertToDataTable<T>(IList<T> FrontBumperSelectedItems4)
        //{
        //    PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
        //    DataTable table = new DataTable();
        //    foreach (PropertyDescriptor prop in properties)
        //        table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
        //    foreach (T item in FrontBumperSelectedItems4)
        //    {
        //        DataRow row = table.NewRow();
        //        foreach (PropertyDescriptor prop in properties)
        //            row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
        //        table.Rows.Add(row);
        //    }
        //    return table;
        //}
        //public void Callsp_InsertDTImage()
        //{
        //    DataTable dt = (DataTable)Session["dt_imagesUploaded"];
        //    dt.TableName = "ImageXML";
        //    DataSet ds = new DataSet();
        //    ds.Tables.Add(dt.Copy());
        //    string childdata = ds.GetXml();

        //    SqlConnection con = new SqlConnection("Data Source=203.124.106.176;Initial Catalog=Caroffer_DB; User ID=sicsjp; Password=user@123");
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = con;
        //    cmd.CommandText = "Sp_InsertImageDT";
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@opr", 2);
        //    cmd.Parameters.AddWithValue("@childdata", childdata);
        //    con.Open();
        //    cmd.ExecuteNonQuery();
        //    con.Close();
        //}



    }
}




