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
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

       void ImageButton_Clicked(object sender, EventArgs e)
        {
            var red   = Color.FromHex("#f1c40f") ;
            btnfeliz.BackgroundColor=red;

            var gris   = Color.FromHex("#dfe6e9");
            btnllorando.BackgroundColor= gris;
            btntriste.BackgroundColor= gris;
            btnreinicia.BackgroundColor=gris;
        }

        private void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            var red   = Color.FromHex("#1abc9c");
            btntriste.BackgroundColor=red;

            var gris   = Color.FromHex("#dfe6e9");
            btnfeliz.BackgroundColor= gris;
            btnllorando.BackgroundColor= gris;
            btnreinicia.BackgroundColor=gris;
        }

        private void ImageButton_Clicked_2(object sender, EventArgs e)
        {
            var red   = Color.FromHex("#3498db");
            btnllorando.BackgroundColor=red;

            var gris   = Color.FromHex("#dfe6e9");
            btnfeliz.BackgroundColor= gris;
            btntriste.BackgroundColor= gris;
            btnreinicia.BackgroundColor=gris;
        }

        private void ImageButton_Clicked_3(object sender, EventArgs e)
        {

            var gris   = Color.FromHex("#dfe6e9");
            btnfeliz.BackgroundColor= gris;
            btnllorando.BackgroundColor= gris;
            btntriste.BackgroundColor= gris;
            btnreinicia.BackgroundColor=gris;

        }
    }
}