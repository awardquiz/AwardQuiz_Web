<%@ Page Title="" Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeFile="bilgiDuzenle.aspx.cs" Inherits="bilgiDuzenle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="Panel1" runat="server">
    <div style="height:28px; color:#23282d;font-weight:400; font-size:23px;    margin:75px 0 25px 0;">Bilgileri Güncelle</div>
            <div style=" width:799px">
                Kullanıcı Adı : <asp:Label ID="Label1" runat="server" Text="Label" Font-Bold="True" Font-Size="X-Large"></asp:Label>
                <br />
                <br />
                <asp:TextBox ID="TextBox3" runat="server" CssClass="txtGorsel" Height="36px" Width="811px" placeholder="Kullanıcı Adı"></asp:TextBox>
                <asp:TextBox ID="TextBox1" runat="server" CssClass="txtGorsel" Height="36px" Width="811px" placeholder="Şifre"></asp:TextBox>
                <asp:TextBox ID="TextBox2" runat="server" CssClass="txtGorsel" Height="36px" Width="811px" placeholder="Şifre Tekrarı"></asp:TextBox><br />

                <br />
                 <asp:Button ID="btnkEkle" runat="server" CssClass="btnGorsel" Height="43px" Text="Bilgileri Güncelle" Width="177px" OnClick="btnkEkle_Click"/>
            </div>
        </asp:Panel>

    <asp:Panel ID="Panel2" runat="server">

    </asp:Panel>
</asp:Content>

