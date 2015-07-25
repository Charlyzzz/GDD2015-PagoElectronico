namespace PagoElectronico.UI.Facturacion
{
    partial class FacturacionWindow
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
            this.seleccionar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.limpiarCampos = new System.Windows.Forms.Button();
            this.clienteActualTextbox = new System.Windows.Forms.TextBox();
            this.verFacturasButton = new System.Windows.Forms.Button();
            this.nuevaFacturaButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.detalleButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // seleccionar
            // 
            this.seleccionar.Location = new System.Drawing.Point(189, 9);
            this.seleccionar.Name = "seleccionar";
            this.seleccionar.Size = new System.Drawing.Size(151, 23);
            this.seleccionar.TabIndex = 0;
            this.seleccionar.Text = "Seleccionar Cliente";
            this.seleccionar.UseVisualStyleBackColor = true;
            this.seleccionar.Click += new System.EventHandler(this.seleccionar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 74);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(340, 185);
            this.dataGridView1.TabIndex = 1;
            // 
            // limpiarCampos
            // 
            this.limpiarCampos.Location = new System.Drawing.Point(12, 305);
            this.limpiarCampos.Name = "limpiarCampos";
            this.limpiarCampos.Size = new System.Drawing.Size(100, 23);
            this.limpiarCampos.TabIndex = 2;
            this.limpiarCampos.Text = "Limpiar";
            this.limpiarCampos.UseVisualStyleBackColor = true;
            this.limpiarCampos.Click += new System.EventHandler(this.limpiarCampos_Click);
            // 
            // clienteActualTextbox
            // 
            this.clienteActualTextbox.Enabled = false;
            this.clienteActualTextbox.Location = new System.Drawing.Point(12, 26);
            this.clienteActualTextbox.Name = "clienteActualTextbox";
            this.clienteActualTextbox.Size = new System.Drawing.Size(162, 20);
            this.clienteActualTextbox.TabIndex = 4;
            // 
            // verFacturasButton
            // 
            this.verFacturasButton.Location = new System.Drawing.Point(189, 38);
            this.verFacturasButton.Name = "verFacturasButton";
            this.verFacturasButton.Size = new System.Drawing.Size(151, 23);
            this.verFacturasButton.TabIndex = 5;
            this.verFacturasButton.Text = "Ver Facturas";
            this.verFacturasButton.UseVisualStyleBackColor = true;
            this.verFacturasButton.Click += new System.EventHandler(this.verFacturasButton_Click);
            // 
            // nuevaFacturaButton
            // 
            this.nuevaFacturaButton.Location = new System.Drawing.Point(215, 305);
            this.nuevaFacturaButton.Name = "nuevaFacturaButton";
            this.nuevaFacturaButton.Size = new System.Drawing.Size(113, 23);
            this.nuevaFacturaButton.TabIndex = 6;
            this.nuevaFacturaButton.Text = "Nueva Factura";
            this.nuevaFacturaButton.UseVisualStyleBackColor = true;
            this.nuevaFacturaButton.Click += new System.EventHandler(this.nuevaFacturaButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Facturas de:";
            // 
            // detalleButton
            // 
            this.detalleButton.Location = new System.Drawing.Point(258, 266);
            this.detalleButton.Name = "detalleButton";
            this.detalleButton.Size = new System.Drawing.Size(75, 23);
            this.detalleButton.TabIndex = 8;
            this.detalleButton.Text = "Detalle";
            this.detalleButton.UseVisualStyleBackColor = true;
            this.detalleButton.Click += new System.EventHandler(this.detalleButton_Click);
            // 
            // FacturacionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 340);
            this.Controls.Add(this.detalleButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nuevaFacturaButton);
            this.Controls.Add(this.verFacturasButton);
            this.Controls.Add(this.clienteActualTextbox);
            this.Controls.Add(this.limpiarCampos);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.seleccionar);
            this.Name = "FacturacionWindow";
            this.Text = "FacturacionWindow";
            this.Load += new System.EventHandler(this.FacturacionWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button seleccionar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button limpiarCampos;
        private System.Windows.Forms.TextBox clienteActualTextbox;
        private System.Windows.Forms.Button verFacturasButton;
        private System.Windows.Forms.Button nuevaFacturaButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button detalleButton;
    }
}