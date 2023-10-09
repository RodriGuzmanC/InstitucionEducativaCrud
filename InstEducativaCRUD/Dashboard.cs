using Capa_Datos;
using Capa_Entidad;
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
    public partial class Dashboard : Form
    {
        //GLOBAL
        EstudianteNegocio objL = new EstudianteNegocio();
        private Conexion conexion;

        public string usuarioActual { get; set; }

        public Dashboard()
        {
            InitializeComponent();
            conexion = new Conexion();

        }
        //A BORRAR
        private void label4_Click(object sender, EventArgs e)
        {
        }
        private void panGuardar_Click(object sender, EventArgs e)
        {  
        }
        private void panBuscar_Click(object sender, EventArgs e)
        {  
        }
        private void panEditar_Click(object sender, EventArgs e)
        {   
        }
        private void panEliminar_Click(object sender, EventArgs e)
        {  
        }
        private void panEditar_Paint(object sender, PaintEventArgs e)
        {
        }
        private void panBuscar_Paint(object sender, PaintEventArgs e)
        { 
        }
        private void panBuscar_MouseClick(object sender, MouseEventArgs e)
        {
        }

        //Fuciones
        private void panel3_Click(object sender, EventArgs e)
        {
            try
            {
                Estudiante objE = new Estudiante();
                objE.Id = int.Parse(txtCodigo.Text);
                objE.PrimerNombre = txtPrimerNombre.Text;
                objE.SegundoNombre = txtSegundoNombre.Text;
                objE.PrimerApellido = txtPrimerApellido.Text;
                objE.SegundoApellido = txtSegundoApellido.Text;
                objE.Telefono = txtTelefono.Text;
                objE.Celular = txtCelular.Text;
                objE.Direccion = txtDireccion.Text;
                objE.Email = txtEmail.Text;
                objE.FechaNacimiento = (DateTime)dpFecha.Value;
                objE.Observaciones = txtObservaciones.Text;

                objL.ModificarEstudiante(objE);
                MessageBox.Show(" Modificado correctamente..!!");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al modificar");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Estudiante objE = new Estudiante();
                int codigo = objE.Id = int.Parse(txtCodigo.Text);

                objL.EliminarEstudiante(codigo);
                MessageBox.Show(" eliminacion de alumno correcto..!!");

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al eliminar el alumno");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Estudiante objE = new Estudiante();
                //objE.Id = int.Parse(txtCodigo.Text);
                objE.PrimerNombre = txtPrimerNombre.Text;
                objE.SegundoNombre = txtSegundoNombre.Text;
                objE.PrimerApellido = txtPrimerApellido.Text;
                objE.SegundoApellido = txtSegundoApellido.Text;
                objE.Telefono = txtTelefono.Text;
                objE.Celular = txtCelular.Text;
                objE.Direccion = txtDireccion.Text;
                objE.Email = txtEmail.Text;
                objE.FechaNacimiento = (DateTime)dpFecha.Value;
                objE.Observaciones = txtObservaciones.Text;

                objL.GuardarEstudiante(objE);
                MessageBox.Show(" Guardado correctamente..!!");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al guardar");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {

                int idEstudiante = int.Parse(txtCodigo.Text);

                Estudiante estudiante = objL.BuscarEstudiante(idEstudiante);

                // Verificar si se encontró un estudiante con el ID ingresado
                if (estudiante != null)
                {
                    // Mostrar los datos del estudiante en los campos de texto
                    txtCodigo.Text = estudiante.Id.ToString();
                    txtPrimerNombre.Text = estudiante.PrimerNombre;
                    txtSegundoNombre.Text = estudiante.SegundoNombre;
                    txtPrimerApellido.Text = estudiante.PrimerApellido;
                    txtSegundoApellido.Text = estudiante.SegundoApellido;
                    txtTelefono.Text = estudiante.Telefono;
                    txtCelular.Text = estudiante.Celular;
                    txtDireccion.Text = estudiante.Direccion;
                    txtEmail.Text = estudiante.Email;
                    dpFecha.Value = estudiante.FechaNacimiento;
                    txtObservaciones.Text = estudiante.Observaciones;
                    MessageBox.Show("Estudiante encontrado y cargado correctamente.");
                }
                else
                {
                    MessageBox.Show("Estudiante no encontrado con el ID proporcionado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al buscar el estudiante: " + ex.Message);
            }
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblUsuarioActual.Text = usuarioActual;
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            Reportes reportes = new Reportes();
            reportes.ShowDialog();
        }
    }
}
