using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonReplaceCheck
{
    public partial class Form1 : Form
    {
        Button first, second;
        public Form1()
        {
            InitializeComponent();
        }

        int a, b,  i = 0, j = 0;

        private void button4_Click(object sender, EventArgs e)
        {

        }

        int aLocationX, bLocationX, aLocationY, bLocationY;

        private void timer1_Tick(object sender, EventArgs e)
        {
            //timer1.Stop();
            if(j<5)
            {
                first.Location = new Point(first.Location.X, first.Location.Y + 10);
                second.Location = new Point(second.Location.X, second.Location.Y - 10);
                j++;
            }
             else if(aLocationY<=button2.Location.Y)
            {
                timer1.Stop();
            }
            else if (aLocationX >= button2.Location.X)
            {
                first.Location = new Point(first.Location.X, first.Location.Y - 10);
                second.Location = new Point(second.Location.X, second.Location.Y + 10);
            }
            else
            {
                first.Location = new Point(first.Location.X + 10, first.Location.Y);
                second.Location = new Point(second.Location.X - 10, second.Location.Y);
            }
            i++;
            if (i == 5)
            {
               // timer1.Stop();
            }
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Int32.TryParse(button1.Text, out a);
            Int32.TryParse(button2.Text, out b);

            aLocationX = button1.Location.X;
            aLocationY = button1.Location.Y;

            bLocationX = button2.Location.X;
            bLocationY = button2.Location.Y;
            first = button1;
            second = button2;
            timer1.Start();
        }
    }
}
