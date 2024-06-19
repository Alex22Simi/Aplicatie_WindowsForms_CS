using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW_Faza1
{
    [Serializable]
    public class Magazin
    {
        private string nume;
        private int nrAngajati;
        private bool gamaVariata;
        private int nrRaioane;
        private List<string> distribuitori;

        public string Nume { get => nume; set => nume = value; }
        public int NrAngajati { get => nrAngajati; set => nrAngajati = value; }
        public bool GamaVariata { get => gamaVariata; set => gamaVariata = value; }
        public int NrRaioane { get => nrRaioane; set => nrRaioane = value; }
        public List<string> Distribuitori { get => distribuitori; set => distribuitori = value; }

        public Magazin()
        {
            Nume = string.Empty;
            nrAngajati = 0;
            gamaVariata = true;
            NrRaioane = 0;
            distribuitori = new List<string>();
        }

        public Magazin(string n, int nA, int nrR)
        {
            this.Nume = n ?? throw new ArgumentNullException(nameof(n));
            this.nrAngajati = nA;
            this.NrRaioane = nrR;
            if (nrR > 10)
            {
                this.gamaVariata = true;
            }
            else
            {
                this.gamaVariata = false;
            }
             distribuitori = new List<string>();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Numele magazinului: ");
            sb.Append(Nume);
            sb.Append(" ");
            sb.Append("Numarul angajatilor: ");
            sb.Append(NrAngajati);
            sb.Append(" Gama este variata? ");
            sb.Append(GamaVariata ? "Da" : "Nu");
            sb.Append(" ");
            sb.Append("Numarul raioanelor este: ");
            sb.Append(NrRaioane);
            sb.AppendLine();
            sb.Append("Distribuitori: ");
            if (Distribuitori != null && Distribuitori.Count > 0)
            {
                sb.Append(Distribuitori[0]);
                for (int i = 1; i < Distribuitori.Count; i++)
                {
                    sb.Append("; ");
                    sb.Append(Distribuitori[i]);
                }
            }

            return sb.ToString();
        }
    }
}

