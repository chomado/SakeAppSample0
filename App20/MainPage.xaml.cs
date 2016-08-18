using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// 空白ページのアイテム テンプレートについては、http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 を参照してください

namespace App20
{
    /// <summary>
    /// それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        ObservableCollection<string> SakeNames = new ObservableCollection<string>();

        public MainPage()
        {
            this.InitializeComponent();
            // データのひも付け
            this.listView.ItemsSource = this.SakeNames;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //this.listView.Items.Add(this.inputForm.Text);
            this.SakeNames.Add(this.inputForm.Text);
        }

        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.listView.Items.Remove(this.listView.SelectedItem);
        }
    }
}
