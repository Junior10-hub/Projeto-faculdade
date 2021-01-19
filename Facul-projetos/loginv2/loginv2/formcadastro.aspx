<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="formcadastro.aspx.cs" Inherits="cadastro.formcadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="cache-control" content="no-cache" />
    <title>Cadastro</title>
    <link rel="stylesheet" href="css/style.css" />
    <link rel="shortcut icon" href="https://i.imgur.com/ETwzuOK.png"/>
</head>
<body>
    <form id="form1" runat="server">
            <h1>Cadastro</h1>
            <br />
            <div class="registro">
                <div class="nome">
                    <asp:TextBox runat="server" ID="TXTnome" placeholder="Usuário" Wrap="False" Width="200px"></asp:TextBox>
                </div>
                <div class="email">
                    <asp:TextBox runat="server" placeholder="Email" ID="TXTemail" Wrap="False" Width="200px"></asp:TextBox>
                </div>
                <div class="senha">
                    <asp:TextBox type="password" runat="server" placeholder="Senha" ID="TXTsenha" Wrap="False" Width="200px"></asp:TextBox>
                </div>
                <br />
                <asp:Button runat="server" ID="BTNcadastrar" Text="Cadastrar" OnClick="BTNcadastrar_Click" />
            </div>
            <br />
            <br /><br />
            <div runat="server" id="DIVdadosTabela"></div> 
    </form>
</body>
</html>
