namespace DUALAPP
{
    public partial class NewPage1 : ContentPage
    {

        public NewPage1() => InitializeComponent();

        

        async public void GuardarUsuario(object sender, EventArgs e)
        {
            // Lógica para guardar el nuevo usuario
            string username = newUsernameEntry.Text;
            string password = newPasswordEntry.Text;
            string confirmPassword = confirmPasswordEntry.Text;

            if (password == confirmPassword)
            {
                // Guardar el usuario (puedes agregar la lógica para guardar en una base de datos o lista)
                await DisplayAlert("YEAH", "Usuario agregado correctamente", "ACEPTAR");
                await Navigation.PopAsync();
            }
            else
            {
                await DisplayAlert("ERROR !", "Las contraseñas no coinciden", "REGRESAR");
            }
        }
    }
}
