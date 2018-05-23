namespace FrbaHotel.AbmHotel
{
    partial class ABM_Hotel
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
            this.EliminarHotel = new System.Windows.Forms.Button();
            this.ModificarHotel = new System.Windows.Forms.Button();
            this.AgregarHotel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Volver
            // 
            this.Volver.Location = new System.Drawing.Point(118, 296);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(87, 30);
            this.Volver.TabIndex = 11;
            this.Volver.Text = "Volver";
            this.Volver.UseVisualStyleBackColor = true;
            // 
            // EliminarHotel
            // 
            this.EliminarHotel.Location = new System.Drawing.Point(95, 208);
            this.EliminarHotel.Name = "EliminarHotel";
            this.EliminarHotel.Size = new System.Drawing.Size(131, 60);
            this.EliminarHotel.TabIndex = 10;
            this.EliminarHotel.Text = "ELIMINAR HOTEL";
            this.EliminarHotel.UseVisualStyleBackColor = true;
            // 
            // ModificarHotel
            // 
            this.ModificarHotel.Location = new System.Drawing.Point(95, 116);
            this.ModificarHotel.Name = "ModificarHotel";
            this.ModificarHotel.Size = new System.Drawing.Size(131, 60);
            this.ModificarHotel.TabIndex = 9;
            this.ModificarHotel.Text = "MODIFICAR HOTEL";
            this.ModificarHotel.UseVisualStyleBackColor = true;
            // 
            // AgregarHotel
            // 
            this.AgregarHotel.Location = new System.Drawing.Point(95, 21);
            this.AgregarHotel.Name = "AgregarHotel";
            this.AgregarHotel.Size = new System.Drawing.Size(131, 60);
            this.AgregarHotel.TabIndex = 8;
            this.AgregarHotel.Text = "AGREGAR HOTEL";
            this.AgregarHotel.UseVisualStyleBackColor = true;
            // 
            // ABM_Hotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 347);
            this.Controls.Add(this.Volver);
            this.Controls.Add(this.EliminarHotel);
            this.Controls.Add(this.ModificarHotel);
            this.Controls.Add(this.AgregarHotel);
            this.Name = "ABM_Hotel";
            this.Text = "ABM Hotel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Volver;
        private System.Windows.Forms.Button EliminarHotel;
        private System.Windows.Forms.Button ModificarHotel;
        private System.Windows.Forms.Button AgregarHotel;
    }
}