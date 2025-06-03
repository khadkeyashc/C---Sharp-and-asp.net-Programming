using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp63
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rn= new Random();    
            int R, G, B;
            R=rn.Next(0,255);
            G=rn.Next(0,255);
            B=rn.Next(0,255);
            BackColor = Color.FromArgb(R, B, G);

        }
    }
}
