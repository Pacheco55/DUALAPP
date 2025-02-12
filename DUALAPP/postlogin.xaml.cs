using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System;
using System.Timers;
using Microsoft.Maui.Dispatching;

namespace DUALAPP
{
    public partial class postlogin : ContentPage
    {
        private const int TimerInterval = 5000;


        private IDispatcherTimer _timer;

        public ObservableCollection<Device> Devices { get; set; }

        public postlogin()
        {
            InitializeComponent();
            Devices = new ObservableCollection<Device>();
            DevicesCollectionView.ItemsSource = Devices;
            StartRandomDataUpdate();
        }

        private void StartRandomDataUpdate()
        {
            _timer = Application.Current.Dispatcher.CreateTimer();
            _timer.Interval = TimeSpan.FromSeconds(5);
            _timer.Tick += (s, e) => UpdateDeviceData();
            _timer.Start();
        }



        private void UpdateDeviceData()
        {
            var random = new Random();
            foreach (var device in Devices)
            {
                device.Temperature = random.Next(-5, 35).ToString();
                device.Humidity = random.Next(15, 80).ToString();
            }
        }

        private void OnAddDevice(object sender, EventArgs e)
        {
            // Lógica para agregar un nuevo dispositivo
            Devices.Add(new Device { Name = "Nuevo Sensor" });
        }

        private void OnDeleteDevice(object sender, EventArgs e)
        {
            // Lógica para eliminar un dispositivo
            var button = sender as Button;
            var device = button.BindingContext as Device;
            Devices.Remove(device);
        }
        private async void Backlogin(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }

    public class Device : INotifyPropertyChanged
    {
        private string _temperature;
        private string _humidity;

        public string Name { get; set; }
        public string Temperature
        {
            get => _temperature;
            set
            {
                _temperature = value;
                OnPropertyChanged();
            }
        }
        public string Humidity
        {
            get => _humidity;
            set
            {
                _humidity = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
      
}
