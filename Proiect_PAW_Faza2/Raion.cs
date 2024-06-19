using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW_Faza1
{
     class Raion: Magazin
    {
        private string numeRaion;
        private int[] nrProdusePerRaion;

        public string NumeRaion { get => numeRaion; set => numeRaion = value; }
        public int[] NrProdusePerRaion { get => nrProdusePerRaion; set => nrProdusePerRaion = value; }

        public Raion() : base()
        {
            numeRaion = string.Empty;
            nrProdusePerRaion = new int[0];
        }

        public Raion(string n, int nA, int nrR, string nR, int[] nP) : base(n, nA, nrR)
        {
            this.numeRaion = nR;
            this.NrProdusePerRaion = new int[nP.Length];
            for (int i = 0; i < nP.Length; i++) 
            {
                this.NrProdusePerRaion[i] = nP[i];
            }
           
        }
    
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Numele raionului: ");
            sb.AppendLine(numeRaion);
            sb.Append("Numarul de produse de pe raion: ");
            sb.Append(string.Join("; ", nrProdusePerRaion));
            return sb.ToString();
        }

    }
}
