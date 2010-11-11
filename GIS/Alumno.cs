using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GoogleGeocoder;


namespace GIS
{
    class Alumno
    {

        protected static Coordenada medrano = Geocode.GetCoordinates("Av Medrano 951, Ciudad Autónoma de Buenos Aires, Capital Federal");
        protected static Coordenada campus = Geocode.GetCoordinates("Mozart 3200, Ciudad Autónoma de Buenos Aires, Capital Federal");

        private String _apellido;
        private String _nombre;
        private String _direccion;
        private double? _latitude;
        private double? _longitude;
        private double? _distanciaMedrano;
        private double? _distanciaCampus;

        public Alumno(string nombre, string apellido, string direccion)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Direccion = direccion;
        }

        public String Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        
        public String Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        
        public String Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        public double Latitude {
            get { return getLatitude(); }
        }

        private double getLatitude()
        {
            if (!_latitude.HasValue)
            {
                _latitude = Geocode.GetCoordinates(this.Direccion).Latitude;
            }
            return _latitude.Value;
        }

        public double Longitude
        {
            get { return getLongitude(); }
        }

        private double getLongitude()
        {
            if (!_longitude.HasValue) {
                _longitude = Geocode.GetCoordinates(this.Direccion).Longitude;
            }
            return _longitude.Value;
        }

        public String NombreCompleto {
            get { return this.Apellido + ", " + this.Nombre; }
        }

        public double DistanceMedrano {
            get { return getDistanciaMedrano(); }
        }

        private double getDistanciaMedrano()
        {
            if (! _distanciaMedrano.HasValue) {
                _distanciaMedrano = Geocode.GetCoordinates(this.Direccion).Distance(medrano);
            }
            return _distanciaMedrano.Value;
        }

        public double DistanceCampus
        {
            get { return getDistanciaCampus(); }
        }

        private double getDistanciaCampus()
        {
            if (! _distanciaCampus.HasValue) {
                _distanciaCampus = Geocode.GetCoordinates(this.Direccion).Distance(campus);
            }
            return _distanciaCampus.Value;
        }
    }
}
