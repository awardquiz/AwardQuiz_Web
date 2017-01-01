<%@ Page Title="" Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeFile="dersDuzenle.aspx.cs" Inherits="dersDuzenle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 651px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div style="height: 28px; color: #23282d; font-weight: 400; font-size: 23px; margin-top: 55px;">Ders Düzenle
     </div><br />
    <asp:DataList ID="DataList1" runat="server" Width="774px" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Both">
        <FooterStyle BackColor="White" ForeColor="#000066" />
        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
        <HeaderTemplate>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">Ders</td>
                    <td>İşlem</td>
                </tr>
            </table>
        </HeaderTemplate>
        <ItemStyle ForeColor="#000066" />
        <ItemTemplate>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("DersAdi") %>'></asp:Label>
                    </td>
                    <td>
                       <a href="dersGuncelle.aspx?DersId=<%#Eval("DersId") %>"><img width="32" height="32" src="../resim/edit.png" /></a>
                        &nbsp;&nbsp;&nbsp;&nbsp;
                        <a href="dersDuzenle.aspx?DersId=<%#Eval("DersId") %>&islem=sil"><img width="32" height="32" src="../resim/delete.png" /></a>
                    </td>
                </tr>
            </table>
        </ItemTemplate>

        <SelectedItemStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />

    </asp:DataList>
</asp:Content>

