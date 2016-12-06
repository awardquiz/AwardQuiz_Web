using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class kullaniciDuzenle : System.Web.UI.Page
{
    esqlbaglantisi baglan = new esqlbaglantisi();
    string yoneticiId="";
    string islem="";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["yoneticiKullanici"] == null)
        {
            Response.Redirect("default.aspx");
        }

        yoneticiId = Request.QueryString["yoneticiId"];
        islem = Request.QueryString["islem"];

        if (islem == "sil")
        {
            SqlCommand cmdsil = new SqlCommand("delete from Yonetici where yoneticiId='" + yoneticiId + "'", baglan.baglan());
            cmdsil.ExecuteNonQuery();
        }

        SqlCommand kgetir = new SqlCommand("select * from Yonetici ", baglan.baglan());
        SqlDataReader drkgetir = kgetir.ExecuteReader();
        DataList1.DataSource = drkgetir;
        DataList1.DataBind();
    }
}