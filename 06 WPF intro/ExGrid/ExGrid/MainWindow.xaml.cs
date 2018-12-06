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

namespace ExGrid
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

        private void Grid_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Button btn = new Button();
            btn.Content = DateTime.Now.ToString();
            btn.Margin = new Thickness(20);
            var rand = new Random();
            btn.Background = new SolidColorBrush(Color.FromRgb(
                (byte)rand.Next(255), (byte)rand.Next(255), (byte)rand.Next(255)));
            btn.Click += Button_Click;
            Grid.Children.Add(btn);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            if (btn != null)
            {
                var col = Grid.GetColumn(btn);
                var row = Grid.GetRow(btn);

                if (col > row)
                    row++;
                else
                    col++;

                if (col > 2 || row > 2)
                    Grid.Children.Remove(btn);
                else
                {
                    Grid.SetColumn(btn, col);
                    Grid.SetRow(btn, row);
                }
            }
        }
    }
}
