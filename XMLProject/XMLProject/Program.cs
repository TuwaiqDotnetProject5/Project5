using System;
using System.Xml;

namespace xml
{
    class xml
    {
        static void CreateXMLFile()
        {
            XmlDocument xmldoc = new XmlDocument();
            XmlElement root = xmldoc.CreateElement("Catalog");
            xmldoc.AppendChild(root);
           

            XmlElement element3 = xmldoc.CreateElement("Book");
            XmlText text3 = xmldoc.CreateTextNode("");
            root.AppendChild(element3);
            element3.AppendChild(text3);

            XmlElement element4 = xmldoc.CreateElement("author");
            XmlText text4 = xmldoc.CreateTextNode("Gammbardelle  ");
            element3.AppendChild(element4);
            element4.AppendChild(text4);

            XmlElement element5 = xmldoc.CreateElement("title");
            XmlText text5 = xmldoc.CreateTextNode("XML developer's Guide ");
            element3.AppendChild(element5);
            element5.AppendChild(text5);

            XmlElement element6 = xmldoc.CreateElement("price");
            XmlText text6 = xmldoc.CreateTextNode("150.7");
            element3.AppendChild(element6);
            element6.AppendChild(text6);

           

            XmlElement element8 = xmldoc.CreateElement("Descriptions");
            XmlText text8 = xmldoc.CreateTextNode("An in-depth look at creating applications with XML.");
            element3.AppendChild(element8);
            element8.AppendChild(text8);
            xmldoc.Save(@"/Users/nadaalotaibi/Downloads/Decomnt/email.xml");
            Console.WriteLine(xmldoc.InnerXml);


        }

        static void ReadXMLFile()
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(@"/Users/nadaalotaibi/Downloads/Decomnt/email.xml");
            foreach (XmlNode node in xmldoc.DocumentElement.ChildNodes)
            {
                string element = node.Name;
                Console.Write(element + ": ");

                string text = node.InnerText;
                Console.WriteLine(text);

            }
        }

        static void Main(string[] args)
        {
           // CreateXMLFile();
            ReadXMLFile();

        }

    }
}

