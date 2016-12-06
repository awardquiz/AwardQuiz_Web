using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class admin_Default : System.Web.UI.Page
{
    esqlbaglantisi baglan = new esqlbaglantisi();
    protected void Page_Load(object sender, EventArgs e)
    {
       
        if (Session["yoneticiKullanici"] != null)
        {
            Response.Redirect("adminpanel.aspx");
        }
    }
    protected void btn_giris_Click(object sender, EventArgs e)
    {
        
        SqlCommand cmd = new SqlCommand("Select * from Yonetici where yoneticiKullanici=@yoneticiKullanici and yoneticiSifre=@yoneticiSifre", baglan.baglan());
        cmd.Parameters.Add("yoneticiKullanici", txt_kadi.Text);
        cmd.Parameters.Add("yoneticiSifre", txt_sifre.Text);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            
            Session["yoneticiKullanici"] = dr["yoneticiKullanici"];
            Session["DersId"]=dr["DersId"];
            Session["Yetki"] = dr["Yetki"];
            Response.Redirect("adminpanel.aspx");
        }
        else
        {
            Response.Write("<script>alert('Hatalı Giriş...')</script>");
        }
    }
}