using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wRaceX.Modelos
{
    public class VehiculoTodoTerreno : Vehiculo
    {
        private static Random random = new Random();

        public VehiculoTodoTerreno(string nombre) : base(nombre, "Todo Terreno")
        {

        }
        public override int calcularAvance(string clima)
        {
            // Genera un número aleatorio entre 5 y 15 para el avance base
            int baseAvance = random.Next(5, 16);

            // Si el clima es "Lluvia", se suma 2 al avance
            return clima == "Lluvia" ? baseAvance + 2 : baseAvance;

        }
    }
}
