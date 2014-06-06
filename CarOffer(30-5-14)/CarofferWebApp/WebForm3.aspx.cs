using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


namespace CarofferWebApp
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           // GetCity(txtCity.Text);
        }


        [System.Web.Script.Services.ScriptMethod()]
        [System.Web.Services.WebMethod]
        public static List<string> GetCity(string prefixText)
        {
            DataTable dt = new DataTable();
            string constr = "Data Source=.\\SQLEXPRESS;Initial Catalog=Share; integrated security=true";
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from TB_CITY where City like @City+'%'", con);
            cmd.Parameters.AddWithValue("@City", prefixText);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);
            List<string> CityNames = new List<string>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                CityNames.Add(dt.Rows[i][1].ToString());
            }
            return CityNames;
        }


        public void InsertDT_to_DB()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("EquipmentInstalled");
            dt.Columns.Add("VIN_ID");
            dt.Columns.Add("STATUS");
            DataRow dr = dt.NewRow();
            dr["EquipmentInstalled"] = "10K GVWR Package";
            dr["VIN_ID"] = 1;
            dr["STATUS"] = 0;
            dt.Rows.Add(dr);


            DataRow dr1 = dt.NewRow();
            dr["EquipmentInstalled"] = "20 In. Chrome Clad Cast Aluminum Wheel";
            dr["VIN_ID"] = 2;
            dr["STATUS"] = 0;
            dt.Rows.Add(dr1);

            DataRow dr2 = dt.NewRow();
            dr["EquipmentInstalled"] = "3.31 Electronic Locking Axle Ratio";
            dr["VIN_ID"] = 3;
            dr["STATUS"] = 0;
            dt.Rows.Add(dr2);


            DataRow dr3 = dt.NewRow();
            dr["EquipmentInstalled"] = "";
            dr["VIN_ID"] = 4;
            dr["STATUS"] = 0;
            dt.Rows.Add(dr3);





        }

    }
}