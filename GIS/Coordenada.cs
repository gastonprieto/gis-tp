using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GoogleGeocoder;
using System.Globalization;

namespace GIS
{
    public class Coordenada
    {
        public Coordenada(String name, String address)
        {
            Name = name;
            Address = address;
        }

        public Coordenada(string direccion)
        {
            Name = direccion;
            Address = direccion;
        }
        public Coordenada()
        {
        }

        protected double? _latitude;
        protected double? _longitude;

        public String Name { get; set; }
        public double? Latitude { get { return getLatitude(); } set { _latitude = value; } }
        public double? Longitude { get { return getLongitude(); } set { _longitude = value; } }
        public String Address { get; set; }

        public double Distance(Coordenada otherCoordenate)
        {
            double earthRadius = 6371;
            double deltaLatitude = ToRadian(otherCoordenate.Latitude - Latitude);
            double deltaLongitude = ToRadian(otherCoordenate.Longitude - Longitude);
            double a = Math.Sin(deltaLatitude / 2) * Math.Sin(deltaLatitude / 2) +
                       Math.Cos(ToRadian(Latitude)) * Math.Cos(ToRadian(otherCoordenate.Latitude)) *
                       Math.Sin(deltaLongitude / 2) * Math.Sin(deltaLongitude / 2);
            double distanceAngular = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            return earthRadius * distanceAngular;
        }

        private double? getLongitude()
        {
            if (!_longitude.HasValue) {
                initializeLatitudeAndLongitude();
            }
            return _longitude;
        }

        private double? getLatitude()
        {
            if (!_latitude.HasValue) {
                initializeLatitudeAndLongitude();
            }
            return _latitude;
        }

        private void initializeLatitudeAndLongitude()
        {
            String[] geoCodeInfo = Geocode.geoCodeInfo(Address);
            _latitude = Convert.ToDouble(geoCodeInfo[2], new CultureInfo("en-US"));
            _longitude = Convert.ToDouble(geoCodeInfo[3], new CultureInfo("en-US"));
        }
        
        protected double ToRadian(double? angle)
        {
            return Math.PI * angle.Value / 180.0;
        }

        protected double ToDegree(double? angle)
        {
            return angle.Value * (180.0 / Math.PI);
        }

    }
}
