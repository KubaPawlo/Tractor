using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traktor_JakubPawłowicz
{
    public class TraktorPolny : Traktor
    {
        public enum GasieniceCzyKola
        {
            gąsienice, koła
        }
       

        private GasieniceCzyKola naped;
     


        public GasieniceCzyKola Naped
        {
            get
            {
                return naped;
            }
            set
            {
                if (Masa > 10000)
                {
                    this.naped = GasieniceCzyKola.gąsienice;
                }
                else
                {
                    this.naped = GasieniceCzyKola.koła;
                }
            }
        }
            

    }

}
