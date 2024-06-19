using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Oracle.ManagedDataAccess.Client;

namespace ProiectPAW_Faza1
{
    
    public partial class FormularMagazin : Form
    {
        private DataBase db;

        public void afisare_menu()
        {
            if (listaMagazine.Count > 0)
            {
                afisareDateToolStripMenuItem.Visible = true;
                salvareToolStripMenuItem.Visible = true;
                salvareToolStripMenuItem1.Visible = true;
            }
        }
        public void show_all()
        {
            //centrare
            tbD.Top -= 200;
            tbNrA.Top -= 200;
            tbNume.Top -= 200;
            tbNrR.Top -= 200;
            lbD.Top -= 200;
            lbNrA.Top -= 200;
            lbNume.Top -= 200;
            lbNrR.Top -= 200;
            btAdaugaM.Top -= 200;
            btnAfiseazaMagazine.Top -= 200;
            tbMagazine.Top -= 200;

            var t = Task.Delay(250);
            t.Wait();
            //ascundere
            tbParola.Visible = false;
            tbNumeLI.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            btAutentificare.Visible = false;
            var t1 = Task.Delay(250);
            t1.Wait();
            //afisare
            tbD.Visible = true;
            tbNrA.Visible = true;
            tbNume.Visible = true;
            tbNrR.Visible = true;
            lbD.Visible = true;
            lbNrA.Visible = true;
            lbNume.Visible = true;
            lbNrR.Visible = true;
            btAdaugaM.Visible = true;
            btnAfiseazaMagazine.Visible = true;
            tbMagazine.Visible = true;
            fileToolStripMenuItem.Visible = true;
            afisare_menu();



        }
        public void hide_all()
        {
            //ascundere

            afisareDateToolStripMenuItem.Visible = false;
            fileToolStripMenuItem.Visible = false;
            salvareToolStripMenuItem.Visible = false;
            salvareToolStripMenuItem1.Visible = false;
            tbD.Visible = false;
            tbNrA.Visible = false;
            tbNume.Visible = false;
            tbNrR.Visible = false;
            lbD.Visible = false;
            lbNrA.Visible = false;
            lbNume.Visible = false;
            lbNrR.Visible = false;
            btAdaugaM.Visible = false;
            btnAfiseazaMagazine.Visible = false;
            tbMagazine.Visible = false;

            //centrare
            tbParola.Top += 100;
            tbNumeLI.Top += 100;
            label1.Top += 100;
            label2.Top += 100;
            label3.Top += 100;
            btAutentificare.Top += 100;

        }
        List<Magazin> listaMagazine;
        public FormularMagazin()
        {
            InitializeComponent();
            try{
                db = new DataBase("193.226.34.57", "1521", "orclpdb.docker.internal", "SIMIONESCUA_63", "STUD");
                db.Open();
            }
            catch(Exception e) {
                MessageBox.Show(e.Message);
            }

            hide_all();
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.StartPosition = FormStartPosition.CenterScreen;
            listaMagazine = new List<Magazin>();

            try
            {
                string comanda = "SELECT nume,nr_ang,nr_raioane,nume_distr from c_magazine";
                OracleCommand cmd = new OracleCommand(comanda);
                cmd.CommandText = comanda;
                cmd.Connection = db.conection;

                // SELECTURI SI JOIN URI
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Magazin magazin = new Magazin(reader["nume"].ToString(), Convert.ToInt32(reader["nr_ang"].ToString()), Convert.ToInt32(reader["nr_raioane"].ToString()));
                    string[] distribuitori = reader["nume_distr"].ToString().Split(',');
                    foreach(string str  in distribuitori)
                    {
                        magazin.Distribuitori.Add(str);
                    }
                    listaMagazine.Add(magazin);
                }
                

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            label1.Font = new Font("Tahoma", 12, FontStyle.Bold);
            label2.Font = new Font("Tahoma", 8, FontStyle.Bold);
            label3.Font = new Font("Tahoma", 8, FontStyle.Bold);
            lbNume.Font = new Font("Tahoma", 8, FontStyle.Bold);
            lbNrA.Font = new Font("Tahoma", 8, FontStyle.Bold);
            lbNrR.Font = new Font("Tahoma", 8, FontStyle.Bold);
            lbD.Font = new Font("Tahoma", 8, FontStyle.Bold);
            tbNumeLI.Font = new Font("Tahoma", 8, FontStyle.Bold);
            tbParola.Font = new Font("Tahoma", 8, FontStyle.Bold);
            btAutentificare.Font = new Font("Tahoma", 8, FontStyle.Bold);
            tbNume.Font = new Font("Tahoma", 8, FontStyle.Bold);
            tbNrA.Font = new Font("Tahoma", 8, FontStyle.Bold);
            tbNrR.Font = new Font("Tahoma", 8, FontStyle.Bold);
            tbD.Font = new Font("Tahoma", 8, FontStyle.Bold);
            btAdaugaM.Font = new Font("Tahoma", 8, FontStyle.Bold);
            tbMagazine.Font = new Font("Tahoma", 8, FontStyle.Bold);
            btnAfiseazaMagazine.Font = new Font("Tahoma", 8, FontStyle.Bold);
            fileToolStripMenuItem.Font = new Font("Tahoma", 8, FontStyle.Bold);
            //DisplayChart();
        }

        private void FormularMagazin_Load(object sender, EventArgs e)
        {
            Form form = sender as Form;
            MessageBox.Show($"Se incarca: {form.Text}");
        }

