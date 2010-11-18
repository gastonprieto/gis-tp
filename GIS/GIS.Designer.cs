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
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lblDistanciaMinima = new System.Windows.Forms.Label();
            this.lblDistanciaMaxima = new System.Windows.Forms.Label();
            this.lblDistanciaPromedio = new System.Windows.Forms.Label();
            this.txtDistanciaMinima = new System.Windows.Forms.Label();
            this.txtDistanciaMaxima = new System.Windows.Forms.Label();
            this.txtDistanciaPromedio = new System.Windows.Forms.Label();
            this.lblSedeMinima = new System.Windows.Forms.Label();
            this.lblSedeMaxima = new System.Windows.Forms.Label();
            this.lblSedePromedio = new System.Windows.Forms.Label();
            this.txtSedeMinima = new System.Windows.Forms.Label();
            this.txtSedeMax = new System.Windows.Forms.Label();
            this.txtSedeProm = new System.Windows.Forms.Label();
            this.txtAlumnoMasLejano = new System.Windows.Forms.Label();
            this.txtAlumnoCercano = new System.Windows.Forms.Label();
            this.lblAlumnoLejano = new System.Windows.Forms.Label();
            this.lblAlumnoCercano = new System.Windows.Forms.Label();
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
            this.pnlProgress = new System.Windows.Forms.Panel();
            this.lblProgress = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlumnos)).BeginInit();
            this.ctxMenuAlumnos.SuspendLayout();
            this.pnlProgress.SuspendLayout();
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
            this.btnAgregar.Location = new System.Drawing.Point(785, 34);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "&Agregar";
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
            this.txtNombre.Size = new System.Drawing.Size(288, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(81, 36);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(688, 20);
            this.txtUbicacion.TabIndex = 3;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(481, 6);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(288, 20);
            this.txtApellido.TabIndex = 2;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(416, 9);
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
            this.lineShape4,
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(872, 441);
            this.shapeContainer1.TabIndex = 9;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape4
            // 
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 13;
            this.lineShape4.X2 = 853;
            this.lineShape4.Y1 = 381;
            this.lineShape4.Y2 = 381;
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 12;
            this.lineShape3.X2 = 853;
            this.lineShape3.Y1 = 385;
            this.lineShape3.Y2 = 385;
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
            // lblDistanciaMinima
            // 
            this.lblDistanciaMinima.AutoSize = true;
            this.lblDistanciaMinima.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistanciaMinima.Location = new System.Drawing.Point(334, 316);
            this.lblDistanciaMinima.Name = "lblDistanciaMinima";
            this.lblDistanciaMinima.Size = new System.Drawing.Size(64, 13);
            this.lblDistanciaMinima.TabIndex = 10;
            this.lblDistanciaMinima.Text = "Distancia:";
            // 
            // lblDistanciaMaxima
            // 
            this.lblDistanciaMaxima.AutoSize = true;
            this.lblDistanciaMaxima.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistanciaMaxima.Location = new System.Drawing.Point(334, 349);
            this.lblDistanciaMaxima.Name = "lblDistanciaMaxima";
            this.lblDistanciaMaxima.Size = new System.Drawing.Size(64, 13);
            this.lblDistanciaMaxima.TabIndex = 11;
            this.lblDistanciaMaxima.Text = "Distancia:";
            // 
            // lblDistanciaPromedio
            // 
            this.lblDistanciaPromedio.AutoSize = true;
            this.lblDistanciaPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistanciaPromedio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblDistanciaPromedio.Location = new System.Drawing.Point(11, 401);
            this.lblDistanciaPromedio.Name = "lblDistanciaPromedio";
            this.lblDistanciaPromedio.Size = new System.Drawing.Size(169, 20);
            this.lblDistanciaPromedio.TabIndex = 12;
            this.lblDistanciaPromedio.Text = "Distancia Promedio:";
            // 
            // txtDistanciaMinima
            // 
            this.txtDistanciaMinima.AutoSize = true;
            this.txtDistanciaMinima.Location = new System.Drawing.Point(404, 316);
            this.txtDistanciaMinima.Name = "txtDistanciaMinima";
            this.txtDistanciaMinima.Size = new System.Drawing.Size(71, 13);
            this.txtDistanciaMinima.TabIndex = 13;
            this.txtDistanciaMinima.Text = "Distancia Min";
            // 
            // txtDistanciaMaxima
            // 
            this.txtDistanciaMaxima.AutoSize = true;
            this.txtDistanciaMaxima.Location = new System.Drawing.Point(404, 349);
            this.txtDistanciaMaxima.Name = "txtDistanciaMaxima";
            this.txtDistanciaMaxima.Size = new System.Drawing.Size(74, 13);
            this.txtDistanciaMaxima.TabIndex = 14;
            this.txtDistanciaMaxima.Text = "Distancia Max";
            // 
            // txtDistanciaPromedio
            // 
            this.txtDistanciaPromedio.AutoSize = true;
            this.txtDistanciaPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistanciaPromedio.Location = new System.Drawing.Point(180, 401);
            this.txtDistanciaPromedio.Name = "txtDistanciaPromedio";
            this.txtDistanciaPromedio.Size = new System.Drawing.Size(146, 20);
            this.txtDistanciaPromedio.TabIndex = 15;
            this.txtDistanciaPromedio.Text = "Distancia Promedio";
            // 
            // lblSedeMinima
            // 
            this.lblSedeMinima.AutoSize = true;
            this.lblSedeMinima.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSedeMinima.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSedeMinima.Location = new System.Drawing.Point(12, 316);
            this.lblSedeMinima.Name = "lblSedeMinima";
            this.lblSedeMinima.Size = new System.Drawing.Size(118, 13);
            this.lblSedeMinima.TabIndex = 16;
            this.lblSedeMinima.Text = "Sede Más Cercana:";
            // 
            // lblSedeMaxima
            // 
            this.lblSedeMaxima.AutoSize = true;
            this.lblSedeMaxima.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSedeMaxima.Location = new System.Drawing.Point(12, 349);
            this.lblSedeMaxima.Name = "lblSedeMaxima";
            this.lblSedeMaxima.Size = new System.Drawing.Size(113, 13);
            this.lblSedeMaxima.TabIndex = 17;
            this.lblSedeMaxima.Text = "Sede Más Alejada:";
            // 
            // lblSedePromedio
            // 
            this.lblSedePromedio.AutoSize = true;
            this.lblSedePromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSedePromedio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblSedePromedio.Location = new System.Drawing.Point(415, 401);
            this.lblSedePromedio.Name = "lblSedePromedio";
            this.lblSedePromedio.Size = new System.Drawing.Size(177, 20);
            this.lblSedePromedio.TabIndex = 18;
            this.lblSedePromedio.Text = "Sede Recomendada:";
            this.lblSedePromedio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSedeMinima
            // 
            this.txtSedeMinima.AutoSize = true;
            this.txtSedeMinima.Location = new System.Drawing.Point(143, 316);
            this.txtSedeMinima.Name = "txtSedeMinima";
            this.txtSedeMinima.Size = new System.Drawing.Size(52, 13);
            this.txtSedeMinima.TabIndex = 19;
            this.txtSedeMinima.Text = "Sede Min";
            // 
            // txtSedeMax
            // 
            this.txtSedeMax.AutoSize = true;
            this.txtSedeMax.Location = new System.Drawing.Point(143, 349);
            this.txtSedeMax.Name = "txtSedeMax";
            this.txtSedeMax.Size = new System.Drawing.Size(55, 13);
            this.txtSedeMax.TabIndex = 20;
            this.txtSedeMax.Text = "Sede Max";
            // 
            // txtSedeProm
            // 
            this.txtSedeProm.AutoSize = true;
            this.txtSedeProm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSedeProm.Location = new System.Drawing.Point(598, 401);
            this.txtSedeProm.Name = "txtSedeProm";
            this.txtSedeProm.Size = new System.Drawing.Size(118, 20);
            this.txtSedeProm.TabIndex = 21;
            this.txtSedeProm.Text = "Sede Promedio";
            // 
            // txtAlumnoMasLejano
            // 
            this.txtAlumnoMasLejano.AutoSize = true;
            this.txtAlumnoMasLejano.Location = new System.Drawing.Point(657, 349);
            this.txtAlumnoMasLejano.Name = "txtAlumnoMasLejano";
            this.txtAlumnoMasLejano.Size = new System.Drawing.Size(65, 13);
            this.txtAlumnoMasLejano.TabIndex = 26;
            this.txtAlumnoMasLejano.Text = "Alumno Max";
            // 
            // txtAlumnoCercano
            // 
            this.txtAlumnoCercano.AutoSize = true;
            this.txtAlumnoCercano.Location = new System.Drawing.Point(657, 316);
            this.txtAlumnoCercano.Name = "txtAlumnoCercano";
            this.txtAlumnoCercano.Size = new System.Drawing.Size(62, 13);
            this.txtAlumnoCercano.TabIndex = 25;
            this.txtAlumnoCercano.Text = "Alumno Min";
            // 
            // lblAlumnoLejano
            // 
            this.lblAlumnoLejano.AutoSize = true;
            this.lblAlumnoLejano.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumnoLejano.Location = new System.Drawing.Point(599, 349);
            this.lblAlumnoLejano.Name = "lblAlumnoLejano";
            this.lblAlumnoLejano.Size = new System.Drawing.Size(52, 13);
            this.lblAlumnoLejano.TabIndex = 24;
            this.lblAlumnoLejano.Text = "Alumno:";
            // 
            // lblAlumnoCercano
            // 
            this.lblAlumnoCercano.AutoSize = true;
            this.lblAlumnoCercano.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumnoCercano.Location = new System.Drawing.Point(599, 316);
            this.lblAlumnoCercano.Name = "lblAlumnoCercano";
            this.lblAlumnoCercano.Size = new System.Drawing.Size(52, 13);
            this.lblAlumnoCercano.TabIndex = 23;
            this.lblAlumnoCercano.Text = "Alumno:";
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
            this.dtgAlumnos.MultiSelect = false;
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
            this.ctxMenuImportar.Name = "ctxMenuImportar";
            this.ctxMenuImportar.Size = new System.Drawing.Size(152, 22);
            this.ctxMenuImportar.Text = "Importar...";
            this.ctxMenuImportar.Click += new System.EventHandler(this.ctxMenuImportar_Click);
            // 
            // ctxMenuExportar
            // 
            this.ctxMenuExportar.Name = "ctxMenuExportar";
            this.ctxMenuExportar.Size = new System.Drawing.Size(152, 22);
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
            // pnlProgress
            // 
            this.pnlProgress.Controls.Add(this.progressBar);
            this.pnlProgress.Controls.Add(this.lblProgress);
            this.pnlProgress.Location = new System.Drawing.Point(274, 131);
            this.pnlProgress.Name = "pnlProgress";
            this.pnlProgress.Size = new System.Drawing.Size(302, 89);
            this.pnlProgress.TabIndex = 28;
            this.pnlProgress.Visible = false;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(17, 17);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(73, 13);
            this.lblProgress.TabIndex = 0;
            this.lblProgress.Text = "Procesando...";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(20, 45);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(267, 23);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 1;
            // 
            // GIS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 441);
            this.Controls.Add(this.pnlProgress);
            this.Controls.Add(this.dtgAlumnos);
            this.Controls.Add(this.txtAlumnoMasLejano);
            this.Controls.Add(this.txtAlumnoCercano);
            this.Controls.Add(this.lblAlumnoLejano);
            this.Controls.Add(this.lblAlumnoCercano);
            this.Controls.Add(this.txtSedeProm);
            this.Controls.Add(this.txtSedeMax);
            this.Controls.Add(this.txtSedeMinima);
            this.Controls.Add(this.lblSedePromedio);
            this.Controls.Add(this.lblSedeMaxima);
            this.Controls.Add(this.lblSedeMinima);
            this.Controls.Add(this.txtDistanciaPromedio);
            this.Controls.Add(this.txtDistanciaMaxima);
            this.Controls.Add(this.txtDistanciaMinima);
            this.Controls.Add(this.lblDistanciaPromedio);
            this.Controls.Add(this.lblDistanciaMaxima);
            this.Controls.Add(this.lblDistanciaMinima);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtUbicacion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblUbicacion);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.shapeContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GIS";
            this.Text = "GIS";
            this.Load += new System.EventHandler(this.GIS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlumnos)).EndInit();
            this.ctxMenuAlumnos.ResumeLayout(false);
            this.pnlProgress.ResumeLayout(false);
            this.pnlProgress.PerformLayout();
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
        private System.Windows.Forms.Label lblDistanciaMinima;
        private System.Windows.Forms.Label lblDistanciaMaxima;
        private System.Windows.Forms.Label lblDistanciaPromedio;
        private System.Windows.Forms.Label txtDistanciaMinima;
        private System.Windows.Forms.Label txtDistanciaMaxima;
        private System.Windows.Forms.Label txtDistanciaPromedio;
        private System.Windows.Forms.Label lblSedeMinima;
        private System.Windows.Forms.Label lblSedeMaxima;
        private System.Windows.Forms.Label lblSedePromedio;
        private System.Windows.Forms.Label txtSedeMinima;
        private System.Windows.Forms.Label txtSedeMax;
        private System.Windows.Forms.Label txtSedeProm;
        private System.Windows.Forms.Label txtAlumnoMasLejano;
        private System.Windows.Forms.Label txtAlumnoCercano;
        private System.Windows.Forms.Label lblAlumnoLejano;
        private System.Windows.Forms.Label lblAlumnoCercano;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
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
        private System.Windows.Forms.Panel pnlProgress;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblProgress;

    }
}

