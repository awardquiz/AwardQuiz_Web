<%@ Page Title="" Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeFile="erisimizinEkle.aspx.cs" Inherits="erisimizinEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

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
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <br />
    <br />
    <br />
    <h1>Bilgisayar Erişim İzin Kayıtı Ekle</h1>
    <br />
    <asp:DataList ID="DataList1" runat="server">
        <ItemTemplate>
            <h3>Erişim İzni Bitiş Tarihi :
                <asp:Label ID="Label2" runat="server" Text='<%# Eval("bitisTarihi") %>'></asp:Label></h3>
        </ItemTemplate>

    </asp:DataList>
    <br />

    <asp:TextBox ID="TextBox1" runat="server" CssClass="txtGorsel" Height="28px" Width="217px"></asp:TextBox>
    &nbsp;<img src="resim/edit.png" style="height: 32px; width: 32px" /><br />
    <br />
    <asp:Button ID="btnSave" runat="server" Text="Ekle" OnClick="btnSave_Click" CssClass="btnGorsel" Height="39px" Width="75px" />



</asp:Content>

