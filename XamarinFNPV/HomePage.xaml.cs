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
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            BackgroundImageSource = "drawable/logofundacionparavivirLOGEO.png";
            AgregarEncuesta.Clicked += AgregarEncuesta_Clicked;
            //using (var datos = new DataAccess())
            //{
            //    DATOSLISTA.ItemsSource = datos.getEncuesta();
            //}

        }

        public async void AgregarEncuesta_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NombreBrigada.Text))
            {
                await DisplayAlert("ERROR", "DEBE INGRESAR EL CAMPO NOMBRE BRIGADA", "Aceptar");
                NombreBrigada.Focus();
                return;
            }

            if (string.IsNullOrEmpty(NombreBrigadista.Text))
            {
                await DisplayAlert("ERROR", "DEBE INGRESAR EL CAMPO NOMBRE BRIGADISTA", "Aceptar");
                NombreBrigadista.Focus();
                return;
            }

            Navigation.PushModalAsync(new Principal());

            Encuesta encuesta = new Encuesta {
                FechaEncuesta = FechaEncuestax.Date,
            NombreBrigada = NombreBrigada.Text,
            NombreBrigadista = NombreBrigadista.Text,
            };

            //using (var datos = new DataAccess())
            //{
            //    datos.InserEncuesta(encuesta);
            //    DATOSLISTA.ItemsSource = datos.getEncuesta();
            //}

        }

        private void startDatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {

        }

        private void startDatePicker_Unfocused(object sender, FocusEventArgs e)
        {

        }

        private void startDatePicker_DateSelected_1(object sender, DateChangedEventArgs e)
        {

        }
    }
}