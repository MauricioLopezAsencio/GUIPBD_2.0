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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fEmpresa x = new fEmpresa();
            x.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fAlumno x = new fAlumno();
            x.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fAlumnoEmpresa x = new fAlumnoEmpresa();
            x.ShowDialog();
        }
    }
}
