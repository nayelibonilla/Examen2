<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="Examen.CapaPresentacion.Usuarios" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Gestion de Usuarios</title>
    <link rel="stylesheet" type="text/css" href="/css/Estilos.css"/>
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
            <h1>Gestion de Usuarios</h1>
        </div>
        <div>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </div>
        <div>
            <asp:Label ID="lblUsuarioID" runat="server" Text="Usuario ID:"></asp:Label>
            <asp:TextBox ID="txtUsuarioID" runat="server"></asp:TextBox>
            <br />
              <asp:Label ID="lblNombre" runat="server" Text="Nombre:"></asp:Label>
              <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblCorreoElectronico" runat="server" Text="Correo electrónico:"></asp:Label>
            <asp:TextBox ID="txtCorreoElectronico" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblTelefono" runat="server" Text="Teléfono:"></asp:Label>
            <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
        </div>

        <div>
           <asp:Button ID="btnAgregar" runat="server" Text="Agregar Usuario" OnClick="btnAgregarClick" />

           <asp:Button ID="btnModificar" runat="server" Text="Modificar Usuario" OnClick="btnModificarClick"/>

           <asp:Button ID="btnEliminar" runat="server" Text="Eliminar Usuario" OnClick="btnEliminarClick" />
        </div>
    </form>
</body>
</html>
