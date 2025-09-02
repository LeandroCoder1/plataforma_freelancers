<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="YourProject.Pages.Login" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Login</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Usuário: <asp:TextBox ID="txtUser" runat="server"></asp:TextBox><br />
            Senha: <asp:TextBox ID="txtPass" TextMode="Password" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnLogin" runat="server" Text="Entrar" OnClick="btnLogin_Click" />
        </div>
    </form>
</body>
</html>
