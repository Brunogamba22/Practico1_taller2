using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico3._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // bloquea la tecla
            }

        }

        private void TDnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // bloquea la tecla
            }

        }

        private void TDapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // bloquea la tecla
            }

        }
        //char.IsControl → deja usar teclas como borrar, enter, tab, etc.

        //char.IsDigit → permite solo números.

        //char.IsLetter → permite solo letras.

        //e.Handled = true; → bloquea el ingreso de la tecla si no cumple.
        private void TGuardar_Click(object sender, EventArgs e)
        {
            // validar si alguno está vacío
            if (string.IsNullOrWhiteSpace(LDni.Text) ||
                string.IsNullOrWhiteSpace(LNombre.Text) ||
                string.IsNullOrWhiteSpace(LApellido.Text))
            {
                MessageBox.Show(
                    "Debe completar todos los campos",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error // ícono crítico
                );
                return; // corta la ejecución
            }

            // si todos los campos están completos
            // actualizar el label LModificar
            LModificar.Text = "Cliente listo para insertar";

        }

        //string.IsNullOrWhiteSpace → revisa que no esté vacío ni con solo espacios.
        //MessageBox.Show con MessageBoxIcon.Error → muestra ícono crítico (equivale al MsgBoxStyle.Critical en VB).
        //si todo está correcto → cambia el texto de LModificar.
    }
}
