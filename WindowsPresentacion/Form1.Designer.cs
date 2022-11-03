namespace WindowsPresentacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInsertarEmpleado1 = new System.Windows.Forms.Button();
            this.btnInsertarEmpleado2 = new System.Windows.Forms.Button();
            this.btnMostrarComision = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInsertarEmpleado1
            // 
            this.btnInsertarEmpleado1.Location = new System.Drawing.Point(68, 53);
            this.btnInsertarEmpleado1.Name = "btnInsertarEmpleado1";
            this.btnInsertarEmpleado1.Size = new System.Drawing.Size(148, 26);
            this.btnInsertarEmpleado1.TabIndex = 0;
            this.btnInsertarEmpleado1.Text = "Insertar primer Empleado";
            this.btnInsertarEmpleado1.UseVisualStyleBackColor = true;
            this.btnInsertarEmpleado1.Click += new System.EventHandler(this.btnInsertarEmpleado1_Click);
            // 
            // btnInsertarEmpleado2
            // 
            this.btnInsertarEmpleado2.Location = new System.Drawing.Point(68, 106);
            this.btnInsertarEmpleado2.Name = "btnInsertarEmpleado2";
            this.btnInsertarEmpleado2.Size = new System.Drawing.Size(148, 26);
            this.btnInsertarEmpleado2.TabIndex = 1;
            this.btnInsertarEmpleado2.Text = "Insertar segundo Empleado";
            this.btnInsertarEmpleado2.UseVisualStyleBackColor = true;
            this.btnInsertarEmpleado2.Click += new System.EventHandler(this.btnInsertarEmpleado2_Click);
            // 
            // btnMostrarComision
            // 
            this.btnMostrarComision.Location = new System.Drawing.Point(657, 12);
            this.btnMostrarComision.Name = "btnMostrarComision";
            this.btnMostrarComision.Size = new System.Drawing.Size(104, 48);
            this.btnMostrarComision.TabIndex = 2;
            this.btnMostrarComision.Text = "Mostrar Valor Comision";
            this.btnMostrarComision.UseVisualStyleBackColor = true;
            this.btnMostrarComision.Click += new System.EventHandler(this.btnMostrarComision_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMostrarComision);
            this.Controls.Add(this.btnInsertarEmpleado2);
            this.Controls.Add(this.btnInsertarEmpleado1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInsertarEmpleado1;
        private System.Windows.Forms.Button btnInsertarEmpleado2;
        private System.Windows.Forms.Button btnMostrarComision;
    }
}

