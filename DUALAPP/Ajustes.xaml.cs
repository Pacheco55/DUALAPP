namespace DUALAPP
{
    public partial class Ajustes : ContentPage
    {
        public Ajustes()
        {
            InitializeComponent();
        }

        async private void OnSaveSettings(object sender, EventArgs e)
        {
            // Lógica para guardar la configuración
            // Puedes agregar la lógica para guardar en una base de datos o preferencias de usuario
            await DisplayAlert("Configuración", "Configuración guardada correctamente", "OK");
        }

        async private void OnBackToPostLogin(object sender, EventArgs e)
        {
            // Lógica para regresar a la página postlogin
            await Navigation.PushAsync(new postlogin());
        }
    }
}
