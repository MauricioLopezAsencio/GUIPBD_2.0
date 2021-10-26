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
    public partial class fAlumnoEmpresa : Form
    {
        string Modo = "";

        public fAlumnoEmpresa()
        {
            InitializeComponent();
        }

        private void fAlumnoEmpresa_Load(object sender, EventArgs e)
        {
            this.CargaDatos();
        }

        private void CargaDatos()
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'pBDDataSet.Empresa' Puede moverla o quitarla según sea necesario.
                this.empresaTableAdapter.Fill(this.pBDDataSet.Empresa);
                // TODO: esta línea de código carga datos en la tabla 'pBDDataSet.Alumno' Puede moverla o quitarla según sea necesario.
                this.alumnoTableAdapter.Fill(this.pBDDataSet.Alumno);
                // TODO: esta línea de código carga datos en la tabla 'pBDDataSet.VAlumnoEmpresa' Puede moverla o quitarla según sea necesario.
                this.vAlumnoEmpresaTableAdapter.Fill(this.pBDDataSet.VAlumnoEmpresa);

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
                    this.vAlumnoEmpresaDataGridView.Enabled = true;
                    this.vAlumnoEmpresaBindingNavigator.Enabled = true;

                    break;

                case "insertar":
                    this.pnlBotones.Enabled = false;
                    this.pnlDetalle.Enabled = true;
                    this.vAlumnoEmpresaDataGridView.Enabled = false;
                    this.vAlumnoEmpresaBindingNavigator.Enabled = false;
                    break;
                     
                case "actualizar":
                    this.pnlBotones.Enabled = false;
                    this.pnlDetalle.Enabled = true;
                    this.vAlumnoEmpresaDataGridView.Enabled = false;
                    this.vAlumnoEmpresaBindingNavigator.Enabled = false;
                    break;
            }
        }

        private void vAlumnoEmpresaDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.vAlumnoEmpresaDataGridView.Rows.Count == 0)
                    return;
                //sincronizar los conbobox
                this.cboAlumno.SelectedValue = this.vAlumnoEmpresaDataGridView.CurrentRow.Cells
                    ["IdAlumno"].Value.ToString();
                this.cboEmpresa.SelectedValue = this.vAlumnoEmpresaDataGridView.CurrentRow.Cells
                    ["IDEmpresa"].Value.ToString();

            }
            catch(Exception ex) 
            {
                MessageBox.Show("error al sincronizar la grid: " + ex.Message.ToString());
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            this.ModoEdicion("insertar");
            this.iDAlumnoEmpresaTextBox.Text="";
            this.cboAlumno.SelectedIndex = 0;
            this.cboEmpresa.SelectedIndex = 0;
            this.anioInicioNumericUpDown.Value = 0;
            this.anioFinNumericUpDown.Value = 0;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.CargaDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.ModoEdicion("actualizar");
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("¿Esta seguro de eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    int id = int.Parse(this.iDAlumnoEmpresaTextBox.Text);
                    this.alumnoEmpresaTableAdapter.Delete(id);
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                    switch (this.Modo)
                    {
                        case "insertar":
                            //ejecuta el insert de la tabla empresa
                            this.alumnoEmpresaTableAdapter.Insert((int)this.cboAlumno.SelectedValue, 
                                (int)this.cboEmpresa.SelectedValue,
                                (short)this.anioInicioNumericUpDown.Value, 
                                (short)this.anioFinNumericUpDown.Value);
                            break;
                        case "actualizar":
                            //ejecuta el update de la tabla empresa
                            int id = int.Parse(this.iDAlumnoEmpresaTextBox.Text);
                        this.alumnoEmpresaTableAdapter.Update((int)this.cboAlumno.SelectedValue, (int)this.cboEmpresa.SelectedValue, (short)this.anioInicioNumericUpDown.Value, (short)this.anioFinNumericUpDown.Value, id);
                            break;
                    }
                    this.CargaDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message.ToString());
            }
        }
    }
}
