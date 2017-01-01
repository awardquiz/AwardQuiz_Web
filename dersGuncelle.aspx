<%@ Page Title="" Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeFile="dersGuncelle.aspx.cs" Inherits="dersGuncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="height:28px; color:#23282d;font-weight:400; font-size:23px;    margin:75px 0 25px 0;">Ders Güncelle</div>
            <div style=" width:799px">
                <asp:TextBox ID="TextBox1" runat="server" CssClass="txtGorsel" Height="36px" Width="811px" placeholder="Ders Bilgisi"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Boş Değer Girilmez"></asp:RequiredFieldValidator><br />
                 <asp:Button ID="dersguncelle" runat="server" CssClass="btnGorsel" Height="43px" Text="Ders Güncelle" Width="177px" OnClick="dersguncelle_Click"   />
            </div>
</asp:Content>

