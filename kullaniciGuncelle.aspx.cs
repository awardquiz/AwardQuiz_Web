using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class kullaniciGuncelle : System.Web.UI.Page
{
    esqlbaglantisi baglan = new esqlbaglantisi();
    string yoneticiId = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["yoneticiKullanici"] == null)
        {
            Response.Redirect("default.aspx");
        }
        yoneticiId = Request.QueryString["yoneticiId"];

        if (Page.IsPostBack == false)
        {
            SqlCommand cmkguncelle = new SqlCommand("Select * from Yonetici where yoneticiId = '" + yoneticiId + "'", baglan.baglan());
            SqlDataReader drkguncelle = cmkguncelle.ExecuteReader();
            DataTable dtkguncelle = new DataTable("tablo");
            dtkguncelle.Load(drkguncelle);
            DataRow row = dtkguncelle.Rows[0];
            TextBox1.Text = row["yoneticiKullanici"].ToString();
        }
    }
    protected void btnkguncelle_Click(object sender, EventArgs e)
    {
        if (TextBox2.Text == "" || TextBox3.Text == "")
        {
            Label1.Text = "Boş Değer Girilmez";
        }
        else
        {
            SqlCommand cmkguncelle = new SqlCommand("update Yonetici Set yoneticiKullanici='" + TextBox1.Text + "', yoneticiSifre='" + TextBox2.Text + "' where yoneticiId='" + yoneticiId + "'", baglan.baglan());
            cmkguncelle.ExecuteNonQuery();
        }
        


    }
}