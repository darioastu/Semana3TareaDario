using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Semana3TareaDario
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnSuma_Clicked(object sender, EventArgs e)
        {   
            //Capturar Exepciones 
            try
            {
                double dato1 = Convert.ToDouble(txtDato1.Text);
                double dato2 = Convert.ToDouble(txtDato2.Text);
                double suma = dato1 + dato2;
                txtResultado.Text = suma.ToString();
            }

            catch (Exception ex)
            {
                DisplayAlert("Alerta",ex.Message, "Gracias");
            }
          

          
        }

        private void btnAbrir_Clicked(object sender, EventArgs e)
        {

        }
    }
}

