using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp41
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "I Am Yash";
            this.BackColor = Color.Purple;
            this.Size = new Size(300,30);
            this.Location = new Point(300, 600);
            this.MinimizeBox=false;
        }
    }
}
