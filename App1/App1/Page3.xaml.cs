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
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            


                        if (enta.Text=="" || entp.Text=="")
            {

               DisplayAlert("Error", "Datos incorrectos", "Reintentar");
                 this.enta.Text=string.Empty;
            this.entp.Text=string.Empty;
            }
            else
            {
             double a= Convert.ToInt32(enta.Text);
            double p= Convert.ToInt32(entp.Text);
            double a2= (a*a)/100;
            double p2= p*100;
            double imc= p2/a2;
            string imC=Convert.ToString(imc);
            DisplayAlert("IMC",imC,"Aceptar");
            this.enta.Text=string.Empty;
            this.entp.Text=string.Empty;
            }
        }
    }
}