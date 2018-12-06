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

namespace UserControls
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

        static readonly SolidColorBrush RED = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
        static readonly SolidColorBrush GREEN = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0));
        static readonly SolidColorBrush BLUE = new SolidColorBrush(Color.FromArgb(255, 0, 0, 255));

        private void BtnColor_Click(object sender, RoutedEventArgs e)
        {
            if (RectColor.Fill == BLUE)
                RectColor.Fill = RED;
            else if (RectColor.Fill == RED)
                RectColor.Fill = GREEN;
            else
                RectColor.Fill = BLUE;

            helloControl.Message = EditMessage.Text;
            helloControl.Foreground = RectColor.Fill;
        }
    }
}
