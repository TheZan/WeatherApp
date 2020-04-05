using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using System.Xml.Linq;

namespace Weather
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DisplayWeather displayWeather;
        string city = "Москва";
        public MainWindow()
        {
            InitializeComponent();
            ChangeBackground(0, EventArgs.Empty);
            DispatcherTimer checkTime = new DispatcherTimer();
            checkTime.Interval = TimeSpan.FromMinutes(30);
            checkTime.Tick += new EventHandler(ChangeBackground);
            checkTime.Start();
            string dayOfWeekStr = CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.GetDayName(DateTime.Now.DayOfWeek);
            dayOfWeek.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(dayOfWeekStr);
            Display();
            FillCityList();
            tbCity.Text = city;
        }

        private void FillCityList()
        {
            var xmlStr = File.ReadAllText("city.xml", Encoding.GetEncoding(1251));
            var str = XElement.Parse(xmlStr);
            var city = str.Elements("city");
            foreach (var citys in city)
            {
                var cityList = citys.Element("name")?.Value;
                cmCity.Items.Add(cityList);
            }
        }

        private void Display()
        {
            try
            {
                displayWeather = new DisplayWeather(city);
                List<MainWeather> mainWeathers = new List<MainWeather>();
                mainWeathers = displayWeather.Get();
                string descript = mainWeathers.Select(p => p.description).FirstOrDefault().ToString();
                byte[] bytes = Encoding.Default.GetBytes(descript);
                descript = Encoding.UTF8.GetString(bytes);
                currentTemp.Text = $"{Convert.ToInt32(mainWeathers.Select(p => p.temp).FirstOrDefault())}°C";
                humidity.Text = $"Влажность: {Convert.ToInt32(mainWeathers.Select(p => p.humidity).FirstOrDefault())}%";
                description.Text = $"Погода: {CultureInfo.CurrentCulture.TextInfo.ToTitleCase(descript)}";
                pressure.Text = $"Давление: {Convert.ToInt32(mainWeathers.Select(p => p.pressure).FirstOrDefault())} мм рт.ст.";
                speed.Text = $"Скорость ветра: {Convert.ToInt32(mainWeathers.Select(p => p.speed).FirstOrDefault())} м/с";
                feels_like.Text = $"Ощущается как {Convert.ToInt32(mainWeathers.Select(p => p.feels_like).FirstOrDefault())}°C";
            }
            catch { }
        }

        private void TopPanelButtonClick(object sender, RoutedEventArgs e)
        {
            switch ((sender as Button).Name)
            {
                case "minimize":
                    this.WindowState = WindowState.Minimized;
                    break;
                case "close":
                    Application.Current.Shutdown();
                    break;
                default:
                    break;
            }
        }

        private void gridTopPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void ChangeBackground(object sender, EventArgs e)
        {
            int currentTime = DateTime.Now.Hour;
            if ((currentTime >= 0) && (currentTime < 5))
            {
                backgroundTime.Source = new BitmapImage(new Uri("Assets/night.png", UriKind.Relative)); ;
            }
            else if ((currentTime >= 5) && (currentTime < 11))
            {
                backgroundTime.Source = new BitmapImage(new Uri("Assets/morning.png", UriKind.Relative)); ;
            }
            else if ((currentTime >= 11) && (currentTime < 17))
            {
                backgroundTime.Source = new BitmapImage(new Uri("Assets/day.png", UriKind.Relative)); ;
            }
            else if ((currentTime >= 17) && (currentTime <= 23))
            {
                backgroundTime.Source = new BitmapImage(new Uri("Assets/evening.png", UriKind.Relative)); ;
            }
        }

        private void cmCity_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmCity.SelectedItem != null)
            {
                city = cmCity.SelectedItem.ToString();
                tbCity.Text = city;
                Display();
            }
        }
    }
}
