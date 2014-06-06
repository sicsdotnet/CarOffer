using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarofferWebApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;

        }

        protected void ddt1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddt1.SelectedIndex == -1)
            {
                div1.Visible = true;
            }
            if(ddt1.SelectedIndex==0)
            {
                div2.Visible = true;
            }

        }

       

        protected void CheckBoxList1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            if (CheckBoxList1.SelectedValue == "0")
            {
                list1.Items[0].Enabled = true;
            }

        }
    }
}