using CustomerApp.Objects;
using Microsoft.Win32;
using SQLite;
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

namespace CustomerApp {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        List<Customer> _customers;
        

        //コンストラクタ
        public MainWindow() {
            InitializeComponent();
            ReadDatabase();
        }

        //SaveButton
        private void SaveButton_Click(object sender, RoutedEventArgs e) {
            if (NameTextBox.Text == string.Empty || PhoneTextBox.Text == string.Empty || AddressTextBox.Text == string.Empty) {
                MessageBox.Show("すべてに文字を入力してください");
                return;
            }

            //if(LoadedImage.Source == null) {
            //    MessageBox.Show("画像を選択してください");
            //    return;
            //}

            byte[] imageBytes = null;

            if (LoadedImage.Source != null) {
                var bitmapImage = LoadedImage.Source as BitmapImage;
                if (bitmapImage != null) {
                    using (var memoryStream = new System.IO.MemoryStream()) {
                        BitmapEncoder encoder = new PngBitmapEncoder();
                        encoder.Frames.Add(BitmapFrame.Create(bitmapImage));
                        encoder.Save(memoryStream);
                        imageBytes = memoryStream.ToArray();
                    }
                }
            }
            var customer = new Customer() {
                Name = NameTextBox.Text,
                Phone = PhoneTextBox.Text,
                Address = AddressTextBox.Text,
                Image = imageBytes,
            };

            using(var connection = new SQLiteConnection(App.databasePass)) {
                connection.CreateTable<Customer>();
                connection.Insert(customer);
            }
            ReadDatabase();
            TextClear();
        }

        //UpdateButton
        private void UpdateButton_Click(object sender, RoutedEventArgs e) {
            var item = CustomerListView.SelectedItem as Customer;
            if(item == null) {
                MessageBox.Show("更新する行を選択してください");
                return;
            }
            if (NameTextBox.Text == string.Empty || PhoneTextBox.Text == string.Empty || AddressTextBox.Text == string.Empty) {
                MessageBox.Show("すべてに文字を入力してください");
                return;
            }
            //if (LoadedImage.Source == null) {
            //    MessageBox.Show("画像を選択してください");
            //    return;
            //}

            byte[] imageBytes = null;

            if (LoadedImage.Source != null) {
                var bitmapImage = LoadedImage.Source as BitmapImage;
                if (bitmapImage != null) {
                    using (var memoryStream = new System.IO.MemoryStream()) {
                        BitmapEncoder encoder = new PngBitmapEncoder();
                        encoder.Frames.Add(BitmapFrame.Create(bitmapImage));
                        encoder.Save(memoryStream);
                        imageBytes = memoryStream.ToArray();
                    }
                } 
            }

            item.Name = NameTextBox.Text;
            item.Phone = PhoneTextBox.Text;
            item.Address = AddressTextBox.Text;
            item.Image = imageBytes;

            using (var connection = new SQLiteConnection(App.databasePass)) {
                connection.CreateTable<Customer>();
                connection.Update(item);
            }
            ReadDatabase();
            TextClear();
        }

        //データベースの読み込み
        private void ReadDatabase() {
            using (var connection = new SQLiteConnection(App.databasePass)) {
                connection.CreateTable<Customer>();
                _customers = connection.Table<Customer>().ToList();

                CustomerListView.ItemsSource = _customers;
            }
        }

        //データベースの検索
        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e) {
            var filterList = _customers.Where(x => x.Name.Contains(SearchTextBox.Text)).ToList();
            CustomerListView.ItemsSource = filterList;
        }

        //DeleteButton
        private void DeleteButton_Click(object sender, RoutedEventArgs e) {
            if(MessageBoxResult.Yes == MessageBox.Show("削除しますか？", "確認", MessageBoxButton.YesNo)) {
                var item = CustomerListView.SelectedItem as Customer;

                if (item == null) {
                    MessageBox.Show("削除する行を選択してください");
                    return;
                }

                using (var connection = new SQLiteConnection(App.databasePass)) {
                    connection.CreateTable<Customer>();
                    connection.Delete(item);

                    ReadDatabase();
                }
                TextClear();
            } else {
                TextClear();
                return;
            }
            
        }

        //ListViewの選択
        private void CustomerListView_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var item = (Customer)CustomerListView.SelectedItem;
            if(item != null) {
                NameTextBox.Text = item.Name;
                PhoneTextBox.Text = item.Phone;
                AddressTextBox.Text = item.Address;
                if (item.Image != null) {
                    var image = new BitmapImage();
                    using (var memoryStream = new System.IO.MemoryStream(item.Image)) {
                        image.BeginInit();
                        image.CacheOption = BitmapCacheOption.OnLoad;
                        image.StreamSource = memoryStream;
                        image.EndInit();
                    }

                    LoadedImage.Source = image;
                } else {
                    LoadedImage.Source = null;
                }
            }
           
        }

        private void TextClear() {
            NameTextBox.Text = string.Empty;
            PhoneTextBox.Text = string.Empty;
            AddressTextBox.Text = string.Empty;
            LoadedImage.Source = null;
            SearchTextBox.Text = string.Empty;
        }

        private void OpenButton_Click(object sender, RoutedEventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            {
                //ファイル選択ダイアログを開く
                if (openFileDialog.ShowDialog() == true) {
                    LoadedImage.Source = new BitmapImage(new Uri(openFileDialog.FileName));
                }
            }
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e) {
            LoadedImage.Source = null;
        }

        private void ClearTextButton_Click(object sender, RoutedEventArgs e) {
            TextClear();
        }
    }
}
