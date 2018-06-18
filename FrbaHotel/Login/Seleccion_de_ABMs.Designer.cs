namespace FrbaHotel.Login
{
    partial class Seleccion_de_ABMs
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
            this.btnRoles = new System.Windows.Forms.Button();
            this.btnHotel = new System.Windows.Forms.Button();
            this.btnHabitacion = new System.Windows.Forms.Button();
            this.btnEstadia = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRoles
            // 
            this.btnRoles.Location = new System.Drawing.Point(111, 23);
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.Size = new System.Drawing.Size(111, 38);
            this.btnRoles.TabIndex = 19;
            this.btnRoles.Text = "ABM Rol";
            this.btnRoles.UseVisualStyleBackColor = true;
            this.btnRoles.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnHotel
            // 
            this.btnHotel.Location = new System.Drawing.Point(111, 155);
            this.btnHotel.Name = "btnHotel";
            this.btnHotel.Size = new System.Drawing.Size(111, 38);
            this.btnHotel.TabIndex = 20;
            this.btnHotel.Text = "ABM Hotel";
            this.btnHotel.UseVisualStyleBackColor = true;
            this.btnHotel.Click += new System.EventHandler(this.btnHotel_Click);
            // 
            // btnHabitacion
            // 
            this.btnHabitacion.Location = new System.Drawing.Point(111, 199);
            this.btnHabitacion.Name = "btnHabitacion";
            this.btnHabitacion.Size = new System.Drawing.Size(111, 38);
            this.btnHabitacion.TabIndex = 21;
            this.btnHabitacion.Text = "ABM Habitación";
            this.btnHabitacion.UseVisualStyleBackColor = true;
            this.btnHabitacion.Click += new System.EventHandler(this.btnHabitacion_Click);
            // 
            // btnEstadia
            // 
            this.btnEstadia.Location = new System.Drawing.Point(111, 243);
            this.btnEstadia.Name = "btnEstadia";
            this.btnEstadia.Size = new System.Drawing.Size(111, 38);
            this.btnEstadia.TabIndex = 22;
            this.btnEstadia.Text = "ABM  Regimen de Estadia";
            this.btnEstadia.UseVisualStyleBackColor = true;
            this.btnEstadia.Click += new System.EventHandler(this.btnEstadia_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(111, 111);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(111, 38);
            this.btnCliente.TabIndex = 23;
            this.btnCliente.Text = "ABM Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.Location = new System.Drawing.Point(111, 67);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(111, 38);
            this.btnUsuario.TabIndex = 24;
            this.btnUsuario.Text = "ABM Usuario";
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(251, 297);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 25;
            this.button7.Text = "Volver";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Seleccion_de_ABMs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 332);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnEstadia);
            this.Controls.Add(this.btnHabitacion);
            this.Controls.Add(this.btnHotel);
            this.Controls.Add(this.btnRoles);
            this.Name = "Seleccion_de_ABMs";
            this.Text = "Seleccion_de_ABM";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRoles;
        private System.Windows.Forms.Button btnHotel;
        private System.Windows.Forms.Button btnHabitacion;
        private System.Windows.Forms.Button btnEstadia;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button button7;
    }
}