using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Pujcovna
{
    public partial class Uprava : Form
    {
        List<Pujcen> x = new List<Pujcen>();
        public Uprava()
        {
            InitializeComponent();
        }
        public string Nazev
        {
            get
            {
                return tb_nazev.Text;
            }
            set
            {
                tb_nazev.Text = value;
            }
        }
        public string Rezie
        {
            get
            {
                return tb_rezie.Text;
            }
            set
            {
                tb_rezie.Text = value;
            }
        }
        public string Zanr
        {
            get
            {
                return tb_zanr.Text;
            }
            set
            {
                tb_zanr.Text = value;
            }
        }
        public int Rok
        {
            get
            {
                return (int)nud_rok.Value;
            }
            set
            {
                nud_rok.Value = value;
            }
        }
        public int Pocet
        {
            get
            {
                return (int)nud_pocet.Value;
            }
            set
            {
                nud_pocet.Value = value;
            }
        }
        public decimal Cena
        {
            get
            {
                return nud_cena.Value;
            }
            set
            {
                nud_cena.Value = value;
            }
        }
        public int Celkem
        {
            get
            {
                return (int)nud_celkem.Value;
            }
            set
            { 
                nud_celkem.Value = value;
            }

        }
        private void bt_close_Click(object sender, EventArgs e)
        {
            Close();
        }
        public List<Pujcen> X
        {
            set { this.x = value; }
        }
        private void tb_nazev_TextChanged(object sender, EventArgs e)
        {
            if (tb_nazev.Text != "" && tb_rezie.Text != "" && tb_zanr.Text != "" && nud_pocet.Value <= nud_celkem.Value && System.Text.RegularExpressions.Regex.IsMatch(tb_rezie.Text, "^[a-zA-Z]") && System.Text.RegularExpressions.Regex.IsMatch(tb_zanr.Text, "^[a-zA-Z]"))
            {
                bt_ok.Enabled = true;
                bt_n.Visible = false;
            }
            else
            {
                bt_ok.Enabled = false;
                bt_n.Visible = true;
            }
            foreach (Pujcen n in x)
            {
                if (n.Nazev == tb_nazev.Text)
                    bt_ok.Enabled = false; bt_n.Visible = true;
            }
        }

        private void tb_rezie_TextChanged(object sender, EventArgs e)
        {
            if (tb_nazev.Text != "" && tb_rezie.Text != "" && tb_zanr.Text != "" && nud_pocet.Value <= nud_celkem.Value && System.Text.RegularExpressions.Regex.IsMatch(tb_rezie.Text, "^[a-zA-Z]") && System.Text.RegularExpressions.Regex.IsMatch(tb_zanr.Text, "^[a-zA-Z]"))
             {
                bt_ok.Enabled = true;
                bt_n.Visible = false;
            }
            else
            {
                bt_ok.Enabled = false;
                bt_n.Visible = true;
            }
            foreach (Pujcen n in x)
            {
                if (n.Nazev == tb_nazev.Text)
                    bt_ok.Enabled = false; bt_n.Visible = true;
            }

        }

        private void tb_zanr_TextChanged(object sender, EventArgs e)
        {
            if (tb_nazev.Text != "" && tb_rezie.Text != "" && tb_zanr.Text != "" && nud_pocet.Value <= nud_celkem.Value && System.Text.RegularExpressions.Regex.IsMatch(tb_rezie.Text, "^[a-zA-Z]") && System.Text.RegularExpressions.Regex.IsMatch(tb_zanr.Text, "^[a-zA-Z]"))
            {
                bt_ok.Enabled = true;
                bt_n.Visible = false;
            }
            else
            {
                bt_ok.Enabled = false;
                bt_n.Visible = true;
            }
            foreach (Pujcen n in x)
            {
                if (n.Nazev == tb_nazev.Text)
                    bt_ok.Enabled = false; bt_n.Visible = true;
            }
        }

        private void nud_pocet_ValueChanged(object sender, EventArgs e)
        {
            if (nud_pocet.Value > nud_celkem.Value)
                nud_celkem.Value = nud_pocet.Value;
            if (tb_nazev.Text != "" && tb_rezie.Text != "" && tb_zanr.Text != "" && nud_pocet.Value <= nud_celkem.Value && System.Text.RegularExpressions.Regex.IsMatch(tb_rezie.Text, "^[a-zA-Z]") && System.Text.RegularExpressions.Regex.IsMatch(tb_zanr.Text, "^[a-zA-Z]"))
            {
                bt_ok.Enabled = true;
                bt_n.Visible = false;
            }
            else
            {
                bt_ok.Enabled = false;
                bt_n.Visible = true;
            }
            foreach (Pujcen n in x)
            {
                if (n.Nazev == tb_nazev.Text)
                    bt_ok.Enabled = false; bt_n.Visible = true;
            }
        }

        private void bt_n_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Properties.Resources.Chyba_MESSAGE, Properties.Resources.Chyba_TITTLE,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

