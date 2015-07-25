namespace PagoElectronico.UI.Login
{
    partial class LoginWindow
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
            this.usuarioTextbox = new System.Windows.Forms.TextBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.usuarioLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.olvidoPasswordLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // usuarioTextbox
            // 
            this.usuarioTextbox.Location = new System.Drawing.Point(96, 25);
            this.usuarioTextbox.Name = "usuarioTextbox";
            this.usuarioTextbox.Size = new System.Drawing.Size(153, 20);
            this.usuarioTextbox.TabIndex = 0;
            this.usuarioTextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(96, 67);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(153, 20);
            this.passwordTextbox.TabIndex = 1;
            this.passwordTextbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.passwordTextbox.PasswordChar = '\u25CF';
            // 
            // usuarioLabel
            // 
            this.usuarioLabel.AutoSize = true;
            this.usuarioLabel.Location = new System.Drawing.Point(12, 32);
            this.usuarioLabel.Name = "usuarioLabel";
            this.usuarioLabel.Size = new System.Drawing.Size(43, 13);
            this.usuarioLabel.TabIndex = 2;
            this.usuarioLabel.Text = "Usuario";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(12, 67);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(61, 13);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Contraseña";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(174, 102);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // olvidoPasswordLinkLabel
            // 
            this.olvidoPasswordLinkLabel.AutoSize = true;
            this.olvidoPasswordLinkLabel.Location = new System.Drawing.Point(162, 128);
            this.olvidoPasswordLinkLabel.Name = "olvidoPasswordLinkLabel";
            this.olvidoPasswordLinkLabel.Size = new System.Drawing.Size(110, 13);
            this.olvidoPasswordLinkLabel.TabIndex = 5;
            this.olvidoPasswordLinkLabel.TabStop = true;
            this.olvidoPasswordLinkLabel.Text = "Olvido su contrase;a?";
            this.olvidoPasswordLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 148);
            this.Controls.Add(this.olvidoPasswordLinkLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usuarioLabel);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.usuarioTextbox);
            this.Name = "LoginWindow";
            this.Text = "LoginWindow";            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usuarioTextbox;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Label usuarioLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.LinkLabel olvidoPasswordLinkLabel;
    }
}