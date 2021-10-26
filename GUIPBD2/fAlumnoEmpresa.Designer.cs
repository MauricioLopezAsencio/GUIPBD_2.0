
namespace GUIPBD2
{
    partial class fAlumnoEmpresa
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
            System.Windows.Forms.Label iDAlumnoEmpresaLabel;
            System.Windows.Forms.Label anioInicioLabel;
            System.Windows.Forms.Label anioFinLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAlumnoEmpresa));
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.pnlDetalle = new System.Windows.Forms.Panel();
            this.anioFinNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.vAlumnoEmpresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pBDDataSet = new GUIPBD2.PBDDataSet();
            this.anioInicioNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.cboEmpresa = new System.Windows.Forms.ComboBox();
            this.empresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.cboAlumno = new System.Windows.Forms.ComboBox();
            this.alumnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.iDAlumnoEmpresaTextBox = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.vAlumnoEmpresaTableAdapter = new GUIPBD2.PBDDataSetTableAdapters.VAlumnoEmpresaTableAdapter();
            this.tableAdapterManager = new GUIPBD2.PBDDataSetTableAdapters.TableAdapterManager();
            this.alumnoTableAdapter = new GUIPBD2.PBDDataSetTableAdapters.AlumnoTableAdapter();
            this.empresaTableAdapter = new GUIPBD2.PBDDataSetTableAdapters.EmpresaTableAdapter();
            this.vAlumnoEmpresaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.vAlumnoEmpresaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alumnoEmpresaTableAdapter = new GUIPBD2.PBDDataSetTableAdapters.AlumnoEmpresaTableAdapter();
            this.fKAlumnoEmpresaEmpresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            iDAlumnoEmpresaLabel = new System.Windows.Forms.Label();
            anioInicioLabel = new System.Windows.Forms.Label();
            anioFinLabel = new System.Windows.Forms.Label();
            this.pnlBotones.SuspendLayout();
            this.pnlDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anioFinNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vAlumnoEmpresaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anioInicioNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vAlumnoEmpresaBindingNavigator)).BeginInit();
            this.vAlumnoEmpresaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vAlumnoEmpresaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKAlumnoEmpresaEmpresaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDAlumnoEmpresaLabel
            // 
            iDAlumnoEmpresaLabel.AutoSize = true;
            iDAlumnoEmpresaLabel.Location = new System.Drawing.Point(26, 24);
            iDAlumnoEmpresaLabel.Name = "iDAlumnoEmpresaLabel";
            iDAlumnoEmpresaLabel.Size = new System.Drawing.Size(100, 13);
            iDAlumnoEmpresaLabel.TabIndex = 4;
            iDAlumnoEmpresaLabel.Text = "IDAlumno Empresa:";
            // 
            // anioInicioLabel
            // 
            anioInicioLabel.AutoSize = true;
            anioInicioLabel.Location = new System.Drawing.Point(29, 104);
            anioInicioLabel.Name = "anioInicioLabel";
            anioInicioLabel.Size = new System.Drawing.Size(59, 13);
            anioInicioLabel.TabIndex = 9;
            anioInicioLabel.Text = "Anio Inicio:";
            // 
            // anioFinLabel
            // 
            anioFinLabel.AutoSize = true;
            anioFinLabel.Location = new System.Drawing.Point(255, 104);
            anioFinLabel.Name = "anioFinLabel";
            anioFinLabel.Size = new System.Drawing.Size(48, 13);
            anioFinLabel.TabIndex = 10;
            anioFinLabel.Text = "Anio Fin:";
            // 
            // pnlBotones
            // 
            this.pnlBotones.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBotones.BackgroundImage")));
            this.pnlBotones.Controls.Add(this.btnBorrar);
            this.pnlBotones.Controls.Add(this.btnEditar);
            this.pnlBotones.Controls.Add(this.btnInsertar);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBotones.Location = new System.Drawing.Point(0, 0);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(853, 100);
            this.pnlBotones.TabIndex = 2;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrar.Image")));
            this.btnBorrar.Location = new System.Drawing.Point(258, 12);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(96, 78);
            this.btnBorrar.TabIndex = 2;
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(136, 12);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(96, 78);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Image = ((System.Drawing.Image)(resources.GetObject("btnInsertar.Image")));
            this.btnInsertar.Location = new System.Drawing.Point(12, 12);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(96, 78);
            this.btnInsertar.TabIndex = 0;
            this.btnInsertar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // pnlDetalle
            // 
            this.pnlDetalle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlDetalle.BackgroundImage")));
            this.pnlDetalle.Controls.Add(anioFinLabel);
            this.pnlDetalle.Controls.Add(this.anioFinNumericUpDown);
            this.pnlDetalle.Controls.Add(anioInicioLabel);
            this.pnlDetalle.Controls.Add(this.anioInicioNumericUpDown);
            this.pnlDetalle.Controls.Add(this.cboEmpresa);
            this.pnlDetalle.Controls.Add(this.label2);
            this.pnlDetalle.Controls.Add(this.cboAlumno);
            this.pnlDetalle.Controls.Add(this.label1);
            this.pnlDetalle.Controls.Add(iDAlumnoEmpresaLabel);
            this.pnlDetalle.Controls.Add(this.iDAlumnoEmpresaTextBox);
            this.pnlDetalle.Controls.Add(this.btnCancelar);
            this.pnlDetalle.Controls.Add(this.btnGuardar);
            this.pnlDetalle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDetalle.Location = new System.Drawing.Point(0, 412);
            this.pnlDetalle.Name = "pnlDetalle";
            this.pnlDetalle.Size = new System.Drawing.Size(853, 157);
            this.pnlDetalle.TabIndex = 3;
            // 
            // anioFinNumericUpDown
            // 
            this.anioFinNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vAlumnoEmpresaBindingSource, "AnioFin", true));
            this.anioFinNumericUpDown.Location = new System.Drawing.Point(309, 104);
            this.anioFinNumericUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.anioFinNumericUpDown.Name = "anioFinNumericUpDown";
            this.anioFinNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.anioFinNumericUpDown.TabIndex = 11;
            // 
            // vAlumnoEmpresaBindingSource
            // 
            this.vAlumnoEmpresaBindingSource.DataMember = "VAlumnoEmpresa";
            this.vAlumnoEmpresaBindingSource.DataSource = this.pBDDataSet;
            // 
            // pBDDataSet
            // 
            this.pBDDataSet.DataSetName = "PBDDataSet";
            this.pBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // anioInicioNumericUpDown
            // 
            this.anioInicioNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vAlumnoEmpresaBindingSource, "AnioInicio", true));
            this.anioInicioNumericUpDown.Location = new System.Drawing.Point(94, 104);
            this.anioInicioNumericUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.anioInicioNumericUpDown.Name = "anioInicioNumericUpDown";
            this.anioInicioNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.anioInicioNumericUpDown.TabIndex = 10;
            // 
            // cboEmpresa
            // 
            this.cboEmpresa.DataSource = this.empresaBindingSource;
            this.cboEmpresa.DisplayMember = "RazonSocial";
            this.cboEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpresa.FormattingEnabled = true;
            this.cboEmpresa.Location = new System.Drawing.Point(255, 67);
            this.cboEmpresa.Name = "cboEmpresa";
            this.cboEmpresa.Size = new System.Drawing.Size(203, 21);
            this.cboEmpresa.TabIndex = 9;
            this.cboEmpresa.ValueMember = "IDEmpresa";
            // 
            // empresaBindingSource
            // 
            this.empresaBindingSource.DataMember = "Empresa";
            this.empresaBindingSource.DataSource = this.pBDDataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Seleccione una empresa";
            // 
            // cboAlumno
            // 
            this.cboAlumno.DataSource = this.alumnoBindingSource;
            this.cboAlumno.DisplayMember = "Nombre";
            this.cboAlumno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAlumno.FormattingEnabled = true;
            this.cboAlumno.Location = new System.Drawing.Point(29, 67);
            this.cboAlumno.Name = "cboAlumno";
            this.cboAlumno.Size = new System.Drawing.Size(203, 21);
            this.cboAlumno.TabIndex = 7;
            this.cboAlumno.ValueMember = "IDAlumno";
            // 
            // alumnoBindingSource
            // 
            this.alumnoBindingSource.DataMember = "Alumno";
            this.alumnoBindingSource.DataSource = this.pBDDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seleccione un alumno";
            // 
            // iDAlumnoEmpresaTextBox
            // 
            this.iDAlumnoEmpresaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vAlumnoEmpresaBindingSource, "IDAlumnoEmpresa", true));
            this.iDAlumnoEmpresaTextBox.Enabled = false;
            this.iDAlumnoEmpresaTextBox.Location = new System.Drawing.Point(132, 21);
            this.iDAlumnoEmpresaTextBox.Name = "iDAlumnoEmpresaTextBox";
            this.iDAlumnoEmpresaTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDAlumnoEmpresaTextBox.TabIndex = 5;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(745, 59);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 80);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(628, 59);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(96, 80);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // vAlumnoEmpresaTableAdapter
            // 
            this.vAlumnoEmpresaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlumnoEmpresaTableAdapter = null;
            this.tableAdapterManager.AlumnoTableAdapter = this.alumnoTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmpresaTableAdapter = this.empresaTableAdapter;
            this.tableAdapterManager.UpdateOrder = GUIPBD2.PBDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // alumnoTableAdapter
            // 
            this.alumnoTableAdapter.ClearBeforeFill = true;
            // 
            // empresaTableAdapter
            // 
            this.empresaTableAdapter.ClearBeforeFill = true;
            // 
            // vAlumnoEmpresaBindingNavigator
            // 
            this.vAlumnoEmpresaBindingNavigator.AddNewItem = null;
            this.vAlumnoEmpresaBindingNavigator.BindingSource = this.vAlumnoEmpresaBindingSource;
            this.vAlumnoEmpresaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vAlumnoEmpresaBindingNavigator.DeleteItem = null;
            this.vAlumnoEmpresaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.vAlumnoEmpresaBindingNavigator.Location = new System.Drawing.Point(0, 100);
            this.vAlumnoEmpresaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vAlumnoEmpresaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vAlumnoEmpresaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vAlumnoEmpresaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vAlumnoEmpresaBindingNavigator.Name = "vAlumnoEmpresaBindingNavigator";
            this.vAlumnoEmpresaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vAlumnoEmpresaBindingNavigator.Size = new System.Drawing.Size(853, 25);
            this.vAlumnoEmpresaBindingNavigator.TabIndex = 4;
            this.vAlumnoEmpresaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // vAlumnoEmpresaDataGridView
            // 
            this.vAlumnoEmpresaDataGridView.AllowUserToAddRows = false;
            this.vAlumnoEmpresaDataGridView.AllowUserToDeleteRows = false;
            this.vAlumnoEmpresaDataGridView.AllowUserToOrderColumns = true;
            this.vAlumnoEmpresaDataGridView.AutoGenerateColumns = false;
            this.vAlumnoEmpresaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vAlumnoEmpresaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.IDAlumno,
            this.IDEmpresa,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.vAlumnoEmpresaDataGridView.DataSource = this.vAlumnoEmpresaBindingSource;
            this.vAlumnoEmpresaDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vAlumnoEmpresaDataGridView.Location = new System.Drawing.Point(0, 125);
            this.vAlumnoEmpresaDataGridView.Name = "vAlumnoEmpresaDataGridView";
            this.vAlumnoEmpresaDataGridView.ReadOnly = true;
            this.vAlumnoEmpresaDataGridView.Size = new System.Drawing.Size(853, 287);
            this.vAlumnoEmpresaDataGridView.TabIndex = 4;
            this.vAlumnoEmpresaDataGridView.SelectionChanged += new System.EventHandler(this.vAlumnoEmpresaDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PrimerApellido";
            this.dataGridViewTextBoxColumn2.HeaderText = "PrimerApellido";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SegundoApellido";
            this.dataGridViewTextBoxColumn3.HeaderText = "SegundoApellido";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NoControl";
            this.dataGridViewTextBoxColumn4.HeaderText = "NoControl";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "IDAlumnoEmpresa";
            this.dataGridViewTextBoxColumn5.HeaderText = "IDAlumnoEmpresa";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // IDAlumno
            // 
            this.IDAlumno.DataPropertyName = "IDAlumno";
            this.IDAlumno.HeaderText = "IDAlumno";
            this.IDAlumno.Name = "IDAlumno";
            this.IDAlumno.ReadOnly = true;
            this.IDAlumno.Visible = false;
            // 
            // IDEmpresa
            // 
            this.IDEmpresa.DataPropertyName = "IDEmpresa";
            this.IDEmpresa.HeaderText = "IDEmpresa";
            this.IDEmpresa.Name = "IDEmpresa";
            this.IDEmpresa.ReadOnly = true;
            this.IDEmpresa.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "AnioInicio";
            this.dataGridViewTextBoxColumn8.HeaderText = "AnioInicio";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "AnioFin";
            this.dataGridViewTextBoxColumn9.HeaderText = "AnioFin";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "RazonSocial";
            this.dataGridViewTextBoxColumn10.HeaderText = "RazonSocial";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // alumnoEmpresaTableAdapter
            // 
            this.alumnoEmpresaTableAdapter.ClearBeforeFill = true;
            // 
            // fKAlumnoEmpresaEmpresaBindingSource
            // 
            this.fKAlumnoEmpresaEmpresaBindingSource.DataMember = "FK_AlumnoEmpresa_Empresa";
            this.fKAlumnoEmpresaEmpresaBindingSource.DataSource = this.empresaBindingSource;
            // 
            // fAlumnoEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(853, 569);
            this.Controls.Add(this.vAlumnoEmpresaDataGridView);
            this.Controls.Add(this.vAlumnoEmpresaBindingNavigator);
            this.Controls.Add(this.pnlDetalle);
            this.Controls.Add(this.pnlBotones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fAlumnoEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlumnoEmpresa";
            this.Load += new System.EventHandler(this.fAlumnoEmpresa_Load);
            this.pnlBotones.ResumeLayout(false);
            this.pnlDetalle.ResumeLayout(false);
            this.pnlDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anioFinNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vAlumnoEmpresaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anioInicioNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vAlumnoEmpresaBindingNavigator)).EndInit();
            this.vAlumnoEmpresaBindingNavigator.ResumeLayout(false);
            this.vAlumnoEmpresaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vAlumnoEmpresaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKAlumnoEmpresaEmpresaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Panel pnlDetalle;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private PBDDataSet pBDDataSet;
        private System.Windows.Forms.BindingSource vAlumnoEmpresaBindingSource;
        private PBDDataSetTableAdapters.VAlumnoEmpresaTableAdapter vAlumnoEmpresaTableAdapter;
        private PBDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vAlumnoEmpresaBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView vAlumnoEmpresaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.ComboBox cboEmpresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboAlumno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox iDAlumnoEmpresaTextBox;
        private PBDDataSetTableAdapters.AlumnoTableAdapter alumnoTableAdapter;
        private System.Windows.Forms.BindingSource alumnoBindingSource;
        private PBDDataSetTableAdapters.EmpresaTableAdapter empresaTableAdapter;
        private System.Windows.Forms.BindingSource empresaBindingSource;
        private PBDDataSetTableAdapters.AlumnoEmpresaTableAdapter alumnoEmpresaTableAdapter;
        private System.Windows.Forms.NumericUpDown anioFinNumericUpDown;
        private System.Windows.Forms.NumericUpDown anioInicioNumericUpDown;
        private System.Windows.Forms.BindingSource fKAlumnoEmpresaEmpresaBindingSource;
    }
}