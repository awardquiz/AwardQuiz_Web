<%@ Page Title="" Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeFile="ayarlar.aspx.cs" Inherits="dersDuzenle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 130px;
        }
    </style>
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div style="height: 28px; color: #23282d; font-weight: 400; font-size: 23px; margin-top: 55px;">Ayarlar</div><br />
     <table class="auto-style1">
         <tr>
             <td class="auto-style2">Doğru Sayısı :</td>
             <td>
            <asp:TextBox ID="TextBox1" runat="server" CssClass="txtGorsel" Height="26px" Width="189px"></asp:TextBox>** En az kaç doğru ?
             </td>
         </tr>
         <tr>
             <td class="auto-style2">Süre(dk) :
            </td>
             <td>
            <asp:TextBox ID="TextBox3" runat="server" CssClass="txtGorsel" Height="26px" Width="188px"></asp:TextBox>** Her doğruya verilen süre dakika cinsinden</td>
         </tr>
         <tr>
             <td class="auto-style2">Şifre :
            </td>
             <td>
            <asp:TextBox ID="TextBox2" runat="server" CssClass="txtGorsel" Height="26px" Width="188px"></asp:TextBox>** Programı devre dışı bırakacak şifre</td>
         </tr>
         <tr>
             <td class="auto-style2">Soru Sayısı :
            </td>
             <td>
            <asp:TextBox ID="TextBox4" runat="server" CssClass="txtGorsel" Height="26px" Width="188px"></asp:TextBox>** Testte kaç soru gözüksün</td>
         </tr>
     </table>
     <br /><br />
            <asp:Button ID="ayarla" runat="server" CssClass="btnGorsel" Height="43px" Text="Ayarla" Width="177px" OnClick="ayarla_Click"  />

</asp:Content>

