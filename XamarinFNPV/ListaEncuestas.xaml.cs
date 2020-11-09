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
    public partial class ListaEncuestas : ContentPage
    {
        public ListaEncuestas()
        {
            BackgroundImageSource = "drawable/logofundacionparavivirLOGEO.png";
            InitializeComponent();

            
        }
    }
}