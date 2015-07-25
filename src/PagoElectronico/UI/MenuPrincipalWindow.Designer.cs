namespace PagoElectronico.UI
{
    partial class MenuPrincipalWindow
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.rolLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.funcionalidadBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cerrarSesionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(13, 13);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(63, 13);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Bienvenido:";
            // 
            // rolLabel
            // 
            this.rolLabel.AutoSize = true;
            this.rolLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rolLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.rolLabel.Location = new System.Drawing.Point(13, 36);
            this.rolLabel.Name = "rolLabel";
            this.rolLabel.Size = new System.Drawing.Size(39, 13);
            this.rolLabel.TabIndex = 1;
            this.rolLabel.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccione una funcionalidad:";
            // 
            // funcionalidadBox
            // 
            this.funcionalidadBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.funcionalidadBox.FormattingEnabled = true;
            this.funcionalidadBox.Location = new System.Drawing.Point(16, 82);
            this.funcionalidadBox.Name = "funcionalidadBox";
            this.funcionalidadBox.Size = new System.Drawing.Size(263, 21);
            this.funcionalidadBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Abrir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cerrarSesionButton
            // 
            this.cerrarSesionButton.Location = new System.Drawing.Point(172, 8);
            this.cerrarSesionButton.Name = "cerrarSesionButton";
            this.cerrarSesionButton.Size = new System.Drawing.Size(107, 23);
            this.cerrarSesionButton.TabIndex = 5;
            this.cerrarSesionButton.Text = "Cerrar Sesion";
            this.cerrarSesionButton.UseVisualStyleBackColor = true;
            this.cerrarSesionButton.Click += new System.EventHandler(this.cerrarSesionButton_Click);
            // 
            // MenuPrincipalWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 158);
            this.Controls.Add(this.cerrarSesionButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.funcionalidadBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rolLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "MenuPrincipalWindow";
            this.Text = "MenuPrincipal";            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label rolLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox funcionalidadBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cerrarSesionButton;
    }
}