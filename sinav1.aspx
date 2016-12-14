
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="sinav1.aspx.cs" Inherits="sinav1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button1" runat="server" Text="İndir" OnClick="Button1_Click" />
        <br />
        <br />
        <br />
        <asp:Repeater ID="Repeater1" runat="server" EnableTheming="True">
       
            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%# Container.ItemIndex + 1 + "-)"%> ' Font-Bold="True" Font-Size="12"></asp:Label><asp:Label ID="Label2" runat="server" Text='<%# Eval("SoruBilgi") %>' Font-Bold="True" Font-Size="12"></asp:Label>
                                <br />
                                <asp:Label ID="Label4" runat="server" Text='<%# "A-)" + Eval("Secenek1") %>'></asp:Label>
                                <br />
                                <asp:Label ID="Label5" runat="server" Text='<%# "B-)" +  Eval("Secenek2") %>'></asp:Label>
                                <br />
                                <asp:Label ID="Label6" runat="server" Text='<%# "C-)" +  Eval("Secenek3") %>'></asp:Label>
                                <br />
                                <asp:Label ID="Label7" runat="server" Text='<%# "D-)" +  Eval("Secenek4") %>'></asp:Label>
                                   <br /><br />
                            </ItemTemplate>
        </asp:Repeater>
    </div>
    </form>
</body>
</html>
