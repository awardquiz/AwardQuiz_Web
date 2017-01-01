using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class erisimizinEkle : System.Web.UI.Page
{
    esqlbaglantisi baglan = new esqlbaglantisi();
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["yoneticiKullanici"] == null && (Convert.ToString(Session["Yetki"]) == "1"))
        {
            Response.Redirect("default.aspx");
        }

        SqlCommand getir = new SqlCommand("Select top 1 * from Erisimizin order by izinId desc", baglan.baglan());
        SqlDataReader drkgetir = getir.ExecuteReader();
        DataList1.DataSource = drkgetir;
        DataList1.DataBind();
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        //DateTime dob = DateTime.Parse(Request.Form[TextBox1.UniqueID]);
        SqlCommand ekle = new SqlCommand("insert into Erisimizin (bitisTarihi) values ('" + TextBox1.Text + "')", baglan.baglan());
        ekle.ExecuteNonQuery();
        Response.Redirect("erisimizinEkle.aspx");
    }
}