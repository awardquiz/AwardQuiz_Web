using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class uniteDuzenle : System.Web.UI.Page
{
    esqlbaglantisi baglan = new esqlbaglantisi();
    string UniteId = "";
    string islem = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["yoneticiKullanici"] == null)
        {
            Response.Redirect("default.aspx");
        }

        UniteId = Request.QueryString["UniteId"];
        islem = Request.QueryString["islem"];

        if (islem == "sil")
        {
            SqlCommand cmdsil = new SqlCommand("delete from Unite where UniteId='" + UniteId + "'", baglan.baglan());
            cmdsil.ExecuteNonQuery();
        }

        SqlCommand getir = new SqlCommand("Select * from Unite ", baglan.baglan());
        SqlDataReader drkgetir = getir.ExecuteReader();
        DataList1.DataSource = drkgetir;
        DataList1.DataBind();
    }
}