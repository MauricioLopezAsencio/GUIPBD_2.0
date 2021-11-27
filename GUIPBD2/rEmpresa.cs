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
    public partial class rEmpresa : Form
    {
        public rEmpresa()
        {
            InitializeComponent();
        }

        private void rEmpresa_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'PBDDataSet.Empresa' Puede moverla o quitarla según sea necesario.
            this.EmpresaTableAdapter.Fill(this.PBDDataSet.Empresa);

            this.reportViewer1.RefreshReport();
        }
    }
}
