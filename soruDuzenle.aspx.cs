using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class soruDuzenle : System.Web.UI.Page
{
    esqlbaglantisi baglan = new esqlbaglantisi();
    string SoruId = "";
    string islem = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            SqlCommand sinif_getir = new SqlCommand("select * from Sinif", baglan.baglan());
            SqlDataReader drsinif_getir = sinif_getir.ExecuteReader();
            DropDownList1.DataTextField = "SinifAdi";
            DropDownList1.DataValueField = "SinifId";
            DropDownList1.DataSource = drsinif_getir;
            DropDownList1.DataBind();

           

            SqlCommand unite_getir = new SqlCommand("select * from Unite", baglan.baglan());
            SqlDataReader drunite_getir = unite_getir.ExecuteReader();
            DropDownList2.DataTextField = "UniteIsım";
            DropDownList2.DataValueField = "UniteId";
            DropDownList2.DataSource = drunite_getir;
            DropDownList2.DataBind();


        }


        if (Session["yoneticiKullanici"] == null)
        {
            Response.Redirect("default.aspx");
        }

        SoruId = Request.QueryString["SoruId"];
        islem = Request.QueryString["islem"];

        if (islem == "sil")
        {
            SqlCommand cmdsil = new SqlCommand("delete from Sorular where SoruId='" + SoruId + "'", baglan.baglan());
            cmdsil.ExecuteNonQuery();
        }
        if (Convert.ToString(Session["Yetki"]) == "1")
        {
            SqlCommand kgetir = new SqlCommand("select * from Sorular", baglan.baglan());
            SqlDataReader drkgetir = kgetir.ExecuteReader();
            DataList1.DataSource = drkgetir;
            DataList1.DataBind();
        }
        else
        {
            SqlCommand kgetir = new SqlCommand("select * from Sorular where DersId='" + Session["DersId"] + "' ", baglan.baglan());
            SqlDataReader drkgetir = kgetir.ExecuteReader();
            DataList1.DataSource = drkgetir;
            DataList1.DataBind();
        }
       
    }
   
    protected void btn_soruEkle_Click(object sender, EventArgs e)
    {
        if (Convert.ToString(Session["Yetki"]) == "1")
        {
            SqlCommand kgetir = new SqlCommand("select * from Sorular where SinifId='" + DropDownList1.SelectedValue + "' and UniteId='" + DropDownList2.SelectedValue + "'", baglan.baglan());
            SqlDataReader drkgetir = kgetir.ExecuteReader();
            DataList1.DataSource = drkgetir;
            DataList1.DataBind();
        }
        else
        {
            SqlCommand kgetir = new SqlCommand("select * from Sorular where SinifId='" + DropDownList1.SelectedValue + "' and UniteId='" + DropDownList2.SelectedValue + "'and  DersId='" + Session["DersId"] + "' ", baglan.baglan());
            SqlDataReader drkgetir = kgetir.ExecuteReader();
            DataList1.DataSource = drkgetir;
            DataList1.DataBind();
        }
    }
}