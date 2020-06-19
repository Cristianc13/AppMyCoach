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
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }
           private void ImageButton_Clicked(object sender, EventArgs e)
        {

        }
        private void btnyoga_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Yoga());
        }


        private void btcaminando_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Caminata());
        }

        private void btncardio_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Cardio());
        }

        private void btnciclismo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Ciclismo());
        }

        private void btnmeditando_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Meditacion());
        }
    }
}