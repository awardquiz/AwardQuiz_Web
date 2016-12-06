<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" runat="server" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
   <div>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
      
        <asp:Button ID="btn" runat="server" OnClick="GenerateMsWordDoc" Text="Generate Ms Word Document" />
    </div>
    </form>
</body>
</html>


