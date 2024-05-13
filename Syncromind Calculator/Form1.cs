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


        
        //Este metodo verifica su result no es nulo, una vez verificado. Se simula un click al Button_Equals.
        //Si result es igual a 0, significa que es la primera operacion realizada. En ese caso se asigna el valor de TextDisplay1 a la variable result.
        //Se obtiene una referencia de del boton que desencadena el evento utilizando 'sender'
        //Se asigna el texto del boton a la variable operacion
        //Se marca la variable enterValue como true. Para indicar que se espera agregar otro valor
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


        //Se guarda el segundo numero ingresado en la Variable secNum,
        //Actualiza el cuadro de texto TextDisplay2 para mostrar la operacion completa, concatenando el contenido actual de TextDisplay2 con el secNum y el signo =
        //Verifica si TextDisplay1 no esta vacio, si el texto en Text Display1 es igual a 0, se borra el contenido del cuadro TextDisplay2
        //Se utiliza un switch para determinar que operacion matemaitca se debe realizar.
        //Realiza la operacion entre el primer numero, la operacion y el segundo numero

            private void Button_Equals_Click(object sender, EventArgs e)
        {
            secNum = TextDisplay1.Text;
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
        
        

       //Este metodo verifica si el texto dentro de TextDisplay1 es 0 o si enterValue es true
       //Si los criterios se cumplen borra el contenido de TextDisplay1 en preparacion para un nuevo numero
       //Establece en false la varibale enterValue para indicar que no es necesario ingresar nuevo valor
       //Obtiene una referencia al boton que desencadeno el evento 
       //Si el texto del button es decimal verifica si textDisplay ya contiene un punto decimal, si no es asi no lo agrega
       //Si no hay punto decimal, lo agrega
        private void Button_Number_Clicks(object sender, EventArgs e)
        {

            if (TextDisplay1.Text == "0" || enterValue) TextDisplay1.Text = string.Empty;

            enterValue= false;

            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (TextDisplay1.Text.Contains("."))
                    TextDisplay1.Text = TextDisplay1.Text + button.Text;
                
            }

            else    TextDisplay1.Text = TextDisplay1.Text + button.Text;
            




        }

        }
}
