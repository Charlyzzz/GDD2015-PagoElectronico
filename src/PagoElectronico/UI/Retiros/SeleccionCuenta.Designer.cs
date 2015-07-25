namespace PagoElectronico.UI.Retiros
{
    partial class SeleccionCuenta
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
            this.seleccionar = new System.Windows.Forms.Button();
            this.tipoDeCuenta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buscar = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 66);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(277, 199);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // seleccionar
            // 
            this.seleccionar.Enabled = false;
            this.seleccionar.Location = new System.Drawing.Point(324, 66);
            this.seleccionar.Name = "seleccionar";
            this.seleccionar.Size = new System.Drawing.Size(88, 199);
            this.seleccionar.TabIndex = 2;
            this.seleccionar.Text = "Seleccionar";
            this.seleccionar.UseVisualStyleBackColor = true;
            this.seleccionar.Click += new System.EventHandler(this.button2_Click);
            // 
            // tipoDeCuenta
            // 
            this.tipoDeCuenta.FormattingEnabled = true;
            this.tipoDeCuenta.Location = new System.Drawing.Point(122, 19);
            this.tipoDeCuenta.Name = "tipoDeCuenta";
            this.tipoDeCuenta.Size = new System.Drawing.Size(167, 21);
            this.tipoDeCuenta.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tipo de Cuenta";
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(324, 12);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(88, 23);
            this.buscar.TabIndex = 8;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.button4_Click);
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(324, 41);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(88, 23);
            this.limpiar.TabIndex = 9;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // SeleccionCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 280);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.tipoDeCuenta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.seleccionar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SeleccionCuenta";
            this.Text = "Cuenta de Destino";
            this.Load += new System.EventHandler(this.SeleccionCuenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button seleccionar;
        private System.Windows.Forms.ComboBox tipoDeCuenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.Button limpiar;
    }
}