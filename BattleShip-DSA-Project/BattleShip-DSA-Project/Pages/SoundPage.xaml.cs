using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BattleShip_DSA_Project.Pages
{
    /// <summary>
    /// Interaction logic for SoundPage.xaml
    /// </summary>
    public partial class SoundPage : Page
    {
        public SoundPage()
        {
            InitializeComponent();
        }
        MediaPlayer mediaPlayer = new MediaPlayer();
        string filename;

        private void BT_Click_Open(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                Multiselect = false,
                DefaultExt = ".mp3"
            };
            System.Windows.Forms.DialogResult dialogResult = fileDialog.ShowDialog();
            if (dialogResult == System.Windows.Forms.DialogResult.OK)
            {
                filename = fileDialog.FileName;
                TBFileName.Text = fileDialog.SafeFileName;
                mediaPlayer.Open(new Uri(filename));
            }
        }

        private void BT_Click_Play(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Play();
        }

        private void BT_Click_Pause(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Pause();
        }

        private void BT_Click_Stop(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Stop();
        }

        private void BT_Click_Back(object sender, RoutedEventArgs e)
        {
            var window = (MainWindow)System.Windows.Application.Current.MainWindow;
            window.Content = (new SettingPage());
        }
    }
}