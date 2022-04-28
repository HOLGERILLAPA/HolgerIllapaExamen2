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
        double porcentaje;
        double Pagomensual;
       
        
               public Registro(string nombre)
        {
            InitializeComponent();

           lblUsuario.Text += nombre;
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)

        {
            if (int.Parse(txtCuota.Text) >= 3000)

             {
                DisplayAlert("Error", "La cuota inicial debe ser menor que 3000", "Cerrar");
                return;

            }
            porcentaje = 3000 * 0.05;
            Pagomensual = ((3000 - double.Parse(txtCuota.Text)))/ 5 + porcentaje;
            txtPagoMensual.Text = Pagomensual.ToString();


        }

       
        private async void bntGuarde_Clicked(object sender, EventArgs e)
        {
            {
                if (txtNombre.Text == null)
                {
                    await DisplayAlert("Error", "Debe ingresar un nombre", "Cerrar");
                    return;
                }
                await DisplayAlert("Guardado", "Elemento gardado con éxito", "Ok");
                double total = Convert.ToDouble(txtCuota.Text) + Pagomensual * 5;
                await Navigation.PushAsync(new Resumen(txtNombre.Text, lblUsuario.Text, total));
            }
        }
    }
}