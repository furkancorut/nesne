using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizeSinavi
{
    public class CepheOtobus// Cephe Tasarım Modeli
    {
        private Otobus_2_1 otobus_2_1;
        private Otobus_2_2 otobus_2_2;
        private DeluxeOtobus deluxeOtobus;


        private OtobusFabrika otobusFabrika;

        public CepheOtobus()
        {
            otobusFabrika = new OtobusFabrika();//Otobus fabrika nesne oluşumu   

            otobus_2_1 = (Otobus_2_1)otobusFabrika.OtobusGetir("2+1");// Otobus fabrikadan nesne üretimi
            otobus_2_2 = (Otobus_2_2)otobusFabrika.OtobusGetir("2+2");
            deluxeOtobus = (DeluxeOtobus)otobusFabrika.OtobusGetir("deluxe");
        }

        public void Otobus_2_1_YerAyirt(string musteriAdi, string musteriTC, bool cinsiyet, string otobus)
        {
            otobus_2_1.YerAyirt(musteriAdi, musteriTC, cinsiyet, otobus);
        }
        public void Otobus_2_2_YerAyirt(string musteriAdi, string musteriTC, bool cinsiyet, string otobus)
        {
            otobus_2_2.YerAyirt(musteriAdi, musteriTC, cinsiyet, otobus);
        }
        public void Deluxe_YerAyirt(string musteriAdi, string musteriTC, bool cinsiyet, string otobus)
        {
            deluxeOtobus.YerAyirt(musteriAdi, musteriTC, cinsiyet, otobus);
        }
    }
}
