using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GoogleGeocoder;

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

        protected double? _latitude;
        protected double? _longitude;

        public String Name { get; set; }
        public double? Latitude { get { return getLatitude(); } }
        public double? Longitude { get { return getLongitude(); } }
        public String Address { get; set; }

        public double Distance(Coordenada otherCoordenate)
        {
            double earthRadius = 3958.75;
            double dLat = ToRadian(otherCoordenate.Latitude - Latitude);
            double dLng = ToRadian(otherCoordenate.Longitude - Longitude);
            double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                       Math.Cos(ToRadian(Latitude)) * Math.Cos(ToRadian(otherCoordenate.Latitude)) *
                       Math.Sin(dLng / 2) * Math.Sin(dLng / 2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            double dist = earthRadius * c;

            int meterConversion = 1609;

            return dist * meterConversion;
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
            _latitude = Convert.ToDouble(geoCodeInfo[2]);
            _longitude = Convert.ToDouble(geoCodeInfo[3]);
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
