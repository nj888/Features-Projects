using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Linq;
using System.Xml.Serialization;
using System.Xml;

namespace FishTank.Lib
{
    public static class Tank
    {
        public static List<IFish> Fishes { get; set; }

        public static float Feed()
        {
            return Fishes.Sum(p => p.Weight);
        }


        public static string GetXML()
        {
            var fishList = new ListOfIFish();
            fishList.AddRange(Fishes);
            var xmlSerializer = new XmlSerializer(fishList.GetType());
            var stringBuilder = new StringBuilder();
            var xmlTextWriter = XmlTextWriter.Create(stringBuilder, new XmlWriterSettings { NewLineChars = "\r\n", Indent = true });
            xmlSerializer.Serialize(xmlTextWriter, fishList);
            return stringBuilder.ToString();
        }

    }
}
