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
                MessageBox.Show("Uspješan unos");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
