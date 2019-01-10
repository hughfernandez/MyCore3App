using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;
using System.Windows;

namespace MyCore3App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        RestClient client = new RestClient("http://greentegratefertilizationapi.azurewebsites.net/");

        public MainWindow()
        {
            InitializeComponent();
            GetFertilizers();
        }

        private void GetFertilizers()
        {
            var request = new RestRequest("api/clients/38fc8f9e-16d2-40e3-806c-5eb2d2d14e9c/catalogs/Fertilizers", Method.GET);
            
            // execute the request
            IRestResponse response = client.Execute(request);
            var content = response.Content;

            var results = JsonConvert.DeserializeObject<List<Fertilizer>>(content);
            listFertilizers.ItemsSource = results;            
        }
    }
}
