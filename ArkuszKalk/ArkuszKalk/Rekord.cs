using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkuszKalk
{
    public class Rekord
    {
        public int id;
        static int id_licznik = 0;
        public string imie;
        public string nazwisko;
        public int wiek;
        public string stanowisko;
        public Rekord()
        {
            id = id_licznik;
            id_licznik++;
            imie = "";
            nazwisko = "";
            wiek = 0;
            stanowisko = "";
        }
    }
}
