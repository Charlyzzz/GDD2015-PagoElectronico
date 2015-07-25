namespace PagoElectronico.UI.ABM_Rol
{
    partial class ModRol
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
            this.bGuardar = new System.Windows.Forms.Button();
            this.bQuitar = new System.Windows.Forms.Button();
            this.bLimpiar = new System.Windows.Forms.Button();
            this.bAgregar = new System.Windows.Forms.Button();
            this.cFuncionalidad = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listFuncionalidad = new System.Windows.Forms.ListBox();
            this.checkHabilitado = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cRol = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bGuardar);
            this.groupBox1.Controls.Add(this.bQuitar);
            this.groupBox1.Controls.Add(this.bLimpiar);
            this.groupBox1.Controls.Add(this.bAgregar);
            this.groupBox1.Controls.Add(this.cFuncionalidad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.listFuncionalidad);
            this.groupBox1.Controls.Add(this.checkHabilitado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cRol);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 212);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modificar rol";
            // 
            // bGuardar
            // 
            this.bGuardar.Location = new System.Drawing.Point(60, 183);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(124, 23);
            this.bGuardar.TabIndex = 10;
            this.bGuardar.Text = "Guardar modificacion";
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // bQuitar
            // 
            this.bQuitar.Location = new System.Drawing.Point(177, 140);
            this.bQuitar.Name = "bQuitar";
            this.bQuitar.Size = new System.Drawing.Size(75, 23);
            this.bQuitar.TabIndex = 9;
            this.bQuitar.Text = "Quitar";
            this.bQuitar.UseVisualStyleBackColor = true;
            this.bQuitar.Click += new System.EventHandler(this.bQuitar_Click);
            // 
            // bLimpiar
            // 
            this.bLimpiar.Location = new System.Drawing.Point(96, 140);
            this.bLimpiar.Name = "bLimpiar";
            this.bLimpiar.Size = new System.Drawing.Size(75, 23);
            this.bLimpiar.TabIndex = 8;
            this.bLimpiar.Text = "Limpiar";
            this.bLimpiar.UseVisualStyleBackColor = true;
            this.bLimpiar.Click += new System.EventHandler(this.bLimpiar_Click);
            // 
            // bAgregar
            // 
            this.bAgregar.Location = new System.Drawing.Point(18, 140);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(75, 23);
            this.bAgregar.TabIndex = 7;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // cFuncionalidad
            // 
            this.cFuncionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cFuncionalidad.FormattingEnabled = true;
            this.cFuncionalidad.Location = new System.Drawing.Point(18, 101);
            this.cFuncionalidad.Name = "cFuncionalidad";
            this.cFuncionalidad.Size = new System.Drawing.Size(230, 21);
            this.cFuncionalidad.TabIndex = 6;
            this.cFuncionalidad.SelectedIndexChanged += new System.EventHandler(this.cFuncionalidad_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Funcionalidades:";
            // 
            // listFuncionalidad
            // 
            this.listFuncionalidad.FormattingEnabled = true;
            this.listFuncionalidad.Location = new System.Drawing.Point(258, 101);
            this.listFuncionalidad.Name = "listFuncionalidad";
            this.listFuncionalidad.Size = new System.Drawing.Size(174, 95);
            this.listFuncionalidad.TabIndex = 4;
            // 
            // checkHabilitado
            // 
            this.checkHabilitado.AutoSize = true;
            this.checkHabilitado.Location = new System.Drawing.Point(215, 61);
            this.checkHabilitado.Name = "checkHabilitado";
            this.checkHabilitado.Size = new System.Drawing.Size(213, 17);
            this.checkHabilitado.TabIndex = 3;
            this.checkHabilitado.Text = "Habilitado (deshabilitar para baja logica)";
            this.checkHabilitado.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccionar rol a modificar";
            // 
            // cRol
            // 
            this.cRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cRol.FormattingEnabled = true;
            this.cRol.Location = new System.Drawing.Point(180, 34);
            this.cRol.Name = "cRol";
            this.cRol.Size = new System.Drawing.Size(161, 21);
            this.cRol.TabIndex = 0;
            this.cRol.SelectedIndexChanged += new System.EventHandler(this.cRol_SelectedIndexChanged);
            // 
            // ModRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 237);
            this.Controls.Add(this.groupBox1);
            this.Name = "ModRol";
            this.Text = "Modificacion de rol";
            this.Load += new System.EventHandler(this.ModRol_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cRol;
        private System.Windows.Forms.CheckBox checkHabilitado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listFuncionalidad;
        private System.Windows.Forms.ComboBox cFuncionalidad;
        private System.Windows.Forms.Button bQuitar;
        private System.Windows.Forms.Button bLimpiar;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.Button bGuardar;
    }
}