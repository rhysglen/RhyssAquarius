using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace RhyssAquarius
{
    public partial class AquariusCard : Form
    {
        public AquariusCard()
        {
            InitializeComponent();
        }
        //Rhyss Glenfield September 20, 2017, "star day" card based off the aquarius constellation
        private void AquariusCard_Click(object sender, EventArgs e)
        {
            // photo
            BackgroundImage = null;
            Refresh();

            //graphics object
            Graphics aquariusCard = this.CreateGraphics();

            //pens,brushes,fonts,soundplayer
            Pen aquariusPen = new Pen(Color.DodgerBlue, 30);
            SolidBrush aquariusBrush = new SolidBrush(Color.DodgerBlue);
            Font aquariusFont = new Font("Papyrus", 70, FontStyle.Bold);
            SolidBrush aquariusWord = new SolidBrush(Color.Black);
            Pen starPen = new Pen(Color.Yellow, 5);
            SolidBrush starBrush = new SolidBrush(Color.Yellow);
            Pen linePen = new Pen(Color.MediumBlue, 3);
            Font rhyssFont = new Font("Pristina", 25, FontStyle.Regular);
            SolidBrush rhyssWord = new SolidBrush(Color.Black);
            Font cardFont = new Font("century", 15, FontStyle.Regular);
            SolidBrush cardBrush = new SolidBrush(Color.DodgerBlue);
            SoundPlayer waterPlayer = new SoundPlayer(Properties.Resources.Water);
            SoundPlayer bellPlayer = new SoundPlayer(Properties.Resources.Bell);

            //the colours of aquarius/front face of card
            aquariusCard.DrawRectangle(aquariusPen, 0, 0, 950, 250);
            aquariusCard.FillRectangle(aquariusBrush, 0, 0, 950, 250);
            aquariusPen.Color = Color.Gray;
            aquariusBrush.Color = Color.Gray;
            aquariusCard.DrawRectangle(aquariusPen, 0, 250, 950, 250);
            aquariusCard.FillRectangle(aquariusBrush, 0, 250, 950, 250);
            aquariusPen.Color = Color.Chartreuse;
            aquariusBrush.Color = Color.Chartreuse;
            aquariusCard.DrawRectangle(aquariusPen, 0, 500, 950, 250);
            aquariusCard.FillRectangle(aquariusBrush, 0,500 , 950, 250);
            aquariusPen.Color = Color.Black;
            aquariusCard.DrawLine(aquariusPen, 0, 15, 950, 15);
            aquariusCard.DrawLine(aquariusPen, 0, 725, 950, 725);
            aquariusCard.DrawLine(aquariusPen, 0, 250, 950, 250);
            aquariusCard.DrawLine(aquariusPen, 0, 500, 950, 500);

            // Tite of the constellation 
            aquariusCard.DrawString("Happy Star Day", aquariusFont, aquariusWord, 70, 55);

            // My name
            aquariusCard.DrawString("Rhyss Glenfield", rhyssFont, rhyssWord, 50, 550);
            aquariusCard.DrawString("September 27, 2017", rhyssFont, rhyssWord, 50, 600);

            //pausing and clearing the screen
            Thread.Sleep(5000);
            aquariusCard.Clear(Color.Black);

            //connect the dots
            aquariusCard.DrawLine(linePen, 105, 200, 170, 250);
            linePen.Color = Color.Black;
            Thread.Sleep(300);
            linePen.Color = Color.MediumBlue;
            aquariusCard.DrawLine(linePen, 170, 250, 195, 350);
            linePen.Color = Color.Black;
            Thread.Sleep(300);
            linePen.Color = Color.MediumBlue;
            aquariusCard.DrawLine(linePen, 195, 350, 175, 390);
            linePen.Color = Color.Black;
            Thread.Sleep(300);
            linePen.Color = Color.MediumBlue;
            aquariusCard.DrawLine(linePen, 175, 390, 115, 520);
            linePen.Color = Color.Black;
            Thread.Sleep(300);
            linePen.Color = Color.MediumBlue;
            aquariusCard.DrawLine(linePen, 105,200, 375, 75);
            linePen.Color = Color.Black;
            Thread.Sleep(300);
            linePen.Color = Color.MediumBlue;
            aquariusCard.DrawLine(linePen, 375, 75, 405, 65);
            linePen.Color = Color.Black;
            Thread.Sleep(300);
            linePen.Color = Color.MediumBlue;
            aquariusCard.DrawLine(linePen, 405, 65, 455, 105);
            linePen.Color = Color.Black;
            Thread.Sleep(300);
            linePen.Color = Color.MediumBlue;
            aquariusCard.DrawLine(linePen, 455, 105, 500, 75);
            linePen.Color = Color.Black;
            Thread.Sleep(300);
            linePen.Color = Color.MediumBlue;
            aquariusCard.DrawLine(linePen, 500, 75, 470, 275);
            linePen.Color = Color.Black;
            Thread.Sleep(300);
            linePen.Color = Color.MediumBlue;
            aquariusCard.DrawLine(linePen, 470, 275, 500, 375);
            linePen.Color = Color.Black;
            Thread.Sleep(300);
            linePen.Color = Color.MediumBlue;
            aquariusCard.DrawLine(linePen, 500, 75, 610, 210);
            linePen.Color = Color.Black;
            Thread.Sleep(300);
            linePen.Color = Color.MediumBlue;
            aquariusCard.DrawLine(linePen, 610, 210, 800, 280);
            linePen.Color = Color.Black;
            Thread.Sleep(300);
            linePen.Color = Color.MediumBlue;

            //the Stars appearing and rushing water
            waterPlayer.Play();
            aquariusCard.DrawEllipse(starPen, 452, 103, 5, 5);
            aquariusCard.FillEllipse(starBrush, 452, 103, 5, 5);
            starPen.Color = Color.Black;
            starBrush.Color = Color.Black;
            Thread.Sleep(200);
            starPen.Color = Color.Yellow;
            starBrush.Color = Color.Yellow;
            aquariusCard.DrawEllipse(starPen, 496, 372, 7, 7);
            aquariusCard.FillEllipse(starBrush, 496, 372, 7, 7);
            starPen.Color = Color.Black;
            starBrush.Color = Color.Black;
            Thread.Sleep(300);
            starPen.Color = Color.Yellow;
            starBrush.Color = Color.Yellow;
            aquariusCard.DrawEllipse(starPen, 168, 250, 5, 5);
            aquariusCard.FillEllipse(starBrush, 168, 250, 5, 5);
            starPen.Color = Color.Black;
            starBrush.Color = Color.Black;
            Thread.Sleep(250);
            starPen.Color = Color.Yellow;
            starBrush.Color = Color.Yellow;
            aquariusCard.DrawEllipse(starPen, 191, 348, 10, 10);
            aquariusCard.FillEllipse(starBrush, 191, 348, 10, 10);
            starPen.Color = Color.Black;
            starBrush.Color = Color.Black;
            Thread.Sleep(100);
            starPen.Color = Color.Yellow;
            starBrush.Color = Color.Yellow;
            aquariusCard.DrawEllipse(starPen, 800, 278, 10, 10);
            aquariusCard.FillEllipse(starBrush, 800, 278, 10, 10);
            starPen.Color = Color.Black;
            starBrush.Color = Color.Black;
            Thread.Sleep(90);
            starPen.Color = Color.Yellow;
            starBrush.Color = Color.Yellow;
            aquariusCard.DrawEllipse(starPen, 112, 520, 5, 5);
            aquariusCard.FillEllipse(starBrush, 112, 520, 5, 5);
            starPen.Color = Color.Black;
            starBrush.Color = Color.Black;
            Thread.Sleep(200);
            starPen.Color = Color.Yellow;
            starBrush.Color = Color.Yellow;
            aquariusCard.DrawEllipse(starPen, 373, 75, 5, 5);
            aquariusCard.FillEllipse(starBrush, 373, 75, 5, 5);
            starPen.Color = Color.Black;
            starBrush.Color = Color.Black;
            Thread.Sleep(170);
            starPen.Color = Color.Yellow;
            starBrush.Color = Color.Yellow;
            aquariusCard.DrawEllipse(starPen, 402, 62, 10, 10);
            aquariusCard.FillEllipse(starBrush, 402, 62, 10, 10);
            starPen.Color = Color.Black;
            starBrush.Color = Color.Black;
            Thread.Sleep(210);
            starPen.Color = Color.Yellow;
            starBrush.Color = Color.Yellow;
            aquariusCard.DrawEllipse(starPen, 100, 190, 25, 25);
            aquariusCard.FillEllipse(starBrush, 100, 190, 25, 25);
            starPen.Color = Color.Black;
            starBrush.Color = Color.Black;
            Thread.Sleep(230);
            starPen.Color = Color.Yellow;
            starBrush.Color = Color.Yellow;     
            aquariusCard.DrawEllipse(starPen, 172, 390, 5, 5);
            aquariusCard.FillEllipse(starBrush, 172, 390, 5, 5);
            starPen.Color = Color.Black;
            starBrush.Color = Color.Black;
            Thread.Sleep(200);
            starPen.Color = Color.Yellow;
            starBrush.Color = Color.Yellow;
            aquariusCard.DrawEllipse(starPen, 467, 275, 7, 7);
            aquariusCard.FillEllipse(starBrush, 467, 275, 7, 7);
            starPen.Color = Color.Black;
            starBrush.Color = Color.Black;
            Thread.Sleep(240);
            starPen.Color = Color.Yellow;
            starBrush.Color = Color.Yellow;
            aquariusCard.DrawEllipse(starPen, 497, 75, 7, 7);
            aquariusCard.FillEllipse(starBrush, 497, 75, 7, 7);
            starPen.Color = Color.Black;
            starBrush.Color = Color.Black;
            Thread.Sleep(150);
            starPen.Color = Color.Yellow;
            starBrush.Color = Color.Yellow;
            aquariusCard.DrawEllipse(starPen, 610, 210, 10, 10);
            aquariusCard.FillEllipse(starBrush, 610, 210, 10, 10);
            starPen.Color = Color.Black;
            starBrush.Color = Color.Black;
            Thread.Sleep(110);
            starPen.Color = Color.Yellow;
            starBrush.Color = Color.Yellow;

            //words and a bell
            bellPlayer.Play();
            aquariusCard.DrawString("May your life bring you to steady waters,", cardFont, cardBrush, 500, 500);
            aquariusCard.DrawString("have a stellar day!", cardFont, cardBrush, 600, 520);
            Thread.Sleep(300);
            aquariusCard.DrawString("May your life bring you to steady waters,", cardFont, cardBrush, 500, 500);
            aquariusCard.DrawString("have a stellar day!", cardFont, cardBrush, 600, 520);
            cardBrush.Color = Color.Gray;
            aquariusCard.DrawString("May your life bring you to steady waters,", cardFont, cardBrush, 500, 500);
            aquariusCard.DrawString("have a stellar day!", cardFont, cardBrush, 600, 520);
            Thread.Sleep(300);
            cardBrush.Color = Color.Chartreuse;
            aquariusCard.DrawString("May your life bring you to steady waters,", cardFont, cardBrush, 500, 500);
            aquariusCard.DrawString("have a stellar day!", cardFont, cardBrush, 600, 520);
            Thread.Sleep(300);
            cardBrush.Color = Color.DodgerBlue;
            aquariusCard.DrawString("May your life bring you to steady waters,", cardFont, cardBrush, 500, 500);
            aquariusCard.DrawString("have a stellar day!", cardFont, cardBrush, 600, 520);
            cardBrush.Color = Color.Gray;
            aquariusCard.DrawString("May your life bring you to steady waters,", cardFont, cardBrush, 500, 500);
            aquariusCard.DrawString("have a stellar day!", cardFont, cardBrush, 600, 520);
            Thread.Sleep(300);
            cardBrush.Color = Color.Chartreuse;
            aquariusCard.DrawString("May your life bring you to steady waters,", cardFont, cardBrush, 500, 500);
            aquariusCard.DrawString("have a stellar day!", cardFont, cardBrush, 600, 520);
            Thread.Sleep(300);
            cardBrush.Color = Color.DodgerBlue;
            aquariusCard.DrawString("May your life bring you to steady waters,", cardFont, cardBrush, 500, 500);
            aquariusCard.DrawString("have a stellar day!", cardFont, cardBrush, 600, 520);
            Thread.Sleep(300);
            cardBrush.Color = Color.Gray;
            aquariusCard.DrawString("May your life bring you to steady waters,", cardFont, cardBrush, 500, 500);
            aquariusCard.DrawString("have a stellar day!", cardFont, cardBrush, 600, 520);
            Thread.Sleep(300);
            cardBrush.Color = Color.Chartreuse;
            aquariusCard.DrawString("May your life bring you to steady waters,", cardFont, cardBrush, 500, 500);
            aquariusCard.DrawString("have a stellar day!", cardFont, cardBrush, 600, 520);
            Thread.Sleep(300);
            cardBrush.Color = Color.DodgerBlue;
            aquariusCard.DrawString("May your life bring you to steady waters,", cardFont, cardBrush, 500, 500);
            aquariusCard.DrawString("have a stellar day!", cardFont, cardBrush, 600, 520);
            Thread.Sleep(300);
            cardBrush.Color = Color.Gray;
            aquariusCard.DrawString("May your life bring you to steady waters,", cardFont, cardBrush, 500, 500);
            aquariusCard.DrawString("have a stellar day!", cardFont, cardBrush, 600, 520);
            Thread.Sleep(300);
            cardBrush.Color = Color.Chartreuse;
            aquariusCard.DrawString("May your life bring you to steady waters,", cardFont, cardBrush, 500, 500);
            aquariusCard.DrawString("have a stellar day!", cardFont, cardBrush, 600, 520);
            Thread.Sleep(300);
            cardBrush.Color = Color.DodgerBlue;
            aquariusCard.DrawString("May your life bring you to steady waters,", cardFont, cardBrush, 500, 500);
            aquariusCard.DrawString("have a stellar day!", cardFont, cardBrush, 600, 520);
            Thread.Sleep(300);
            cardBrush.Color = Color.Gray;
            aquariusCard.DrawString("May your life bring you to steady waters,", cardFont, cardBrush, 500, 500);
            aquariusCard.DrawString("have a stellar day!", cardFont, cardBrush, 600, 520);
            Thread.Sleep(300);
            cardBrush.Color = Color.Chartreuse;
            aquariusCard.DrawString("May your life bring you to steady waters,", cardFont, cardBrush, 500, 500);
            aquariusCard.DrawString("have a stellar day!", cardFont, cardBrush, 600, 520);
            Thread.Sleep(300);
            cardBrush.Color = Color.DodgerBlue;
            aquariusCard.DrawString("May your life bring you to steady waters,", cardFont, cardBrush, 500, 500);
            aquariusCard.DrawString("have a stellar day!", cardFont, cardBrush, 600, 520);
            Thread.Sleep(450);
            bellPlayer.Stop();





        }

        private void AquariusCard_Load(object sender, EventArgs e)
        {
          
            
        }
    }
}
