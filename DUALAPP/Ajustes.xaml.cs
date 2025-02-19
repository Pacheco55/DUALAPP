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

        private void OnVolumeChanged(object sender, ValueChangedEventArgs e)
        {
            _audioPlayer.Volume = e.NewValue / 100;
        }

        private void OnSoundToggled(object sender, ToggledEventArgs e)
        {
            if (e.Value)
            {
                _audioPlayer.Pause();
            }
            else
            {
                _audioPlayer.Play();
            }
        }

        private void OnSaveSettings(object sender, EventArgs e)
        {
            // Guardar configuración
        }

        private void OnBackToPostLogin(object sender, EventArgs e)
        {
            // Regresar a la página anterior
        }
    }
}
