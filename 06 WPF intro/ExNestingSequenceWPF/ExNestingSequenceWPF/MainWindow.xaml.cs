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

namespace ExNestingSequenceWPF
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

        private void b1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b1.Opacity = (b1.Opacity < 0.1) ? 1.0 : b1.Opacity - 0.25;
            t1.Text = $"Text before / Opacity = {b1.Opacity}";
        }

        private void b2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b2.Opacity = (b2.Opacity < 0.1) ? 1.0 : b2.Opacity - 0.25;
            t2.Text = $"Text inside / Opacity = {b2.Opacity}";
        }

        private void b3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            b3.Opacity = (b3.Opacity < 0.1) ? 1.0 : b3.Opacity - 0.25;
            t3.Text = $"Text after / Opacity = {b3.Opacity}";
        }
    }
}
