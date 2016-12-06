using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
      
    }
   

    protected void GenerateMsWordDoc(object sender, EventArgs e)
    {
        string strBody = "<html>" +
            "<body>" +
                "<div>Your name is: <b>" + txtName.Text + "</b></div>" +
               
                "Ms Word document generated successfully." +
            "</body>" +
            "</html>";
        string fileName = "dosya.doc";
        // You can add whatever you want to add as the HTML and it will be generated as Ms Word docs
        Response.AppendHeader("Content-Type", "application/msword");
        Response.AppendHeader("Content-disposition", "attachment; filename=" + fileName);
        Response.Write(strBody);
    }
}