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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Krumpussy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           
            r1.IsChecked = true;
            r2.IsChecked = false;
            r3.IsChecked = false;
            maximize.IsEnabled = false;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            ((Storyboard)TryFindResource("ExecutorIn")).Begin();
            ((Storyboard)TryFindResource("SettingOut")).Begin();
            ((Storyboard)TryFindResource("ScriptHubOut")).Begin();

        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            ((Storyboard)TryFindResource("ScriptHubIn")).Begin();
            ((Storyboard)TryFindResource("SettingOut")).Begin();
            ((Storyboard)TryFindResource("ExecuterOut")).Begin();
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            ((Storyboard)TryFindResource("SettingIn")).Begin();
            ((Storyboard)TryFindResource("ExecuterOut")).Begin();
            ((Storyboard)TryFindResource("ScriptHubOut")).Begin();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
