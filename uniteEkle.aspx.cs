using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class uniteEkle : System.Web.UI.Page
{
    esqlbaglantisi baglan = new esqlbaglantisi();

    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (Session["yoneticiKullanici"] == null)
        {
            Response.Redirect("default.aspx");
        }
    }
    protected void btnUniteEkle_Click(object sender, EventArgs e)
    {
        SqlCommand uniteekle = new SqlCommand("insert into Unite (UniteIsım) values ('" + TextBox1.Text + "')", baglan.baglan());
        uniteekle.ExecuteNonQuery();
        TextBox1.Text = "";
    }
}