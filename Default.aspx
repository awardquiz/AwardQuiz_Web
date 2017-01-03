<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="admin_Default" %>

<!DOCTYPE html>
<head runat="server">
    <title></title>
    <style type="text/css">
        #login {
            width: 400px;
            margin: 0 auto;
            margin-top: 180px;
            margin-bottom: 2%;
            transition: opacity 1s;
            -webkit-transition: opacity 1s;
            background-color: #fff;
        }

            #login h1 {
                background: #3399cc;
                padding: 20px 0;
                font-size: 140%;
                font-weight: 300;
                text-align: center;
                color: #fff;
            }

        #txt_kadi, #txt_sifre {
            width: 91.5%;
            background: #fff;
            margin-bottom: 4%;
            border: 1px solid #ccc;
            padding: 4%;
            font-family: 'Open Sans',sans-serif;
            font-size: 95%;
            color: #555;
        }

        #btn_giris {
            width: 100%;
            background: #3399cc;
            border: 0;
            padding: 4%;
            font-family: 'Open Sans',sans-serif;
            font-size: 100%;
            color: #fff;
            cursor: pointer;
            transition: background .3s;
            -webkit-transition: background .3s;
        }

            #btn_giris:hover {
                background: #2288bb;
            }

        body {
            background: #567;
            font-family: 'Open Sans',sans-serif;
        }

        form {
            background-color: #567;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="login">
            <h1>Yönetici Giriş Paneli</h1>
            <asp:TextBox ID="txt_kadi" runat="server" placeholder="Kullanıcı Adı"></asp:TextBox>
            <asp:TextBox ID="txt_sifre" runat="server" placeholder="Şifre" TextMode="Password"></asp:TextBox>
            <asp:Button ID="btn_giris" runat="server" Text="Giriş Yap" OnClick="btn_giris_Click" />
        </div>
    </form>
</body>
