using System.Collections.Generic;

using OxyPlot;
using LiveCharts;
using System.Windows;
using System.Windows.Controls;

namespace WPF_With_LiveCharts
{
    /// <summary>
    /// Interaction logic for CardLineChart.xaml
    /// </summary>
    public partial class CardLineChart : UserControl
    {
        public CardLineChart()
        {
            InitializeComponent();
            CardGrid.DataContext = this;
        }


        /// <summary>
        /// Series Data Property for Card Chart
        /// </summary>
        public SeriesCollection SeriesData
        {
            get { return null; }
            set { SetValue(SeriesDataProperty, value); }
        }

        public static readonly DependencyProperty SeriesDataProperty =
            DependencyProperty.Register("SeriesData",
                typeof(SeriesCollection), typeof(CardLineChart),
                new PropertyMetadata(new SeriesCollection()));


        public string BackgroundColour
        {
            set { SetValue(ColourBG, value); }
        }
        public static readonly DependencyProperty ColourBG =
            DependencyProperty.Register("BackgroundColour",
                typeof(string), typeof(CardLineChart), new PropertyMetadata(null));

        public string CardContent
        {
            set { SetValue(LabelAtBottom, value); }
        }
        public static readonly DependencyProperty LabelAtBottom =
            DependencyProperty.Register("CardContent",
                typeof(string), typeof(CardLineChart), new PropertyMetadata(null));


        public string CardTitle
        {
            set { SetValue(LabelAtTop, value); }
        }
        public static readonly DependencyProperty LabelAtTop =
            DependencyProperty.Register("CardTitle",
                typeof(string), typeof(CardLineChart), new PropertyMetadata(null));


    }


}
