using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class kullaniciEkle : System.Web.UI.Page
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
            SqlCommand ders_getir = new SqlCommand("select * from Dersler", baglan.baglan());
            SqlDataReader drders_getir = ders_getir.ExecuteReader();
            DropDownList1.DataTextField = "DersAdi";
            DropDownList1.DataValueField = "DersId";
            DropDownList1.DataSource = drders_getir;
            DropDownList1.DataBind();
        }
    }
    protected void btnkEkle_Click(object sender, EventArgs e)
    {
        if (DropDownList2.SelectedValue=="yonetici")
        {
            SqlCommand kulekle = new SqlCommand("insert into Yonetici (yoneticiKullanici,yoneticiSifre,dersId,Yetki) values ('" + TextBox1.Text + "','" + TextBox2.Text + "','0','1')", baglan.baglan());
            kulekle.ExecuteNonQuery();
        }
        else
        {
            SqlCommand kulekle = new SqlCommand("insert into Yonetici (yoneticiKullanici,yoneticiSifre,dersId,Yetki) values ('" + TextBox1.Text + "','" + TextBox2.Text + "','"+DropDownList1.SelectedValue+"','0')", baglan.baglan());
            kulekle.ExecuteNonQuery();
        }
        

    }
}