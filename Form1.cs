using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class TicTac : Form
    {
        PictureBox[,] field = new PictureBox[3, 3];
        public TicTac()
        {
            InitializeComponent();
        }
        int player = 0;
        int computer = 0;
        string[] imageName =
        {
            "emp.jpg",
            "cross.jpg",
            "zero.jpg"
        };

        void MainPole()
        {
            int dx = 0;
            int dy = 0;
            int pictureSize = 60;
            string namePict = "P_";
            for (int y = 0; y < 3; y++)
            {
                for (int x = 0; x < 3; x++)
                {
                    field[y,x] = new PictureBox()
                    {
                        Name = namePict + y+","+x,                 
                        Height = pictureSize,                           
                        Width = pictureSize,                           
                        Image = Image.FromFile("emp.jpg"),       
                        SizeMode = PictureBoxSizeMode.StretchImage, 
                        Location = new Point(dy, dx)
                    };

                    field[y,x].Click += Picture_Click;

                    panel3.Controls.Add(field[y,x]); 
                    dx += pictureSize; 
                }
                dy += pictureSize; 
                dx = 0; 
            }
        }
        private void Picture_Click(object sender, EventArgs e)
        {

         }

        private void TicTac_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            MainPole();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            player = 1;
            computer = 2;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            player = 2;
            computer = 1;
        }
    }
}
