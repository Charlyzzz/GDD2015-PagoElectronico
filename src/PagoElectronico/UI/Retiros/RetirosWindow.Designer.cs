namespace PagoElectronico.UI.Retiros
{
    partial class RetirosWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numeroDocumento = new System.Windows.Forms.TextBox();
            this.tipoDocumento = new System.Windows.Forms.ComboBox();
            this.validarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Va a ser necesario que se verifique";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de Documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Número de Documento";
            // 
            // numeroDocumento
            // 
            this.numeroDocumento.Location = new System.Drawing.Point(133, 114);
            this.numeroDocumento.Name = "numeroDocumento";
            this.numeroDocumento.Size = new System.Drawing.Size(100, 20);
            this.numeroDocumento.TabIndex = 3;
            // 
            // tipoDocumento
            // 
            this.tipoDocumento.FormattingEnabled = true;
            this.tipoDocumento.Location = new System.Drawing.Point(133, 63);
            this.tipoDocumento.Name = "tipoDocumento";
            this.tipoDocumento.Size = new System.Drawing.Size(121, 21);
            this.tipoDocumento.TabIndex = 4;
            // 
            // validarButton
            // 
            this.validarButton.Location = new System.Drawing.Point(93, 158);
            this.validarButton.Name = "validarButton";
            this.validarButton.Size = new System.Drawing.Size(75, 23);
            this.validarButton.TabIndex = 5;
            this.validarButton.Text = "Validar";
            this.validarButton.UseVisualStyleBackColor = true;
            this.validarButton.Click += new System.EventHandler(this.validarButton_Click);
            // 
            // RetirosWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 193);
            this.Controls.Add(this.validarButton);
            this.Controls.Add(this.tipoDocumento);
            this.Controls.Add(this.numeroDocumento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RetirosWindow";
            this.Text = "RetirosWindow";
            this.Load += new System.EventHandler(this.RetirosWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numeroDocumento;
        private System.Windows.Forms.ComboBox tipoDocumento;
        private System.Windows.Forms.Button validarButton;
    }
}