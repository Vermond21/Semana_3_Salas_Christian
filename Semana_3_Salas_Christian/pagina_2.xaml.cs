using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana_3_Salas_Christian
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class pagina_2 : ContentPage
    {
        public pagina_2()
        {
            InitializeComponent();

            lbluser.Text = "Usuario: " + user;
            lblpass.Text = "Contraseña: " + pass;
        }

        private void btnParcial1_Clicked(object sender, EventArgs e)
        {
            try
            {
                double notaS1 = Convert.ToDouble(txtNotaS1.Text);
                double notaE1 = Convert.ToDouble(txtEx1.Text);
                double notaP1 = Convert.ToDouble(txtNotaP1.Text);

                if (notaS1 <= 10 && notaE1 <= 10)
                {
                    notaS1 *= 0.3;
                    notaE1 *= 0.2;
                    notaP1 = notaS1 + notaE1;
                    txtNotaP1.Text = notaP1.ToString();

                }
                else
                {
                    DisplayAlert("Alerta", "Ingreso solo números del 0 al 10", "OK");
                }


            }
            catch (Exception ex)
            {

                DisplayAlert("Error", ex.Message, "Cerrar");
            }
        }

        private void btnParcial2_Clicked(object sender, EventArgs e)
        {
            try
            {
                double notaS2 = Convert.ToDouble(txtNotaS2.Text);
                double notaE2 = Convert.ToDouble(txtEx2.Text);
                double notaP2 = Convert.ToDouble(txtNotaP2.Text);

                if (notaS2 <= 10 && notaE2 <= 10)
                {
                    notaS2 *= 0.3;
                    notaE2 *= 0.2;
                    notaP2 = notaS2 + notaE2;
                    txtNotaP2.Text = notaP2.ToString();

                }
                else
                {
                    DisplayAlert("Alerta", "Ingreso solo números del 0 al 10", "OK");
                }


            }
            catch (Exception ex)
            {

                DisplayAlert("Error", ex.Message, "Cerrar");
            }
        }

        private void btnNotaF_Clicked(object sender, EventArgs e)
        {
            try
            {
                double notaP1 = Convert.ToDouble(txtNotaP1.Text);
                double notaP2 = Convert.ToDouble(txtNotaP2.Text);
                double notaF = Convert.ToDouble(txtNotaF.Text);
                notaF = notaP1 + notaP2;

                if (notaF >= 7)
                {
                    txtNotaF.Text = "Su Nota es " + notaF.ToString() + " Aprobado";
                }
                else if (notaF >= 5 && notaF <= 6.9)
                {
                    txtNotaF.Text = "Su Nota es " + notaF.ToString() + " Complementario";
                }
                else
                {
                    txtNotaF.Text = "Su Nota es " + notaF.ToString() + " REPROBADO";
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "Cerrar");
            }
        }
    }
}
    }
}