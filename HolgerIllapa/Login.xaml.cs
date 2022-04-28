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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }
        
         private async void btnIngresar_Clicked(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "holger2022" && txtpass.Text == "uisrael2022")
            {


                await Navigation.PushAsync(new Registro(txtUsuario.Text));


            }
            else
            {
                await DisplayAlert("Error", "Usuario o Clave Incorrecta", "ok");
            }

        }
    }
}