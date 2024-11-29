using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klase
{
    internal class Igra
    {
        private string naziv, opis, vrsta, izdavac;
        private double cijena;
        private DateTime datumIzdavanja;

        public void UpisiNaziv(string naziv)
        {
            if (string.IsNullOrEmpty(naziv))
                throw new ArgumentException("Naziv ne smije biti prazan");
            this.naziv = naziv;
        }
        public string CitajNaziv()
        {
            return this.naziv;
        }
        //Umjesto običnih funkcija Upisi, Citaj radimo tzv. public property Naziv sa 
        //get,set dijelom
        public string Naziv
        {
            get
            {
                return this.naziv;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Naziv ne smije biti prazan");
                this.naziv = value;
            }
        }
        //opis
        public string Opis
        {
            get
            {
                return this.opis;
            }
            set
            {
                this.opis = value;
            }
        }
        //vrsta
        public string Vrsta
        {
            get
            {
                return this.vrsta;
            }
            set 
            { 
                this.vrsta = value;
            }
        }
        //cijena
        public double Cijena
        {
            get
            {
                return this.cijena;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Cijena ne smije biti negativna");
                this.cijena = value;
            }
        }
        //datum izdavanja
        public DateTime DatumIzdavanja
        {
            get
            {
                return this.datumIzdavanja;
            }
            set
            {
                if (value > DateTime.Now)
                    throw new ArgumentException("Datum ne smije biti u budućnosti");
                this.datumIzdavanja = value;
            }
        }
        //izdavač
        public string Izdavac
        {
            get
            {
                return this.izdavac;
            }
            set
            {
                this.izdavac = value;
            }
        }
    }
}
