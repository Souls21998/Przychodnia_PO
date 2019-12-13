using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przychodnia_PO
{
    class Przychodnia : IPrzychodnia
    {
        int nr_gabinetu;
        string nazwa_gabinetu;

        public Przychodnia(int nr_gabinetu, string nazwa_gabinetu)
        {
            this.nr_gabinetu = nr_gabinetu;
            this.nazwa_gabinetu = nazwa_gabinetu;
        }
    }
}
