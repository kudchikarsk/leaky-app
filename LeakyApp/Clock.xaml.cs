using System;
using System.Windows;
using System.Windows.Threading;

namespace LeakyApp
{
    public partial class Clock : Window
    {
        DispatcherTimer timer;

        public Clock()
        {
            InitializeComponent();
            timer = new DispatcherTimer
            {
                Interval = new TimeSpan(0, 0, 1)
            };

            timer.Start();
            timer.Tick += UpdateTime;
        }

        private void UpdateTime(object sender, EventArgs e)
        {
            timerText.Content = DateTime.Now.ToLongTimeString();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            //Uncommnet below lines to stop memory leak

            //timer.Tick -= UpdateTime;
            //timer.Stop();
        }
    }
}
