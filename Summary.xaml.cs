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
using System.IO;

namespace Lamborghini_App
{
    /// <summary>
    /// Interaction logic for Summary.xaml
    /// </summary>
    public partial class Summary : Window
    {
        public Summary()
        {
            InitializeComponent();
            ReadFinalData();
        }



        public void ReadFinalData()
        {
            string filepath = @"C:\Users\Krisz\Desktop\Lamborghini Customization\Lamborghini App\Resources\FinalData.txt";

            foreach (var i in File.ReadAllLines(filepath))
            {
                string[] m = i.Split(';');

                FinalCarData.Source = new BitmapImage(new Uri(m[0], UriKind.Relative));
                FinalFuelData.Source = new BitmapImage(new Uri(m[1], UriKind.Relative));
                FinalTireData.Source = new BitmapImage(new Uri(m[2], UriKind.Relative));
                FinalLeatherData.Source = new BitmapImage(new Uri(m[3], UriKind.Relative));

                FinalPrice.Text = m[4];
            }

        }
        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            Selection selection = new Selection();
            selection.Show();
        }
        private void ButtonX_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}
