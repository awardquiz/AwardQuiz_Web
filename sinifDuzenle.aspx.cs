using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class sinifDuzenle : System.Web.UI.Page
{
    esqlbaglantisi baglan = new esqlbaglantisi();
    string SinifId = "";
    string islem = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["yoneticiKullanici"] == null)
        {
            Response.Redirect("default.aspx");
        }

        SinifId = Request.QueryString["SinifId"];
        islem = Request.QueryString["islem"];

        if (islem == "sil")
        {
            SqlCommand cmdsil = new SqlCommand("delete from Sinif where SinifId='" + SinifId + "'", baglan.baglan());
            cmdsil.ExecuteNonQuery();
        }

        SqlCommand getir = new SqlCommand("Select * from Sinif", baglan.baglan());
        SqlDataReader drkgetir = getir.ExecuteReader();
        DataList1.DataSource = drkgetir;
        DataList1.DataBind();
    }
}