using System;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;

namespace MediaKeys
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PreviousButtonClick(object sender, EventArgs e)
        {
            PressButton(Keys.MediaPreviousTrack);
        }

        private void PlayPauseButtonClick(object sender, EventArgs e)
        {
            PressButton(Keys.MediaPlayPause);
        }

        private void ForwardButtonClick(object sender, EventArgs e)
        {
            PressButton(Keys.MediaNextTrack);
        }

        private void MuteUnmuteButtonClick(object sender, EventArgs e)
        {
            PressButton(Keys.VolumeMute);
        }

        private void ExitButtonClick(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MinimizeButtonClick(object sender, EventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                DragMove();
            }
        }

        private static void PressButton(Keys key)
        {
            SendInput.Instance.KeyDown(key).KeyUp(key).Flush();
        }
    }
}
