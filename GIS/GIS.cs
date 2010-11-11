using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using GoogleGeocoder;

namespace GIS
{
    public partial class GIS : Form
    {

        public GIS()
        {
            InitializeComponent();
        }

        private void GIS_Load(object sender, EventArgs e)
        {
            resetTotals();
            dtgAlumnos.AutoGenerateColumns = false;
            dtgAlumnos.DataSource = new List<Alumno>();
        }

        private void resetAlumno() {
            txtApellido.Text = String.Empty;
            txtUbicacion.Text = String.Empty;
            txtNombre.Text = String.Empty;
        }

        private void resetTotals()
        {
            txtDistanciaMaxima.Text = String.Empty;
            txtDistanciaMinima.Text = String.Empty;
            txtDistanciaPromedio.Text = String.Empty;
            txtSedeMax.Text = String.Empty;
            txtSedeMinima.Text = String.Empty;
            txtSedeProm.Text = String.Empty;
        }

        private Alumno bind() {
            return new Alumno(txtNombre.Text, txtApellido.Text, txtUbicacion.Text);
        }
            
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            List<Alumno> alumnos = (List<Alumno>) dtgAlumnos.DataSource;
            alumnos.Add(bind());
            
            dtgAlumnos.DataSource = null;
            dtgAlumnos.DataSource = alumnos;
            resetAlumno();
        }

    }
}