        private void btAdaugaM_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbNume.Text.Trim()))
                {
                    throw new Exception("Numele este invalid!");
                }
                string nume = tbNume.Text;
                int nrA = Convert.ToInt32(tbNrA.Text);
                int nrR = Convert.ToInt32(tbNrR.Text);
                string[] numeD = tbD.Text.Split(',');
                string[] numeDs = new string[numeD.Length];
                StringBuilder numeDsBuilder = new StringBuilder();

                foreach (string numeDistribuitor in numeD)
                {
                    string numeTrimmed = numeDistribuitor.Trim();
                    if (!string.IsNullOrEmpty(numeTrimmed))
                    {
                        if (numeDsBuilder.Length > 0)
                        {
                            numeDsBuilder.Append(", ");
                        }
                        numeDsBuilder.Append(numeTrimmed);
                    }
                }

                string numeDss = numeDsBuilder.ToString();
                Magazin m = new Magazin(nume, nrA, nrR);


                List<string> distribuitoriList = string.IsNullOrEmpty(numeDss)
                    ? new List<string>()
                    : numeDss.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).ToList();
                m.Distribuitori = distribuitoriList;

                try
                {
                    string distr = "";
                    foreach(string str  in distribuitoriList)
                    {
                        distr+= str+",";
                    }
                    distr = distr.Remove(distr.Length-1,1);
                    string insert = "insert into c_magazine values('"+m.Nume+"',"+m.NrAngajati.ToString()+","+m.NrRaioane.ToString()+ ",'" + distr + "')";
                    OracleCommand command = new OracleCommand(insert);
                    command.Connection = db.conection;

                    //inser update delete;
                    int a  =  command.ExecuteNonQuery();
                    if(a==0)
                    {
                        throw new Exception("Nu au fost inserate randuri");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                listaMagazine.Add(m);
                MessageBox.Show(m.ToString());
                afisare_menu();

                // Adăugarea codului pentru prezentarea grafică a datelor de bază
                //DisplayChart();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exista o eroare", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
            finally
            {
                tbNume.Clear();
                tbNrA.Clear();
                tbNrR.Clear();
                tbD.Clear();
            }
        }

        private void btnAfiseazaMagazine_Click(object sender, EventArgs e)
        {
            tbMagazine.Clear();
            foreach (Magazin m in listaMagazine)
            {
                tbMagazine.Text += m.ToString() + Environment.NewLine;
            }
        }



        private void tbNrA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space || (!char.IsDigit((char)e.KeyCode) && e.KeyCode != Keys.Back))
            {
                tbNrA.BackColor = Color.Red;
                MessageBox.Show("INTRODU UN NUMAR!");
            }
            else
            {
                tbNrA.BackColor = SystemColors.Window;
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
                tbNrR.BackColor = Color.Red;
                MessageBox.Show("INTRODU UN NUMAR!");
            }
            else
            {
                tbNrR.BackColor = SystemColors.Window;
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
            tbNume.BackColor = SystemColors.Window;

            if ((!char.IsLetter(e.KeyChar) && !containsLetters(tbNume.Text)) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != 8)
            {
                e.Handled = true;
                tbNume.BackColor = Color.Red;
                MessageBox.Show("INTRODU UN NUME!");
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
            if ((!char.IsLetter(e.KeyChar) && !containsLetters(tbNume.Text)) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != 8 && e.KeyChar != 44)//8 - backspace, 44 - ;
            {
                e.Handled = true;
                tbD.BackColor = Color.Red;
                MessageBox.Show("INTRODU UN NUME!");
            }
            else
            {
                tbD.BackColor = SystemColors.Window;
            }
        }

        private void btAutentificare_Click(object sender, EventArgs e)
        {
            string numeUtilizator = tbNumeLI.Text;
            bool found = false;
            string parola = tbParola.Text;
            string select = "SELECT username,pass from c_utilizatori";
            OracleCommand command = new OracleCommand();
            command.CommandText = select;
            command.Connection = db.conection;
            OracleDataReader reader = command.ExecuteReader();
            while(reader.Read() && !found)
            {
                if (reader["username"].ToString()==numeUtilizator && reader["pass"].ToString() ==parola)
                {
                    
                        found = true;
                }
                    
                
            }
            if (found)
            {

                MessageBox.Show("Autentificare reușită!");
                var t = Task.Delay(500);
                t.Wait();
                show_all();
            }
            else
            {

                MessageBox.Show("Nume de utilizator sau parolă incorectă. Vă rugăm să încercați din nou.");
            }
        }

        bool isFirstLetter3 = true;
        private void tbNumeLI_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbParola.UseSystemPasswordChar = true;
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
        }

        //fisier txt
        private void salvareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "(*.txt)|*.txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                foreach (Magazin m in listaMagazine)
                {
                    sw.WriteLine(m.ToString());
                }
                sw.Close();
                tbMagazine.Clear();
                MessageBox.Show($"S-a salvat cu succes fisierul: {saveFileDialog1.FileName}");
            }
        }

        private void restaurareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.txt)|.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                tbMagazine.Text += sr.ReadToEnd();
                sr.Close();
                afisare_menu();
            }
        }


        //fisier binar
        private void salvareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("magazine.dat", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, listaMagazine);
            fs.Close();
            tbMagazine.Clear();
            MessageBox.Show("S-a salvat cu succes fisierul binar!");

        }

        private void restaurareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("magazine.dat", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            List<Magazin> listaMagazineDeserializate = (List<Magazin>)bf.Deserialize(fs);
            foreach (Magazin m in listaMagazineDeserializate)
            {
                tbMagazine.Text += m.ToString() + Environment.NewLine;
            }
            fs.Close();
            afisare_menu();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void afisareDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVizualizare form2 = new FormVizualizare(listaMagazine, db);
            form2.Show();
        }

        ~FormularMagazin()
        {
            db.Close();
        }
    }
}
