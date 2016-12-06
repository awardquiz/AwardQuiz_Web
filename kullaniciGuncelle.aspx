<%@ Page Title="" Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeFile="kullaniciGuncelle.aspx.cs" Inherits="kullaniciGuncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="height: 28px; color: #23282d; font-weight: 400; font-size: 23px; margin: 75px 0 25px 0;">Kullanıcı Güncelle</div>
    <div>
         <asp:TextBox ID="TextBox1" runat="server" Enabled="false" CssClass="txtGorsel" Height="36px" Width="715px" placeholder="Kullanıcı Adı"></asp:TextBox>
         <asp:TextBox ID="TextBox2" runat="server" CssClass="txtGorsel" Height="36px" Width="716px" placeholder="Şifre" TextMode="Password"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox3" ControlToValidate="TextBox2" ErrorMessage="Şifreler Aynı Olmalı !!"></asp:CompareValidator>
         <asp:TextBox ID="TextBox3" runat="server" CssClass="txtGorsel" Height="36px" Width="716px" placeholder="Şifre Tekrarı" TextMode="Password"></asp:TextBox>
             <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToCompare="TextBox2" ControlToValidate="TextBox3" ErrorMessage="Şifreler Aynı Olmalı !!"></asp:CompareValidator>

        <br />
         
         <br />
        <asp:Button ID="btnkguncelle" runat="server" CssClass="btnGorsel" Height="43px" Text="Bilgileri Güncelle" Width="177px" OnClick="btnkguncelle_Click" />
         <br />
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>

