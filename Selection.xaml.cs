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

        private void start_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Huracán_Button_Click(object sender, RoutedEventArgs e)
        {
            Huracán huracán = new Huracán();
            huracán.Show();
        }
    }
}
