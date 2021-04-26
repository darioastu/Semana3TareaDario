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
            string clave = txtPass.Text;

             if (persona!= "estudiante2021" | clave != "uisrael2021")
            {
               await DisplayAlert("Alerta", "Usuario o contraseña incorrectos", "Cerrar");
                return;
            }
            await Navigation.PushAsync(new Page1(persona));
        }


      
           
        
    }
}