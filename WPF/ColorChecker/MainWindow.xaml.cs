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

namespace ColorChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            rValue.Text = "0";
            gValue.Text = "0";
            bValue.Text = "0";
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            int redValue = (int)rSlider.Value;
            rValue.Text = redValue.ToString();
            int greenValue = (int)gSlider.Value;
            gValue.Text = greenValue.ToString();
            int blueValue = (int)bSlider.Value;
            bValue.Text = blueValue.ToString();
            int alpha = 255;

            colorArea.Background = new SolidColorBrush(Color.FromArgb((byte)alpha, (byte)redValue, (byte)greenValue, (byte)blueValue));

            
        }
    }
}
