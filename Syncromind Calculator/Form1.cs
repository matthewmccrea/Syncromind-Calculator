using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Syncromind_Calculator
{
    public partial class Form1 : Form

        

    {

        Double result = 0;
        string operation = string.Empty;
        string fstNumber, secNum;
        bool enterValue = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelTitle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void Button_Number_Clicks(object sender, EventArgs e)
        {

            if (TxtDisplay1.Text == "0" || enterValue) TxtDisplay1.Text = string.Empty;
            
            enterValue = false;
            Button button = new Button();
            if (button.Text == ".")
            {
                if (TxtDisplay1.Text.Contains("."))
                    TxtDisplay1.Text = TxtDisplay1.Text + button.Text;
            }
            else TxtDisplay1.Text = TxtDisplay1.Text + button.Text;
            { }
        }
    }
}
