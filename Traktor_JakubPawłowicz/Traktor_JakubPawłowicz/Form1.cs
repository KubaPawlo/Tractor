using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traktor_JakubPawłowicz
{
    public partial class fmMain : Form
    {
        public fmMain()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fmMain_Load(object sender, EventArgs e)
        {
            tbInfo.AppendText("Traktor\r\n");
            tbInfo.AppendText("Jakub Pawłowicz 153029\r\n");
            tbInfo.AppendText("MCH2 semestr 5 Mechatronika\r\n");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tbInfo.AppendText("13.11.2023\r\n");


            Traktor t1; //na stosie
            t1 = new Traktor(); //na stercie

            tbInfo.AppendText("informacje o obiekcie t1:\r\n");
            tbInfo.AppendText(t1.ToString() + "\r\n"); //nazwa przestrzeni.nazwa klasy
            tbInfo.AppendText(t1.GetType().ToString() + "\r\n"); //to samo co wyzej
            tbInfo.AppendText("\r\n");

            Traktor t2 = new Traktor();
            t2.Masa = -2115;
            tbInfo.AppendText("informacje o obiekcie t2:\r\n");
            tbInfo.AppendText("masa: " + t2.Masa.ToString() + "\r\n");
            tbInfo.AppendText("\r\n");

            Traktor t3 = new Traktor();
            t3.Masa = 5555;
            t3.Rozmiar = Rozmiary.duży;
            tbInfo.AppendText("Informacje o obiekcie t3: \r\n");
            tbInfo.AppendText("masa: " + t3.Masa + "\r\n");
            tbInfo.AppendText("rozmiar: " + t3.Rozmiar + "\r\n");
            tbInfo.AppendText("\r\n");

            Traktor t4 = new Traktor();
            t4.Masa = 4444;
            t4.Rozmiar = Rozmiary.średni;
            t4.PojemnoscSilnika = 444.2;
            tbInfo.AppendText("Informacje o obiekcie t4: \r\n");
            tbInfo.AppendText("masa: " + t4.Masa + "\r\n");
            tbInfo.AppendText("rozmiar: " + t4.Rozmiar + "\r\n");
            tbInfo.AppendText("pojemnosc silnika: " + t4.PojemnoscSilnika + "\r\n");
            tbInfo.AppendText("\r\n");

            Traktor t5 = new Traktor();
            t5.Masa = 1234;
            t5.Rozmiar = Rozmiary.mały;
            t5.PojemnoscSilnika = 1;
            t5.Kolor = 5;
            tbInfo.AppendText("Informacje o obiekcie t5: \r\n");
            tbInfo.AppendText("masa: " + t5.Masa + "\r\n");
            tbInfo.AppendText("rozmiar: " + t5.Rozmiar + "\r\n");
            tbInfo.AppendText("pojemnosc silnika: " + t5.PojemnoscSilnika + "\r\n");
            tbInfo.AppendText("kolor: " + t5.Kolor + "\r\n");
            tbInfo.AppendText("\r\n");

            Traktor t6 = new Traktor();
            t6.Masa = 10001;
            t6.Rozmiar = Rozmiary.duży;
            t6.PojemnoscSilnika = 6;
            t6.Kolor = 10;
            t6.Nazwa = "traktor do ogródka";
            tbInfo.AppendText("Informacje o obiekcie t6: \r\n");
            tbInfo.AppendText("masa: " + t6.Masa + "\r\n");
            tbInfo.AppendText("rozmiar: " + t6.Rozmiar + "\r\n");
            tbInfo.AppendText("pojemnosc silnika: " + t6.PojemnoscSilnika + "\r\n");
            tbInfo.AppendText("kolor: " + t6.Kolor + "\r\n");
            tbInfo.AppendText("nazwa: " + t6.Nazwa + "\r\n");


            tbInfo.AppendText("27.11.2023\r\n");

            tbInfo.AppendText("11.12.2023\r\n");
            Traktor t7 = new Traktor();
            t7.Info(tbInfo);


            Traktor t8 = new Traktor(21.15, 666);
            t8.Info(tbInfo);

            Traktor t9 = new Traktor("pyrpyr");
            t9.Info(tbInfo);

            Traktor t10 = new Traktor(555, Rozmiary.duży);
            t10.Info(tbInfo);


            tbInfo.AppendText("08.01.2024\r\n");

            MaszynaRolnicza mr1 = new MaszynaRolnicza();

            Traktor t11 = new Traktor();

            TraktorPolny tp1 = new TraktorPolny();

            Kombajn Kombajn1 = new Kombajn(15000, Rozmiary.duży, 3, "Kombajn1", Kombajn.TypNarzedzia.Zbierające);
            tbInfo.AppendText("Nazwa: " + Kombajn1.Nazwa + ", Typ narzędzia: " + Kombajn1.Narzedzie);

        }
    }
}
