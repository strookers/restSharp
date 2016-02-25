using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BLL;
using Core;

namespace Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static BWeatherMap bMap = new BWeatherMap();
        WeatherMap wm = bMap.RestSharp();

        public MainWindow()
        {
            
            InitializeComponent();
            getWeatherMap();
        }

        public void getWeatherMap()
        {
            richTextBox.Selection.Text = "";

            string name = wm.name;
            string country = wm.sys.country;
            List<Weather> wList = wm.weather;
            richTextBox.Selection.Text = $"By: {name} \n" +
                                         $"Land: {country}";

            dataGrid.ItemsSource = wList;
        }
    }
}
