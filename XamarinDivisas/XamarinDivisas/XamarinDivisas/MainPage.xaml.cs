using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinDivisas
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Padding = Device.OnPlatform(
                            new Thickness(10),
                            new Thickness(20),
                            new Thickness(30));

            convertButton.Clicked += ConvertButton_Clicked;
            
        }

        private async void ConvertButton_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(pesosEntry.Text))
            {
                await DisplayAlert("Error", "Debe ingresar un valor", "Aceptar");
                return;
            }

            decimal pesos = decimal.Parse(pesosEntry.Text);
            decimal dollars = pesos / 3740.14M;
            decimal euros = pesos / 4486.38M;
            decimal pounds = pesos / 5158.99M;

            dollarsEntry.Text = string.Format("{0:N2}", dollars);
            eurosEntry.Text = string.Format("{0:N2}", euros);
            poundsEntry.Text = string.Format("{0:N2}", pounds);

        }
    }
}
