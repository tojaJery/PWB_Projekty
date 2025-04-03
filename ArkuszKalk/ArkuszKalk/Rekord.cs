using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace ArkuszKalk
{
    [Serializable]
    public class Rekord
    {
        public int id;
        static int id_licznik = 0;
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public int wiek { get; set; }
        public string stanowisko { get; set; }

        public Rekord()
        {
            id = id_licznik;
            id_licznik++;
            imie = "";
            nazwisko = "";
            wiek = 0;
            stanowisko = "";
        }
        public Rekord(string imie, string nazwisko, int wiek, string stanowisko)
        {
            id = id_licznik;
            id_licznik++;
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.wiek = wiek;
            this.stanowisko = stanowisko;
        }
        public void SerializeToXML(string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Rekord));
            using (TextWriter writer = new StreamWriter(fileName))
            {
                serializer.Serialize(writer, this);
            }
            Console.WriteLine("Obiekt został zserializowany do pliku XML.");
        }
        public static Rekord DeserializeFromXML(string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Rekord));
            using (TextReader reader = new StreamReader(fileName))
            {
                Rekord rek1 = (Rekord)serializer.Deserialize(reader);
                Console.WriteLine("Obiekt został odczytany z pliku XML.");
                return rek1;
            }
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {id}, Imię: {imie}, Nazwisko: {nazwisko}, Wiek: {wiek}, Stanowisko: {stanowisko}");
        }
        

    }
}
