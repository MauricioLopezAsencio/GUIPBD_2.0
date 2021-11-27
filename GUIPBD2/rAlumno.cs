using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIPBD2
{
    public partial class rAlumno : Form
    {
        public rAlumno()
        {
            InitializeComponent();
        }

        private void rAlumno_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'PBDDataSet.Alumno' Puede moverla o quitarla según sea necesario.
            this.AlumnoTableAdapter.Fill(this.PBDDataSet.Alumno);

            this.reportViewer1.RefreshReport();
        }
    }
}
