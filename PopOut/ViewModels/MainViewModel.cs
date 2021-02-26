using Caliburn.Micro;
using System;
using System.Windows.Threading;
using Tulpep.NotificationWindow;

namespace PopOut.ViewModels
{
    public class MainViewModel : Screen
    {

        System.Timers.Timer timer;

        public MainViewModel(DateTime alarmTime)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;

        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            DateTime userTime = dateTimePicker.Value;
        }

        public void PopUpBtn()
        {
            PopupNotifier popup = new PopupNotifier();
            popup.Image = Properties.Resources.information_button;
            popup.TitleText = "Notification";
            popup.ContentText = "Its already 10:00 AM!";
            popup.Popup();
        }
    }
}
