namespace PagoElectronico.UI.Consulta_Saldos
{
    partial class ConsultaSaldoWindow
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
            this.gridDepositos = new System.Windows.Forms.DataGridView();
            this.gridRetiros = new System.Windows.Forms.DataGridView();
            this.gridTransferencias = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.cCuenta = new System.Windows.Forms.ComboBox();
            this.tSaldo = new System.Windows.Forms.TextBox();
            this.bAceptar = new System.Windows.Forms.Button();
            this.tNombreChabon = new System.Windows.Forms.TextBox();
            this.bBuscarCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridDepositos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRetiros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransferencias)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Saldo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ultimos Depositos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ultimos Retiros";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ultimas Transferencias";
            // 
            // gridDepositos
            // 
            this.gridDepositos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDepositos.Location = new System.Drawing.Point(15, 113);
            this.gridDepositos.Name = "gridDepositos";
            this.gridDepositos.Size = new System.Drawing.Size(631, 100);
            this.gridDepositos.TabIndex = 6;
            this.gridDepositos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDepositos_CellContentClick);
            // 
            // gridRetiros
            // 
            this.gridRetiros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRetiros.Location = new System.Drawing.Point(15, 243);
            this.gridRetiros.Name = "gridRetiros";
            this.gridRetiros.Size = new System.Drawing.Size(631, 107);
            this.gridRetiros.TabIndex = 7;
            // 
            // gridTransferencias
            // 
            this.gridTransferencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTransferencias.Location = new System.Drawing.Point(15, 379);
            this.gridTransferencias.Name = "gridTransferencias";
            this.gridTransferencias.Size = new System.Drawing.Size(631, 121);
            this.gridTransferencias.TabIndex = 8;
            this.gridTransferencias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Cuenta";
            // 
            // cCuenta
            // 
            this.cCuenta.FormattingEnabled = true;
            this.cCuenta.Location = new System.Drawing.Point(68, 36);
            this.cCuenta.Name = "cCuenta";
            this.cCuenta.Size = new System.Drawing.Size(350, 21);
            this.cCuenta.TabIndex = 10;
            this.cCuenta.SelectedIndexChanged += new System.EventHandler(this.cCuenta_SelectedIndexChanged);
            // 
            // tSaldo
            // 
            this.tSaldo.Enabled = false;
            this.tSaldo.Location = new System.Drawing.Point(68, 66);
            this.tSaldo.Name = "tSaldo";
            this.tSaldo.Size = new System.Drawing.Size(350, 20);
            this.tSaldo.TabIndex = 11;
            this.tSaldo.TextChanged += new System.EventHandler(this.tSaldo_TextChanged);
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(571, 516);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 12;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // tNombreChabon
            // 
            this.tNombreChabon.Enabled = false;
            this.tNombreChabon.Location = new System.Drawing.Point(68, 9);
            this.tNombreChabon.Name = "tNombreChabon";
            this.tNombreChabon.Size = new System.Drawing.Size(350, 20);
            this.tNombreChabon.TabIndex = 13;
            // 
            // bBuscarCliente
            // 
            this.bBuscarCliente.Location = new System.Drawing.Point(473, 7);
            this.bBuscarCliente.Name = "bBuscarCliente";
            this.bBuscarCliente.Size = new System.Drawing.Size(161, 23);
            this.bBuscarCliente.TabIndex = 14;
            this.bBuscarCliente.Text = "Buscar Cliente";
            this.bBuscarCliente.UseVisualStyleBackColor = true;
            this.bBuscarCliente.Click += new System.EventHandler(this.bBuscarCliente_Click);
            // 
            // ConsultaSaldoWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 551);
            this.Controls.Add(this.bBuscarCliente);
            this.Controls.Add(this.tNombreChabon);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.tSaldo);
            this.Controls.Add(this.cCuenta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gridTransferencias);
            this.Controls.Add(this.gridRetiros);
            this.Controls.Add(this.gridDepositos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ConsultaSaldoWindow";
            this.Text = "ConsultaSaldoWindow";
            this.Load += new System.EventHandler(this.ConsultaSaldoWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDepositos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRetiros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransferencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView gridDepositos;
        private System.Windows.Forms.DataGridView gridRetiros;
        private System.Windows.Forms.DataGridView gridTransferencias;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cCuenta;
        private System.Windows.Forms.TextBox tSaldo;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.TextBox tNombreChabon;
        private System.Windows.Forms.Button bBuscarCliente;
    }
}