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

            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(nombreUsuario) ||
                string.IsNullOrWhiteSpace(correo) ||
                string.IsNullOrWhiteSpace(semestre) ||
                string.IsNullOrWhiteSpace(contrasenia) ||
                string.IsNullOrWhiteSpace(confirmarContrasenia))
            {
                MessageBox.Show("Por favor complete todos los campos.");
                return;
            }

            // Validar que las contraseñas coincidan
            if (contrasenia != confirmarContrasenia)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }

            // Validar que el correo tenga un formato válido
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (!regex.IsMatch(correo))
            {
                MessageBox.Show("Ingrese una dirección de correo electrónico válida.");
                return;
            }

            // TODO: Agregar validaciones adicionales según tus necesidades, como verificar si el nombre de usuario ya está en uso

            // Si llegamos hasta aquí, el registro fue exitoso
            MessageBox.Show("Registro exitoso.");

            // Cambiar a la ventana de inicio de sesión
            this.Hide();
            Form ventanaInicioSesion = new Form();
            // TODO: Agregar controles y lógica para la ventana de inicio de sesión según tus necesidades
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