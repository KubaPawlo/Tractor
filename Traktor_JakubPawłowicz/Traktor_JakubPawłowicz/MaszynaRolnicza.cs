using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traktor_JakubPawłowicz
{

    public enum Rozmiary
    {
        brak, mały, średni, duży
    }
    public class MaszynaRolnicza
    {
        private double masa;
        private int kolor;
        private string nazwa;
        private Rozmiary rozmiar;




        public double Masa
        {
            get
            {
                return masa;
            }

            set
            {
                if (value > 10000)
                {
                    this.rozmiar = Rozmiary.duży;
                }
                else if (value > 5000)
                {
                    this.rozmiar = Rozmiary.średni;
                }
                else if (value > 0)
                {
                    this.rozmiar = Rozmiary.mały;
                }
                else
                {
                    MessageBox.Show("masa nie może byc ujemna");
                }
                masa = value;
                if (masa < 0)
                {
                    masa = masa * (-1);
                }
            }
        }



        public Rozmiary Rozmiar
        {
            get
            {
                return rozmiar;
            }

            set
            {
                if (masa > 10000)
                {
                    this.rozmiar = Rozmiary.duży;
                }
                else if (masa > 5000)
                {
                    this.rozmiar = Rozmiary.średni;
                }
                else if (masa > 0)
                {
                    this.rozmiar = Rozmiary.mały;
                }

            }
        }




        public int Kolor
        {
            get
            {
                return kolor;
            }

            set
            {
                kolor = value;
            }
        }




        public string Nazwa
        {
            get
            {
                return nazwa;
            }

            set
            {


                if (value != null)
                {
                    int dlugosc = value.Length;
                    if (dlugosc < 2)
                    {
                        MessageBox.Show("za krótka nazwa");
                    }
                    else
                    {
                        nazwa = value;
                    }
                }


            }
        }


    }
}
