namespace PagoElectronico.UI.Transferencias
{
    partial class TransferenciasWindow
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
            this.label2 = new System.Windows.Forms.Label();
            this.destino = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.origen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.moneda = new System.Windows.Forms.ComboBox();
            this.monto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.realizar = new System.Windows.Forms.Button();
            this.fechaTransferencia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Destino";
            // 
            // destino
            // 
            this.destino.Enabled = false;
            this.destino.Location = new System.Drawing.Point(59, 42);
            this.destino.Name = "destino";
            this.destino.Size = new System.Drawing.Size(120, 20);
            this.destino.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(190, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Seleccionar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(190, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Seleccionar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // origen
            // 
            this.origen.Enabled = false;
            this.origen.Location = new System.Drawing.Point(59, 12);
            this.origen.Name = "origen";
            this.origen.Size = new System.Drawing.Size(120, 20);
            this.origen.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Origen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Moneda";
            // 
            // moneda
            // 
            this.moneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.moneda.FormattingEnabled = true;
            this.moneda.Location = new System.Drawing.Point(144, 73);
            this.moneda.Name = "moneda";
            this.moneda.Size = new System.Drawing.Size(121, 21);
            this.moneda.TabIndex = 4;
            // 
            // monto
            // 
            this.monto.Location = new System.Drawing.Point(79, 100);
            this.monto.Name = "monto";
            this.monto.Size = new System.Drawing.Size(186, 20);
            this.monto.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Monto";
            // 
            // realizar
            // 
            this.realizar.Location = new System.Drawing.Point(104, 159);
            this.realizar.Name = "realizar";
            this.realizar.Size = new System.Drawing.Size(75, 23);
            this.realizar.TabIndex = 19;
            this.realizar.Text = "Realizar";
            this.realizar.UseVisualStyleBackColor = true;
            this.realizar.Click += new System.EventHandler(this.realizar_Click);
            // 
            // fechaTransferencia
            // 
            this.fechaTransferencia.Enabled = false;
            this.fechaTransferencia.Location = new System.Drawing.Point(79, 126);
            this.fechaTransferencia.Name = "fechaTransferencia";
            this.fechaTransferencia.Size = new System.Drawing.Size(186, 20);
            this.fechaTransferencia.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Fecha";
            // 
            // TransferenciasWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 194);
            this.Controls.Add(this.fechaTransferencia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.realizar);
            this.Controls.Add(this.monto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.origen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.destino);
            this.Controls.Add(this.moneda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "TransferenciasWindow";
            this.Text = "Nueva Transferencia";
            this.Load += new System.EventHandler(this.TransferenciasWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox destino;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox origen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox moneda;
        private System.Windows.Forms.TextBox monto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button realizar;
        private System.Windows.Forms.TextBox fechaTransferencia;
        private System.Windows.Forms.Label label4;

    }
}