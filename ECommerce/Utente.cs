using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce
{
    internal class Utente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public List<Ordine> ListaOrdini { get; set; }=new List<Ordine>();
        public List<Indirizzo> Indirizzi { get; set;} = new List<Indirizzo>();
        public List<MetodiPagamento> MetodiPagamento { get; set; } = new List<MetodiPagamento>();

        public Utente(string nome, string cognome)
        {
            Nome = nome;
            Cognome = cognome;
        }
        
        public static void AggiungiOrdine(Utente u, Ordine o) 
        {
            u.ListaOrdini.Add(o);
        } 
        public static void AggiungiIndirizzo(Utente u, Indirizzo i)
        {
            u.Indirizzi.Add(i);
        }

        public static void AggiungiMetodo(Utente u, MetodiPagamento m)
        {
            u.MetodiPagamento.Add(m);
        }

        public void StampaUtente() 
        {
            Console.WriteLine($"Nome Utente: {Nome}");
            Console.WriteLine($"Cognome Utente: {Cognome}");
            Console.WriteLine("___________________________________________________________");
            foreach (Ordine item in ListaOrdini)
            {
                Console.WriteLine("___________________________________________________________");
                item.StampaOrdine();
                Console.WriteLine("___________________________________________________________");

            }
            Console.WriteLine("___________________________________________________________");
            foreach (Indirizzo item in Indirizzi) 
            {
                item.StampaIndirizzo();

            }
            Console.WriteLine("___________________________________________________________");
            foreach (MetodiPagamento item in MetodiPagamento) 
            {
                item.StampaMetodo();
            }
            Console.WriteLine("___________________________________________________________");

        }
    }
}
