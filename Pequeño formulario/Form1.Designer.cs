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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LDni = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.LNya = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.LModificar = new System.Windows.Forms.Label();
            this.TDni = new System.Windows.Forms.TextBox();
            this.Tapellido = new System.Windows.Forms.TextBox();
            this.Tnombre = new System.Windows.Forms.TextBox();
            this.panelDatos = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Temail = new System.Windows.Forms.TextBox();
            this.CBNaranja = new System.Windows.Forms.CheckBox();
            this.RBVaron = new System.Windows.Forms.RadioButton();
            this.RBMujer = new System.Windows.Forms.RadioButton();
            this.CBVisa = new System.Windows.Forms.CheckBox();
            this.CBMaster = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BSalir = new System.Windows.Forms.Button();
            this.pictureCliente = new System.Windows.Forms.PictureBox();
            this.BGuardar = new System.Windows.Forms.Button();
            this.TEliminar = new System.Windows.Forms.Button();
            this.panelDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.Location = new System.Drawing.Point(16, 50);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(30, 13);
            this.LDni.TabIndex = 0;
            this.LDni.Text = "*DNI";
            this.LDni.Click += new System.EventHandler(this.label1_Click);
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Location = new System.Drawing.Point(16, 139);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(48, 13);
            this.LNombre.TabIndex = 1;
            this.LNombre.Text = "*Nombre";
            // 
            // LNya
            // 
            this.LNya.AutoSize = true;
            this.LNya.Location = new System.Drawing.Point(3, 15);
            this.LNya.Name = "LNya";
            this.LNya.Size = new System.Drawing.Size(92, 13);
            this.LNya.TabIndex = 2;
            this.LNya.Text = "Nombre y Apellido";
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Location = new System.Drawing.Point(16, 90);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(48, 13);
            this.LApellido.TabIndex = 3;
            this.LApellido.Text = "*Apellido";
            // 
            // LModificar
            // 
            this.LModificar.AutoSize = true;
            this.LModificar.ForeColor = System.Drawing.Color.Red;
            this.LModificar.Location = new System.Drawing.Point(115, 15);
            this.LModificar.Name = "LModificar";
            this.LModificar.Size = new System.Drawing.Size(50, 13);
            this.LModificar.TabIndex = 4;
            this.LModificar.Text = "Modificar";
            // 
            // TDni
            // 
            this.TDni.Location = new System.Drawing.Point(97, 47);
            this.TDni.Name = "TDni";
            this.TDni.Size = new System.Drawing.Size(100, 20);
            this.TDni.TabIndex = 5;
            this.TDni.TextChanged += new System.EventHandler(this.TDni_TextChanged);
            this.TDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TDni_KeyPress);
            // 
            // Tapellido
            // 
            this.Tapellido.Location = new System.Drawing.Point(97, 132);
            this.Tapellido.Name = "Tapellido";
            this.Tapellido.Size = new System.Drawing.Size(100, 20);
            this.Tapellido.TabIndex = 6;
            this.Tapellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tapellido_KeyPress);
            // 
            // Tnombre
            // 
            this.Tnombre.Location = new System.Drawing.Point(97, 87);
            this.Tnombre.Name = "Tnombre";
            this.Tnombre.Size = new System.Drawing.Size(100, 20);
            this.Tnombre.TabIndex = 7;
            this.Tnombre.TextChanged += new System.EventHandler(this.Tnombre_TextChanged);
            this.Tnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tnombre_KeyPress);
            // 
            // panelDatos
            // 
            this.panelDatos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelDatos.Controls.Add(this.label2);
            this.panelDatos.Controls.Add(this.CBMaster);
            this.panelDatos.Controls.Add(this.CBVisa);
            this.panelDatos.Controls.Add(this.CBNaranja);
            this.panelDatos.Controls.Add(this.Temail);
            this.panelDatos.Controls.Add(this.label1);
            this.panelDatos.Controls.Add(this.TDni);
            this.panelDatos.Controls.Add(this.Tnombre);
            this.panelDatos.Controls.Add(this.Tapellido);
            this.panelDatos.Controls.Add(this.LNya);
            this.panelDatos.Controls.Add(this.LModificar);
            this.panelDatos.Controls.Add(this.LDni);
            this.panelDatos.Controls.Add(this.LApellido);
            this.panelDatos.Controls.Add(this.LNombre);
            this.panelDatos.Location = new System.Drawing.Point(22, 12);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(225, 291);
            this.panelDatos.TabIndex = 10;
            this.panelDatos.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Email";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Temail
            // 
            this.Temail.Location = new System.Drawing.Point(97, 178);
            this.Temail.Name = "Temail";
            this.Temail.Size = new System.Drawing.Size(100, 20);
            this.Temail.TabIndex = 9;
            // 
            // CBNaranja
            // 
            this.CBNaranja.AutoSize = true;
            this.CBNaranja.Location = new System.Drawing.Point(119, 215);
            this.CBNaranja.Name = "CBNaranja";
            this.CBNaranja.Size = new System.Drawing.Size(63, 17);
            this.CBNaranja.TabIndex = 10;
            this.CBNaranja.Text = "Naranja";
            this.CBNaranja.UseVisualStyleBackColor = true;
            this.CBNaranja.CheckedChanged += new System.EventHandler(this.CBNaranja_CheckedChanged);
            // 
            // RBVaron
            // 
            this.RBVaron.AutoSize = true;
            this.RBVaron.Checked = true;
            this.RBVaron.Location = new System.Drawing.Point(289, 134);
            this.RBVaron.Name = "RBVaron";
            this.RBVaron.Size = new System.Drawing.Size(53, 17);
            this.RBVaron.TabIndex = 12;
            this.RBVaron.TabStop = true;
            this.RBVaron.Text = "Varón";
            this.RBVaron.UseVisualStyleBackColor = true;
            this.RBVaron.CheckedChanged += new System.EventHandler(this.RBVaron_CheckedChanged);
            // 
            // RBMujer
            // 
            this.RBMujer.AutoSize = true;
            this.RBMujer.Location = new System.Drawing.Point(359, 134);
            this.RBMujer.Name = "RBMujer";
            this.RBMujer.Size = new System.Drawing.Size(51, 17);
            this.RBMujer.TabIndex = 13;
            this.RBMujer.Text = "Mujer";
            this.RBMujer.UseVisualStyleBackColor = true;
            this.RBMujer.CheckedChanged += new System.EventHandler(this.RBMujer_CheckedChanged);
            // 
            // CBVisa
            // 
            this.CBVisa.AutoSize = true;
            this.CBVisa.Location = new System.Drawing.Point(119, 238);
            this.CBVisa.Name = "CBVisa";
            this.CBVisa.Size = new System.Drawing.Size(46, 17);
            this.CBVisa.TabIndex = 11;
            this.CBVisa.Text = "Visa";
            this.CBVisa.UseVisualStyleBackColor = true;
            this.CBVisa.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // CBMaster
            // 
            this.CBMaster.AutoSize = true;
            this.CBMaster.Location = new System.Drawing.Point(119, 261);
            this.CBMaster.Name = "CBMaster";
            this.CBMaster.Size = new System.Drawing.Size(79, 17);
            this.CBMaster.TabIndex = 12;
            this.CBMaster.Text = "Mastercard";
            this.CBMaster.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tarjeta de creditos";
            // 
            // BSalir
            // 
            this.BSalir.Image = ((System.Drawing.Image)(resources.GetObject("BSalir.Image")));
            this.BSalir.Location = new System.Drawing.Point(335, 296);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(75, 58);
            this.BSalir.TabIndex = 14;
            this.BSalir.UseVisualStyleBackColor = true;
            this.BSalir.Click += new System.EventHandler(this.BSalir_Click);
            // 
            // pictureCliente
            // 
            this.pictureCliente.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureCliente.ErrorImage")));
            this.pictureCliente.Image = ((System.Drawing.Image)(resources.GetObject("pictureCliente.Image")));
            this.pictureCliente.Location = new System.Drawing.Point(318, 46);
            this.pictureCliente.Name = "pictureCliente";
            this.pictureCliente.Size = new System.Drawing.Size(63, 69);
            this.pictureCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureCliente.TabIndex = 11;
            this.pictureCliente.TabStop = false;
            // 
            // BGuardar
            // 
            this.BGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BGuardar.Image")));
            this.BGuardar.Location = new System.Drawing.Point(155, 308);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(75, 54);
            this.BGuardar.TabIndex = 9;
            this.BGuardar.UseVisualStyleBackColor = true;
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // TEliminar
            // 
            this.TEliminar.Image = ((System.Drawing.Image)(resources.GetObject("TEliminar.Image")));
            this.TEliminar.Location = new System.Drawing.Point(58, 308);
            this.TEliminar.Name = "TEliminar";
            this.TEliminar.Size = new System.Drawing.Size(75, 54);
            this.TEliminar.TabIndex = 8;
            this.TEliminar.UseVisualStyleBackColor = true;
            this.TEliminar.Click += new System.EventHandler(this.TEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 366);
            this.Controls.Add(this.BSalir);
            this.Controls.Add(this.RBMujer);
            this.Controls.Add(this.RBVaron);
            this.Controls.Add(this.pictureCliente);
            this.Controls.Add(this.panelDatos);
            this.Controls.Add(this.BGuardar);
            this.Controls.Add(this.TEliminar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pequeño Formulario";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelDatos.ResumeLayout(false);
            this.panelDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCliente)).EndInit();
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
        private System.Windows.Forms.Panel panelDatos;
        private System.Windows.Forms.TextBox Temail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CBNaranja;
        private System.Windows.Forms.PictureBox pictureCliente;
        private System.Windows.Forms.RadioButton RBVaron;
        private System.Windows.Forms.RadioButton RBMujer;
        private System.Windows.Forms.CheckBox CBMaster;
        private System.Windows.Forms.CheckBox CBVisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BSalir;
    }
}

