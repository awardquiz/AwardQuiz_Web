<%@ Page Title="" Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeFile="kullaniciDuzenle.aspx.cs" Inherits="kullaniciDuzenle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }

        .auto-style2 {
            width: 242px;
        }

        .auto-style3 {
            width: 246px;
            color:white;
        }

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div style="height: 28px; color: #23282d; font-weight: 400; font-size: 23px; margin: 75px 0 25px 0;">Kullanıcı Düzenle</div>
    <asp:DataList ID="DataList1" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Both">
        <HeaderStyle BackColor="#006699" Font-Bold="True" />
        <HeaderTemplate>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">Kullanıcı Adı</td>
                    <td class="auto-style3">İşlem</td>

                </tr>
            </table>
        </HeaderTemplate>
         <ItemStyle ForeColor="#000066" />
        <ItemTemplate>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">

                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("yoneticiKullanici") %>'></asp:Label>
                    </td>
                    <td>
                        <a href="kullaniciGuncelle.aspx?yoneticiId=<%#Eval("yoneticiId") %>">
                            <img width="32" height="32" src="../resim/edit.png" /></a>
                         &nbsp;&nbsp;
                         <a href="kullaniciduzenle.aspx?yoneticiId=<%#Eval("yoneticiId") %>&islem=sil"><img width="32" height="32" src="../resim/delete.png" /></a>
                    </td>
                </tr>
            </table>
        </ItemTemplate>
        <SelectedItemStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
    </asp:DataList>
</asp:Content>

