using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wRaceX.Modelos
{
    public class VehiculoHibrido : Vehiculo
    {
        public VehiculoHibrido(string nombre) : base(nombre, "Híbrido")
        {
        }
        public override int calcularAvance(string clima)
        {
            // Genera un número aleatorio entre 5 y 15 para el avance base
            int baseAvance = new Random().Next(5, 16);

            // Si el clima es "Soleado", se suma 2 al avance
            return clima == "Ventoso" ? baseAvance - 1 : baseAvance;
        }
    }
}
