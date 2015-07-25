namespace PagoElectronico.UI.ABM_Cliente
{
    partial class AltaCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this._nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._apellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._nroIdentificacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tipo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this._telefono = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Siguiente = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.país = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.fechadenacimiento = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._Depto = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this._piso = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this._altura = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this._localidad = new System.Windows.Forms.TextBox();
            this._calle = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.LimpiarCeldas = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this._ingresarUsuario = new System.Windows.Forms.Button();
            this._nacionalidad = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(54, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // _nombre
            // 
            this._nombre.Location = new System.Drawing.Point(107, 52);
            this._nombre.Name = "_nombre";
            this._nombre.Size = new System.Drawing.Size(169, 20);
            this._nombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(281, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido:";
            // 
            // _apellido
            // 
            this._apellido.Location = new System.Drawing.Point(331, 52);
            this._apellido.Name = "_apellido";
            this._apellido.Size = new System.Drawing.Size(141, 20);
            this._apellido.TabIndex = 3;
            this._apellido.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "N° Identificación:";
            // 
            // _nroIdentificacion
            // 
            this._nroIdentificacion.Location = new System.Drawing.Point(107, 84);
            this._nroIdentificacion.Name = "_nroIdentificacion";
            this._nroIdentificacion.Size = new System.Drawing.Size(176, 20);
            this._nroIdentificacion.TabIndex = 5;
            this._nroIdentificacion.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(297, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tipo:";
            // 
            // tipo
            // 
            this.tipo.FormattingEnabled = true;
            this.tipo.Location = new System.Drawing.Point(334, 84);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(138, 21);
            this.tipo.TabIndex = 7;
            this.tipo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(3, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Dirección de Email:";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(107, 111);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(169, 20);
            this.email.TabIndex = 9;
            this.email.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(276, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Teléfono:";
            // 
            // _telefono
            // 
            this._telefono.Location = new System.Drawing.Point(334, 111);
            this._telefono.Name = "_telefono";
            this._telefono.Size = new System.Drawing.Size(138, 20);
            this._telefono.TabIndex = 11;
            this._telefono.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Siguiente
            // 
            this.Siguiente.Location = new System.Drawing.Point(458, 297);
            this.Siguiente.Name = "Siguiente";
            this.Siguiente.Size = new System.Drawing.Size(107, 21);
            this.Siguiente.TabIndex = 12;
            this.Siguiente.Text = "Finalizar Carga";
            this.Siguiente.UseVisualStyleBackColor = true;
            this.Siguiente.Click += new System.EventHandler(this.Siguiente_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(69, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "País:";
            // 
            // país
            // 
            this.país.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.país.FormattingEnabled = true;
            this.país.Location = new System.Drawing.Point(107, 139);
            this.país.Name = "país";
            this.país.Size = new System.Drawing.Size(138, 21);
            this.país.TabIndex = 14;
            this.país.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(250, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Localidad:";
            // 
            // fechadenacimiento
            // 
            this.fechadenacimiento.Location = new System.Drawing.Point(334, 140);
            this.fechadenacimiento.Name = "fechadenacimiento";
            this.fechadenacimiento.Size = new System.Drawing.Size(200, 20);
            this.fechadenacimiento.TabIndex = 16;
            this.fechadenacimiento.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._Depto);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this._piso);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this._altura);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this._localidad);
            this.groupBox1.Controls.Add(this._calle);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(32, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 95);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dirección";
            // 
            // _Depto
            // 
            this._Depto.Location = new System.Drawing.Point(313, 59);
            this._Depto.Name = "_Depto";
            this._Depto.Size = new System.Drawing.Size(34, 20);
            this._Depto.TabIndex = 25;
            this._Depto.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(276, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Depto:";
            // 
            // _piso
            // 
            this._piso.Location = new System.Drawing.Point(215, 59);
            this._piso.Name = "_piso";
            this._piso.Size = new System.Drawing.Size(40, 20);
            this._piso.TabIndex = 23;
            this._piso.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(179, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Piso:";
            // 
            // _altura
            // 
            this._altura.Location = new System.Drawing.Point(86, 59);
            this._altura.Name = "_altura";
            this._altura.Size = new System.Drawing.Size(40, 20);
            this._altura.TabIndex = 21;
            this._altura.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(48, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Altura:";
            // 
            // _localidad
            // 
            this._localidad.Location = new System.Drawing.Point(312, 22);
            this._localidad.Name = "_localidad";
            this._localidad.Size = new System.Drawing.Size(138, 20);
            this._localidad.TabIndex = 19;
            this._localidad.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // _calle
            // 
            this._calle.Location = new System.Drawing.Point(86, 22);
            this._calle.Name = "_calle";
            this._calle.Size = new System.Drawing.Size(138, 20);
            this._calle.TabIndex = 18;
            this._calle.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(47, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Calle:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(265, 142);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Nacimiento:";
            // 
            // LimpiarCeldas
            // 
            this.LimpiarCeldas.Location = new System.Drawing.Point(82, 295);
            this.LimpiarCeldas.Name = "LimpiarCeldas";
            this.LimpiarCeldas.Size = new System.Drawing.Size(75, 23);
            this.LimpiarCeldas.TabIndex = 19;
            this.LimpiarCeldas.Text = "Limpiar";
            this.LimpiarCeldas.UseVisualStyleBackColor = true;
            this.LimpiarCeldas.Click += new System.EventHandler(this.LimpiarCeldas_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(29, 169);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "Nacionalidad:";
            // 
            // _ingresarUsuario
            // 
            this._ingresarUsuario.Location = new System.Drawing.Point(107, 12);
            this._ingresarUsuario.Name = "_ingresarUsuario";
            this._ingresarUsuario.Size = new System.Drawing.Size(134, 23);
            this._ingresarUsuario.TabIndex = 22;
            this._ingresarUsuario.Text = "Ingresar Usuario";
            this._ingresarUsuario.UseVisualStyleBackColor = true;
            this._ingresarUsuario.Click += new System.EventHandler(this._ingresarUsuario_Click);
            // 
            // _nacionalidad
            // 
            this._nacionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._nacionalidad.FormattingEnabled = true;
            this._nacionalidad.Location = new System.Drawing.Point(107, 167);
            this._nacionalidad.Name = "_nacionalidad";
            this._nacionalidad.Size = new System.Drawing.Size(138, 21);
            this._nacionalidad.TabIndex = 23;
            // 
            // AltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 330);
            this.Controls.Add(this._nacionalidad);
            this.Controls.Add(this._ingresarUsuario);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.LimpiarCeldas);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fechadenacimiento);
            this.Controls.Add(this.país);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Siguiente);
            this.Controls.Add(this._telefono);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tipo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._nroIdentificacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._apellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._nombre);
            this.Controls.Add(this.label1);
            this.Name = "AltaCliente";
            this.Text = "AltaCliente";
            this.Load += new System.EventHandler(this.AltaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _apellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _nroIdentificacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox tipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button Siguiente;
        private System.Windows.Forms.ComboBox país;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker fechadenacimiento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox _calle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox _Depto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox _piso;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox _altura;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox _localidad;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button LimpiarCeldas;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button _ingresarUsuario;
        private System.Windows.Forms.ComboBox _nacionalidad;
        private System.Windows.Forms.TextBox _telefono;
    }
}