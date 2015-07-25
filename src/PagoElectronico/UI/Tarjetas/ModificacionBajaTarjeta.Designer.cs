namespace PagoElectronico.UI.Tarjetas
{
    partial class ModificacionBajaTarjeta
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
            this.tarjetaDataGrid = new System.Windows.Forms.DataGridView();
            this.emisorCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.filtrarButton = new System.Windows.Forms.Button();
            this.modificarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tarjetaDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tarjetaDataGrid
            // 
            this.tarjetaDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tarjetaDataGrid.Location = new System.Drawing.Point(12, 48);
            this.tarjetaDataGrid.MultiSelect = false;
            this.tarjetaDataGrid.Name = "tarjetaDataGrid";
            this.tarjetaDataGrid.ReadOnly = true;
            this.tarjetaDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tarjetaDataGrid.Size = new System.Drawing.Size(651, 150);
            this.tarjetaDataGrid.TabIndex = 0;
            // 
            // emisorCombo
            // 
            this.emisorCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.emisorCombo.FormattingEnabled = true;
            this.emisorCombo.Location = new System.Drawing.Point(68, 12);
            this.emisorCombo.Name = "emisorCombo";
            this.emisorCombo.Size = new System.Drawing.Size(121, 21);
            this.emisorCombo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Emisor";
            // 
            // filtrarButton
            // 
            this.filtrarButton.Location = new System.Drawing.Point(543, 10);
            this.filtrarButton.Name = "filtrarButton";
            this.filtrarButton.Size = new System.Drawing.Size(109, 23);
            this.filtrarButton.TabIndex = 3;
            this.filtrarButton.Text = "Filtrar";
            this.filtrarButton.UseVisualStyleBackColor = true;
            this.filtrarButton.Click += new System.EventHandler(this.filtrarButton_Click);
            // 
            // modificarButton
            // 
            this.modificarButton.Location = new System.Drawing.Point(260, 227);
            this.modificarButton.Name = "modificarButton";
            this.modificarButton.Size = new System.Drawing.Size(160, 23);
            this.modificarButton.TabIndex = 4;
            this.modificarButton.Text = "Modificar/Dar de baja";
            this.modificarButton.UseVisualStyleBackColor = true;
            this.modificarButton.Click += new System.EventHandler(this.modificarButton_Click);
            // 
            // ModificacionBajaTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 262);
            this.Controls.Add(this.modificarButton);
            this.Controls.Add(this.filtrarButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emisorCombo);
            this.Controls.Add(this.tarjetaDataGrid);
            this.Name = "ModificacionBajaTarjeta";
            this.Text = "ModificacionBajaTarjeta";
            this.Load += new System.EventHandler(this.ModificacionBajaTarjeta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tarjetaDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tarjetaDataGrid;
        private System.Windows.Forms.ComboBox emisorCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button filtrarButton;
        private System.Windows.Forms.Button modificarButton;
    }
}