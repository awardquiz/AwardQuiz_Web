using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
public partial class sinifGuncelle : System.Web.UI.Page
{
    esqlbaglantisi baglan = new esqlbaglantisi();
    string SinifId = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["yoneticiKullanici"] == null)
        {
            Response.Redirect("default.aspx");
        }
        SinifId = Request.QueryString["SinifId"];
        if (Page.IsPostBack == false)
        {
            SqlCommand cmkguncelle = new SqlCommand("Select * from Sinif where SinifId = '" + SinifId + "'", baglan.baglan());
            SqlDataReader drkguncelle = cmkguncelle.ExecuteReader();
            DataTable dtkguncelle = new DataTable("tablo");
            dtkguncelle.Load(drkguncelle);
            DataRow row = dtkguncelle.Rows[0];
            TextBox1.Text = row["SinifAdi"].ToString();
           
        }
    }
    protected void btnsinifEkle_Click(object sender, EventArgs e)
    {
        SqlCommand guncelle = new SqlCommand("update Sinif set SinifAdi='" + TextBox1.Text + "' where SinifId='"+SinifId+"'", baglan.baglan());
        guncelle.ExecuteNonQuery();
        Response.Redirect("sinifDuzenle.aspx");
    }
}