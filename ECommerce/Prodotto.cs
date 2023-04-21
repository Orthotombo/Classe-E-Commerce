using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce
{
    internal class Prodotto
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public decimal Prezzo { get; set; }
        public string Descrizione { get; set; }
        public string Brand { get; set; }
        public int QuantitaInGiacenza { get; set; }

        public Prodotto(string id, string nome, decimal prezzo, string descrizione, string brand, int quantita)
        {
            Id = id;
            Nome = nome;
            Prezzo = prezzo;
            Descrizione = descrizione;
            Brand = brand;
            QuantitaInGiacenza = quantita;
        }

        public void StampaProdotto()
        {
            Console.WriteLine($"\nID Prodotto: {Id}");
            Console.WriteLine($"Nome Prodotto: {Nome}");
            Console.WriteLine($"Prezzo del Prodotto: {Prezzo.ToString("C2")}");
            Console.WriteLine($"Descrizione: {Descrizione}");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"QUantità attualemnte disponibile: {QuantitaInGiacenza}");
        }
    }
}
