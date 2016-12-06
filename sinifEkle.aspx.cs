using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class sinifEkle : System.Web.UI.Page
{
    esqlbaglantisi baglan = new esqlbaglantisi();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["yoneticiKullanici"] == null)
        {
            Response.Redirect("default.aspx");
        }

    }



    protected void btnsinifEkle_Click(object sender, EventArgs e)
    {
        SqlCommand sinifekle = new SqlCommand("insert into Sinif (SinifAdi) values ('" + TextBox1.Text + "')", baglan.baglan());
        sinifekle.ExecuteNonQuery();
        TextBox1.Text = "";
    }
}