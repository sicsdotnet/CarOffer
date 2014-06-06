using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using CarofferWebApp.BAl;

namespace CarofferWebApp.CarofferForms
{
    public partial class Admin : System.Web.UI.Page
    {
        public DataTable dt = null;
        PropertyManager pm = new PropertyManager();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindAdminGridview();
            }
        }

        [System.Web.Script.Services.ScriptMethod()]
        [System.Web.Services.WebMethod]
        public static List<string> GetVin(string prefixText)
        {
            string constr = "Data Source=203.124.106.176;Initial Catalog=Caroffer_DB; User ID=sicsjp; Password=user@123;";
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "select * from TB_VEHICLE_VIN where VIN like @vin+'%'";
            cmd.Parameters.AddWithValue("@vin", prefixText);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            List<string> Vins = new List<string>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Vins.Add(dt.Rows[i][1].ToString());
            }
            return Vins;

          
           
        }




        public void BindAdminGridview()
        {
            try
            {
                dt = pm.getVehiclespecification();
                if (dt != null)
                {
                    AdminGridview.DataSource = dt;
                    AdminGridview.DataBind();
                }
            }
            catch (Exception e)
            {

            }
        }


        // to b serviced---status 0
        public void BindTObServicedGrid()
        {
            try
            {
                DataTable dt = pm.getdataToBServiced();
                if (dt != null)
                {
                    AdminGridview.DataSource = dt;
                    AdminGridview.DataBind();
                }
            }
            catch (Exception e)
            {
            }

        }

        // Serviced Data---status 1
        public void BindServicedGrid()
        {
           // getdataToBServiced();
            try
            {
                DataTable dt = pm.getdataServicedAlready();
                if (dt != null)
                {
                    AdminGridview.DataSource = dt;
                    AdminGridview.DataBind();
                }
            }
            catch (Exception e)
            {
            }

        }


        protected void AdminGridview_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            GridViewRow row = (GridViewRow)(((LinkButton)e.CommandSource).NamingContainer);

            if (e.CommandName == "view")
            {
                string vin = AdminGridview.DataKeys[row.RowIndex].Value.ToString();
              //  string vin = AdminGridview.DataKeys[row.RowIndex].Values[0].ToString();where o is The datakeynames list
                string vinid = e.CommandArgument.ToString();
                ViewState["summary_vinid"] = vinid;

                Response.Redirect("Summary.aspx?vinid=" + e.CommandArgument.ToString());
            }

        }

        protected void AdminGridview_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            AdminGridview.PageIndex = e.NewPageIndex;
            BindAdminGridview();
        }

        protected void TobServicedBtn_Click(object sender, EventArgs e)
        {
            BindTObServicedGrid();
        }

        protected void serviced_btn_Click(object sender, EventArgs e)
        {
            BindServicedGrid();
        }

        protected void SearchVIn_Click(object sender, EventArgs e)
        {

            string vinnum = txtVin.Text.ToString();
            try
            {
          DataTable dt=pm.getVehiclespecificationById(vinnum);
          
              if (dt.Rows.Count > 0)
              {
                  AdminGridview.DataSource = dt;
                  AdminGridview.DataBind();
              }
          }
          catch (Exception w)
          {

          }
        }
    }
}