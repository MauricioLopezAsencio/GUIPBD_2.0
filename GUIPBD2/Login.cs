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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //conectar a la base de datos y va a validar que exixte el usaurio
            //validar si los campos estan llenos 
            if (this.valida())
            {
                //mandar a llamar el procedimiento de usuario para validar si existe 
                this.usuarioTableAdapter.Fill(this.pbdDataSet.Usuario, this.txtUsuario.Text.Trim(), this.txtPassword.Text.Trim());
                //si existe el usuario 
                if (this.pbdDataSet.Usuario.Rows.Count > 0)
                {
                    //existe el usuario ingresamos al menu principal
                    Form1 f = new Form1();
                    this.Hide();
                    f.ShowDialog();
                    this.Close();

                }
                else
                {
                    //tiene que mandar un mensaje diciendo que el usuario o la contraseña son incorrectos
                    MessageBox.Show("El usuario o contraseña son incorrectos", "valida usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private bool valida()
        {
            this.errorProvider1.Clear();
            bool resultado = true;
            //validar el campo de usuario 
            if (txtUsuario.Text.Trim() == "")
            {
                resultado = false;
                this.errorProvider1.SetError(this.txtUsuario, "este campo es requerido");
            }
            //validar el campo de password
            if (txtUsuario.Text.Trim() == "")
            {
                resultado = false;
                this.errorProvider1.SetError(this.txtPassword, "este campo es requerido");
            }

            return resultado;
        }
    }
}
