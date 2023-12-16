using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CapaDatos
{
    public class Conexion
    {
        public static string cadena;

        static Conexion()
        {
            try
            {
                cadena = ConfigurationManager.ConnectionStrings["cadena_conexion"].ToString();
            }
            catch (Exception ex)
            {
                // Manejar el error de configuración
                // Por ejemplo, imprimir un mensaje o lanzar una excepción personalizada.
                Console.WriteLine($"Error al obtener la cadena de conexión: {ex.Message}");
            }
        }
    }

}
