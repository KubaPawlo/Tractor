using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traktor_JakubPawłowicz
{
    public class Kombajn : MaszynaRolnicza
    {

        public enum TypNarzedzia
        {
            Zbierające, Żniwiarskie
        }

        private TypNarzedzia typNarzedzia;

        public TypNarzedzia Narzedzie
        {
            get
            {
                return typNarzedzia;
            }

            set
            {
                typNarzedzia = value;
                if (Narzedzie == TypNarzedzia.Zbierające)
                {
                    MessageBox.Show(this.Nazwa + " rozpoczyna zbieranie!");
                }
                else if (Narzedzie == TypNarzedzia.Żniwiarskie)
                {
                    MessageBox.Show(this.Nazwa + " rozpoczyna żniwa!");
                }
                else
                {
                    MessageBox.Show(this.Nazwa + " rozpoczyna pracę!");
                }
            }
        }

        public Kombajn(double nowaMasa, Rozmiary nowyRozmiar, int nowyKolor, string nowaNazwa, TypNarzedzia nowyTypNarzedzia)
            
        {
            this.Narzedzie = nowyTypNarzedzia;
        }

        
        

        


    }
}
