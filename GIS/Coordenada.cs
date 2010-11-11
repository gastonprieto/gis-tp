using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GoogleGeocoder;

namespace GIS
{
    public class Coordenada : CoordenadaEspacial
    {
        public Coordenada(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        #region ISpatialCoordinate Members

        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public double Distance(Coordenada otherCoordenate)
        {
            double theta = Longitude - otherCoordenate.Longitude;
            double dist = Math.Sin(DegreeToRadian(Latitude))
                    * Math.Sin(DegreeToRadian(otherCoordenate.Latitude))
                    + Math.Cos(DegreeToRadian(Latitude))
                    * Math.Cos(DegreeToRadian(otherCoordenate.Latitude)) * Math.Cos(DegreeToRadian(theta));
            dist = Math.Acos(dist);
            dist = DegreeToRadian(dist);
            dist = dist * 60 * 1.1515;
            dist = dist * 1.609344;
            
            return dist;
        }

        
        protected double DegreeToRadian(double angle)
        {
            return Math.PI * angle / 180.0;
        }

        protected double RadianToDegree(double angle)
        {
            return angle * (180.0 / Math.PI);
        }
        #endregion
    }
}
