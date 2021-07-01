using System;
using System.Threading;
using System.Xml;

namespace xml
{
    class xml
    {

        static XmlElement CreateXmlElement(XmlDocument xmldoc, string Name) => xmldoc.CreateElement(Name);
        static XmlText CreateXmlText(XmlDocument xmldoc, string name) => xmldoc.CreateTextNode("Name " + name);
        static void CreateXMLFile()
        {
            XmlDocument xmldoc = new XmlDocument();
            XmlElement root = xmldoc.CreateElement("Catalog");
            xmldoc.AppendChild(root);

            root.AppendChild(CreateXmlElement(xmldoc, "Name").AppendChild(CreateXmlText(xmldoc, "Nada")));

            root.AppendChild(CreateXmlElement(xmldoc, "Name").AppendChild(CreateXmlText(xmldoc, "Reham")));

            root.AppendChild(CreateXmlElement(xmldoc, "Name").AppendChild(CreateXmlText(xmldoc, "Abdullah")));

            root.AppendChild(CreateXmlElement(xmldoc, "Name").AppendChild(CreateXmlText(xmldoc, "Abdulmajeed")));

            root.AppendChild(CreateXmlElement(xmldoc, "Name").AppendChild(CreateXmlText(xmldoc, "Abdulrahman")));

            xmldoc.Save(@"email.xml");

        }

        static void ReadXMLFile()
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(@"email.xml");
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
            Thread writer = new Thread(CreateXMLFile);
            Thread reader = new Thread(ReadXMLFile);

            writer.Start();
            writer.Join();
            reader.Start();
            reader.Join();
        }

    }
}

