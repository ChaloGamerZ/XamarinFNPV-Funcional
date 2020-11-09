using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFNPV
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Principal : ContentPage
    {
        public Principal()
        {
            BackgroundImageSource = "drawable/logofundacionparavivirLOGEO.png";
            InitializeComponent();
            btnEncuestar.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new HomePage());
            };

            btnListarEncuestas.Clicked += (sender, e) =>
            {
                
                Navigation.PushAsync(new ListaEncuestas());
            };
            
            

        }

        
    }
}