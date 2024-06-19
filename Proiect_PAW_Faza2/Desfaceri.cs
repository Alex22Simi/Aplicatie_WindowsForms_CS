using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW_Faza1
{
    public class Desfaceri: Magazin
    {
        private string[] numeDistribuitor;
        private int oraSosireProduse;
        private int nrProdusePrimite;

        
        public int OraSosireProduse { get => oraSosireProduse; set => oraSosireProduse = value; }
        public int NrProdusePrimite { get => nrProdusePrimite; set => nrProdusePrimite = value; }
        public string[] NumeDistribuitor { get => numeDistribuitor; set => numeDistribuitor = value; }

        public Desfaceri() : base()
        {
            numeDistribuitor = new string[0];
            oraSosireProduse = 0;
            nrProdusePrimite = 0;
        }

        public Desfaceri(string n, int nA, bool g, int nrR, string[] nD, int oS, int nPP) : base(n, nA, nrR)
        {
            this.numeDistribuitor = new string[nD.Length];
            for (int i = 0; i < nD.Length; i++)
            {
                this.numeDistribuitor[i] = nD[i].ToString();
            }
            this.oraSosireProduse = oS;
            this.nrProdusePrimite = nPP;
        }

     
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Numele distribuitorilor: ");
            foreach (string nume in numeDistribuitor)
            {
                sb.Append(nume + "; ");
            }
            sb.AppendLine();
            sb.Append("Ora sosire produse: ");
            sb.Append(oraSosireProduse);
            sb.Append(" Numar produse primite: ");
            sb.Append(nrProdusePrimite);
            return sb.ToString();
        }

    }
}
