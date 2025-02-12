namespace DUALAPP
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(postlogin), typeof(postlogin));
        }
    }
}
