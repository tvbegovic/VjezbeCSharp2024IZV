using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klase
{
    public partial class Glavna : Form
    {
        List<Igra> igre = new List<Igra>();
        public Glavna()
        {
            InitializeComponent();
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            try
            {
                Igra igra1 = new Igra();
                igra1.Naziv = txtNaziv.Text;
                igra1.Opis = txtOpis.Text;
                igra1.Vrsta = txtVrsta.Text;
                igra1.Izdavac = txtIzdavac.Text;
                bool ok = double.TryParse(txtCijena.Text, out double cijena);
                if (!ok)
                {
                    MessageBox.Show("Pogrešna cijena");
                    return;
                }
                igra1.Cijena = cijena;
                ok = DateTime.TryParse(txtDatum.Text, out DateTime datum);
                if (!ok)
                {
                    MessageBox.Show("Pogrešan datum");
                    return;
                }
                igra1.DatumIzdavanja = datum;
                igre.Add(igra1);
                AzurirajGrid();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void AzurirajGrid()
        {
            dgvIgre.DataSource = null;
            dgvIgre.DataSource = igre;
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            var datoteka = new StreamWriter("igre.txt");
            foreach (var igra in igre)
            {
                datoteka.WriteLine($"{igra.Naziv};{igra.Opis};{igra.Vrsta};{igra.DatumIzdavanja};{igra.Cijena};{igra.Izdavac}");
            }
            datoteka.Close();
        }

        private void btnUcitaj_Click(object sender, EventArgs e)
        {
            string[] redci = File.ReadAllLines("igre.txt");
            foreach (string r in redci)
            {
                string[] stupci = r.Split(';');
                Igra igra1 = new Igra();
                igra1.Naziv = stupci[0];
                igra1.Opis = stupci[1];
                igra1.Vrsta = stupci[2];
                bool ok = DateTime.TryParse(stupci[3], out DateTime datum);
                if(ok)
                    igra1.DatumIzdavanja = datum;
                ok = double.TryParse(stupci[4], out double cijena);
                if (ok)
                    igra1.Cijena = cijena;
                igra1.Izdavac = stupci[5];
                igre.Add(igra1);
            }
            AzurirajGrid();
        }
    }
}
