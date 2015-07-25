namespace PagoElectronico.UI.Retiros
{
    partial class RetirosSeleccionWindow
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
            this.seleccionarCuenta = new System.Windows.Forms.Button();
            this.cuenta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.moneda = new System.Windows.Forms.ComboBox();
            this.monto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.retirar = new System.Windows.Forms.Button();
            this.fechaTransferencia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bancoSeleccionado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // seleccionarCuenta
            // 
            this.seleccionarCuenta.Location = new System.Drawing.Point(190, 10);
            this.seleccionarCuenta.Name = "seleccionarCuenta";
            this.seleccionarCuenta.Size = new System.Drawing.Size(75, 23);
            this.seleccionarCuenta.TabIndex = 16;
            this.seleccionarCuenta.Text = "Seleccionar";
            this.seleccionarCuenta.UseVisualStyleBackColor = true;
            this.seleccionarCuenta.Click += new System.EventHandler(this.button3_Click);
            // 
            // cuenta
            // 
            this.cuenta.Enabled = false;
            this.cuenta.Location = new System.Drawing.Point(59, 12);
            this.cuenta.Name = "cuenta";
            this.cuenta.Size = new System.Drawing.Size(120, 20);
            this.cuenta.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Cuenta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Moneda";            
            // 
            // moneda
            // 
            this.moneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.moneda.FormattingEnabled = true;
            this.moneda.Location = new System.Drawing.Point(144, 39);
            this.moneda.Name = "moneda";
            this.moneda.Size = new System.Drawing.Size(121, 21);
            this.moneda.TabIndex = 4;
            // 
            // monto
            // 
            this.monto.Location = new System.Drawing.Point(79, 93);
            this.monto.Name = "monto";
            this.monto.Size = new System.Drawing.Size(186, 20);
            this.monto.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Monto";
            // 
            // retirar
            // 
            this.retirar.Location = new System.Drawing.Point(104, 159);
            this.retirar.Name = "retirar";
            this.retirar.Size = new System.Drawing.Size(75, 23);
            this.retirar.TabIndex = 19;
            this.retirar.Text = "Realizar";
            this.retirar.UseVisualStyleBackColor = true;
            this.retirar.Click += new System.EventHandler(this.realizar_Click);
            // 
            // fechaTransferencia
            // 
            this.fechaTransferencia.Enabled = false;
            this.fechaTransferencia.Location = new System.Drawing.Point(79, 119);
            this.fechaTransferencia.Name = "fechaTransferencia";
            this.fechaTransferencia.Size = new System.Drawing.Size(186, 20);
            this.fechaTransferencia.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Fecha";
            // 
            // bancoSeleccionado
            // 
            this.bancoSeleccionado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bancoSeleccionado.FormattingEnabled = true;
            this.bancoSeleccionado.Location = new System.Drawing.Point(144, 66);
            this.bancoSeleccionado.Name = "bancoSeleccionado";
            this.bancoSeleccionado.Size = new System.Drawing.Size(121, 21);
            this.bancoSeleccionado.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Banco";
            // 
            // RetirosSeleccionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 194);
            this.Controls.Add(this.bancoSeleccionado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fechaTransferencia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.retirar);
            this.Controls.Add(this.monto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.seleccionarCuenta);
            this.Controls.Add(this.cuenta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.moneda);
            this.Controls.Add(this.label3);
            this.Name = "RetirosSeleccionWindow";
            this.Text = "Nueva Transferencia";
            this.Load += new System.EventHandler(this.RetirosSeleccionWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button seleccionarCuenta;
        private System.Windows.Forms.TextBox cuenta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox moneda;
        private System.Windows.Forms.TextBox monto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button retirar;
        private System.Windows.Forms.TextBox fechaTransferencia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox bancoSeleccionado;
        private System.Windows.Forms.Label label2;

    }
}