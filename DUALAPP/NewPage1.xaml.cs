namespace DUALAPP
{
    public partial class NewPage1 : ContentPage
    {

        public NewPage1() => InitializeComponent();

        

        async public void GuardarUsuario(object sender, EventArgs e)
        {
            // L�gica para guardar el nuevo usuario
            string username = newUsernameEntry.Text;
            string password = newPasswordEntry.Text;
            string confirmPassword = confirmPasswordEntry.Text;

            if (password == confirmPassword)
            {
                // Guardar el usuario (puedes agregar la l�gica para guardar en una base de datos o lista)
                await DisplayAlert("�xito", "Usuario agregado correctamente", "OK");
                await Navigation.PopAsync();
            }
            else
            {
                await DisplayAlert("Error", "Las contrase�as no coinciden", "OK");
            }
        }
    }
}
