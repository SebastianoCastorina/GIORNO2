using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIORNO_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Come ti chiami?");
            string Nome = Console.ReadLine();
            Console.WriteLine("Ed il cognome?");
            string Cognome = Console.ReadLine();
            Console.WriteLine("Quanto sei vecchio?");
            double Eta = Convert.ToDouble(Console.ReadLine());
            Persona persona = new Persona(Nome,Cognome,Eta);
            Console.WriteLine(persona.FullName());
            Console.ReadLine();


            Console.WriteLine("Nome prodotto");
            string ProductName = Console.ReadLine();
            Console.WriteLine("Quantità?");
            double Quantità = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Prezzo");
            double Prezzo = Convert.ToDouble(Console.ReadLine());
          
            Prodotto prodotto= new Prodotto(ProductName,Quantità,Prezzo);
            Console.WriteLine(prodotto.FullCost());
            Console.ReadLine();
        }
    }
}



