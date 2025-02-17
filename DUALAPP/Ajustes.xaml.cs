using Microsoft.Maui.Controls;
using Plugin.Maui.Audio;

namespace DUALAPP
{
    public partial class Ajustes : ContentPage
    {
        private IAudioPlayer _audioPlayer;
        public Ajustes()
        {
            InitializeComponent();
            volumeSlider.ValueChanged += OnVolumeChanged;
            soundSwitch.Toggled += OnSoundToggled;

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

        private void OnVolumeChanged(object sender, ValueChangedEventArgs e)
        {
            _audioPlayer.Volume = e.NewValue / 100;
        }

        private void OnSoundToggled(object sender, ToggledEventArgs e)
        {
            if (e.Value)
            {
                _audioPlayer.Play();
            }
            else
            {
                _audioPlayer.Pause();
            }
        }

        
    }
}
