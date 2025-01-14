﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using ProyectoITXamarin.DataModel;
using ProyectoITXamarin.Data;

namespace ProyectoITXamarin
{
    public partial class MainPage : ContentPage
    {
        //private async void SimpleButton_Clicked(object sender, EventArgs e)
        //{
           
        //}
        public async void TraerDatos()
        {
            var request = new HttpRequestMessage();
            request.RequestUri = new Uri("https://api.jsonbin.io/b/606e153bceba857326707915");
            request.Method = HttpMethod.Get;
            request.Headers.Add("Accpet", "application/json");
            var client = new HttpClient();
            HttpResponseMessage response = await client.SendAsync(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                string content = await response.Content.ReadAsStringAsync();
                var resultado = JsonConvert.DeserializeObject<List<Cliente>>(content);
                grid.ItemsSource = resultado;
            }
        }
        public async void TraerDatos1()
        {
            var request = new HttpRequestMessage();
            request.RequestUri = new Uri("https://api.jsonbin.io/b/606f75dd9c59a9732caff265");
            request.Method = HttpMethod.Get;
            request.Headers.Add("Accpet", "application/json");
            var client = new HttpClient();
            HttpResponseMessage response = await client.SendAsync(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                string content = await response.Content.ReadAsStringAsync();
                var resultado = JsonConvert.DeserializeObject<List<Factura>>(content);
                grid1.ItemsSource = resultado;
            }
        }
        public MainPage()
        {
            InitializeComponent();
            DevExpress.XamarinForms.DataGrid.Initializer.Init();
            DevExpress.XamarinForms.Editors.Initializer.Init();
            TraerDatos();
            TraerDatos1();
        }
        public bool ShowAutoFilterRow { get; set; }
    }
}
