namespace wRaceX
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNombreVehiculo = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblRegistroVehiculos = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.comboBoxVehiculo = new System.Windows.Forms.ComboBox();
            this.btnAgregarVehiculo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvVehiculos = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxClima = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnIniciarCarrera = new System.Windows.Forms.Button();
            this.btnSiguienteTurno = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.Obstaculo = new System.Windows.Forms.Label();
            this.listBoxMessages = new System.Windows.Forms.ListBox();
            this.flpProgreso = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreVehiculo
            // 
            this.txtNombreVehiculo.Location = new System.Drawing.Point(117, 45);
            this.txtNombreVehiculo.Name = "txtNombreVehiculo";
            this.txtNombreVehiculo.Size = new System.Drawing.Size(100, 20);
            this.txtNombreVehiculo.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(51, 48);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblRegistroVehiculos
            // 
            this.lblRegistroVehiculos.AutoSize = true;
            this.lblRegistroVehiculos.Location = new System.Drawing.Point(73, 13);
            this.lblRegistroVehiculos.Name = "lblRegistroVehiculos";
            this.lblRegistroVehiculos.Size = new System.Drawing.Size(130, 13);
            this.lblRegistroVehiculos.TabIndex = 2;
            this.lblRegistroVehiculos.Text = "📋 Registro de Vehículos ";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(298, 38);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 13);
            this.lblTitle.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "RaceX: Simulador de carrera";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(51, 90);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 5;
            this.lblTipo.Text = "Tipo:";
            // 
            // comboBoxVehiculo
            // 
            this.comboBoxVehiculo.FormattingEnabled = true;
            this.comboBoxVehiculo.Items.AddRange(new object[] {
            "Deportivo",
            "Hibrido",
            "Todoterreno"});
            this.comboBoxVehiculo.Location = new System.Drawing.Point(117, 82);
            this.comboBoxVehiculo.Name = "comboBoxVehiculo";
            this.comboBoxVehiculo.Size = new System.Drawing.Size(100, 21);
            this.comboBoxVehiculo.TabIndex = 6;
            // 
            // btnAgregarVehiculo
            // 
            this.btnAgregarVehiculo.Location = new System.Drawing.Point(54, 120);
            this.btnAgregarVehiculo.Name = "btnAgregarVehiculo";
            this.btnAgregarVehiculo.Size = new System.Drawing.Size(163, 23);
            this.btnAgregarVehiculo.TabIndex = 7;
            this.btnAgregarVehiculo.Text = "Agregar vehiculo";
            this.btnAgregarVehiculo.UseVisualStyleBackColor = true;
            this.btnAgregarVehiculo.Click += new System.EventHandler(this.btnAgregarVehiculo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "📃 Lista de Vehículos Registrados ";
            // 
            // dgvVehiculos
            // 
            this.dgvVehiculos.AllowUserToAddRows = false;
            this.dgvVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Tipo,
            this.Distancia});
            this.dgvVehiculos.Location = new System.Drawing.Point(292, 67);
            this.dgvVehiculos.Name = "dgvVehiculos";
            this.dgvVehiculos.Size = new System.Drawing.Size(342, 192);
            this.dgvVehiculos.TabIndex = 14;
            this.dgvVehiculos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehiculos_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // Distancia
            // 
            this.Distancia.HeaderText = "Distancia";
            this.Distancia.Name = "Distancia";
            this.Distancia.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(104, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Seleccion de clima";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Clima:";
            // 
            // comboBoxClima
            // 
            this.comboBoxClima.FormattingEnabled = true;
            this.comboBoxClima.Items.AddRange(new object[] {
            "Soleado",
            "Lluvia",
            "Ventoso"});
            this.comboBoxClima.Location = new System.Drawing.Point(118, 187);
            this.comboBoxClima.Name = "comboBoxClima";
            this.comboBoxClima.Size = new System.Drawing.Size(99, 21);
            this.comboBoxClima.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(98, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Controles de carrera";
            // 
            // btnIniciarCarrera
            // 
            this.btnIniciarCarrera.Location = new System.Drawing.Point(36, 249);
            this.btnIniciarCarrera.Name = "btnIniciarCarrera";
            this.btnIniciarCarrera.Size = new System.Drawing.Size(59, 39);
            this.btnIniciarCarrera.TabIndex = 19;
            this.btnIniciarCarrera.Text = "Iniciar Carrera";
            this.btnIniciarCarrera.UseVisualStyleBackColor = true;
            this.btnIniciarCarrera.Click += new System.EventHandler(this.btnIniciarCarrera_Click);
            // 
            // btnSiguienteTurno
            // 
            this.btnSiguienteTurno.Location = new System.Drawing.Point(107, 249);
            this.btnSiguienteTurno.Name = "btnSiguienteTurno";
            this.btnSiguienteTurno.Size = new System.Drawing.Size(72, 39);
            this.btnSiguienteTurno.TabIndex = 20;
            this.btnSiguienteTurno.Text = "Siguiente turno";
            this.btnSiguienteTurno.UseVisualStyleBackColor = true;
            this.btnSiguienteTurno.Click += new System.EventHandler(this.btnSiguienteTurno_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(196, 249);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(59, 39);
            this.btnReiniciar.TabIndex = 21;
            this.btnReiniciar.Text = "Reiniciar carrera";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(409, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Avance de vehiculos";
            // 
            // Obstaculo
            // 
            this.Obstaculo.AutoSize = true;
            this.Obstaculo.Location = new System.Drawing.Point(33, 306);
            this.Obstaculo.Name = "Obstaculo";
            this.Obstaculo.Size = new System.Drawing.Size(58, 13);
            this.Obstaculo.TabIndex = 25;
            this.Obstaculo.Text = "Obstaculo:";
            // 
            // listBoxMessages
            // 
            this.listBoxMessages.FormattingEnabled = true;
            this.listBoxMessages.Location = new System.Drawing.Point(36, 331);
            this.listBoxMessages.Name = "listBoxMessages";
            this.listBoxMessages.Size = new System.Drawing.Size(283, 251);
            this.listBoxMessages.TabIndex = 27;
            // 
            // flpProgreso
            // 
            this.flpProgreso.Location = new System.Drawing.Point(342, 331);
            this.flpProgreso.Name = "flpProgreso";
            this.flpProgreso.Size = new System.Drawing.Size(292, 251);
            this.flpProgreso.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 642);
            this.Controls.Add(this.flpProgreso);
            this.Controls.Add(this.listBoxMessages);
            this.Controls.Add(this.Obstaculo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnSiguienteTurno);
            this.Controls.Add(this.btnIniciarCarrera);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxClima);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvVehiculos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAgregarVehiculo);
            this.Controls.Add(this.comboBoxVehiculo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblRegistroVehiculos);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombreVehiculo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreVehiculo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblRegistroVehiculos;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox comboBoxVehiculo;
        private System.Windows.Forms.Button btnAgregarVehiculo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvVehiculos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxClima;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnIniciarCarrera;
        private System.Windows.Forms.Button btnSiguienteTurno;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Obstaculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distancia;
        private System.Windows.Forms.ListBox listBoxMessages;
        private System.Windows.Forms.FlowLayoutPanel flpProgreso;
    }
}

