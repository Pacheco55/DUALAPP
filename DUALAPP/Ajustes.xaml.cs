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
            // L�gica para guardar la configuraci�n
            // Puedes agregar la l�gica para guardar en una base de datos o preferencias de usuario
            await DisplayAlert("Configuraci�n", "Configuraci�n guardada correctamente", "OK");
        }

        async private void OnBackToPostLogin(object sender, EventArgs e)
        {
            // L�gica para regresar a la p�gina postlogin
            await Navigation.PushAsync(new postlogin());
        }
    }
}
