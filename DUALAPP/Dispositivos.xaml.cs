using Microsoft.Maui.Controls;

namespace DUALAPP
{
    public partial class Dispositivos : ContentPage
    {
        public Dispositivos()
        {
            InitializeComponent();
        }

        private async void OnConfirmarClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Confirmación", "El dispositivo ha sido registrado con éxito.", "OK");
            await Navigation.PushAsync(new postlogin());
        }

        private async void OnRegresarClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
