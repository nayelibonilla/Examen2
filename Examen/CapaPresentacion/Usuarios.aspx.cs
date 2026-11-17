using Examen.CapaLogica;
using Examen.CapaLogica.Examen.CapaLogica;
using System;
using System.Configuration;
using System.Data.SqlClient;

namespace Examen.CapaPresentacion
{
    public partial class Usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        protected void LlenarGrid()
        {
            string constr = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Usuarios", con))
            {
                con.Open();
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    GridView1.DataSource = rdr;
                    GridView1.DataBind();
                }
            }
        }

        protected void btnAgregarClick(object sender, EventArgs e)
        {
            if (LogicaUsuario.AgregarUsuarios(int.Parse(txtUsuarioID.Text), txtNombre.Text, txtCorreoElectronico.Text, txtTelefono.Text) > 0)
            {
                LlenarGrid();
            }
        }

        protected void btnModificarClick(object sender, EventArgs e)
        {
            if (LogicaUsuario.ModificarUsuarios(int.Parse(txtUsuarioID.Text), txtNombre.Text, txtCorreoElectronico.Text, txtTelefono.Text) > 0)
            {
                LlenarGrid();
            }
        }

        protected void btnEliminarClick(object sender, EventArgs e)
        {
            if (LogicaUsuario.EliminarUsuarios(int.Parse(txtUsuarioID.Text)) > 0)
            {
                LlenarGrid();
            }
        }
    }
}