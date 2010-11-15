using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Net;
using GIS;
using System.Diagnostics;


namespace GoogleGeocoder
{
    
    public class Geocode
    {
        private const string _googleUri = "http://maps.google.com/maps/geo?q=";
        private const string _googleKey = "ABQIAAAAV97fQygxEv4ID2q86Y4brhQnVTSv6XhOKLxt7w4XsRuTA4AxURSQy752oGLIMKX1fUt4zZ0i1LxIWg"; // Get your key from:  http://www.google.com/apis/maps/signup.html
        private const string _outputType = "csv"; // Available options: csv, xml, kml, json

        private static Uri GetGeocodeUri(string address)
        {
            address = HttpUtility.UrlEncode(address);
            return new Uri(String.Format("{0}{1}&output={2}&key={3}", _googleUri, address, _outputType, _googleKey));
        }

        public static string[] geoCodeInfo(string address)
        {
            WebClient client = new WebClient();
            Uri uri = GetGeocodeUri(address);
            
            string[] geocodeInfo = client.DownloadString(uri).Split(',');
            Debug.WriteLine("Point[addres=" + address + "; latitude=" + geocodeInfo[2] + "; longitude=" + geocodeInfo[3] + "]");

            return geocodeInfo;
        }

    }
}

