using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using wRaceX.Modelos;

namespace wRaceX.Controller
{

    public class Validaciones
    {
        public static void ValidarNombreAuto(string nombreAuto, List<Vehiculo> autosRegistrados)
        {
            if (string.IsNullOrWhiteSpace(nombreAuto))
            {
                throw new ArgumentException("El nombre del vehiculo no puede estar vacío.");
            }
            // Verifica si el nombre del vehículo ya existe en la lista de vehículos registrados ignorando mayúsculas y minúsculas
            if (autosRegistrados.Any(a => a.Nombre.Equals(nombreAuto, StringComparison.OrdinalIgnoreCase)))
            {
                throw new ArgumentException($"Ya existe un vehículo con el nombre {nombreAuto}.");
            }
        }


        public static void ValidarTipoAuto(string tipoAuto)
        {
            // metodo trim elimina los espacios en blanco al principio y al final de la cadena y el toLower convierte la cadena a minúsculas
            string tipoNormalizado = tipoAuto.Trim().ToLower();

            // Verifica si el tipo de vehículo es válido
            if (tipoNormalizado != "deportivo" && tipoNormalizado != "hibrido" && tipoNormalizado != "todoterreno")
            {
                throw new ArgumentException("Tipo de vehículo no válido. Debe ser 'Deportivo', 'Hibrido' o 'Todoterreno'.");
            }
        }

       public static void ValidarClima(string clima)
        {
            string c = clima.Trim().ToLower();
            // Verifica si el clima es válido
            if (c != "soleado" && c != "lluvia" && c != "ventoso")
            {
                throw new ArgumentException("Clima no válido. Debe ser 'Soleado', 'Lluvia' o 'Ventoso'.");
            }
        }

        public static void  ValidarCarreraIniciada(bool inCurso)
        {
            if (inCurso)
            {
                throw new InvalidOperationException("No se pueden modificar los autos una vez iniciada la carrera.");
            }
        }
    }
}
