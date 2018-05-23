namespace FrbaHotel.AbmHabitacion
{
    partial class ModificarHabitacion
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
            this.btCancelar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.S = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textPiso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textNumeroDeHabitacion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.S)).BeginInit();
            this.SuspendLayout();
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(197, 103);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(81, 32);
            this.btCancelar.TabIndex = 35;
            this.btCancelar.Text = "CANCELAR";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(53, 103);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(81, 32);
            this.btEliminar.TabIndex = 34;
            this.btEliminar.Text = "MODIFICAR";
            this.btEliminar.UseVisualStyleBackColor = true;
            // 
            // S
            // 
            this.S.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.S.Location = new System.Drawing.Point(10, 141);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(308, 166);
            this.S.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Piso:";
            // 
            // textPiso
            // 
            this.textPiso.Location = new System.Drawing.Point(178, 71);
            this.textPiso.Name = "textPiso";
            this.textPiso.Size = new System.Drawing.Size(100, 20);
            this.textPiso.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Numero Habitacion:";
            // 
            // textNumeroDeHabitacion
            // 
            this.textNumeroDeHabitacion.Location = new System.Drawing.Point(178, 37);
            this.textNumeroDeHabitacion.Name = "textNumeroDeHabitacion";
            this.textNumeroDeHabitacion.Size = new System.Drawing.Size(100, 20);
            this.textNumeroDeHabitacion.TabIndex = 29;
            // 
            // ModificarHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 345);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.S);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textPiso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNumeroDeHabitacion);
            this.Name = "ModificarHabitacion";
            this.Text = "Modificar Habitacion";
            ((System.ComponentModel.ISupportInitialize)(this.S)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.DataGridView S;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textPiso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNumeroDeHabitacion;
    }
}