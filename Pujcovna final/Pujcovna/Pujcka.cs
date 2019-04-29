using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pujcovna
{
    public partial class Pujcka : Form
    {
        List<Pujcen> a = new List<Pujcen>();
        List<Pujcen> b = new List<Pujcen>();
        promena p = new promena();
        public Pujcka()
        {
            InitializeComponent();
            dtp_date.Enabled = true;
            tb_penale.Text = "žádné";
        }
        public DateTime Datum
        {
            set
            {
                dtp_date.Value = value;
            }
        }
        public List<Pujcen> A
        {
            set
            {
                this.a = value;
            }
            get
            {
                return a;
            }

        }
        public List<Pujcen> B
        {
            set
            {
                this.b = value;
            }
            get
            {
                return b;
            }
        }
        public string Pujcovne
        {
            get
            {
                return tb_cena.Text;
            }
        }
        public string Penale
        {
            get
            {
                return tb_penale.Text;
            }
        }
        public void zamceni()
        {
            dtp_date.Enabled= false;
            tb_penale.Visible = false;
            lb_cena.Text = "Celková cena za půjčení:";
        }
        public void odemc()
        {
            tb_cena.Visible = false;
            lb_cena.Text = "Penále za pozdní vrácení:";
        }
        private void bt_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lsb_filmy_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (Pujcen n in a)
                {
                    if ((object)lsb_filmy.SelectedItem == (object)(n.Nazev))
                    {
                        n.MinusPocet();
                        Pujcen x = new Pujcen(n.Nazev, n.Rezie, n.Zanr, n.Rok, n.Pocet, n.Cena, n.Celkem);
                        p.celkove(1);
                        p.soucetPrice(x.Cena);
                        b.Add(x);
                        a.RemoveAll(Name => Name.Nazev == x.Nazev);
                        kontrolapenale();
                    }
                }
            }catch { }
            RefreshA(); RefreshB(); kontrolapenale();
        }
        private void lsb_pujceny_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { 
            foreach (Pujcen n in b)
            {
                    if ((object)lsb_pujceny.SelectedItem == (object)(n.Nazev))
                    {
                        n.PlusPocet();
                        Pujcen y = new Pujcen(n.Nazev, n.Rezie, n.Zanr, n.Rok, n.Pocet, n.Cena, n.Celkem);
                        a.Add(y);
                        b.RemoveAll(Name => Name.Nazev == y.Nazev);
                        p.odcetPrice(y.Cena);
                        p.celkove(2);
                        kontrolapenale();
                    }
            }
            }catch { }
            RefreshA(); RefreshB(); kontrolapenale();
        }
        public void RefreshA()
        {
            lsb_filmy.DataSource = null;
            lsb_filmy.Items.Clear();
            foreach (Pujcen n in a)
            {
                if(n.Pocet!=0)
                    lsb_filmy.Items.Add(n.Nazev);
            }
        }
        public void RefreshB()
        {
            lsb_pujceny.DataSource = null;
            lsb_pujceny.Items.Clear();
            foreach (Pujcen n in b)
            {
                if(n.Pocet!=n.Celkem)
                    lsb_pujceny.Items.Add(n.Nazev);
            }
        }
        public void kontrolapenale()
        {

            DateTime now = DateTime.Today;
            DateTime curr = Convert.ToDateTime(dtp_date.Value);
            if (DateTime.Compare(curr, now) >= 0)
                tb_penale.Text = "žádné";
            else
                tb_penale.Text = p.penale();
            tb_cena.Text = p.vysledna();
        }
        private void dtp_date_ValueChanged(object sender, EventArgs e)
        {
            kontrolapenale();
        }
    }
}
