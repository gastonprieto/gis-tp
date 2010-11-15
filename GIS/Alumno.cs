using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GoogleGeocoder;


namespace GIS
{
    class Alumno
    {
        #region Internal State
        protected static Coordenada medrano = new Coordenada("UTN FRBA - Medrano", "Av Medrano 951, Ciudad Autónoma de Buenos Aires, Capital Federal");
        protected static Coordenada campus = new Coordenada("UTN FRBA - Campus", "Mozart 3200, Ciudad Autónoma de Buenos Aires, Capital Federal");

        protected Double? _distanciaMedrano;
        protected Double? _distanciaCampus;
        #endregion
        #region Constructors
        public Alumno(string nombre, string apellido, String direccion)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Direccion = new Coordenada(direccion);
        }
        #endregion
        #region Properties
        public String Nombre {get; set;}
        public String Apellido { get; set; }
        public Coordenada Direccion { get; set; }
        public Double Latitude 
        {
            get { return Direccion.Latitude.Value; }
        }
        public Double Longitude
        {
            get { return Direccion.Longitude.Value; }
        }
        public String Ubicacion 
        {
            get { return Direccion.Address; }
        }
        public String NombreCompleto {
            get { return this.Apellido + ", " + this.Nombre; }
        }
        public double DistanceMedrano
        {
            get { return getDistanciaMedrano(); }
        }
        public double DistanceCampus
        {
            get { return getDistanciaCampus(); }
        }
        #endregion
        #region Bussiness Method
        public double DistanciaA(Coordenada coordenada)
        {
            return Direccion.Distance(coordenada);
        }
        private double getDistanciaCampus()
        {
            if (! _distanciaCampus.HasValue) {
                _distanciaCampus = Direccion.Distance(campus);
            }
            return _distanciaCampus.Value;
        }
        private double getDistanciaMedrano()
        {
            if (!_distanciaMedrano.HasValue)
            {
                _distanciaMedrano = Direccion.Distance(medrano);
            }
            return _distanciaMedrano.Value;
        }
        public Coordenada sedeMasCercana()
        {
            if (DistanceCampus < DistanceMedrano)
            {
                return campus;
            }
            else
            {
                return medrano;
            }
        }
        public Coordenada sedeMasLejana()
        {
            if (DistanceCampus > DistanceMedrano)
            {
                return campus;
            }
            else
            {
                return medrano;
            }
        }
        #endregion
    }
}
