namespace PagoElectronico.UI.Depositos
{
    partial class DepositosWindow
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
            this.cuenta = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.importe = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tipoMoneda = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tarjetaCredito = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.limpiarCampos = new System.Windows.Forms.Button();
            this.guardarCampos = new System.Windows.Forms.Button();
            this.labelAdvertencia = new System.Windows.Forms.Label();
            this.clienteIDTextbox = new System.Windows.Forms.TextBox();
            this.seleccionarClienteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cuenta
            // 
            this.cuenta.AutoSize = true;
            this.cuenta.Location = new System.Drawing.Point(12, 59);
            this.cuenta.Name = "cuenta";
            this.cuenta.Size = new System.Drawing.Size(44, 13);
            this.cuenta.TabIndex = 0;
            this.cuenta.Text = "Cuenta:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(86, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(187, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // importe
            // 
            this.importe.AutoSize = true;
            this.importe.Location = new System.Drawing.Point(13, 83);
            this.importe.Name = "importe";
            this.importe.Size = new System.Drawing.Size(45, 13);
            this.importe.TabIndex = 2;
            this.importe.Text = "Importe:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(137, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // tipoMoneda
            // 
            this.tipoMoneda.AutoSize = true;
            this.tipoMoneda.Location = new System.Drawing.Point(12, 106);
            this.tipoMoneda.Name = "tipoMoneda";
            this.tipoMoneda.Size = new System.Drawing.Size(73, 13);
            this.tipoMoneda.TabIndex = 4;
            this.tipoMoneda.Text = "Tipo Moneda:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(140, 103);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(97, 21);
            this.comboBox2.TabIndex = 5;
            // 
            // tarjetaCredito
            // 
            this.tarjetaCredito.AutoSize = true;
            this.tarjetaCredito.Location = new System.Drawing.Point(12, 133);
            this.tarjetaCredito.Name = "tarjetaCredito";
            this.tarjetaCredito.Size = new System.Drawing.Size(94, 13);
            this.tarjetaCredito.TabIndex = 6;
            this.tarjetaCredito.Text = "Tarjeta de Crédito:";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(112, 130);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(147, 21);
            this.comboBox3.TabIndex = 7;
            // 
            // limpiarCampos
            // 
            this.limpiarCampos.Location = new System.Drawing.Point(16, 184);
            this.limpiarCampos.Name = "limpiarCampos";
            this.limpiarCampos.Size = new System.Drawing.Size(75, 23);
            this.limpiarCampos.TabIndex = 9;
            this.limpiarCampos.Text = "Limpiar";
            this.limpiarCampos.UseVisualStyleBackColor = true;
            this.limpiarCampos.Click += new System.EventHandler(this.limpiarCampos_Click);
            // 
            // guardarCampos
            // 
            this.guardarCampos.Location = new System.Drawing.Point(215, 184);
            this.guardarCampos.Name = "guardarCampos";
            this.guardarCampos.Size = new System.Drawing.Size(75, 23);
            this.guardarCampos.TabIndex = 10;
            this.guardarCampos.Text = "Guardar";
            this.guardarCampos.UseVisualStyleBackColor = true;
            this.guardarCampos.Click += new System.EventHandler(this.guardarCampos_Click_1);
            // 
            // labelAdvertencia
            // 
            this.labelAdvertencia.AutoSize = true;
            this.labelAdvertencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdvertencia.ForeColor = System.Drawing.Color.DarkRed;
            this.labelAdvertencia.Location = new System.Drawing.Point(1, 158);
            this.labelAdvertencia.Name = "labelAdvertencia";
            this.labelAdvertencia.Size = new System.Drawing.Size(302, 13);
            this.labelAdvertencia.TabIndex = 11;
            this.labelAdvertencia.Text = "Usted no posee tarjetas en condicion de ser usadas";
            // 
            // clienteIDTextbox
            // 
            this.clienteIDTextbox.Location = new System.Drawing.Point(16, 21);
            this.clienteIDTextbox.Name = "clienteIDTextbox";
            this.clienteIDTextbox.Size = new System.Drawing.Size(100, 20);
            this.clienteIDTextbox.TabIndex = 12;
            // 
            // seleccionarClienteButton
            // 
            this.seleccionarClienteButton.Location = new System.Drawing.Point(184, 18);
            this.seleccionarClienteButton.Name = "seleccionarClienteButton";
            this.seleccionarClienteButton.Size = new System.Drawing.Size(111, 23);
            this.seleccionarClienteButton.TabIndex = 13;
            this.seleccionarClienteButton.Text = "Seleccionar Cliente";
            this.seleccionarClienteButton.UseVisualStyleBackColor = true;
            this.seleccionarClienteButton.Click += new System.EventHandler(this.seleccionarClienteButton_Click);
            // 
            // DepositosWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 223);
            this.Controls.Add(this.seleccionarClienteButton);
            this.Controls.Add(this.clienteIDTextbox);
            this.Controls.Add(this.labelAdvertencia);
            this.Controls.Add(this.guardarCampos);
            this.Controls.Add(this.limpiarCampos);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.tarjetaCredito);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.tipoMoneda);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.importe);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cuenta);
            this.Name = "DepositosWindow";
            this.Text = "DepositosWindow";
            this.Load += new System.EventHandler(this.DepositosWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cuenta;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label importe;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label tipoMoneda;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label tarjetaCredito;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button limpiarCampos;
        private System.Windows.Forms.Button guardarCampos;
        private System.Windows.Forms.Label labelAdvertencia;
        private System.Windows.Forms.TextBox clienteIDTextbox;
        private System.Windows.Forms.Button seleccionarClienteButton;
    }
}