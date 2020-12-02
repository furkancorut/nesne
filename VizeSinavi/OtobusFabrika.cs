using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizeSinavi
{
    public class OtobusFabrika
    {
        public IOtobus OtobusGetir(string otobusTipi)// Her otobus için fabrika nesne oluşumu cepheOtobusde gerçekkleştirildi
        {
            if (otobusTipi == "2+2")
            {
                return new Otobus_2_2();
            }
            else if (otobusTipi == "2+1")
            {
                return new Otobus_2_1();
            }
            else if (otobusTipi == "deluxe")
            {
                return new DeluxeOtobus();
            }
            else
            {
                return null;
            }
        }
    }
}
