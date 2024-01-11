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

namespace BattleShip_DSA_Project.Pages
{
    /// <summary>
    /// Interaction logic for WindowSizePage.xaml
    /// </summary>
    public partial class WindowSizePage : Page
    {
        
        public WindowSizePage()
        {
            InitializeComponent();
            TheControl.SetInitials(Window.GetWindow(this));
        }

        private void exit_CLick(object sender, RoutedEventArgs e)
        {
            TheControl.Exit();
        }

        private void min_Click(object sender, RoutedEventArgs e)
        {
            TheControl.Minimize(Window.GetWindow(this));
        }

        private void Max_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            TheControl.DoMaximize(Window.GetWindow(this),btn);
        }

        private void full_Click(object sender, RoutedEventArgs e)
        {
            TheControl.DoFullScreen(Window.GetWindow(this));
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            var window = (MainWindow)Application.Current.MainWindow;
            window.Content = (new SettingPage());
        }
    }
}
