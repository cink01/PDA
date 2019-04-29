using Pujcovna;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Pujcovna
{
    public partial class FormMain : Form
    {
        List<Pujcen> data = new List<Pujcen>();
        List<Pujcen> c = new List<Pujcen>();
        StringComparison comp = StringComparison.OrdinalIgnoreCase;
        public FormMain()
        {
            InitializeComponent();
            saveFileDialog.Filter = openFileDialog.Filter = "Textové soubory (*.xml)|*.xml";
            lsb_rez.GotFocus += (object anonSender, EventArgs anonE) => { lsb_rez.Parent.Focus(); };
            lsb_zan.GotFocus += (object anonSender, EventArgs anonE) => { lsb_zan.Parent.Focus(); };
        }

        private void refresh()
        {
            mazani();
            foreach (Pujcen n in data)
            {
                lsb_film.Items.Add(n.Nazev);
                if (lsb_rez.Items.Contains(n.Rezie) != true)
                    lsb_rez.Items.Add(n.Rezie);
                if (lsb_zan.Items.Contains(n.Zanr) != true)
                    lsb_zan.Items.Add(n.Zanr);
            }
        }

        private void mazani()
        {
            lsb_film.DataSource = null;
            lsb_film.Items.Clear();
            lsb_rez.DataSource = null;
            lsb_rez.Items.Clear();
            lsb_zan.DataSource = null;
            lsb_zan.Items.Clear();
            tb_f.Text = "";
            tb_zf.Text = "";
            tb_jmenoFind.Text = "";
        }
        private void novýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mazani();
            data.Clear();
        }

        private void backupFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mazani();
            data.Clear();
            data.Add(new Pujcen("Prometheus", "Scott Ridley", "Dobrodružný|Sci-Fi ", 2012, 0, 99, 10));
            data.Add(new Pujcen("Aliens", "Cameron James", "Akční|Horor|Sci-Fi", 1986, 6, 99, 10));
            data.Add(new Pujcen("Alien", "Scott Ridley", "Horor|Sci-Fi", 1979, 5, 99, 10));
            data.Add(new Pujcen("Alien 3", "Fincher David", "Akční|Horor|Sci-Fi", 1992, 13, 49, 15));
            refresh();
        }

        private void zvolitToolStripMenuItem_Click(object sender, EventArgs e) //otevreni xml
        {
            openFileDialog.Title = "Zdrojový soubor";                       // titulek dialogu
            openFileDialog.Filter = "Textové soubory (*.xml)|*.xml";
            openFileDialog.InitialDirectory = Application.StartupPath;      // nastaveni adresarove cesty adresare, ktery bude v dialogu zobrazen
            DialogResult rslt = openFileDialog.ShowDialog(this);
            // zobrazi dialog modalne - dialog prebira zamereni, dokud neni uzavren
            if (rslt == DialogResult.OK)
            {
                if (File.Exists(openFileDialog.FileName))
                {
                    try
                    {
                        mazani(); data.Clear();
                        var maps = from c in XElement.Load(openFileDialog.FileName).Elements("Pujcen") select c;
                        foreach (var item in maps)
                        {
                            data.Add(new Pujcen()
                            {
                                Nazev = item.Element("Nazev").Value,
                                Rezie = item.Element("Rezie").Value,
                                Zanr = item.Element("Zanr").Value,
                                Rok = Convert.ToInt32(item.Element("Rok").Value),
                                Pocet = Convert.ToInt32(item.Element("Pocet").Value),
                                Cena = Convert.ToDecimal(item.Element("Cena").Value),
                                Celkem = Convert.ToInt32(item.Element("Celkem").Value)
                            });
                        }
                        refresh();
                    }
                    catch (Exception) { MessageBox.Show("Soubor XML nemá požadovaný tvar!",Properties.Resources.Chyba_TITTLE,MessageBoxButtons.OK,MessageBoxIcon.Error); }
                }
            }
            refresh();
        }

        private void uložitToolStripMenuItem_Click(object sender, EventArgs e) //ulozeni do xml zaznamy
        {
            saveFileDialog.Title = "Uložit jako ... ";
            saveFileDialog.AddExtension = true;
            saveFileDialog.Filter = "Textové soubory (*.xml)|*.xml";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var ser = new XmlSerializer(typeof(List<Pujcen>));
                    TextWriter writer = new StreamWriter(saveFileDialog.FileName);
                    ser.Serialize(writer, data);
                }
                catch (Exception) { MessageBox.Show("Soubor XML nemá požadovaný tvar!", Properties.Resources.Chyba_TITTLE, MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else
                Close();
        }

        private void přidatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Uprava pridat = new Uprava();
            pridat.Text = "Přidat film";
            pridat.X = data;
            DialogResult potvrzeni = pridat.ShowDialog();
            if (potvrzeni == DialogResult.OK)
            {
                data.Add(new Pujcen(
                pridat.Nazev,
                pridat.Rezie,
                pridat.Zanr,
                pridat.Rok,
                pridat.Pocet,
                pridat.Cena,
                pridat.Celkem));
                refresh();
            }
        }

        private void upravitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (lsb_film.SelectedIndex >= 0)
            {
                Uprava uprava = new Uprava();
                uprava.Text = "Upravit film";
                lisboxpresun();
                uprava.X = c;
                foreach (Pujcen n in data)
                {
                    if ((object)lsb_film.SelectedItem == (object)(n.Nazev))
                    {
                        uprava.Nazev = n.Nazev;
                        uprava.Rezie = n.Rezie;
                        uprava.Zanr = n.Zanr;
                        uprava.Rok = n.Rok;
                        uprava.Pocet = n.Pocet;
                        uprava.Cena = n.Cena;
                        uprava.Celkem = n.Celkem;
                    }
                }
                if (uprava.ShowDialog() == DialogResult.OK)
                {
                    data.RemoveAll(Name => Name.Nazev == (string)lsb_film.SelectedItem);
                    data.Add(new Pujcen(
                    uprava.Nazev,
                    uprava.Rezie,
                    uprava.Zanr,
                    uprava.Rok,
                    uprava.Pocet,
                    uprava.Cena,
                    uprava.Celkem));
                    refresh();
                }
            }
        }

        private void odebratToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data.RemoveAll(Name => Name.Nazev == (string)lsb_film.SelectedItem);
            refresh();
        }

        private void konecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Properties.Resources.EXIT_MESSAGE, Properties.Resources.EXIT_TITLE,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void oProgramuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Properties.Resources.HINT_MESSAGE, Properties.Resources.HINT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lsb_film_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Pujcen n in data)
            {
                if ((object)lsb_film.SelectedItem == (object)(n.Nazev))
                {
                    tb_rok.Text = n.Rok.ToString();
                    tb_pocet.Text = n.Pocet.ToString() + "/" + n.Celkem.ToString() + " ks";
                    tb_cena.Text = n.Cena.ToString() + " Kč";
                    lsb_rez.SelectedItem = n.Rezie;
                    lsb_zan.SelectedItem = n.Zanr;
                }
            }
        }

        private void tb_f_TextChanged(object sender, EventArgs e)
        {
            cb_f.Items.Clear(); chb_exist.Checked = false;
            cb_f.Text = "Nalezené filmy";
            foreach (Pujcen n in data)
            {
                if (n.Nazev.IndexOf(tb_f.Text, comp)>=0)
                {
                    cb_f.Items.Add(n.Nazev);
                    chb_exist.Checked = true;
                }
            }
        }

        private void cb_f_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Pujcen n in data)
            {
                if ((object)cb_f.SelectedItem == (object)(n.Nazev))
                    lsb_film.SelectedItem = n.Nazev;
            }
        }

        private void tb_jmenoFind_TextChanged(object sender, EventArgs e)
        {
            chb_je.Checked = false;
            cb_find.Items.Clear();
            cb_find.Text = "Nalezené filmy";
            foreach (Pujcen n in data)
            {
                if (n.Rezie.IndexOf(tb_jmenoFind.Text, comp) >= 0)
                {
                    cb_find.Items.Add(n.Rezie+ " ·" + n.Nazev);
                    chb_je.Checked = true;
                }
            }
        }

        private void cb_find_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string[] x = (cb_find.SelectedItem.ToString()).Split('·');
                foreach (Pujcen n in data)
                {
                    if (x[1] == n.Nazev)
                        lsb_film.SelectedItem = n.Nazev;
                }
            }
            catch { }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            chb_je1.Checked = false;
            cb_ff.Items.Clear();
            cb_ff.Text = "Nalezené filmy";
            foreach (Pujcen n in data)
            {
                if (n.Zanr.IndexOf(tb_zf.Text, comp) >= 0)
                {
                    cb_ff.Items.Add(n.Zanr + " ·" + n.Nazev);
                    chb_je1.Checked = true;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string[] x = (cb_ff.SelectedItem.ToString()).Split('·');
                foreach (Pujcen n in data)
                {
                    if (x[1] == n.Nazev)
                        lsb_film.SelectedItem = n.Nazev;
                }
            }
            catch { }
        }
        private void bt_pujcit_Click(object sender, EventArgs e)
        {
            Pujcka p = new Pujcka();
            p.Text = "Půjčení";
            p.zamceni();
            p.A = data;
            p.RefreshA();
            DateTime doba = DateTime.Now.AddDays(30);
            p.Datum = doba;
            if (DialogResult.OK == p.ShowDialog())
            {
                var res = p.A.Union(p.B).ToList();
                if (!p.B.Any())
                    MessageBox.Show("Nic jste si nevypujcili.", Properties.Resources.INFO_TITTLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show(String.Concat("Vaše vybrané filmy vraťte do: ",
                    doba.ToString("dd.MM.yyyy"), "\nCelková cena půjčky: ", p.Pujcovne),
                    Properties.Resources.INFO_TITTLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                mazani();
                data.Clear();
                data = res;
                refresh();

            }
        }

        private void bt_vratit_Click(object sender, EventArgs e)
        {
            //open dialog pujcka
            Pujcka v = new Pujcka();
            v.Text = "Vrácení";
            v.odemc();
            v.B = data;
            v.RefreshB();
            if (DialogResult.OK == v.ShowDialog())
            {
                var res = v.A.Union(v.B).ToList();
                if(!v.A.Any())
                    MessageBox.Show("Nic jste nevrátili.",Properties.Resources.INFO_TITTLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show(string.Concat("Uspěšně jste vratili filmy. ", "\nVýše penále: ", v.Penale),
                    Properties.Resources.INFO_TITTLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                mazani();
                data.Clear();
                data = res;
                refresh();
             }
        }

        private void RefrREz()
        {
            lsb_rez.DataSource = null;
            lsb_rez.Items.Clear();
            foreach (Pujcen n in data)
                if (lsb_rez.Items.Contains(n.Rezie) != true)
                    lsb_rez.Items.Add(n.Rezie);
        }
        private void RefFilm()
        {
            lsb_film.DataSource = null;
            lsb_film.Items.Clear();
            foreach (Pujcen n in data)
                lsb_film.Items.Add(n.Nazev);
        }
        private void RefZanr()
        {
            lsb_zan.DataSource = null;
            lsb_zan.Items.Clear();
            foreach (Pujcen n in data)
                if (lsb_zan.Items.Contains(n.Zanr) != true)
                    lsb_zan.Items.Add(n.Zanr);
        }

        private void lisboxpresun()
        {
            c.Clear();
            foreach (Pujcen n in data)
                if (n.Nazev != (string)lsb_film.SelectedItem)
                    c.Add(new Pujcen(n.Nazev, n.Rezie, n.Zanr, n.Rok, n.Pocet, n.Cena, n.Celkem));
        }
        private void názevToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            data.Sort(delegate (Pujcen a, Pujcen b) { return a.Nazev.CompareTo(b.Nazev); });
            RefFilm();
        }

        private void režieToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            data.Sort(delegate (Pujcen a, Pujcen b) { return a.Rezie.CompareTo(b.Rezie); });
            RefrREz();
        }

        private void žánrToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            data.Sort(delegate (Pujcen a, Pujcen b) { return a.Zanr.CompareTo(b.Zanr); });
            RefZanr();
        }

        private void názevToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            data.Sort(delegate (Pujcen a, Pujcen b) { return b.Nazev.CompareTo(a.Nazev); });
            RefFilm();
        }

        private void režieToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            data.Sort(delegate (Pujcen a, Pujcen b) { return b.Rezie.CompareTo(a.Rezie); });
            RefrREz();
        }

        private void žánrToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            data.Sort(delegate (Pujcen a, Pujcen b) { return b.Zanr.CompareTo(a.Zanr); });
            RefZanr();
        }

        private void početToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data.Sort(delegate (Pujcen a, Pujcen b) { return a.Pocet.CompareTo(b.Pocet); });
            refresh();
        }

        private void cenaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            data.Sort(delegate (Pujcen a, Pujcen b) { return a.Cena.CompareTo(b.Cena); });
            refresh();
        }

        private void rokToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            data.Sort(delegate (Pujcen a, Pujcen b) { return b.Rok.CompareTo(a.Rok); });
            refresh();
        }

        private void početToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            data.Sort(delegate (Pujcen a, Pujcen b) { return b.Pocet.CompareTo(a.Pocet); });
            refresh();
        }

        private void cenaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            data.Sort(delegate (Pujcen a, Pujcen b) { return b.Cena.CompareTo(a.Cena); });
            refresh();
        }

        private void rokToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            data.Sort(delegate (Pujcen a, Pujcen b) { return a.Rok.CompareTo(b.Rok); });
            refresh();
        }

        private void zobrazTlačítkaUpravyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bt_1Z.Visible == false)
            {
                bt_1A.Visible = true;
                bt_2A.Visible = true;
                bt_3A.Visible = true;
                bt_1Z.Visible = true;
                bt_2Z.Visible = true;
                bt_3Z.Visible = true;
                zobrazTlačítkaUpravyToolStripMenuItem.Text = "Schovat tlačítka";
            }
            else
            {
                bt_1A.Visible = false;
                bt_2A.Visible = false;
                bt_3A.Visible = false;
                bt_1Z.Visible = false;
                bt_2Z.Visible = false;
                bt_3Z.Visible = false;
                zobrazTlačítkaUpravyToolStripMenuItem.Text = "Zobrazit tlačítka";
            }
        }
    }
}