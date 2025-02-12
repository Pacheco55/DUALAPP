namespace DUALAPP
{
    public partial class postlogin : ContentPage
    {
        public postlogin()
        {
            InitializeComponent();
        }

      
        private async void Backlogin(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
       

    }
}
