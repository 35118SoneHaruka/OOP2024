﻿using System;
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

namespace SampleApplication {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show("こんにちは");
        }

        private void okButton_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show(string.Format("入力された文字は{0}です。", messageTextBox.Text));
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show("キャンセルされました。");
        }
    }
}
