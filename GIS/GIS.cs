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

        private BindingList<Alumno> alumnosGrid = new BindingList<Alumno>();

        public GIS()
        {
            InitializeComponent();
        }

        private void GIS_Load(object sender, EventArgs e)
        {
            resetTotals();
            dtgAlumnos.AutoGenerateColumns = false;
            dtgAlumnos.DataSource = alumnosGrid;
        }

        private void resetAlumno() {
            txtNombre.Text = String.Empty;
            txtApellido.Text = String.Empty;
            txtUbicacion.Text = String.Empty;
            
            txtNombre.Focus();
        }

        private void resetTotals()
        {

            // MEDRANO
            txtAlumnoCercanoMedrano.Text = "";
            txtDistanciaMinimaMedrano.Text = "";
            
            txtAlumnoLejanoMedrano.Text = "";
            txtDistanciaMaximaMedrano.Text = "";

            txtDistanciaPromedioMedrano.Text = "";
            txtDistanciaPromedioMedrano.BackColor = Color.White;

            // CAMPUS
            txtAlumnoCercanoCampus.Text = "";
            txtDistanciaMinimaCampus.Text = "";

            txtAlumnoLejanoCampus.Text = "";
            txtDistanciaMaximaCampus.Text = "";

            txtDistanciaPromedioCampus.Text = "";
            txtDistanciaPromedioCampus.BackColor = Color.White;
        }

        private Alumno bind() {
            return new Alumno(txtNombre.Text.Trim(), txtApellido.Text.Trim(), txtUbicacion.Text.Trim());
        }
            
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            statusInfo.Text = "Agregando Alumno...";

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
                MessageBox.Show("Se debe ingresar la direccion del alumno");
                return;
            }
            if (!Geocode.isUniqueAddress(txtUbicacion.Text)) {
                BindingList<String> direcciones = Geocode.getSimilars(txtUbicacion.Text);
                SelectAddress formAddress = new SelectAddress();
                formAddress.loadAddress(direcciones);
                formAddress.ShowDialog();
                if (String.IsNullOrEmpty(formAddress.DireccionSelected) || formAddress.DireccionSelected.Equals(txtUbicacion.Text)){
                    MessageBox.Show("Se debe refinar la dirección");
                    return; 
                }
            }

            Alumno alumno = bind();
            alumnosGrid.Add(alumno);

            statusInfo.Text = "Alumno agregado satisfactoriamente (" + alumno.NombreCompleto + ")"; 
            updateStadistics();
            resetAlumno();
        }

        private void updateStadistics()
        {
            if (alumnosGrid.Count > 0)
            {
                // MEDRANO
                Alumno alumnoCercanoMedrano = alumnosGrid.Aggregate(alumnosGrid[0], (Alumno alumno, Alumno otroAlumno) => alumno.masCercanoA(otroAlumno, Helpers.MEDRANO));
                Alumno alumnoLejanoMedrano = alumnosGrid.Aggregate(alumnosGrid[0], (Alumno alumno, Alumno otroAlumno) => alumno.masLejanoA(otroAlumno, Helpers.MEDRANO));
                Double promedioMedrano = alumnosGrid.Sum((Alumno alumno) => alumno.DistanceMedrano) / alumnosGrid.Count;

                txtAlumnoCercanoMedrano.Text = alumnoCercanoMedrano.NombreCompleto;
                txtDistanciaMinimaMedrano.Text = alumnoCercanoMedrano.DistanceMedrano.ToString(".0000 Km.");
                txtAlumnoLejanoMedrano.Text = alumnoLejanoMedrano.NombreCompleto;
                txtDistanciaMaximaMedrano.Text = alumnoLejanoMedrano.DistanceMedrano.ToString(".0000 Km.");
                txtDistanciaPromedioMedrano.Text = promedioMedrano.ToString(".0000 Km.");

                // CAMPUS
                Alumno alumnoCercanoCampus = alumnosGrid.Aggregate(alumnosGrid[0], (Alumno alumno, Alumno otroAlumno) => alumno.masCercanoA(otroAlumno, Helpers.CAMPUS));
                Alumno alumnoLejanoCampus = alumnosGrid.Aggregate(alumnosGrid[0], (Alumno alumno, Alumno otroAlumno) => alumno.masLejanoA(otroAlumno, Helpers.CAMPUS));
                Double promedioCampus = alumnosGrid.Sum((Alumno alumno) => alumno.DistanceCampus) / alumnosGrid.Count;

                txtAlumnoCercanoCampus.Text = alumnoCercanoCampus.NombreCompleto;
                txtDistanciaMinimaCampus.Text = alumnoCercanoCampus.DistanceCampus.ToString(".0000 Km.");
                txtAlumnoLejanoCampus.Text = alumnoLejanoCampus.NombreCompleto;
                txtDistanciaMaximaCampus.Text = alumnoLejanoCampus.DistanceCampus.ToString(".0000 Km.");
                txtDistanciaPromedioCampus.Text = promedioCampus.ToString(".0000 Km.");


                if (promedioMedrano < promedioCampus){
                    setHighColor(txtDistanciaPromedioMedrano);
                    setNormalColor(txtDistanciaPromedioCampus);
                }else{
                    setHighColor(txtDistanciaPromedioCampus);
                    setNormalColor(txtDistanciaPromedioMedrano);
                }
            }
            else {
                resetTotals();
            }
        }

        protected void setNormalColor(TextBox txtbox) {
            txtbox.BackColor = Color.Blue;
            txtbox.ForeColor = Color.White;
        }

        protected void setHighColor(TextBox txtbox)
        {
            txtbox.BackColor = Color.White;
            txtbox.ForeColor = Color.Black;
        }
        private void ctxMenuImportar_Click(object sender, EventArgs e)
        {
            if (dlgOpen.ShowDialog() == DialogResult.OK) {
                String fileName = dlgOpen.FileName;
                try
                {
                    statusInfo.Text = "Importando Archivo...";
                    IList<Alumno> alumnos = InterfaceXML.importFrom(fileName);
                    alumnos.ToList().ForEach((Alumno alumno) => alumnosGrid.Add(alumno));
                    statusInfo.Text = "Archivo Importado satisfactoriamente (" + fileName + ")...";
                    updateStadistics();
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
                statusInfo.Text = "Exportando archivo...";
                InterfaceXML.exportTo(fileName, alumnosGrid);
                statusInfo.Text = "Archivo Exportado satisfactoriamente (" + fileName + ")";
            }
        }

        private void dtgAlumnos_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            updateStadistics();
        }

    }
}
