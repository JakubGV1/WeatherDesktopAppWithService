using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeatherAppClient.DomainServices;
using WeatherAppClient.Models;
using WeatherAppClient.Models.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WeatherAppClient
{
    public partial class MainWindow : Form
    {

        List<string> MapCities = new List<string> {
            "Szczecin",
            "Poznań",
            "Zakopane",
            "Warszawa",
            "Kraków",
            "Olsztyn",
            "Suwałki",
            "Wrocław",
            "Gdańsk",
            "Lublin",
        };
        WeatherService weatherService = new WeatherService();

        public MainWindow()
        {
            InitializeComponent();
            this.actionToolStripMenuItem.Text = Properties.Settings.Default.Action;
            this.authorToolStripMenuItem.Text = Properties.Settings.Default.Author;
            this.closeToolStripMenuItem.Text = Properties.Settings.Default.Close;
            this.FullInformation.Text = Properties.Settings.Default.Information;
            this.ChosenCity.Text = Properties.Settings.Default.City;
            this.Map.Text = Properties.Settings.Default.MapPolish;
            this.LoadCurrentDataLabel.Text = Properties.Settings.Default.LoadCurrentData;
            this.TemperatureButton.Text = Properties.Settings.Default.Temperature;
            this.HumidityButton.Text = Properties.Settings.Default.Humidity;
            this.PressureButton.Text = Properties.Settings.Default.Pressure;
            this.StatusLabel.Text = Properties.Settings.Default.Status;
            this.ChoseCityName.Text = Properties.Settings.Default.ChoseCityName;
            this.GetAllWeatherButton.Text = Properties.Settings.Default.GetAllWeather;
            this.Text = "Pogoda INFO";
            GetTownList();

        }

        private void GetTownList()
        {
            List<string> cityNames = weatherService.ListOfTowns();
            if (cityNames != null)
            {
                foreach (string cityName in cityNames)
                {
                    cityComboBox.Items.Add(cityName);
                }
            }
        }

       

        private void authorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autor - Jakub Grzeszczuk.", "O autorze", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void actionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private bool CheckStatus()
        {
            if (weatherService.PingAuth())
            {
                return true;
            } else
            {
                MessageBox.Show("Serwis pogodowy nie jest dostępny. Spróbuj później!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        private void TemperatureButton_Click(object sender, EventArgs e)
        {
            if (CheckStatus())
            {
                List<DtoTown> dtoTowns = new List<DtoTown>();
                foreach (var city in MapCities)
                {
                    dtoTowns.Add(new DtoTown { Name = city });
                }
                List<SimpleData> dataList = weatherService.GetWeatherForMultipleCities(dtoTowns);
                if (dataList != null && dataList.Count > 0)
                {
                    StatusLabel.Text = "Wczytano temperature";
                    DateInfo.Text = $"Data odczytu: {DateTime.Now}";
                    FillLabelsWithData(dataList);
                }
            }
        }

        private void PressureButton_Click(object sender, EventArgs e)
        {
            if (CheckStatus())
            {
                List<DtoTown> dtoTowns = new List<DtoTown>();
                foreach (var city in MapCities)
                {
                    dtoTowns.Add(new DtoTown { Name = city });
                }
                List<SimpleData> dataList = weatherService.GetPressureForMultipleCities(dtoTowns);
                if (dataList != null && dataList.Count > 0)
                {
                    StatusLabel.Text = "Wczytano ciśnienie";
                    DateInfo.Text = $"Data odczytu: {DateTime.Now}";
                    FillLabelsWithData(dataList);
                }
            }
        }

        private void HumidityButton_Click(object sender, EventArgs e)
        {
            if (CheckStatus())
            {
                List<DtoTown> dtoTowns = new List<DtoTown>();
                foreach (var city in MapCities)
                {
                    dtoTowns.Add(new DtoTown { Name = city });
                }
                List<SimpleData> dataList = weatherService.GetHumidityForMultipleCities(dtoTowns);
                if (dataList != null && dataList.Count > 0)
                {
                    StatusLabel.Text = "Wczytano wilgotność";
                    DateInfo.Text = $"Data odczytu: {DateTime.Now}";
                    FillLabelsWithData(dataList);
                }
            }
        }

        private void FillLabelsWithData(List<SimpleData> data)
        {
            foreach (var cityData in data)
            { 
                Label label = Controls.Find($"{cityData.Name}Value", true).FirstOrDefault() as Label;
                if (label != null)
                {
                    label.Text = cityData.Value;
                }
            }
        }


        private void WrocławLabel_Click(object sender, EventArgs e)
        {

        }

        private void GetAllWeatherButton_Click(object sender, EventArgs e)
        {
            if (CheckStatus())
            {
                List<WeatherForecastEntry> weatherForecastEntries = weatherService.WeatherFullInformations();

                if (weatherForecastEntries != null && weatherForecastEntries.Count > 0)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine($"Data aktualizacji: {DateTime.Now}");
                    sb.AppendLine();

                    foreach (var weatherEntry in weatherForecastEntries)
                    {
                        AppendWeatherEntryInfo(sb, weatherEntry);
                    }

                    resultInformation.Text = sb.ToString();
                }
            }
        }

        private void AppendWeatherEntryInfo(StringBuilder sb, WeatherForecastEntry weatherEntry)
        {
            sb.AppendLine($"Stacja: {weatherEntry.stacja}");
            sb.AppendLine($"IdStacji: {weatherEntry.id_stacji}");
            sb.AppendLine($"Temperatura: {weatherEntry.temperatura}");
            sb.AppendLine($"Godzina pomiaru: {weatherEntry.godzina_pomiaru}");
            sb.AppendLine($"Data pomiaru: {weatherEntry.data_pomiaru}");
            sb.AppendLine($"Kierunek wiatru: {weatherEntry.kierunek_wiatru}");
            sb.AppendLine($"Prędkość wiatru: {weatherEntry.predkosc_wiatru}");
            sb.AppendLine($"Wilgotność względna: {weatherEntry.wilgotnosc_wzgledna}");
            sb.AppendLine($"Suma opadu: {weatherEntry.suma_opadu}");
            sb.AppendLine($"Ciśnienie: {weatherEntry.cisnienie}");
            sb.AppendLine();
        }

        private void cityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CheckStatus())
            {
                if (cityComboBox.SelectedItem != null)
                {
                    string selectedTown = cityComboBox.SelectedItem.ToString();
                    ShowTownInformation(selectedTown);
                }
            }
        }

        private void ShowTownInformation(string selectedTown)
        {
            TownInfo townInfo = weatherService.WeatherForSpecificCity(selectedTown);

            StringBuilder sb = new StringBuilder();

            if (townInfo != null)
            {
                sb.AppendLine($"Stacja: {townInfo.stacja}");
                sb.AppendLine($"Temperatura: {townInfo.temperatura}");
                sb.AppendLine($"Godzina pomiaru: {townInfo.godzina_pomiaru}");
                sb.AppendLine($"Data pomiaru: {townInfo.data_pomiaru}");
                sb.AppendLine($"Ciśnienie: {townInfo.cisnienie}");
            }

            textBoxCity.Text = sb.ToString();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
