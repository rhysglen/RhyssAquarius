using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        {
            //graphics object
            Graphics aquariusCard = this.CreateGraphics();

            //pens and brushes and fonts
            Pen aquariusPen = new Pen(Color.DodgerBlue, 30);
            SolidBrush aquariusBrush = new SolidBrush(Color.DodgerBlue);
            Font aquariusFont = new Font("Papyrus", 70, FontStyle.Bold);
            SolidBrush aquariusWord = new SolidBrush(Color.Black);

            //the colours of aquarius
            aquariusCard.DrawRectangle(aquariusPen, 0, 0, 910, 250);
            aquariusCard.FillRectangle(aquariusBrush, 0, 0, 910, 250);
            aquariusPen.Color = Color.Gray;
            aquariusBrush.Color = Color.Gray;
            aquariusCard.DrawRectangle(aquariusPen, 0, 250, 910, 250);
            aquariusCard.FillRectangle(aquariusBrush, 0, 250, 910, 250);
            aquariusPen.Color = Color.Chartreuse;
            aquariusBrush.Color = Color.Chartreuse;
            aquariusCard.DrawRectangle(aquariusPen, 0, 500, 910, 250);
            aquariusCard.FillRectangle(aquariusBrush, 0,500 , 910, 250);
            aquariusPen.Color = Color.Black;
            aquariusCard.DrawLine(aquariusPen, 0, 15, 910, 15);
            aquariusCard.DrawLine(aquariusPen, 0, 725, 910, 725);
            aquariusCard.DrawLine(aquariusPen, 0, 250, 910, 250);
            aquariusCard.DrawLine(aquariusPen, 0, 500, 910, 500);

            // Tite of the constellation 
            aquariusCard.DrawString("Aquarius", aquariusFont, aquariusWord, 210, 55);

            // My name
            Font rhyssFont = new Font("Pristina", 25, FontStyle.Regular);
            SolidBrush rhyssWord = new SolidBrush(Color.Black);
            aquariusCard.DrawString("Rhyss Glenfield", rhyssFont, rhyssWord, 50, 550);
            aquariusCard.DrawString("September 26, 2017", rhyssFont, rhyssWord, 50, 600);
            this.BackgroundImage = Properties.Resources.aquariusphoto;
            this.BackgroundImageLayout = ImageLayout.Center;


        }

        private void AquariusCard_Load(object sender, EventArgs e)
        {

        }
    }
}
