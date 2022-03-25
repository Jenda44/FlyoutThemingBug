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
using ControlzEx.Theming;
using MahApps.Metro;
using MahApps.Metro.Controls;

namespace FlyoutThemingBug
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            //Sets a theme upon loading the window
            ThemeManager.Current.ChangeTheme(Application.Current, RuntimeThemeGenerator.Current.GenerateRuntimeTheme("Dark", (Color)ColorConverter.ConvertFromString("#83003C")));
        }
        private void NewWindowBtn_Click(object sender, RoutedEventArgs e)
        {
            AnotherWindow window = new AnotherWindow();
            window.Show();
        }

        private void FlyoutBtn_Click(object sender, RoutedEventArgs e)
        {
            //This is an easy way to remedy the bug
            //MyFlyout.Theme = FlyoutTheme.Inverse;
            //MyFlyout.Theme = FlyoutTheme.Adapt;

            MyFlyout.IsOpen = MyFlyout.IsOpen != true;
        }

        
    }
}
