using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeisePlan_Linhart_Gebauer
{
   public class Zutat
    {
        //Objektvariablen
   
        private int menge;
        private string einheit;
        private string bezeichnug;
        private string allergene;


        //Konstruktoren

        public Zutat(int menge, string einheit, string bezeichnung, string allergene)
        {
       
            this.menge = menge;
            this.einheit = einheit;
            this.bezeichnug = bezeichnung;
            this.allergene = allergene;
        }

        public int Menge { get; set; }
        public string Einheit { get; set; }
        public string Bezeichnung  { get; set; }
        public string Allergene { get; set; }




    }
}
