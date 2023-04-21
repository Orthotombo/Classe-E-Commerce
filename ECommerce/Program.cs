using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Prodotto prodotto1 = new Prodotto("H1Z1", "Pallone da calcio", 3.5m, "Adidas", "Adidas", 100);
            Prodotto prodotto2 = new Prodotto("H1Z2", "Pallone da calcio", 7m, "Nike", "Nike", 100);
            Prodotto prodotto3 = new Prodotto("H2Z1", "Pallone da calcio", 1.50m, "Super Santos", "Super Santos", 100);

            Utente utente1 = new Utente("Emanuele", "Patella");
            Utente utente2 = new Utente("Paolo", "Brosio");
            Utente utente3 = new Utente("Cristiano", "Ronaldo");

            DatiDiSpedizione dati1 = new DatiDiSpedizione("Bartolini");
            DatiDiSpedizione dati2 = new DatiDiSpedizione("Poste Italiane");
            DatiDiSpedizione dati3 = new DatiDiSpedizione("Amazon");

            DateTime data1 = new DateTime(2022, 10, 4);
            Ordine ordine1 = new Ordine("Ordine 1", data1, dati1);
            DateTime data2 = new DateTime(2019, 10, 4);
            Ordine ordine2 = new Ordine("Ordine 2", data2, dati2);
            DateTime data3 = new DateTime(2022, 1, 22);
            Ordine ordine3 = new Ordine("Ordine 3", data3, dati3);

            Ordine.AggiungiProdotto(ordine1, prodotto1);
            Ordine.AggiungiProdotto(ordine1, prodotto1);
            Ordine.AggiungiProdotto(ordine1, prodotto1);
            Ordine.AggiungiProdotto(ordine1, prodotto2);
            //Ordine 1 = 3 palloni Adidas e 1 Nike, per un totale di 17.50

            Ordine.AggiungiProdotto(ordine2, prodotto3);
            Ordine.AggiungiProdotto(ordine2, prodotto1);
            Ordine.AggiungiProdotto(ordine2, prodotto1);
            Ordine.AggiungiProdotto(ordine2, prodotto2);
            // Ordine 2 = 1 Supoer Stantos 2 Palloni Adidas e 1 Nike, per un totale di 15.50

            Ordine.AggiungiProdotto(ordine3, prodotto3);
            Ordine.AggiungiProdotto(ordine3, prodotto3);
            Ordine.AggiungiProdotto(ordine3, prodotto3);
            Ordine.AggiungiProdotto(ordine3, prodotto3);
            // Ordine 3 = 4 Palloni Super Santos, per un totale di 6

            Utente.AggiungiOrdine(utente1, ordine1);

            Utente.AggiungiOrdine(utente2, ordine2);
            Utente.AggiungiOrdine(utente2, ordine2);

            Utente.AggiungiOrdine(utente3, ordine3);
            Utente.AggiungiOrdine(utente3, ordine3);
            Utente.AggiungiOrdine(utente3, ordine3);

            Indirizzo indirizzo1 = new Indirizzo("Via Madonna del Carmine 175");
            Indirizzo indirizzo12 = new Indirizzo("Via Madonna del Carmine 49");

            Utente.AggiungiIndirizzo(utente1, indirizzo1);
            Utente.AggiungiIndirizzo(utente1, indirizzo12);

            Indirizzo indirizzo2 = new Indirizzo("aaaaaaaaaaaaaa");
            Indirizzo indirizzo22 = new Indirizzo("bbbbbbbbbbbbbbbbbb");

            Utente.AggiungiIndirizzo(utente2, indirizzo2);
            Utente.AggiungiIndirizzo(utente2, indirizzo22);

            Indirizzo indirizzo3 = new Indirizzo("Ronaldo city");

            Utente.AggiungiIndirizzo(utente3, indirizzo3);

            MetodiPagamento metodo1 = new MetodiPagamento("Carta");
            MetodiPagamento metodo2 = new MetodiPagamento("Contante");
            MetodiPagamento metodo3 = new MetodiPagamento("Bonifico");

            Utente.AggiungiMetodo(utente1, metodo1);
            Utente.AggiungiMetodo(utente1, metodo2);

            Utente.AggiungiMetodo(utente2, metodo2);
            Utente.AggiungiMetodo(utente2, metodo3);

            Utente.AggiungiMetodo(utente3, metodo3);

            ordine1.MetodiPagamento = metodo1;
            ordine2.MetodiPagamento = metodo2;
            ordine3.MetodiPagamento = metodo3;

            ordine1.DatiDiSpedizione = dati1;
            ordine2.DatiDiSpedizione = dati2;
            ordine3.DatiDiSpedizione = dati3;

            DatabaseEcommerce.ProdottiInMagazzino.Add(prodotto1);
            DatabaseEcommerce.ProdottiInMagazzino.Add(prodotto2);
            DatabaseEcommerce.ProdottiInMagazzino.Add(prodotto3);

            DatabaseEcommerce.TotaleOrdini.Add(ordine1);
            DatabaseEcommerce.TotaleOrdini.Add(ordine2);
            DatabaseEcommerce.TotaleOrdini.Add(ordine3);

            DatabaseEcommerce.UtenteList.Add(utente1);
            DatabaseEcommerce.UtenteList.Add(utente2);
            DatabaseEcommerce.UtenteList.Add(utente3);

            DatabaseEcommerce.MenuComandi();
        }
    }
}
