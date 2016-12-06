<%@ Page Title="" Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeFile="kullaniciEkle.aspx.cs" Inherits="kullaniciEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="height:28px; color:#23282d;font-weight:400; font-size:23px;    margin:75px 0 25px 0;">Kullanıcı Ekle</div>
            <div style=" width:799px">
                <asp:TextBox ID="TextBox1" runat="server" CssClass="txtGorsel" Height="36px" Width="811px" placeholder="Kullanıcı Adı"></asp:TextBox>
                <asp:TextBox ID="TextBox2" runat="server" CssClass="txtGorsel" Height="36px" Width="811px" placeholder="Şifre"></asp:TextBox><br />
                <asp:DropDownList ID="DropDownList1" runat="server">
                </asp:DropDownList>
                <br />
                 <asp:DropDownList ID="DropDownList2" runat="server">
                     <asp:ListItem Value="yonetici">Yönetici</asp:ListItem>
                     <asp:ListItem Value="normal">Normal Hesap</asp:ListItem>
                </asp:DropDownList>
                <br /><br />
                 <asp:Button ID="btnkEkle" runat="server" CssClass="btnGorsel" Height="43px" Text="Kullanıcı Ekle" Width="177px" OnClick="btnkEkle_Click" />
            </div>
</asp:Content>

