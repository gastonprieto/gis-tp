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
                _distanciaCampus = Direccion.Distance(Helpers.CAMPUS);
            }
            return _distanciaCampus.Value;
        }
        private double getDistanciaMedrano()
        {
            if (!_distanciaMedrano.HasValue)
            {
                _distanciaMedrano = Direccion.Distance(Helpers.MEDRANO);
            }
            return _distanciaMedrano.Value;
        }
        public Coordenada sedeMasCercana()
        {
            if (DistanceCampus < DistanceMedrano)
            {
                return Helpers.CAMPUS;
            }
            else
            {
                return Helpers.MEDRANO;
            }
        }
        public Coordenada sedeMasLejana()
        {
            if (DistanceCampus > DistanceMedrano)
            {
                return Helpers.CAMPUS;
            }
            else
            {
                return Helpers.MEDRANO;
            }
        }
        #endregion
    }
}
