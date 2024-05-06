using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace OCHO
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        //private const string CadenaConexion = "server=(local);database=nocho;";
        private const string CadenaConexion = "Server=(local);Database=ncho;Integrated Security=True;";

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string Modifica(int id, string nombre, string apellido, string telefono, bool tipo)
        {
            try
            {
                // Construye la consulta SQL para actualizar la entrada en la tabla persona
                string query = "UPDATE persona SET nombre = @Nombre, apellido = @Apellido, telefono = @Telefono, tipo = @Tipo WHERE idpersona = @ID";

                // Establece la conexión con la base de datos
                using (SqlConnection conexion = new SqlConnection(CadenaConexion))
                {
                    // Abre la conexión
                    conexion.Open();

                    // Crea el comando SQL y establece los parámetros
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@Nombre", nombre);
                        comando.Parameters.AddWithValue("@Apellido", apellido);
                        comando.Parameters.AddWithValue("@Telefono", telefono);
                        comando.Parameters.AddWithValue("@Tipo", tipo);
                        comando.Parameters.AddWithValue("@ID", id);

                        // Ejecuta la consulta
                        int filasActualizadas = comando.ExecuteNonQuery();

                        // Verifica si se actualizaron filas
                        if (filasActualizadas > 0)
                        {
                            return "Se modificó la persona correctamente.";
                        }
                        else
                        {
                            return "No se encontró ninguna persona con el ID especificado.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return "Error al modificar la persona: " + ex.Message;
            }
        }

        [WebMethod]
        public string Crea(string nombre, string apellido, string telefono, bool tipo)
        {
            try
            {
                // Construye la consulta SQL para insertar un nuevo registro en la tabla persona
                string query = "INSERT INTO persona (nombre, apellido, telefono, tipo) VALUES (@Nombre, @Apellido, @Telefono, @Tipo); SELECT SCOPE_IDENTITY();";

                // Establece la conexión con la base de datos
                using (SqlConnection conexion = new SqlConnection(CadenaConexion))
                {
                    // Abre la conexión
                    conexion.Open();

                    // Crea el comando SQL y establece los parámetros
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@Nombre", nombre);
                        comando.Parameters.AddWithValue("@Apellido", apellido);
                        comando.Parameters.AddWithValue("@Telefono", telefono);
                        comando.Parameters.AddWithValue("@Tipo", tipo);

                        // Ejecuta la consulta para insertar el nuevo registro y obtiene el ID generado automáticamente
                        int nuevoID = Convert.ToInt32(comando.ExecuteScalar());

                        // Verifica si se insertó el registro correctamente
                        if (nuevoID > 0)
                        {
                            return "Se creó la persona correctamente con ID: " + nuevoID;
                        }
                        else
                        {
                            return "Error al crear la persona.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return "Error al crear la persona: " + ex.Message;
            }
        }

        [WebMethod]
        public string Elimina(int id)
        {
            try
            {
                // Construye la consulta SQL para eliminar el registro de la tabla persona
                string query = "DELETE FROM persona WHERE idpersona = @ID";

                // Establece la conexión con la base de datos
                using (SqlConnection conexion = new SqlConnection(CadenaConexion))
                {
                    // Abre la conexión
                    conexion.Open();

                    // Crea el comando SQL y establece el parámetro
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@ID", id);

                        // Ejecuta la consulta para eliminar el registro
                        int filasEliminadas = comando.ExecuteNonQuery();

                        // Verifica si se eliminó el registro correctamente
                        if (filasEliminadas > 0)
                        {
                            return "Se eliminó la persona con ID: " + id + " correctamente.";
                        }
                        else
                        {
                            return "No se encontró ninguna persona con el ID especificado.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return "Error al eliminar la persona: " + ex.Message;
            }
        }



    }


}





