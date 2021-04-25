using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana3TareaDario
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VentanaUno : ContentPage
    {
        public VentanaUno()
        {
            InitializeComponent();
        }

        private async void btnIngreso_Clicked(object sender, EventArgs e)
        {
            string persona = txtUser.Text;
            await Navigation.PushAsync(new Page1(persona));
           
        }
    }
}