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
            dtgAlumnos.DataSource = new BindingList<Alumno>();
        }

        private void resetAlumno() {
            txtNombre.Text = String.Empty;
            txtApellido.Text = String.Empty;
            txtUbicacion.Text = String.Empty;
            
            txtNombre.Focus();
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
            return new Alumno(txtNombre.Text.Trim(), txtApellido.Text.Trim(), txtUbicacion.Text.Trim());
        }
            
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNombre.Text)) {
                MessageBox.Show("Se debe ingresar el nombre del alumno");
                return;
            }
            if (String.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("Se debe ingresar el nombre del alumno");
                return;
            }
            if (String.IsNullOrEmpty(txtUbicacion.Text))
            {
                MessageBox.Show("Se debe ingresar el nombre del alumno");
                return;
            }
            BindingList<Alumno> alumnos = (BindingList<Alumno>)dtgAlumnos.DataSource;
            alumnos.Add(bind());
            dtgAlumnos.DataSource = alumnos;
            updateStadistics(alumnos);
            resetAlumno();
        }

        private void updateStadistics(BindingList<Alumno> alumnos)
        {
            if (alumnos.Count > 0)
            {
                // Actualizo los datos del alumno que tiene más cerca una sede
                Alumno elAlumnoMasCercano = alumnos.Aggregate(alumnos[0], (Alumno alumnoLejano, Alumno alumno) => alumnoMasCercano(alumnoLejano, alumno));
                txtAlumnoCercano.Text = elAlumnoMasCercano.NombreCompleto;
                txtDistanciaMinima.Text = String.Format("{0:0.0000}", elAlumnoMasCercano.DistanciaA(elAlumnoMasCercano.sedeMasCercana())) + " Km.";
                txtSedeMinima.Text = elAlumnoMasCercano.sedeMasCercana().Name;

                // Actualizo los datos del alumno que tiene maás lejos una sede
                Alumno elAlumnoMasLejano = alumnos.Aggregate(alumnos[0], (Alumno alumnoLejano, Alumno alumno) => alumnoMasLejano(alumnoLejano, alumno));
                txtAlumnoMasLejano.Text = elAlumnoMasLejano.NombreCompleto;
                txtDistanciaMaxima.Text = String.Format("{0:0.0000}", elAlumnoMasLejano.DistanciaA(elAlumnoMasLejano.sedeMasLejana())) + " Km.";
                txtSedeMax.Text = elAlumnoMasLejano.sedeMasLejana().Name;

                // Actualizo los datos de la sede q mejor se ajusta
                Double latitudeProm = alumnos.Sum<Alumno>((Alumno alumno) => alumno.Latitude) / alumnos.Count;
                Double longitudeProm = alumnos.Sum<Alumno>((Alumno alumno) => alumno.Longitude) / alumnos.Count;
                Coordenada coordenada = new Coordenada("Coordenada Promedio", "");
                coordenada.Latitude = latitudeProm;
                coordenada.Longitude = longitudeProm;
                double distanciaCampus = coordenada.Distance(Helpers.CAMPUS);
                double distanciaMedrano = coordenada.Distance(Helpers.MEDRANO);
                if (distanciaCampus < distanciaMedrano)
                {
                    txtDistanciaPromedio.Text = String.Format("{0:0.0000}", distanciaCampus) + " Km.";
                    txtSedeProm.Text = Helpers.CAMPUS.Name;
                }
                else
                {
                    txtDistanciaPromedio.Text = String.Format("{0:0.0000}", distanciaMedrano) + " Km.";
                    txtSedeProm.Text = Helpers.MEDRANO.Name;
                }
            }
            else {
                resetTotals();
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

        private void ctxMenuImportar_Click(object sender, EventArgs e)
        {
            if (dlgOpen.ShowDialog() == DialogResult.OK) {
                String fileName = dlgOpen.FileName;
                try
                {
                    IList<Alumno> alumnos = InterfaceXML.importFrom(fileName);
                    BindingList<Alumno> alumnosDS = (BindingList<Alumno>)dtgAlumnos.DataSource;
                    alumnos.ToList().ForEach((Alumno alumno) => alumnosDS.Add(alumno));
                    dtgAlumnos.DataSource = alumnosDS;
                    updateStadistics(alumnosDS);
                    resetAlumno();
                }
                catch (Exception ex) 
                {
                    MessageBox.Show(ex.Message, "Error al importar el archivo " + fileName);
                }
            }
        }

        private void ctxMenuExportar_Click(object sender, EventArgs e)
        {
            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                String fileName = dlgSave.FileName;
                BindingList<Alumno> alumnosDS = (BindingList<Alumno>)dtgAlumnos.DataSource;
                InterfaceXML.exportTo(fileName, alumnosDS);

            }
        }

        private void dtgAlumnos_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            BindingList<Alumno> alumnos = (BindingList<Alumno>)dtgAlumnos.DataSource;
            updateStadistics(alumnos);
        }
        
    }
}
