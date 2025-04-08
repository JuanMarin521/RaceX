using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wRaceX.Controller;
using wRaceX.Modelos;

namespace wRaceX
{
    public partial class Form1 : Form

    {

        private Carrera carrera = new Carrera();
        private Dictionary<Vehiculo, ProgressBar> barrasVehiculos = new Dictionary<Vehiculo, ProgressBar>();
        private Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dgvVehiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnAgregarVehiculo_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreVehiculo.Text.Trim();
            string tipo = comboBoxVehiculo.Text.Trim();

            try
            {
                Validaciones.ValidarNombreAuto(nombre, carrera.Vehiculos);
                Validaciones.ValidarTipoAuto(tipo);

                Vehiculo vehiculo = VehiculosFactory.CrearVehiculo(tipo, nombre);
                carrera.AgregarVehiculo(vehiculo);


                // Agregar el vehículo a la DataGridView
                dgvVehiculos.Rows.Add(vehiculo.Nombre, vehiculo.Tipo, vehiculo.DistanciaRecorrida);

                txtNombreVehiculo.Clear();

                // 
                comboBoxVehiculo.SelectedIndex = -1;
                MessageBox.Show("Vehículo agregado correctamente.");

               /* ProgressBar barra = new ProgressBar();
                barra.Maximum = 150;
                barra.Minimum = 0;
                barra.Value = 0;
                barra.Width = 200;
                barra.Height = 20;
                barra.Margin = new Padding(5);
               
                // Agrega la barra al panel visual
                flpProgreso.Controls.Add(barra);

                // Asocia el vehículo con su barra
                barrasVehiculos[vehiculo] = barra;
               */
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnIniciarCarrera_Click(object sender, EventArgs e)
        {
            try
            {
                string climaSeleccionado = comboBoxClima.Text.Trim();

                if (string.IsNullOrEmpty(climaSeleccionado))
                {
                    MessageBox.Show("Debes ingresar un clima antes de iniciar la carrera (Soleado, Lluvia o Ventoso).");
                    return;
                }

                Validaciones.ValidarClima(climaSeleccionado);

                carrera.IniciarCarrera(climaSeleccionado);
                MessageBox.Show("Carrera iniciada correctamente.");

                listBoxMessages.Items.Add("Carrera iniciada con clima: " + carrera.Clima);

                //Se crea dinamicamente las barras de progreso
                flpProgreso.Controls.Clear();
                barrasVehiculos.Clear();

                foreach(var vehiculo in carrera.Vehiculos)
                {
                    // Crear una nueva barra de progreso para cada vehículo
                    Label lbl = new Label() { Text = vehiculo.Nombre, Width = 100 };

                    // Crear una nueva barra de progreso
                    ProgressBar pb = new ProgressBar() { Minimum = 0, Maximum = 150, Width = 300, Height = 20 };

                    // Asignar el nombre del vehículo a la barra de progreso
                    flpProgreso.Controls.Add(lbl);

                    // Agregar la barra de progreso al panel
                    flpProgreso.Controls.Add(pb);
                    
                    // Iniciar la barra de progreso
                    barrasVehiculos[vehiculo] = pb;
                }

                // Deshabilitar los controles de agregar vehículo y clima
                btnAgregarVehiculo.Enabled = false;
                comboBoxVehiculo.Enabled = false;
                txtNombreVehiculo.Enabled = false;
                comboBoxClima.Enabled = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
        }

        private void btnSiguienteTurno_Click(object sender, EventArgs e)
        {
            if (!carrera.inCurso)
            {
                MessageBox.Show("La carrera no ha comenzado.");
                return;
            }

            var resultado = carrera.SiguienteTurno();

            // Actualizar la DataGridView con la distancia recorrida
            for (int i = 0; i < carrera.Vehiculos.Count; i++)
            {
                dgvVehiculos.Rows[i].Cells["Distancia"].Value = carrera.Vehiculos[i].DistanciaRecorrida;
            }

            // Actualizar las barras de progreso
            foreach (var vehiculo in carrera.Vehiculos)
            {
                if (barrasVehiculos.TryGetValue(vehiculo, out var barra))
                {
                    barra.Value = Math.Min(vehiculo.DistanciaRecorrida, barra.Maximum);
                }
            }

            listBoxMessages.Items.Add(resultado);

            if (carrera.Ganador != null)
            {
                btnSiguienteTurno.Enabled = false;
            }

            MessageBox.Show(resultado);
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            carrera = new Carrera();

            // Limpiar campos de entrada
            txtNombreVehiculo.Clear();
            comboBoxClima.SelectedIndex = -1;
            comboBoxVehiculo.SelectedIndex = -1;

            // Limpiar visualización
            dgvVehiculos.Rows.Clear();
            flpProgreso.Controls.Clear();
          

            // Habilitar los botones necesarios
            btnAgregarVehiculo.Enabled = true;
            comboBoxVehiculo.Enabled = true;
            txtNombreVehiculo.Enabled = true;
            comboBoxClima.Enabled = true;
            listBoxMessages.Items.Clear();

            MessageBox.Show("La carrera ha sido reiniciada. Puedes comenzar de nuevo.");

        }
    }
}
