namespace FrbaHotel
{
    partial class VentanaPrincipal
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
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelarReserva = new System.Windows.Forms.Button();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.btnRegistrarConsumible = new System.Windows.Forms.Button();
            this.btnGenerarOmodificarReserva = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnABMs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Elija una fecha de inicio del Sistema:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(97, 66);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(203, 20);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Bienvenido:";
            // 
            // btnCancelarReserva
            // 
            this.btnCancelarReserva.Location = new System.Drawing.Point(238, 172);
            this.btnCancelarReserva.Name = "btnCancelarReserva";
            this.btnCancelarReserva.Size = new System.Drawing.Size(111, 38);
            this.btnCancelarReserva.TabIndex = 27;
            this.btnCancelarReserva.Text = "Cancelar Reserva";
            this.btnCancelarReserva.UseVisualStyleBackColor = true;
            this.btnCancelarReserva.Click += new System.EventHandler(this.button11_Click);
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.Location = new System.Drawing.Point(148, 232);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(111, 38);
            this.btnEstadisticas.TabIndex = 26;
            this.btnEstadisticas.Text = "Listado Estadistico";
            this.btnEstadisticas.UseVisualStyleBackColor = true;
            this.btnEstadisticas.Click += new System.EventHandler(this.button10_Click);
            // 
            // btnRegistrarConsumible
            // 
            this.btnRegistrarConsumible.Location = new System.Drawing.Point(238, 103);
            this.btnRegistrarConsumible.Name = "btnRegistrarConsumible";
            this.btnRegistrarConsumible.Size = new System.Drawing.Size(111, 38);
            this.btnRegistrarConsumible.TabIndex = 22;
            this.btnRegistrarConsumible.Text = "Registrar Consumible";
            this.btnRegistrarConsumible.UseVisualStyleBackColor = true;
            this.btnRegistrarConsumible.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnGenerarOmodificarReserva
            // 
            this.btnGenerarOmodificarReserva.Location = new System.Drawing.Point(68, 172);
            this.btnGenerarOmodificarReserva.Name = "btnGenerarOmodificarReserva";
            this.btnGenerarOmodificarReserva.Size = new System.Drawing.Size(111, 38);
            this.btnGenerarOmodificarReserva.TabIndex = 20;
            this.btnGenerarOmodificarReserva.Text = "Generar o Modificar Reserva";
            this.btnGenerarOmodificarReserva.UseVisualStyleBackColor = true;
            this.btnGenerarOmodificarReserva.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnABMs
            // 
            this.btnABMs.Location = new System.Drawing.Point(68, 103);
            this.btnABMs.Name = "btnABMs";
            this.btnABMs.Size = new System.Drawing.Size(111, 38);
            this.btnABMs.TabIndex = 18;
            this.btnABMs.Text = "ABMs";
            this.btnABMs.UseVisualStyleBackColor = true;
            this.btnABMs.Click += new System.EventHandler(this.button3_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 335);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelarReserva);
            this.Controls.Add(this.btnEstadisticas);
            this.Controls.Add(this.btnRegistrarConsumible);
            this.Controls.Add(this.btnGenerarOmodificarReserva);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnABMs);
            this.Name = "VentanaPrincipal";
            this.Text = "acciones";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelarReserva;
        private System.Windows.Forms.Button btnEstadisticas;
        private System.Windows.Forms.Button btnRegistrarConsumible;
        private System.Windows.Forms.Button btnGenerarOmodificarReserva;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnABMs;
    }
}