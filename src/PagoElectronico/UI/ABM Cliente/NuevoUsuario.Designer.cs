namespace PagoElectronico.UI.ABM_Cliente
{
    partial class NuevoUsuario
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
            this._username = new System.Windows.Forms.Label();
            this._password = new System.Windows.Forms.Label();
            this._preguntaSecreta = new System.Windows.Forms.Label();
            this._respuestaSecreta = new System.Windows.Forms.Label();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.preguntaTB = new System.Windows.Forms.TextBox();
            this.respuestaTB = new System.Windows.Forms.TextBox();
            this._limpiar = new System.Windows.Forms.Button();
            this._aceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _username
            // 
            this._username.AutoSize = true;
            this._username.Location = new System.Drawing.Point(13, 23);
            this._username.Name = "_username";
            this._username.Size = new System.Drawing.Size(58, 13);
            this._username.TabIndex = 0;
            this._username.Text = "Username:";
            // 
            // _password
            // 
            this._password.AutoSize = true;
            this._password.Location = new System.Drawing.Point(13, 56);
            this._password.Name = "_password";
            this._password.Size = new System.Drawing.Size(56, 13);
            this._password.TabIndex = 1;
            this._password.Text = "Password:";
            // 
            // _preguntaSecreta
            // 
            this._preguntaSecreta.AutoSize = true;
            this._preguntaSecreta.Location = new System.Drawing.Point(4, 84);
            this._preguntaSecreta.Name = "_preguntaSecreta";
            this._preguntaSecreta.Size = new System.Drawing.Size(93, 13);
            this._preguntaSecreta.TabIndex = 5;
            this._preguntaSecreta.Text = "Pregunta Secreta:";
            // 
            // _respuestaSecreta
            // 
            this._respuestaSecreta.AutoSize = true;
            this._respuestaSecreta.Location = new System.Drawing.Point(4, 112);
            this._respuestaSecreta.Name = "_respuestaSecreta";
            this._respuestaSecreta.Size = new System.Drawing.Size(101, 13);
            this._respuestaSecreta.TabIndex = 6;
            this._respuestaSecreta.Text = "Respuesta Secreta:";
            // 
            // usernameTB
            // 
            this.usernameTB.Location = new System.Drawing.Point(134, 20);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(121, 20);
            this.usernameTB.TabIndex = 7;
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(134, 53);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(121, 20);
            this.passwordTB.TabIndex = 8;
            // 
            // preguntaTB
            // 
            this.preguntaTB.Location = new System.Drawing.Point(134, 84);
            this.preguntaTB.Name = "preguntaTB";
            this.preguntaTB.Size = new System.Drawing.Size(121, 20);
            this.preguntaTB.TabIndex = 9;
            // 
            // respuestaTB
            // 
            this.respuestaTB.Location = new System.Drawing.Point(134, 112);
            this.respuestaTB.Name = "respuestaTB";
            this.respuestaTB.Size = new System.Drawing.Size(121, 20);
            this.respuestaTB.TabIndex = 10;
            // 
            // _limpiar
            // 
            this._limpiar.Location = new System.Drawing.Point(16, 145);
            this._limpiar.Name = "_limpiar";
            this._limpiar.Size = new System.Drawing.Size(81, 23);
            this._limpiar.TabIndex = 14;
            this._limpiar.Text = "Limpiar";
            this._limpiar.UseVisualStyleBackColor = true;
            this._limpiar.Click += new System.EventHandler(this._limpiar_Click);
            // 
            // _aceptar
            // 
            this._aceptar.Location = new System.Drawing.Point(271, 145);
            this._aceptar.Name = "_aceptar";
            this._aceptar.Size = new System.Drawing.Size(81, 23);
            this._aceptar.TabIndex = 15;
            this._aceptar.Text = "Aceptar";
            this._aceptar.UseVisualStyleBackColor = true;
            this._aceptar.Click += new System.EventHandler(this._aceptar_Click);
            // 
            // NuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 172);
            this.Controls.Add(this._aceptar);
            this.Controls.Add(this._limpiar);
            this.Controls.Add(this.respuestaTB);
            this.Controls.Add(this.preguntaTB);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.usernameTB);
            this.Controls.Add(this._respuestaSecreta);
            this.Controls.Add(this._preguntaSecreta);
            this.Controls.Add(this._password);
            this.Controls.Add(this._username);
            this.Name = "NuevoUsuario";
            this.Text = "NuevoUsuario";
            this.Load += new System.EventHandler(this.NuevoUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _username;
        private System.Windows.Forms.Label _password;
        private System.Windows.Forms.Label _preguntaSecreta;
        private System.Windows.Forms.Label _respuestaSecreta;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.TextBox preguntaTB;
        private System.Windows.Forms.TextBox respuestaTB;
        private System.Windows.Forms.Button _limpiar;
        private System.Windows.Forms.Button _aceptar;
    }
}