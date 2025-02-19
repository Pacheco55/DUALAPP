namespace DUALAPP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async public void IniciarSesh(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new lobby());
        }
        async public void AgregarUsuario(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewPage1());
        }
    }
}
