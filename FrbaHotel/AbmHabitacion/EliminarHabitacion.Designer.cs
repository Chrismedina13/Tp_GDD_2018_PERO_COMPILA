﻿namespace FrbaHotel.AbmHabitacion
{
    partial class EliminarHabitacion
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
            this.textNumeroDeHabitacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textPiso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.S = new System.Windows.Forms.DataGridView();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.S)).BeginInit();
            this.SuspendLayout();
            // 
            // textNumeroDeHabitacion
            // 
            this.textNumeroDeHabitacion.Location = new System.Drawing.Point(171, 43);
            this.textNumeroDeHabitacion.Name = "textNumeroDeHabitacion";
            this.textNumeroDeHabitacion.Size = new System.Drawing.Size(100, 20);
            this.textNumeroDeHabitacion.TabIndex = 0;
            this.textNumeroDeHabitacion.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textNumeroHabitacion_KeyUp);

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero Habitacion";
            // 
            // textPiso
            // 
            this.textPiso.Location = new System.Drawing.Point(171, 77);
            this.textPiso.Name = "textPiso";
            this.textPiso.Size = new System.Drawing.Size(100, 20);
            this.textPiso.TabIndex = 2;
            this.textPiso.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textPiso_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Piso";
            // 
            // S
            // 
            this.S.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.S.Location = new System.Drawing.Point(-6, 147);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(308, 166);
            this.S.TabIndex = 25;
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(46, 109);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(81, 32);
            this.btEliminar.TabIndex = 26;
            this.btEliminar.Text = "ELIMINAR";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(190, 109);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(81, 32);
            this.btCancelar.TabIndex = 28;
            this.btCancelar.Text = "CANCELAR";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // EliminarHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 338);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.S);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textPiso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNumeroDeHabitacion);
            this.Name = "EliminarHabitacion";
            this.Text = "Eliminar Habitacion";
            ((System.ComponentModel.ISupportInitialize)(this.S)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNumeroDeHabitacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textPiso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView S;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btCancelar;
    }
}