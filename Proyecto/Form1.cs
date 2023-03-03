using System.Diagnostics;
using System.Drawing;
using System;
using System.Drawing;
using System.Text.RegularExpressions;

namespace Proyecto
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Goldenrod;
           

        }


        private void btnRegistro_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtNombreUsuario.Text;
            string correo = txtCorreo.Text;
            string semestre = txtSemestre.Text;
            string contrasenia = txtContrasenia.Text;
            string confirmarContrasenia = txtConfirmarContrasenia.Text;

            // Validar que los campos no est�n vac�os
            if (string.IsNullOrWhiteSpace(nombreUsuario) ||
                string.IsNullOrWhiteSpace(correo) ||
                string.IsNullOrWhiteSpace(semestre) ||
                string.IsNullOrWhiteSpace(contrasenia) ||
                string.IsNullOrWhiteSpace(confirmarContrasenia))
            {
                MessageBox.Show("Por favor complete todos los campos.");
                return;
            }

            // Validar que las contrase�as coincidan
            if (contrasenia != confirmarContrasenia)
            {
                MessageBox.Show("Las contrase�as no coinciden.");
                return;
            }

            // Validar que el correo tenga un formato v�lido
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (!regex.IsMatch(correo))
            {
                MessageBox.Show("Ingrese una direcci�n de correo electr�nico v�lida.");
                return;
            }

            // TODO: Agregar validaciones adicionales seg�n tus necesidades, como verificar si el nombre de usuario ya est� en uso

            // Si llegamos hasta aqu�, el registro fue exitoso
            MessageBox.Show("Registro exitoso.");

            // Cambiar a la ventana de inicio de sesi�n
            this.Hide();
            Form ventanaInicioSesion = new Form();
            // TODO: Agregar controles y l�gica para la ventana de inicio de sesi�n seg�n tus necesidades
            ventanaInicioSesion.Show();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide(); //ocultar la ventana actual
            Form ventanaInicioSesion = new Form(); //crear una instancia de la ventana anterior
            ventanaInicioSesion.Show(); //mostrar la ventana anterior
        }
    }
}