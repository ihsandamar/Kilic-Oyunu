using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KilicOyunu
{
    class Kart
    {
        public string tur;
        public string sayi;
        

        public void bilgiYaz()
        {
            Console.WriteLine(" {0} - {1}", tur, sayi);
        }
    }
}
