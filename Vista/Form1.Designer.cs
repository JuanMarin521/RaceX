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
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvVehiculos = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxClima = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreVehiculo
            // 
            this.txtNombreVehiculo.Location = new System.Drawing.Point(123, 96);
            this.txtNombreVehiculo.Name = "txtNombreVehiculo";
            this.txtNombreVehiculo.Size = new System.Drawing.Size(100, 20);
            this.txtNombreVehiculo.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(57, 99);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblRegistroVehiculos
            // 
            this.lblRegistroVehiculos.AutoSize = true;
            this.lblRegistroVehiculos.Location = new System.Drawing.Point(79, 64);
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
            this.label1.Location = new System.Drawing.Point(230, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "RaceX: Simulador de carrera";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(57, 154);
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
            this.comboBoxVehiculo.Location = new System.Drawing.Point(123, 151);
            this.comboBoxVehiculo.Name = "comboBoxVehiculo";
            this.comboBoxVehiculo.Size = new System.Drawing.Size(100, 21);
            this.comboBoxVehiculo.TabIndex = 6;
            // 
            // btnAgregarVehiculo
            // 
            this.btnAgregarVehiculo.Location = new System.Drawing.Point(60, 205);
            this.btnAgregarVehiculo.Name = "btnAgregarVehiculo";
            this.btnAgregarVehiculo.Size = new System.Drawing.Size(163, 23);
            this.btnAgregarVehiculo.TabIndex = 7;
            this.btnAgregarVehiculo.Text = "Agregar vehiculo";
            this.btnAgregarVehiculo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "📃 Lista de Vehículos Registrados ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tipo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Distancia";
            // 
            // dgvVehiculos
            // 
            this.dgvVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculos.Location = new System.Drawing.Point(38, 341);
            this.dgvVehiculos.Name = "dgvVehiculos";
            this.dgvVehiculos.Size = new System.Drawing.Size(220, 38);
            this.dgvVehiculos.TabIndex = 14;
            this.dgvVehiculos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehiculos_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 404);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Seleccion de clima";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 438);
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
            this.comboBoxClima.Location = new System.Drawing.Point(159, 435);
            this.comboBoxClima.Name = "comboBoxClima";
            this.comboBoxClima.Size = new System.Drawing.Size(100, 21);
            this.comboBoxClima.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 642);
            this.Controls.Add(this.comboBoxClima);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvVehiculos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvVehiculos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxClima;
    }
}

