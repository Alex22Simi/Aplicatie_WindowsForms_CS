using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPAW_Faza1
{
    public partial class FormEditare : Form
    {
        public Magazin m;
        public DataBase db;
        public bool error = false;
        public FormEditare(Magazin m,DataBase db)
        {
            InitializeComponent();
            this.db = db;
            this.m = m;
            tbNume2.Text = m.Nume;
            string distribuitori = "";
            foreach(string s in m.Distribuitori)
            {
                distribuitori += s;
            }
            tbD2.Text = distribuitori;
            tbNrA2.Text = m.NrAngajati.ToString();
            tbNrR2.Text = m.NrRaioane.ToString();
        }

        private void Nume_Click(object sender, EventArgs e)
        {

        }

        private void btAdauga2_Click(object sender, EventArgs e)
        {
            if(tbNume2.Text.Equals("") || tbNrA2.Text.Equals("") || tbNrR2.Text.Equals("") || tbD2.Text.Equals(""))
            {
                MessageBox.Show("Campurile nu pot fi necompletate", "Eroare", MessageBoxButtons.RetryCancel);
                return;
            }
            if (error)
                return;
            string dist = "";
            foreach(string st in m.Distribuitori)
            {
                dist += st+",";
            }
            dist = dist.Remove(dist.Length-1,1);
            Magazin old = new Magazin(m.Nume,m.NrAngajati, m.NrRaioane);
            m.Nume = tbNume2.Text;
            m.NrRaioane = Convert.ToInt32(tbNrR2.Text);
            m.NrAngajati = Convert.ToInt32(tbNrA2.Text);

 


            string[] distribuitori = tbD2.Text.Split(',');
            m.Distribuitori = new List<string>();
            foreach(string it in  distribuitori)
            {
                m.Distribuitori.Add(it);
            }

            string dist2 = "";
            foreach (string st in m.Distribuitori)
            {
                dist2 += st + ",";
            }
            dist2 = dist2.Remove(dist2.Length - 1, 1);
            string command = "update c_magazine set nume='" + tbNume2.Text + "',nr_ang=" + m.NrAngajati.ToString() +
",nr_raioane=" + m.NrRaioane.ToString() + ",nume_distr='" + dist2 + "' ";
            command += " where nume='" + old.Nume + "' and nr_ang =" + old.NrAngajati.ToString() + " and nr_raioane=" + old.NrRaioane.ToString()
                + " and nume_distr='" + dist + "'";
            try
            {
  

                OracleCommand command1 = new OracleCommand(command);
                command1.Connection = db.conection;
                int a = command1.ExecuteNonQuery();
                if (a == 0) throw new Exception("Nu a fost shimbata inregistrarea");
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Magazinul a fost editat cu succes!", "Confirmare.", MessageBoxButtons.OK);
            this.DialogResult = DialogResult.OK;
        }

        private void tbNrA_KeyDown(object sender, KeyEventArgs e)
        {
     
            if (e.KeyCode == Keys.Space || (!char.IsDigit((char)e.KeyCode) && e.KeyCode != Keys.Back))
            {
                error = true;
                tbNrA2.BackColor = Color.Red;
                MessageBox.Show("INTRODU UN NUMAR!");
            }
            else
            {
                error = false;
                tbNrA2.BackColor = SystemColors.Window;
            }
        }

        private void tbNrA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void tbNrR_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space || (!char.IsDigit((char)e.KeyCode) && e.KeyCode != Keys.Back))
            {
                tbNrR2.BackColor = Color.Red;
                MessageBox.Show("INTRODU UN NUMAR!");
                error = true;
            }
            else
            {
                error = false;
                tbNrR2.BackColor = SystemColors.Window;
            }
        }

        private void tbNrR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        bool containsLetters(string text)
        {
            string numbers = "0123456789";
            foreach (char c in text)
            {
                if (!numbers.Contains(c))
                    return true;

            }
            return false;

        }

        bool isFirstLetter = true;
        private void tbNume_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isFirstLetter && char.IsLetter(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
                isFirstLetter = false;
            }
            else if (char.IsLetter(e.KeyChar))
            {
                e.KeyChar = char.ToLower(e.KeyChar);
            }

            if (e.KeyChar == ' ')
            {
                isFirstLetter = true;
            }
            tbNume2.BackColor = SystemColors.Window;

            if ((!char.IsLetter(e.KeyChar) && !containsLetters(tbNume2.Text)) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != 8)
            {
                e.Handled = true;
                tbNume2.BackColor = Color.Red;
                MessageBox.Show("INTRODU UN NUME!");
                error = true;
            }
            else
            {
                error = false;
            }

        }

        bool isFirstLetter2 = true;
        private void tbD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isFirstLetter2 && char.IsLetter(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
                isFirstLetter2 = false;
            }
            else if (char.IsLetter(e.KeyChar))
            {
                e.KeyChar = char.ToLower(e.KeyChar);
            }

            if (e.KeyChar == ' ')
            {
                isFirstLetter2 = true;
            }
            if ((!char.IsLetter(e.KeyChar) && !containsLetters(tbNume2.Text)) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != 8 && e.KeyChar != 44)//8 - backspace, 44 - ;
            {
                e.Handled = true;
                tbD2.BackColor = Color.Red;
                MessageBox.Show("INTRODU UN NUME!");
                error = true;
            }
            else
            {
                error = false;
                tbD2.BackColor = SystemColors.Window;
            }
        }


    }
}
