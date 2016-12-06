using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class dersEkle : System.Web.UI.Page
{
    esqlbaglantisi baglan = new esqlbaglantisi();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["yoneticiKullanici"] == null)
        {
            Response.Redirect("default.aspx");
        }
        if (Convert.ToString(Session["Yetki"]) != "1")
        {
            Response.Redirect("adminpanel.aspx");
        }
    }
    protected void btnDersEkle_Click(object sender, EventArgs e)
    {
        SqlCommand dersekle = new SqlCommand("insert into Dersler (DersAdi) values ('" + TextBox1.Text + "')", baglan.baglan());
        dersekle.ExecuteNonQuery();
        TextBox1.Text = "";
    }
}