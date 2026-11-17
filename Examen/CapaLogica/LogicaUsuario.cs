namespace Examen.CapaLogica
{
    using System.Data;
    using System.Data.SqlClient;

    namespace Examen.CapaLogica
    {
        public class LogicaUsuario
        {
            public static int AgregarUsuarios(int codigo, string nombre, string correo, string telefono)
            {
                int retorno = 0;
                SqlConnection Conn = new SqlConnection();

                try
                {
                    using (Conn = new DBconn().Conectar())
                    {
                        SqlCommand cmd = new SqlCommand("INSERT INTO Usuarios (UsuarioID, Nombre, CorreoElectronico, Telefono) VALUES (@codigo, @nombre, @correo, @telefono)", Conn);
                        {
                            cmd.CommandType = CommandType.Text;
                        }
                        ;

                        cmd.Parameters.AddWithValue("@codigo", codigo);
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@correo", correo);
                        cmd.Parameters.AddWithValue("@telefono", telefono);

                        retorno = cmd.ExecuteNonQuery();
                    }
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    retorno = 0;
                }
                finally
                {
                    Conn.Close();
                }

                return retorno;
            }

            public static int ModificarUsuarios(int codigo, string nombre, string correo, string telefono)
            {
                int retorno = 0;
                SqlConnection Conn = new SqlConnection();

                try
                {
                    using (Conn = new DBconn().Conectar())
                    {
                        SqlCommand cmd = new SqlCommand("UPDATE Usuarios SET Nombre = @nombre, CorreoElectronico = @correo, Telefono = @telefono WHERE UsuarioID = @codigo", Conn);
                        {
                            cmd.CommandType = CommandType.Text;
                        }
                        ;

                        cmd.Parameters.AddWithValue("@codigo", codigo);
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@correo", correo);
                        cmd.Parameters.AddWithValue("@telefono", telefono);

                        retorno = cmd.ExecuteNonQuery();
                    }
                }
                catch (SqlException ex)
                {
                    retorno = 0;
                }

                return retorno;
            }

            public static int EliminarUsuarios(int codigo)
            {
                int retorno = 0;
                SqlConnection Conn = new SqlConnection();

                try
                {
                    using (Conn = new DBconn().Conectar())
                    {
                        SqlCommand cmd = new SqlCommand("DELETE FROM Usuarios WHERE UsuarioID = @codigo", Conn);
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("@codigo", codigo);

                        retorno = cmd.ExecuteNonQuery();
                    }
                }
                catch (SqlException ex)
                {
                    retorno = 0;
                }

                return retorno;
            }
        }
    }
}