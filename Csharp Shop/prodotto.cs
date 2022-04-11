using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Shop
{
    internal class prodotto
    {

        //ATTRIBUTI
        private int codice;
        private string nome;
        private string descrizione;
        private double prezzo;
        private double iva;


        //COSTRUTTORE
        public prodotto(string nome, string descrizione, double prezzo, double iva)
        {

            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
            this.iva = iva;

            Random codiceRandom = new Random();
            codice = codiceRandom.Next();
        }





        public void stampare()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine(codice + " - " + nome);
            Console.WriteLine("Il nome del prodotto è: " + nome);
            Console.WriteLine("La descrizione del mio prodotto: " + descrizione);
            Console.WriteLine("il prezzo senza iva è: " + prezzo + "€");
            Console.WriteLine("L'iva del prodotto è: " + iva + "%");
            Console.WriteLine("Il prezzo del prodotto con iva è: " + PrezzoConIva() + "€");
            Console.WriteLine("-------------------------------------------------------------");
        }

        public double PrezzoConIva()
        {
            double prezzoFinale;
            if (iva == 22)
            {
                prezzoFinale = prezzo * 1.22;
            }
            else if (iva == 5)
            {
                prezzoFinale = prezzo * 1.05;

            }
            else
            {
                prezzoFinale = prezzo * 1.10;
            }
            prezzoFinale = Math.Round(prezzoFinale, 2);
            return prezzoFinale;
        }


    }
}
    

      
