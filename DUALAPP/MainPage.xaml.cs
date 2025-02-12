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
            await Navigation.PushAsync(new postlogin());
        }
    }
}
