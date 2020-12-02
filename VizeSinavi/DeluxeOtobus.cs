using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VizeSinavi
{
    public class DeluxeOtobus : OtobusBase, IOtobus
    {
        string path = Directory.GetCurrentDirectory() + @"\Yolcular.txt";
        public void YerAyirt(string musteriAdi,string musteriTC,bool cinsiyet,string otobus)
        {
            string cinsiyetStr = "";
            if (cinsiyet)
            {
                cinsiyetStr = "Erkek";
            }
            else
            {
                cinsiyetStr = "Kadın";
            }
            string kayit = musteriAdi + "  " + musteriTC + "  " + cinsiyetStr + "  " + otobus;
           
            File.WriteAllText(path, kayit);
        }
    }
}
