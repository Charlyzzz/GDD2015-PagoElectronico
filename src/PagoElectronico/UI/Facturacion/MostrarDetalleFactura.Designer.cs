namespace PagoElectronico.UI.Facturacion
{
    partial class MostrarDetalleFactura
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
            this.nyATextbox = new System.Windows.Forms.TextBox();
            this.fechaFactura = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.okButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nyATextbox
            // 
            this.nyATextbox.Enabled = false;
            this.nyATextbox.Location = new System.Drawing.Point(12, 12);
            this.nyATextbox.Name = "nyATextbox";
            this.nyATextbox.Size = new System.Drawing.Size(200, 20);
            this.nyATextbox.TabIndex = 0;
            // 
            // fechaFactura
            // 
            this.fechaFactura.Enabled = false;
            this.fechaFactura.Location = new System.Drawing.Point(12, 38);
            this.fechaFactura.Name = "fechaFactura";
            this.fechaFactura.Size = new System.Drawing.Size(200, 20);
            this.fechaFactura.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 64);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(430, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(177, 227);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "Cerrar";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // MostrarDetalleFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 262);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.fechaFactura);
            this.Controls.Add(this.nyATextbox);
            this.Name = "MostrarDetalleFactura";
            this.Text = "MostrarDetalleFactura";
            this.Load += new System.EventHandler(this.MostrarDetalleFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nyATextbox;
        private System.Windows.Forms.DateTimePicker fechaFactura;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button okButton;
    }
}