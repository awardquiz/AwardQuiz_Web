using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class admin_adminpanel : System.Web.UI.Page
{
    esqlbaglantisi baglan = new esqlbaglantisi();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["yoneticiKullanici"] == null)
        {
            Response.Redirect("default.aspx");
        }
        else
        {
            Label1.Text = "Merhaba " + Session["yoneticiKullanici"].ToString();
        }
      
            
           
        
       
    }

}