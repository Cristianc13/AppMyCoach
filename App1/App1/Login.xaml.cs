using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            if (entusuar.Text=="1" && entcontra.Text=="1")
            {

                await Navigation.PushAsync(new Home());
                entusuar.Text= string.Empty;
                entcontra.Text=string.Empty;
            }
            else
            {
                await DisplayAlert("Error", "Datos incorrectos", "Reintentar");
                entusuar.Text= string.Empty;
                entcontra.Text=string.Empty;
            }
        }
    }
}