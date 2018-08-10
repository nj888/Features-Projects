using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace FishTank.Lib
{
    public class ListOfIFish : List<IFish>, IXmlSerializable
    {
        public ListOfIFish() : base() { }

        #region IXmlSerializable
        public System.Xml.Schema.XmlSchema GetSchema() { return null; }

        public void ReadXml(XmlReader reader)
        {
            reader.ReadStartElement("ListOfIFish");
            while (reader.IsStartElement("IFish"))
            {
                Type type = Type.GetType(reader.GetAttribute("AssemblyQualifiedName"));
                XmlSerializer serial = new XmlSerializer(type);

                reader.ReadStartElement("IFish");
                this.Add((IFish)serial.Deserialize(reader));
                reader.ReadEndElement(); //IAnimal
            }
            reader.ReadEndElement(); //ListOfIAnimal
        }

        public void WriteXml(XmlWriter writer)
        {
            foreach (IFish animal in this)
            {
                writer.WriteStartElement("IFish");
                writer.WriteAttributeString("AssemblyQualifiedName", animal.GetType().AssemblyQualifiedName);
                XmlSerializer xmlSerializer = new XmlSerializer(animal.GetType());
                xmlSerializer.Serialize(writer, animal);
                writer.WriteEndElement();
            }
        }
        #endregion
    }

}
