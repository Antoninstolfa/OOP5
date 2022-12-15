using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zamestnanec
{
    class Zamestnanec
    {
        private string jmeno;
        private string prijmeni;
        private DateTime datumNastupu;
        public short HodinovaMzda { get; }
        public int odpracHodiny;
        public Zamestnanec(string jmeno, string prijmeni, DateTime datumNastupu, int HodinovaMzda)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.datumNastupu = datumNastupu;
            this.HodinovaMzda = HodinovaMzda;
        }

        public int PocetDni()
        {
            return PocetDni;
        }
        public void ODpracujHodiny()
        {

        }
        public void VypoctiMzdu()
        {

        }
        public string vypis()
        {
            return " ";
        }
    }
}
