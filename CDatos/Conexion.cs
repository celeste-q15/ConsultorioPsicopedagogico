using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioPsicopedagogico.CDatos
{
    internal class Conexion
    {
        internal static string servidor = "localhost";
        internal static string bd = "ConsultorioPsicopedagogico";
        internal static string usuario = "root";
        internal static string password = "chino2510"; // <--- Actualizar con la contraseña de su base de datos
        internal static string puerto = "3306";

        // Propiedad opcional para obtener la cadena de conexión completa
        internal static string ConnectionString
        {
            get
            {
                return $"server={servidor};port={puerto};database={bd};user id={usuario};password={password};";
            }
        }
    }
}
