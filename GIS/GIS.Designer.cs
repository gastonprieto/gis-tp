namespace GIS
{
    partial class GIS
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GIS));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape6 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.dtgAlumnos = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.Nombre = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.Direccion = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.Latitud = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.Longitud = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.DistanceMedrano = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.DistanceCampus = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.ctxMenuAlumnos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxMenuImportar = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuExportar = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.headerMedrano = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.headerCampus = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.kryptonSeparator1 = new ComponentFactory.Krypton.Toolkit.KryptonSeparator();
            this.lblAlumnoCercanoMedrano = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblAlumnoLejanoMedrano = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblDistanciaPromedioMedrano = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblDistanciaMinimaMedrano = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblDistanciaMaximaMedrano = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtAlumnoCercanoMedrano = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtDistanciaMinimaMedrano = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtDistanciaMaximaMedrano = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtAlumnoLejanoMedrano = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtDistanciaMaximaCampus = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtAlumnoLejanoCampus = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtDistanciaMinimaCampus = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtAlumnoCercanoCampus = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblDistanciaMaximaCampus = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblDistanciaMinimaCampus = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblDistanciaPromedioCampus = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblAlumnoLejanoCampus = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblAlumnoCercanoCampus = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtDistanciaPromedioMedrano = new System.Windows.Forms.TextBox();
            this.txtDistanciaPromedioCampus = new System.Windows.Forms.TextBox();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusInfo = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlumnos)).BeginInit();
            this.ctxMenuAlumnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator1)).BeginInit();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 9);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(739, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(121, 54);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Location = new System.Drawing.Point(12, 39);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(58, 13);
            this.lblUbicacion.TabIndex = 3;
            this.lblUbicacion.Text = "Ubicación:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(81, 6);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(246, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(81, 36);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(637, 20);
            this.txtUbicacion.TabIndex = 3;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(448, 6);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(270, 20);
            this.txtApellido.TabIndex = 2;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(383, 9);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 6;
            this.lblApellido.Text = "Apellido:";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape6,
            this.lineShape5,
            this.lineShape4,
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(872, 552);
            this.shapeContainer1.TabIndex = 9;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape6
            // 
            this.lineShape6.Name = "lineShape6";
            this.lineShape6.X1 = 442;
            this.lineShape6.X2 = 788;
            this.lineShape6.Y1 = 413;
            this.lineShape6.Y2 = 413;
            // 
            // lineShape5
            // 
            this.lineShape5.Name = "lineShape5";
            this.lineShape5.X1 = 443;
            this.lineShape5.X2 = 785;
            this.lineShape5.Y1 = 477;
            this.lineShape5.Y2 = 477;
            // 
            // lineShape4
            // 
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 23;
            this.lineShape4.X2 = 365;
            this.lineShape4.Y1 = 479;
            this.lineShape4.Y2 = 479;
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 22;
            this.lineShape3.X2 = 368;
            this.lineShape3.Y1 = 415;
            this.lineShape3.Y2 = 415;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 10;
            this.lineShape2.X2 = 854;
            this.lineShape2.Y1 = 298;
            this.lineShape2.Y2 = 298;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 8;
            this.lineShape1.X2 = 857;
            this.lineShape1.Y1 = 72;
            this.lineShape1.Y2 = 72;
            // 
            // dtgAlumnos
            // 
            this.dtgAlumnos.AllowUserToAddRows = false;
            this.dtgAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Direccion,
            this.Latitud,
            this.Longitud,
            this.DistanceMedrano,
            this.DistanceCampus});
            this.dtgAlumnos.ContextMenuStrip = this.ctxMenuAlumnos;
            this.dtgAlumnos.Location = new System.Drawing.Point(15, 81);
            this.dtgAlumnos.Name = "dtgAlumnos";
            this.dtgAlumnos.ReadOnly = true;
            this.dtgAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgAlumnos.Size = new System.Drawing.Size(840, 209);
            this.dtgAlumnos.TabIndex = 27;
            this.dtgAlumnos.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dtgAlumnos_RowsRemoved);
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Nombre.DataPropertyName = "NombreCompleto";
            this.Nombre.HeaderText = "Apellido, Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 130;
            // 
            // Direccion
            // 
            this.Direccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Direccion.DataPropertyName = "Ubicacion";
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.Width = 86;
            // 
            // Latitud
            // 
            this.Latitud.DataPropertyName = "Latitude";
            dataGridViewCellStyle5.Format = "N4";
            this.Latitud.DefaultCellStyle = dataGridViewCellStyle5;
            this.Latitud.HeaderText = "Latitud";
            this.Latitud.Name = "Latitud";
            this.Latitud.ReadOnly = true;
            this.Latitud.Width = 145;
            // 
            // Longitud
            // 
            this.Longitud.DataPropertyName = "Longitude";
            dataGridViewCellStyle6.Format = "N4";
            this.Longitud.DefaultCellStyle = dataGridViewCellStyle6;
            this.Longitud.HeaderText = "Longitud";
            this.Longitud.Name = "Longitud";
            this.Longitud.ReadOnly = true;
            this.Longitud.Width = 146;
            // 
            // DistanceMedrano
            // 
            this.DistanceMedrano.DataPropertyName = "DistanceMedrano";
            dataGridViewCellStyle7.Format = ".0000 Km.";
            this.DistanceMedrano.DefaultCellStyle = dataGridViewCellStyle7;
            this.DistanceMedrano.HeaderText = "Distancia a Medrano";
            this.DistanceMedrano.Name = "DistanceMedrano";
            this.DistanceMedrano.ReadOnly = true;
            this.DistanceMedrano.Width = 146;
            // 
            // DistanceCampus
            // 
            this.DistanceCampus.DataPropertyName = "DistanceCampus";
            dataGridViewCellStyle8.Format = ".0000 Km.";
            this.DistanceCampus.DefaultCellStyle = dataGridViewCellStyle8;
            this.DistanceCampus.HeaderText = "Distancia a Campus";
            this.DistanceCampus.Name = "DistanceCampus";
            this.DistanceCampus.ReadOnly = true;
            this.DistanceCampus.Width = 146;
            // 
            // ctxMenuAlumnos
            // 
            this.ctxMenuAlumnos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxMenuAlumnos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxMenuImportar,
            this.ctxMenuExportar});
            this.ctxMenuAlumnos.Name = "ctxMenuAlumnos";
            this.ctxMenuAlumnos.Size = new System.Drawing.Size(130, 48);
            // 
            // ctxMenuImportar
            // 
            this.ctxMenuImportar.Image = ((System.Drawing.Image)(resources.GetObject("ctxMenuImportar.Image")));
            this.ctxMenuImportar.Name = "ctxMenuImportar";
            this.ctxMenuImportar.Size = new System.Drawing.Size(129, 22);
            this.ctxMenuImportar.Text = "Importar...";
            this.ctxMenuImportar.Click += new System.EventHandler(this.ctxMenuImportar_Click);
            // 
            // ctxMenuExportar
            // 
            this.ctxMenuExportar.Image = ((System.Drawing.Image)(resources.GetObject("ctxMenuExportar.Image")));
            this.ctxMenuExportar.Name = "ctxMenuExportar";
            this.ctxMenuExportar.Size = new System.Drawing.Size(129, 22);
            this.ctxMenuExportar.Text = "Exportar...";
            this.ctxMenuExportar.Click += new System.EventHandler(this.ctxMenuExportar_Click);
            // 
            // dlgOpen
            // 
            this.dlgOpen.Filter = "Archivo XML|*.xml";
            this.dlgOpen.Title = "Importar Listado Alumnos";
            // 
            // dlgSave
            // 
            this.dlgSave.DefaultExt = "xml";
            this.dlgSave.Filter = "Archivo XML|*.xml";
            this.dlgSave.Title = "Exportar Listado Alumnos";
            // 
            // headerMedrano
            // 
            this.headerMedrano.Location = new System.Drawing.Point(15, 315);
            this.headerMedrano.Name = "headerMedrano";
            this.headerMedrano.Size = new System.Drawing.Size(196, 31);
            this.headerMedrano.TabIndex = 28;
            this.headerMedrano.Values.Description = "";
            this.headerMedrano.Values.Heading = "Estadísticas Medrano";
            this.headerMedrano.Values.Image = null;
            // 
            // headerCampus
            // 
            this.headerCampus.Location = new System.Drawing.Point(439, 315);
            this.headerCampus.Name = "headerCampus";
            this.headerCampus.Size = new System.Drawing.Size(187, 31);
            this.headerCampus.TabIndex = 29;
            this.headerCampus.Values.Description = "";
            this.headerCampus.Values.Heading = "Estadísticas Campus";
            this.headerCampus.Values.Image = null;
            // 
            // kryptonSeparator1
            // 
            this.kryptonSeparator1.Location = new System.Drawing.Point(386, 315);
            this.kryptonSeparator1.Name = "kryptonSeparator1";
            this.kryptonSeparator1.Size = new System.Drawing.Size(27, 207);
            this.kryptonSeparator1.TabIndex = 30;
            // 
            // lblAlumnoCercanoMedrano
            // 
            this.lblAlumnoCercanoMedrano.Location = new System.Drawing.Point(15, 362);
            this.lblAlumnoCercanoMedrano.Name = "lblAlumnoCercanoMedrano";
            this.lblAlumnoCercanoMedrano.Size = new System.Drawing.Size(104, 20);
            this.lblAlumnoCercanoMedrano.TabIndex = 31;
            this.lblAlumnoCercanoMedrano.Values.Text = "Alumno Cercano:";
            // 
            // lblAlumnoLejanoMedrano
            // 
            this.lblAlumnoLejanoMedrano.Location = new System.Drawing.Point(15, 426);
            this.lblAlumnoLejanoMedrano.Name = "lblAlumnoLejanoMedrano";
            this.lblAlumnoLejanoMedrano.Size = new System.Drawing.Size(95, 20);
            this.lblAlumnoLejanoMedrano.TabIndex = 32;
            this.lblAlumnoLejanoMedrano.Values.Text = "Alumno Lejano:";
            // 
            // lblDistanciaPromedioMedrano
            // 
            this.lblDistanciaPromedioMedrano.Location = new System.Drawing.Point(15, 490);
            this.lblDistanciaPromedioMedrano.Name = "lblDistanciaPromedioMedrano";
            this.lblDistanciaPromedioMedrano.Size = new System.Drawing.Size(119, 20);
            this.lblDistanciaPromedioMedrano.TabIndex = 33;
            this.lblDistanciaPromedioMedrano.Values.Text = "Distancia Promedio:";
            // 
            // lblDistanciaMinimaMedrano
            // 
            this.lblDistanciaMinimaMedrano.Location = new System.Drawing.Point(15, 388);
            this.lblDistanciaMinimaMedrano.Name = "lblDistanciaMinimaMedrano";
            this.lblDistanciaMinimaMedrano.Size = new System.Drawing.Size(107, 20);
            this.lblDistanciaMinimaMedrano.TabIndex = 34;
            this.lblDistanciaMinimaMedrano.Values.Text = "Distancia Mínima:";
            // 
            // lblDistanciaMaximaMedrano
            // 
            this.lblDistanciaMaximaMedrano.Location = new System.Drawing.Point(15, 452);
            this.lblDistanciaMaximaMedrano.Name = "lblDistanciaMaximaMedrano";
            this.lblDistanciaMaximaMedrano.Size = new System.Drawing.Size(109, 20);
            this.lblDistanciaMaximaMedrano.TabIndex = 35;
            this.lblDistanciaMaximaMedrano.Values.Text = "Distancia Máxima:";
            // 
            // txtAlumnoCercanoMedrano
            // 
            this.txtAlumnoCercanoMedrano.Location = new System.Drawing.Point(138, 362);
            this.txtAlumnoCercanoMedrano.Name = "txtAlumnoCercanoMedrano";
            this.txtAlumnoCercanoMedrano.ReadOnly = true;
            this.txtAlumnoCercanoMedrano.Size = new System.Drawing.Size(231, 20);
            this.txtAlumnoCercanoMedrano.TabIndex = 36;
            // 
            // txtDistanciaMinimaMedrano
            // 
            this.txtDistanciaMinimaMedrano.Location = new System.Drawing.Point(138, 388);
            this.txtDistanciaMinimaMedrano.Name = "txtDistanciaMinimaMedrano";
            this.txtDistanciaMinimaMedrano.ReadOnly = true;
            this.txtDistanciaMinimaMedrano.Size = new System.Drawing.Size(100, 20);
            this.txtDistanciaMinimaMedrano.TabIndex = 37;
            // 
            // txtDistanciaMaximaMedrano
            // 
            this.txtDistanciaMaximaMedrano.Location = new System.Drawing.Point(138, 452);
            this.txtDistanciaMaximaMedrano.Name = "txtDistanciaMaximaMedrano";
            this.txtDistanciaMaximaMedrano.ReadOnly = true;
            this.txtDistanciaMaximaMedrano.Size = new System.Drawing.Size(100, 20);
            this.txtDistanciaMaximaMedrano.TabIndex = 39;
            // 
            // txtAlumnoLejanoMedrano
            // 
            this.txtAlumnoLejanoMedrano.Location = new System.Drawing.Point(138, 426);
            this.txtAlumnoLejanoMedrano.Name = "txtAlumnoLejanoMedrano";
            this.txtAlumnoLejanoMedrano.ReadOnly = true;
            this.txtAlumnoLejanoMedrano.Size = new System.Drawing.Size(231, 20);
            this.txtAlumnoLejanoMedrano.TabIndex = 38;
            // 
            // txtDistanciaMaximaCampus
            // 
            this.txtDistanciaMaximaCampus.Location = new System.Drawing.Point(566, 452);
            this.txtDistanciaMaximaCampus.Name = "txtDistanciaMaximaCampus";
            this.txtDistanciaMaximaCampus.ReadOnly = true;
            this.txtDistanciaMaximaCampus.Size = new System.Drawing.Size(100, 20);
            this.txtDistanciaMaximaCampus.TabIndex = 50;
            // 
            // txtAlumnoLejanoCampus
            // 
            this.txtAlumnoLejanoCampus.Location = new System.Drawing.Point(566, 426);
            this.txtAlumnoLejanoCampus.Name = "txtAlumnoLejanoCampus";
            this.txtAlumnoLejanoCampus.ReadOnly = true;
            this.txtAlumnoLejanoCampus.Size = new System.Drawing.Size(231, 20);
            this.txtAlumnoLejanoCampus.TabIndex = 49;
            // 
            // txtDistanciaMinimaCampus
            // 
            this.txtDistanciaMinimaCampus.Location = new System.Drawing.Point(566, 388);
            this.txtDistanciaMinimaCampus.Name = "txtDistanciaMinimaCampus";
            this.txtDistanciaMinimaCampus.ReadOnly = true;
            this.txtDistanciaMinimaCampus.Size = new System.Drawing.Size(100, 20);
            this.txtDistanciaMinimaCampus.TabIndex = 48;
            // 
            // txtAlumnoCercanoCampus
            // 
            this.txtAlumnoCercanoCampus.Location = new System.Drawing.Point(566, 362);
            this.txtAlumnoCercanoCampus.Name = "txtAlumnoCercanoCampus";
            this.txtAlumnoCercanoCampus.ReadOnly = true;
            this.txtAlumnoCercanoCampus.Size = new System.Drawing.Size(231, 20);
            this.txtAlumnoCercanoCampus.TabIndex = 47;
            // 
            // lblDistanciaMaximaCampus
            // 
            this.lblDistanciaMaximaCampus.Location = new System.Drawing.Point(443, 452);
            this.lblDistanciaMaximaCampus.Name = "lblDistanciaMaximaCampus";
            this.lblDistanciaMaximaCampus.Size = new System.Drawing.Size(109, 20);
            this.lblDistanciaMaximaCampus.TabIndex = 46;
            this.lblDistanciaMaximaCampus.Values.Text = "Distancia Máxima:";
            // 
            // lblDistanciaMinimaCampus
            // 
            this.lblDistanciaMinimaCampus.Location = new System.Drawing.Point(443, 388);
            this.lblDistanciaMinimaCampus.Name = "lblDistanciaMinimaCampus";
            this.lblDistanciaMinimaCampus.Size = new System.Drawing.Size(107, 20);
            this.lblDistanciaMinimaCampus.TabIndex = 45;
            this.lblDistanciaMinimaCampus.Values.Text = "Distancia Mínima:";
            // 
            // lblDistanciaPromedioCampus
            // 
            this.lblDistanciaPromedioCampus.Location = new System.Drawing.Point(443, 490);
            this.lblDistanciaPromedioCampus.Name = "lblDistanciaPromedioCampus";
            this.lblDistanciaPromedioCampus.Size = new System.Drawing.Size(119, 20);
            this.lblDistanciaPromedioCampus.TabIndex = 44;
            this.lblDistanciaPromedioCampus.Values.Text = "Distancia Promedio:";
            // 
            // lblAlumnoLejanoCampus
            // 
            this.lblAlumnoLejanoCampus.Location = new System.Drawing.Point(443, 426);
            this.lblAlumnoLejanoCampus.Name = "lblAlumnoLejanoCampus";
            this.lblAlumnoLejanoCampus.Size = new System.Drawing.Size(95, 20);
            this.lblAlumnoLejanoCampus.TabIndex = 43;
            this.lblAlumnoLejanoCampus.Values.Text = "Alumno Lejano:";
            // 
            // lblAlumnoCercanoCampus
            // 
            this.lblAlumnoCercanoCampus.Location = new System.Drawing.Point(443, 362);
            this.lblAlumnoCercanoCampus.Name = "lblAlumnoCercanoCampus";
            this.lblAlumnoCercanoCampus.Size = new System.Drawing.Size(104, 20);
            this.lblAlumnoCercanoCampus.TabIndex = 42;
            this.lblAlumnoCercanoCampus.Values.Text = "Alumno Cercano:";
            // 
            // txtDistanciaPromedioMedrano
            // 
            this.txtDistanciaPromedioMedrano.Location = new System.Drawing.Point(140, 490);
            this.txtDistanciaPromedioMedrano.Name = "txtDistanciaPromedioMedrano";
            this.txtDistanciaPromedioMedrano.Size = new System.Drawing.Size(100, 20);
            this.txtDistanciaPromedioMedrano.TabIndex = 52;
            // 
            // txtDistanciaPromedioCampus
            // 
            this.txtDistanciaPromedioCampus.Location = new System.Drawing.Point(566, 490);
            this.txtDistanciaPromedioCampus.Name = "txtDistanciaPromedioCampus";
            this.txtDistanciaPromedioCampus.Size = new System.Drawing.Size(100, 20);
            this.txtDistanciaPromedioCampus.TabIndex = 53;
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusInfo});
            this.statusBar.Location = new System.Drawing.Point(0, 530);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(872, 22);
            this.statusBar.TabIndex = 54;
            // 
            // statusInfo
            // 
            this.statusInfo.Name = "statusInfo";
            this.statusInfo.Size = new System.Drawing.Size(0, 17);
            // 
            // GIS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 552);
            this.Controls.Add(this.txtDistanciaPromedioCampus);
            this.Controls.Add(this.txtDistanciaPromedioMedrano);
            this.Controls.Add(this.txtDistanciaMaximaCampus);
            this.Controls.Add(this.txtAlumnoLejanoCampus);
            this.Controls.Add(this.txtDistanciaMinimaCampus);
            this.Controls.Add(this.txtAlumnoCercanoCampus);
            this.Controls.Add(this.lblDistanciaMaximaCampus);
            this.Controls.Add(this.lblDistanciaMinimaCampus);
            this.Controls.Add(this.lblDistanciaPromedioCampus);
            this.Controls.Add(this.lblAlumnoLejanoCampus);
            this.Controls.Add(this.lblAlumnoCercanoCampus);
            this.Controls.Add(this.txtDistanciaMaximaMedrano);
            this.Controls.Add(this.txtAlumnoLejanoMedrano);
            this.Controls.Add(this.txtDistanciaMinimaMedrano);
            this.Controls.Add(this.txtAlumnoCercanoMedrano);
            this.Controls.Add(this.lblDistanciaMaximaMedrano);
            this.Controls.Add(this.lblDistanciaMinimaMedrano);
            this.Controls.Add(this.lblDistanciaPromedioMedrano);
            this.Controls.Add(this.lblAlumnoLejanoMedrano);
            this.Controls.Add(this.lblAlumnoCercanoMedrano);
            this.Controls.Add(this.kryptonSeparator1);
            this.Controls.Add(this.headerCampus);
            this.Controls.Add(this.headerMedrano);
            this.Controls.Add(this.dtgAlumnos);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtUbicacion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblUbicacion);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.shapeContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GIS";
            this.Text = "GIS";
            this.Load += new System.EventHandler(this.GIS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlumnos)).EndInit();
            this.ctxMenuAlumnos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator1)).EndInit();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dtgAlumnos;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn Nombre;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn Direccion;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn Latitud;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn Longitud;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn DistanceMedrano;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewTextBoxColumn DistanceCampus;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.ContextMenuStrip ctxMenuAlumnos;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuImportar;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuExportar;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader headerMedrano;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader headerCampus;
        private ComponentFactory.Krypton.Toolkit.KryptonSeparator kryptonSeparator1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblAlumnoCercanoMedrano;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblAlumnoLejanoMedrano;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblDistanciaPromedioMedrano;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblDistanciaMinimaMedrano;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblDistanciaMaximaMedrano;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtAlumnoCercanoMedrano;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtDistanciaMinimaMedrano;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtDistanciaMaximaMedrano;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtAlumnoLejanoMedrano;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape6;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape5;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtDistanciaMaximaCampus;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtAlumnoLejanoCampus;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtDistanciaMinimaCampus;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtAlumnoCercanoCampus;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblDistanciaMaximaCampus;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblDistanciaMinimaCampus;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblDistanciaPromedioCampus;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblAlumnoLejanoCampus;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblAlumnoCercanoCampus;
        private System.Windows.Forms.TextBox txtDistanciaPromedioMedrano;
        private System.Windows.Forms.TextBox txtDistanciaPromedioCampus;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel statusInfo;

    }
}

