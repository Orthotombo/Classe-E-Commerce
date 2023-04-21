using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce
{
    internal class Indirizzo
    {
        public string IndirizzoDiConsegna { get; set; }

        public Indirizzo(string indi)
        {
            IndirizzoDiConsegna = indi;
        }

        public void StampaIndirizzo()
        {
            Console.WriteLine($"Indirizzo di consegna: {IndirizzoDiConsegna}");
        }
    }
}
