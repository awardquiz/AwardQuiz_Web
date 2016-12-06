using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class bilgiDuzenle : System.Web.UI.Page
{
    esqlbaglantisi baglan = new esqlbaglantisi();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["yoneticiKullanici"] == null)
        {
            Response.Redirect("default.aspx");
        }
        Label1.Text = Session["yoneticiKullanici"].ToString();
    }
    protected void btnkEkle_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text == TextBox2.Text)
        {
            SqlCommand btnguncelle = new SqlCommand("update Yonetici set yoneticiKullanici='"+TextBox3.Text+"',yoneticiSifre='"+TextBox1.Text+"' where yoneticiKullanici='"+Session["yoneticiKullanici"]+"'",baglan.baglan());
            btnguncelle.ExecuteNonQuery();
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
        }
            
    }
}