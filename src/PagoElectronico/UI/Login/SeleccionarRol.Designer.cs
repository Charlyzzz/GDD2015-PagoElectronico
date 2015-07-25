namespace PagoElectronico.UI.Login
{
    partial class SeleccionarRol
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
            this.seleccionarButton = new System.Windows.Forms.Button();
            this.rolCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // seleccionarButton
            // 
            this.seleccionarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seleccionarButton.Location = new System.Drawing.Point(197, 25);
            this.seleccionarButton.Name = "seleccionarButton";
            this.seleccionarButton.Size = new System.Drawing.Size(75, 23);
            this.seleccionarButton.TabIndex = 0;
            this.seleccionarButton.Text = "Seleccionar";
            this.seleccionarButton.UseVisualStyleBackColor = true;
            this.seleccionarButton.Click += new System.EventHandler(this.seleccionarButton_Click);
            // 
            // rolCombo
            // 
            this.rolCombo.FormattingEnabled = true;
            this.rolCombo.Location = new System.Drawing.Point(2, 25);
            this.rolCombo.Name = "rolCombo";
            this.rolCombo.Size = new System.Drawing.Size(164, 21);
            this.rolCombo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Por favor, seleccione un rol";
            // 
            // SeleccionarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 56);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rolCombo);
            this.Controls.Add(this.seleccionarButton);
            this.Name = "SeleccionarRol";
            this.Text = "SeleccionarRol";
            this.Load += new System.EventHandler(this.SeleccionarRol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button seleccionarButton;
        private System.Windows.Forms.ComboBox rolCombo;
        private System.Windows.Forms.Label label1;
    }
}