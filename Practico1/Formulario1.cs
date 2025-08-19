using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico1
{
    public partial class MiPrimerFroms : Form
    {
        public MiPrimerFroms()
        {
            InitializeComponent();
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            /**
             * textBoxMulti.Clear() es un método propio del TextBox 
             * borra TODO el contenido del control, dejándolo vacío.
             * 
             */
             textBoxMulti.Clear();
        }


        private void BGuardar_Click(object sender, EventArgs e)
        {
            string apellido = textBoxApellido.Text;
            string nombre = textBoxNombre.Text;

            /**
             * txtApellido.Text = lo que escribe el usuario en la caja de apellido
             * string.IsNullOrWhiteSpace es un metodo de C# que devuelve true si el texto:
             * es NULL, Vacio o solo tiene espacios en blanco
             * 
             * MassageBox.Show(...) muestra un mensaje que se especifique dentro
             * return; corta la ejecucion del metodo en ese punto 
             */

            if (string.IsNullOrWhiteSpace(textBoxApellido.Text) || string.IsNullOrWhiteSpace(textBoxNombre.Text))
            {
                MessageBox.Show("Completar Apellido y Nombre.");
                return;
            }

            string completo = (apellido + " " + nombre).Trim(); //.Trim saca espacios sobrantes
           
            textBoxMulti.Text = completo;

        }

        private void textBoxMulti_TextChanged(object sender, EventArgs e)
        {

        }

        private void LApellido_Click(object sender, EventArgs e)
        {

        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            /**
             * e.control detecta si la tecla ctrl esta presionada
             * e.KeyCode == Keys.S detecta si la tecla S se presiono
             * si ambas son verdaderas se ejecuta End
             */
            if(e.Control && e.KeyCode == Keys.S)
            {
                Application.Exit();
            }
        }
    }
}
