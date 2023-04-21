using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce
{
    internal class MetodiPagamento
    {
        public string Metodo { get; set; }
        public MetodiPagamento(string met)
        {
            Metodo = met;
        }

        public void StampaMetodo() 
        {
            Console.WriteLine($"Metodo di Pagamento: {Metodo}");
        }
    }
}
