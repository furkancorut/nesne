using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizeSinavi
{
    public interface IOtobus//Fabrika tasarım deseni için referans olarak kullanılacak interface
    {
        void YerAyirt(string musteriAdi, string musteriTC, bool cinsiyet, string otobus);
    }
}
