using BFH.WebSearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace WebSearchWithCancelWPF
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

        private CancellationTokenSource cts = null;

        private async void BtnSearch_Click(object sender, RoutedEventArgs e)
        {
            if (cts == null)
            {
                Searcher.Status = (s) => { TBDebug.Text = s; };
                var word = TBSearch.Text.Trim();
                TBDebug.Text = $"searching '{word}'";
                BtnSearch.Content = "Cancel";

                try
                {
                    cts = new CancellationTokenSource();
                    var res = await Searcher.FindWordAsync(word, cts.Token);
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
                    cts = null;
                    BtnSearch.Content = "Search";
                    BtnSearch.IsEnabled = true;
                }
            }
            else
            {
                BtnSearch.Content = "cancelling ...";
                BtnSearch.IsEnabled = false;
                TBDebug.Text = "cancelling !!!";
                cts.Cancel();
            }
        }
    }
}
