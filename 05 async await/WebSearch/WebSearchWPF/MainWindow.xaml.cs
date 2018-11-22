using BFH.WebSearch;
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

namespace WebSearchWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private static readonly object statusLock = new Object();

        private void ShowStatus(string s)
        {
            lock (statusLock)
            {
                TBDebug.Text = s;
            }

        }

        private async void BtnSearch_Click(object sender, RoutedEventArgs e)
        {
            Searcher.Status = ShowStatus;
            var word = TBSearch.Text.Trim();
            TBDebug.Text = $"searching '{word}'";
            BtnSearch.IsEnabled = false;
            BtnSearch.Content = "Searching";

            try
            {
                var res = await Searcher.FindWordAsync(word);
                ListResult.ItemsSource = res;
                TBDebug.Text = $"search completed '{word}'";
            }
            catch (Exception ex)
            {
                ListResult.ItemsSource = null;
                TBDebug.Text = ex.Message;
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                BtnSearch.Content = "Search";
                BtnSearch.IsEnabled = true;
            }
        }
    }
}
