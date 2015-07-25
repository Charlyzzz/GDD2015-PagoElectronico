namespace PagoElectronico.UI.Tarjetas
{
    partial class AltaTarjeta
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NumeroTarjeta = new System.Windows.Forms.TextBox();
            this.CodigoSeguridad = new System.Windows.Forms.TextBox();
            this.FechaEmision = new System.Windows.Forms.DateTimePicker();
            this.FechaVenciento = new System.Windows.Forms.DateTimePicker();
            this.Emisor = new System.Windows.Forms.ComboBox();
            this.aceptarButton = new System.Windows.Forms.Button();
            this.limpiarButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Titular = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Emisor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha emision";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha vencimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Codigo de Seguridad";
            // 
            // NumeroTarjeta
            // 
            this.NumeroTarjeta.Location = new System.Drawing.Point(77, 23);
            this.NumeroTarjeta.Name = "NumeroTarjeta";
            this.NumeroTarjeta.Size = new System.Drawing.Size(138, 20);
            this.NumeroTarjeta.TabIndex = 5;
            // 
            // CodigoSeguridad
            // 
            this.CodigoSeguridad.Location = new System.Drawing.Point(171, 128);
            this.CodigoSeguridad.Name = "CodigoSeguridad";
            this.CodigoSeguridad.Size = new System.Drawing.Size(138, 20);
            this.CodigoSeguridad.TabIndex = 6;
            // 
            // FechaEmision
            // 
            this.FechaEmision.Location = new System.Drawing.Point(341, 23);
            this.FechaEmision.Name = "FechaEmision";
            this.FechaEmision.Size = new System.Drawing.Size(245, 20);
            this.FechaEmision.TabIndex = 7;
            // 
            // FechaVenciento
            // 
            this.FechaVenciento.Location = new System.Drawing.Point(341, 65);
            this.FechaVenciento.Name = "FechaVenciento";
            this.FechaVenciento.Size = new System.Drawing.Size(245, 20);
            this.FechaVenciento.TabIndex = 8;
            // 
            // Emisor
            // 
            this.Emisor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Emisor.FormattingEnabled = true;
            this.Emisor.Location = new System.Drawing.Point(77, 88);
            this.Emisor.Name = "Emisor";
            this.Emisor.Size = new System.Drawing.Size(138, 21);
            this.Emisor.TabIndex = 9;
            // 
            // aceptarButton
            // 
            this.aceptarButton.Location = new System.Drawing.Point(466, 127);
            this.aceptarButton.Name = "aceptarButton";
            this.aceptarButton.Size = new System.Drawing.Size(120, 23);
            this.aceptarButton.TabIndex = 10;
            this.aceptarButton.Text = "Aceptar";
            this.aceptarButton.UseVisualStyleBackColor = true;
            this.aceptarButton.Click += new System.EventHandler(this.aceptarButton_Click);
            // 
            // limpiarButton
            // 
            this.limpiarButton.Location = new System.Drawing.Point(341, 127);
            this.limpiarButton.Name = "limpiarButton";
            this.limpiarButton.Size = new System.Drawing.Size(119, 23);
            this.limpiarButton.TabIndex = 11;
            this.limpiarButton.Text = "Limpiar";
            this.limpiarButton.UseVisualStyleBackColor = true;
            this.limpiarButton.Click += new System.EventHandler(this.limpiarButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Titular";
            // 
            // Titular
            // 
            this.Titular.Location = new System.Drawing.Point(77, 56);
            this.Titular.Name = "Titular";
            this.Titular.Size = new System.Drawing.Size(138, 20);
            this.Titular.TabIndex = 13;
            // 
            // AltaTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 160);
            this.Controls.Add(this.Titular);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.limpiarButton);
            this.Controls.Add(this.aceptarButton);
            this.Controls.Add(this.Emisor);
            this.Controls.Add(this.FechaVenciento);
            this.Controls.Add(this.FechaEmision);
            this.Controls.Add(this.CodigoSeguridad);
            this.Controls.Add(this.NumeroTarjeta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AltaTarjeta";
            this.Text = "AltaTarjeta";
            this.Load += new System.EventHandler(this.AltaTarjeta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NumeroTarjeta;
        private System.Windows.Forms.TextBox CodigoSeguridad;
        private System.Windows.Forms.DateTimePicker FechaEmision;
        private System.Windows.Forms.DateTimePicker FechaVenciento;
        private System.Windows.Forms.ComboBox Emisor;
        private System.Windows.Forms.Button aceptarButton;
        private System.Windows.Forms.Button limpiarButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Titular;
    }
}