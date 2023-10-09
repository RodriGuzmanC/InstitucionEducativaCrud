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
    public partial class MuestraAlumno : Form
    {
        public MuestraAlumno()
        {
            InitializeComponent();
        }

        private void MuestraAlumno_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet.sp_ObtenerEstudiantes' Puede moverla o quitarla según sea necesario.
            this.sp_ObtenerEstudiantesTableAdapter.Fill(this.dataSet.sp_ObtenerEstudiantes);
            try
            {
                // Refrescar el informe para que muestre los datos recién cargados
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante la carga de datos o la generación del informe
                MessageBox.Show("Error al cargar el informe: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.reportViewer1.RefreshReport();
        }
    }
}
