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
        //Rhyss Glenfield September 20, 2017
        private void AquariusCard_Click(object sender, EventArgs e)
        {// photo

            BackgroundImage = null;
            Refresh();

            //graphics object
            Graphics aquariusCard = this.CreateGraphics();

            //pens and brushes and fonts
            Pen aquariusPen = new Pen(Color.DodgerBlue, 30);
            SolidBrush aquariusBrush = new SolidBrush(Color.DodgerBlue);
            Font aquariusFont = new Font("Papyrus", 70, FontStyle.Bold);
            SolidBrush aquariusWord = new SolidBrush(Color.Black);
            Pen starPen = new Pen(Color.Yellow, 5);
            SolidBrush starBrush = new SolidBrush(Color.Yellow);
            Pen linePen = new Pen(Color.MediumBlue, 3);

            //the colours of aquarius
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
            aquariusCard.DrawString("Aquarius", aquariusFont, aquariusWord, 210, 55);

            // My name
            Font rhyssFont = new Font("Pristina", 25, FontStyle.Regular);
            SolidBrush rhyssWord = new SolidBrush(Color.Black);
            aquariusCard.DrawString("Rhyss Glenfield", rhyssFont, rhyssWord, 50, 550);
            aquariusCard.DrawString("September 26, 2017", rhyssFont, rhyssWord, 50, 600);

            //pausing
            
            Thread.Sleep(50);
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

            //the Stars
            aquariusCard.DrawEllipse(starPen, 455, 105, 5, 5);
            aquariusCard.FillEllipse(starBrush, 455, 105, 5, 5);
            starPen.Color = Color.Black;
            starBrush.Color = Color.Black;
            Thread.Sleep(200);
            starPen.Color = Color.Yellow;
            starBrush.Color = Color.Yellow;
            aquariusCard.DrawEllipse(starPen, 500, 375, 7, 7);
            aquariusCard.FillEllipse(starBrush, 500, 375, 7, 7);
            starPen.Color = Color.Black;
            starBrush.Color = Color.Black;
            Thread.Sleep(200);
            starPen.Color = Color.Yellow;
            starBrush.Color = Color.Yellow;
            aquariusCard.DrawEllipse(starPen, 170, 250, 5, 5);
            aquariusCard.FillEllipse(starBrush, 170, 250, 5, 5);
            starPen.Color = Color.Black;
            starBrush.Color = Color.Black;
            Thread.Sleep(200);
            starPen.Color = Color.Yellow;
            starBrush.Color = Color.Yellow;
            aquariusCard.DrawEllipse(starPen, 195, 350, 10, 10);
            aquariusCard.FillEllipse(starBrush, 195, 350, 10, 10);
            starPen.Color = Color.Black;
            starBrush.Color = Color.Black;
            Thread.Sleep(200);
            starPen.Color = Color.Yellow;
            starBrush.Color = Color.Yellow;
            aquariusCard.DrawEllipse(starPen, 800, 280, 10, 10);
            aquariusCard.FillEllipse(starBrush, 800, 280, 10, 10);
            starPen.Color = Color.Black;
            starBrush.Color = Color.Black;
            Thread.Sleep(200);
            starPen.Color = Color.Yellow;
            starBrush.Color = Color.Yellow;
            aquariusCard.DrawEllipse(starPen, 115, 520, 5, 5);
            aquariusCard.FillEllipse(starBrush, 115, 520, 5, 5);
            starPen.Color = Color.Black;
            starBrush.Color = Color.Black;
            Thread.Sleep(200);
            starPen.Color = Color.Yellow;
            starBrush.Color = Color.Yellow;
            aquariusCard.DrawEllipse(starPen, 375, 75, 5, 5);
            aquariusCard.FillEllipse(starBrush, 375, 75, 5, 5);
            starPen.Color = Color.Black;
            starBrush.Color = Color.Black;
            Thread.Sleep(200);
            starPen.Color = Color.Yellow;
            starBrush.Color = Color.Yellow;
            aquariusCard.DrawEllipse(starPen, 405, 65, 10, 10);
            aquariusCard.FillEllipse(starBrush, 405, 65, 10, 10);
            starPen.Color = Color.Black;
            starBrush.Color = Color.Black;
            Thread.Sleep(200);
            starPen.Color = Color.Yellow;
            starBrush.Color = Color.Yellow;
            aquariusCard.DrawEllipse(starPen, 100, 200, 25, 25);
            aquariusCard.FillEllipse(starBrush, 100, 200, 25, 25);
            starPen.Color = Color.Black;
            starBrush.Color = Color.Black;
            Thread.Sleep(200);
            starPen.Color = Color.Yellow;
            starBrush.Color = Color.Yellow;     
            aquariusCard.DrawEllipse(starPen, 175, 390, 5, 5);
            aquariusCard.FillEllipse(starBrush, 175, 390, 5, 5);
            starPen.Color = Color.Black;
            starBrush.Color = Color.Black;
            Thread.Sleep(200);
            starPen.Color = Color.Yellow;
            starBrush.Color = Color.Yellow;
            aquariusCard.DrawEllipse(starPen, 470, 275, 7, 7);
            aquariusCard.FillEllipse(starBrush, 470, 275, 7, 7);
            starPen.Color = Color.Black;
            starBrush.Color = Color.Black;
            Thread.Sleep(200);
            starPen.Color = Color.Yellow;
            starBrush.Color = Color.Yellow;
            aquariusCard.DrawEllipse(starPen, 500, 75, 7, 7);
            aquariusCard.FillEllipse(starBrush, 500, 75, 7, 7);
            starPen.Color = Color.Black;
            starBrush.Color = Color.Black;
            Thread.Sleep(200);
            starPen.Color = Color.Yellow;
            starBrush.Color = Color.Yellow;
            aquariusCard.DrawEllipse(starPen, 610, 210, 10, 10);
            aquariusCard.FillEllipse(starBrush, 610, 210, 10, 10);
            starPen.Color = Color.Black;
            starBrush.Color = Color.Black;
            Thread.Sleep(200);
            starPen.Color = Color.Yellow;
            starBrush.Color = Color.Yellow;

        }

        private void AquariusCard_Load(object sender, EventArgs e)
        {
          
            
        }
    }
}
