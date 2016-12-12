<%@ Page Title="" Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeFile="soruDuzenle.aspx.cs" Inherits="soruDuzenle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }

        .auto-style2 {
            width: 84%;
            padding:10px;
        }

        .auto-style3 {
            width: 90%;
            color:white;
        }

        .auto-style4 {
            width: 7%;
            color: white;
        }

        .auto-style5 {
            width: 4%;
            padding: 10px;
        }
        .auto-style6 {
            width: 85%;
            color: white;
        }

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="height: 28px; color: #23282d; font-weight: 400; font-size: 23px; margin: 75px 0 25px 0;">Soru Düzenle</div>
    <div style="padding:5px; margin:5px;">
        <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
        <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList>
        <asp:Button ID="btn_soruEkle" runat="server" CssClass="btnGorsel" Height="38px" Text="Filtrele" Width="100px" OnClick="btn_soruEkle_Click" />
    </div>

    <asp:DataList ID="DataList1" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Both" Width="90%">
        <HeaderStyle BackColor="#006699" Font-Bold="True" />
        <HeaderTemplate>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style4">Sıra</td>
                    <td class="auto-style6">Soru</td>
                    <td class="auto-style3">İşlem</td>

                </tr>
            </table>
        </HeaderTemplate>
         <ItemStyle ForeColor="#000066" />
        <ItemTemplate>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style5"><asp:Label ID="Label2" runat="server" Text='<%# Container.ItemIndex + 1 %>'></asp:Label></td>
                    <td class="auto-style2"><asp:Label ID="Label1" runat="server" Text='<%# Eval("SoruBilgi").ToString() %>'></asp:Label></td>
                    <td>
                        <a href="soruGuncelle.aspx?SoruId=<%#Eval("SoruId") %>">
                            <img width="32" height="32" src="../resim/edit.png" /></a>
                         &nbsp;&nbsp;
                         <a href="soruDuzenle.aspx?SoruId=<%#Eval("SoruId") %>&islem=sil"><img width="32" height="32" src="../resim/delete.png" /></a>
                    </td>
                </tr>
            </table>
        </ItemTemplate>
        <SelectedItemStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
    </asp:DataList>
</asp:Content>

