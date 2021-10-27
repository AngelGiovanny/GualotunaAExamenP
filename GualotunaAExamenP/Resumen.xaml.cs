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
    public partial class Resumen : ContentPage
    {
        public Resumen(string usuario, string nombre, string total)
        {
            InitializeComponent();

            lblusuario.Text = usuario;

            //lbltotal.Text = total;
            //txtusuario.Text = usuario;

            txtnombre.Text = nombre;
            txttotal.Text = total;
        }
    }
}