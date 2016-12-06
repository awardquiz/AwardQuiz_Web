using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Net;
public partial class sinav1 : System.Web.UI.Page
{
    esqlbaglantisi baglan = new esqlbaglantisi();
    string idler = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        idler = Request.QueryString["idler"];
       

        SqlCommand kgetir;

        kgetir = new SqlCommand("select * from Sorular where SoruId IN (" + idler + ") ", baglan.baglan());

        Repeater1.DataSource = kgetir.ExecuteReader();
        Repeater1.DataBind();

        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Button1.Visible = false;
        Response.AddHeader("content-disposition", "attachment;filename=sinav.doc");
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        Response.ContentEncoding = System.Text.Encoding.GetEncoding("ISO-8859-9");
        Response.Charset = "ISO-8859-9";
        Response.ContentType = "application/vnd.word";
        System.IO.StringWriter stringWrite = new System.IO.StringWriter();
        System.Web.UI.HtmlTextWriter htmlWrite = new HtmlTextWriter(stringWrite); 
    }
   
}