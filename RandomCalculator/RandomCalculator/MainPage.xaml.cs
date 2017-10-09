using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RandomCalculator
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
            Title = "Main Page";
            InitializeComponent();
           
        }

        
        void Clickstart(object sender, System.EventArgs e)
        {
            var number = new Label();
            number.SetBinding(Label.TextProperty, new Binding("SelectedItem", source: picker));
            Navigation.PushAsync(new SecondPage(number.Text.ToString()));

        }

       

    }
}
