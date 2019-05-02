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
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;

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

        #region SeriesData DP
        public SeriesCollection SeriesData
        {
            set { SetValue(DataProperty, value); }
        }
        public static readonly DependencyProperty DataProperty =
            DependencyProperty.Register("SeriesData", 
                typeof(SeriesCollection), typeof(CardLineChart), 
                new PropertyMetadata(new SeriesCollection()));
        #endregion

        #region BackgroundColour DP
        public string BackgroundColour
        {
            set { SetValue(ColourBG, value); }
        }
        public static readonly DependencyProperty ColourBG =
            DependencyProperty.Register("BackgroundColour",
                typeof(string), typeof(CardLineChart), new PropertyMetadata(""));
        #endregion

        #region BottomLabel DP
        public string BottomLabel
        {
            set { SetValue(LabelAtBottom, value); }
        }
        public static readonly DependencyProperty LabelAtBottom =
            DependencyProperty.Register("BottomLabel",
                typeof(string), typeof(CardLineChart), new PropertyMetadata(null));
        #endregion

        #region TopLabel DP
        public string TopLabel
        {
            set { SetValue(LabelAtTop, value); }
        }
        public static readonly DependencyProperty LabelAtTop =
            DependencyProperty.Register("TopLabel",
                typeof(string), typeof(CardLineChart), new PropertyMetadata(null));
        #endregion
    }


}
