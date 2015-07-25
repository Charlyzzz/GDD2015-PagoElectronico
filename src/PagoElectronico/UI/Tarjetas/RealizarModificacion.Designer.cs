namespace PagoElectronico.UI.Tarjetas
{
    partial class RealizarModificacion
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Emisores = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelnumero = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.NumeroDeTarjeta = new System.Windows.Forms.TextBox();
            this.labelCodSeg = new System.Windows.Forms.Label();
            this.CodigoDeSeguridad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(585, 60);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Emisores
            // 
            this.Emisores.FormattingEnabled = true;
            this.Emisores.Location = new System.Drawing.Point(56, 102);
            this.Emisores.Name = "Emisores";
            this.Emisores.Size = new System.Drawing.Size(121, 21);
            this.Emisores.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Emisor";
            // 
            // labelnumero
            // 
            this.labelnumero.AutoSize = true;
            this.labelnumero.Location = new System.Drawing.Point(203, 105);
            this.labelnumero.Name = "labelnumero";
            this.labelnumero.Size = new System.Drawing.Size(95, 13);
            this.labelnumero.TabIndex = 3;
            this.labelnumero.Text = "Numero de Tarjeta";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(519, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 103);
            this.button1.TabIndex = 4;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NumeroDeTarjeta
            // 
            this.NumeroDeTarjeta.Location = new System.Drawing.Point(313, 102);
            this.NumeroDeTarjeta.Name = "NumeroDeTarjeta";
            this.NumeroDeTarjeta.Size = new System.Drawing.Size(148, 20);
            this.NumeroDeTarjeta.TabIndex = 5;
            // 
            // labelCodSeg
            // 
            this.labelCodSeg.AutoSize = true;
            this.labelCodSeg.Location = new System.Drawing.Point(203, 144);
            this.labelCodSeg.Name = "labelCodSeg";
            this.labelCodSeg.Size = new System.Drawing.Size(106, 13);
            this.labelCodSeg.TabIndex = 6;
            this.labelCodSeg.Text = "Codigo de Seguridad";
            // 
            // CodigoDeSeguridad
            // 
            this.CodigoDeSeguridad.Location = new System.Drawing.Point(313, 141);
            this.CodigoDeSeguridad.Name = "CodigoDeSeguridad";
            this.CodigoDeSeguridad.Size = new System.Drawing.Size(148, 20);
            this.CodigoDeSeguridad.TabIndex = 7;
            // 
            // RealizarModificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 185);
            this.Controls.Add(this.CodigoDeSeguridad);
            this.Controls.Add(this.labelCodSeg);
            this.Controls.Add(this.NumeroDeTarjeta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelnumero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Emisores);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RealizarModificacion";
            this.Text = "RealizarModificacion";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox Emisores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelnumero;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox NumeroDeTarjeta;
        private System.Windows.Forms.Label labelCodSeg;
        private System.Windows.Forms.TextBox CodigoDeSeguridad;
    }
}