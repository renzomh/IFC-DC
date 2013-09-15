<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UPC.IFCDC.UI.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title></title>
    <link href="css/ownstyle.css" rel="stylesheet" />
    <link href="css/Site.css" rel="Stylesheet" />
</head>
<body  >
 
<div class="vertical-centered-box">
<div id="header"><img src="Imagenes/logoUPC.png" /></div>
    <form id="formularioLogin" class="textoLogin" runat="server" style="margin:0 auto">
        
            <div class="right-box">Usuario: <asp:TextBox ID="texto_usuario" runat="server" />  </div>
            <div class="right-box">Password: <asp:TextBox TextMode="Password" ID="texto_password" runat="server" />  </div>
            <asp:Button ID="ingresar" CssClass="btn-ingresar" runat="server"  />
        
    </form>
    </div>
</body>
</html>
