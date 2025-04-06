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
            if(!inCurso)
            {
                // Agrega un vehículo a la lista de vehículos participantes
                Vehiculos.Add(vehiculo);
            }
            else
            {
                throw new InvalidOperationException("No se pueden agregar vehículos una vez que la carrera ha comenzado.");
            }

            if(Vehiculos.Any(a => a.Nombre == vehiculo.Nombre)){
                throw new ArgumentException($"Ya existe un vehículo con el nombre {vehiculo.Nombre}.");
            }
            Vehiculos.Add(vehiculo);
        }

        public void SeleccionarClima(string clima)
        {
            if (!inCurso)
            {
                // Selecciona el clima para la carrera
                Clima = clima;
            }


            throw new InvalidOperationException("No se puede seleccionar el clima una vez que la carrera ha comenzado.");
        }

        public void IniciarCarrera()
        {
            if (Vehiculos.Count < 3)
            {
                throw new InvalidOperationException("Se necesitan al menos 3 vehículos para iniciar la carrera.");
            }

            if(string.IsNullOrEmpty(Clima))
            {
                throw new InvalidOperationException("El clima debe ser seleccionado antes de iniciar la carrera.");
            }

            inCurso = true;
        }

        public string SiguienteTurno()
        {
            if(!inCurso || Ganador!=null)
            {
                return "La carrera no está en curso o ya ha terminado.";
            }

            foreach (var auto in Vehiculos)
            {
                Vehiculos.avanzar(Clima))
            }
        }

        
    }
}
