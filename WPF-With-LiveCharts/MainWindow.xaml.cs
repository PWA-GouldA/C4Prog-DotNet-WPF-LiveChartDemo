using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WPF_With_LiveCharts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public SeriesCollection theData;
        public SeriesCollection theData2;
        public string BackgroundColour;

        public MainWindow()
        {
            InitializeComponent();

            theData = new SeriesCollection
            {
                new LineSeries
                {
                    Values = new ChartValues<decimal> { 7, 3, 2, 3, 5, 7, 4 }
                }
            };

            theData2 = new SeriesCollection
            {
                new LineSeries
                {
                    Values = new ChartValues<decimal> { 100, 90, 70, 40, 10 }
                }
            };

            BackgroundColour = "#FFCE2156";

            DataContext = this;

        }

        private void ButtonLineChart_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
