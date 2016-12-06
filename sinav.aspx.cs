using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class sinav : System.Web.UI.Page
{
    esqlbaglantisi baglan = new esqlbaglantisi();

    protected void Page_Load(object sender, EventArgs e)
    {

        //if (Session["yoneticiKullanici"] == null)
        //{
        //    Response.Redirect("default.aspx");
        //}
        //if (Convert.ToString(Session["Yetki"]) != "1")
        //{
        //    Response.Redirect("adminpanel.aspx");
        //}

        if (Page.IsPostBack == false)
        {
            SqlCommand sinif_getir = new SqlCommand("select * from Sinif", baglan.baglan());
            SqlDataReader drsinif_getir = sinif_getir.ExecuteReader();
            DropDownList1.DataTextField = "SinifAdi";
            DropDownList1.DataValueField = "SinifId";
            DropDownList1.DataSource = drsinif_getir;
            DropDownList1.DataBind();

            SqlCommand ders_getir = new SqlCommand("SELECT * FROM Dersler", baglan.baglan());
            SqlDataReader drders_getir = ders_getir.ExecuteReader();
            DropDownList2.DataSource = drders_getir;

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
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlCommand getir = new SqlCommand("SELECT * FROM Dersler INNER JOIN Sorular ON Dersler.DersId = Sorular.DersId INNER JOIN Unite ON Sorular.UniteId = Unite.UniteId INNER JOIN Sinif ON Sorular.SinifId = Sinif.SinifId where Sinif.SinifId='" + DropDownList1.SelectedValue + "'", baglan.baglan());
        SqlDataReader drkgetir = getir.ExecuteReader();
        CheckBoxList1.DataTextField = "SoruBilgi";
        CheckBoxList1.DataValueField = "SoruId";
        CheckBoxList1.DataSource = drkgetir;
        CheckBoxList1.DataBind();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        string parametre = "";
        int sira = 0;
        for (int i = 0; i < CheckBoxList1.Items.Count; i++)
        {
            if (CheckBoxList1.Items[i].Selected)
            {
                sira++;
                if (sira > 1)
                {
                    parametre += ",";
                }
                parametre += CheckBoxList1.Items[i].Value;
                
            }
        }

        Response.Redirect("sinav1.aspx?idler="+parametre);



  
    }
   
   
}