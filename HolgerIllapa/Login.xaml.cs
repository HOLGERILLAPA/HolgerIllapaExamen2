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
        private void Button_Clicked(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "holger2022" && txtpass.Text == "uisrael2022")
            {

                DisplayAlert("BIENVENIDOS","Registro de Estudiante", "OK");
                Navigation.PushAsync(new Registro());


            }
            else
            {
                DisplayAlert("Error", "Usuario o Clave Incorrecta", "ok");
            }
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {

        }
    }
}