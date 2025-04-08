using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace wRaceX.Modelos
{
    public class Carrera
    {
        // Propiedades de la clase Carrera
        // Lista de vehículos participantes
        public List<Vehiculo> Vehiculos { get; private set; } = new List<Vehiculo>();
        
        //clima
        public string Clima { get; private set; }
       
        public bool inCurso { get; private set; } = false;

        public Vehiculo Ganador { get; private set; }

        private Random random = new Random();


        public void AgregarVehiculo(Vehiculo vehiculo)
        {
            if (!inCurso)
            {
                Vehiculos.Add(vehiculo);
            }
            else
            {
                throw new InvalidOperationException("No se pueden agregar vehículos una vez que la carrera ha comenzado.");
            }
        }

        public void SeleccionarClima(string clima)
        
        {
            if (inCurso)
            {
                throw new InvalidOperationException("No se puede seleccionar el clima una vez que la carrera ha comenzado.");
            }

            Clima = clima;

        }

        public void IniciarCarrera(string clima)
        {
            if (inCurso)
            {
                throw new InvalidOperationException("La carrera ya está en curso.");
            }

            if (Vehiculos.Count < 3)
            {
                throw new InvalidOperationException("Se necesitan al menos 3 vehículos para iniciar la carrera.");
            }

            if (string.IsNullOrEmpty(clima))
            {
                throw new InvalidOperationException("El clima debe ser seleccionado antes de iniciar la carrera.");
            }

            SeleccionarClima(clima);
            inCurso = true;
        }

        public string SiguienteTurno()
        {
            if (!inCurso || Ganador != null)
            {
                return "La carrera no está en curso o ya ha terminado.";
            }

            // Avanzar todos los vehículos
            foreach (var auto in Vehiculos)
            {
                auto.Avanzar(Clima);
            }

            // Verificar si hay un ganador antes de aplicar obstáculos
            var posibleGanador = Vehiculos.FirstOrDefault(v => v.DistanciaRecorrida >= 150);
            if (posibleGanador != null)
            {
                Ganador = posibleGanador;
                inCurso = false;

                return $"El vehículo {Ganador.Nombre} ha ganado la carrera.";
            }
            if (random.NextDouble() <= 0.333)
            {
                var afectado = Vehiculos[random.Next(Vehiculos.Count)];
                afectado.AplicarObstaculo();
                return $"El vehículo {afectado.Nombre} ha sido afectado por un obstáculo y su distancia se redujo -5mts.";

            }
            return "Todos los vehículos avanzaron sin obstaculos.";

        }


        public void Reiniciar()
        {
            inCurso = false;
            Ganador = null;
            Clima = null;
            Vehiculos.Clear();
            // Reiniciar la distancia recorrida de todos los vehículos
            
        }


    }
}
