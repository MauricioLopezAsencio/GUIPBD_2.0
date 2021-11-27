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
    public partial class fAlumno : Form
    {
        string Modo = "";
        public fAlumno()
        {
            InitializeComponent();
        }

        private void alumnoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.alumnoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pBDDataSet);

        }

        private void fAlumno_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pBDDataSet.Alumno' Puede moverla o quitarla según sea necesario.
            this.CargaDatos();

        }

        private void CargaDatos()
        {
            try
            {
                this.alumnoTableAdapter.Fill(this.pBDDataSet.Alumno);
                this.ModoEdicion("lectura");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la carga de datos: " + ex.Message.ToString());
            }
        }

        private void ModoEdicion(String modo)
        {
            this.Modo = modo;
            switch (modo)
            {
                case "lectura":
                    this.pnlBotones.Enabled = true;
                    this.pnlDetalle.Enabled = false;
                    this.alumnoDataGridView.Enabled = true;
                    this.alumnoBindingNavigator.Enabled = true;

                    break;

                case "insertar":
                    this.pnlBotones.Enabled = false;
                    this.pnlDetalle.Enabled = true;
                    this.alumnoDataGridView.Enabled = false;
                    this.alumnoBindingNavigator.Enabled = false;
                    break;

                case "actualizar":
                    this.pnlBotones.Enabled = false;
                    this.pnlDetalle.Enabled = true;
                    this.alumnoDataGridView.Enabled = false;
                    this.alumnoBindingNavigator.Enabled = false;
                    break;
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            this.ModoEdicion("insertar");
            this.iDAlumnoTextBox.Text = "";
            this.nombreTextBox.Text = "";
            this.nombreTextBox.Focus();
            this.primerApellidoTextBox.Text = "";
            this.segundoApellidoTextBox.Text = "";
            this.noControlTextBox.Text = "";
            this.emailTextBox.Text = "";
            this.telefonoTextBox.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.CargaDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ModoEdicion("actualizar");
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("¿Esta seguro de eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    int id = int.Parse(this.iDAlumnoTextBox.Text);
                    this.alumnoTableAdapter.Delete(id);
                    this.CargaDatos();
                }
                else
                {
                    this.CargaDatos();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error eliminar:" + ex.ToString());
            }
        }

        private bool Valida()
        {
            this.errorProvider1.Clear();
            bool validado = true;
            if (this.nombreTextBox.Text.Trim() == "")
            {
                validado = false;
                this.errorProvider1.SetError(this.nombreTextBox, "campo requerido");
            }
            if (this.primerApellidoTextBox.Text.Trim() == "")
            {
                validado = false;
                this.errorProvider1.SetError(this.primerApellidoTextBox, "campo requerido");
            }
            if (this.segundoApellidoTextBox.Text.Trim() == "")
            {
                validado = false;
                this.errorProvider1.SetError(this.segundoApellidoTextBox, "campo requerido");
            }
            if (this.noControlTextBox.Text.Trim() == "")
            {
                validado = false;
                this.errorProvider1.SetError(this.noControlTextBox, "campo requerido");
            }
            if (this.emailTextBox.Text.Trim() == "")
            {
                validado = false;
                this.errorProvider1.SetError(this.emailTextBox, "campo requerido");
            }
            if (this.telefonoTextBox.Text.Trim() == "")
            {
                validado = false;
                this.errorProvider1.SetError(this.telefonoTextBox, "campo requerido");
            }
            return validado;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Valida())
                {
                    switch (this.Modo)
                    {
                        case "insertar":
                            //ejecuta el insert de la tabla empresa
                            this.alumnoTableAdapter.Insert(this.nombreTextBox.Text, this.primerApellidoTextBox.Text, this.segundoApellidoTextBox.Text, this.noControlTextBox.Text, this.emailTextBox.Text, this.telefonoTextBox.Text);
                            break;
                        case "actualizar":
                            //ejecuta el update de la tabla empresa
                            int id = int.Parse(this.iDAlumnoTextBox.Text);
                            this.alumnoTableAdapter.Update(this.nombreTextBox.Text, this.primerApellidoTextBox.Text, this.segundoApellidoTextBox.Text, this.noControlTextBox.Text, this.emailTextBox.Text, this.telefonoTextBox.Text, id);
                            break;
                    }
                    this.CargaDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message.ToString());
            }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            rAlumno x = new rAlumno();
            x.ShowDialog();
        }
    }

}
