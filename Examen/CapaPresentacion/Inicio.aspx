<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Examen.CapaPresentacion.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Inicio</title>
    <link rel="stylesheet" type="text/css" href="/css/Estilos.css">
</head>
<body>
    <form id="form1" runat="server">
        <div>
                        <ul>
  <li><a class="active" href="Inicio.aspx">Inicio</a></li>
  <li><a href="Usuarios.aspx">Usuarios</a></li>
  <li><a href="#contact">Contactos</a></li>
  <li><a href="#about">Ayuda</a></li>
</ul>
        </div>
             <div>
            <asp:Image ID="Image1" runat="server"
                Height="455px"
                Width="663px"
                ImageUrl="~/Imagen/https://t4.ftcdn.net/jpg/04/94/85/25/360_F_494852538_r8ylVApdAY0YuWYCkWIsg5pDZkboERYI.jpg" />
        </div>
    </form>
</body>
</html>
