using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bunifu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            if (panel1.Width == 63)
            {
                panel1.Visible = false;
                panel1.Width = 270;
                an1.ShowSync(panel1);
                an2.ShowSync(pictureBox1);
            }
            else
            {
                an1.Hide(pictureBox2);
                panel1.Visible = false;
                panel1.Width = 63;
                an1.ShowSync(panel1);

            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
