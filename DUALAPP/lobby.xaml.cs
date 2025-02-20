using System;
using System.Collections.Generic;
using Microsoft.Maui.Controls;

namespace DUALAPP
{
    public partial class lobby : ContentPage
    {
        private Dictionary<string, List<string>> estadosMunicipios = new Dictionary<string, List<string>>()
        {
{ "Estado de México", new List<string> {
        "Toluca", "Ecatepec", "Naucalpan", "Metepec", "Tecámac",
        "Nextlalpan", "Zumpango", "Teotihuacán"
    }},
{ "CDMX", new List<string> {
        "Álvaro Obregón", "Benito Juárez", "Miguel Hidalgo"
    }},
    { "Hidalgo", new List<string> {
        "Pachuca de Soto", "Mineral de la Reforma", "Tizayuca"
    }}
};

        private Dictionary<string, List<string>> municipiosCodigosPostales = new Dictionary<string, List<string>>()
        {
          { "Toluca", new List<string> { "50000", "50010", "50020", "50030" } },
    { "Ecatepec", new List<string> { "55000", "55010", "55020" } },
    { "Naucalpan", new List<string> { "53000", "53100" } },
    { "Metepec", new List<string> { "52140" } },
    { "Tecámac", new List<string> { "55740" } },
    { "Nextlalpan", new List<string> { "55790" } },
    { "Zumpango", new List<string> { "55600" } },
    { "Teotihuacán", new List<string> { "55800" } },
    { "Álvaro Obregón", new List<string> { "01000", "01010" } },
    { "Benito Juárez", new List<string> { "03000" } },
    { "Miguel Hidalgo", new List<string> { "11000" } },
    { "Pachuca de Soto", new List<string> { "42000" } },
    { "Mineral de la Reforma", new List<string> { "42180" } },
    { "Tizayuca", new List<string> { "43800" } }
};

        private Dictionary<string, List<string>> codigosPostalesColonias = new Dictionary<string, List<string>>()
{
    { "50000", new List<string> { "Centro", "Santa Ana Tlapaltitlán", "San Mateo Oxtotitlán" } },
    { "50010", new List<string> { "Morelos", "La Merced", "San Bernardino" } },
    { "50020", new List<string> { "Moderna de la Cruz", "San Sebastián", "El Cóporo" } },
    { "50030", new List<string> { "Barrio de la Merced", "Universidad", "La Teresona" } },
    { "55000", new List<string> { "San Cristóbal", "Ciudad Azteca", "Las Américas" } },
    { "55010", new List<string> { "Granjas Valle de Guadalupe", "Santa Clara Coatitla", "Boulevares de Ecatepec" } },
    { "55020", new List<string> { "México Insurgentes", "Villas de Ecatepec", "Ejidos de San Cristóbal" } },
    { "53000", new List<string> { "El Conde", "Santa Cruz Acatlán", "San Bartolo Naucalpan" } },
    { "53100", new List<string> { "Lomas Verdes", "Echegaray", "Boulevard de la Nación" } },
    { "52140", new List<string> { "La Providencia", "San Salvador Tizatlalli", "San Jerónimo Chicahualco" } },
    { "55740", new List<string> { "Ojo de Agua", "Real del Cid", "Santa Cruz Tecámac" } },
    { "55790", new List<string> { "Nextlalpan Centro", "San Miguel Xaltocan", "San Pedro Miltenco" } },
    { "55600", new List<string> { "Zumpango Centro", "San Juan Zitlaltepec", "Santa María Cuevas" } },
    { "55800", new List<string> { "San Juan Teotihuacán", "Purificación", "San Francisco Mazapa" } },
    { "01000", new List<string> { "Florida", "Guadalupe Inn", "San Ángel" } },
    { "01010", new List<string> { "Altavista", "Chimalistac", "Álvaro Obregón Centro" } },
    { "03000", new List<string> { "Del Valle", "Narvarte", "Portales" } },
    { "11000", new List<string> { "Lomas de Chapultepec", "Polanco", "San Miguel Chapultepec" } },
    { "42000", new List<string> { "Centro", "San Javier", "Villas de Pachuca" } },
    { "42180", new List<string> { "Pachuquilla", "La Providencia", "Carboneras" } },
    { "43800", new List<string> { "Tizayuca Centro", "El Carmen", "Hacienda de Tizayuca" } }
};


        public lobby()
        {
            InitializeComponent();
            estadoPicker.ItemsSource = new List<string> { "Estado de México", "CDMX", "Hidalgo" };
        }

        private void OnEstadoSelected(object sender, EventArgs e)
        {
            string selectedEstado = estadoPicker.SelectedItem as string;
            if (selectedEstado != null && estadosMunicipios.ContainsKey(selectedEstado))
            {
                municipioPicker.ItemsSource = estadosMunicipios[selectedEstado];
                municipioPicker.SelectedItem = null;
                codigoPostalPicker.ItemsSource = null;
                coloniaPicker.ItemsSource = null;
            }
        }

        private void OnMunicipioSelected(object sender, EventArgs e)
        {
            string selectedMunicipio = municipioPicker.SelectedItem as string;
            if (selectedMunicipio != null && municipiosCodigosPostales.ContainsKey(selectedMunicipio))
            {
                codigoPostalPicker.ItemsSource = municipiosCodigosPostales[selectedMunicipio];
                codigoPostalPicker.SelectedItem = null;
                coloniaPicker.ItemsSource = null;
            }
        }

        private void OnCodigoPostalSelected(object sender, EventArgs e)
        {
            string selectedCodigoPostal = codigoPostalPicker.SelectedItem as string;
            if (selectedCodigoPostal != null && codigosPostalesColonias.ContainsKey(selectedCodigoPostal))
            {
                coloniaPicker.ItemsSource = codigosPostalesColonias[selectedCodigoPostal];
                coloniaPicker.SelectedItem = null;
            }
        }

        async public void Regresar(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        async public void OnAjustesClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Ajustes());
        }

        async public void OnDispositivosClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Dispositivos());
        }
    }
}
