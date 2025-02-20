namespace DUALAPP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async public void AgregarUsuario(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewPage1());
        }
        async public void IniciarSesh(object sender, EventArgs e)
        {
            // Lógica para guardar el nuevo usuario
            string username = UsernameEntry.Text;
            string password = PasswordEntry.Text;

            if (username == "pacheco" && password == "123")
            {
                // Guardar el usuario (puedes agregar la lógica para guardar en una base de datos o lista)
                await DisplayAlert("Bienvenido", "Ingeniero " + username , "ACEPTAR");
                await Navigation.PushAsync(new lobby());
            }
            else
            {
                await DisplayAlert("ERROR !", "La contraseña o el ususario no coinciden .", "REGRESAR");
            }
        }


    }
}
