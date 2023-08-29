using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIORNO_2
{
    public class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public double Eta { get; set; }
        


        public string FullName() { return Nome + " " + Cognome + " " + Eta + " "; }
        public Persona() { }

        public Persona (string nome, string cognome, double eta)
        {
            Nome = nome;
            Cognome = cognome;
            Eta = eta;
       
        }
    }
   

}


