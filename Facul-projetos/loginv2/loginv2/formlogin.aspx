<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="formlogin.aspx.cs" Inherits="login.formlogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="cache-control" content="no-cache" />
    <title>Login</title>
    <link rel="stylesheet" href="css/style.css" />
    <link rel="shortcut icon" href="https://i.imgur.com/ETwzuOK.png"/>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Login</h1>
        <br />
        <div class="login">
            <div class="nome">
                <asp:TextBox runat="server" placeholder="Usuário" ID="TXTnome" Wrap="False" Width="200px"></asp:TextBox>
            </div>
            <div class="senha">
                <asp:TextBox runat="server" placeholder="Senha" ID="TXTsenha" Wrap="False" Width="200px"></asp:TextBox>
            </div>
            <br />
            <asp:Button runat="server" ID="BTNcadastrar" Text="Login" OnClick="BTNcadastrar_Click" />
        </div>
        <br />
        <br /><br />
        <div runat="server" id="DIVdadosTabela"></div> 
    </form>
</body>
</html>
