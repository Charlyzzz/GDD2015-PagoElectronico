namespace PagoElectronico.UI
{
    partial class ABM_Form
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
            this.altaRadioButton = new System.Windows.Forms.RadioButton();
            this.modificarDarDeBajaRadioButton = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione una acción a realizar:";
            // 
            // altaRadioButton
            // 
            this.altaRadioButton.AutoSize = true;
            this.altaRadioButton.Location = new System.Drawing.Point(15, 34);
            this.altaRadioButton.Name = "altaRadioButton";
            this.altaRadioButton.Size = new System.Drawing.Size(126, 17);
            this.altaRadioButton.TabIndex = 2;
            this.altaRadioButton.TabStop = true;
            this.altaRadioButton.Text = "Dar de alta un cliente";
            this.altaRadioButton.UseVisualStyleBackColor = true;
            // 
            // modificarDarDeBajaRadioButton
            // 
            this.modificarDarDeBajaRadioButton.AutoSize = true;
            this.modificarDarDeBajaRadioButton.Location = new System.Drawing.Point(15, 57);
            this.modificarDarDeBajaRadioButton.Name = "modificarDarDeBajaRadioButton";
            this.modificarDarDeBajaRadioButton.Size = new System.Drawing.Size(178, 17);
            this.modificarDarDeBajaRadioButton.TabIndex = 3;
            this.modificarDarDeBajaRadioButton.TabStop = true;
            this.modificarDarDeBajaRadioButton.Text = "Modificar/Dar de Baja un cliente";
            this.modificarDarDeBajaRadioButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 21);
            this.button1.TabIndex = 5;
            this.button1.Text = "Siguiente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ABM_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 123);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.modificarDarDeBajaRadioButton);
            this.Controls.Add(this.altaRadioButton);
            this.Controls.Add(this.label1);
            this.Name = "ABM_Form";
            this.Text = "ABM_Form";
            this.Load += new System.EventHandler(this.ABM_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.RadioButton altaRadioButton;
        protected System.Windows.Forms.RadioButton modificarDarDeBajaRadioButton;
        protected System.Windows.Forms.Button button1;
    }
}