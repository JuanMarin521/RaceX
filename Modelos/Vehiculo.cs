using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wRaceX
{
    public abstract class Vehiculo
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        // Propiedad que representa la distancia recorrida por el vehículo
        //se usa el set protected para que solo se pueda modificar desde la clase base
        public int DistanciaRecorrida { get; protected set; }

        protected Vehiculo(string nombre, string tipo)
        {
            // Constructor de la clase Vehiculo, el constructor sirve para inicializar las propiedades Nombre, Tipo y DistanciaRecorrida
            //Se usa protected para que solo se pueda acceder desde la clase base

            Nombre = nombre;
            Tipo = tipo;
            DistanciaRecorrida = 0;
        }

        /// Método abstracto para calcular el avance del vehículo en función del clima
        public abstract int calcularAvance(string clima);

        public void Avanzar(string clima)
        {
            // Simulando el avance del vehículo en función del clima 
            DistanciaRecorrida += calcularAvance(clima);
        }

        public void AplicarObstaculo()
        {
            // Simulando un obstáculo que reduce la distancia recorrida mediante math.max
            // que significa que no puede ser menor a 0 y se resta -5 a la variable DistanciaRecorrida
            DistanciaRecorrida = Math.Max(0, DistanciaRecorrida - 5);
        }



    }
}
