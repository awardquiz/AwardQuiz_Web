<%@ Page Title="" Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeFile="erisimizinEkle.aspx.cs" Inherits="erisimizinEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
<script src="Scripts/jquery-1.4.1.min.js" type="text/javascript"></script>
<script src="Scripts/jquery.dynDateTime.min.js" type="text/javascript"></script>
<script src="Scripts/calendar-en.min.js" type="text/javascript"></script>
<link href="Styles/calendar-blue.css" rel="stylesheet" type="text/css" />
<script type="text/javascript">
    $(document).ready(function () {
        $("#<%=TextBox1.ClientID %>").dynDateTime({
            showsTime: true,
            ifFormat: "%Y/%m/%d %H:%M",
            daFormat: "%l;%M %p, %e %m, %Y",
            align: "BR",
            electric: false,
            singleClick: false,
            displayArea: ".siblings('.dtcDisplayArea')",
            button: ".next()"
        });
    });
</script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br /><br /><br />
    <h1>Bilgisayar Erişim İzin Kayıtı Ekle</h1>
    
    <% if (false){ %>
    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
<asp:TextBox ID="TextBox1" runat="server" ReadOnly = "true"></asp:TextBox>
<img src="resim/edit.png" style="height: 30px; width: 30px" />
    <br />
<asp:Button ID="btnSave" runat="server" Text="Ekle" onclick="btnSave_Click" />
    <%}else{ %>

    <h2>Aktif erişim izni bulunmaktadır. Erişim izin süresi bittikten sonra yeni kayıt girebilirsiniz.</h2>
    <%} %>
    </asp:Content>

