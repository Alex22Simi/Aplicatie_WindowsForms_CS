using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProiectPAW_Faza1
{
    public partial class FormVizualizare : Form
    {
        DataBase db;
        List<Magazin> lista;
        Bitmap memoryImage;

        private void refresh()
        {
            DisplayChart();
            listView1.Items.Clear();
            creareLista();
        }
         private void DisplayChart()
        {
            chart1.Series.Clear();
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisY.Interval = 1;

            Series series = new Series("Număr angajați");

            foreach (Magazin m in lista)
            {
                series.Points.AddXY(m.Nume, m.NrAngajati);
            }

            chart1.Series.Add(series);
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
        }
        public void creareLista()
        {
            foreach(Magazin it in lista)
            {
                string distribuitori = "";
                foreach (string str in it.Distribuitori)
                {
                    distribuitori += str;
                }
                ListViewItem ldi = new ListViewItem(new string[] {it.Nume,it.NrAngajati.ToString(),distribuitori,it.NrRaioane.ToString()});
                ldi.Tag = it;
                listView1.Items.Add(ldi);
            }
        }
        public FormVizualizare(List<Magazin> lista, DataBase db)
        {
            InitializeComponent();
            this.lista = lista;
            creareLista();
            DisplayChart();
            this.db = db;
        }
        private void print_Document(object sender, EventArgs e)
        {
            button1.Visible= false;
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height);
            this.DrawToBitmap(memoryImage, new Rectangle(this.ClientRectangle.X+100, this.ClientRectangle.Y+100, this.ClientRectangle.Width, this.ClientRectangle.Height));
            printDocument2.Print();
            button1.Visible= true;

        }
              

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            print_Document(sender,e);
        }

        private void printDocument2_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void listView1_MouseDown(object sender, MouseEventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                listView1.DoDragDrop((Magazin)listView1.SelectedItems[0].Tag,DragDropEffects.Copy);
            }
        }

        private void button1_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(typeof(Magazin)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else 
                e.Effect = DragDropEffects.None;
        }

        private void button1_DragDrop(object sender, DragEventArgs e)
        {
            if(e.Effect == DragDropEffects.Copy)
            {
                Magazin m = e.Data.GetData(typeof(Magazin)) as Magazin;
                FormEditare form3 = new FormEditare(m,db);
                form3.ShowDialog();
                refresh();
            }
        }
    }
}
