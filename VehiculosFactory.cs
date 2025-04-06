using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using wRaceX.Modelos;

namespace wRaceX
{
    public class VehiculosFactory
    {
        public VehiculosFactory() { }
        public static Vehiculo CrearVehiculo(string tipo, string nombre)
        {
            // Método para crear un vehículo según el tipo especificado
            // Se usa un switch para determinar el tipo de vehículo a crear
            switch (tipo)
            {
                case "Deportivo":
                    return new VehiculoDeportivo(nombre);
                case "Todo Terreno":
                    return new VehiculoTodoTerreno(nombre);
                case "Híbrido":
                    return new VehiculoHibrido(nombre);
                default:
                    throw new ArgumentException("Tipo de vehículo no válido");
            }
        }
    }
}
