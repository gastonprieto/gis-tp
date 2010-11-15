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
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
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
            this.dtgAlumnos = new System.Windows.Forms.DataGridView();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DistanceCampus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DistanceMedrano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnuCtxGrid = new ComponentFactory.Krypton.Toolkit.KryptonContextMenu();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlumnos)).BeginInit();
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
            this.btnAgregar.Location = new System.Drawing.Point(526, 34);
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
            this.txtNombre.Size = new System.Drawing.Size(176, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(81, 36);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(424, 20);
            this.txtUbicacion.TabIndex = 3;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(332, 6);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(173, 20);
            this.txtApellido.TabIndex = 2;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(279, 9);
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
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(613, 393);
            this.shapeContainer1.TabIndex = 9;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 10;
            this.lineShape2.X2 = 598;
            this.lineShape2.Y1 = 298;
            this.lineShape2.Y2 = 298;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 8;
            this.lineShape1.X2 = 600;
            this.lineShape1.Y1 = 72;
            this.lineShape1.Y2 = 72;
            // 
            // lblDistanciaMinima
            // 
            this.lblDistanciaMinima.AutoSize = true;
            this.lblDistanciaMinima.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistanciaMinima.Location = new System.Drawing.Point(12, 313);
            this.lblDistanciaMinima.Name = "lblDistanciaMinima";
            this.lblDistanciaMinima.Size = new System.Drawing.Size(107, 13);
            this.lblDistanciaMinima.TabIndex = 10;
            this.lblDistanciaMinima.Text = "Distancia Minima:";
            // 
            // lblDistanciaMaxima
            // 
            this.lblDistanciaMaxima.AutoSize = true;
            this.lblDistanciaMaxima.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistanciaMaxima.Location = new System.Drawing.Point(12, 340);
            this.lblDistanciaMaxima.Name = "lblDistanciaMaxima";
            this.lblDistanciaMaxima.Size = new System.Drawing.Size(110, 13);
            this.lblDistanciaMaxima.TabIndex = 11;
            this.lblDistanciaMaxima.Text = "Distancia Máxima:";
            // 
            // lblDistanciaPromedio
            // 
            this.lblDistanciaPromedio.AutoSize = true;
            this.lblDistanciaPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistanciaPromedio.Location = new System.Drawing.Point(12, 366);
            this.lblDistanciaPromedio.Name = "lblDistanciaPromedio";
            this.lblDistanciaPromedio.Size = new System.Drawing.Size(120, 13);
            this.lblDistanciaPromedio.TabIndex = 12;
            this.lblDistanciaPromedio.Text = "Distancia Promedio:";
            // 
            // txtDistanciaMinima
            // 
            this.txtDistanciaMinima.AutoSize = true;
            this.txtDistanciaMinima.Location = new System.Drawing.Point(142, 313);
            this.txtDistanciaMinima.Name = "txtDistanciaMinima";
            this.txtDistanciaMinima.Size = new System.Drawing.Size(71, 13);
            this.txtDistanciaMinima.TabIndex = 13;
            this.txtDistanciaMinima.Text = "Distancia Min";
            // 
            // txtDistanciaMaxima
            // 
            this.txtDistanciaMaxima.AutoSize = true;
            this.txtDistanciaMaxima.Location = new System.Drawing.Point(142, 340);
            this.txtDistanciaMaxima.Name = "txtDistanciaMaxima";
            this.txtDistanciaMaxima.Size = new System.Drawing.Size(74, 13);
            this.txtDistanciaMaxima.TabIndex = 14;
            this.txtDistanciaMaxima.Text = "Distancia Max";
            // 
            // txtDistanciaPromedio
            // 
            this.txtDistanciaPromedio.AutoSize = true;
            this.txtDistanciaPromedio.Location = new System.Drawing.Point(142, 366);
            this.txtDistanciaPromedio.Name = "txtDistanciaPromedio";
            this.txtDistanciaPromedio.Size = new System.Drawing.Size(78, 13);
            this.txtDistanciaPromedio.TabIndex = 15;
            this.txtDistanciaPromedio.Text = "Distancia Prom";
            // 
            // lblSedeMinima
            // 
            this.lblSedeMinima.AutoSize = true;
            this.lblSedeMinima.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSedeMinima.Location = new System.Drawing.Point(279, 313);
            this.lblSedeMinima.Name = "lblSedeMinima";
            this.lblSedeMinima.Size = new System.Drawing.Size(125, 13);
            this.lblSedeMinima.TabIndex = 16;
            this.lblSedeMinima.Text = "Sede Recomendada:";
            // 
            // lblSedeMaxima
            // 
            this.lblSedeMaxima.AutoSize = true;
            this.lblSedeMaxima.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSedeMaxima.Location = new System.Drawing.Point(279, 340);
            this.lblSedeMaxima.Name = "lblSedeMaxima";
            this.lblSedeMaxima.Size = new System.Drawing.Size(125, 13);
            this.lblSedeMaxima.TabIndex = 17;
            this.lblSedeMaxima.Text = "Sede Recomendada:";
            // 
            // lblSedePromedio
            // 
            this.lblSedePromedio.AutoSize = true;
            this.lblSedePromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSedePromedio.Location = new System.Drawing.Point(279, 366);
            this.lblSedePromedio.Name = "lblSedePromedio";
            this.lblSedePromedio.Size = new System.Drawing.Size(125, 13);
            this.lblSedePromedio.TabIndex = 18;
            this.lblSedePromedio.Text = "Sede Recomendada:";
            this.lblSedePromedio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSedeMinima
            // 
            this.txtSedeMinima.AutoSize = true;
            this.txtSedeMinima.Location = new System.Drawing.Point(420, 313);
            this.txtSedeMinima.Name = "txtSedeMinima";
            this.txtSedeMinima.Size = new System.Drawing.Size(52, 13);
            this.txtSedeMinima.TabIndex = 19;
            this.txtSedeMinima.Text = "Sede Min";
            // 
            // txtSedeMax
            // 
            this.txtSedeMax.AutoSize = true;
            this.txtSedeMax.Location = new System.Drawing.Point(420, 340);
            this.txtSedeMax.Name = "txtSedeMax";
            this.txtSedeMax.Size = new System.Drawing.Size(55, 13);
            this.txtSedeMax.TabIndex = 20;
            this.txtSedeMax.Text = "Sede Max";
            // 
            // txtSedeProm
            // 
            this.txtSedeProm.AutoSize = true;
            this.txtSedeProm.Location = new System.Drawing.Point(420, 366);
            this.txtSedeProm.Name = "txtSedeProm";
            this.txtSedeProm.Size = new System.Drawing.Size(59, 13);
            this.txtSedeProm.TabIndex = 21;
            this.txtSedeProm.Text = "Sede Prom";
            // 
            // dtgAlumnos
            // 
            this.dtgAlumnos.AllowUserToAddRows = false;
            this.dtgAlumnos.AllowUserToDeleteRows = false;
            this.dtgAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreCompleto,
            this.Ubicacion,
            this.DistanceCampus,
            this.DistanceMedrano});
            this.dtgAlumnos.Location = new System.Drawing.Point(8, 81);
            this.dtgAlumnos.MultiSelect = false;
            this.dtgAlumnos.Name = "dtgAlumnos";
            this.dtgAlumnos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtgAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgAlumnos.ShowEditingIcon = false;
            this.dtgAlumnos.Size = new System.Drawing.Size(591, 209);
            this.dtgAlumnos.TabIndex = 22;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.DataPropertyName = "NombreCompleto";
            this.NombreCompleto.HeaderText = "Apellido, Nombre";
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            // 
            // Ubicacion
            // 
            this.Ubicacion.DataPropertyName = "Ubicacion";
            this.Ubicacion.HeaderText = "Ubicación";
            this.Ubicacion.Name = "Ubicacion";
            this.Ubicacion.ReadOnly = true;
            // 
            // DistanceCampus
            // 
            this.DistanceCampus.DataPropertyName = "DistanceCampus";
            this.DistanceCampus.HeaderText = "Distancia a Campus";
            this.DistanceCampus.Name = "DistanceCampus";
            this.DistanceCampus.ReadOnly = true;
            // 
            // DistanceMedrano
            // 
            this.DistanceMedrano.DataPropertyName = "DistanceMedrano";
            this.DistanceMedrano.HeaderText = "Distancia a Medrano";
            this.DistanceMedrano.Name = "DistanceMedrano";
            this.DistanceMedrano.ReadOnly = true;
            // 
            // GIS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 393);
            this.Controls.Add(this.dtgAlumnos);
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
        private System.Windows.Forms.DataGridView dtgAlumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ubicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DistanceCampus;
        private System.Windows.Forms.DataGridViewTextBoxColumn DistanceMedrano;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenu mnuCtxGrid;

    }
}

