using Microsoft.Maui.Controls;

namespace DUALAPP
{
    public partial class lobby : ContentPage
    {
        public lobby()
        {
            InitializeComponent();
        }

        private async void OnCerrarSesionClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async void OnAjustesClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Ajustes());
        }

        private async void OnDispositivosClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Dispositivos());
        }
    }
}

