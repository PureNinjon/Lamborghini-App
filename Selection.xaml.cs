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

namespace Lamborghini_App
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Selection : Window
    {
        public Selection()
        {
            InitializeComponent();
        }

        private void Huracán_Button_Click(object sender, RoutedEventArgs e)
        {
            Huracán huracán = new Huracán();
            huracán.Show();
        }
        private void Aventador_Button_Click(object sender, RoutedEventArgs e)
        {
            Aventador aventador = new Aventador();
            aventador.Show();
        }
        private void Urus_Button_Click(object sender, RoutedEventArgs e)
        {
            Urus urus = new Urus();
            urus.Show();
        }
        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
        private void ButtonX_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}
