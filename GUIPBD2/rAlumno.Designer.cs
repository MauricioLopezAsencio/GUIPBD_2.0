
namespace GUIPBD2
{
    partial class rAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rAlumno));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PBDDataSet = new GUIPBD2.PBDDataSet();
            this.AlumnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AlumnoTableAdapter = new GUIPBD2.PBDDataSetTableAdapters.AlumnoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlumnoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Alumno";
            reportDataSource1.Value = this.AlumnoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUIPBD2.rptAlumno.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // PBDDataSet
            // 
            this.PBDDataSet.DataSetName = "PBDDataSet";
            this.PBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // rAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alumno";
            this.Load += new System.EventHandler(this.rAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlumnoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource AlumnoBindingSource;
        private PBDDataSet PBDDataSet;
        private PBDDataSetTableAdapters.AlumnoTableAdapter AlumnoTableAdapter;
    }
}