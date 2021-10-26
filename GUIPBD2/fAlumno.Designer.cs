
namespace GUIPBD2
{
    partial class fAlumno
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
            System.Windows.Forms.Label iDAlumnoLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label primerApellidoLabel;
            System.Windows.Forms.Label segundoApellidoLabel;
            System.Windows.Forms.Label noControlLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAlumno));
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.pnlDetalle = new System.Windows.Forms.Panel();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.alumnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pBDDataSet = new GUIPBD2.PBDDataSet();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.noControlTextBox = new System.Windows.Forms.TextBox();
            this.segundoApellidoTextBox = new System.Windows.Forms.TextBox();
            this.primerApellidoTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.iDAlumnoTextBox = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.alumnoTableAdapter = new GUIPBD2.PBDDataSetTableAdapters.AlumnoTableAdapter();
            this.tableAdapterManager = new GUIPBD2.PBDDataSetTableAdapters.TableAdapterManager();
            this.alumnoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.alumnoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            iDAlumnoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            primerApellidoLabel = new System.Windows.Forms.Label();
            segundoApellidoLabel = new System.Windows.Forms.Label();
            noControlLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            this.pnlBotones.SuspendLayout();
            this.pnlDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingNavigator)).BeginInit();
            this.alumnoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // iDAlumnoLabel
            // 
            iDAlumnoLabel.AutoSize = true;
            iDAlumnoLabel.Location = new System.Drawing.Point(39, 26);
            iDAlumnoLabel.Name = "iDAlumnoLabel";
            iDAlumnoLabel.Size = new System.Drawing.Size(56, 13);
            iDAlumnoLabel.TabIndex = 4;
            iDAlumnoLabel.Text = "IDAlumno:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(45, 52);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 5;
            nombreLabel.Text = "Nombre:";
            // 
            // primerApellidoLabel
            // 
            primerApellidoLabel.AutoSize = true;
            primerApellidoLabel.Location = new System.Drawing.Point(16, 78);
            primerApellidoLabel.Name = "primerApellidoLabel";
            primerApellidoLabel.Size = new System.Drawing.Size(79, 13);
            primerApellidoLabel.TabIndex = 6;
            primerApellidoLabel.Text = "Primer Apellido:";
            // 
            // segundoApellidoLabel
            // 
            segundoApellidoLabel.AutoSize = true;
            segundoApellidoLabel.Location = new System.Drawing.Point(2, 104);
            segundoApellidoLabel.Name = "segundoApellidoLabel";
            segundoApellidoLabel.Size = new System.Drawing.Size(93, 13);
            segundoApellidoLabel.TabIndex = 8;
            segundoApellidoLabel.Text = "Segundo Apellido:";
            // 
            // noControlLabel
            // 
            noControlLabel.AutoSize = true;
            noControlLabel.Location = new System.Drawing.Point(255, 30);
            noControlLabel.Name = "noControlLabel";
            noControlLabel.Size = new System.Drawing.Size(60, 13);
            noControlLabel.TabIndex = 10;
            noControlLabel.Text = "No Control:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(280, 56);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 12;
            emailLabel.Text = "Email:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(263, 82);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 14;
            telefonoLabel.Text = "Telefono:";
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
            this.pnlBotones.Size = new System.Drawing.Size(913, 100);
            this.pnlBotones.TabIndex = 1;
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
            this.pnlDetalle.Controls.Add(telefonoLabel);
            this.pnlDetalle.Controls.Add(this.telefonoTextBox);
            this.pnlDetalle.Controls.Add(emailLabel);
            this.pnlDetalle.Controls.Add(this.emailTextBox);
            this.pnlDetalle.Controls.Add(noControlLabel);
            this.pnlDetalle.Controls.Add(this.noControlTextBox);
            this.pnlDetalle.Controls.Add(segundoApellidoLabel);
            this.pnlDetalle.Controls.Add(this.segundoApellidoTextBox);
            this.pnlDetalle.Controls.Add(primerApellidoLabel);
            this.pnlDetalle.Controls.Add(this.primerApellidoTextBox);
            this.pnlDetalle.Controls.Add(nombreLabel);
            this.pnlDetalle.Controls.Add(this.nombreTextBox);
            this.pnlDetalle.Controls.Add(iDAlumnoLabel);
            this.pnlDetalle.Controls.Add(this.iDAlumnoTextBox);
            this.pnlDetalle.Controls.Add(this.btnCancelar);
            this.pnlDetalle.Controls.Add(this.btnGuardar);
            this.pnlDetalle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDetalle.Location = new System.Drawing.Point(0, 277);
            this.pnlDetalle.Name = "pnlDetalle";
            this.pnlDetalle.Size = new System.Drawing.Size(913, 176);
            this.pnlDetalle.TabIndex = 2;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnoBindingSource, "Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(321, 79);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(172, 20);
            this.telefonoTextBox.TabIndex = 15;
            // 
            // alumnoBindingSource
            // 
            this.alumnoBindingSource.DataMember = "Alumno";
            this.alumnoBindingSource.DataSource = this.pBDDataSet;
            // 
            // pBDDataSet
            // 
            this.pBDDataSet.DataSetName = "PBDDataSet";
            this.pBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnoBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(321, 52);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(204, 20);
            this.emailTextBox.TabIndex = 13;
            // 
            // noControlTextBox
            // 
            this.noControlTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.noControlTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnoBindingSource, "NoControl", true));
            this.noControlTextBox.Location = new System.Drawing.Point(321, 27);
            this.noControlTextBox.Name = "noControlTextBox";
            this.noControlTextBox.Size = new System.Drawing.Size(100, 20);
            this.noControlTextBox.TabIndex = 11;
            // 
            // segundoApellidoTextBox
            // 
            this.segundoApellidoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.segundoApellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnoBindingSource, "SegundoApellido", true));
            this.segundoApellidoTextBox.Location = new System.Drawing.Point(98, 101);
            this.segundoApellidoTextBox.Name = "segundoApellidoTextBox";
            this.segundoApellidoTextBox.Size = new System.Drawing.Size(143, 20);
            this.segundoApellidoTextBox.TabIndex = 9;
            // 
            // primerApellidoTextBox
            // 
            this.primerApellidoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.primerApellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnoBindingSource, "PrimerApellido", true));
            this.primerApellidoTextBox.Location = new System.Drawing.Point(98, 75);
            this.primerApellidoTextBox.Name = "primerApellidoTextBox";
            this.primerApellidoTextBox.Size = new System.Drawing.Size(143, 20);
            this.primerApellidoTextBox.TabIndex = 7;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnoBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(98, 49);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(143, 20);
            this.nombreTextBox.TabIndex = 6;
            // 
            // iDAlumnoTextBox
            // 
            this.iDAlumnoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnoBindingSource, "IDAlumno", true));
            this.iDAlumnoTextBox.Enabled = false;
            this.iDAlumnoTextBox.Location = new System.Drawing.Point(98, 23);
            this.iDAlumnoTextBox.Name = "iDAlumnoTextBox";
            this.iDAlumnoTextBox.Size = new System.Drawing.Size(103, 20);
            this.iDAlumnoTextBox.TabIndex = 5;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(805, 78);
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
            this.btnGuardar.Location = new System.Drawing.Point(688, 78);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(96, 80);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // alumnoTableAdapter
            // 
            this.alumnoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlumnoEmpresaTableAdapter = null;
            this.tableAdapterManager.AlumnoTableAdapter = this.alumnoTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmpresaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GUIPBD2.PBDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // alumnoBindingNavigator
            // 
            this.alumnoBindingNavigator.AddNewItem = null;
            this.alumnoBindingNavigator.BindingSource = this.alumnoBindingSource;
            this.alumnoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.alumnoBindingNavigator.DeleteItem = null;
            this.alumnoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.alumnoBindingNavigator.Location = new System.Drawing.Point(0, 100);
            this.alumnoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.alumnoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.alumnoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.alumnoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.alumnoBindingNavigator.Name = "alumnoBindingNavigator";
            this.alumnoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.alumnoBindingNavigator.Size = new System.Drawing.Size(913, 25);
            this.alumnoBindingNavigator.TabIndex = 3;
            this.alumnoBindingNavigator.Text = "bindingNavigator1";
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
            // alumnoDataGridView
            // 
            this.alumnoDataGridView.AllowUserToAddRows = false;
            this.alumnoDataGridView.AllowUserToDeleteRows = false;
            this.alumnoDataGridView.AllowUserToOrderColumns = true;
            this.alumnoDataGridView.AutoGenerateColumns = false;
            this.alumnoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.alumnoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.alumnoDataGridView.DataSource = this.alumnoBindingSource;
            this.alumnoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alumnoDataGridView.Location = new System.Drawing.Point(0, 125);
            this.alumnoDataGridView.Name = "alumnoDataGridView";
            this.alumnoDataGridView.ReadOnly = true;
            this.alumnoDataGridView.Size = new System.Drawing.Size(913, 152);
            this.alumnoDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDAlumno";
            this.dataGridViewTextBoxColumn1.HeaderText = "IDAlumno";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PrimerApellido";
            this.dataGridViewTextBoxColumn3.HeaderText = "PrimerApellido";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SegundoApellido";
            this.dataGridViewTextBoxColumn4.HeaderText = "SegundoApellido";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NoControl";
            this.dataGridViewTextBoxColumn5.HeaderText = "NoControl";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn6.HeaderText = "Email";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Telefono";
            this.dataGridViewTextBoxColumn7.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // fAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(913, 453);
            this.Controls.Add(this.alumnoDataGridView);
            this.Controls.Add(this.alumnoBindingNavigator);
            this.Controls.Add(this.pnlDetalle);
            this.Controls.Add(this.pnlBotones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alumnos";
            this.Load += new System.EventHandler(this.fAlumno_Load);
            this.pnlBotones.ResumeLayout(false);
            this.pnlDetalle.ResumeLayout(false);
            this.pnlDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingNavigator)).EndInit();
            this.alumnoBindingNavigator.ResumeLayout(false);
            this.alumnoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.BindingSource alumnoBindingSource;
        private PBDDataSetTableAdapters.AlumnoTableAdapter alumnoTableAdapter;
        private PBDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator alumnoBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView alumnoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox noControlTextBox;
        private System.Windows.Forms.TextBox segundoApellidoTextBox;
        private System.Windows.Forms.TextBox primerApellidoTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox iDAlumnoTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}