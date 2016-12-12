<%@ Page Title="" Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeFile="soruGuncelle.aspx.cs" Inherits="soruGuncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div style="height: 28px; color: #23282d; font-weight: 400; font-size: 23px; margin-top: 55px;">Yeni Soru Ekle</div>
    <div style="height: 19px; width: 799px"></div>


    <table class="auto-style1">

        <tr>
            <p>
                <td class="auto-style2">
                    <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
                &nbsp;</p>
            <br />
            <p>
                <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList>
            </p>
            <br />
            <p>
                <asp:DropDownList ID="DropDownList3" runat="server"></asp:DropDownList>
            <p>&nbsp;</p>

        </tr>

        <tr>
            <td class="auto-style6">
                <asp:TextBox ID="TextBox1" runat="server" CssClass="txtGorsel" Height="36px" Width="811px" placeholder="Soru Bilgisi"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Boş Değer Girilmez"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">
                <asp:TextBox ID="TextBox2" runat="server" CssClass="txtGorsel" Height="36px" Width="811px" placeholder="Seçenek"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Boş Değer Girilmez"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">
                <asp:TextBox ID="TextBox3" runat="server" CssClass="txtGorsel" Height="36px" Width="812px" placeholder="Seçenek"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="Boş Değer Girilmez"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">
                <asp:TextBox ID="TextBox4" runat="server" CssClass="txtGorsel" Height="36px" Width="811px" placeholder="Seçenek"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" ErrorMessage="Boş Değer Girilmez"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">
                <asp:TextBox ID="TextBox5" runat="server" CssClass="txtGorsel" Height="36px" Width="810px" placeholder="Seçenek"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox5" ErrorMessage="Boş Değer Girilmez"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <!--<asp:FileUpload ID="FileUpload1" runat="server" CssClass="txtGorsel" Width="814px" />-->
            </td>
        </tr>
        <tr>
            <td>
               Önceki Cevap :  <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                <br />
            </td>
        </tr>
        <tr>
            <td>
                <br />
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" Height="21px" RepeatDirection="Horizontal" Width="298px">
                    <asp:ListItem>A</asp:ListItem>
                    <asp:ListItem>B</asp:ListItem>
                    <asp:ListItem>C</asp:ListItem>
                    <asp:ListItem>D</asp:ListItem>
                </asp:RadioButtonList>
                <br />
                <asp:Button ID="btn_soruEkle" runat="server" CssClass="btnGorsel" Height="43px" Text="Soru Ekle" Width="177px" OnClick="btn_soruEkle_Click"  />
                <br />
                <br />
                <br />
                <br />
            </td>
        </tr>

    </table>
</asp:Content>

