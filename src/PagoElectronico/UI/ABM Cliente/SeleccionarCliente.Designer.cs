namespace PagoElectronico.UI.ABM_Cliente
{
    partial class SeleccionarCliente
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
            this._nombre = new System.Windows.Forms.Label();
            this._apellido = new System.Windows.Forms.Label();
            this._nroIdentificacion = new System.Windows.Forms.Label();
            this._tipoIdentificacion = new System.Windows.Forms.Label();
            this._email = new System.Windows.Forms.Label();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.nroDocTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.tipoDocComboBox = new System.Windows.Forms.ComboBox();
            this.buscarGrilla = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.modificarButton = new System.Windows.Forms.Button();
            this.darDeBajaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 99);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(681, 162);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // _nombre
            // 
            this._nombre.AutoSize = true;
            this._nombre.Location = new System.Drawing.Point(13, 13);
            this._nombre.Name = "_nombre";
            this._nombre.Size = new System.Drawing.Size(47, 13);
            this._nombre.TabIndex = 1;
            this._nombre.Text = "Nombre:";
            // 
            // _apellido
            // 
            this._apellido.AutoSize = true;
            this._apellido.Location = new System.Drawing.Point(14, 50);
            this._apellido.Name = "_apellido";
            this._apellido.Size = new System.Drawing.Size(47, 13);
            this._apellido.TabIndex = 2;
            this._apellido.Text = "Apellido:";
            // 
            // _nroIdentificacion
            // 
            this._nroIdentificacion.AutoSize = true;
            this._nroIdentificacion.Location = new System.Drawing.Point(205, 50);
            this._nroIdentificacion.Name = "_nroIdentificacion";
            this._nroIdentificacion.Size = new System.Drawing.Size(105, 13);
            this._nroIdentificacion.TabIndex = 3;
            this._nroIdentificacion.Text = "Nro. de Identifiación:";
            // 
            // _tipoIdentificacion
            // 
            this._tipoIdentificacion.AutoSize = true;
            this._tipoIdentificacion.Location = new System.Drawing.Point(201, 13);
            this._tipoIdentificacion.Name = "_tipoIdentificacion";
            this._tipoIdentificacion.Size = new System.Drawing.Size(109, 13);
            this._tipoIdentificacion.TabIndex = 4;
            this._tipoIdentificacion.Text = "Tipo de Identificación";
            // 
            // _email
            // 
            this._email.AutoSize = true;
            this._email.Location = new System.Drawing.Point(442, 46);
            this._email.Name = "_email";
            this._email.Size = new System.Drawing.Size(35, 13);
            this._email.TabIndex = 5;
            this._email.Text = "Email:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(66, 10);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreTextBox.TabIndex = 6;
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.Location = new System.Drawing.Point(66, 47);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(100, 20);
            this.apellidoTextBox.TabIndex = 7;
            // 
            // nroDocTextBox
            // 
            this.nroDocTextBox.Location = new System.Drawing.Point(319, 43);
            this.nroDocTextBox.Name = "nroDocTextBox";
            this.nroDocTextBox.Size = new System.Drawing.Size(100, 20);
            this.nroDocTextBox.TabIndex = 8;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(483, 43);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 9;
            // 
            // tipoDocComboBox
            // 
            this.tipoDocComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoDocComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tipoDocComboBox.FormattingEnabled = true;
            this.tipoDocComboBox.Location = new System.Drawing.Point(319, 10);
            this.tipoDocComboBox.Name = "tipoDocComboBox";
            this.tipoDocComboBox.Size = new System.Drawing.Size(121, 21);
            this.tipoDocComboBox.TabIndex = 10;
            this.tipoDocComboBox.SelectedIndexChanged += new System.EventHandler(this.tipoDocComboBox_SelectedIndexChanged);
            // 
            // buscarGrilla
            // 
            this.buscarGrilla.Location = new System.Drawing.Point(473, 73);
            this.buscarGrilla.Name = "buscarGrilla";
            this.buscarGrilla.Size = new System.Drawing.Size(121, 24);
            this.buscarGrilla.TabIndex = 11;
            this.buscarGrilla.Text = "Buscar";
            this.buscarGrilla.UseVisualStyleBackColor = true;
            this.buscarGrilla.Click += new System.EventHandler(this.buscarGrilla_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 24);
            this.button1.TabIndex = 12;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // modificarButton
            // 
            this.modificarButton.Location = new System.Drawing.Point(66, 274);
            this.modificarButton.Name = "modificarButton";
            this.modificarButton.Size = new System.Drawing.Size(121, 23);
            this.modificarButton.TabIndex = 13;
            this.modificarButton.Text = "Modificar";
            this.modificarButton.UseVisualStyleBackColor = true;
            this.modificarButton.Click += new System.EventHandler(this.modificarButton_Click);
            // 
            // darDeBajaButton
            // 
            this.darDeBajaButton.Location = new System.Drawing.Point(473, 274);
            this.darDeBajaButton.Name = "darDeBajaButton";
            this.darDeBajaButton.Size = new System.Drawing.Size(121, 23);
            this.darDeBajaButton.TabIndex = 14;
            this.darDeBajaButton.Text = "Dar de baja";
            this.darDeBajaButton.UseVisualStyleBackColor = true;
            this.darDeBajaButton.Click += new System.EventHandler(this.darDeBajaButton_Click);
            // 
            // SeleccionarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 309);
            this.Controls.Add(this.darDeBajaButton);
            this.Controls.Add(this.modificarButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buscarGrilla);
            this.Controls.Add(this.tipoDocComboBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.nroDocTextBox);
            this.Controls.Add(this.apellidoTextBox);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this._email);
            this.Controls.Add(this._tipoIdentificacion);
            this.Controls.Add(this._nroIdentificacion);
            this.Controls.Add(this._apellido);
            this.Controls.Add(this._nombre);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SeleccionarCliente";
            this.Text = "SeleccionarCliente";
            this.Load += new System.EventHandler(this.SeleccionarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label _nombre;
        private System.Windows.Forms.Label _apellido;
        private System.Windows.Forms.Label _nroIdentificacion;
        private System.Windows.Forms.Label _tipoIdentificacion;
        private System.Windows.Forms.Label _email;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.TextBox nroDocTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.ComboBox tipoDocComboBox;
        private System.Windows.Forms.Button buscarGrilla;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button modificarButton;
        private System.Windows.Forms.Button darDeBajaButton;
    }
}