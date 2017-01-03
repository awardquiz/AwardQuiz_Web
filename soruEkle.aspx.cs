using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class soruEkle : System.Web.UI.Page
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
    }

    public void bosalt()
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
    }
    protected void btn_soruEkle_Click(object sender, EventArgs e)
    {
        if (RadioButtonList1.SelectedIndex == 0)
        {
            SqlCommand ekle = new SqlCommand("insert into Sorular (SoruBilgi,Secenek1,Secenek2,Secenek3,Secenek4,Cevap,Derece,SinifId,DersId,UniteId) values ('" + TextBox1.Text.Trim().ToString().Replace("'", "''") + "','" + TextBox2.Text.Trim().ToString().Replace("'", "''") + "','" + TextBox3.Text.Trim().ToString().Replace("'", "''") + "','" + TextBox4.Text.Trim().ToString().Replace("'", "''") + "','" + TextBox5.Text.Trim().ToString().Replace("'", "''") + "','" + TextBox2.Text.Trim().ToString().Replace("'", "''") + "','" + DropDownList4.SelectedValue + "','" + DropDownList1.SelectedValue + "','" + DropDownList2.SelectedValue + "','" + DropDownList3.SelectedValue + "')", baglan.baglan());
            ekle.ExecuteNonQuery();
        }
        else if (RadioButtonList1.SelectedIndex == 1)
        {
            SqlCommand ekle = new SqlCommand("insert into Sorular (SoruBilgi,Secenek1,Secenek2,Secenek3,Secenek4,Cevap,Derece,SinifId,DersId,UniteId) values ('" + TextBox1.Text.Trim().ToString().Replace("'", "''") + "','" + TextBox2.Text.Trim().ToString().Replace("'", "''") + "','" + TextBox3.Text.Trim().ToString().Replace("'", "''") + "','" + TextBox4.Text.Trim().ToString().Replace("'", "''") + "','" + TextBox5.Text.Trim().ToString().Replace("'", "''") + "','" + TextBox3.Text.Trim().ToString().Replace("'", "''") + "','" + DropDownList4.SelectedValue + "','" + DropDownList1.SelectedValue + "','" + DropDownList2.SelectedValue + "','" + DropDownList3.SelectedValue + "')", baglan.baglan());
            ekle.ExecuteNonQuery();
        }
        else if (RadioButtonList1.SelectedIndex == 2)
        {
            SqlCommand ekle = new SqlCommand("insert into Sorular (SoruBilgi,Secenek1,Secenek2,Secenek3,Secenek4,Cevap,Derece,SinifId,DersId,UniteId) values ('" + TextBox1.Text.Trim().ToString().Replace("'", "''") + "','" + TextBox2.Text.Trim().ToString().Replace("'", "''") + "','" + TextBox3.Text.Trim().ToString().Replace("'", "''") + "','" + TextBox4.Text.Trim().ToString().Replace("'", "''") + "','" + TextBox5.Text.Trim().ToString().Replace("'", "''") + "','" + TextBox4.Text.Trim().ToString().Replace("'", "''") + "','" + DropDownList4.SelectedValue + "','" + DropDownList1.SelectedValue + "','" + DropDownList2.SelectedValue + "','" + DropDownList3.SelectedValue + "')", baglan.baglan());
            ekle.ExecuteNonQuery();
        }
        else
        {
            SqlCommand ekle = new SqlCommand("insert into Sorular (SoruBilgi,Secenek1,Secenek2,Secenek3,Secenek4,Cevap,Derece,SinifId,DersId,UniteId) values ('" + TextBox1.Text.Trim().ToString().Replace("'", "''") + "','" + TextBox2.Text.Trim().ToString().Replace("'", "''") + "','" + TextBox3.Text.Trim().ToString().Replace("'", "''") + "','" + TextBox4.Text.Trim().ToString().Replace("'", "''") + "','" + TextBox5.Text.Trim().ToString().Replace("'", "''") + "','" + TextBox5.Text.Trim().ToString().Replace("'", "''") + "','" + DropDownList4.SelectedValue + "','" + DropDownList1.SelectedValue + "','" + DropDownList2.SelectedValue + "','" + DropDownList3.SelectedValue + "')", baglan.baglan());
            ekle.ExecuteNonQuery();
        }
        bosalt();

    }

}