namespace Practico3._2
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
            this.LDni = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.LNya = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.LModificar = new System.Windows.Forms.Label();
            this.TDni = new System.Windows.Forms.TextBox();
            this.Tapellido = new System.Windows.Forms.TextBox();
            this.Tnombre = new System.Windows.Forms.TextBox();
            this.TEliminar = new System.Windows.Forms.Button();
            this.BGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.Location = new System.Drawing.Point(53, 70);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(26, 13);
            this.LDni.TabIndex = 0;
            this.LDni.Text = "DNI";
            this.LDni.Click += new System.EventHandler(this.label1_Click);
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Location = new System.Drawing.Point(53, 145);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(44, 13);
            this.LNombre.TabIndex = 1;
            this.LNombre.Text = "Nombre";
            // 
            // LNya
            // 
            this.LNya.AutoSize = true;
            this.LNya.Location = new System.Drawing.Point(33, 18);
            this.LNya.Name = "LNya";
            this.LNya.Size = new System.Drawing.Size(92, 13);
            this.LNya.TabIndex = 2;
            this.LNya.Text = "Nombre y Apellido";
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Location = new System.Drawing.Point(51, 109);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(44, 13);
            this.LApellido.TabIndex = 3;
            this.LApellido.Text = "Apellido";
            // 
            // LModificar
            // 
            this.LModificar.AutoSize = true;
            this.LModificar.ForeColor = System.Drawing.Color.Red;
            this.LModificar.Location = new System.Drawing.Point(131, 18);
            this.LModificar.Name = "LModificar";
            this.LModificar.Size = new System.Drawing.Size(50, 13);
            this.LModificar.TabIndex = 4;
            this.LModificar.Text = "Modificar";
            // 
            // TDni
            // 
            this.TDni.Location = new System.Drawing.Point(101, 67);
            this.TDni.Name = "TDni";
            this.TDni.Size = new System.Drawing.Size(100, 20);
            this.TDni.TabIndex = 5;
            this.TDni.TextChanged += new System.EventHandler(this.TDni_TextChanged);
            this.TDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TDni_KeyPress);
            // 
            // Tapellido
            // 
            this.Tapellido.Location = new System.Drawing.Point(101, 142);
            this.Tapellido.Name = "Tapellido";
            this.Tapellido.Size = new System.Drawing.Size(100, 20);
            this.Tapellido.TabIndex = 6;
            this.Tapellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tapellido_KeyPress);
            // 
            // Tnombre
            // 
            this.Tnombre.Location = new System.Drawing.Point(101, 106);
            this.Tnombre.Name = "Tnombre";
            this.Tnombre.Size = new System.Drawing.Size(100, 20);
            this.Tnombre.TabIndex = 7;
            this.Tnombre.TextChanged += new System.EventHandler(this.Tnombre_TextChanged);
            this.Tnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tnombre_KeyPress);
            // 
            // TEliminar
            // 
            this.TEliminar.Location = new System.Drawing.Point(36, 230);
            this.TEliminar.Name = "TEliminar";
            this.TEliminar.Size = new System.Drawing.Size(75, 23);
            this.TEliminar.TabIndex = 8;
            this.TEliminar.Text = "Eliminar";
            this.TEliminar.UseVisualStyleBackColor = true;
            this.TEliminar.Click += new System.EventHandler(this.TEliminar_Click);
            // 
            // BGuardar
            // 
            this.BGuardar.Location = new System.Drawing.Point(200, 229);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(75, 23);
            this.BGuardar.TabIndex = 9;
            this.BGuardar.Text = "Guardar";
            this.BGuardar.UseVisualStyleBackColor = true;
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 315);
            this.Controls.Add(this.BGuardar);
            this.Controls.Add(this.TEliminar);
            this.Controls.Add(this.Tnombre);
            this.Controls.Add(this.Tapellido);
            this.Controls.Add(this.TDni);
            this.Controls.Add(this.LModificar);
            this.Controls.Add(this.LApellido);
            this.Controls.Add(this.LNya);
            this.Controls.Add(this.LNombre);
            this.Controls.Add(this.LDni);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pequeño Formulario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LDni;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LNya;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label LModificar;
        private System.Windows.Forms.TextBox TDni;
        private System.Windows.Forms.TextBox Tapellido;
        private System.Windows.Forms.TextBox Tnombre;
        private System.Windows.Forms.Button TEliminar;
        private System.Windows.Forms.Button BGuardar;
    }
}

