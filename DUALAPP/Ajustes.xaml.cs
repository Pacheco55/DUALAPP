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
            // L�gica para guardar la configuraci�n
            // Puedes agregar la l�gica para guardar en una base de datos o preferencias de usuario
            await DisplayAlert("Configuraci�n", "Configuraci�n guardada correctamente", "OK");
        }

        async private void OnBackToPostLogin(object sender, EventArgs e)
        {
            // L�gica para regresar a la p�gina postlogin
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
