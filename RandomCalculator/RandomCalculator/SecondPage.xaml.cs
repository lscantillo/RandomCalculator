using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RandomCalculator
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SecondPage : ContentPage
	{
		public SecondPage (String value)
		{
            Title ="Operaciones";
			InitializeComponent ();
            int counter = 1;
            titulo.Text = "Operación " + counter + "de " + value + ".";
            Random rand1 = new Random();
            Random rand2 = new Random();
            Random rand3 = new Random();
            number1.Text = rand1.Next(0, 100).ToString();
            number2.Text = rand2.Next(0, 50).ToString();

            if (rand3.Next(0, 2) == 1)
            {
                operacion.Text = "+";
            }
            else
            {
                operacion.Text = "-";
            }

        }

        //void Clickrespuesta(object sender, System.EventArgs e)
        void Clickrespuesta(String value, object sender, System.EventArgs e)
        {
            Random rand1 = new Random();
            Random rand2 = new Random();
            Random rand3 = new Random();
            //int x = Convert.ToInt32(value);
            //while (int i = 0; i< x; i++) { }
            number1.Text = rand1.Next(0, 100).ToString();
            number2.Text = rand2.Next(0, 50).ToString();

            if (rand3.Next(0, 2) == 1)
            {
                operacion.Text = "+";
            }
            else
            {
                operacion.Text = "-";
            }
            etresultado.Text = "";
           



        }
    }
}