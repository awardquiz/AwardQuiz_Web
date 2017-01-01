using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_admin : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Convert.ToString(Session["Yetki"]) != "1")
        {
            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = false;

        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("cikis.aspx");
        
    }
}
