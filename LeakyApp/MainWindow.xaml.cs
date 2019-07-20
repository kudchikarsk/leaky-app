using System.Collections.Generic;
using System.Windows;

namespace LeakyApp
{
    public partial class MainWindow : Window
    {
        List<Clock> clocks = new List<Clock>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 50; i++)
            {
                var clock = new Clock();
                clock.Show();
                clocks.Add(clock);
            }
        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            foreach (var clock in clocks)
            {
                clock.Close();
            }
            clocks.Clear();
        }
    }
}
