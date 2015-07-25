namespace PagoElectronico.UI.Listados
{
    partial class ListadoWindow
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
            this.dataGridConsulta = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cTrimestre = new System.Windows.Forms.ComboBox();
            this.cConsulta = new System.Windows.Forms.ComboBox();
            this.cAnio = new System.Windows.Forms.NumericUpDown();
            this.bConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAnio)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridConsulta
            // 
            this.dataGridConsulta.AllowUserToAddRows = false;
            this.dataGridConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridConsulta.Location = new System.Drawing.Point(207, 96);
            this.dataGridConsulta.MultiSelect = false;
            this.dataGridConsulta.Name = "dataGridConsulta";
            this.dataGridConsulta.ReadOnly = true;
            this.dataGridConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridConsulta.Size = new System.Drawing.Size(252, 169);
            this.dataGridConsulta.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione el listado deseado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccione trimestre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Seleccione año";
            // 
            // cTrimestre
            // 
            this.cTrimestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cTrimestre.FormattingEnabled = true;
            this.cTrimestre.Items.AddRange(new object[] {
            "1° Trimestre",
            "2° Trimestre",
            "3° Trimestre",
            "4° Trimestre"});
            this.cTrimestre.Location = new System.Drawing.Point(135, 53);
            this.cTrimestre.Name = "cTrimestre";
            this.cTrimestre.Size = new System.Drawing.Size(121, 21);
            this.cTrimestre.TabIndex = 5;
            this.cTrimestre.SelectedIndex = 1;
            // 
            // cConsulta
            // 
            this.cConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cConsulta.FormattingEnabled = true;
            this.cConsulta.Items.AddRange(new object[] {
            "Top 5 Clientes Inhabilitaciones por Comision",
            "Top 5 Clientes Comisiones Facturadas",
            "Top 5 Clientes Transacciones Cuentas Propias",
            "Top 5 Paises Movimientos",
            "Total Facturado Tipo Cuenta"});
            this.cConsulta.Location = new System.Drawing.Point(167, 10);
            this.cConsulta.Name = "cConsulta";
            this.cConsulta.Size = new System.Drawing.Size(506, 21);
            this.cConsulta.TabIndex = 6;
            this.cConsulta.SelectedIndexChanged += new System.EventHandler(this.cConsulta_SelectedIndexChanged);
            this.cConsulta.SelectedIndex = 1;
            // 
            // cAnio
            // 
            this.cAnio.Location = new System.Drawing.Point(401, 53);
            this.cAnio.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.cAnio.Minimum = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            this.cAnio.Name = "cAnio";
            this.cAnio.Size = new System.Drawing.Size(120, 20);
            this.cAnio.TabIndex = 8;
            this.cAnio.Value = new decimal(new int[] {
            2016,
            0,
            0,
            0});
            // 
            // bConsultar
            // 
            this.bConsultar.Location = new System.Drawing.Point(547, 51);
            this.bConsultar.Name = "bConsultar";
            this.bConsultar.Size = new System.Drawing.Size(125, 22);
            this.bConsultar.TabIndex = 9;
            this.bConsultar.Text = "Consultar";
            this.bConsultar.UseVisualStyleBackColor = true;
            this.bConsultar.Click += new System.EventHandler(this.bConsultar_Click);
            // 
            // ListadoWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 277);
            this.Controls.Add(this.bConsultar);
            this.Controls.Add(this.cAnio);
            this.Controls.Add(this.cConsulta);
            this.Controls.Add(this.cTrimestre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridConsulta);
            this.Name = "ListadoWindow";
            this.Text = "ListadoWindow";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAnio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridConsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cTrimestre;
        private System.Windows.Forms.ComboBox cConsulta;
        private System.Windows.Forms.NumericUpDown cAnio;
        private System.Windows.Forms.Button bConsultar;
    }
}
