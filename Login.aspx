<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" ValidateRequest="false"
    meta:resourcekey="PageResource1" %>

<%--<% WebFormAntiForgery.AntiForgeryToken(); %>--%>
<!DOCTYPE html>


<head>
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=10, user-scalable=yes">
    <title>TestApp</title>
</head>
<body>

    <form id="form1" runat="server">

        <asp:Login ID="Login1" runat="server" OnLoggingIn="NewLogin_Page_Load"></asp:Login>
        <br />
        <br />
        <asp:Label ID="msg" Style=" font-size: 35px" runat="server" Text="wert" ForeColor="Red"></asp:Label>
    </form>
</body>
