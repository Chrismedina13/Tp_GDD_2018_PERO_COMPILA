namespace FrbaHotel.AbmHabitacion
{
    partial class ABM_Habitacion
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
            this.Volver = new System.Windows.Forms.Button();
            this.EliminarHabitacion = new System.Windows.Forms.Button();
            this.ModificarHabitacion = new System.Windows.Forms.Button();
            this.AgregarHabitacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Volver
            // 
            this.Volver.Location = new System.Drawing.Point(118, 300);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(87, 30);
            this.Volver.TabIndex = 7;
            this.Volver.Text = "Volver";
            this.Volver.UseVisualStyleBackColor = true;
            // 
            // EliminarHabitacion
            // 
            this.EliminarHabitacion.Location = new System.Drawing.Point(95, 218);
            this.EliminarHabitacion.Name = "EliminarHabitacion";
            this.EliminarHabitacion.Size = new System.Drawing.Size(131, 60);
            this.EliminarHabitacion.TabIndex = 6;
            this.EliminarHabitacion.Text = "ELIMINAR HABITACION";
            this.EliminarHabitacion.UseVisualStyleBackColor = true;
            // 
            // ModificarHabitacion
            // 
            this.ModificarHabitacion.Location = new System.Drawing.Point(95, 120);
            this.ModificarHabitacion.Name = "ModificarHabitacion";
            this.ModificarHabitacion.Size = new System.Drawing.Size(131, 60);
            this.ModificarHabitacion.TabIndex = 5;
            this.ModificarHabitacion.Text = "MODIFICAR HABITACION";
            this.ModificarHabitacion.UseVisualStyleBackColor = true;
            // 
            // AgregarHabitacion
            // 
            this.AgregarHabitacion.Location = new System.Drawing.Point(95, 25);
            this.AgregarHabitacion.Name = "AgregarHabitacion";
            this.AgregarHabitacion.Size = new System.Drawing.Size(131, 60);
            this.AgregarHabitacion.TabIndex = 4;
            this.AgregarHabitacion.Text = "AGREGAR HABITACION";
            this.AgregarHabitacion.UseVisualStyleBackColor = true;
            // 
            // ABM_Habitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 355);
            this.Controls.Add(this.Volver);
            this.Controls.Add(this.EliminarHabitacion);
            this.Controls.Add(this.ModificarHabitacion);
            this.Controls.Add(this.AgregarHabitacion);
            this.Name = "ABM_Habitacion";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Volver;
        private System.Windows.Forms.Button EliminarHabitacion;
        private System.Windows.Forms.Button ModificarHabitacion;
        private System.Windows.Forms.Button AgregarHabitacion;
    }
}