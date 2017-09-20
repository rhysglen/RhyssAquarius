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

        private void AquariusCard_Click(object sender, EventArgs e)
        {
            Graphics aquariusCard = this.CreateGraphics();
            Pen aquariusPen = new Pen(Color.DodgerBlue);
            SolidBrush aquariusBrush = new SolidBrush(Color.DodgerBlue);
            aquariusCard.DrawRectangle(aquariusPen, 0, 0, 910, 175);
            aquariusCard.FillRectangle(aquariusBrush, 0, 0, 910, 175);
            aquariusPen.Color = Color.Gray;
            aquariusBrush.Color = Color.Gray;
            aquariusCard.DrawRectangle(aquariusPen, 0, 150, 910, 175);
            aquariusCard.FillRectangle(aquariusBrush, 0, 150, 910, 175);
            aquariusPen.Color = Color.Chartreuse;
            aquariusBrush.Color = Color.Chartreuse;
            aquariusCard.DrawRectangle(aquariusPen, 0, 300, 910, 175);
            aquariusCard.FillRectangle(aquariusBrush, 0, , 910, 175);


        }

        private void AquariusCard_Load(object sender, EventArgs e)
        {

        }
    }
}
