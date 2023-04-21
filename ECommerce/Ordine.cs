using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce
{
    internal class Ordine
    {
        public string IdOrdine { get; set; }
        public DateTime DataOrdine { get; set; }
        public decimal ImportoTotale { get; set; }
        public List<Prodotto> Prodotti { get; set; } = new List<Prodotto>();
        public MetodiPagamento MetodiPagamento { get; set; }
        public DatiDiSpedizione DatiDiSpedizione { get; set; }
        public Ordine(string id, DateTime data, DatiDiSpedizione d) 
        {
            IdOrdine = id;
            DataOrdine = data;
            DatiDiSpedizione = d;
        }

        public static void AggiungiProdotto(Ordine o, Prodotto p) 
        {
            int posizione = 0;
            o.Prodotti.Add(p);
            foreach (Prodotto item in DatabaseEcommerce.ProdottiInMagazzino)
            {
                if (item.Id == DatabaseEcommerce.ProdottiInMagazzino.ElementAt(posizione).Id)
                {
                    DatabaseEcommerce.ProdottiInMagazzino.ElementAt(posizione).QuantitaInGiacenza--;
                    break;
                }
                else 
                {
                    posizione++;
                }
            }
            o.ImportoTotale += p.Prezzo;
            p.QuantitaInGiacenza--;
        }

        public void StampaOrdine() 
        {
            Console.WriteLine($"ID Ordine: {IdOrdine}");
            Console.WriteLine($"Data dell'Ordine: {DataOrdine.Date}");
            Console.WriteLine($"Importo dell'ordine: {ImportoTotale.ToString("C2")}");
            foreach (Prodotto item in Prodotti) 
            {
                item.StampaProdotto();
            }
            Console.WriteLine("");
            MetodiPagamento.StampaMetodo();
            DatiDiSpedizione.StampaCorriere();
        }

    }
}
