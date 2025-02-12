using System.Collections.ObjectModel;
using System.Text.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace DUALAPP
{
    public partial class postlogin : ContentPage
    {
        public postlogin()
        {
            InitializeComponent();
            Devices = new ObservableCollection<Device>();
            DevicesCollectionView.ItemsSource = Devices;
            //LoadDevicesFromApi();
        }


        private async void Backlogin(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        public ObservableCollection<Device> Devices { get; set; }

        private async void LoadDevicesFromApi()
        {
            // Lógica para cargar dispositivos desde la API
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetStringAsync("https://api.example.com/devices");
                var devices = JsonSerializer.Deserialize<List<Device>>(response);
                foreach (var device in devices)
                {
                    Devices.Add(device);
                }
            }
       }


        private void OnAddDevice(object sender, EventArgs e)
        {
            // Lógica para agregar un nuevo dispositivo
            Devices.Add(new Device { Name = "Nuevo Dispositivo" });
        }

        private void OnDeleteDevice(object sender, EventArgs e)
        {
            // Lógica para eliminar un dispositivo
            var button = sender as Button;
            var device = button.BindingContext as Device;
            Devices.Remove(device);
        }

        public class Device
        {
            public string Name { get; set; }
            public string Temperature { get; set; }
            public string Humidity { get; set; }
        }
    }
}
