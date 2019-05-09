using LiveCharts;
using LiveCharts.Wpf;
using System.Collections.Generic;
using System.Windows;

namespace WPF_With_LiveCharts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public SeriesCollection theData1;
        public SeriesCollection theData2;
        public SeriesCollection theData3;
        public string BackgroundColour;
        private CountdownTicker timer;

        public MainWindow()
        {
            InitializeComponent();

            theData1 = new SeriesCollection
            {
                new LineSeries
                {
                    Values = new ChartValues<double> { 3, 5, 7, 4 }
                },
                new LineSeries
                {
                    Values = new ChartValues<decimal> { 5, 6, 2, 7 }
                }
            };

            theData2 = new SeriesCollection
            {
                new LineSeries
                {
                    Values = new ChartValues<decimal> { 100, 90, 70, 40, 10 }
                }
            };


            theData3 = new SeriesCollection
            {
                new ColumnSeries
                {
                    Values = new ChartValues<decimal> { 100, 50, 70, 20, 30 }
                }
            };

            this.BackgroundColour = "#FF000000";

            timer = new CountdownTicker();

            timer.Start();

            TestingCardLineChart1.SeriesData = theData1;
            TestingCardLineChart2.SeriesData = theData2;
            TestingCardLineChart3.SeriesData = theData3;


        }

        private void ButtonLineChart_Click(object sender, RoutedEventArgs e)
        {

        }



    }
}
