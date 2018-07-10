namespace FrbaHotel.Login
{
    partial class VentanaPPAL
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
            this.comboFuncionalidades = new System.Windows.Forms.ComboBox();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboFuncionalidades);
            this.groupBox1.Controls.Add(this.botonAceptar);
            this.groupBox1.Location = new System.Drawing.Point(41, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 139);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funcionalidades";
            // 
            // comboFuncionalidades
            // 
            this.comboFuncionalidades.FormattingEnabled = true;
            this.comboFuncionalidades.Location = new System.Drawing.Point(21, 39);
            this.comboFuncionalidades.Name = "comboFuncionalidades";
            this.comboFuncionalidades.Size = new System.Drawing.Size(161, 21);
            this.comboFuncionalidades.TabIndex = 0;
            this.comboFuncionalidades.SelectedIndexChanged += new System.EventHandler(this.comboFuncionalidades_SelectedIndexChanged);
            // 
            // botonAceptar
            // 
            this.botonAceptar.Location = new System.Drawing.Point(48, 74);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(117, 26);
            this.botonAceptar.TabIndex = 3;
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = true;
            this.botonAceptar.Click += new System.EventHandler(this.botonAceptar_Click);
            // 
            // VentanaPPAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 254);
            this.Controls.Add(this.groupBox1);
            this.Name = "VentanaPPAL";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.VentanaPPAL_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboFuncionalidades;
        private System.Windows.Forms.Button botonAceptar;
    }
}