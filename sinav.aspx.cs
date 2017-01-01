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
        label1.Visible = false;
        label2.Visible = false;
        label3.Visible = false;
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

            


        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
       
        label1.Visible = true;
        label2.Visible = true;
        label3.Visible = true;

        SqlCommand kolaygetir = new SqlCommand("SELECT * from Sorular where SinifId='" + DropDownList1.SelectedValue + "' and DersId='"+DropDownList2.SelectedValue+"' and Derece='0'", baglan.baglan());
        SqlDataReader kdrkgetir = kolaygetir.ExecuteReader();
        CheckBoxList1.DataTextField = "SoruBilgi";
        CheckBoxList1.DataValueField = "SoruId";
        CheckBoxList1.DataSource = kdrkgetir;
        CheckBoxList1.DataBind();

        SqlCommand ortagetir = new SqlCommand("SELECT * from Sorular where SinifId='" + DropDownList1.SelectedValue + "' and DersId='" + DropDownList2.SelectedValue + "' and Derece='1'", baglan.baglan());
        SqlDataReader odrkgetir = ortagetir.ExecuteReader();
        CheckBoxList2.DataTextField = "SoruBilgi";
        CheckBoxList2.DataValueField = "SoruId";
        CheckBoxList2.DataSource = odrkgetir;
        CheckBoxList2.DataBind();

        SqlCommand zorgetir = new SqlCommand("SELECT * from Sorular where SinifId='" + DropDownList1.SelectedValue + "' and DersId='" + DropDownList2.SelectedValue + "' and Derece='2'", baglan.baglan());
        SqlDataReader zdrkgetir = zorgetir.ExecuteReader();
        CheckBoxList3.DataTextField = "SoruBilgi";
        CheckBoxList3.DataValueField = "SoruId";
        CheckBoxList3.DataSource = zdrkgetir;
        CheckBoxList3.DataBind();
        
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

        for (int i = 0; i < CheckBoxList2.Items.Count; i++)
        {
            if (CheckBoxList2.Items[i].Selected)
            {
                sira++;
                if (sira > 1)
                {
                    parametre += ",";
                }
                parametre += CheckBoxList2.Items[i].Value;

            }
        }

        for (int i = 0; i < CheckBoxList3.Items.Count; i++)
        {
            if (CheckBoxList3.Items[i].Selected)
            {
                sira++;
                if (sira > 1)
                {
                    parametre += ",";
                }
                parametre += CheckBoxList3.Items[i].Value;

            }
        }

        Response.Redirect("sinav1.aspx?idler="+parametre);



  
    }
   
   
}