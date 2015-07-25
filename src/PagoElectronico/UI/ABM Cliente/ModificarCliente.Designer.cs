namespace PagoElectronico.UI.ABM_Cliente
{
    partial class ModificarCliente
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
            this.components = new System.ComponentModel.Container();
            this.clienteGrid = new System.Windows.Forms.DataGridView();
            this.commitButton = new System.Windows.Forms.Button();
            this.domicilioGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.asociarDesacociarButton = new System.Windows.Forms.Button();
            this.labelPais = new System.Windows.Forms.Label();
            this.paisTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.pais = new System.Windows.Forms.ComboBox();
            this.nacionalidadLabel = new System.Windows.Forms.Label();
            this.nacionalidad = new System.Windows.Forms.ComboBox();
            this.numeroDocumento = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tipoDocumento = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clienteGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.domicilioGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clienteGrid
            // 
            this.clienteGrid.AllowUserToAddRows = false;
            this.clienteGrid.AllowUserToDeleteRows = false;
            this.clienteGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clienteGrid.Location = new System.Drawing.Point(2, 43);
            this.clienteGrid.Name = "clienteGrid";
            this.clienteGrid.Size = new System.Drawing.Size(620, 78);
            this.clienteGrid.TabIndex = 0;
            // 
            // commitButton
            // 
            this.commitButton.Location = new System.Drawing.Point(483, 291);
            this.commitButton.Name = "commitButton";
            this.commitButton.Size = new System.Drawing.Size(130, 23);
            this.commitButton.TabIndex = 1;
            this.commitButton.Text = "Commit changes";
            this.commitButton.UseVisualStyleBackColor = true;
            this.commitButton.Click += new System.EventHandler(this.commitButton_Click);
            // 
            // domicilioGrid
            // 
            this.domicilioGrid.AllowUserToAddRows = false;
            this.domicilioGrid.AllowUserToDeleteRows = false;
            this.domicilioGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.domicilioGrid.Location = new System.Drawing.Point(2, 140);
            this.domicilioGrid.Name = "domicilioGrid";
            this.domicilioGrid.Size = new System.Drawing.Size(620, 50);
            this.domicilioGrid.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Domicilio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cliente";
            // 
            // asociarDesacociarButton
            // 
            this.asociarDesacociarButton.Location = new System.Drawing.Point(469, 242);
            this.asociarDesacociarButton.Name = "asociarDesacociarButton";
            this.asociarDesacociarButton.Size = new System.Drawing.Size(153, 23);
            this.asociarDesacociarButton.TabIndex = 7;
            this.asociarDesacociarButton.Text = "Asociar/Desasociar Tarjetas";
            this.asociarDesacociarButton.UseVisualStyleBackColor = true;
            this.asociarDesacociarButton.Click += new System.EventHandler(this.asociarDesacociarButton_Click);
            // 
            // labelPais
            // 
            this.labelPais.AutoSize = true;
            this.labelPais.Location = new System.Drawing.Point(256, 217);
            this.labelPais.Name = "labelPais";
            this.labelPais.Size = new System.Drawing.Size(30, 13);
            this.labelPais.TabIndex = 9;
            this.labelPais.Text = "Pais:";
            this.labelPais.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Documento";
            // 
            // pais
            // 
            this.pais.FormattingEnabled = true;
            this.pais.Location = new System.Drawing.Point(319, 214);
            this.pais.Name = "pais";
            this.pais.Size = new System.Drawing.Size(121, 21);
            this.pais.TabIndex = 12;
            this.pais.SelectionChangeCommitted += new System.EventHandler(this.pais_SelectionChangeCommitted);
            // 
            // nacionalidadLabel
            // 
            this.nacionalidadLabel.AutoSize = true;
            this.nacionalidadLabel.Location = new System.Drawing.Point(241, 274);
            this.nacionalidadLabel.Name = "nacionalidadLabel";
            this.nacionalidadLabel.Size = new System.Drawing.Size(72, 13);
            this.nacionalidadLabel.TabIndex = 13;
            this.nacionalidadLabel.Text = "Nacionalidad:";
            // 
            // nacionalidad
            // 
            this.nacionalidad.FormattingEnabled = true;
            this.nacionalidad.Location = new System.Drawing.Point(319, 271);
            this.nacionalidad.Name = "nacionalidad";
            this.nacionalidad.Size = new System.Drawing.Size(121, 21);
            this.nacionalidad.TabIndex = 14;
            this.nacionalidad.SelectionChangeCommitted += new System.EventHandler(this.nacionalidad_SelectionChangeCommitted);
            // 
            // numeroDocumento
            // 
            this.numeroDocumento.Location = new System.Drawing.Point(86, 3);
            this.numeroDocumento.Name = "numeroDocumento";
            this.numeroDocumento.Size = new System.Drawing.Size(100, 20);
            this.numeroDocumento.TabIndex = 15;
            this.numeroDocumento.TextChanged += new System.EventHandler(this.numeroDocumento_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tipoDocumento);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numeroDocumento);
            this.panel1.Location = new System.Drawing.Point(15, 211);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 103);
            this.panel1.TabIndex = 16;
            // 
            // tipoDocumento
            // 
            this.tipoDocumento.FormattingEnabled = true;
            this.tipoDocumento.Location = new System.Drawing.Point(76, 60);
            this.tipoDocumento.Name = "tipoDocumento";
            this.tipoDocumento.Size = new System.Drawing.Size(121, 21);
            this.tipoDocumento.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Tipo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Numero:";
            // 
            // ModificarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 326);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nacionalidad);
            this.Controls.Add(this.nacionalidadLabel);
            this.Controls.Add(this.pais);
            this.Controls.Add(this.labelPais);
            this.Controls.Add(this.asociarDesacociarButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.domicilioGrid);
            this.Controls.Add(this.commitButton);
            this.Controls.Add(this.clienteGrid);
            this.Name = "ModificarCliente";
            this.Text = "ModificarCliente";
            this.Load += new System.EventHandler(this.ModificarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clienteGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.domicilioGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView clienteGrid;
        private System.Windows.Forms.Button commitButton;
        private System.Windows.Forms.DataGridView domicilioGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button asociarDesacociarButton;
        private System.Windows.Forms.Label labelPais;
        private System.Windows.Forms.ToolTip paisTooltip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox pais;
        private System.Windows.Forms.Label nacionalidadLabel;
        private System.Windows.Forms.ComboBox nacionalidad;
        private System.Windows.Forms.TextBox numeroDocumento;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox tipoDocumento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}