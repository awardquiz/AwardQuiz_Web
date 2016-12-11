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
}