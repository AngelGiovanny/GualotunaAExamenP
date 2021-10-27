using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GualotunaAExamenP
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
            string usuario = txtusuario.Text;
            string pass = txtlog.Text;

            string usu = "estudiante2021";
            string log = "uisrael2021";

            if (usuario == usu && pass == log)
            {
                await Navigation.PushAsync(new Registro(usuario, pass));
            }
            else
            {
                await DisplayAlert("Advertencia", "usuario o contraseña invalida", "OK");
            }

        }
    }
}