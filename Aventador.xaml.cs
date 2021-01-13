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
    /// Interaction logic for Aventador.xaml
    /// </summary>
    public partial class Aventador : Window
    {
        public Aventador()
        {
            InitializeComponent();

        }

        public void OutputMaker()
        {
            List<string> output = new List<string>();
            output.Add($"{CarData};{FuelData};{TireData};{LeatherData};{PriceData}");

            string filepath = @"C:\Users\Krisz\Desktop\Lamborghini Customization\Lamborghini App\Resources\FinalData.txt";
            File.WriteAllLines(filepath, output);
        }


        int total = 0;

        int fuelTotal = 0;
        int tireTotal = 0;
        int leatherTotal = 0;


        string CarData = @"Resources\CarColors\UrusWhite.png";
        string FuelData;
        string TireData;
        string LeatherData = @"Resources\Leathers\WhiteLeather.png";
        string PriceData;

        private void SetTotal()
        {
            total = fuelTotal + tireTotal + leatherTotal;


            if (TotalAventador != null)
            {
                TotalAventador.Text = $"Total: $ {total}".Insert(12,",");
            }

            PriceData = TotalAventador.Text;

        }

        //Color Customization
        private void AventadorWhite_Click(object sender, RoutedEventArgs e)
        {
            AventadorPicture.Source = new BitmapImage(new Uri(@"Resources\CarColors\AventadorSVJWhite.png", UriKind.Relative));
            CarData = @"Resources\CarColors\AventadorSVJWhite.png";
            OutputMaker();
        }
        private void AventadorYellow_Click(object sender, RoutedEventArgs e)
        {
            AventadorPicture.Source = new BitmapImage(new Uri(@"Resources\CarColors\AventadorSVJYellow.png", UriKind.Relative));
            CarData = @"Resources\CarColors\AventadorSVJYellow.png";
            OutputMaker();
        }

        private void AventadorBlue_Click(object sender, RoutedEventArgs e)
        {
            AventadorPicture.Source = new BitmapImage(new Uri(@"Resources\CarColors\AventadorSVJGreen.png", UriKind.Relative));
            CarData = @"Resources\CarColors\AventadorSVJGreen.png";
            OutputMaker();
        }

        private void AventadorBlack_Click(object sender, RoutedEventArgs e)
        {
            AventadorPicture.Source = new BitmapImage(new Uri(@"Resources\CarColors\AventadorSVJRed.png", UriKind.Relative));
            CarData = @"Resources\CarColors\AventadorSVJRed.png";
            OutputMaker();

        }

        //Fuel Total Counter
        private void TotalAventador_Loaded(object sender, RoutedEventArgs e)
        {
            SetTotal();
        }

        private void Gascar_Checked(object sender, RoutedEventArgs e)
        {
            fuelTotal = 229428;
            SetTotal();
            FuelData = Gascar.Content.ToString();
            OutputMaker();

        }

        private void ElcerticCar_Checked(object sender, RoutedEventArgs e)
        {
            fuelTotal = 340160;
            SetTotal();
            FuelData = ElcerticCar.Content.ToString();
            OutputMaker();
        }


        //Tire Total Counter
        private void Tire1RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            tireTotal = 990;
            SetTotal();

            TireData = Tire1RadioButton.Content.ToString();
            OutputMaker();

        }

        private void Tire2RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            tireTotal = 850;
            SetTotal();
            TireData = Tire2RadioButton.Content.ToString();
            OutputMaker();

        }

        private void Tire3RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            tireTotal = 690;
            SetTotal();
            TireData = Tire3RadioButton.Content.ToString();
            OutputMaker();

        }

        private void Tire4RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            tireTotal = 580;
            SetTotal();
            TireData = Tire4RadioButton.Content.ToString();
            OutputMaker();

        }


        //Leather Total Counter
        private void WhiteLeatherRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            leatherTotal = 290;
            SetTotal();

            if (WhiteLeatherRadioButton.Content != null) LeatherData = WhiteLeatherRadioButton.Content.ToString();
            OutputMaker();


        }

        private void BlueLeatherRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            leatherTotal = 420;
            SetTotal();
            LeatherData = BlueLeatherRadioButton.Content.ToString();
            OutputMaker();

        }

        private void RedLeatherRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            leatherTotal = 399;
            SetTotal();
            LeatherData = RedLeatherRadioButton.Content.ToString();
            OutputMaker();

        }

        private void BlackLeatherRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            leatherTotal = 990;
            SetTotal();
            LeatherData = BlackLeatherRadioButton.Content.ToString();
            OutputMaker();

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

        private void Finalization_Button_Click(object sender, RoutedEventArgs e)
        {
            Summary summary = new Summary();
            summary.Show();
        }

    }

}
