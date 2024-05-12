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

        private void Math_Operations(object sender, EventArgs e)
        {
            if (result != 0)ButtonEquals.PerformClick();
            else result = Double.Parse(TextDisplay2.Text);
            Button button = (Button)sender;
            operation = button.Text;
            enterValue = true;
            if (TextDisplay2.Text != "0") { 

                TextDisplay2.Text= fstNumber=$"{result}{operation}";
                TextDisplay1.Text = string.Empty;
            }
        }

        private void Button_Equals_Click(object sender, EventArgs e)
        {
            secNum=TextDisplay1.Text;
            TextDisplay2.Text = $"{TextDisplay2.Text}{TextDisplay1.Text}=";
            if (TextDisplay1.Text!=string.Empty)
            {
                if (TextDisplay1.Text == "0") TextDisplay2.Text = string.Empty;
                switch (operation) {

                    case "+":
                        TextDisplay1.Text=(result + Double.Parse(TextDisplay1.Text)).ToString(); 
                        break;

                    case "-":
                        TextDisplay1.Text = (result - Double.Parse(TextDisplay1.Text)).ToString();
                        break;

                    case "*":
                        TextDisplay1.Text = (result * Double.Parse(TextDisplay1.Text)).ToString();
                        break;

                    case "/":
                        TextDisplay1.Text = (result / Double.Parse(TextDisplay1.Text)).ToString();
                        break;

                    default:TextDisplay2.Text = $"{TextDisplay1.Text}";
                        break;
                }
            }
        }

        private void Button_Number_Clicks(object sender, EventArgs e)
        {

            if (TextDisplay1.Text == "0" || enterValue) TextDisplay1.Text = string.Empty;
            
            enterValue = false;
            Button button = (Button) sender;
            if (button.Text == ".")
            {
                if (TextDisplay1.Text.Contains("."))
                    TextDisplay1.Text = TextDisplay1.Text + button.Text;
            }
            else TextDisplay1.Text = TextDisplay1.Text + button.Text;
            
        }
    }
}
