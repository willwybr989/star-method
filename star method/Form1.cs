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

namespace star_method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void StarField()
        {
            Graphics formGraphics = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Red, 10);
            Random randNum = new Random();
            int counter = 0;

            while (counter <= 2000)
            {

                int x = randNum.Next(0, this.Width);
                int y = randNum.Next(0, this.Height);
                int red = randNum.Next(1, 256);
                int green = randNum.Next(1, 256);
                int blue = randNum.Next(1, 256);

                SolidBrush drawBrush = new SolidBrush(Color.FromArgb(red, green, blue));



                formGraphics.DrawEllipse(drawPen, x, y, 30, 30);
                formGraphics.FillEllipse(drawBrush, x, y, 30, 30);


                counter++;
                Thread.Sleep(10);
            }
        }
    }
}
