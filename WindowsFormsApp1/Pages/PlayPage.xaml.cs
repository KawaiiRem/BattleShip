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
using WindowsFormsApp1;

namespace BattleShip_DSA_Project
{
    /// <summary>
    /// Interaction logic for PlayPage.xaml
    /// </summary>
    public partial class PlayPage : Page
    {
        public PlayPage()
        {
            InitializeComponent();
        }

        private void btnBack(object sender, RoutedEventArgs e)
        {
            var window = (MainWindow)Application.Current.MainWindow;
            window.Content = (new MainPage());
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            Form1 form1 = new Form1();
            var window = (MainWindow)Application.Current.MainWindow;
            window.Close();
            form1.ShowDialog();
        }
    }
}
