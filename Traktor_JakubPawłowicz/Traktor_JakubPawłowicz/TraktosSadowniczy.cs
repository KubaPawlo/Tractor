using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traktor_JakubPawłowicz
{
    public class TraktorSadowniczy : Traktor
    {
        public enum RodzajZbioru
        {
            Mechaniczny, // Rodzaj zbioru wykorzystujący mechanizmy mechaniczne
            Elektroniczny // Rodzaj zbioru wykorzystujący zaawansowane rozwiązania elektroniczne
        }

        private RodzajZbioru rodzajZbioru;

        public RodzajZbioru Zbior
        {
            get
            {
                return rodzajZbioru;
            }
            set
            {
                rodzajZbioru = value;
            }
        }
    }
}

        
       


