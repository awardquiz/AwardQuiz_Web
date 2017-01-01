using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class dersDuzenle : System.Web.UI.Page
{
    esqlbaglantisi baglan = new esqlbaglantisi();
    string DersId = "";
    string islem = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["yoneticiKullanici"] == null)
        {
            Response.Redirect("default.aspx");
        }

        DersId = Request.QueryString["DersId"];
        islem = Request.QueryString["islem"];

        if (islem == "sil")
        {
            SqlCommand cmdsil = new SqlCommand("delete from Dersler where DersId='" + DersId + "'", baglan.baglan());
            cmdsil.ExecuteNonQuery();
        }

        SqlCommand getir = new SqlCommand("Select * from Dersler ", baglan.baglan());
        SqlDataReader drkgetir = getir.ExecuteReader();
        DataList1.DataSource = drkgetir;
        DataList1.DataBind();
    }
}