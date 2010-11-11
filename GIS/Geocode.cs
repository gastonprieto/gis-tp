using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Net;
using GIS;
using System.Diagnostics;


namespace GoogleGeocoder
{
    public interface CoordenadaEspacial
    {
        double Latitude { get; set; }
        double Longitude { get; set; }
    }
    
    public class Geocode
    {
        private const string _googleUri = "http://maps.google.com/maps/geo?q=";
        private const string _googleKey = "yourkey"; // Get your key from:  http://www.google.com/apis/maps/signup.html
        private const string _outputType = "csv"; // Available options: csv, xml, kml, json

        private static Uri GetGeocodeUri(string address)
        {
            address = HttpUtility.UrlEncode(address);
            return new Uri(String.Format("{0}{1}&output={2}&key={3}", _googleUri, address, _outputType, _googleKey));
        }

        public static Coordenada GetCoordinates(string address)
        {
            WebClient client = new WebClient();
            Uri uri = GetGeocodeUri(address);
            
            string[] geocodeInfo = client.DownloadString(uri).Split(',');
            Debug.WriteLine("Point[addres=" + address + "; latitude=" + geocodeInfo[2] + "; longitude=" + geocodeInfo[3] + "]");

            return new Coordenada(address, Convert.ToDouble(geocodeInfo[2]), Convert.ToDouble(geocodeInfo[3]));
        }

    }
}

