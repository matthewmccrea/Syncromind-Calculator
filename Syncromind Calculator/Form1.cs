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
        string fstNum, secNum;
        bool enterValue = false;
        public Form1()
        {
            InitializeComponent();
        }



        // This method checks if result is not null, once verified. A click to the Button_Equals is simulated.
        // If result equals 0, it means it's the first operation performed. In that case, the value of TextDisplay1 is assigned to the variable result.
        // A reference to the button that triggers the event is obtained using 'sender'.
        // The button's text is assigned to the variable operation.
        // The enterValue variable is marked as true, indicating that another value is expected.
        private void Math_Operations(object sender, EventArgs e)
        {
            if (result != 0) ButtonEquals.PerformClick();
            else result = Double.Parse(TextDisplay1.Text);

            Button button = (Button)sender;
            operation = button.Text;
            enterValue = true;
            if (TextDisplay1.Text!="0")
            {
                TextDisplay2.Text = fstNum = $"{result}{operation}";
                TextDisplay1.Text = string.Empty;
            }


        }


        // The second entered number is stored in the variable secNum.
        // Updates the TextDisplay2 text box to display the complete operation, concatenating the current content of TextDisplay2 with secNum and the = sign.
        // Checks if TextDisplay1 is not empty, if the text in TextDisplay1 is equal to 0, the content of the TextDisplay2 text box is cleared.
        // A switch statement is used to determine which mathematical operation should be performed.
        // It performs the operation between the first number, the operation, and the second number.

        bool equalPressed = false;

        private void Button_Equals_Click(object sender, EventArgs e)
        {
            // checks if "=" was pressed
            if (!equalPressed)
            {
                secNum = TextDisplay1.Text;
                TextDisplay2.Text = $"{TextDisplay2.Text}{TextDisplay1.Text}=";
                if (!string.IsNullOrEmpty(TextDisplay1.Text))
                {
                    if (TextDisplay1.Text == "0") TextDisplay2.Text = string.Empty;
                    switch (operation)
                    {
                        case "+":
                            TextDisplay1.Text = (result + Double.Parse(TextDisplay1.Text)).ToString();
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
                        default:
                            TextDisplay2.Text = $"{TextDisplay1.Text}";
                            break;
                    }
                }
                // Flag that records if the equal button was pressed
                equalPressed = true;
            }
            else
            {
                // If "=" was pressed the value of Text Display is String.Empty
                TextDisplay2.Text = string.Empty;
                
            }
        }
        // This method checks if there is at least one character in TextDisplay1.
        // Then it removes the last character from the string.
        // It checks if TextDisplay1 is empty once the character is removed.
        // If the text box is empty, it sets it to 0.
        private void Button_Erase_Click(object sender, EventArgs e)
        {
            if (TextDisplay1.Text.Length > 0)
                TextDisplay1.Text = TextDisplay1.Text.Remove(TextDisplay1.Text.Length - 1,1);
            if (TextDisplay1.Text == string.Empty) TextDisplay1.Text = "0";
            
                
        


        }

        ////This method sets DisplayText1 to 0 and DisplayText2 to Empty
        private void Button_C_Click(object sender, EventArgs e)
        {
            TextDisplay1.Text = "0";
            TextDisplay2.Text = string.Empty;
            result = 0;
            equalPressed = false;

        }

        //This method set sonly DisplayText1 to 0
        private void Button_CE_Click(object sender, EventArgs e)
        {
            TextDisplay1.Text = "0";
            equalPressed = false;
        }

        //This method exits App
        private void Button_Exit_App(object sender, EventArgs e)
        {
            Application.Exit();
        }






        // This method checks if the text inside TextDisplay1 is 0 or if enterValue is true
        // If the criteria are met, it clears the content of TextDisplay1 in preparation for a new number
        // Sets the variable enterValue to false to indicate that it's not necessary to input a new value
        // Gets a reference to the button that triggered the event
        // If the button's text is decimal, it checks if TextDisplay already contains a decimal point, if not, it adds it
        // If there is no decimal point, it adds one
        private void Button_Number_Clicks(object sender, EventArgs e)
        {
            if (TextDisplay1.Text == "0" || enterValue)
                TextDisplay1.Text = string.Empty;

            enterValue = false;

            Button button = (Button)sender;
            if (button.Text == ",")
            {
                // The while cicle check's if there is a coma in TextDisplay1. If there's a coma the cicle ends.
                while (!TextDisplay1.Text.Contains(","))
                {
                    TextDisplay1.Text = TextDisplay1.Text + button.Text;
                   
                    break;
                }
            }
            else
            {
                TextDisplay1.Text = TextDisplay1.Text + button.Text;
            }
        }

    }
}
