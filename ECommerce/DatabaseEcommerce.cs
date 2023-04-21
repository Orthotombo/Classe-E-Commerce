using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce
{
    internal class DatabaseEcommerce
    {
        public static List<Utente> UtenteList { get; set; } = new List<Utente>();
        public static List<Ordine> TotaleOrdini { get; set; } = new List<Ordine>();

        public static List<Prodotto> ProdottiInMagazzino { get; set; } = new List<Prodotto>();

        public static void MenuComandi()
        {
            int scelta;

            Console.WriteLine("===========================================================");
            Console.WriteLine("============ BENVENUTO NEL NOSTRO E - COMMERCE ============\n");
            Console.WriteLine("Scegli pure tra una delle seguenti opzioni, premendo il numero corrispondente: ");
            Console.WriteLine("1. Stampa elenco clienti che hanno ordinato.");
            Console.WriteLine("2. Importo totale degli ordini evasi fino ad ora.");
            Console.WriteLine("3. Ordini superiori a un determinato imput.");
            Console.WriteLine("4. Prodotti in giacenza con quantità inferiore a X.");
            Console.WriteLine("5. Elenco prodotti ordinati nell'ordine X.");
            Console.WriteLine("6. ESCI\n");
            Console.WriteLine("============ BENVENUTO NEL NOSTRO E - COMMERCE ============");
            Console.WriteLine("===========================================================");
            scelta=int.Parse(Console.ReadLine());

            switch (scelta)
            {
                case 1:
                    DatabaseEcommerce.StampaUtenti();
                    break;
                case 2:
                    DatabaseEcommerce.StampaTotaleOrdini();
                    break; 
                case 3:
                    DatabaseEcommerce.StampaOrdiniSoglia();
                    DatabaseEcommerce.MenuComandi();
                    break; 
                case 4:
                    DatabaseEcommerce.StampaProdottiSottoSOglia();
                    break; 
                case 5:
                    DatabaseEcommerce.StampaOrdineSpecifico();
                    DatabaseEcommerce.MenuComandi();
                    break; 
                case 6: 
                    Environment.Exit(0);
                    break;
                default: 
                    Console.Clear();
                    Console.WriteLine("Comando non in elenco, riprovare");
                    DatabaseEcommerce.MenuComandi();
                    break;
            }   
        }

        public static void StampaUtenti()
        {
            Console.Clear();
            foreach (Utente item in UtenteList)
            {
                Console.WriteLine("===========================================================");
                item.StampaUtente();
                Console.WriteLine("===========================================================");
                Console.WriteLine("");
            }
            Console.WriteLine("PREMERE INVIO PER TORNARE AL MENU");
            Console.ReadLine();
            Console.Clear();
            DatabaseEcommerce.MenuComandi();
        }

        public static void StampaTotaleOrdini() 
        {
            int contatore = 0;
            decimal totale=0;
            Console.Clear();
            foreach (Ordine item in TotaleOrdini) 
            {
                totale+=item.ImportoTotale;
                contatore++;
            }
            Console.WriteLine("===========================================================");
            Console.WriteLine("============ BENVENUTO NEL NOSTRO E - COMMERCE ============\n");
            Console.WriteLine($"\nIl totale degli oridni evasi finora ammonta a: {contatore}\n Per un totale di: {totale.ToString("C2")}");
            Console.WriteLine("\nPREMERE INVIO PER TORNARE AL MENU\n");
            Console.WriteLine("============ BENVENUTO NEL NOSTRO E - COMMERCE ============");
            Console.WriteLine("===========================================================");
            Console.ReadLine();
            Console.Clear();
            DatabaseEcommerce.MenuComandi();
        }

        public static void StampaOrdiniSoglia() 
        {
            decimal soglia;
            Console.Clear();
            Console.Write("Inserire la soglia di prezzo: ");
            soglia=decimal.Parse(Console.ReadLine());
            Console.WriteLine("");

            foreach (Ordine item in TotaleOrdini)
            {
                if(item.ImportoTotale >= soglia)
                {
                    Console.WriteLine("===========================================================");
                    item.StampaOrdine();
                    Console.WriteLine("===========================================================");
                    Console.WriteLine("");
                }
            }
            Console.WriteLine("PREMERE INVIO PER TORNARE AL MENU");
            Console.ReadLine();
            Console.Clear();
            DatabaseEcommerce.MenuComandi();
        }

        public static void StampaProdottiSottoSOglia() 
        {
            decimal soglia;
            Console.Clear();
            Console.Write("Inserire il valore X: ");
            soglia = decimal.Parse(Console.ReadLine());

            foreach (Prodotto item in ProdottiInMagazzino)
            {
                if(item.QuantitaInGiacenza < soglia)
                {
                    Console.WriteLine("===========================================================");
                    item.StampaProdotto();
                    Console.WriteLine("===========================================================");
                    Console.WriteLine("");
                }
            }
            Console.WriteLine("PREMERE INVIO PER TORNARE AL MENU");
            Console.ReadLine();
            Console.Clear();
            DatabaseEcommerce.MenuComandi();
        }

        public static void StampaOrdineSpecifico() 
        {
            string identificativo;
            Console.Clear();
            
            Console.WriteLine("===========================================================");
            Console.WriteLine("============ BENVENUTO NEL NOSTRO E - COMMERCE ============\n");
            Console.Write("Inserire l'identificativo dell'ordine: ");
            identificativo = Console.ReadLine();
            Console.WriteLine("\n");


            foreach (Ordine item in TotaleOrdini) 
            {
                if (item.IdOrdine==identificativo) 
                {
                    Console.WriteLine("===========================================================");
                    item.StampaOrdine();
                    Console.WriteLine("===========================================================");
                }
            }
            Console.WriteLine("\nPREMERE INVIO PER TORNARE AL MENU");
            Console.ReadLine();
            Console.Clear();
            DatabaseEcommerce.MenuComandi();
        }
    }
}
