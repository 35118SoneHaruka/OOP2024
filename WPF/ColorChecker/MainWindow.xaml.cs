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

        MyColor currentColor;
        //double redValue;
        //double greenValue;
        //double blueValue;

        public MainWindow() {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {

            currentColor.Color = Color.FromRgb((byte)rSlider.Value, (byte)gSlider.Value, (byte)bSlider.Value);
            colorArea.Background = new SolidColorBrush(currentColor.Color);
            //redValue = (int)rSlider.Value;
            //greenValue = (int)gSlider.Value;
            //blueValue = (int)bSlider.Value; ;

            //colorArea.Background = new SolidColorBrush(Color.FromRgb((byte)redValue, (byte)greenValue, (byte)blueValue));

        }

        private void stockButton_Click(object sender, RoutedEventArgs e) {
            if (stockList.Items.Contains(currentColor)) {
                MessageBox.Show("既に登録されています。");
            } else {
                stockList.Items.Insert(0, currentColor);
            }
            
            //if (stockList.Items.Contains(colorArea.Background)) {
            //    MessageBox.Show("既に登録されています。");
            //} else {
            //    redValue = (int)rSlider.Value;
            //    greenValue = (int)gSlider.Value;
            //    blueValue = (int)bSlider.Value;
            //    var color = new MyColor();
            //    color.Color = Color.FromRgb((byte)redValue, (byte)greenValue, (byte)blueValue);
            //    stockList.Items.Insert(0, color);
            //}


        }

        private void stockList_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if(stockList.SelectedItem is MyColor selectedColor) {
                rValue.Text =selectedColor.Color.R.ToString();
                gValue.Text =selectedColor.Color.G.ToString();
                bValue.Text =selectedColor.Color.B.ToString();
            }
        }
    }
}
