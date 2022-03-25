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
using System.Windows.Shapes;
using ControlzEx.Theming;
using MahApps.Metro;
using MahApps.Metro.Controls;

namespace FlyoutThemingBug
{
    /// <summary>
    /// Interakční logika pro AnotherWindow.xaml
    /// </summary>
    public partial class AnotherWindow : MetroWindow
    {
        public AnotherWindow()
        {
            InitializeComponent();
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            //sets a nice chartreause colour for good measure
            ThemeManager.Current.ChangeTheme(this, RuntimeThemeGenerator.Current.GenerateRuntimeTheme("Light", (Color)ColorConverter.ConvertFromString("#7FFF00")));
        }
    }
}
