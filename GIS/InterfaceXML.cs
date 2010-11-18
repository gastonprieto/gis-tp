using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Diagnostics;

namespace GIS
{
    class InterfaceXML
    {
        #region Export XML
        public static void exportTo(String filename, IList<Alumno> alumnos)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.NewLineOnAttributes = true;

            XmlWriter textWriter = XmlWriter.Create(filename, settings);
            textWriter.WriteStartDocument();
            textWriter.WriteStartElement("Alumnos");
            alumnos.ToList().ForEach((Alumno alumno) => writeElement(alumno, textWriter));
            textWriter.WriteEndElement();
            textWriter.WriteEndDocument();
            textWriter.Close();
        }

        private static void writeElement(Alumno alumno, XmlWriter textWriter)
        {
            textWriter.WriteStartElement("Alumno");
            
            textWriter.WriteStartElement("Nombre");
            textWriter.WriteString(alumno.Nombre);
            textWriter.WriteEndElement();
            
            textWriter.WriteStartElement("Apellido");
            textWriter.WriteString(alumno.Apellido);
            textWriter.WriteEndElement();

            textWriter.WriteStartElement("Ubicacion");
            textWriter.WriteStartAttribute("Nombre");
            textWriter.WriteString(alumno.Direccion.Name);
            textWriter.WriteEndAttribute();
            textWriter.WriteStartAttribute("Direccion");
            textWriter.WriteString(alumno.Direccion.Address);
            textWriter.WriteEndAttribute();
            textWriter.WriteStartAttribute("Latitud");
            textWriter.WriteString(alumno.Direccion.Latitude.ToString());
            textWriter.WriteEndAttribute();
            textWriter.WriteStartAttribute("Longitud");
            textWriter.WriteString(alumno.Direccion.Longitude.ToString());
            textWriter.WriteEndAttribute();
            textWriter.WriteEndElement();

            textWriter.WriteEndElement();
        }
        #endregion

        #region Import XML
        public static IList<Alumno> importFrom(String filename)
        {
            List<Alumno> alumnos = new List<Alumno>();
            
            XmlReader reader = XmlReader.Create(filename);
            XmlDocument document = new XmlDocument();
            document.Load(reader);

            XmlNodeList nodesAlumnos = document.GetElementsByTagName("Alumno");
            foreach (XmlNode node in nodesAlumnos) 
            {
                Alumno alumno = new Alumno();
                XmlNode nodeNombre = node.SelectSingleNode("Nombre");
                XmlNode nodeApellido = node.SelectSingleNode("Apellido");
                XmlElement nodeUbicacion = (XmlElement) node.SelectSingleNode("Ubicacion");

                if (nodeNombre == null && nodeApellido == null && nodeUbicacion == null) 
                {
                    throw new Exception("Registro Inválido " + node.InnerText);
                }
                
                alumno.Nombre = nodeNombre.FirstChild.Value;
                alumno.Apellido = nodeApellido.FirstChild.Value;
                alumno.Direccion = new Coordenada();

                alumno.Direccion.Name = nodeUbicacion.GetAttribute("Nombre");
                alumno.Direccion.Address = nodeUbicacion.GetAttribute("Direccion");

                String latitudXML = nodeUbicacion.GetAttribute("Latitud");
                String longitudXML = nodeUbicacion.GetAttribute("Longitud");

                if (String.IsNullOrEmpty(alumno.Direccion.Address) && (String.IsNullOrEmpty(latitudXML) || String.IsNullOrEmpty(longitudXML))) {
                    throw new Exception("Registro Inválido, no se puede obtener la dirección del alumno " + (alumnos.Count + 1));
                }

                if (!String.IsNullOrEmpty(latitudXML)){
                    alumno.Direccion.Latitude = Double.Parse(latitudXML);
                }
                
                if (!String.IsNullOrEmpty(longitudXML)) {
                    alumno.Direccion.Longitude = Double.Parse(longitudXML);
                }
                
                alumnos.Add(alumno);
            }

            reader.Close();
            return alumnos;
        }
        #endregion
    }
}
