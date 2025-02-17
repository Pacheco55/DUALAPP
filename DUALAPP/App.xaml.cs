using Plugin.Maui.Audio;

namespace DUALAPP
{
    public partial class App : Application
    {
        private IAudioPlayer _audioPlayer;

        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();

            InitializeAudioPlayer();
        }

        private async void InitializeAudioPlayer()
        {
            var audioStream = await FileSystem.OpenAppPackageFileAsync("CelloSuite1.mp3");
            _audioPlayer = AudioManager.Current.CreatePlayer(audioStream);
            _audioPlayer.Play();
        }
    }
}
