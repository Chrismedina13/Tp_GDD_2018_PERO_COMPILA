namespace FrbaHotel.AbmCliente
{
    partial class ABM_Cliente
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
            this.AgregarCliente = new System.Windows.Forms.Button();
            this.ModificarCliente = new System.Windows.Forms.Button();
            this.EliminarCliente = new System.Windows.Forms.Button();
            this.Volver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AgregarCliente
            // 
            this.AgregarCliente.Location = new System.Drawing.Point(83, 12);
            this.AgregarCliente.Name = "AgregarCliente";
            this.AgregarCliente.Size = new System.Drawing.Size(131, 60);
            this.AgregarCliente.TabIndex = 0;
            this.AgregarCliente.Text = "AGREGAR CLIENTE";
            this.AgregarCliente.UseVisualStyleBackColor = true;
            // 
            // ModificarCliente
            // 
            this.ModificarCliente.Location = new System.Drawing.Point(83, 107);
            this.ModificarCliente.Name = "ModificarCliente";
            this.ModificarCliente.Size = new System.Drawing.Size(131, 60);
            this.ModificarCliente.TabIndex = 1;
            this.ModificarCliente.Text = "MODIFICAR CLIENTE";
            this.ModificarCliente.UseVisualStyleBackColor = true;
            this.ModificarCliente.Click += new System.EventHandler(this.button2_Click);
            // 
            // EliminarCliente
            // 
            this.EliminarCliente.Location = new System.Drawing.Point(83, 205);
            this.EliminarCliente.Name = "EliminarCliente";
            this.EliminarCliente.Size = new System.Drawing.Size(131, 60);
            this.EliminarCliente.TabIndex = 2;
            this.EliminarCliente.Text = "ELIMINAR CLIENTE";
            this.EliminarCliente.UseVisualStyleBackColor = true;
            // 
            // Volver
            // 
            this.Volver.Location = new System.Drawing.Point(106, 287);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(87, 30);
            this.Volver.TabIndex = 3;
            this.Volver.Text = "Volver";
            this.Volver.UseVisualStyleBackColor = true;
            // 
            // ABM_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 329);
            this.Controls.Add(this.Volver);
            this.Controls.Add(this.EliminarCliente);
            this.Controls.Add(this.ModificarCliente);
            this.Controls.Add(this.AgregarCliente);
            this.Name = "ABM_Cliente";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AgregarCliente;
        private System.Windows.Forms.Button ModificarCliente;
        private System.Windows.Forms.Button EliminarCliente;
        private System.Windows.Forms.Button Volver;
    }
}