using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class dersDuzenle : System.Web.UI.Page
{
    esqlbaglantisi baglan = new esqlbaglantisi();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["yoneticiKullanici"] == null)
        {
            Response.Redirect("default.aspx");
        }

        if (Page.IsPostBack == false)
        {
            SqlCommand cmkguncelle = new SqlCommand("Select * from ayarlar", baglan.baglan());
            SqlDataReader drkguncelle = cmkguncelle.ExecuteReader();
            DataTable dtkguncelle = new DataTable("tablo");
            dtkguncelle.Load(drkguncelle);
            DataRow row = dtkguncelle.Rows[0];
            TextBox1.Text = row["dogru_sayisi"].ToString();
            TextBox3.Text = row["dakika"].ToString();
            TextBox2.Text = row["sifre"].ToString();
            TextBox4.Text = row["soru_sayisi"].ToString();
        }

        
    }
    protected void ayarla_Click(object sender, EventArgs e)
    {
        SqlCommand cmkguncelle = new SqlCommand("update ayarlar Set dogru_sayisi='"+TextBox1.Text+"', dakika='"+TextBox3.Text+"', sifre='"+TextBox2.Text+"', soru_sayisi='"+TextBox4.Text+"'", baglan.baglan());
        cmkguncelle.ExecuteNonQuery();
        Response.Redirect("ayarlar.aspx");
    }
}