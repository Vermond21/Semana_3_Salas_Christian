using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Semana_3_Salas_Christian
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;

            if ((user == "estudiante2022") && (pass == "uisrael2022"))
            {
                await Navigation.PushAsync(new pagina_2(user, pass));
            }
            else
            {
                DisplayAlert("Alerta", "Credenciales Incorectas", "cerrar");
            }







        }
    }
}
