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
    public partial class MuestraNivel : Form
    {
        public MuestraNivel()
        {
            InitializeComponent();
        }

        private void MuestraNivel_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet.sp_ObtenerNiveles' Puede moverla o quitarla según sea necesario.
            this.sp_ObtenerNivelesTableAdapter.Fill(this.dataSet.sp_ObtenerNiveles);

            this.reportViewer1.RefreshReport();
        }
    }
}
