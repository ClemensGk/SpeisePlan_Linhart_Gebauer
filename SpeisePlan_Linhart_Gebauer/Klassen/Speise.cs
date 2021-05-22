using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeisePlan_Linhart_Gebauer.Klassen
{
    class Speise
    {
       //Objektvariablen
        private int speiseID;
        private string name;
        private int kosten;
        private char speiseart;
        private string bildpfad;


        //Klassenvariablen
        private static int autonum = 1;

        //Konstruktoren
        public Speise()
        {
            speiseID = autonum;
            autonum++;
        }

        public Speise(int speiseID, string name, int kosten, char speiseart, string bildpfad)
        {
            this.speiseID = autonum;
            autonum++;
            this.name = name;
            this.kosten = kosten;
            this.speiseart = speiseart;
            this.bildpfad = bildpfad;
        }

        public int SpeiseID { get; set; }
        public string Name { get; set; }
        public int Kosten { get; set; }
        public char Speiseart { get; set; }
        public string Bildpfad { get; set; }

        public static int Autonum
        {
            get { return Autonum; }
            set { autonum = value; }
        }


        public override string ToString()
        {
            return speiseID + ";" + name + ";" + kosten + ";" + speiseart + ";" + bildpfad;
        }
    }
}
