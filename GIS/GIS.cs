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
            txtAlumnoCercano.Text = String.Empty;
            txtAlumnoMasLejano.Text = String.Empty;

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

            updateStadistics(alumnos);

            resetAlumno();
        }

        private void updateStadistics(List<Alumno> alumnos)
        {
            Alumno elAlumnoMasCercano = alumnos.Aggregate(alumnos[0], (Alumno alumnoLejano, Alumno alumno) => alumnoMasCercano(alumnoLejano, alumno));
            txtAlumnoCercano.Text = elAlumnoMasCercano.NombreCompleto;
            txtDistanciaMinima.Text = elAlumnoMasCercano.DistanciaA(elAlumnoMasCercano.sedeMasCercana()).ToString();
            txtSedeMinima.Text = elAlumnoMasCercano.sedeMasCercana().Name;
                        
            Alumno elAlumnoMasLejano = alumnos.Aggregate(alumnos[0], (Alumno alumnoLejano, Alumno alumno) => alumnoMasLejano(alumnoLejano, alumno));
            txtAlumnoMasLejano.Text = elAlumnoMasLejano.NombreCompleto;
            txtDistanciaMaxima.Text = elAlumnoMasLejano.DistanciaA(elAlumnoMasLejano.sedeMasLejana()).ToString();
            txtSedeMax.Text = elAlumnoMasLejano.sedeMasLejana().Name;

            Double latitudeProm = alumnos.Sum<Alumno>( (Alumno alumno) => alumno.Latitude ) / alumnos.Count;
            Double longitudeProm = alumnos.Sum<Alumno>((Alumno alumno) => alumno.Longitude) / alumnos.Count;
            Coordenada coordenada = new Coordenada("Coordenada Promedio", "");
            coordenada.Latitude = latitudeProm;
            coordenada.Longitude = longitudeProm;
            double distanciaCampus = coordenada.Distance(Helpers.CAMPUS);
            double distanciaMedrano = coordenada.Distance(Helpers.MEDRANO);
            if (distanciaCampus < distanciaMedrano)
            {
                txtDistanciaPromedio.Text = distanciaCampus.ToString();
                txtSedeProm.Text = Helpers.CAMPUS.Name;
            }
            else 
            {
                txtDistanciaPromedio.Text = distanciaMedrano.ToString();
                txtSedeProm.Text = Helpers.MEDRANO.Name;
            }
        }

        private Alumno alumnoMasLejano(Alumno alumnoLejano, Alumno alumno)
        {
            if (alumnoLejano.DistanciaA(alumnoLejano.sedeMasLejana()) > alumno.DistanciaA(alumno.sedeMasLejana()))
            {
                return alumnoLejano;
            }
            else 
            {
                return alumno;
            }
        }

        private Alumno alumnoMasCercano(Alumno alumnoCercano, Alumno alumno)
        {
            if (alumnoCercano.DistanciaA(alumnoCercano.sedeMasCercana()) < alumno.DistanciaA(alumno.sedeMasCercana()))
            {
                return alumnoCercano;
            }
            else
            {
                return alumno;
            }
        }

        
    }
}
