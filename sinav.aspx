﻿<%@ Page Title="" Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeFile="sinav.aspx.cs" Inherits="sinav" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            width: 52px;
        }
        .auto-style9 {
            width: 769px;
        }
        .auto-style12 {
            width: 57px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div style="height: 28px; color: #23282d; font-weight: 400; font-size: 23px; margin: 75px 0 25px 0;">Sınav Oluşturucu</div>
    <table class="auto-style1">
        <tr>
            <td class="auto-style9">
                <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList></td>
        </tr>
        <tr>
            <td class="auto-style9">
                <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList></td>
        </tr>
        <tr>
            <td class="auto-style9">
                <asp:DropDownList ID="DropDownList3" runat="server"></asp:DropDownList></td>
        </tr>
        <tr>
            <td class="auto-style9">
                <br />
                <asp:Button ID="Button1" runat="server" CssClass="btnGorsel" Height="30px" Text="Getir" Width="78px" OnClick="Button1_Click" />
                <asp:Button ID="Button2" runat="server" CssClass="btnGorsel" Height="30px" Text="Getir" Width="78px" OnClick="Button2_Click" OnClientClick="form1.target='_blank';" />
                
                <br /></td>
        </tr>
    </table>

    
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                </tr>
            </table>
        
              <table class="auto-style1">
                <tr>
                    <td class="auto-style12">
                        <asp:CheckBoxList ID="CheckBoxList1" runat="server"></asp:CheckBoxList>
                        <br />
                       
                    </td>
                    
                </tr>
            </table>
       
</asp:Content>

