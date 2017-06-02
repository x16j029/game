using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game
{
    public partial class Form1 : Form
    {
        int spaed = 5;
        int moveX;
        int moveY;
        int moveX2;
        int moveY2;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            moveY -= spaed;
            //moveX = 0;
        }

        private void button4_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            moveY += spaed;
            //moveX = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            moveX -= spaed;
            //moveY = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            moveX += spaed;
            //moveY = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            pictureBox1.Left += moveX;
            pictureBox1.Top += moveY;
            pictureBox3.Left += moveX2;
            pictureBox3.Top += moveY2;

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                moveY-= spaed;
                moveY2 -= spaed;
            }
            else if (e.KeyCode == Keys.Down)
            {
                moveY += spaed;
                moveY2 += spaed;
            }
            else if (e.KeyCode == Keys.Right)
            {
                moveX += spaed;
                moveX2 += spaed;
            }
            else if (e.KeyCode == Keys.Left)
            {
                moveX -= spaed;
                moveX2 -= spaed;
            }
            if (e.KeyCode == Keys.Enter)
            {
                moveY2 -= spaed;
            }
            if (e.KeyCode == Keys.Space)
            {
                pictureBox3.Left = pictureBox1.Left;
                pictureBox3.Top = pictureBox1.Top;
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                moveY = 0;
                moveY2 = 0;
            }
            else if (e.KeyCode == Keys.Down)
            {
                moveY = 0;
                moveY2 = 0;
            }
            else if (e.KeyCode == Keys.Right)
            {
                moveX = 0;
                moveX2 = 0;
            }
            else if (e.KeyCode == Keys.Left)
            {
                moveX = 0;
                moveX2 = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
