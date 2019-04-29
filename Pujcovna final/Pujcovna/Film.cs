using System;
using System.Xml.Serialization;

namespace Pujcovna
{
    public class Film
    {
        string nazev;
        string rezie;
        string zanr;
        int rok;
        [XmlElement("Nazev")]
        public string Nazev { get { return nazev; } set { nazev = value; } }
        [XmlElement("Rezie")]
        public string Rezie { get { return rezie; } set { rezie = value; } }
        [XmlElement("Zanr")]
        public string Zanr { get { return zanr; } set { zanr = value; } }
        [XmlElement("Rok")]
        public int Rok { get { return rok; } set { rok = value; } }
        public Film() { }
        public Film(string n, string r, string z,int y)
        {
            this.nazev = n;
            this.rezie = r;
            this.zanr = z;
            this.rok = y;
        }
    }
    public class Pujcen : Film
    {
        public Pujcen(string n, string r, string z, int y, int p, decimal c,int celk) : base(n, r, z, y)
        {
            this.pocet = p;
            this.cena = c;
            this.celkem = celk;
        }
        public Pujcen() { }
        int pocet;
        decimal cena;
        int celkem;
        [XmlElement("Celkem")]
        public int Celkem { get { return celkem; } set { celkem = value; } }
        [XmlElement("Pocet")]
        public int Pocet { get { return pocet; } set { pocet = value; } }
        public void PlusPocet() { pocet++; }
        public void MinusPocet() { pocet--; }
        [XmlElement("Cena")]
        public decimal Cena { get { return cena; } set { cena = value; } }
    }
    public class promena//trida na pocitani celkove ceny(globalni promenne)
    {
        public promena(){ this.price = 0;this.c = 0; }
        decimal price;
        int c;
        public int C { get; set; }
        public decimal Price { get { return this.price; } }  //pres set nastavit na zacatku 0 a pres get na konci final price
        public void soucetPrice(decimal cena) { this.price += cena; }  //scitani cen
        public void odcetPrice(decimal cena) { this.price -= cena; }
        public void celkove(int x)//cekovy pocet pujcenych filmu na pocitani penale
        {
            if (x == 1) c++;
            if (x == 2) c--;
        } 
        public string penale() { return ((c * -20).ToString()+" Kč"); } //penale 20 kč * počet
        public string vysledna() { return String.Format("{0} Kč", price); }
    }

}

