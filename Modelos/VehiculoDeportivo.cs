using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wRaceX.Modelos
{
    public class VehiculoDeportivo : Vehiculo
    {
        private static Random random = new Random();
        public VehiculoDeportivo(string nombre) : base (nombre, "Deportivo")
        {
            
        }

        public override int calcularAvance(string clima)
        {
            //aleatorizar el avance entre 5 y 15
            int baseAvance = random.Next(5, 16);

            // Si el clima es soleado, se suma 3 al avance
            return clima == "Soleado" ? baseAvance + 3 : baseAvance;
        }
    }
}
