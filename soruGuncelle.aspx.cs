using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class soruGuncelle : System.Web.UI.Page
{
    esqlbaglantisi baglan = new esqlbaglantisi();
    string SoruId = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["yoneticiKullanici"] == null)
        {
            Response.Redirect("default.aspx");
        }
        SoruId = Request.QueryString["SoruId"];

        if (Page.IsPostBack == false)
        {
            SqlCommand sinif_getir = new SqlCommand("select * from Sinif", baglan.baglan());
            SqlDataReader drsinif_getir = sinif_getir.ExecuteReader();
            DropDownList1.DataTextField = "SinifAdi";
            DropDownList1.DataValueField = "SinifId";
            DropDownList1.DataSource = drsinif_getir;
            DropDownList1.DataBind();

            if (Convert.ToString(Session["Yetki"]) == "1")
            {
                SqlCommand ders_getir = new SqlCommand("SELECT * FROM Dersler", baglan.baglan());
                SqlDataReader drders_getir = ders_getir.ExecuteReader();
                DropDownList2.DataSource = drders_getir;
            }
            else
            {
                SqlCommand ders_getir = new SqlCommand("SELECT * FROM Dersler INNER JOIN Yonetici ON Dersler.DersId = Yonetici.DersId where Dersler.DersId='" + Session["DersId"] + "'", baglan.baglan());
                SqlDataReader drders_getir = ders_getir.ExecuteReader();
                DropDownList2.DataSource = drders_getir;
            }

            DropDownList2.DataTextField = "DersAdi";
            DropDownList2.DataValueField = "DersId";
            DropDownList2.DataBind();

            SqlCommand unite_getir = new SqlCommand("select * from Unite", baglan.baglan());
            SqlDataReader drunite_getir = unite_getir.ExecuteReader();
            DropDownList3.DataTextField = "UniteIsım";
            DropDownList3.DataValueField = "UniteId";
            DropDownList3.DataSource = drunite_getir;
            DropDownList3.DataBind();


        }


        if (Page.IsPostBack == false)
        {
            SqlCommand cmkguncelle = new SqlCommand("Select * from Sorular where SoruId = '" + SoruId + "'", baglan.baglan());
            SqlDataReader drkguncelle = cmkguncelle.ExecuteReader();
            DataTable dtkguncelle = new DataTable("tablo");
            dtkguncelle.Load(drkguncelle);
            DataRow row = dtkguncelle.Rows[0];
            TextBox1.Text = row["SoruBilgi"].ToString();
            TextBox2.Text = row["Secenek1"].ToString();
            TextBox3.Text = row["Secenek2"].ToString();
            TextBox4.Text = row["Secenek3"].ToString();
            TextBox5.Text = row["Secenek4"].ToString();
            Label1.Text = row["Cevap"].ToString();
        }
    }


    protected void btn_soruEkle_Click(object sender, EventArgs e)
    {
        if (RadioButtonList1.SelectedIndex == 0)
        {
            SqlCommand cmkguncelle = new SqlCommand("update Sorular Set SinifId='" + DropDownList1.SelectedValue + "',DersId='" + DropDownList2.SelectedValue + "', UniteId='" + DropDownList3.SelectedValue + "',SoruBilgi='" + TextBox1.Text.Trim().ToString().Replace("'", "''") + "',Secenek1='" + TextBox2.Text.Trim().ToString().Replace("'", "''") + "',Secenek2='" + TextBox3.Text.Trim().ToString().Replace("'", "''") + "',Secenek3='" + TextBox4.Text.Trim().ToString().Replace("'", "''") + "',Secenek4='" + TextBox5.Text.Trim().ToString().Replace("'", "''") + "',cevap='" + TextBox2.Text.Trim().ToString().Replace("'", "''") + "'  where SoruId='" + SoruId + "'", baglan.baglan());
            cmkguncelle.ExecuteNonQuery();
        }
        else if (RadioButtonList1.SelectedIndex == 1)
        {
            SqlCommand cmkguncelle = new SqlCommand("update Sorular Set SinifId='" + DropDownList1.SelectedValue + "',DersId='" + DropDownList2.SelectedValue + "', UniteId='" + DropDownList3.SelectedValue + "',SoruBilgi='" + TextBox1.Text.Trim().ToString().Replace("'", "''") + "',Secenek1='" + TextBox2.Text.Trim().ToString().Replace("'", "''") + "',Secenek2='" + TextBox3.Text.Trim().ToString().Replace("'", "''") + "',Secenek3='" + TextBox4.Text.Trim().ToString().Replace("'", "''") + "',Secenek4='" + TextBox5.Text.Trim().ToString().Replace("'", "''") + "',cevap='" + TextBox3.Text.Trim().ToString().Replace("'", "''") + "'  where SoruId='" + SoruId + "'", baglan.baglan());
            cmkguncelle.ExecuteNonQuery();
        }
        else if (RadioButtonList1.SelectedIndex == 2)
        {
            SqlCommand cmkguncelle = new SqlCommand("update Sorular Set SinifId='" + DropDownList1.SelectedValue + "',DersId='" + DropDownList2.SelectedValue + "', UniteId='" + DropDownList3.SelectedValue + "',SoruBilgi='" + TextBox1.Text.Trim().ToString().Replace("'", "''") + "',Secenek1='" + TextBox2.Text.Trim().ToString().Replace("'", "''") + "',Secenek2='" + TextBox3.Text.Trim().ToString().Replace("'", "''") + "',Secenek3='" + TextBox4.Text.Trim().ToString().Replace("'", "''") + "',Secenek4='" + TextBox5.Text.Trim().ToString().Replace("'", "''") + "',cevap='" + TextBox4.Text.Trim().ToString().Replace("'", "''") + "'  where SoruId='" + SoruId + "'", baglan.baglan());
            cmkguncelle.ExecuteNonQuery();
        }
        else if (RadioButtonList1.SelectedIndex == 3)
        {
            SqlCommand cmkguncelle = new SqlCommand("update Sorular Set SinifId='" + DropDownList1.SelectedValue + "',DersId='" + DropDownList2.SelectedValue + "', UniteId='" + DropDownList3.SelectedValue + "',SoruBilgi='" + TextBox1.Text.Trim().ToString().Replace("'", "''") + "',Secenek1='" + TextBox2.Text.Trim().ToString().Replace("'", "''") + "',Secenek2='" + TextBox3.Text.Trim().ToString().Replace("'", "''") + "',Secenek3='" + TextBox4.Text.Trim().ToString().Replace("'", "''") + "',Secenek4='" + TextBox5.Text.Trim().ToString().Replace("'", "''") + "',cevap='" + TextBox5.Text.Trim().ToString().Replace("'", "''") + "'  where SoruId='" + SoruId + "'", baglan.baglan());
            cmkguncelle.ExecuteNonQuery();
        }
        else
        {
            SqlCommand cmkguncelle = new SqlCommand("update Sorular Set SinifId='" + DropDownList1.SelectedValue + "',DersId='" + DropDownList2.SelectedValue + "', UniteId='" + DropDownList3.SelectedValue + "',SoruBilgi='" + TextBox1.Text.Trim().ToString().Replace("'", "''") + "',Secenek1='" + TextBox2.Text.Trim().ToString().Replace("'", "''") + "',Secenek2='" + TextBox3.Text.Trim().ToString().Replace("'", "''") + "',Secenek3='" + TextBox4.Text.Trim().ToString().Replace("'", "''") + "',Secenek4='" + TextBox5.Text.Trim().ToString().Replace("'", "''") + "',cevap='" + TextBox5.Text.Trim().ToString().Replace("'", "''") + "'  where SoruId='" + SoruId + "'", baglan.baglan());
            cmkguncelle.ExecuteNonQuery();
        }
        Response.Redirect("soruDuzenle.aspx");
    }
}