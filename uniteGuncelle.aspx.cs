using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
public partial class uniteGuncelle : System.Web.UI.Page
{
    esqlbaglantisi baglan = new esqlbaglantisi();
    string UniteId = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["yoneticiKullanici"] == null)
        {
            Response.Redirect("default.aspx");
        }
        UniteId = Request.QueryString["UniteId"];
        if (Page.IsPostBack == false)
        {
            SqlCommand cmkguncelle = new SqlCommand("Select * from Unite where UniteId = '" + UniteId + "'", baglan.baglan());
            SqlDataReader drkguncelle = cmkguncelle.ExecuteReader();
            DataTable dtkguncelle = new DataTable("tablo");
            dtkguncelle.Load(drkguncelle);
            DataRow row = dtkguncelle.Rows[0];
            TextBox1.Text = row["UniteIsım"].ToString();
           
        }
    }

    protected void btnsinifEkle_Click(object sender, EventArgs e)
    {
        SqlCommand guncelle = new SqlCommand("update Unite set UniteIsım='" + TextBox1.Text + "' where UniteId='" + UniteId + "'", baglan.baglan());
        guncelle.ExecuteNonQuery();
        Response.Redirect("uniteDuzenle.aspx");
    }
}