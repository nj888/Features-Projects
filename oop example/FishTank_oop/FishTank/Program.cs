using FishTank.Lib;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IFish> fishes = new List<IFish>();
            fishes.Add(new GoldFish());
            fishes.Add(new GoldFish());
            fishes.Add(new GoldFish());

            fishes.Add(new AngelFish());
            fishes.Add(new AngelFish());
            fishes.Add(new AngelFish());

            fishes.Add(new BabelFish());
            fishes.Add(new BabelFish());
            fishes.Add(new BabelFish());

            Tank.Fishes = fishes;

            Console.WriteLine("Total Food to be feed is " + Tank.Feed());

            Console.WriteLine(Tank.GetXML());

            Console.ReadLine();
        }
    }
}
