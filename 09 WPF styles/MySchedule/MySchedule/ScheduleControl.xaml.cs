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

namespace MySchedule
{
    /// <summary>
    /// Interaction logic for ScheduleControl.xaml
    /// </summary>
    public partial class ScheduleControl : UserControl
    {
        public static readonly DependencyProperty ScheduleProperty =
            DependencyProperty.Register("Schedule",
                typeof(Models.Schedule), typeof(ScheduleControl));

        public Models.Schedule Schedule
        {
            get { return (Models.Schedule)GetValue(ScheduleProperty); }
            set { SetValue(ScheduleProperty, value); Console.WriteLine("setting schedule " + value.Count); }
        }

        public static readonly DependencyProperty UnitsPerHourProperty =
            DependencyProperty.Register("UnitsPerHour",
                typeof(double), typeof(ScheduleControl),
                new PropertyMetadata(30.0));

        public double UnitsPerHour
        {
            get { return (double)GetValue(UnitsPerHourProperty); }
            set { SetValue(UnitsPerHourProperty, value); }
        }

        public ScheduleControl()
        {
            InitializeComponent();

            Console.WriteLine("count = " + Schedule?.Count);

            OuterGrid.ColumnDefinitions.Clear();
            OuterGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });
            for (int i = 1; i < 6; i++)
                OuterGrid.ColumnDefinitions.Add(new ColumnDefinition());

            OuterGrid.RowDefinitions.Clear();
            OuterGrid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            var binding = new Binding("UnitsPerHour");
            binding.Source = this;
            for (int i = 1; i < 17; i++)
            {
                var r = new RowDefinition();
                r.SetBinding(RowDefinition.HeightProperty, binding);
                OuterGrid.RowDefinitions.Add(r);
            }

            for (int i = 1; i < 17; i++)
            {
                var t = new TextBlock { Text = $"{i + 5}:00" };
                Grid.SetRow(t, i);
                OuterGrid.Children.Insert(0, t);
            }

            for (int i = 0; i < 6; i++)
            {
                var b = new Border();
                Grid.SetColumn(b, i);
                Grid.SetRowSpan(b, 17);
                OuterGrid.Children.Insert(0, b);
            }

            for (int i = 0; i < 17; i++)
            {
                var b = new Border();
                Grid.SetRow(b, i);
                Grid.SetColumnSpan(b, 6);
                OuterGrid.Children.Insert(0, b);
            }

        }
    }
}
