
namespace GUIPBD2
{
    partial class rAlumnoEmpresa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rAlumnoEmpresa));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PBDDataSet = new GUIPBD2.PBDDataSet();
            this.vAlumnoEmpresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vAlumnoEmpresaTableAdapter = new GUIPBD2.PBDDataSetTableAdapters.vAlumnoEmpresaTableAdapter();
            this.AlumnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AlumnoTableAdapter = new GUIPBD2.PBDDataSetTableAdapters.AlumnoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vAlumnoEmpresaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlumnoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "AlumnoEmpresa";
            reportDataSource1.Value = this.vAlumnoEmpresaBindingSource;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.AlumnoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUIPBD2.rptAlumnoEmpresa.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(867, 384);
            this.reportViewer1.TabIndex = 0;
            // 
            // PBDDataSet
            // 
            this.PBDDataSet.DataSetName = "PBDDataSet";
            this.PBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vAlumnoEmpresaBindingSource
            // 
            this.vAlumnoEmpresaBindingSource.DataMember = "vAlumnoEmpresa";
            this.vAlumnoEmpresaBindingSource.DataSource = this.PBDDataSet;
            // 
            // vAlumnoEmpresaTableAdapter
            // 
            this.vAlumnoEmpresaTableAdapter.ClearBeforeFill = true;
            // 
            // AlumnoBindingSource
            // 
            this.AlumnoBindingSource.DataMember = "Alumno";
            this.AlumnoBindingSource.DataSource = this.PBDDataSet;
            // 
            // AlumnoTableAdapter
            // 
            this.AlumnoTableAdapter.ClearBeforeFill = true;
            // 
            // rAlumnoEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 384);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rAlumnoEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlumnoEmpresa";
            this.Load += new System.EventHandler(this.rAlumnoEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vAlumnoEmpresaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlumnoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource vAlumnoEmpresaBindingSource;
        private PBDDataSet PBDDataSet;
        private System.Windows.Forms.BindingSource AlumnoBindingSource;
        private PBDDataSetTableAdapters.vAlumnoEmpresaTableAdapter vAlumnoEmpresaTableAdapter;
        private PBDDataSetTableAdapters.AlumnoTableAdapter AlumnoTableAdapter;
    }
}