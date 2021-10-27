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
    public partial class Registro : ContentPage
    {
        public Registro(string usuario, string log)
        {
            InitializeComponent();
            lblusuario.Text = usuario;
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            double cuota = Convert.ToDouble(txtmonto.Text);
            double total;
            double mensual;

            if (cuota>=1 && cuota<=1800)
            {
                total = 1800 - cuota;
                double porcentaje = 1800 * 0.05;
                mensual = (total / 3) + porcentaje;
                txttotal.Text = mensual.ToString();
            }
            else
            {
                DisplayAlert("Error", "Monto incorrecto", "Ok");
            }

            
        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            string usuario = txtusuario.Text;
            string nombre = txtnombre.Text;
            string total = txttotal.Text;



            await DisplayAlert("MENSAJE", "Elemento guardado con exito", "OK");

            await Navigation.PushAsync(new Resumen(lblusuario.Text, nombre, total));
        }
    }
}