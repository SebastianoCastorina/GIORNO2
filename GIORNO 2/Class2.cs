using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIORNO_2
{
    internal class Prodotto
    {
        public string ProductName { get; set; }
        public double Quantita { get; set; }
        public double Prezzo { get; set; }
        
        public Prodotto() { }
        public Prodotto(string NomeProdotto, double HowMany, double QuantoMiCosta) {
            ProductName = NomeProdotto;
            Quantita = HowMany;
            Prezzo = QuantoMiCosta;
        }

        public double FullCost() { return   Quantita * Prezzo ;}

    }
}
