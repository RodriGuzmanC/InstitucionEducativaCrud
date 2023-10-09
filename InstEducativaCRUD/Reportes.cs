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
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet.sp_ObtenerNiveles' Puede moverla o quitarla según sea necesario.
            this.sp_ObtenerNivelesTableAdapter.Fill(this.dataSet.sp_ObtenerNiveles);
            // TODO: esta línea de código carga datos en la tabla 'dataSet.sp_ObtenerEstudiantes' Puede moverla o quitarla según sea necesario.
            this.sp_ObtenerEstudiantesTableAdapter.Fill(this.dataSet.sp_ObtenerEstudiantes);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnReporteAlumno_Click(object sender, EventArgs e)
        {
            MuestraAlumno ventanaAlumno = new MuestraAlumno();
            ventanaAlumno.ShowDialog();
        }

        private void btnReporteNivel_Click(object sender, EventArgs e)
        {
            MuestraNivel ventanaNivel = new MuestraNivel();
            ventanaNivel.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
