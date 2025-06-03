using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Add items to the ListBox
            listBox1.Items.Add("Item 1");
            listBox1.Items.Add("Item 2");
            listBox1.Items.Add("Item 3");

            // Add items to the ComboBox
            comboBox1.Items.Add("Option 1");
            comboBox1.Items.Add("Option 2");
            comboBox1.Items.Add("Option 3");

            // Set the selected item in the ComboBox
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Add an item to the ListBox
            listBox1.Items.Add("New Item");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Remove the selected item from the ListBox
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Display the selected item in a MessageBox
            MessageBox.Show("You selected: " + comboBox1.SelectedItem.ToString());
        }


    }
}
