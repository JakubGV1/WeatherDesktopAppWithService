using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherAppClient.DomainServices;

namespace WeatherAppClient.Forms
{
    public partial class SplashScreen : Form
    {
        WeatherService weatherService = new WeatherService();
        public SplashScreen()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            CheckStatus();
        }
        private void CheckStatus()
        {
            if(weatherService.PingAuth())
            {
                SplashStatus.Text = "Serwis pogodowy jest dostępny";
                SplashStatus.ForeColor = Color.Green;
                timer1.Start();
            } else
            {
                SplashStatus.Text = "Serwis pogodowy jest niedostępny!";
                SplashStatus.ForeColor = Color.Red;
                timer2.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            MainWindow mainMenu = new MainWindow();
            mainMenu.Show();
            this.Hide();
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            timer2.Stop();
            Application.Exit();
        }
    }
}
