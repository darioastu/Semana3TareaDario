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
    public partial class Page1 : ContentPage
    {
        public Page1(string persona)
        {
            InitializeComponent();
              txtNombre.Text = persona;
        }

        private void btnSumar_Clicked(object sender, EventArgs e)
        {
           

        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            double parcial1;
            double parcial2;
            double notaFinal;
            //Capturar Exepciones 
            try
            {

                    string usuario = txtNombre.Text;

                    double nota1 = Convert.ToDouble(txtNota1.Text);
                    double examen1 = Convert.ToDouble(txtExamen1.Text);
                    double nota2 = Convert.ToDouble(txtNota2.Text);
                    double examen2 = Convert.ToDouble(txtExamen2.Text);
                if (nota1 <= 10 &  nota2 <= 10 & examen1 <= 10 & examen2 <= 10)
                {
                    ///
                    nota1 = nota1 * 0.3;
                    examen1 = examen1 * 0.2;
                    parcial1 = nota1 + examen1;
                    ///
                    nota2 = nota2 * 0.3;
                    examen2 = examen2 * 0.2;
                    parcial2 = nota2 + examen2;

                    //
                    notaFinal = parcial1 + parcial2;

                    if (notaFinal >= 7)
                    {
                        DisplayAlert("Estudiante: ", usuario, "Haz Aprobado");

                    }
                    else
                    {
                        DisplayAlert("Estudiante: ", usuario, "Haz Reprobado");
                    }
                }
                else
                {
                    DisplayAlert("Estudiante ", usuario, "Ingrese notas sobre 10 puntos");
                }
                }

                    catch (Exception ex)
                    {
                        DisplayAlert("Alerta", ex.Message, "Gracias");
                    }

        }

    }
}