using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Traktor_JakubPawłowicz.TraktorPolny;

namespace Traktor_JakubPawłowicz
{
    
    public class Traktor : MaszynaRolnicza
    {
        public enum SzerokoscKol
        {
            szerokie, wąskie
        }
        //private double masa; //wczesniej byly w traktorze ale bardziej pasują do klasy nadrzędnej

        //private Rozmiary rozmiar;

        private double pojemnoscSilnika;
        private SzerokoscKol szerokoscKola;

        //private int kolor;

        //private string nazwa; //pole     pozostaje prywatne zeby byla hermetyzacja danych i zachowac kontrole nad wprowadzonymi wartosciami

        
        public double PojemnoscSilnika //własciwosc
        {
            get
            {
                return pojemnoscSilnika;
            }

            set
            {
                try
                {
                    if (value < 5)
                    {
                        MessageBox.Show(this.Nazwa + "za mała pojemnosc, to nie traktor");
                    }
                    pojemnoscSilnika = value;
                }
                catch
                {

                }
            }
        }
       


        
        public Traktor()//konstruktor
        {
            this.Masa = 1;
            this.Rozmiar = Rozmiary.średni;
            this.PojemnoscSilnika = 10;
            this.Kolor = 5;
            this.Nazwa = "traktorek";
        }

        public Traktor(double NowaMasa, double NowaPojemnoscSilnika) : this()//konstruktor z parametrem, this() oznacza wykonanie konstruktora domyslnego, nastepnie zostanie zmienione na parametr
        {
            this.Masa = NowaMasa;
            this.PojemnoscSilnika = NowaPojemnoscSilnika;
        }

        public Traktor(int NowyKolor, Rozmiary NowyRozmiar) : this()
        {
            this.Kolor = NowyKolor;
            this.Rozmiar = NowyRozmiar;//nie mozna narzucic rozmiaru jesli wczesniej nie spelni warunku masy ktory jest w if
        }
        public Traktor(double nowaMasa, Rozmiary nowyRozmiar, double nowaPojemnoscSilnika, int nowyKolor, string nowaNazwa) :this() //kaskadowe pobieranie
        {
            
            this.Masa = nowaMasa;

            // Przykład użycia właściwości z warunkiem (rozmiar nie może zostać ustawiony przed sprawdzeniem masy)
            if (nowaMasa > 5)
            {
                this.Rozmiar = nowyRozmiar;
            }
            else
            {
                MessageBox.Show(this.Nazwa + ": Za mała masa, nie można ustawić rozmiaru!");
            }

            this.PojemnoscSilnika = nowaPojemnoscSilnika;
            this.Kolor = nowyKolor;
            this.Nazwa = nowaNazwa;
        }

        public Traktor(string NowaNazwa) : this()
        {
            this.Nazwa = NowaNazwa;
        }


        public void Info(TextBox tb)
        {
            tb.AppendText("Informacje o obiekcie: \r\n");
            tb.AppendText("masa: " + this.Masa + "\r\n");
            tb.AppendText("rozmiar: " + this.Rozmiar + "\r\n");
            tb.AppendText("pojemnosc silnika: " + this.PojemnoscSilnika + "\r\n");
            tb.AppendText("kolor: " + this.Kolor + "\r\n");
            tb.AppendText("nazwa: " + this.Nazwa + "\r\n");
            
            tb.AppendText("\r\n");
        }
    }
}
