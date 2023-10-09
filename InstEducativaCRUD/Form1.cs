using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstEducativaCRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MuestraAlumno ventanaAlumno = new MuestraAlumno();
            ventanaAlumno.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MuestraNivel ventanaNivel = new MuestraNivel();
            ventanaNivel.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string nombreUsuario = txtNombreUsuario.Text;
            string contrasena = txtContra.Text;

            EstudianteNegocio objL = new EstudianteNegocio();


            if (objL.ValidarInicioSesion(nombreUsuario, contrasena))
            {
                // Las credenciales son válidas, permite el acceso.
                Dashboard dashboard = new Dashboard();

                dashboard.usuarioActual = nombreUsuario;
                dashboard.ShowDialog();
                Close();
            }
            else
            {
                // Las credenciales son incorrectas, muestra un mensaje de error.
                MessageBox.Show("Credenciales incorrectas. Intente nuevamente.");
            }
        }
    }
}
