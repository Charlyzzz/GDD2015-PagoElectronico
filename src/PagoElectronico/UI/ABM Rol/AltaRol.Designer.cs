namespace PagoElectronico.UI.ABM_Rol
{
    partial class AltaRol
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bAlta = new System.Windows.Forms.Button();
            this.bLimpiarFuncLista = new System.Windows.Forms.Button();
            this.bQuitarFuncLista = new System.Windows.Forms.Button();
            this.bAgregarFuncLista = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listFuncionalidad = new System.Windows.Forms.ListBox();
            this.cFuncionalidad = new System.Windows.Forms.ComboBox();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bAlta);
            this.groupBox1.Controls.Add(this.bLimpiarFuncLista);
            this.groupBox1.Controls.Add(this.bQuitarFuncLista);
            this.groupBox1.Controls.Add(this.bAgregarFuncLista);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.listFuncionalidad);
            this.groupBox1.Controls.Add(this.cFuncionalidad);
            this.groupBox1.Controls.Add(this.tNombre);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 321);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alta de roles";
            // 
            // bAlta
            // 
            this.bAlta.Location = new System.Drawing.Point(231, 278);
            this.bAlta.Name = "bAlta";
            this.bAlta.Size = new System.Drawing.Size(75, 23);
            this.bAlta.TabIndex = 9;
            this.bAlta.Text = "Crear rol";
            this.bAlta.UseVisualStyleBackColor = true;
            this.bAlta.Click += new System.EventHandler(this.bAlta_Click);
            // 
            // bLimpiarFuncLista
            // 
            this.bLimpiarFuncLista.Location = new System.Drawing.Point(371, 193);
            this.bLimpiarFuncLista.Name = "bLimpiarFuncLista";
            this.bLimpiarFuncLista.Size = new System.Drawing.Size(75, 23);
            this.bLimpiarFuncLista.TabIndex = 8;
            this.bLimpiarFuncLista.Text = "Limpiar";
            this.bLimpiarFuncLista.UseVisualStyleBackColor = true;
            this.bLimpiarFuncLista.Click += new System.EventHandler(this.bLimpiarFuncLista_Click);
            // 
            // bQuitarFuncLista
            // 
            this.bQuitarFuncLista.Location = new System.Drawing.Point(371, 160);
            this.bQuitarFuncLista.Name = "bQuitarFuncLista";
            this.bQuitarFuncLista.Size = new System.Drawing.Size(75, 23);
            this.bQuitarFuncLista.TabIndex = 7;
            this.bQuitarFuncLista.Text = "Quitar";
            this.bQuitarFuncLista.UseVisualStyleBackColor = true;
            this.bQuitarFuncLista.Click += new System.EventHandler(this.bQuitarFuncLista_Click);
            // 
            // bAgregarFuncLista
            // 
            this.bAgregarFuncLista.Location = new System.Drawing.Point(371, 100);
            this.bAgregarFuncLista.Name = "bAgregarFuncLista";
            this.bAgregarFuncLista.Size = new System.Drawing.Size(131, 23);
            this.bAgregarFuncLista.TabIndex = 6;
            this.bAgregarFuncLista.Text = "Agregar a la lista";
            this.bAgregarFuncLista.UseVisualStyleBackColor = true;
            this.bAgregarFuncLista.Click += new System.EventHandler(this.bAgregarFuncLista_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Funcionalidades";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Seleccionar funcionalidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre del rol";
            // 
            // listFuncionalidad
            // 
            this.listFuncionalidad.FormattingEnabled = true;
            this.listFuncionalidad.Location = new System.Drawing.Point(182, 160);
            this.listFuncionalidad.Name = "listFuncionalidad";
            this.listFuncionalidad.Size = new System.Drawing.Size(171, 95);
            this.listFuncionalidad.TabIndex = 2;
            // 
            // cFuncionalidad
            // 
            this.cFuncionalidad.FormattingEnabled = true;
            this.cFuncionalidad.Location = new System.Drawing.Point(182, 100);
            this.cFuncionalidad.Name = "cFuncionalidad";
            this.cFuncionalidad.Size = new System.Drawing.Size(171, 21);
            this.cFuncionalidad.TabIndex = 1;
            // 
            // tNombre
            // 
            this.tNombre.Location = new System.Drawing.Point(182, 33);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(171, 20);
            this.tNombre.TabIndex = 0;
            // 
            // AltaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 342);
            this.Controls.Add(this.groupBox1);
            this.Name = "AltaRol";
            this.Text = "Alta de roles";
            this.Load += new System.EventHandler(this.AltaRol_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listFuncionalidad;
        private System.Windows.Forms.ComboBox cFuncionalidad;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bAlta;
        private System.Windows.Forms.Button bLimpiarFuncLista;
        private System.Windows.Forms.Button bQuitarFuncLista;
        private System.Windows.Forms.Button bAgregarFuncLista;
    }
}