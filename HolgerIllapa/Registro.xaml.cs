using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HolgerIllapa
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage

    {
        Double porcentaje;
        double Pagomensual;
        public Registro()
        {
            InitializeComponent();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)

        {
            if (int.Parse(TxtMontoin.Text) >= 3000)
             {
                DisplayAlert("Error", "La cuota inicial debe ser menor que 3000", "Cerrar");
                return;

            }
            porcentaje = 3000 * 0.05;
            Pagomensual = ((3000 - double.Parse(TxtMontoin.Text)))/ 5 + porcentaje;
            TxtMontoin.Text = TxtPagoMensual.ToString();

        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)

        {
            if (TexNombre.Text == null)
            {
                await DisplayAlert("Error", "Debe ingresar un nombre", "Cerrar");
                return;
            }
            await DisplayAlert("Guardado", "Elemento gardado con éxito", "Ok");
            double total = Convert.ToDouble(TxtMontoin.Text) + Pagomensual * 5;
            //await Navigation.PushAsync(new Resumen(TexNombre.Text, total));
        }
    }
}