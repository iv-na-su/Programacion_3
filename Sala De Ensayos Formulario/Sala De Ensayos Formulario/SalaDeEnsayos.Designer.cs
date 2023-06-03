namespace Sala_De_Ensayos_Formulario
{
    partial class SalaDeEnsayos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalaDeEnsayos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Banda = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbDolar = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CotizUSD = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CostoH = new System.Windows.Forms.NumericUpDown();
            this.Descuento = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.Duracion = new System.Windows.Forms.NumericUpDown();
            this.NumR = new System.Windows.Forms.NumericUpDown();
            this.InicR = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Salida = new System.Windows.Forms.Label();
            this.btnReserva = new System.Windows.Forms.Button();
            this.btnCompartidos = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtReserva = new System.Windows.Forms.Label();
            this.btnMayor = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CotizUSD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostoH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Descuento)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Duracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumR)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(13, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de Reserva";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(13, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inicio de la reserva";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(13, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Costo Por Hora";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(13, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descuento";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(13, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 37);
            this.label5.TabIndex = 4;
            this.label5.Text = "Banda";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Banda
            // 
            this.Banda.Location = new System.Drawing.Point(200, 261);
            this.Banda.Name = "Banda";
            this.Banda.Size = new System.Drawing.Size(322, 20);
            this.Banda.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbDolar);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.CotizUSD);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.CostoH);
            this.panel1.Controls.Add(this.Descuento);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(56, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 237);
            this.panel1.TabIndex = 10;
            // 
            // cbDolar
            // 
            this.cbDolar.AutoSize = true;
            this.cbDolar.Location = new System.Drawing.Point(544, 183);
            this.cbDolar.Name = "cbDolar";
            this.cbDolar.Size = new System.Drawing.Size(94, 17);
            this.cbDolar.TabIndex = 3;
            this.cbDolar.Text = "Ver en dolares";
            this.cbDolar.UseVisualStyleBackColor = true;
            this.cbDolar.CheckedChanged += new System.EventHandler(this.cbDolar_CheckedChanged);
            this.cbDolar.CheckStateChanged += new System.EventHandler(this.cbDolar_CheckedChanged);
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(521, 179);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 23);
            this.label15.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(175, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 26);
            this.label6.TabIndex = 24;
            this.label6.Text = "$";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CotizUSD
            // 
            this.CotizUSD.DecimalPlaces = 2;
            this.CotizUSD.Enabled = false;
            this.CotizUSD.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.CotizUSD.Location = new System.Drawing.Point(198, 179);
            this.CotizUSD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.CotizUSD.Name = "CotizUSD";
            this.CotizUSD.Size = new System.Drawing.Size(340, 20);
            this.CotizUSD.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label14.Enabled = false;
            this.label14.Location = new System.Drawing.Point(13, 169);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(156, 37);
            this.label14.TabIndex = 22;
            this.label14.Text = "Cotizacion DOLAR";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(521, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 23);
            this.label12.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(521, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 23);
            this.label11.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(175, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 26);
            this.label9.TabIndex = 19;
            this.label9.Text = "$";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(175, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 26);
            this.label10.TabIndex = 18;
            this.label10.Text = "%";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CostoH
            // 
            this.CostoH.DecimalPlaces = 2;
            this.CostoH.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.CostoH.Location = new System.Drawing.Point(198, 54);
            this.CostoH.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.CostoH.Name = "CostoH";
            this.CostoH.Size = new System.Drawing.Size(340, 20);
            this.CostoH.TabIndex = 1;
            // 
            // Descuento
            // 
            this.Descuento.DecimalPlaces = 2;
            this.Descuento.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Descuento.Location = new System.Drawing.Point(198, 120);
            this.Descuento.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.Descuento.Name = "Descuento";
            this.Descuento.Size = new System.Drawing.Size(340, 20);
            this.Descuento.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.Duracion);
            this.panel2.Controls.Add(this.NumR);
            this.panel2.Controls.Add(this.InicR);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.Banda);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(56, 281);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(666, 342);
            this.panel2.TabIndex = 11;
            // 
            // label16
            // 
            this.label16.Enabled = false;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(521, 143);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 26);
            this.label16.TabIndex = 35;
            this.label16.Text = "Hs";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(521, 202);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(30, 23);
            this.label17.TabIndex = 34;
            // 
            // Duracion
            // 
            this.Duracion.Location = new System.Drawing.Point(200, 148);
            this.Duracion.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.Duracion.Name = "Duracion";
            this.Duracion.Size = new System.Drawing.Size(322, 20);
            this.Duracion.TabIndex = 31;
            // 
            // NumR
            // 
            this.NumR.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NumR.Location = new System.Drawing.Point(200, 205);
            this.NumR.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NumR.Name = "NumR";
            this.NumR.Size = new System.Drawing.Size(340, 20);
            this.NumR.TabIndex = 32;
            // 
            // InicR
            // 
            this.InicR.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.InicR.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.InicR.Location = new System.Drawing.Point(200, 87);
            this.InicR.Name = "InicR";
            this.InicR.Size = new System.Drawing.Size(322, 20);
            this.InicR.TabIndex = 6;
            this.InicR.Value = new System.DateTime(2023, 5, 22, 19, 22, 41, 0);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(13, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 37);
            this.label8.TabIndex = 11;
            this.label8.Text = "Duracion";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(-2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 37);
            this.label7.TabIndex = 10;
            this.label7.Text = "Datos de la reserva";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.UseCompatibleTextRendering = true;
            // 
            // Salida
            // 
            this.Salida.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Salida.Location = new System.Drawing.Point(762, 281);
            this.Salida.Name = "Salida";
            this.Salida.Size = new System.Drawing.Size(273, 342);
            this.Salida.TabIndex = 12;
            this.Salida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReserva
            // 
            this.btnReserva.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReserva.Enabled = false;
            this.btnReserva.Location = new System.Drawing.Point(73, 652);
            this.btnReserva.Name = "btnReserva";
            this.btnReserva.Size = new System.Drawing.Size(229, 56);
            this.btnReserva.TabIndex = 10;
            this.btnReserva.Text = "Generar Reserva";
            this.btnReserva.UseVisualStyleBackColor = false;
            this.btnReserva.Click += new System.EventHandler(this.btnReserva_Click);
            // 
            // btnCompartidos
            // 
            this.btnCompartidos.Location = new System.Drawing.Point(789, 115);
            this.btnCompartidos.Name = "btnCompartidos";
            this.btnCompartidos.Size = new System.Drawing.Size(246, 53);
            this.btnCompartidos.TabIndex = 5;
            this.btnCompartidos.Text = "Guardar Datos Compartidos";
            this.btnCompartidos.UseVisualStyleBackColor = true;
            this.btnCompartidos.Click += new System.EventHandler(this.btnCompartidos_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(269, 281);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 33);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(268, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(155, 33);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(0, -3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(156, 37);
            this.label13.TabIndex = 23;
            this.label13.Text = "Datos compartidos";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label13.UseCompatibleTextRendering = true;
            // 
            // txtReserva
            // 
            this.txtReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReserva.Location = new System.Drawing.Point(765, 254);
            this.txtReserva.Name = "txtReserva";
            this.txtReserva.Size = new System.Drawing.Size(270, 27);
            this.txtReserva.TabIndex = 23;
            this.txtReserva.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnMayor
            // 
            this.btnMayor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMayor.Enabled = false;
            this.btnMayor.Location = new System.Drawing.Point(366, 652);
            this.btnMayor.Name = "btnMayor";
            this.btnMayor.Size = new System.Drawing.Size(229, 56);
            this.btnMayor.TabIndex = 11;
            this.btnMayor.Text = "Mostrar mayor reserva";
            this.btnMayor.UseVisualStyleBackColor = false;
            this.btnMayor.Click += new System.EventHandler(this.btnMayor_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCerrar.Location = new System.Drawing.Point(659, 652);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(229, 56);
            this.btnCerrar.TabIndex = 30;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // SalaDeEnsayos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1068, 731);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnMayor);
            this.Controls.Add(this.txtReserva);
            this.Controls.Add(this.btnCompartidos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnReserva);
            this.Controls.Add(this.Salida);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SalaDeEnsayos";
            this.Text = "RESERVAS DE LA SALA DE ENSAYOS";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CotizUSD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostoH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Descuento)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Duracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumR)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Banda;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Salida;
        private System.Windows.Forms.Button btnReserva;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCompartidos;
        private System.Windows.Forms.NumericUpDown CostoH;
        private System.Windows.Forms.NumericUpDown Descuento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown CotizUSD;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox cbDolar;
        private System.Windows.Forms.DateTimePicker InicR;
        private System.Windows.Forms.Label txtReserva;
        private System.Windows.Forms.Button btnMayor;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.NumericUpDown Duracion;
        private System.Windows.Forms.NumericUpDown NumR;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}

