using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GraWPanstwa.Repozytorium
{
    public class Mieszanie
    {
        public string[] ZmianaKolejnosci(string[] Litery)
        {
            Random r = new Random();
            return Litery.OrderBy(x => r.Next()).ToArray();
        }
    }
}