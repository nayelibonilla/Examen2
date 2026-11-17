using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examen.CapaDatos
{

    public class Usuario
    {
        private int usuarioID;
        private string nombre;
        private string correoElectronico;
        private string telefono;

        public int UsuarioID
        {
            get { return usuarioID; }
            set { usuarioID = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string CorreoElectronico
        {
            get { return correoElectronico; }
            set { correoElectronico = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
    }

}