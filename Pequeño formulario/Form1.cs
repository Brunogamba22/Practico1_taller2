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

        private void Tnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true; // bloquea la tecla
            }

        }

        private void Tapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true; // bloquea la tecla
            }

        }
        //char.IsControl → deja usar teclas como borrar, enter, tab, etc.

        //char.IsDigit → permite solo números.

        //char.IsLetter → permite solo letras.

        //e.Handled = true; → bloquea el ingreso de la tecla si no cumple.
        private void BGuardar_Click(object sender, EventArgs e)
        {
            // Validación de campos vacíos
            if (string.IsNullOrWhiteSpace(TDni.Text) ||
                string.IsNullOrWhiteSpace(Tnombre.Text) ||
                string.IsNullOrWhiteSpace(Tapellido.Text))
            {
                MessageBox.Show(
                    "Debe completar todos los campos",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            // Pregunta de confirmación
            DialogResult ask = MessageBox.Show(
                "¿Seguro que desea insertar un nuevo Cliente?",
                "Confirmar Inserción",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1 // por defecto en "Sí"
            );

            if (ask == DialogResult.Yes)
            {
                MessageBox.Show(
                    $"El Cliente: {Tnombre.Text} {Tapellido.Text} se insertó correctamente",
                    "Guardar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // actualizar el label
                LModificar.Text = $"Cliente listo: {Tnombre.Text} {Tapellido.Text}";
            }
        }

        private void TEliminar_Click(object sender, EventArgs e)
        {
            // Mostrar mensaje de advertencia
            DialogResult ask = MessageBox.Show(
                $"Está a punto de eliminar el Cliente: {Tnombre.Text} {Tapellido.Text}",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2 // por defecto en "No"
            );

            if (ask == DialogResult.Yes)
            {
                // limpiar campos
                TDni.Clear();
                Tnombre.Clear();
                Tapellido.Clear();
                LModificar.Text = "";

                // confirmar eliminación
                MessageBox.Show(
                    $"El Cliente: {Tnombre.Text} {Tapellido.Text} se eliminó correctamente",
                    "Eliminar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            // Si elige No, no se hace nada

        }

        private void Tnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void TDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RBMujer_CheckedChanged(object sender, EventArgs e)
        {
            if (RBMujer.Checked) // solo si está marcado
            {
                pictureCliente.Image = Properties.Resources.mujer;
            }
        }

        private void CBNaranja_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RBVaron_CheckedChanged(object sender, EventArgs e)
        {
            if (RBVaron.Checked) // solo si está marcado
            {
                pictureCliente.Image = Properties.Resources.varon;
            }
        }

        //string.IsNullOrWhiteSpace → revisa que no esté vacío ni con solo espacios.
        //MessageBox.Show con MessageBoxIcon.Error → muestra ícono crítico (equivale al MsgBoxStyle.Critical en VB).
        //si todo está correcto → cambia el texto de LModificar.
    }
}
