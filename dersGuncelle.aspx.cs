using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
public partial class dersGuncelle : System.Web.UI.Page
{
    esqlbaglantisi baglan = new esqlbaglantisi();
    string DersId = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["yoneticiKullanici"] == null)
        {
            Response.Redirect("default.aspx");
        }
        DersId = Request.QueryString["DersId"];
        if (Page.IsPostBack == false)
        {
            SqlCommand cmkguncelle = new SqlCommand("Select * from Dersler where DersId = '" + DersId + "'", baglan.baglan());
            SqlDataReader drkguncelle = cmkguncelle.ExecuteReader();
            DataTable dtkguncelle = new DataTable("tablo");
            dtkguncelle.Load(drkguncelle);
            DataRow row = dtkguncelle.Rows[0];
            TextBox1.Text = row["DersAdi"].ToString();

        }
    }


    protected void dersguncelle_Click(object sender, EventArgs e)
    {
        SqlCommand guncelle = new SqlCommand("update Dersler set DersAdi='" + TextBox1.Text + "' where DersId='" + DersId + "'", baglan.baglan());
        guncelle.ExecuteNonQuery();
        Response.Redirect("dersDuzenle.aspx");
    }
}