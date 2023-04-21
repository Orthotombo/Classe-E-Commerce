using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce
{
    internal class DatiDiSpedizione
    {
        public string TipoCorriere { get; set; }
        
        public DatiDiSpedizione(string tipo)
        {
            TipoCorriere = tipo;
        }

        public void StampaCorriere()
        {
            Console.WriteLine($"Ditta che effettua la spedizione: {TipoCorriere}");
        }
    }
}
