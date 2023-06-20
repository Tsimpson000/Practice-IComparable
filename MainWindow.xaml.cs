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

namespace Practice_IComparable
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<GuitarPick> _guitarPicks = new List<GuitarPick>();
        public MainWindow()
        {
            InitializeComponent();

            _guitarPicks.Add(new GuitarPick("Fender", .6, 20));
            _guitarPicks.Add(new GuitarPick("Ernie Ball", 1.0, 50));
            _guitarPicks.Add(new GuitarPick("Fender", .45, 40));
            _guitarPicks.Add(new GuitarPick("Dunlop", .6, 100));
            _guitarPicks.Add(new GuitarPick("Gravity", .8, 20));
        }

        private void btnOriginal_Click(object sender, RoutedEventArgs e)
        {
            _guitarPicks.Clear();
            _guitarPicks.Add(new GuitarPick("Fender", .6, 20));
            _guitarPicks.Add(new GuitarPick("Ernie Ball", 1.0, 50));
            _guitarPicks.Add(new GuitarPick("Fender", .45, 40));
            _guitarPicks.Add(new GuitarPick("Dunlop", .6, 100));
            _guitarPicks.Add(new GuitarPick("Gravity", .8, 20));
            lbList.ItemsSource = _guitarPicks;
            lbList.Items.Refresh();
        }

        private void btnBrand_Click(object sender, RoutedEventArgs e)
        {
            _guitarPicks.Sort(new BrandCompare());
            lbList.Items.Refresh();
        }

        private void btnQuantityDesc_Click(object sender, RoutedEventArgs e)
        {
            _guitarPicks.Sort(new QuantityDesc());
            lbList.Items.Refresh();
        }

        private void btnThicknessAsc_Click(object sender, RoutedEventArgs e)
        {
            _guitarPicks.Sort();
            lbList.Items.Refresh();
        }
    }
}
