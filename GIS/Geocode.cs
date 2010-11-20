using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Net;
using GIS;
using System.Diagnostics;
using System.ComponentModel;
using System.Xml;
using System.Globalization;


namespace GoogleGeocoder
{
    
    public class Geocode
    {
        private const string _googleUri = "http://maps.google.com/maps/geo?q=";
        private const string _googleKey = "ABQIAAAAV97fQygxEv4ID2q86Y4brhQnVTSv6XhOKLxt7w4XsRuTA4AxURSQy752oGLIMKX1fUt4zZ0i1LxIWg"; // Get your key from:  http://www.google.com/apis/maps/signup.html
        private const string _outputType = "xml"; // Available options: csv, xml, kml, json

        private static Uri GetGeocodeUri(string address)
        {
            address = HttpUtility.UrlEncode(address);
            return new Uri(String.Format("{0}{1}&output={2}&key={3}", _googleUri, address, _outputType, _googleKey));
        }

        public static List<Point> geoCodeInfo(string address)
        {
            WebClient client = new WebClient();
            Uri uri = GetGeocodeUri(address);
            String geocodeInfo = client.DownloadString(uri);

            XmlDocument document = new XmlDocument();
            document.LoadXml(geocodeInfo);
            
            List<Point> points = new List<Point>();
            XmlNodeList nodesLugares = document.GetElementsByTagName("Placemark");

            foreach (XmlNode node in nodesLugares)
            {
                Point point = new Point();
                point.Address = node.ChildNodes[0].FirstChild.Value;
                String[] latLong = node.ChildNodes[3].FirstChild.FirstChild.Value.Split(',');
                point.Latitude = Convert.ToDouble(latLong[0], new CultureInfo("en-US"));
                point.Longitude = Convert.ToDouble(latLong[1], new CultureInfo("en-US"));

                points.Add(point);
            }

            return points;
        }

        public static Point getPoint(String address) 
        {
            return geoCodeInfo(address)[0];
        }

        public static bool isUniqueAddress(string address)
        {
            return getSimilars(address).Count == 1;
        }

        public static BindingList<string> getSimilars(string address)
        {
            BindingList<String> listAddress = new BindingList<string>();
            geoCodeInfo(address).ForEach((Point point) => listAddress.Add(point.Address));
            return listAddress;
        }

    }
}

